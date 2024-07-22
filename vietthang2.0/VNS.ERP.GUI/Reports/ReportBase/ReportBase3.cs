using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace VNS.ERP.GUI
{
    public partial class ReportBase3 : DevExpress.XtraReports.UI.XtraReport
    {
        private decimal reportYear;
        public decimal ReportYear
        {
            get { return reportYear; }
            set
            {
                reportYear = value;
                lbYear.Text = "Cho năm tài chính kết thúc ngày 31 tháng 12 năm " + value.ToString();
            }
        }
        public ReportBase3()
        {
            InitializeComponent();
        }
    }
}
