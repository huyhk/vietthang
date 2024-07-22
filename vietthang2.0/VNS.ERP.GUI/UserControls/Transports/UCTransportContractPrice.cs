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
using System.Collections;

namespace VNS.ERP.GUI.Transports
{
    public partial class UCTransportContractPrice : EditControlBase
    {
        private Guid contractID;
        public Guid ContractID
        {
            get { return contractID; }
            set { contractID = value; }
        }
        public UCTransportContractPrice()
        {
            InitializeComponent();
        }
        protected override void BindData()
        {
            if (DataSource != null)
            {
                this.txtStartDate.EditValue = (dataSource as TransportContractPrice).StartDate;
                this.txtDescription.Text = (dataSource as TransportContractPrice).Description;
                this.lookUpRouteCode.EditValue = (dataSource as TransportContractPrice).RouteCode;
                ListBase<Item> lst = lstItemCode.DataSource as ListBase<Item>;
                foreach (Item s in lst)
                {
                    TransportContractPriceItem bxcps = (dataSource as TransportContractPrice).ListTransportContractPriceItem.Search("ItemCode", s.ItemCode);
                    if (bxcps == null) lstItemCode.SetItemChecked(lst.IndexOf(s), false);
                    else
                    {
                        lstItemCode.SetItemChecked(lst.IndexOf(s), true);
                    }
                }
                gridControl1.DataSource = (DataSource as TransportContractPrice).ListTransportContractPriceDetail;
            }
        }

        protected override void InitDataObject()
        {
            base.InitDataObject();
            if (!this.DesignMode)
            {
                this.lookUpRouteCode.Properties.DataSource = new TransportRouteBLL().GetAll();
                this.repLookUpTransportItemType.DataSource = new TransportItemTypeBLL().GetAll();
                this.repLookUpTransportType.DataSource = new TransportTypeBLL().GetAll();
                this.lstItemCode.DataSource = new ItemBLL().GetAll();
            }
        }
        protected override int ValidateData()
        {
            if (lstItemCode.CheckedItems.Count == 0)
                return -2;
            if (lookUpRouteCode.EditValue.ToString() == string.Empty)
            {
                this.lookUpRouteCode.Focus();
                return -1;
            }
            this.gridView1.CloseEditor();

            ListBase<TransportContractPriceDetail> lst = (this.DataSource as TransportContractPrice).ListTransportContractPriceDetail;
            for (int i = lst.Count - 1; i >= 0; i--)
            {
                if (lst[i].TranportItemType == string.Empty && lst[i].TransportType==string.Empty)
                { lst.RemoveAt(i); }
            }
            return 0;


        }
        protected override void AssignData()
        {
            if (dataSource == null)
                dataSource = new TransportContractPrice();
            (dataSource as TransportContractPrice).ContractID = this.ContractID;
            (dataSource as TransportContractPrice).StartDate = this.txtStartDate.DateTime;
            (dataSource as TransportContractPrice).RouteCode = this.lookUpRouteCode.EditValue.ToString();
            (dataSource as TransportContractPrice).Description = this.txtDescription.Text;
            (dataSource as TransportContractPrice).ListTransportContractPriceItem.Clear();
            for (int i = 0; i < lstItemCode.CheckedItems.Count; i++)
            {
                TransportContractPriceItem bxcps = new TransportContractPriceItem();
                bxcps.ItemCode = lstItemCode.CheckedItems[i].ToString();

                (dataSource as TransportContractPrice).ListTransportContractPriceItem.Add(bxcps);
            }
            if (this.EditMode == VNS.Windows.FormEditMode.ADD)
            {
                (dataSource as TransportContractPrice).UserCreated = Contexts.CurrentUser.LoginName;
                (dataSource as TransportContractPrice).DateCreated = DateTime.Now;
            }
            (dataSource as TransportContractPrice).UserUpdated = Contexts.CurrentUser.LoginName;
            (dataSource as TransportContractPrice).DateUpdated = DateTime.Now;

            base.AssignData();
        }
        public override void RefreshControl()
        {
            if (this.editMode == FormEditMode.ADD)
            {
                this.lstItemCode.CheckOnClick = true;
                txtStartDate.Properties.ReadOnly = false;
                txtDescription.Properties.ReadOnly = false;
                lookUpRouteCode.Properties.ReadOnly = false;
                gridView1.OptionsBehavior.Editable = true;
                gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            }
            else if (this.editMode == FormEditMode.EDIT)
            {
                this.lstItemCode.CheckOnClick = true;
                txtStartDate.Properties.ReadOnly = false;
                txtDescription.Properties.ReadOnly = false;
                lookUpRouteCode.Properties.ReadOnly = false;
                gridView1.OptionsBehavior.Editable = true;
                gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

            }
            if (this.editMode == FormEditMode.VIEW)
            {
                this.lstItemCode.CheckOnClick = false;
                txtStartDate.Properties.ReadOnly = true;
                txtDescription.Properties.ReadOnly = true;
                lookUpRouteCode.Properties.ReadOnly = true;
                gridView1.OptionsBehavior.Editable = false;
                gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            }
            //if (this.DataSource == null)
            //{
            //    txtdescription.Text = "";
            //    gridControl1.DataSource = null;
            //}
            base.RefreshControl();
        }
    }
}

