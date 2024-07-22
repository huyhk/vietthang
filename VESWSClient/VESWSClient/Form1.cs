using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VESWSClient.VESWS;
namespace VESWSClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VESWS.VESWS ad = new VESWSClient.VESWS.VESWS();
            WSMaterialTest[] lst = ad.GetWSMaterialTest(this.txtSearch.Text);

            if (lst == null || lst.Count() == 0)
                this.txtDate.Text = "không có";
            else
            {

                //this.txtDate.Text = m.ObjProductTestTransaction.TransactionDate.ToString();
                this.gridControl1.DataSource = lst[1].ListMaterialTestTransactionDetail;
            }
        }
    }
}
