using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data.Transports;

namespace VNS.ERP.GUI.Transports
{
    public partial class FormTransportContractPrice :FormEditBase
    {
        private Guid contractID;
        TransportContractPriceBLL bll = new TransportContractPriceBLL();
        public FormTransportContractPrice(Guid pContractID)
        {
            InitializeComponent();
            this.Business = bll;
            this.contractID = pContractID;
            this.ucTransportContractPrice1.ContractID = contractID;
        }
    }
}

