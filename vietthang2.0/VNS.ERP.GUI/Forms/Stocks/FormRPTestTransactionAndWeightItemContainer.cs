using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;
namespace VNS.ERP.GUI.Stocks
{
    public partial class FormRPTestTransactionAndWeightItemContainer : VNS.Windows.Forms.FormBase
    {
        public FormRPTestTransactionAndWeightItemContainer()
        {
            InitializeComponent();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            this.gridControl1.DataSource = new StockReportBLL().KiemtraPhieuNhapxuatVaPhieucanxetai(this.ucDatePeriodSelection1.StartDate, this.ucDatePeriodSelection1.EndDate);
        }
    }
}

