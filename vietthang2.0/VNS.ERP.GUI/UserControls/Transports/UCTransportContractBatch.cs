using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;
using VNS.Windows;
namespace VNS.ERP.GUI.Transports
{
    public partial class UCTransportContractBatch : VNS.Windows.Controls.EditControlBase
    {
        public UCTransportContractBatch()
        {
            InitializeComponent();
        }
        protected override void InitDataObject()
        {
            this.lokDonviGN.Properties.DataSource = new VendorBLL().GetForVanchuyen();
            this.lokVendor.Properties.DataSource = new VendorBLL().GetForPurchase();
            this.lokItemName.Properties.DataSource = new ItemBLL().GetAll();
            base.InitDataObject();
        }
        protected override void BindData()
        {
            if (this.DataSource != null)
            {
                TransportContractBatch obj = dataSource as TransportContractBatch;
                this.txtBillNo.EditValue = obj.BillNo;
                this.lokItemName.EditValue = obj.ItemCode;
                this.txtContQuantity.EditValue = obj.ContQuantity;
                this.txtContDes.EditValue = obj.ContDes;
                this.txtSobao.EditValue = obj.Sobao;
                this.txtSoluongBLNet.EditValue = obj.SoluongBLNet;
                this.txtGiakhaiHQ.EditValue = obj.GiakhaiHQ;
                this.txtTygiaNH.EditValue = obj.TygiaNH;
                this.lokDonviGN.EditValue = obj.DonViGN;
                this.txtTokhaiHQNo.EditValue = obj.TokhaiHQNo;
                this.txtPortName.EditValue = obj.PortName;
                this.lokVendor.EditValue = obj.VendorCode;
                this.txtHangtau.EditValue = obj.Hangtau;
                this.txtNoigiaohang.EditValue = obj.Noigiaohang;
                this.detThongbaotauden.DateTime = obj.Thongbaotauden;
                this.detBCTvetoiBank.DateTime = obj.BCTvetoiBank;
                this.detBankgiaoBCT.DateTime = obj.BankgiaoBCT;
                this.detNhanBCTTuBank.DateTime = obj.NhanBCTtuBank;
                this.detGiaoBCTchoDV.DateTime = obj.GiaoBCTchoDV;
                this.detMotokhaiHQ.DateTime = obj.MotokhaiHQ;
                this.detBatdaunhanCont.DateTime = obj.BatdaunhanCont;
                this.detKetthucnhanCont.DateTime = obj.KetthucnhanCont;
                this.detHethanluuConttaibai.DateTime = obj.HethanluuConttaibai;
                this.detHethanluubai.DateTime = obj.Hethanluubai;
                this.detHethanluukhorieng.DateTime = obj.Hethanluukhorieng;
                this.detNgaydangtainhamay.DateTime = obj.Ngaydangtainhamay;
                this.detNgaynhapxong.DateTime = obj.Ngaynhapxong;
                this.detNgaytrarong.DateTime = obj.Ngaytrarong;

                this.txtPriceVC.EditValue = obj.PriceVC;
                this.txtPriceKQ.EditValue = obj.PriceKQ;
                this.chkIsRutruot.Checked = obj.IsRutruot;

                this.gridControl4.DataSource = obj.ListTransportContractFee;

                this.txtDescription.EditValue = obj.Description;
            }

            base.BindData();
        }
        protected override int ValidateData()
        {
            //if (this.txtCode.Text == string.Empty)
            //{
            //    this.txtCode.Focus();
            //    return -1;
            //}
            //if (this.txtName.Text == string.Empty)
            //{
            //    this.txtName.Focus();
            //    return -2;
            //}
            return 0;
        }
        protected override void AssignData()
        {
            if (dataSource == null) dataSource = new TransportContractBatch();
            TransportContractBatch obj = dataSource as TransportContractBatch;
            obj.BillNo = this.txtBillNo.Text;
            obj.ItemCode = this.lokItemName.EditValue.ToString();
            obj.ContQuantity = (int)this.txtContQuantity.EditValue;
            obj.ContDes = this.txtContDes.Text;
            obj.Sobao = (int)this.txtSobao.EditValue;
            obj.SoluongBLNet = (decimal)this.txtSoluongBLNet.EditValue;
            obj.GiakhaiHQ = (decimal)this.txtGiakhaiHQ.EditValue;
            obj.TygiaNH = (decimal)this.txtTygiaNH.EditValue;
            obj.DonViGN = this.lokDonviGN.EditValue.ToString();
            obj.TokhaiHQNo = this.txtTokhaiHQNo.Text;
            obj.PortName = this.txtPortName.Text;
            obj.VendorCode = this.lokVendor.EditValue.ToString();
            obj.Hangtau = this.txtHangtau.Text;
            obj.Noigiaohang = this.txtNoigiaohang.Text;
            obj.Thongbaotauden = this.detThongbaotauden.DateTime;
            obj.BCTvetoiBank = this.detBCTvetoiBank.DateTime;
            obj.BankgiaoBCT = this.detBankgiaoBCT.DateTime;
            obj.NhanBCTtuBank = this.detNhanBCTTuBank.DateTime;
            obj.GiaoBCTchoDV = this.detGiaoBCTchoDV.DateTime;
            obj.MotokhaiHQ = this.detMotokhaiHQ.DateTime;
            obj.BatdaunhanCont = this.detBatdaunhanCont.DateTime;
            obj.KetthucnhanCont = this.detKetthucnhanCont.DateTime;
            obj.HethanluuConttaibai = this.detHethanluuConttaibai.DateTime;
            obj.Hethanluubai = this.detHethanluubai.DateTime;
            obj.Hethanluukhorieng = this.detHethanluukhorieng.DateTime;
            obj.Ngaydangtainhamay = this.detNgaydangtainhamay.DateTime;
            obj.Ngaynhapxong = this.detNgaynhapxong.DateTime;
            obj.Ngaytrarong = this.detNgaytrarong.DateTime;

            obj.PriceVC = (decimal)this.txtPriceVC.EditValue;
            obj.PriceKQ = (decimal)this.txtPriceKQ.EditValue;
            obj.IsRutruot = this.chkIsRutruot.Checked;

            obj.Description = this.txtDescription.Text;

            base.AssignData();
        }
        public override void RefreshControl()
        {
            bool viewMode = this.editMode == FormEditMode.VIEW;

            this.txtBillNo.Properties.ReadOnly = viewMode;
            this.lokItemName.Properties.ReadOnly = viewMode;
            this.txtContQuantity.Properties.ReadOnly = viewMode;
            this.txtContDes.Properties.ReadOnly = viewMode;
            this.txtSobao.Properties.ReadOnly = viewMode;
            this.txtSoluongBLNet.Properties.ReadOnly = viewMode;
            this.txtGiakhaiHQ.Properties.ReadOnly = viewMode;
            this.txtTygiaNH.Properties.ReadOnly = viewMode;
            this.lokDonviGN.Properties.ReadOnly = viewMode;
            this.txtTokhaiHQNo.Properties.ReadOnly = viewMode;
            this.txtPortName.Properties.ReadOnly = viewMode;
            this.lokVendor.Properties.ReadOnly = viewMode;
            this.txtHangtau.Properties.ReadOnly = viewMode;
            this.txtNoigiaohang.Properties.ReadOnly = viewMode;
            this.detThongbaotauden.Properties.ReadOnly = viewMode;
            this.detBCTvetoiBank.Properties.ReadOnly = viewMode;
            this.detBankgiaoBCT.Properties.ReadOnly = viewMode;
            this.detNhanBCTTuBank.Properties.ReadOnly = viewMode;
            this.detGiaoBCTchoDV.Properties.ReadOnly = viewMode;
            this.detMotokhaiHQ.Properties.ReadOnly = viewMode;
            this.detBatdaunhanCont.Properties.ReadOnly = viewMode;
            this.detKetthucnhanCont.Properties.ReadOnly = viewMode;
            this.detHethanluuConttaibai.Properties.ReadOnly = viewMode;
            this.detHethanluubai.Properties.ReadOnly = viewMode;
            this.detHethanluukhorieng.Properties.ReadOnly = viewMode;
            this.detNgaydangtainhamay.Properties.ReadOnly = viewMode;
            this.detNgaynhapxong.Properties.ReadOnly = viewMode;
            this.detNgaytrarong.Properties.ReadOnly = viewMode;

            this.btnInsertTransportContractFee.Enabled = viewMode;

            this.txtPriceVC.Properties.ReadOnly = viewMode;
            this.txtPriceKQ.Properties.ReadOnly = viewMode;
            this.chkIsRutruot.Properties.ReadOnly = viewMode;

            this.txtDescription.Properties.ReadOnly = viewMode;

            base.RefreshControl();
        }

