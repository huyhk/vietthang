using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.ERP.Data;
using VNS.ERP.Data.Transports;
using VNS.Windows;
using VNS.Common;

namespace VNS.ERP.GUI.UserControls.Transports
{
    public partial class UCTransportContractItemLossGroup : VNS.Windows.Controls.EditControlBase
    {
        private Guid contractID;
        public Guid ContractID
        {
            get { return contractID; }
            set { contractID = value; }
        }
        public UCTransportContractItemLossGroup()
        {
            InitializeComponent();
        }
        protected override void InitDataObject()
        {
            base.InitDataObject();
            if (!this.DesignMode)
            {
                this.lstItemCode.DataSource = new ItemBLL().GetAll();
            }
        }
        protected override void BindData()
        {
            if (DataSource != null)
            {
                this.txtGroupName.Text = (dataSource as TransportContractItemLossGroup).GroupName;
                this.txtDescription.Text = (dataSource as TransportContractItemLossGroup).Description;
                this.gridControl3.DataSource = (dataSource as TransportContractItemLossGroup).ListTransportContractItemLossGroupCompenPrice;
                ListBase<Item> lst = lstItemCode.DataSource as ListBase<Item>;
                foreach (Item s in lst)
                {
                    TransportContractItemLossGroupItem tcilgi = (dataSource as TransportContractItemLossGroup).ListTransportContractItemLossGroupItem.Search("ItemCode", s.ItemCode);
                    if (tcilgi == null) lstItemCode.SetItemChecked(lst.IndexOf(s), false);
                    else
                    {
                        lstItemCode.SetItemChecked(lst.IndexOf(s), true);
                    }
                }
            }
        }
        protected override int ValidateData()
        {
            if (this.txtGroupName.Text == string.Empty)
            {
                this.txtGroupName.Focus();
                return -1;
            }
            this.gridView3.CloseEditor();

            //ListBase<TransportContractItemLossGroupItem> lst = (this.DataSource as TransportContractItemLossGroup).ListTransportContractItemLossGroupItem;
            //for (int i = lst.Count - 1; i >= 0; i--)
            //{
            //    if (lst[i].TranportItemType == string.Empty && lst[i].TransportType == string.Empty)
            //    { lst.RemoveAt(i); }
            //}
            return base.ValidateData();

        }
        protected override void AssignData()
        {
            if (this.dataSource == null)
                dataSource = new TransportContractItemLossGroup();
            (dataSource as TransportContractItemLossGroup).ContractID = this.ContractID;
            (this.dataSource as TransportContractItemLossGroup).GroupName = this.txtGroupName.Text;
            (this.dataSource as TransportContractItemLossGroup).Description = this.txtDescription.Text;

            (dataSource as TransportContractItemLossGroup).ListTransportContractItemLossGroupItem.Clear();
            for (int i = 0; i < lstItemCode.CheckedItems.Count; i++)
            {
                TransportContractItemLossGroupItem tcilgi = new TransportContractItemLossGroupItem();
                tcilgi.ItemCode = lstItemCode.CheckedItems[i].ToString();

                (dataSource as TransportContractItemLossGroup).ListTransportContractItemLossGroupItem.Add(tcilgi);
            }

            if (this.EditMode == VNS.Windows.FormEditMode.ADD)
            {
                (dataSource as TransportContractItemLossGroup).UserCreated = Contexts.CurrentUser.LoginName;
                (dataSource as TransportContractItemLossGroup).DateCreated = DateTime.Now;
            }
            (dataSource as TransportContractItemLossGroup).UserUpdated = Contexts.CurrentUser.LoginName;
            (dataSource as TransportContractItemLossGroup).DateUpdated = DateTime.Now;
            base.AssignData();
        }
        public override void RefreshControl()
        {
            if (this.editMode == FormEditMode.ADD || this.editMode == FormEditMode.EDIT)
            {
                this.txtGroupName.Properties.ReadOnly = false;
                this.txtDescription.Properties.ReadOnly = false;
                this.gridView3.OptionsBehavior.Editable = true;
                this.gridView3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
                this.lstItemCode.CheckOnClick = true;
            }
            else if (this.editMode == FormEditMode.VIEW)
            {
                this.txtGroupName.Properties.ReadOnly = true;
                this.txtDescription.Properties.ReadOnly = true;
                this.gridView3.OptionsBehavior.Editable = false;
                this.gridView3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                this.lstItemCode.CheckOnClick = false;
            }
            base.RefreshControl();
        }
    }
}

