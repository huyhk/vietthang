using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.ERP.Data;
using VNS.Windows;
using System.Collections;
using VNS.Windows.Forms;
using VNS.Common;

namespace VNS.ERP.GUI.Transports
{
    public partial class UCVesselTransactions : EditControlBase
    {
        private PurchaseContractBLL purchaseContractBLL=new PurchaseContractBLL();
        public UCVesselTransactions()
        {
            InitializeComponent();
        }
        //private Guid _contractID;

        //public Guid ContractID
        //{
        //    get { return _contractID; }
        //    set { _contractID = value; }
        //}

        protected override void AssignData()
        {

            if (dataSource == null)
                dataSource = new VesselTransaction();

            (dataSource as VesselTransaction).VendorCode = lookUpEditVendorCode.EditValue.ToString();
            (dataSource as VesselTransaction).VesselCode = lookUpEditVesselCode.EditValue.ToString();
            (dataSource as VesselTransaction).EstimateDate =txtEstimateDate.DateTime;
            (dataSource as VesselTransaction).Description = txtDienGiai.Text;
            (dataSource as VesselTransaction).StartPlace = this.txtStartPlace.Text;
            (dataSource as VesselTransaction).EndPlace = this.txtEndPlace.Text;
            (dataSource as VesselTransaction).TransactionNo = this.txtTransactionNo.Text;
            (dataSource as VesselTransaction).TransactionDate = this.txtTransactionDate.DateTime;

            if (this.EditMode == VNS.Windows.FormEditMode.ADD)
            {

                (dataSource as VesselTransaction).UserCreated = Contexts.CurrentUser.LoginName;
                (dataSource as VesselTransaction).DateCreated = DateTime.Now;
            }
            (dataSource as VesselTransaction).UserUpdated = Contexts.CurrentUser.LoginName;
            (dataSource as VesselTransaction).DateUpdated = DateTime.Now;
            
            base.AssignData();
        }
        protected override void BindData()
        {
            if (this.dataSource != null)
            {

                this.lookUpEditVendorCode.EditValue = (dataSource as VesselTransaction).VendorCode;
                this.lookUpEditVesselCode.EditValue = (dataSource as VesselTransaction).VesselCode;
                this.txtDienGiai.EditValue = (dataSource as VesselTransaction).Description;
                this.txtEndPlace.Text = (dataSource as VesselTransaction).EndPlace;
                this.txtStartPlace.Text = (dataSource as VesselTransaction).StartPlace;
                this.txtTransactionNo.Text = (dataSource as VesselTransaction).TransactionNo;
                this.txtTransactionDate.EditValue = (dataSource as VesselTransaction).TransactionDate;

                gridControl1.DataSource = (DataSource as VesselTransaction).DetailInvoice;
              
                //     base.BindData();
            }
            base.BindData();
        }
        protected override void InitDataObject()
        {
            if (!DesignMode)
            {
                lookUpEditVendorCode.Properties.DataSource = new VendorBLL().GetForPurchase();
                lookUpEditVesselCode.Properties.DataSource = new VesselBLL().GetAll();
                replkCurrencyCode.DataSource = new CurrencyBL().GetAll();
                this.replkItemCode.DataSource = new ItemBLL().GetAll();
                //tien te
                ListBase<Currency> ds = new CurrencyBL().GetAll();
                Currency t = new Currency();
                t.CurrencyCode = string.Empty;
                ds.Insert(0, t);
                this.replookupCurrencyCode .DataSource = ds;
               // replookupCurrencyCode.indes = 0;
            }
            base.InitDataObject();
        }
        protected override int ValidateData()
        {
            if (this.txtTransactionNo.Text == string.Empty)
            {
                return -1;
            }
            if (lookUpEditVesselCode.EditValue == null||lookUpEditVesselCode.EditValue.ToString()==string.Empty)
            {
                return -2;
            }

            if (lookUpEditVendorCode.EditValue == null || lookUpEditVendorCode.EditValue.ToString()==string.Empty)
            {
                return -3;
            }

            if (this.txtStartPlace.Text == "")
            {
                return -4;
            }
            if (this.txtEndPlace.Text == "")
            {
                return -5;
            }
            
            //if (txtStartPlace.Text = "")
            //    return -3;
            //if (txtEndPlace.Text = "")
            //    return -4;



            return base.ValidateData();
        }

