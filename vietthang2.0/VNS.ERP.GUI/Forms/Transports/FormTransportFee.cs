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
    public partial class FormTransportFee : VNS.Windows.Forms.FormEditBase
    {
        TransportFeeBLL bll = new TransportFeeBLL();
        public FormTransportFee()
        {
            InitializeComponent();

            this.Business = bll;
        }

        private void FormTransportFee_Load(object sender, EventArgs e)
        {
            this.repTypeName.DataSource = new TransportFeeTypeBLL().GetAll();
            if (this.DataSource == null)
                this.DataSource = bll.GetAll();
            

        }
    }
}

