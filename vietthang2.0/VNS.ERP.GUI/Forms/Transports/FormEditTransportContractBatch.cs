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
    public partial class FormEditTransportContractBatch : VNS.Windows.Forms.FormEditBase
    {
        TransportContractBatchBLL bll = new TransportContractBatchBLL();
        Guid ContractID;
        public FormEditTransportContractBatch(Guid contractID)
        {
            InitializeComponent();
            this.Business = bll;
            this.ContractID = contractID;
        }
        public override object AddNew()
        {
            TransportContractBatch b = base.AddNew() as TransportContractBatch;
            if (b == null)
                b = new TransportContractBatch();
            b.ContractID = this.ContractID;
            return b;
        }
    }
}

