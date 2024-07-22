using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;

namespace VNS.ERP.GUI
{
    public partial class FormEmployee : FormEditBase
    {
        EmployeeBLL obj = new EmployeeBLL();

        public FormEmployee()
        {
            InitializeComponent();
            repItemLookUpStockCode.DataSource = new StockBLL().GetAll();
            this.DataSource = obj.GetAll();
            this.Business = obj;
        }
    }
}