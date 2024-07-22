using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.ERP.Data;
using VNS.Windows.Forms;
using VNS.Windows;
using System.Collections;

namespace VNS.ERP.GUI
{
    public partial class UCExchangeResult : EditControlBase
    {
        public UCExchangeResult()
        {
            InitializeComponent();

        }
        private VesselExchangeContractBLL vesselExchangeContract=new VesselExchangeContractBLL();
 //       private ExchangeResultBLL vesselExchangeContract = new VesselTransactionBLL();

        protected override int ValidateData()
        {
            
            if (this.lkExchangeSubjectCode.EditValue == null || this.lkExchangeSubjectCode.EditValue.ToString() == string.Empty)
                return -1;
            
            
            return base.ValidateData();
        }
        protected override void AssignData()
        {
            if (this.DataSource == null)
                DataSource = new ExchangeResult();
            (this.DataSource as ExchangeResult).ExchangeSubjectCode = this.lkExchangeSubjectCode.EditValue.ToString();
            (this.DataSource as ExchangeResult).VesselExchangeContractNo = this.btnEditVesselExchangeContractNo.EditValue.ToString();
            (this.DataSource as ExchangeResult).Description = this.txtChuThich.Text;
            (this.DataSource as ExchangeResult).FromDate = this.txtFromDate.DateTime;
            (this.DataSource as ExchangeResult).ToDate = this.txtToDate.DateTime;

            if (this.EditMode == VNS.Windows.FormEditMode.ADD)
            {
                (dataSource as ExchangeResult).UserCreated = Contexts.CurrentUser.LoginName;
                (dataSource as ExchangeResult).DateCreated = DateTime.Now;
            }
            (dataSource as ExchangeResult).UserUpdated = Contexts.CurrentUser.LoginName;
            (dataSource as ExchangeResult).DateUpdated = DateTime.Now;
            base.AssignData();
        }
        protected override void BindData()
        {
            if (DataSource != null)
            {
                this.txtChuThich.Text = (this.DataSource as ExchangeResult).Description;
            
                this.btnEditVesselExchangeContractNo.EditValue = (this.DataSource as ExchangeResult).VesselExchangeContractNo;
                this.lkExchangeSubjectCode.EditValue = (this.DataSource as ExchangeResult).ExchangeSubjectCode;
                this.gridControl1.DataSource = (this.DataSource as ExchangeResult).ListExchangeResultDetail;
            }
                    base.BindData();
        }
        protected override void InitDataObject()
        {
         
            if (!DesignMode)
            {
                this.lkExchangeSubjectCode.Properties.DataSource = new VendorBLL().GetForVanchuyen(); //new SubjectBLL().GetKhoVan();
                this.replkItemCode.DataSource = new ItemBLL().GetAll();
                this.replkStockCode.DataSource = new StockBLL().GetAll();
                this.replkTransportTypeCode.DataSource = new TransportTypeBLL().GetAll();
                this.replkTransportItemTypeCode.DataSource = new TransportItemTypeBLL().GetAll();
                
            }
            base.InitDataObject();
        }
        public override void RefreshControl()
        {
            bool viewMode = this.EditMode == FormEditMode.VIEW;
            this.lkExchangeSubjectCode.Properties.ReadOnly = viewMode;
            this.btnEditVesselExchangeContractNo.Properties.ReadOnly = viewMode;
            this.gridView1.OptionsBehavior.Editable = !viewMode;
            this.txtChuThich.Properties.ReadOnly = viewMode;
            this.txtFromDate.Properties.ReadOnly = viewMode;
            this.txtToDate.Properties.ReadOnly = viewMode;
            gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;

            if (this.EditMode == FormEditMode.ADD)
            {
                //this.gridView1.OptionsBehavior.Editable = true;
                this.txtDonvigiaonhan.Properties.ReadOnly = true;
                gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;


            }
            else
            {
              //  this.gridView1.OptionsBehavior.Editable = true;
                this.txtDonvigiaonhan.Properties.ReadOnly = true;
                gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            }

            base.RefreshControl();

        }       
       //public override void RefreshControl()
       // {

       //     bool viewMode = this.EditMode == FormEditMode.VIEW;
       //     this.lkExchangeSubjectCode.Properties.ReadOnly = viewMode;
       //     this.btnEditVesselExchangeContractNo.Properties.ReadOnly = viewMode;
       //     this.gridView1.OptionsBehavior.Editable = !viewMode;
       //     this.txtChuThich.Properties.ReadOnly = viewMode;
       //     //this.ButtonEditVesselTransactionNo.Enabled = !viewMode ;
       //     gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;

       //     if (this.EditMode == FormEditMode.ADD)
       //     {
       //         this.txtDonvigiaonhan.Properties.ReadOnly = true;
       //         gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

               
       //     }
       //     else 
       //     {
       //         this.txtDonvigiaonhan.Properties.ReadOnly = true;
       //         gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
       //     }

       //     base.RefreshControl();
       // }
     
      
        private void btnEditVesselExchangeContractNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(this.lkExchangeSubjectCode.EditValue!=null&&this.lkExchangeSubjectCode.EditValue.ToString()!=string.Empty)
            {
                string[] fields ={ "ContractNo", "ContractDate", "VesselName", "VendorName", "Description" };
                string[] header ={ "Số hợp đồng", "Ngày", "Tên tàu", "Nhà cung cấp", "Ghi chú" };
                //PurchaseContract dr = (FormSearch.ShowSearch((this.repItemButtonEditContractNo..Properties.DataSource), fields, header) as PurchaseContract);
                DataRowView dr = (FormSearch.ShowSearch(this.vesselExchangeContract.GetSearch(this.lkExchangeSubjectCode.EditValue.ToString()), fields, header) as DataRowView);
                if (this.editMode != FormEditMode.VIEW)
                {
                    if (dr != null)
                    {
                 //       this.gridView1.SetRowCellValue(this.gridView1.FocusedRowHandle, colContracNo, dr["ContractNo"].ToString());
                        //this.gridView1.SetRowCellValue(this.gridView3.FocusedRowHandle, colMasothue, dr["TaxCode"].ToString());
                        this.btnEditVesselExchangeContractNo.EditValue = dr["ContractNo"].ToString();
                    }
                }
            }
        }

        private void lkExchangeSubjectCode_EditValueChanged(object sender, EventArgs e)
        {
            if (this.lkExchangeSubjectCode.EditValue != null && this.lkExchangeSubjectCode.EditValue.ToString() != string.Empty)
            {
                this.txtDonvigiaonhan.Text = lkExchangeSubjectCode.GetColumnValue("SubjectName").ToString();

            }
        }

        private void gridView1_GotFocus(object sender, EventArgs e)
        {
            if (gridView1.DataRowCount == 0)
                gridView1.MoveFirst();
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
