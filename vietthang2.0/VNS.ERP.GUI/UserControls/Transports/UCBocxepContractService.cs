using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;

namespace VNS.ERP.GUI.UserControls.Transports
{
    public partial class UCBocxepContractService : VNS.Windows.Controls.EditControlBase
    {
        public BocxepContract Contract;
        public UCBocxepContractService()
        {
            InitializeComponent();
            if (!this.IsDesignMode)
            {
                this.repBocxepName.DataSource = new BocxepTypeBLL().GetAll();
                this.repBocxepCode.DataSource = this.repBocxepName.DataSource;
            }
        }
        protected override void BindData()
        {
            this.txtServiceName.Text = (this.DataSource as BocxepContractService).ServiceName;
            this.gridControlListBocxep.DataSource = (this.DataSource as BocxepContractService).ListBocxepService;
            base.BindData();
        }
        protected override void AssignData()
        {
            (this.DataSource as BocxepContractService).ServiceName = this.txtServiceName.Text;
            (this.DataSource as BocxepContractService).ContractID = this.Contract.ContractID;
            base.AssignData();
        }
        protected override int ValidateData()
        {
            if (this.txtServiceName.Text.Trim() == "")
                return -1;
            return base.ValidateData();
        }
        public override void RefreshControl()
        {
            this.txtServiceName.Enabled = (this.EditMode != VNS.Windows.FormEditMode.VIEW);
            this.gridViewListBocxep.OptionsBehavior.Editable = (this.EditMode != VNS.Windows.FormEditMode.VIEW);
            base.RefreshControl();
        }
    }
}

