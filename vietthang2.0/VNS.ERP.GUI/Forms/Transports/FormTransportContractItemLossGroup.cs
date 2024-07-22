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
    public partial class FormTransportContractItemLossGroup : VNS.Windows.Forms.FormEditBase
    {
        private Guid contractID;
        TransportContractItemLossGroupBLL bll = new TransportContractItemLossGroupBLL();
        public FormTransportContractItemLossGroup(Guid pContractID)
        {
            InitializeComponent();

            this.Business = bll;
            this.contractID = pContractID;
            this.ucTransportContractItemLossGroup1.ContractID = contractID;
        }
    }
}

