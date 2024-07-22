using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace VNS.ERP.GUI
{
    public partial class RpManufactureForEmployeeMaster : ReportBase1
    {
        DataTable dt1;
        DataTable dt2;
        DataTable dt3;
        public RpManufactureForEmployeeMaster()
        {
            InitializeComponent();
        }
        public RpManufactureForEmployeeMaster(DataTable dtShiftLeader,DataTable dtEmployeeID1,DataTable dtEmployeeID2 )
        {
            InitializeComponent();
            dt1 = dtShiftLeader;
            dt2 = dtEmployeeID1;
            dt3 = dtEmployeeID2;
        }
        public void BindDataMaster(ArrayList array)
        {
            this.cellNhamay.Text = array[0].ToString();
            this.cellTungay.Text = array[1].ToString();
            this.cellDenngay.Text = array[2].ToString();
        }

        public void BindDataDetail()
        {
            this.subreport1.ReportSource.DataSource = dt1;
            (this.subreport1.ReportSource as RpManufactureForEmployeeSub).BindDataDetail();
            (this.subreport1.ReportSource as RpManufactureForEmployeeSub).BindDataMaster("Trưởng ca");
            this.subreport2.ReportSource.DataSource = dt2;
            (this.subreport2.ReportSource as RpManufactureForEmployeeSub).BindDataDetail();
            (this.subreport2.ReportSource as RpManufactureForEmployeeSub).BindDataMaster("Vận hành máy nghiền");
            this.subreport3.ReportSource.DataSource = dt3;
            (this.subreport3.ReportSource as RpManufactureForEmployeeSub).BindDataDetail();
            (this.subreport3.ReportSource as RpManufactureForEmployeeSub).BindDataMaster("Vận hành máy ép");
        }

    }
}
