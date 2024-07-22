using System;
using System.Drawing;
using System.Data;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.Common;
using VNS.ERP.Data;

namespace VNS.ERP.GUI
{
    public partial class ReportEquipment_VattuInventoryDetails : ReportBase1
    {
        object lstDatasource;
        decimal openQuantity = 0;
        string vattuCode;
        public ReportEquipment_VattuInventoryDetails()
        {
            InitializeComponent();
        }
        public ReportEquipment_VattuInventoryDetails(string periodText, string stockName, string vattuCode, string vattuName, string typeName, decimal openQuantity, DataTable dt, bool vattu)
        {
            InitializeComponent();
            txtPeriodText.Text = periodText;
            lbStockName.Text += stockName;
            this.vattuCode = vattuCode;
            lbVattuCode.Text += vattuCode;
            lbVattuName.Text += vattuName;
            if (!vattu)
            {
                lbTypeName.Text += typeName;
                lbTypeName.Visible = true;
            }
            this.openQuantity = openQuantity;
            txtOpenQuantity.Text += openQuantity.ToString(AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT);
            lstDatasource = dt;
            this.DataSource = lstDatasource;
            Binddata();
        }
        public void Binddata()
        {
            ListBase<Vattu> lstVattu = new VattuBLL().GetAll();
            Vattu vattu = lstVattu.Search("VattuCode", vattuCode);
            if (vattu != null)
                txtUnit.Text += vattu.Unit;
            this.txtTransactionDate.DataBindings.Add("Text", lstDatasource, "TransactionDate", AppConfigs.CONFIG_DATEFORMAT_STRING);
            this.txtDescription.DataBindings.Add("Text", lstDatasource, "Description");
            this.txtInQuantity.DataBindings.Add("Text", lstDatasource, "InQuantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.txtOutQuantity.DataBindings.Add("Text", lstDatasource, "OutQuantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
        }

        decimal closeQuantity = 0;
        int dem = 0;
        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal inQuantity = Convert.ToDecimal(this.GetCurrentColumnValue("InQuantity"));
            decimal outQuantity = Convert.ToDecimal(this.GetCurrentColumnValue("OutQuantity"));
            if (dem == 0)
                closeQuantity = openQuantity + inQuantity - outQuantity;
            else
                closeQuantity += inQuantity - outQuantity;
            this.txtCloseQuantity.Text = closeQuantity.ToString(AppConfigs.CONFIG_QUANTITYFORMAT);
            dem++;
        }
    }
}
