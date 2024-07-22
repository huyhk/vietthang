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
    public partial class UCTransportCompensationPrice : EditControlBase
    {
        public UCTransportCompensationPrice()
        {
            InitializeComponent();
        }
        protected override void BindData()
        {
            if (DataSource != null)
            {
                TransportCompensationPrice obj = (dataSource as TransportCompensationPrice);
                this.txtStartDate.EditValue = obj.StartDate;
                this.lookUpItemCode.EditValue = obj.ItemCode;
                this.txtPrice.EditValue = obj.Price;
            }
        }

        protected override void InitDataObject()
        {
            if (!this.DesignMode)
            {
                this.lookUpItemCode.Properties.DataSource = new ItemBLL().GetAll();
            }
        }
        protected override int ValidateData()
        {
            if (this.lookUpItemCode.EditValue.ToString() == String.Empty)
            {
                this.lookUpItemCode.Focus();
                return -1;
            }
            return 0;
        }
        protected override void AssignData()
        {
            if (dataSource == null)
                dataSource = new TransportCompensationPrice();
            TransportCompensationPrice obj = (dataSource as TransportCompensationPrice);
            obj.StartDate = this.txtStartDate.DateTime;
            obj.ItemCode = this.lookUpItemCode.EditValue.ToString();
            obj.Price = Convert.ToDecimal(this.txtPrice.EditValue);
            if (this.EditMode == VNS.Windows.FormEditMode.ADD)
            {
                obj.UserCreated = Contexts.CurrentUser.LoginName;
                obj.DateCreated = DateTime.Now;
            }
            obj.UserUpdated = Contexts.CurrentUser.LoginName;
            obj.DateUpdated = DateTime.Now;

            base.AssignData();
        }
        public override void RefreshControl()
        {
            bool view = (this.editMode == FormEditMode.VIEW);
            this.txtStartDate.Properties.ReadOnly = view;
            this.lookUpItemCode.Properties.ReadOnly = view;
            this.txtPrice.Properties.ReadOnly = view;
            base.RefreshControl();
        }
    }
}

