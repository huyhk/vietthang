using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data.Transports;

namespace VNS.ERP.GUI.Transports
{
    public partial class FormRPTransportResult : VNS.Windows.Forms.FormBase
    {
        public FormRPTransportResult()
        {
            InitializeComponent();
        }

        private void FormRPTransportResult_Load(object sender, EventArgs e)
        {
            this.ucDatePeriodSelection1.WorkingDate = DateTime.Today;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetData();
        }
        private void GetData()
        {
            this.gridControl1.DataSource = (new TransportReportBLL().Report_TransportResults(this.ucDatePeriodSelection1.StartDate, this.ucDatePeriodSelection1.EndDate)).Tables[0];
        }
    }
}

