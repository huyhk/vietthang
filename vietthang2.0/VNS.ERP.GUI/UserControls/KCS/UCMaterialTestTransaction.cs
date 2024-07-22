using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.KCS;
using VNS.Common;
using System.Collections;

namespace VNS.ERP.GUI.KCS
{
    public partial class UCMaterialTestTransaction : VNS.Windows.Controls.EditControlBase
    {
        private string stockCode = string.Empty;
        public string StockCode
        {
            get { return stockCode; }
            set { stockCode = value; }
        }
        public UCMaterialTestTransaction()
        {
            InitializeComponent();
            this.repTxtPercent.Mask.EditMask = ModuleKCS.CONFIG_TECH_PERCENTFORMAT;
        }

        protected override void BindData()
        {
            if (DataSource != null)
            {
                MaterialTestTransaction t = this.DataSource as MaterialTestTransaction;
                dateEditTransaction.DateTime = t.TestTransactionDate;
                
                if (t.TestTransactionNo == string.Empty && this.EditMode == VNS.Windows.FormEditMode.ADD)
                {
                    //t.TestTransactionNo = new MaterialTestTransactionBLL().GetMaxTestTransactionNo(this.stockCode);
                }
                txtTestTransactionNo.Text = t.TestTransactionNo;
                //lookUpBranchCode.EditValue = this.branchCode;
                lookUpStock.EditValue = this.stockCode; //t.StockCode;
                lookUpItem.EditValue = t.ItemCode;
                lookUpVendor.EditValue = t.SubjectCode;
                txtLocation.Text = t.Location;
                //dateEditStart.DateTime = t.StartDate;
                //dateEditEnd.DateTime = t.EndDate;
                txtDescription.Text = t.Description;
                gridControl1.DataSource = t.Detail;
                //gridControl2.DataSource = t.DetailLAB;
            }
            base.BindData();
        }
        //override AddNew
        protected override int ValidateData()
        {
            txtTestTransactionNo.Text = txtTestTransactionNo.Text.Trim();
            txtLocation.Text = txtLocation.Text.Trim();
            txtPTVC.Text = txtPTVC.Text.Trim();
            txtDescription.Text = txtDescription.Text.Trim();
            //if (lookUpBranchCode.EditValue == null || lookUpBranchCode.EditValue.ToString() == string.Empty)
            //{
            //    lookUpBranchCode.Focus();
            //    return -1;
            //}
            if (lookUpItem.EditValue == null || lookUpItem.EditValue.ToString() == string.Empty)
            {
                lookUpItem.Focus();
                return -2;
            }
            //if (lookUpVendor.EditValue == null || lookUpVendor.EditValue.ToString() == string.Empty)
            //{
            //    lookUpVendor.Focus();
            //    return -3;
            //}
            if (lookUpStock.EditValue == null || lookUpStock.EditValue.ToString() == string.Empty)
            {
                lookUpStock.Focus();
                return -4;
            }
            MaterialTestTransaction t = this.DataSource as MaterialTestTransaction;
            foreach (MaterialTestTransactionDetail tTechGroup1 in t.Detail)
            {
                if (tTechGroup1.TechCode == string.Empty)
                {
                    gridControl1.Focus();
                    return -5;
                }
                MaterialTestTransactionDetail d = t.Detail.Search("TechCode", tTechGroup1.TechCode);
                if (d != null && d != tTechGroup1)
                {
                    gridControl1.Focus();
                    return -6;
                }
            }
            return base.ValidateData();
        }
        protected override void AssignData()
        {
            if (this.DataSource == null) this.DataSource = new MaterialTestTransaction();
            MaterialTestTransaction t = this.DataSource as MaterialTestTransaction;
            t.TestTransactionDate = dateEditTransaction.DateTime;
            t.TestTransactionNo = txtTestTransactionNo.Text;
            //t.BranchCode = lookUpBranchCode.EditValue.ToString();
            t.StockCode = lookUpStock.EditValue.ToString();
            t.ItemCode = lookUpItem.EditValue.ToString();
            t.Location = txtLocation.Text;
            t.SubjectCode = lookUpVendor.EditValue.ToString();
            t.PTVC = txtPTVC.Text;
            //t.StartDate = dateEditStart.DateTime;
            //t.EndDate = dateEditEnd.DateTime;
            t.Description = txtDescription.Text;
            
            if (this.EditMode == VNS.Windows.FormEditMode.ADD)
            {
                t.UserCreated = Contexts.CurrentUser.LoginName;
                t.DateCreated = DateTime.Now;
            }
            t.UserUpdated = Contexts.CurrentUser.LoginName;
            t.DateUpdated = DateTime.Now;
            base.AssignData();
        }
        public override void RefreshControl()
        {
            bool viewMode = this.EditMode == VNS.Windows.FormEditMode.VIEW;
            dateEditTransaction.Properties.ReadOnly = viewMode;
            txtTestTransactionNo.Properties.ReadOnly = viewMode;
            //lookUpBranchCode.Properties.ReadOnly = true;
            lookUpStock.Properties.ReadOnly = true;
            lookUpItem.Properties.ReadOnly = viewMode;
            txtLocation.Properties.ReadOnly = viewMode;
            lookUpVendor.Properties.ReadOnly = viewMode;
            txtPTVC.Properties.ReadOnly = viewMode;
            //dateEditStart.Properties.ReadOnly = viewMode;
            //dateEditEnd.Properties.ReadOnly = viewMode;
            txtDescription.Properties.ReadOnly = viewMode;
            gridView1.OptionsBehavior.Editable = !viewMode;
            if (!viewMode)
            {
                gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            }
            else
            {
                gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            }
            if (this.DataSource == null)
            {
                txtTestTransactionNo.Text = string.Empty;
                txtLocation.Text = string.Empty;
                txtPTVC.Text = string.Empty;
                txtDescription.Text = string.Empty;
            }

            if (editMode == VNS.Windows.FormEditMode.ADD)
            {
                txtTestTransactionNo.Focus();
            }

            base.RefreshControl();
        }
        protected override void InitDataObject()
        {
            if (!this.DesignMode)
            {
                //lookUpBranchCode.Properties.DataSource = new BranchBLL().GetAll();
                lookUpStock.Properties.DataSource = new StockBLL().GetAll();
                lookUpItem.Properties.DataSource = new ItemBLL().GetListMaterial();
                ListBase<Vendor> lstVendor = new VendorBLL().GetForPurchase();
                lstVendor.Insert(0, new Vendor());
                lookUpVendor.Properties.DataSource = lstVendor;
                //repLookUpTechCode.DataSource = new TechnicalTestBLL().GetAll();
                reLookUpTechCode.DataSource = new TechnicalTestBLL().GetAll();
            }
            base.InitDataObject();
        }

