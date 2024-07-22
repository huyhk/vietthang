using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using VNS.Common;

namespace VNS.ERP.Manufactures.Reports
{
    public partial class rptNguyenlieuFromManufacture :XtraReport
    {

        private DataTable dtDetailMaterial;
        public rptNguyenlieuFromManufacture()
        {
            InitializeComponent();
        }
        public rptNguyenlieuFromManufacture(DataView dtMaterial)
        {
            InitializeComponent();
            dtDetailMaterial = dtMaterial.ToTable();
            this.DataSource = dtDetailMaterial;
            this.DetailReport.DataSource = dtDetailMaterial;
        }

        public void BindDataMaster(ArrayList array)
        {
            this.lbltilte.Text = array[7].ToString();
            this.lblNgaybaocao.Text = array[6].ToString();
            this.lblProductName.Text = array[0].ToString();
            this.lblSoluongNap.Text = array[2].ToString();
            this.lblCongthuc.Text = array[1].ToString();
            this.lblCa.Text=array[3].ToString();
            this.lblKho.Text=array[5].ToString();
            if (array[4].ToString() == string.Empty)
            {
                this.lblLineSX.Visible = false;
                this.lblLine.Visible = false;
            }
            else
                this.lblLine.Text = array[4].ToString();
        }
        
        public void BindDataDetail()
        {
            this.cellMa.DataBindings.Add("Text", dtDetailMaterial, "MaterialCode");
            this.celTen.DataBindings.Add("Text", dtDetailMaterial, "ItemName");
            this.cellSoluong.DataBindings.Add("Text", dtDetailMaterial, "Weight", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
        
        }


      
    }
}
