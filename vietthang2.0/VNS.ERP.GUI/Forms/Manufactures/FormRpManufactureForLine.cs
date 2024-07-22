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
using System.Collections;

namespace VNS.ERP.GUI.Manufactures
{
    public partial class FormRpManufactureForLine : FormBase
    {
        DataTable dtP;
        public FormRpManufactureForLine()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ManufactureShiftBLL mn = new ManufactureShiftBLL();
            dtP = mn.GetReportsForLineSX(cboKho.EditValue.ToString(), cboTungay.DateTime, cboDenngay.DateTime);
            this.gridControl.DataSource = dtP;
            if (dtP.Rows.Count > 0)
                btnReports.Enabled = true;
            else
                btnReports.Enabled = false;
        }

        private void FormRpManufactureForLine_Load(object sender, EventArgs e)
        {
            this.cboKho.Properties.DataSource = (new StockBLL()).GetAllForMember(Contexts.CurrentUser.MemberID);
            this.cboKho.ItemIndex = 0;
            this.cboTungay.DateTime = Contexts.WorkingDate;
            this.cboDenngay.DateTime = Contexts.WorkingDate;
            btnReports.Enabled = false;
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ArrayList array = new ArrayList();
            array.Add(this.cboKho.Text);
            array.Add(this.cboTungay.Text);
            array.Add(this.cboDenngay.Text);
            RpManufactureForLine rpt = new RpManufactureForLine(dtP);
            rpt.BindDataMaster(array);
            rpt.BindDataDetail();
            rpt.ShowPreviewDialog();
        }
    }
}