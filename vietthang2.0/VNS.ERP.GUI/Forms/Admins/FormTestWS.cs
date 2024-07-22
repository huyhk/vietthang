using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Manufactures;
using VNS.Common;
using VNS.ERP.Data.KCS;
using VNS.ERP.Data.Premixs;

namespace VNS.ERP.GUI
{
    public partial class FormTestWS : Form
    {
        public FormTestWS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListBase<StockTransaction> lst = new StockTransactionBLL().GetPremixInfo(this.txtSearch.Text);
            

            if (lst == null)
                this.txtDate.Text = "không có";
            else
            {

                this.txtDate.Text = lst[0].DVGiao;
                this.gridControl1.DataSource = lst;
            }
        }
    }
}