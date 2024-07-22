using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Transports;
using VNS.Common;

namespace VNS.ERP.GUI.Transports
{
    public partial class FormEditTransportContractFee : VNS.Windows.Forms.FormEditBase
    {
        private Guid contractID;
        private Guid batchID;
        TransportContractFeeBLL bll = new TransportContractFeeBLL();
        public ListBase<TransportContractBatch> ListBatch
        {
            set { this.ucTransportContractFee1.ListBatch = value; }
        }
        public FormEditTransportContractFee(Guid pContractID)
        {
            InitializeComponent();

            this.Business = bll;
            this.contractID = pContractID;
            this.ucTransportContractFee1.ContractID = contractID;
        }
        public FormEditTransportContractFee(Guid pContractID, Guid pBatchID)
        {
            InitializeComponent();

            this.Business = bll;
            this.contractID = pContractID;
            this.ucTransportContractFee1.ContractID = contractID;

            this.batchID = pBatchID;
            this.ucTransportContractFee1.BatchID = batchID;
        }
        public override object AddNew()
        {
            TransportContractFee t = base.AddNew() as TransportContractFee;
            if (t == null)
                t = new TransportContractFee();
            t.ContractID = this.contractID;
            t.BatchID = this.batchID;

            return t;
        }
    }
}

