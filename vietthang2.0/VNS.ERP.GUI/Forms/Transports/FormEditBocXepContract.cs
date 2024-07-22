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

namespace VNS.ERP.GUI.Transports
{
    public partial class FormEditBocXepContract : FormEditBase
    {
        BocxepContractBLL obj = new BocxepContractBLL();
        public FormEditBocXepContract()
        {
            InitializeComponent();
            this.Business = obj;
        }

        public FormEditBocXepContract(string textForm)
        {
            InitializeComponent();
            this.Business = obj;
            this.Text = textForm;
        }
    }
}