        private void btnInsertTransportContractFee_Click(object sender, EventArgs e)
        {
            if ((this.DataSource as TransportContractBatch) != null)
            {
                TransportContractBatch obj = dataSource as TransportContractBatch;

                FormEditTransportContractFee f = new FormEditTransportContractFee(obj.ContractID, obj.BatchID);
                f.DataSource = obj.ListTransportContractFee;
                CurrencyManager cr = this.BindingContext[gridControl4.DataSource] as CurrencyManager;
                f.DataSource = gridControl4.DataSource;
                //f.ListBatch = (this.DataSource as TransportContract).ListTransportContractBatch;
                
                if (cr.Count > 0)
                    f.CurrentItem = cr.Current;
                f.AddNewItem();
                f.ShowDialog();
            }
        }

        private void gridView4_DoubleClick(object sender, EventArgs e)
        {
            if ((this.DataSource as TransportContractBatch) != null)
            {
                TransportContractBatch obj = dataSource as TransportContractBatch;

                FormEditTransportContractFee f = new FormEditTransportContractFee(obj.ContractID, obj.BatchID);
                f.DataSource = obj.ListTransportContractFee;
                CurrencyManager cr = this.BindingContext[gridControl4.DataSource] as CurrencyManager;
                f.DataSource = gridControl4.DataSource;
                //f.ListBatch = (this.DataSource as TransportContract).ListTransportContractBatch;

                if (cr.Count > 0)
                    f.CurrentItem = cr.Current;
                //f.AddNewItem();
                f.ShowDialog();
            }
        }
    }
}

