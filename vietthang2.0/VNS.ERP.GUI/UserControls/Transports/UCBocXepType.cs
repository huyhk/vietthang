using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using DevExpress.XtraEditors.Controls;
using VNS.Common;
using VNS.ERP.Data;
using VNS.Windows;

namespace VNS.ERP.GUI.Transports
{
    public partial class UCBocXepType : EditControlBase
    {
        public UCBocXepType()
        {
            InitializeComponent();
        }
        //public void SetDataSoucedCbo(ListBase<AccountClassificationType> lstTypeCode)
        //{
        //    this.cboClassificationTypeCode.Properties.DataSource = lstTypeCode;

        //}
        protected override void BindData()
        {
            if (this.DataSource != null)
            {
                this.txtMaLoai.Text =(dataSource as BocxepType).TypeCode;
                this.txtTenLoai.Text = (dataSource as BocxepType).TypeName;
                this.memoMoTa.Text = (dataSource as BocxepType).Description;
                
            }

        }
        protected override int ValidateData()
        {
            if (this.txtMaLoai.Text == string.Empty)
            {
                this.txtMaLoai.Focus();
                return -1;
            }
            if (this.txtTenLoai.Text == string.Empty)
            {
                this.txtTenLoai.Focus();
                return -2;
            }
            
            return 0;
        }
        protected override void AssignData()
        {
     
            if (dataSource == null) 
                   dataSource = new BocxepType();
            (dataSource as BocxepType).TypeCode = this.txtMaLoai.Text;
            (dataSource as BocxepType).TypeName = this.txtTenLoai.Text;

            (dataSource as BocxepType).Description = this.memoMoTa.Text;
            if (this.EditMode == VNS.Windows.FormEditMode.ADD)
            {

                (dataSource as BocxepType).UserCreated = Contexts.CurrentUser.LoginName;
                (dataSource as BocxepType).DateCreated = DateTime.Now;
            }
            (dataSource as BocxepType).UserUpdated = Contexts.CurrentUser.LoginName;
            (dataSource as BocxepType).DateUpdated = DateTime.Now;
            base.AssignData();
        }
        public override void RefreshControl()
        {
            if (this.editMode == FormEditMode.ADD)
            {
                this.txtMaLoai.Properties.ReadOnly = false;
                this.txtTenLoai.Properties.ReadOnly = false;
                
                this.memoMoTa.Properties.ReadOnly = false;
                this.txtTenLoai.Focus();
                this.txtMaLoai.Focus();
            }
            else if (this.editMode == FormEditMode.EDIT)
            {
                this.txtTenLoai.Properties.ReadOnly = false;
                this.txtMaLoai.Properties.ReadOnly = true ;
                this.memoMoTa.Properties.ReadOnly = false;
                this.txtTenLoai.Focus();

            }
            else// (this.editMode == FormEditMode.VIEW)
            {

                this.txtMaLoai.Properties.ReadOnly = true;
                this.txtTenLoai.Properties.ReadOnly = true;
                this.memoMoTa.Properties.ReadOnly = true;
            }
            base.RefreshControl();
        }

        private void UCBocXepType_Load(object sender, EventArgs e)
        {

        }

        private void txtMaLoai_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void memoMoTa_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTenLoai_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

     

        
       
    }
}
