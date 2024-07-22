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
    public partial class FormTransportContractDetentionPrice : FormEditBase
    {
        private Guid contractID;
        TransportContractDetentionPriceBLL bll = new TransportContractDetentionPriceBLL();
        public FormTransportContractDetentionPrice(Guid pContractID)
        {
            InitializeComponent();
            this.Business = bll;
            this.contractID = pContractID;
            this.ucTransportContractDetentionPrice1.ContractID = contractID;
        }
    }
}