        private void gridView1_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column.FieldName != "Result")
                return;
            //if (e.RowHandle >= 0)
            //{
                object o = gridView1.GetRow(e.RowHandle);
                if (o == null)
                    return;
                string techCode = (o as MaterialTestTransactionDetail).TechCode;
                TechnicalTest tt = (reLookUpTechCode.DataSource as ListBase<TechnicalTest>).Search("TechCode", techCode);
                if (tt != null)
                {
                    if (tt.ResultType == enumResultTypeTechnicalTest.Decimal.ToString())
                    {
                        if (("Result").Contains(e.Column.FieldName))
                            e.RepositoryItem = repTxtDecimal;
                    }
                    if (tt.ResultType == enumResultTypeTechnicalTest.Text.ToString())
                    {
                        if (("Result").Contains(e.Column.FieldName))
                            e.RepositoryItem = repTxtString;
                    }
                    if (tt.ResultType == enumResultTypeTechnicalTest.Percent.ToString())
                    {
                        if (("Result").Contains(e.Column.FieldName))
                            e.RepositoryItem = repTxtPercent;
                    }
                    
                }
            //}
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

        private void lookUpVendor_EditValueChanged(object sender, EventArgs e)
        {
            this.txtVendorName.EditValue = this.lookUpVendor.GetColumnValue("SubjectName");
        }

        private void gridView1_GotFocus(object sender, EventArgs e)
        {
            if (gridView1.DataRowCount == 0)
                gridView1.MoveFirst();
        }

    }
}

