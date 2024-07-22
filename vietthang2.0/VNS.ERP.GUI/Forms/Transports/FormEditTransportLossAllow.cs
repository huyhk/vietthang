using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Transports;

namespace VNS.ERP.GUI.Transports
{
    public partial class FormEditTransportLossAllow : VNS.Windows.Forms.FormEditBase
    {
        TransportLossAllowBLL bll = new TransportLossAllowBLL();
        public FormEditTransportLossAllow()
        {
            InitializeComponent();

            this.Business = bll;
        }
    }
}

