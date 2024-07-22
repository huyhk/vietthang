using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.Common;
using VNS.ERP.Data;

namespace VNS.ERP.GUI
{
    public partial class RpWeightItemContainer : XtraReport
    {
        public struct Params
        {
            public WeightItemContainer WICObj;
            public string TransactionType;
            public string StockName;
            public string ItemName;
            public string CustomerName;
            public string EmployeeName;
        }
        public Params RpParams;
        public RpWeightItemContainer()
        {
            InitializeComponent();
        }
        public void BindData()
        {
            cellKhachhang.Text = this.RpParams.CustomerName;
            cellTenhang.Text = this.RpParams.ItemName;
            if (this.RpParams.WICObj.Quantity != 0)
            {
                cellBaobi.Text = this.RpParams.WICObj.WrappingWeight.ToString(AppConfigs.CONFIG_QUANTITYFORMAT) + " kg/cái";
                cellSobao.Text = this.RpParams.WICObj.Quantity.ToString(AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT);
                cellKhoiluongbaobi.Text = this.RpParams.WICObj.TotalWrappingWeight.ToString(AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT);

                cellKLChuabi.Text = this.RpParams.WICObj.KLChuabi.ToString(AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT);
                cellNgaygiora1.Text= this.RpParams.WICObj.PalletWeight.ToString(AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT);
            }
            else
            {
                lblBaobi.Text = cellBaobi.Text="";
                lblSobao.Text = cellSobao.Text = "";
                lblKhoiluongbaobi.Text = cellKhoiluongbaobi.Text = "";

                lblKLchuabi.Text = "";
                lblNgaygiora1.Text = "";
            }
            cellKhoiluongtong.Text = this.RpParams.WICObj.Weight1.ToString(AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT);
            cellKhoiluongxe.Text = this.RpParams.WICObj.Weight2.ToString(AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT);
            
            cellKhoiluonghang.Text = this.RpParams.WICObj.ItemWeight.ToString(AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT);
            cellSoxe.Text = this.RpParams.WICObj.Soxe;

            if (this.RpParams.WICObj.PTTrungChuyen == "")
            {
                lblPTVC.Text = "";
            }
            else
            {
                cellPTVC.Text = this.RpParams.WICObj.PTVanChuyen;
            }

            cellKho.Text = this.RpParams.StockName;
            cellVTKho.Text = this.RpParams.WICObj.StockLocationCode;

            if (this.RpParams.WICObj.IsReceive)
            {
                
            }
            else
            {
                lblKho.Text = "Kho xuất:";
                lblVTKho.Text = "VT kho xuất:";
            }
            cellNgaygiovao.Text = this.RpParams.WICObj.WeightDate.ToString(AppConfigs.CONFIG_DATEFORMAT) + " " +
                this.RpParams.WICObj.WeightTime1.ToString("HH:mm:ss");
            cellNgaygiora.Text = this.RpParams.WICObj.WeightDate.ToString(AppConfigs.CONFIG_DATEFORMAT) + " " +
                this.RpParams.WICObj.WeightTime2.ToString("HH:mm:ss");
            cellXuatnhap.Text = this.RpParams.TransactionType;

            lbWeightNo.Text = this.RpParams.WICObj.WeightCode;
            lbNguoiCan.Text = this.RpParams.EmployeeName;
        }
    }
}
