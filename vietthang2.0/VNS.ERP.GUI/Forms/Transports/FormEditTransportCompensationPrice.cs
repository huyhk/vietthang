using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Transports;
using VNS.Common;

namespace VNS.ERP.GUI.Transports
{
    public partial class FormEditTransportCompensationPrice : FormEditBase
    {
        TransportCompensationPriceBLL bll = new TransportCompensationPriceBLL();
        public FormEditTransportCompensationPrice()
        {
            InitializeComponent();
            this.Business = bll;
        }
    }
}

