using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.ERP.Data;
using VNS.ERP.Data.Sales;
using VNS.Windows;
using VNS.Common;
namespace VNS.ERP.GUI.Transports
{
    public partial class UCTransportFee : VNS.Windows.Controls.EditControlBase
    {
        public UCTransportFee()
        {
            InitializeComponent();
            this.SetTextCode(this.txtFeeCode);
            this.FirstControl = this.txtFeeCode;
        }
        protected override void InitDataObject()
        {
            base.InitDataObject();

            this.lokTypeName.Properties.DataSource = new TransportFeeTypeBLL().GetAll();
        }
        protected override void BindData()
        {
            if (this.DataSource != null)
            {
                this.txtFeeCode.Text = (dataSource as TransportFee).FeeCode;
                this.txtFeeName.Text = (dataSource as TransportFee).FeeName;
                this.txtUnitName.Text = (dataSource as TransportFee).UnitName;
                this.txtTaxRate.EditValue = (dataSource as TransportFee).TaxRate;
                this.txtDescription.Text = (dataSource as TransportFee).Description;

                this.lokTypeName.EditValue = (dataSource as TransportFee).TypeCode;
            }

            base.BindData();
        }
        protected override int ValidateData()
        {
            if (this.txtFeeCode.Text == string.Empty)
            {
                this.txtFeeCode.Focus();
                return -1;
            }
            if (this.txtFeeName.Text == string.Empty)
            {
                this.txtFeeName.Focus();
                return -2;
            }
            return 0;
        }
        protected override void AssignData()
        {
            if (dataSource == null) dataSource = new Customer();
            (dataSource as TransportFee).FeeCode = this.txtFeeCode.Text;
            (dataSource as TransportFee).FeeName = this.txtFeeName.Text;
            (dataSource as TransportFee).UnitName = this.txtUnitName.Text;
            (dataSource as TransportFee).TaxRate = (decimal)this.txtTaxRate.EditValue;
            (dataSource as TransportFee).Description = this.txtDescription.Text;

            (dataSource as TransportFee).TypeCode = this.lokTypeName.EditValue.ToString();
            base.AssignData();
        }
        public override void RefreshControl()
        {

            this.txtFeeCode.Properties.ReadOnly = this.editMode != FormEditMode.ADD;
            this.txtFeeName.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;
            this.txtUnitName.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;
            this.txtTaxRate.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;
            this.txtDescription.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;

            this.lokTypeName.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;

            base.RefreshControl();
        }

        private void txtTaxRate_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}

