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
    public partial class FormEditVesselExchangeContract : FormEditBase
    {
        VesselExchangeContractBLL obj = new VesselExchangeContractBLL();
        public FormEditVesselExchangeContract()
        {
            InitializeComponent();
            this.Business = obj;
        }
        public FormEditVesselExchangeContract(string textform)
        {
            InitializeComponent();
            this.Business = obj;
            this.Text = textform;
        }
    }
}