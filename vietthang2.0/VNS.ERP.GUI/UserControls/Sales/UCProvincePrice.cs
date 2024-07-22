using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using VNS.Windows.Controls;
using VNS.ERP.Data;
using VNS.ERP.Data.Sales;
using VNS.Windows;
using VNS.Common;

namespace VNS.ERP.GUI.UserControls.Sales
{
    public partial class UCProvincePrice : VNS.Windows.Controls.EditControlBase
    {
        public UCProvincePrice()
        {
            InitializeComponent();
        }

        protected override void BindData()
        {
            ProvincePrice t = (dataSource as ProvincePrice);
            if (this.DataSource != null)
            {
                this.lokProvince.EditValue = t.StockCode;
                this.txtStartDate.DateTime = t.StartDate;
                this.txtAmount.EditValue = t.Amount;
                this.cbProductType.Text = t.ProductType;
            }

            base.BindData();
        }
        protected override void AssignData()
        {
            if (dataSource == null) dataSource = new ProvincePrice();
            ProvincePrice t = (dataSource as ProvincePrice);
            t.StockCode = this.lokProvince.EditValue.ToString();
            t.ProductType = this.cbProductType.Text;
            t.StartDate = this.txtStartDate.DateTime;
            t.Amount = (decimal)this.txtAmount.EditValue;

            if (this.EditMode == VNS.Windows.FormEditMode.ADD)
            {

                t.UserCreated = Contexts.CurrentUser.LoginName;
                t.DateCreated = DateTime.Now;
            }
            t.UserUpdated = Contexts.CurrentUser.LoginName;
            t.DateUpdated = DateTime.Now;
            base.AssignData();
        }
        protected override void InitDataObject()
        {
            if (!this.DesignMode)
            {
                this.lokProvince.Properties.DataSource = new StockBLL().GetAll();
            }
            base.InitDataObject();
        }
        public override void RefreshControl()
        {
            bool view = (this.editMode == FormEditMode.VIEW);
            this.lokProvince.Properties.ReadOnly = view;
            this.txtStartDate.Properties.ReadOnly = view;
            this.txtAmount.Properties.ReadOnly = view;
            this.cbProductType.Enabled = !view;

            base.RefreshControl();
        }
        protected override int ValidateData()
        {
            if (this.lokProvince.EditValue.ToString() == string.Empty)
            {
                this.lokProvince.Focus();
                return -1;
            }
            return 0;
        }
    }
}
