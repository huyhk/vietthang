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
using VNS.Windows.Controls;
using VNS.Windows;

namespace VNS.ERP.GUI.UserControls.Transports
{
    public partial class UCTransportContractFee : VNS.Windows.Controls.EditControlBase
    {
        private Guid contractID;
        public Guid ContractID
        {
            get { return contractID; }
            set { contractID = value; }
        }
        private Guid batchID;
        public Guid BatchID
        {
            get { return batchID; }
            set { batchID = value; }
        }
        public ListBase<TransportContractBatch> ListBatch
        {
            set { this.lokBatch.Properties.DataSource = value; }
        }
        public UCTransportContractFee()
        {
            InitializeComponent();
        }
        protected override void BindData()
        {
            if (this.dataSource != null)
            {
                this.txtStartDate.EditValue = (dataSource as TransportContractFee).StartDate;
                this.txtEndDate.EditValue = (dataSource as TransportContractFee).EndDate;
                this.txtDescription.Text = (dataSource as TransportContractFee).Description;
                this.gridControl1.DataSource = (dataSource as TransportContractFee).ListTransportContractFeeDetail;

                this.lokBatch.EditValue = (dataSource as TransportContractFee).BatchID;
            }
            base.BindData();
        }
        protected override void InitDataObject()
        {
            base.InitDataObject();
            if (!this.DesignMode)
            {
                ListBase<TransportFee> listTransportFee = new TransportFeeBLL().GetAll();
                this.repFeeName.DataSource = listTransportFee;
                this.repFeeCode.DataSource = listTransportFee;
            }
        }
        public override void RefreshControl()
        {
            if (this.editMode == FormEditMode.ADD || this.editMode == FormEditMode.EDIT)
            {
                this.txtStartDate.Properties.ReadOnly = false;
                this.txtEndDate.Properties.ReadOnly = false;
                this.txtDescription.Properties.ReadOnly = false;
                gridView1.OptionsBehavior.Editable = true;
                gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
                gridView1.OptionsCustomization.AllowFilter = false;

                this.lokBatch.Properties.ReadOnly = false;
            }
            else if (this.editMode == FormEditMode.VIEW)
            {
                this.txtStartDate.Properties.ReadOnly = true;
                this.txtEndDate.Properties.ReadOnly = true;
                this.txtDescription.Properties.ReadOnly = true;
                this.gridView1.OptionsBehavior.Editable = false;
                this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;

                this.lokBatch.Properties.ReadOnly = true;
            }
            base.RefreshControl();
        }

        protected override void AssignData()
        {
            if (dataSource == null)
                dataSource = new TransportContractFee();
            (dataSource as TransportContractFee).ContractID = this.ContractID;
            (dataSource as TransportContractFee).StartDate = this.txtStartDate.DateTime;
            (dataSource as TransportContractFee).EndDate = this.txtEndDate.DateTime;
            (dataSource as TransportContractFee).Description = this.txtDescription.Text;

            if (this.batchID == Guid.Empty)
            {
                if (this.lokBatch.EditValue != null)
                    (dataSource as TransportContractFee).BatchID = (Guid)this.lokBatch.EditValue;
            }
            else
                (dataSource as TransportContractFee).BatchID = this.batchID;

            if (this.EditMode == VNS.Windows.FormEditMode.ADD)
            {
                (dataSource as TransportContractFee).UserCreated = Contexts.CurrentUser.LoginName;
                (dataSource as TransportContractFee).DateCreated = DateTime.Now;
            }
            (dataSource as TransportContractFee).UserUpdated = Contexts.CurrentUser.LoginName;
            (dataSource as TransportContractFee).DateUpdated = DateTime.Now;

            base.AssignData();
        }

        protected override int ValidateData()
        {
            this.gridView1.CloseEditor();
            return 0;
        }

        private void UCTransportContractFee_Load(object sender, EventArgs e)
        {
            if (this.batchID != Guid.Empty)
            {
                this.lokBatch.Visible = false;
                this.lblBatch.Visible = false;
            }
        }
    }
}

