using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.Windows;
using VNS.ERP.Data;
using VNS.ERP.Data.KCS;

namespace VNS.ERP.GUI
{
    public partial class UCProductTestFrequencys : EditControlBase
    {
        public UCProductTestFrequencys()
        {
            InitializeComponent();
        }
        private string _ProductCode;

        public string ProductCode
        {
            get { return _ProductCode; }
            set { _ProductCode = value; }
        }
        public override void  RefreshControl()
        {
            if (this.EditMode == FormEditMode.ADD)
            {
                this.lookUpEditFrequencyCode.Properties.ReadOnly = false  ;
//                this.lookUpEditProductCode.Properties.ReadOnly = true;
                this.lookUpEditTechCode.Properties.ReadOnly = false;
                this.txtDescription.Properties.ReadOnly = false;
                this.txtStartDate.Properties.ReadOnly = false;
                this.txtQuantity.Properties.ReadOnly = false;
                this.txtQuantityLocal.Properties.ReadOnly = false;
                
            }
            else if (this.EditMode == FormEditMode.EDIT)
            {
                this.txtStartDate.Properties.ReadOnly = true;
  //              this.lookUpEditProductCode.Properties.ReadOnly = true;
                this.lookUpEditTechCode.Properties.ReadOnly = true;
                this.txtDescription.Properties.ReadOnly = false;
                this.txtQuantity.Properties.ReadOnly = false;
                this.lookUpEditFrequencyCode.Properties.ReadOnly = false;
                this.txtQuantityLocal.Properties.ReadOnly = false;
            }
            else
            {
                this.lookUpEditFrequencyCode.Properties.ReadOnly = true;
                //this.lookUpEditProductCode.Properties.ReadOnly = true;
                this.lookUpEditTechCode.Properties.ReadOnly = true;
                this.txtDescription.Properties.ReadOnly = true;
                this.txtStartDate.Properties.ReadOnly = true;
                this.txtQuantity.Properties.ReadOnly = true;
                this.txtQuantityLocal.Properties.ReadOnly = true;
            }
 	         base.RefreshControl();
        }
        protected override int ValidateData()
        {
            if (this.lookUpEditFrequencyCode.EditValue==null||this.lookUpEditFrequencyCode.EditValue.ToString() == string.Empty )
            {
                return -1;
            }
            //if (this.lookUpEditProductCode.EditValue == null||this.lookUpEditProductCode.EditValue.ToString() == string.Empty)
            //{
            //    return -2;
            //}
            if (this.lookUpEditTechCode.EditValue == null||this.lookUpEditTechCode.EditValue.ToString() == string.Empty)
            {
                return -3;
            }
            //if (Convert.ToDecimal(txtQuantity.Text) ==0)
            //{
            //    txtQuantity.Focus();
            //    return -4;
            //}
         
            return base.ValidateData();
        }
        protected override void AssignData()
        {
            if (this.dataSource == null)
                dataSource = new ProductTestFrequency();
             (dataSource as ProductTestFrequency).FrequencyType=this.lookUpEditFrequencyCode.EditValue.ToString();
             (dataSource as ProductTestFrequency).ProductCode=this.ProductCode;
             (dataSource as ProductTestFrequency).TechCode=this.lookUpEditTechCode.EditValue.ToString() ;
             (dataSource as ProductTestFrequency).Description=this.txtDescription.Text ;
             (dataSource as ProductTestFrequency).StartDate=this.txtStartDate.DateTime;
             (dataSource as ProductTestFrequency).Quantity=Convert.ToDecimal(txtQuantity.EditValue) ;
             (dataSource as ProductTestFrequency).QuantityLocal = Convert.ToDecimal(txtQuantityLocal.EditValue);

             if (this.EditMode == VNS.Windows.FormEditMode.ADD)
             {

                 (dataSource as ProductTestFrequency).UserCreated = Contexts.CurrentUser.LoginName;
                 (dataSource as ProductTestFrequency).DateCreated = DateTime.Now;
             }
             (dataSource as ProductTestFrequency).UserUpdated = Contexts.CurrentUser.LoginName;
             (dataSource as ProductTestFrequency).DateUpdated = DateTime.Now;
            base.AssignData();
        }
        protected override void BindData()
        {
            if (this.dataSource != null)
            {

                this.lookUpEditFrequencyCode.EditValue = (dataSource as ProductTestFrequency).FrequencyType;
           //     this.lookUpEditProductCode.EditValue = (dataSource as ProductTestFrequency).ProductCode;
                this.lookUpEditTechCode.EditValue = (dataSource as ProductTestFrequency).TechCode;
                this.txtDescription.Text  = (dataSource as ProductTestFrequency).Description;
                this.txtStartDate.EditValue  = (dataSource as ProductTestFrequency).StartDate;
                this.txtQuantity.EditValue = (dataSource as ProductTestFrequency).Quantity;
                this.txtQuantityLocal.EditValue = (dataSource as ProductTestFrequency).QuantityLocal;
                
            }
                base.BindData();
        }
        protected override void InitDataObject()
        {
            
            if (!DesignMode)
            {
                //this.lookUpEditProductCode.Properties.DataSource = new ProductBLL().GetAll();
                this.lookUpEditTechCode.Properties.DataSource = new TechnicalTestBLL().GetAll();
                this.lookUpEditFrequencyCode.Properties.DataSource = EnumDisplays.GetListenumFrequencyType();

            }
            base.InitDataObject();
        }

        private void txtStartDate_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
