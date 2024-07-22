using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Manufactures;

namespace VNS.ERP.GUI.Manufactures
{
    public partial class FormEditManufacturePlanMonth : FormEditBase
    {
        private string stockCode;
        public string StockCode
        {
            get { return stockCode; }
            set 
            { 
                stockCode = value;
                ucManufactPlanMonth1.StockCode = value;
            }
        }
        ManufacturePlanMonthBLL mpmBLL = new ManufacturePlanMonthBLL();
        /// <summary>
        /// not use
        /// </summary>
        public FormEditManufacturePlanMonth()
        {
            InitializeComponent();
            this.ucManufactPlanMonth1.InitDss();
            this.Business = mpmBLL;
        }
        /// <summary>
        /// Use tao call
        /// </summary>
        /// <param name="sCode"></param>
        public FormEditManufacturePlanMonth(string sCode)
        {
            InitializeComponent();
            this.ucManufactPlanMonth1.InitDss();
            this.Business = mpmBLL;
            this.StockCode = sCode;
        }

        private void FormEditManufacturePlanMonth_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.EditMode == VNS.Windows.FormEditMode.ADD)
            {
                this.CancelItem();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ManufacturePlanMonth mpm = (ManufacturePlanMonth)(this.CurrentItem as ManufacturePlanMonth).Clone();
            mpm.Detail = mpmBLL.GetSumDetail(mpm.ManufacturePlanMonthID);
            RpManufacturePlanMonth rp = new RpManufacturePlanMonth(mpm, this.ucManufactPlanMonth1.StockName, this.ucManufactPlanMonth1.ItemDataSource);
            rp.ShowPreviewDialog();
        }

        private void btnReportMaterial_Click(object sender, EventArgs e)
        {
            ManufacturePlanMonth mpm = this.CurrentItem as ManufacturePlanMonth;
            RpManufacturePlanMonthMaterial rp = new RpManufacturePlanMonthMaterial(mpm, mpmBLL.GetDetailMaterial(mpm.ManufacturePlanMonthID), this.ucManufactPlanMonth1.StockName);
            rp.ShowPreviewDialog();
        }
        public override void RefreshButtons()
        {
            btnPrint.Enabled = this.EditMode == VNS.Windows.FormEditMode.VIEW;
            btnReportMaterial.Enabled = this.EditMode == VNS.Windows.FormEditMode.VIEW;
            base.RefreshButtons();
        }
    }
}