        public override void RefreshControl()
        {
           
            if (this.editMode == FormEditMode.ADD)
            {
               
                this.lookUpEditVendorCode.Properties.ReadOnly = false;
                this.lookUpEditVesselCode.Properties.ReadOnly = false;
                this.txtDienGiai.Properties.ReadOnly = false;
                this.txtEndPlace.Properties.ReadOnly = false;
                this.txtStartPlace.Properties.ReadOnly = false;
                this.gridView1.OptionsBehavior.Editable = true;
                this.txtTransactionNo.Properties.ReadOnly = false;
                this.txtTransactionDate.Properties.ReadOnly = false;
                this.txtEstimateDate.Properties.ReadOnly = false;
                this.gridView2.OptionsBehavior.Editable = true;
                //colAmount.ReadOnly = true;
                //colTotalAmount.ReadOnly = true;
                gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
                gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
                
            }
            else if( this.editMode == FormEditMode.EDIT)
            {
                this.lookUpEditVendorCode.Properties.ReadOnly = false;
                this.lookUpEditVesselCode.Properties.ReadOnly = false;
                this.txtDienGiai.Properties.ReadOnly = false;
                this.txtEndPlace.Properties.ReadOnly = false;
                this.txtStartPlace.Properties.ReadOnly = false;
                this.gridView1.OptionsBehavior.Editable = true;
                this.gridView2.OptionsBehavior.Editable = true;
                this.txtEstimateDate.Properties.ReadOnly = true;
                this.txtTransactionNo.Properties.ReadOnly = false;
                this.txtTransactionDate.Properties.ReadOnly = false;
                //colAmount.ReadOnly = true;
                //colTotalAmount.ReadOnly = true;\
                gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
                gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            }
            else
            {
                 this.lookUpEditVendorCode.Properties.ReadOnly = true;
                this.lookUpEditVesselCode.Properties.ReadOnly = true;
                this.txtDienGiai.Properties.ReadOnly = true;
                this.txtEndPlace.Properties.ReadOnly = true;
                this.txtStartPlace.Properties.ReadOnly = true;
                this.gridView1.OptionsBehavior.Editable = false;
                this.gridView2.OptionsBehavior.Editable = false;
                this.txtTransactionNo.Properties.ReadOnly = true;
                this.txtTransactionDate.Properties.ReadOnly = true;
                //colAmount.ReadOnly = true;
                //colTotalAmount.ReadOnly = true;
                this.txtEstimateDate.Properties.ReadOnly = true;
                gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None ;
                gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            }
            //if (this.DataSource == null)
            //{
            //    txtDienGiai.Text = "";
            //    txtContractNo.Text = "";
            //    gridControl1.DataSource = null;
            //}
            base.RefreshControl();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FormListPurchaseContract f = new FormListPurchaseContract();
            f.ShowDialog();
            
                
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lookUpEditVendorCode_EditValueChanged(object sender, EventArgs e)
        {
            if (this.lookUpEditVendorCode.EditValue != null&&this.lookUpEditVendorCode.EditValue.ToString()!=string.Empty)
            {
                this.txtVendor.Text = lookUpEditVendorCode.GetColumnValue("SubjectName").ToString();

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

        private void gridView1_GotFocus(object sender, EventArgs e)
        {
            if (gridView1.DataRowCount == 0)
                gridView1.MoveFirst();

        }

        private void gridView2_GotFocus(object sender, EventArgs e)
        {

            if (gridView1.DataRowCount == 0)
                gridView1.MoveFirst();

        }

        private void gridView2_KeyDown(object sender, KeyEventArgs e)
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

        private void repItemButtonEditContractNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
             string vendorcode="";

             if (lookUpEditVendorCode.EditValue != null && lookUpEditVendorCode.EditValue.ToString() != string.Empty)
             {
                 vendorcode = this.lookUpEditVendorCode.EditValue.ToString();
             }
            string[] fields ={ "ContractNo", "ContractDate", "Description"};
            string[] header ={ "Số hợp đồng", "Ngày", "Diễn giải"};
            //PurchaseContract dr = (FormSearch.ShowSearch((this.repItemButtonEditContractNo..Properties.DataSource), fields, header) as PurchaseContract);
            DataRowView dr = (FormSearch.ShowSearch(purchaseContractBLL.GetByVendor(vendorcode), fields, header) as DataRowView);
            if (this.editMode != FormEditMode.VIEW)
            {
                if (dr != null)
                {
                    this.gridView1.SetRowCellValue(this.gridView1.FocusedRowHandle, colContracNo, dr["ContractNo"].ToString());
                    //this.gridView1.SetRowCellValue(this.gridView3.FocusedRowHandle, colMasothue, dr["TaxCode"].ToString());
                }
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.IsNewItemRow(e.FocusedRowHandle))
            {
                gridView1.AddNewRow();
                gridView1.RefreshRow(e.FocusedRowHandle);
            }
        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // UCVesselTransactions
        //    // 
        //    this.Name = "UCVesselTransactions";
        //    this.Size = new System.Drawing.Size(660, 394);
        //    this.ResumeLayout(false);

        //}

        
    }
}
