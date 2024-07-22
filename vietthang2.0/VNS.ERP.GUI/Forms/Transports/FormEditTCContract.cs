using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data.Transports;

namespace VNS.ERP.GUI.Transports
{
    public partial class FormEditTCContract : VNS.Windows.Forms.FormEditBase
    {
        TCContractBLL bll = new TCContractBLL();
        public FormEditTCContract()
        {
            InitializeComponent();

            this.Business = bll;
        }
    }
}

