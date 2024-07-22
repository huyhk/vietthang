using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.ERP.Data;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class ReportBase2 : XtraReport
    {
        public ReportBase2()
        {
            InitializeComponent();

            ModuleAccounting md = new ModuleBLL().GetModuleAccounting();

            xrTableCelltxtDonvi.Text = md.TenDonvi;
            xrTableCelltxtDiachi.Text = md.Diachi;
        }

    }
}
