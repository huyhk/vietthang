using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.Common;

namespace VNS.ERP.GUI.Reports.Accounts
{
    public partial class ReportAccountSoNhatkyMuahang : ReportBase2
    {
        public string colAccountCode1, colAccountCode2, colAccountCode3, colSoTK1;
        public string soTKName, code1Name, code2Name, code3Name, TKGhi1, TKGhi2;
        public int number;
        public string periodText, textRp;
        public DateTime ngayMS;
        decimal sumTKCo1 = 0;
        decimal sumTKNo1 = 0;
        decimal sumTKNo2 = 0;
        decimal sumTKNo3 = 0;
        decimal sumSotienCoKhac = 0;
        decimal sumSotienNoKhac = 0;
        int so = 0;
        public ReportAccountSoNhatkyMuahang()
        {
            InitializeComponent();
          }
        
        public void BindData()
        {
            //this.txtNgayghiso.DataBindings.Add("Text", DataSource, "Ngayghiso", AppConfigs.CONFIG_DATEFORMAT_STRING);
            //this.txtSoCT.DataBindings.Add("Text", DataSource, "SoCT");
            //this.txtNgayCT.DataBindings.Add("Text", DataSource, "NgayCT", AppConfigs.CONFIG_DATEFORMAT_STRING);
            //this.txtDiengiai.DataBindings.Add("Text", DataSource, "Diengiai");

            this.txtTKCo1.DataBindings.Add("Text", DataSource, colSoTK1, AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);
            this.txtSohieuCo.DataBindings.Add("Text", DataSource, "SohieuCoTKKhac");
            this.txtSotienCo.DataBindings.Add("Text", DataSource, "SotienCoTKKhac", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);
            this.txtTKNo1.DataBindings.Add("Text", DataSource, colAccountCode1, AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);
            this.txtTKNo2.DataBindings.Add("Text", DataSource, colAccountCode2, AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);
            this.txtTKNo3.DataBindings.Add("Text", DataSource, colAccountCode3, AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);
            this.txtSohieuNo.DataBindings.Add("Text", DataSource, "SohieuNoTKKhac");
            this.txtSotienNo.DataBindings.Add("Text", DataSource, "SotienNoTKKhac", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);

            this.txtPeriodText.Text = this.periodText;
            this.txtNgayMS.Text = this.ngayMS.ToString(AppConfigs.CONFIG_DATEFORMAT);
            this.txtText.Text = this.textRp;
            this.txtsoTK1Name.Text = this.soTKName;
            this.txtCode1Name.Text = this.code1Name;
            this.txtCode2Name.Text = this.code2Name;
            this.txtCode3Name.Text = this.code3Name;
            this.txtTKGhi1.Text = this.TKGhi1;
            this.txtTKGhi2.Text = this.TKGhi2;
        }

        int check2;
        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (this.GetCurrentColumnValue("Check").ToString() != null)
            {
                int check1 = Convert.ToInt32(this.GetCurrentColumnValue("Check"));
                if (check1 == check2)
                {
                    txtNgayghiso.Text = "";
                    txtNgayCT.Text = "";
                    txtSoCT.Text = "";
                    txtDiengiai.Text = "";
                }
                else
                {
                    DateTime ngayGhiSo = Convert.ToDateTime(this.GetCurrentColumnValue("Ngayghiso"));
                    DateTime ngayCT = Convert.ToDateTime(this.GetCurrentColumnValue("NgayCT"));
                    txtNgayghiso.Text = ngayGhiSo.ToString(AppConfigs.CONFIG_DATEFORMAT);
                    txtSoCT.Text = this.GetCurrentColumnValue("SoCT").ToString();
                    txtNgayCT.Text = ngayCT.ToString(AppConfigs.CONFIG_DATEFORMAT);
                    txtDiengiai.Text = this.GetCurrentColumnValue("Diengiai").ToString();
                }
                check2 = check1;
            }
        }

        private void Detail_AfterPrint(object sender, EventArgs e)
        {
            sumTKCo1 += (decimal)this.GetCurrentColumnValue(colSoTK1);
            sumTKNo1 += (decimal)this.GetCurrentColumnValue(colAccountCode1);
            sumTKNo2 += (decimal)this.GetCurrentColumnValue(colAccountCode2);
            sumTKNo3 += (decimal)this.GetCurrentColumnValue(colAccountCode3);
            sumSotienCoKhac += (decimal)this.GetCurrentColumnValue("SotienCoTKKhac");
            sumSotienNoKhac += (decimal)this.GetCurrentColumnValue("SotienNoTKKhac");
            so = Convert.ToInt32(this.GetCurrentColumnValue("PageNumber"));
        }

        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            rowTrangtruocchuyensang.Visible = true;
            GroupHeader1.Height = 17;
            this.txtPreTKCoKhac.Text = sumSotienCoKhac.ToString(AppConfigs.CONFIG_AMOUNTVNFORMAT);
            this.txtPreTKCo1.Text = sumTKCo1.ToString(AppConfigs.CONFIG_AMOUNTNTFORMAT);
            this.txtPreTKNo1.Text = sumTKNo1.ToString(AppConfigs.CONFIG_AMOUNTNTFORMAT);
            this.txtPreTKNo2.Text = sumTKNo2.ToString(AppConfigs.CONFIG_AMOUNTNTFORMAT);
            this.txtPreTKNo3.Text = sumTKNo3.ToString(AppConfigs.CONFIG_AMOUNTNTFORMAT);
            this.txtPreTKNoKhac.Text = sumSotienNoKhac.ToString(AppConfigs.CONFIG_AMOUNTNTFORMAT);
            if (Convert.ToInt32(this.GetCurrentColumnValue("PageNumber")) == 1)
            {
                rowTrangtruocchuyensang.Visible = false;
                GroupHeader1.Height = 0;
            }
        }

        private void GroupFooter1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.txtNextTKCoKhac.Text = sumSotienCoKhac.ToString(AppConfigs.CONFIG_AMOUNTVNFORMAT);
            this.txtNextTKNoKhac.Text = sumSotienNoKhac.ToString(AppConfigs.CONFIG_AMOUNTVNFORMAT);
            this.txtNextTKCo1.Text = sumTKCo1.ToString(AppConfigs.CONFIG_AMOUNTNTFORMAT);
            this.txtNextTKNo1.Text = sumTKNo1.ToString(AppConfigs.CONFIG_AMOUNTNTFORMAT);
            this.txtNextTKNo2.Text = sumTKNo2.ToString(AppConfigs.CONFIG_AMOUNTNTFORMAT);
            this.txtNextTKNo3.Text = sumTKNo3.ToString(AppConfigs.CONFIG_AMOUNTNTFORMAT);

        }

        private void GroupFooter1_AfterPrint(object sender, EventArgs e)
        {
            if (so == number)
            {
                GroupFooter1.PageBreak = DevExpress.XtraReports.UI.PageBreak.None;
            }
        }
    }
}
