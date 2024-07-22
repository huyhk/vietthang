using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data.Transports;
using VNS.Common;
using VNS.ERP.Data;
using VNS.Windows;
namespace VNS.ERP.GUI.Transports
{
    public partial class UCTransportLossAllow : VNS.Windows.Controls.EditControlBase
    {
        public UCTransportLossAllow()
        {
            InitializeComponent();
        }

        protected override void InitDataObject()
        {
            base.InitDataObject();
            if (!this.DesignMode)
            {
                this.checkListTransportItemType.DataSource = new TransportItemTypeBLL().GetAll();
                this.checkListTransportType.DataSource = new TransportTypeBLL().GetAll();
                this.checkListItem.DataSource = new ItemBLL().GetAll();
            }
        }

        protected override void AssignData()
        {
            if (this.dataSource == null)
                dataSource = new TransportLossAllow();
            (this.dataSource as TransportLossAllow).StartDate = this.txtStartDate.DateTime;
            (this.dataSource as TransportLossAllow).LossAllowRate = (decimal) this.txtLossAllowRate.EditValue;
            (this.dataSource as TransportLossAllow).Description = this.txtDescription.Text;
            (dataSource as TransportLossAllow).TransportLossAllowItemList.Clear();
            for (int i = 0; i < checkListItem.CheckedItems.Count; i++)
            {
                TransportLossAllowItem oTLAI = new TransportLossAllowItem();
                oTLAI.ItemCode = checkListItem.CheckedItems[i].ToString();

                (dataSource as TransportLossAllow).TransportLossAllowItemList.Add(oTLAI);
            }
            (dataSource as TransportLossAllow).TransportLossAllowTransportTypeList.Clear();
            for (int i = 0; i < checkListTransportType.CheckedItems.Count; i++)
            {
                TransportLossAllowTransportType oTLATT = new TransportLossAllowTransportType();
                oTLATT.TransportType = checkListTransportType.CheckedItems[i].ToString();

                (dataSource as TransportLossAllow).TransportLossAllowTransportTypeList.Add(oTLATT);
            }
            (dataSource as TransportLossAllow).TransportLossAllowTransportItemTypeList.Clear();
            for (int i = 0; i < checkListTransportItemType.CheckedItems.Count; i++)
            {
                TransportLossAllowTransportItemType oTLATIT = new TransportLossAllowTransportItemType();
                oTLATIT.TransportItemType = checkListTransportItemType.CheckedItems[i].ToString();

                (dataSource as TransportLossAllow).TransportLossAllowTransportItemTypeList.Add(oTLATIT);
            }
            if (this.EditMode == VNS.Windows.FormEditMode.ADD)
            {
                (dataSource as TransportLossAllow).UserCreated = Contexts.CurrentUser.LoginName;
                //(dataSource as TransportLossAllow).DateCreated = DateTime.Now;
            }
            (dataSource as TransportLossAllow).UserUpdated = Contexts.CurrentUser.LoginName;
            //(dataSource as TransportLossAllow).DateUpdated = DateTime.Now;
            base.AssignData();
        }

        protected override void BindData()
        {
            if (this.dataSource != null)
            {
                this.txtStartDate.DateTime = (dataSource as TransportLossAllow).StartDate;
                this.txtLossAllowRate.EditValue = (dataSource as TransportLossAllow).LossAllowRate;
                this.txtDescription.Text = (dataSource as TransportLossAllow).Description;
                //Set list Item
                ListBase<Item> lstItem = checkListItem.DataSource as ListBase<Item>;
                foreach (Item i in lstItem)
                {
                    TransportLossAllowItem oTLAI = (dataSource as TransportLossAllow).TransportLossAllowItemList.Search("ItemCode", i.ItemCode);
                    if (oTLAI == null) checkListItem.SetItemChecked(lstItem.IndexOf(i), false);
                    else
                    {
                        checkListItem.SetItemChecked(lstItem.IndexOf(i), true);
                    }
                }
                //Set list Transport Type
                DataTable dtTransportType = checkListTransportType.DataSource as DataTable;
                foreach (DataRow row in dtTransportType.Rows)
                {
                    TransportLossAllowTransportType oTLATT = (dataSource as TransportLossAllow).TransportLossAllowTransportTypeList.Search("TransportType", row["TypeCode"]);
                    if (oTLATT == null) checkListTransportType.SetItemChecked(dtTransportType.Rows.IndexOf(row), false);
                    else
                    {
                        checkListTransportType.SetItemChecked(dtTransportType.Rows.IndexOf(row), true);
                    }
                }
                //Set list Transport Item Type
                DataTable dtTransportItemType = checkListTransportItemType.DataSource as DataTable;
                foreach (DataRow row in dtTransportItemType.Rows)
                {
                    TransportLossAllowTransportItemType oTLATIT = (dataSource as TransportLossAllow).TransportLossAllowTransportItemTypeList.Search("TransportItemType", row["TypeCode"]);
                    if (oTLATIT == null) checkListTransportItemType.SetItemChecked(dtTransportItemType.Rows.IndexOf(row), false);
                    else
                    {
                        checkListTransportItemType.SetItemChecked(dtTransportItemType.Rows.IndexOf(row), true);
                    }
                }
            }
            base.BindData();
        }

        public override void RefreshControl()
        {
            bool viewMode = this.EditMode == FormEditMode.VIEW;
            this.txtStartDate.Properties.ReadOnly = viewMode;
            this.txtLossAllowRate.Properties.ReadOnly = viewMode;
            this.txtDescription.Properties.ReadOnly = viewMode;
            this.checkListTransportType.CheckOnClick = !viewMode;
            this.checkListTransportItemType.CheckOnClick = !viewMode;
            this.checkListItem.CheckOnClick = !viewMode;
            
            base.RefreshControl();
        }

    }
}

