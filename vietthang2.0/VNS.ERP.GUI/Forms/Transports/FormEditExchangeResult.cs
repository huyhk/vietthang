using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;

namespace VNS.ERP.GUI.Transports
{
    public partial class FormEditExchangeResult : FormEditBase
    {
        ExchangeResultBLL obj = new ExchangeResultBLL();
        public FormEditExchangeResult()
        {
            InitializeComponent();
            this.Business = obj;
            
        }
        public FormEditExchangeResult(string ftext)
        {
            InitializeComponent();
            this.Business = obj;
            this.Text = ftext;
        }
    }
}