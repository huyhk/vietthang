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
    public partial class FormEditBocxepContractPrices : FormEditBase
    {
        private Guid _contractID = Guid.Empty;

        public Guid ContractID
        {
            get { return _contractID; }
            set { this.ucBocxepContractPrices2.ContractID = value; }
        }
        BocxepContractPriceBLL bx = new BocxepContractPriceBLL();
        public FormEditBocxepContractPrices(Guid _contractID)
        {
            InitializeComponent();
            this.Business = bx;
            this.ContractID = _contractID;
        }
        
        public FormEditBocxepContractPrices()
        {
            InitializeComponent();
            this.Business = bx;
        }
       
        private void ucBocxepContractPrices2_Load(object sender, EventArgs e)
        {
            
        }

        private void FormBocxepContractPrices_Load(object sender, EventArgs e)
        {

        }

        private void ucBocxepContractPrices2_Load_1(object sender, EventArgs e)
        {

        }
        
      
     
    }
}