using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data.Equipments;
using VNS.Windows.Forms;
using VNS.ERP.Data;

namespace VNS.ERP.GUI.Equipments
{
    public partial class FormEditEquipmentExpense : FormEditBase
    {
        private string _StockCode="";

        public string StockCode
        {
            get { return _StockCode; }
            set { ucEquipmentExpense1.StockCode = value; }
        }

        EquipmentExpensBLL obj = new EquipmentExpensBLL();
        public FormEditEquipmentExpense()
        {
            InitializeComponent();
            this.Business = obj;
        }
        public FormEditEquipmentExpense(string textform,string stockCode)
        {
            InitializeComponent();
            this.Business = obj;
            this.Text = textform;
            this.StockCode = stockCode;
        }
    }
}