using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;

namespace VNS.ERP.GUI
{
    public partial class FormTransportFeeType : VNS.Windows.Forms.FormEditBase
    {
        TransportFeeTypeBLL bll = new TransportFeeTypeBLL();
        public FormTransportFeeType()
        {
            InitializeComponent();
            this.Business = bll;
        }

        private void FormTransportFeeType_Load(object sender, EventArgs e)
        {
            if (this.DataSource == null)
                this.DataSource = bll.GetAll();
        }
    }
}

