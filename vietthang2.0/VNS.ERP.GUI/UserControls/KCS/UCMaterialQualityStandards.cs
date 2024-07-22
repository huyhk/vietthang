using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.ERP.Data;
using VNS.ERP.Data.KCS;
using VNS.Windows;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class UCMaterialQualityStandards : EditControlBase
    {
        public UCMaterialQualityStandards()
        {
            InitializeComponent();
     
        }
        private string itemCode = "";
        public string ItemCode
        {
            get { return itemCode; }
            set { itemCode = value; }
        }

        protected override void BindData()
        {
            if (DataSource != null)
            {
                MaterialQualityStandards t= (DataSource as MaterialQualityStandards);
                this.dateEditStartDate.EditValue = t.StartDate;
                //this.txtItemCode.EditValue = materialTestFrequencys.ItemCode;
                this.lookUpTechnic.EditValue = t.TechCode;
                this.txtValueString.EditValue  = t.ValueString;
                this.txtDescription.EditValue = t.Description;
                this.lookUpConditionType.EditValue = t.ConditionType;
            }
            base.BindData();
        }
        public void SetDss()
        {
            //Enum t=new enumFrequencyType();
            //ListBase<Enum> list = EnumDisplays.GetListenumFrequencyType();
            //Enum e = list.Search("EnumText", enumFrequencyType.Block.ToString());
            //if (e != null)
            //{
            //    list.Remove(list.IndexOf(e));
            //}
            lookUpConditionType.Properties.DataSource = EnumDisplays.GetListenumKCSConditionType();
            //lookUpFrequencyType.Properties.DataSource = list;
            lookUpConditionType.Properties.DisplayMember = "EnumText";
            lookUpConditionType.Properties.ValueMember = "EnumName";

            lookUpTechnic.Properties.DataSource = new TechnicalTestBLL().GetAll();
            lookUpTechnic.Properties.DisplayMember = "TechName";
            lookUpTechnic.Properties.ValueMember = "TechCode";
        }
        protected override void AssignData()
        {
            if (DataSource == null) DataSource = new MaterialTestFrequencys();
            MaterialQualityStandards materialTestFrequencys = (DataSource as MaterialQualityStandards);

            if (this.EditMode == FormEditMode.ADD)
            {
                materialTestFrequencys.UserCreated = Contexts.CurrentUser.LoginName;
                materialTestFrequencys.DateCreated = DateTime.Now;
            }
            materialTestFrequencys.UserUpdated = Contexts.CurrentUser.LoginName;
            materialTestFrequencys.DateUpdated = DateTime.Now;
            materialTestFrequencys.ItemCode = this.ItemCode;
            materialTestFrequencys.StartDate = dateEditStartDate.DateTime.Date;
            materialTestFrequencys.ValueString  = this.txtValueString.EditValue.ToString();
            materialTestFrequencys.TechCode = this.lookUpTechnic.EditValue.ToString();
            materialTestFrequencys.Description = txtDescription.Text;
            materialTestFrequencys.ConditionType = this.lookUpConditionType.EditValue.ToString();
            base.AssignData();
        }

        protected override int ValidateData()
        {
            txtDescription.Text = txtDescription.Text.Trim();
            if (lookUpTechnic.EditValue.ToString() == "")
            {
                lookUpTechnic.Focus();
                return -2;
            }

            if (lookUpConditionType.EditValue.ToString() == "")
            {
                lookUpConditionType.Focus();
                return -1;
            }
            if (txtValueString.Text == "")
            {
                txtValueString.Focus();
                return -3;
            }
            return base.ValidateData();
        }

        public override void RefreshControl()
        {
            if (this.EditMode == FormEditMode.ADD)
            {
                this.lookUpTechnic.Focus();
            }
            if (this.EditMode == FormEditMode.EDIT)
            {
                this.txtValueString.Focus();
            }
            dateEditStartDate.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW || this.EditMode == FormEditMode.EDIT;
            this.lookUpConditionType.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW;
            lookUpTechnic.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW || this.EditMode == FormEditMode.EDIT;
            //txtItemCode.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW || this.EditMode == FormEditMode.EDIT;
            txtDescription.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW;
            this.txtValueString .Properties.ReadOnly = this.EditMode == FormEditMode.VIEW;
            base.RefreshControl();
        }

        private void lookUpTechnic_EditValueChanged(object sender, EventArgs e)
        {
            if (this.lookUpTechnic.EditValue != null && this.lookUpTechnic.EditValue.ToString() != String.Empty)
            {
                string techcode = this.lookUpTechnic.EditValue.ToString();
                TechnicalTest t = (this.lookUpTechnic.Properties.DataSource as ListBase<TechnicalTest>).Search("TechCode", techcode);
                //this.lookUpTechnic.GetColumnValue("ResultType").ToString();

                if (t.ResultType == enumResultTypeTechnicalTest.Decimal.ToString())
                {
                    this.txtValueString.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                    this.txtValueString.Properties.Mask.EditMask = AppConfigs.CONFIG_QUANTITYMASK;
                }
                else if (t.ResultType == enumResultTypeTechnicalTest.Text.ToString())
                {
                    this.txtValueString.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
                }
                else  //if(t.ResultType == enumResultTypeTechnicalTest.Percent.ToString())
                {
                    this.txtValueString.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                    this.txtValueString.Properties.Mask.EditMask = ModuleKCS.CONFIG_TECH_PERCENTFORMAT;
                }
               
                this.txtValueString.Properties.Mask.UseMaskAsDisplayFormat = true;
            }   
        }

      

    }
}
