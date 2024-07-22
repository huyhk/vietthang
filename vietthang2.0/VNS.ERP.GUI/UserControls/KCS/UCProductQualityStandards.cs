using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.Data;
using VNS.ERP.Data;
using VNS.ERP.Data.KCS;
using VNS.Windows;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class UCProductQualityStandards : EditControlBase
    {
        public UCProductQualityStandards()
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
                this.lookUpEditConditionType.Properties.ReadOnly = false  ;
//                this.lookUpEditProductCode.Properties.ReadOnly = true;
                this.lookUpEditTechCode.Properties.ReadOnly = false;
                this.txtDescription.Properties.ReadOnly = false;
                this.txtStartDate.Properties.ReadOnly = false;
                this.txtValueString.Properties.ReadOnly = false;
                
            }
            else if (this.EditMode == FormEditMode.EDIT)
            {
                this.txtStartDate.Properties.ReadOnly = true;
  //              this.lookUpEditProductCode.Properties.ReadOnly = true;
                this.lookUpEditTechCode.Properties.ReadOnly = true;
                this.txtDescription.Properties.ReadOnly = false;
                this.txtValueString.Properties.ReadOnly = false;
                this.lookUpEditConditionType.Properties.ReadOnly = false;
            }
            else
            {
                this.lookUpEditConditionType.Properties.ReadOnly = true;
                //this.lookUpEditProductCode.Properties.ReadOnly = true;
                this.lookUpEditTechCode.Properties.ReadOnly = true;
                this.txtDescription.Properties.ReadOnly = true;
                this.txtStartDate.Properties.ReadOnly = true;
                this.txtValueString.Properties.ReadOnly = true;
            }
 	         base.RefreshControl();
        }
        protected override int ValidateData()
        {
            if (this.lookUpEditConditionType.EditValue==null||this.lookUpEditConditionType.EditValue.ToString() == string.Empty )
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
            if (txtValueString.Text ==string.Empty)
            {
                txtValueString.Focus();
                return -4;
            }
         
            return base.ValidateData();
        }
        protected override void AssignData()
        {
            if (this.dataSource == null)
                dataSource = new ProductQualityStandards();
            (dataSource as ProductQualityStandards).ConditionType = this.lookUpEditConditionType.EditValue.ToString();
            (dataSource as ProductQualityStandards).ProductCode = this.ProductCode;
            (dataSource as ProductQualityStandards).TechCode = this.lookUpEditTechCode.EditValue.ToString();
            (dataSource as ProductQualityStandards).Description = this.txtDescription.Text;
             (dataSource as ProductQualityStandards).StartDate=this.txtStartDate.DateTime;
             (dataSource as ProductQualityStandards).ValueString=txtValueString.EditValue.ToString();
             if (this.EditMode == VNS.Windows.FormEditMode.ADD)
             {

                 (dataSource as ProductQualityStandards).UserCreated = Contexts.CurrentUser.LoginName;
                 (dataSource as ProductQualityStandards).DateCreated = DateTime.Now;
             }
             (dataSource as ProductQualityStandards).UserUpdated = Contexts.CurrentUser.LoginName;
             (dataSource as ProductQualityStandards).DateUpdated = DateTime.Now;
            base.AssignData();
        }
        protected override void BindData()
        {
            if (this.dataSource != null)
            {

                this.lookUpEditConditionType.EditValue = (dataSource as ProductQualityStandards).ConditionType;
           //     this.lookUpEditProductCode.EditValue = (dataSource as ProductQualityStandards).ProductCode;
                this.lookUpEditTechCode.EditValue = (dataSource as ProductQualityStandards).TechCode;
                this.txtDescription.Text  = (dataSource as ProductQualityStandards).Description;
                this.txtStartDate.EditValue  = (dataSource as ProductQualityStandards).StartDate;
                this.txtValueString.EditValue= (dataSource as ProductQualityStandards).ValueString;
                
            }
                base.BindData();
        }
        protected override void InitDataObject()
        {
            
            if (!DesignMode)
            {
                //this.lookUpEditProductCode.Properties.DataSource = new ProductBLL().GetAll();
                this.lookUpEditTechCode.Properties.DataSource = new TechnicalTestBLL().GetAll();
                this.lookUpEditConditionType.Properties.DataSource = EnumDisplays.GetListenumKCSConditionType();

            }
            base.InitDataObject();
        }

      
        private void lookUpEditTechCode_EditValueChanged(object sender, EventArgs e)
        {
            if (this.lookUpEditTechCode.EditValue != null && this.lookUpEditTechCode.EditValue.ToString() != String.Empty)
            {
                string techcode = this.lookUpEditTechCode.EditValue.ToString();
                TechnicalTest t = (this.lookUpEditTechCode.Properties.DataSource as ListBase<TechnicalTest>).Search("TechCode", techcode);
                if (t.ResultType == enumResultTypeTechnicalTest.Text.ToString())
                {
                    this.txtValueString.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
                }
                else if (t.ResultType == enumResultTypeTechnicalTest.Percent.ToString())
                {
                    this.txtValueString.Properties.Mask.EditMask = ModuleKCS.CONFIG_TECH_PERCENTFORMAT;
                    this.txtValueString.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                }
                else // (t.ResultType == enumResultTypeTechnicalTest.Decimal.ToString())
                {
                    this.txtValueString.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                    this.txtValueString.Properties.Mask.EditMask = AppConfigs.CONFIG_QUANTITYMASK;
                }

                this.txtValueString.Properties.Mask.UseMaskAsDisplayFormat = true;
            }   
        }

        

    }
}
