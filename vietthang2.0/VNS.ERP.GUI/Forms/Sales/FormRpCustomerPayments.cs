using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.Common;
using VNS.ERP.Data;
using VNS.ERP.Data.Sales;
using System.Collections;
using VNS.Windows;

namespace VNS.ERP.GUI.Sales
{
    public partial class FormRpCustomerPayments : FormBase
    {
        private DataTable dt;
        string productType;
        public FormRpCustomerPayments(string pProductType)
        {
            InitializeComponent();
            productType = pProductType;
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            if (this.gridView.RowCount > 0)
            {
                ArrayList array = new ArrayList();
                array.Add(this.ucDatePeriodSelection1.StartDate);
                array.Add(this.ucDatePeriodSelection1.EndDate);
                DataView dv = GridUtils.GetDataView(this.gridControl);
                RpCustomerPayment rpt = new RpCustomerPayment(dv);
                rpt.BindDataMaster(array);
                rpt.ShowPreviewDialog();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dt = (new CustomerPaymentBLL()).CustomerPaymentReports(this.ucDatePeriodSelection1.StartDate, this.ucDatePeriodSelection1.EndDate, productType);
            this.gridControl.DataSource = dt;
            if (this.gridView.RowCount > 0)
               this.btnReports.Enabled = true;
            else
                this.btnReports.Enabled = false;
        }

    }
}