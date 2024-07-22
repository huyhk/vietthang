using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using VNS.Windows.Controls;
using VNS.ERP.Data;
using VNS.ERP.Data.Sales;
using VNS.Windows;
using VNS.Common;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections;

namespace VNS.ERP.GUI.Sales
{
    public partial class UCCustomerSpecialPrices : VNS.Windows.Controls.EditControlBase
    {
        public UCCustomerSpecialPrices()
        {
            InitializeComponent();
        }

        protected override void BindData()
        {
            CustomerSpecialPrice customer = (dataSource as CustomerSpecialPrice);
            if (this.DataSource != null)
            {
                this.lookUpSubject.EditValue = customer.SubjectCode;
                this.txtStartDate.DateTime = customer.StartDate;
                this.txtDescription.Text = customer.Description;
                this.gridControl1.DataSource = customer.ListCustomerSpecialPriceDetail;
            }

            base.BindData();
        }
        protected override int ValidateData()
        {
            this.gridView1.CloseEditor();

            ListBase<CustomerSpecialPriceDetail> lst = (this.DataSource as CustomerSpecialPrice).ListCustomerSpecialPriceDetail;
            for (int i = lst.Count - 1; i >= 0; i--)
            {
                if (lst[i].ItemCode == string.Empty)
                {
                    lst.RemoveAt(i);
                }
            }
            if (this.lookUpSubject.EditValue.ToString() == string.Empty)
            {
                this.lookUpSubject.Focus();
                return -1;
            }
            return 0;
        }
        protected override void AssignData()
        {
            if (dataSource == null) dataSource = new CustomerSpecialPrice();
            CustomerSpecialPrice customer = (dataSource as CustomerSpecialPrice);
            customer.SubjectCode = this.lookUpSubject.EditValue.ToString();
            customer.StartDate = this.txtStartDate.DateTime;
            customer.Description = this.txtDescription.Text;
            if (this.EditMode == VNS.Windows.FormEditMode.ADD)
            {

                customer.UserCreated = Contexts.CurrentUser.LoginName;
                customer.DateCreated = DateTime.Now;
            }
            customer.UserUpdated = Contexts.CurrentUser.LoginName;
            customer.DateUpdated = DateTime.Now;
            base.AssignData();
        }
        protected override void InitDataObject()
        {
            if (!this.DesignMode)
            {
                this.lookUpSubject.Properties.DataSource = new CustomerBLL().GetAll();
                this.repLookUpItemCode.DataSource = new ItemBLL().GetbyItemtype((int)enumItemType.Product);
                this.repLookUpItemName.DataSource = new ItemBLL().GetbyItemtype((int)enumItemType.Product);
            }
            base.InitDataObject();
        }
        public override void RefreshControl()
        {
            bool view = (this.editMode == FormEditMode.VIEW);
            this.lookUpSubject.Properties.ReadOnly = view;
            this.txtStartDate.Properties.ReadOnly = view;
            this.txtDescription.Properties.ReadOnly = view;
            this.gridView1.OptionsBehavior.Editable = !view;

            if (this.editMode == FormEditMode.VIEW)
                gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            else
                gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            //if (this.editMode == FormEditMode.ADD)
            //    gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

            base.RefreshControl();
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.editMode == FormEditMode.VIEW)
                return;

            if (this.gridView1.RowCount > 0)
            {
                if (e.KeyCode == Keys.Delete)
                    this.gridView1.DeleteRow(this.gridView1.FocusedRowHandle);
            }


            if (e.KeyCode == Keys.Insert)
            {
                if (this.gridView1.FocusedRowHandle >= 0)
                {
                    System.Type type = (gridView1.DataSource as IList)[0].GetType();
                    object obj = Activator.CreateInstance(type);
                    (gridView1.DataSource as IList).Insert(this.gridView1.FocusedRowHandle, obj);
                }
            }
        }
    }
}

