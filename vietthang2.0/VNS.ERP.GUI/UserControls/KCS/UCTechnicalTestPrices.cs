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
    public partial class UCTechnicalTestPrices : EditControlBase
    {
        private string subjectCode = "";
        public string SubjectCode
        {
            get { return subjectCode; }
            set { subjectCode = value; }
        }

        public UCTechnicalTestPrices()
        {
            InitializeComponent();
            this.txtPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrice.Properties.Mask.EditMask = AppConfigs.CONFIG_PRICEVNMASK;
            this.txtPrice.Properties.Mask.UseMaskAsDisplayFormat = true;
            
        }

        protected override void BindData()
        {
            if (DataSource != null)
            {
                TechnicalTestPrice technicalTestPrice = (DataSource as TechnicalTestPrice);
                this.dateEditStartDate.EditValue = technicalTestPrice.StartDate;
                //this.txtItemCode.EditValue = materialTestFrequencys.ItemCode;
                this.lookUpTechnical.EditValue = technicalTestPrice.TechCode;
                //this.lookUpAnalizeSubject.EditValue = technicalTestPrice.SubjectCode;
                this.txtPrice.Text = technicalTestPrice.Price.ToString();
                this.txtDescription.Text = technicalTestPrice.Description;
            }
            base.BindData();
        }
        public void SetDss()
        {
            //lookUpAnalizeSubject.Properties.DataSource = new AnalizeSubjectBLL().GetAll();
            //lookUpAnalizeSubject.Properties.DisplayMember = "SubjectName";
            //lookUpAnalizeSubject.Properties.ValueMember = "SubjectCode";

            lookUpTechnical.Properties.DataSource = new TechnicalTestBLL().GetAll();
            lookUpTechnical.Properties.DisplayMember = "TechName";
            lookUpTechnical.Properties.ValueMember = "TechCode";
        }
        protected override void AssignData()
        {
            if (DataSource == null) DataSource = new TechnicalTestPrice();
            TechnicalTestPrice technicalTestPrice = (DataSource as TechnicalTestPrice);

            if (this.EditMode == FormEditMode.ADD)
            {
                technicalTestPrice.UserCreated = Contexts.CurrentUser.LoginName;
                technicalTestPrice.DateCreated = DateTime.Now.Date;
            }
            technicalTestPrice.UserUpdated = Contexts.CurrentUser.LoginName;
            technicalTestPrice.DateUpdated = DateTime.Now.Date;
            technicalTestPrice.SubjectCode = this.SubjectCode;
            technicalTestPrice.StartDate = dateEditStartDate.DateTime.Date;
            technicalTestPrice.Price = Convert.ToDecimal(txtPrice.EditValue);
            technicalTestPrice.TechCode = this.lookUpTechnical.EditValue.ToString();
            technicalTestPrice.Description = txtDescription.Text;
            base.AssignData();
        }

        protected override int ValidateData()
        {
            txtDescription.Text = txtDescription.Text.Trim();
            if (lookUpTechnical.EditValue.ToString() == "")
            {
                lookUpTechnical.Focus();
                return -1;
            }
            
            //if (Convert.ToDecimal(txtPrice.Text) <=0 )
            //{
            //    txtPrice.Focus();
            //    return -2;
            //}

            return base.ValidateData();
        }

        public override void RefreshControl()
        {
            if (this.EditMode == FormEditMode.ADD)
            {
                this.lookUpTechnical.Focus();
            }
            if (this.EditMode == FormEditMode.EDIT)
            {
                this.txtPrice.Focus();
            }
            dateEditStartDate.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW || this.EditMode == FormEditMode.EDIT;
            lookUpTechnical.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW || this.EditMode == FormEditMode.EDIT;
            //txtItemCode.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW || this.EditMode == FormEditMode.EDIT;
            txtDescription.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW;
            txtPrice.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW;
            base.RefreshControl();
        }
    }
}
