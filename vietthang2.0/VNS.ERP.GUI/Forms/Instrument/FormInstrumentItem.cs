using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Accounting;

namespace VNS.ERP.GUI
{
    public partial class FormInstrumentItem : FormEditBase
    {
        InstrumentItemBLL bll = new InstrumentItemBLL();
        public FormInstrumentItem()
        {
            InitializeComponent();
            this.Business = bll;
            this.DataSource = bll.GetAll();
        }
    }
}