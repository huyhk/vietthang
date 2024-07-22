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
    public partial class UCTransportContractDetentionPrice : EditControlBase
    {
        private Guid contractID;
        public Guid ContractID
        {
            get { return contractID; }
            set { contractID = value; }
        }
        public UCTransportContractDetentionPrice()
        {
            InitializeComponent();
        }
        public override void RefreshControl()
        {
            if (this.editMode == FormEditMode.ADD || this.editMode == FormEditMode.EDIT)
            {
                this.txtStartDate.Properties.ReadOnly = false;
                this.txtDescription.Properties.ReadOnly = false;
                gridView1.OptionsBehavior.Editable = true;
                gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            }
            else if (this.editMode == FormEditMode.VIEW)
            {
                this.txtStartDate.Properties.ReadOnly = true;
                this.txtDescription.Properties.ReadOnly = true;
                this.gridView1.OptionsBehavior.Editable = false;
                this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            }
            base.RefreshControl();
        }
        protected override void InitDataObject()
        {
            base.InitDataObject();
            if (!this.DesignMode)
            {
                this.repLookUpTransportType.DataSource = new TransportTypeBLL().GetAll();
            }
        }
        protected override void BindData()
        {
            if (this.dataSource != null)
            {
                this.txtStartDate.EditValue = (dataSource as TransportContractDetentionPrice).StartDate;
                this.txtDescription.Text = (dataSource as TransportContractDetentionPrice).Description;
                this.gridControl1.DataSource = (dataSource as TransportContractDetentionPrice).ListTransportContractDetentionPriceDetail;
            }
            base.BindData();
        }
        protected override int ValidateData()
        {
            this.gridView1.CloseEditor();
            return 0;
        }
        protected override void AssignData()
        {
            if (dataSource == null)
                dataSource = new TransportContractDetentionPrice();
            (dataSource as TransportContractDetentionPrice).ContractID = this.ContractID;
            (dataSource as TransportContractDetentionPrice).StartDate = this.txtStartDate.DateTime;
            (dataSource as TransportContractDetentionPrice).Description = this.txtDescription.Text;
            if (this.EditMode == VNS.Windows.FormEditMode.ADD)
            {
                (dataSource as TransportContractDetentionPrice).UserCreated = Contexts.CurrentUser.LoginName;
                (dataSource as TransportContractDetentionPrice).DateCreated = DateTime.Now;
            }
            (dataSource as TransportContractDetentionPrice).UserUpdated = Contexts.CurrentUser.LoginName;
            (dataSource as TransportContractDetentionPrice).DateUpdated = DateTime.Now;

            base.AssignData();
        }
    }
}

