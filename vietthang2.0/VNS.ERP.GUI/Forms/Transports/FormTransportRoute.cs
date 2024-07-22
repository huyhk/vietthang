using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class FormTransportRoute : FormEditBase
    {
        TransportRouteBLL obj = new TransportRouteBLL();

        public FormTransportRoute()
        {
            InitializeComponent();
            this.EditControl = ucTransportRoute1;
            this.Business = obj;
            this.DataSource = obj.GetAll();

            ListBase<Stock> listStock = new StockBLL().GetAll();
            Stock stock = new Stock();
            listStock.Insert(0, stock);
            this.repStockIn.DataSource = listStock;
            this.repStockOut.DataSource = listStock;
        }

        
    }
}   