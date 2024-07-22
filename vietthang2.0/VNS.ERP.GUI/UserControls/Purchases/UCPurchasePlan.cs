using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.ERP.Data;
using VNS.Windows;
using VNS.Common;
using System.Runtime.Remoting.Contexts;
using System.Collections;
using VNS.Windows.Forms;
using VNS.Utils;

namespace VNS.ERP.GUI
{
    public partial class UCPurchasePlan : VNS.Windows.Controls.EditControlBase
    {
        public UCPurchasePlan()
        {
            InitializeComponent();
        }

        protected override void BindData()
        {
            PurchasePlan obj = (DataSource as PurchasePlan);
            if (DataSource != null)
            {
                TxtYearNo.EditValue = Convert.ToInt32(obj.YearNo);
                numUpDnMonthNo.Value = Convert.ToInt32(obj.MonthNo);
                txtDescription.Text = obj.Description;
                this.gridControl1.DataSource = obj.ListPurchasePlanDetail;
            }
            base.BindData();
        }
        protected override void AssignData()
        {
            if (this.DataSource == null) this.DataSource = new PurchasePlan();
            PurchasePlan obj = (DataSource as PurchasePlan);
            obj.YearNo = Convert.ToInt32(TxtYearNo.EditValue);
            obj.MonthNo = Convert.ToInt32(numUpDnMonthNo.Value);
            obj.Description = txtDescription.Text;
            if (this.EditMode == VNS.Windows.FormEditMode.ADD)
            {
                obj.UserCreated = Contexts.CurrentUser.LoginName;
            }
            obj.UserUpdated = Contexts.CurrentUser.LoginName;
            base.AssignData();
        }
        protected override int ValidateData()
        {
            ListBase<PurchasePlanDetail> lstDetail = (gridControl1.DataSource as ListBase<PurchasePlanDetail>);
            foreach (PurchasePlanDetail pm in lstDetail)
            {
                if (pm.ItemCode.ToString() == "")
                {
                    return -2;
                }
            }
            txtDescription.Text = txtDescription.Text.Trim();
            TxtYearNo.Text = TxtYearNo.Text.Trim();
            if (TxtYearNo.Text == "")
            {
                TxtYearNo.Focus();
                return -1;
            }
            return base.ValidateData();
        }
        public override void RefreshControl()
        {
            bool viewMode = this.EditMode == VNS.Windows.FormEditMode.VIEW;
            numUpDnMonthNo.Properties.ReadOnly = viewMode;
            TxtYearNo.Properties.ReadOnly = viewMode;
            txtDescription.Properties.ReadOnly = viewMode;
            gridView1.OptionsBehavior.Editable = !viewMode;
            if (this.EditMode == VNS.Windows.FormEditMode.ADD)
                gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            if (this.EditMode == VNS.Windows.FormEditMode.EDIT)
                gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            if (this.EditMode == VNS.Windows.FormEditMode.VIEW)
                gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;

            base.RefreshControl();
        }
        protected override void InitDataObject()
        {
            base.InitDataObject();
            if (!this.DesignMode)
            {
                ListBase<Item> lst3 = new ItemBLL().GetAll();
                this.repLookUpItemCode.DataSource = lst3;
                this.repLookUpItemName.DataSource = lst3;
            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.gridView1.FocusedRowHandle >= 0 && this.gridView1.OptionsBehavior.Editable == true)
            {
                if (e.KeyCode == Keys.Delete)
                    this.gridView1.DeleteRow(this.gridView1.FocusedRowHandle);
            }
            if (e.KeyCode == Keys.Insert && this.gridView1.OptionsBehavior.Editable == true)
            {
                if (this.gridView1.FocusedRowHandle < 0)
                { }
                else
                {
                    System.Type type = (gridView1.DataSource as IList)[0].GetType();
                    object obj = Activator.CreateInstance(type);
                    (gridView1.DataSource as IList).Insert(this.gridView1.FocusedRowHandle, obj);
                }
            }
        }
    }
}

