using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;

namespace VNS.ERP.GUI.Transports
{
    public partial class FormEditBocxepContractService : VNS.Windows.Forms.FormEditBase
    {
        private BocxepContract contract;
        public BocxepContract Contract
        {
            get { return contract; }
            set
            {
                contract = value;
                this.ucBocxepContractService1.Contract = contract;
                this.DataSource = contract.ListBocxepContractService;
            }
        }
        public FormEditBocxepContractService()
        {
            InitializeComponent();
            this.Business = new BocxepContractServiceBLL();
        }
    }
}

