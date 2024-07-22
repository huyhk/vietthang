using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.Common;
using VNS.Windows;
namespace VNS.ERP.GUI
{
    public partial class FormStockTransport : FormEditBase
    {
        public static string StockCode="";
        public FormStockTransport()
        {
            InitializeComponent();
            this.Business = new StockTransportBLL();
     
        }
      
     
        private void lookUpStock_EditValueChanged(object sender, EventArgs e)
        {
          
             StockCode = lookUpStock.EditValue.ToString();
             string StocName = lookUpStock.GetColumnValue("StockName").ToString();
             this.txtStockName.EditValue = StocName;
             this.DataSource = new StockTransportBLL().GetAll(StockCode);
        }

        private void lookUpStock_Enter(object sender, EventArgs e)
        {
            lookUpStock.Properties.ReadOnly = this.editMode == FormEditMode.EDIT ;
           
        }
        public override void  RefreshButtons()
        {
            base.RefreshButtons();
            if (this.editMode == FormEditMode.EDIT)
                lookUpStock.BackColor = Color.Honeydew;
            else
                lookUpStock.BackColor = Color.White;
               
           
 	       
        }

        private void FormStockTransport_Load(object sender, EventArgs e)
        {
            lookUpStock.Properties.DataSource = new StockBLL().GetAll();
            this.lookUpStock.ItemIndex = 0;
        }

        
    }
}