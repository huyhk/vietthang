using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.ERP.Data;
using System.Collections;
using VNS.Windows.Forms;
using VNS.Windows;
using VNS.Common;

namespace VNS.ERP.GUI.Transports
{
    public partial class UCVesselExchangeContract : EditControlBase
    {
        public UCVesselExchangeContract()
        {
            InitializeComponent();
            //this.txtGiaphatluusalan.Properties.Mask.EditMask = AppConfigs.CONFIG_QUANTITYMASK;
            //this.txtNangsuatbocdo.Properties.Mask.EditMask = AppConfigs.CONFIG_QUANTITYMASK;
        }
        private VesselTransactionBLL vesselExchangeContract = new VesselTransactionBLL();

        protected override int ValidateData()
        {
            if (this.txtContractNo.Text ==string.Empty)
                return -1;
            if (this.lookUpExchangeSubjectCode.EditValue == null || this.lookUpExchangeSubjectCode.EditValue.ToString() == string.Empty)
                return -2;
            //if (this.ButtonEditVesselTransactionNo.EditValue.ToString() == string.Empty)
            //    return -3;
            //if (Convert.ToDecimal( this.txtNangsuatbocdo.EditValue.ToString())<=0)
            //    return -4;
            //if (Convert.ToDecimal(this.txtGiaphatluusalan.EditValue.ToString())<=0)
            //    return -5;
            
            return base.ValidateData();
        }
        protected override void AssignData()
        {
            if (this.DataSource == null)
                DataSource = new VesselExchangeContract();
            //(this.DataSource as VesselExchangeContract).ContractNo = this.ButtonEditVesselTransactionNo.EditValue.ToString();
            (this.DataSource as VesselExchangeContract).ContractNo = this.txtContractNo.Text;
            (this.DataSource as VesselExchangeContract).ContractDate = this.txtContractDate.DateTime;
            (this.DataSource as VesselExchangeContract).Description = this.txtDienGiai.Text;
            (this.DataSource as VesselExchangeContract).NangsuatbocdoSalan = Convert.ToDecimal(this.txtNangsuatbocdo.EditValue);
            (this.DataSource as VesselExchangeContract).GiaphatluuSalan =Convert.ToDecimal(this.txtGiaphatluusalan.EditValue);
            (this.DataSource as VesselExchangeContract).ExchangeSubjectCode = this.lookUpExchangeSubjectCode.EditValue.ToString();
            (this.DataSource as VesselExchangeContract).VesselTransactionNo = this.ButtonEditVesselTransactionNo.EditValue.ToString();
            if (this.EditMode == VNS.Windows.FormEditMode.ADD)
            {
                (dataSource as VesselExchangeContract).UserCreated = Contexts.CurrentUser.LoginName;
                (dataSource as VesselExchangeContract).DateCreated = DateTime.Now;
            }
            (dataSource as VesselExchangeContract).UserUpdated = Contexts.CurrentUser.LoginName;
            (dataSource as VesselExchangeContract).DateUpdated = DateTime.Now;
            base.AssignData();
        }
        protected override void BindData()
        {
            if (DataSource != null)
            {
                this.txtContractNo.Text = (this.DataSource as VesselExchangeContract).ContractNo;
                this.txtContractDate.DateTime = (this.DataSource as VesselExchangeContract).ContractDate;
                this.txtDienGiai.Text = (this.DataSource as VesselExchangeContract).Description;
                this.txtGiaphatluusalan.EditValue = (this.DataSource as VesselExchangeContract).GiaphatluuSalan;
                this.txtNangsuatbocdo.EditValue = (this.DataSource as VesselExchangeContract).NangsuatbocdoSalan;
                this.ButtonEditVesselTransactionNo.EditValue = (this.DataSource as VesselExchangeContract).VesselTransactionNo;
                this.lookUpExchangeSubjectCode.EditValue = (this.DataSource as VesselExchangeContract).ExchangeSubjectCode;
                this.gridControl1.DataSource = (this.DataSource as VesselExchangeContract).Detail;
            }
                    base.BindData();
        }
        protected override void InitDataObject()
        {
            base.InitDataObject();
            if (!DesignMode)
            {
                this.lookUpExchangeSubjectCode.Properties.DataSource = new VendorBLL().GetForVanchuyen(); //new SubjectBLL().GetKhoVan();
                this.replkItemCode.DataSource = new ItemBLL().GetAll();
                this.replkStockCode.DataSource = new StockBLL().GetAll();
                this.replkTransportItemTypeCode.DataSource = new TransportItemTypeBLL().GetAll();
                this.replkTransportTypeCode.DataSource = new TransportTypeBLL().GetAll();
                //this.repTransportType.DataSource = new TransactiontypeBLL().GetAll();
            }
        }

        

        private void ButtonEditVesselTransactionNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //string[] fields ={ "TransactionNo", "TransactionDate", "VesselName", "VendorName","Description" };
            //string[] header ={ "Mã chuyến tàu", "Ngày", "Tên tàu", "Nhà cung cấp","Ghi chú" };
            //VesselTransaction dr = (FormSearch.ShowSearch((this.ButtonEditVesselTransactionNo.Properties.DataSource), fields, header) as VesselTransaction);
            //if (this.editMode != FormEditMode.VIEW)
            //{
            //    if (dr != null)
            //    {
            //        this.ButtonEditVesselTransactionNo.EditValue = dr.TransactionNo;
            //        //if (dr.Nguoilienhe != string.Empty)
            //        //    this.txtHovaTen.Text = dr.Nguoilienhe;
            //        //else
            //        //    this.txtHovaTen.Text = "";

            //        //this.txtHovaTen.Text = dr.SubjectName;
            //        //this.txtDiachi.Text = dr.Address;
            //    }
            //}
            string[] fields ={ "TransactionNo", "TransactionDate", "VesselName", "VendorName", "Description" };
            string[] header ={ "Mã chuyến tàu", "Ngày", "Tên tàu", "Nhà cung cấp", "Ghi chú" };
            //PurchaseContract dr = (FormSearch.ShowSearch((this.repItemButtonEditContractNo..Properties.DataSource), fields, header) as PurchaseContract);
            DataRowView dr = (FormSearch.ShowSearch(this.vesselExchangeContract.GetSearch(), fields, header) as DataRowView);
            if (this.editMode != FormEditMode.VIEW)
            {
                if (dr != null)
                {
             //       this.gridView1.SetRowCellValue(this.gridView1.FocusedRowHandle, colContracNo, dr["ContractNo"].ToString());
                    //this.gridView1.SetRowCellValue(this.gridView3.FocusedRowHandle, colMasothue, dr["TaxCode"].ToString());
                    this.ButtonEditVesselTransactionNo.EditValue = dr["TransactionNo"].ToString();
                }
            }
        }
        public override void RefreshControl()
        {

            bool viewMode = this.EditMode == FormEditMode.VIEW;
            this.txtDonvigiaonhan.ReadOnly =true;
            this.txtNangsuatbocdo.Properties.ReadOnly=viewMode;

            this.txtGiaphatluusalan.Properties.ReadOnly = viewMode;
            this.txtContractNo.Properties.ReadOnly = viewMode;
            this.txtContractDate.Properties.ReadOnly = viewMode;
            this.lookUpExchangeSubjectCode.Properties.ReadOnly = viewMode;
            this.ButtonEditVesselTransactionNo.Properties.ReadOnly = viewMode;
            this.txtDonvigiaonhan.ReadOnly = viewMode;
            this.gridView1.OptionsBehavior.Editable = !viewMode;
            this.txtDienGiai.Properties.ReadOnly = viewMode;
            //this.ButtonEditVesselTransactionNo.Enabled = !viewMode ;
            gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;

            if (this.EditMode == FormEditMode.ADD)
            {
                this.txtDonvigiaonhan.ReadOnly = true;
                //this.txtGiaphatluusalan.Properties.ReadOnly = viewMode;
                //this.txtContractNo.Properties.ReadOnly = viewMode;
                //this.txtContractDate.Properties.ReadOnly = viewMode;
                //this.lookUpExchangeSubjectCode.Properties.ReadOnly = viewMode;
                //this.ButtonEditVesselTransactionNo.Properties.ReadOnly = viewMode;
                //this.txtDonvigiaonhan.ReadOnly = viewMode;
                //this.txtNangsuatbocdo.Properties.ReadOnly = viewMode;
                //this.gridView1.OptionsBehavior.Editable = !viewMode;
                gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

               
            }
            else 
            {
                this.txtDonvigiaonhan.ReadOnly = true;
                //this.txtGiaphatluusalan.Properties.ReadOnly = viewMode;
                //this.txtContractNo.Properties.ReadOnly = viewMode;
                //this.txtContractDate.Properties.ReadOnly = viewMode;
                //this.lookUpExchangeSubjectCode.Properties.ReadOnly = viewMode;
                //this.ButtonEditVesselTransactionNo.Properties.ReadOnly = viewMode;
                //this.txtDonvigiaonhan.ReadOnly = viewMode;
                //this.gridView1.OptionsBehavior.Editable = !viewMode;
                //this.txtNangsuatbocdo.Properties.ReadOnly = viewMode;

                 gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            }

            base.RefreshControl();
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

        private void lookUpExchangeSubjectCode_EditValueChanged(object sender, EventArgs e)
        {
            if (this.lookUpExchangeSubjectCode.EditValue != null && this.lookUpExchangeSubjectCode.EditValue.ToString() != string.Empty)
            {
                this.txtDonvigiaonhan.Text = lookUpExchangeSubjectCode.GetColumnValue("SubjectName").ToString();

            }
        }

    
    }

}
