using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.ERP.Data;
using VNS.Windows;
using VNS.Common;


namespace VNS.ERP.GUI.UserControl
{
    public partial class DetailStock : EditControlBase
    {
        public delegate void btnClick(object sender, EventArgs e, string sCode, string sName);
        public event btnClick OnBtnClick;
        public string ControllerName
        {
            get { return this.LookupController.EditValue.ToString(); }
            set { }
        }
        //public FormStock frmParentMe;
        public DetailStock()
        {
            InitializeComponent();
            btn.BackColor = this.BackColor;
           // btn.Visible = false;
        }
        #region Method
        public void SetLookupController(object Data)
        {
            this.LookupController.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeID", 20, "Mã NV"));
            this.LookupController.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeName", 50, "Tên NV"));
            this.LookupController.Properties.ValueMember = "EmployeeID";
            this.LookupController.Properties.DisplayMember = "EmployeeName";
            //this.LookupController.Properties.Columns.
            this.LookupController.Properties.DataSource = Data;
        }
        protected override void InitDataObject()
        {
            if (!this.DesignMode)
            {
                ListBase<Branch> lst = new BranchBLL().GetAll();
                //radioButton1.re
                lst.Add(new Branch());
                lookUpBranchCode.Properties.DataSource = lst;

                this.repItemName.DataSource = new ItemBLL().GetAll();
                base.InitDataObject();
            }
        }
        protected override void BindData()
        {
            if (dataSource != null)
            {
                this.LookupController.EditValue = (dataSource as Stock).Controller;
                if (this.LookupController.EditValue == null)
                {
                    this.LookupController.ItemIndex = 0;
                }
                this.TxtAddress.Text = (dataSource as Stock).Address;
                this.TxtDescription.Text = (dataSource as Stock).Description;
                this.TxtFax.Text = (dataSource as Stock).Fax;
                this.TxtPhone.Text = (dataSource as Stock).Phone;
                this.TxtStockCode.Text = (dataSource as Stock).StockCode;
                this.TxtStockName.Text = (dataSource as Stock).StockName;
                this.ChkIsManufacture.Checked = (dataSource as Stock).IsManufacture;
                this.ChkHasLocation.Checked = (dataSource as Stock).HasLocation;
                this.TxtSoHieu.Text = (dataSource as Stock).SoHieu;
                this.lookUpBranchCode.EditValue = (dataSource as Stock).BranchCode;

                if (this.ChkHasLocation.Checked)
                {
                    btn.Enabled = true;
                }
                else
                {
                    btn.Enabled = false;
                }
                this.cboStockType.EditValue = (dataSource as Stock).StockType;
                this.chkInActive.Checked = (dataSource as Stock).InActive;

                this.gridControlItemAuto.DataSource = (dataSource as Stock).ListItemStockAuto;
            }
            base.BindData();
        }

        protected override void AssignData()
        {
            if (dataSource == null) dataSource = new Stock();
            (dataSource as Stock).StockCode = this.TxtStockCode.Text;
            (dataSource as Stock).StockName = this.TxtStockName.Text;
            (dataSource as Stock).Address = this.TxtAddress.Text;
            (dataSource as Stock).Phone = this.TxtPhone.Text;
            (dataSource as Stock).Fax = this.TxtFax.Text;
            if (this.EditMode == FormEditMode.ADD)
            {
                (dataSource as Stock).UserCreated = Contexts.CurrentUser.LoginName;
                (dataSource as Stock).DateCreated = DateTime.Now;
            }
            //(dataSource as Stock).BranchCode = this.lookUpBranchCode.EditValue.ToString();
            if (this.lookUpBranchCode.EditValue != null)
            {
                (dataSource as Stock).BranchCode = this.lookUpBranchCode.EditValue.ToString();
            }
            else
            {
                (dataSource as Stock).BranchCode = string.Empty;
            }
            (dataSource as Stock).UserUpdated = Contexts.CurrentUser.LoginName;
            (dataSource as Stock).DateUpdated = DateTime.Now;
            (dataSource as Stock).Description = this.TxtDescription.Text;
            (dataSource as Stock).Controller = (string)this.LookupController.EditValue;
            (dataSource as Stock).IsManufacture = this.ChkIsManufacture.Checked;
            (dataSource as Stock).HasLocation = this.ChkHasLocation.Checked;
            (dataSource as Stock).SoHieu = TxtSoHieu.Text;

            (dataSource as Stock).StockType = this.cboStockType.Text;
            (dataSource as Stock).InActive = this.chkInActive.Checked;

            base.AssignData();
        }

        protected override int ValidateData()
        {
            this.TxtStockCode.Text = this.TxtStockCode.Text.Trim();
            this.TxtStockName.Text = this.TxtStockName.Text.Trim();
            this.TxtAddress.Text = this.TxtAddress.Text.Trim();
            this.TxtDescription.Text = this.TxtDescription.Text.Trim();
            TxtSoHieu.Text = TxtSoHieu.Text.Trim();
            if (this.TxtStockCode.Text == "")
            {
                TxtStockCode.Focus();
                return -1;
            }
            if (this.LookupController.Text == "")
            {
                LookupController.Focus();
                return -2;
            }
            if (this.TxtStockName.Text == "")
            {
                TxtStockName.Focus();
                return -3;
            }
            if (TxtSoHieu.Text == "")
            {
                TxtSoHieu.Focus();
                return -4;
            }
            //if(lookUpBranchCode.e
            return base.ValidateData();
        }
        #endregion
        public override void RefreshControl()
        {
            TxtStockCode.Properties.ReadOnly = (this.editMode == FormEditMode.VIEW) || (this.editMode == FormEditMode.EDIT);
            TxtDescription.Properties.ReadOnly = (this.editMode == FormEditMode.VIEW);
            TxtStockName.Properties.ReadOnly = (this.editMode == FormEditMode.VIEW);
            TxtAddress.Properties.ReadOnly = (this.editMode == FormEditMode.VIEW);
            TxtFax.Properties.ReadOnly = (this.editMode == FormEditMode.VIEW);
            TxtPhone.Properties.ReadOnly = (this.editMode == FormEditMode.VIEW);
            TxtSoHieu.Properties.ReadOnly = (this.editMode == FormEditMode.VIEW);
            ChkHasLocation.Properties.ReadOnly = (this.editMode == FormEditMode.VIEW);
            ChkIsManufacture.Properties.ReadOnly = (this.editMode == FormEditMode.VIEW);
            LookupController.Properties.ReadOnly = (this.editMode == FormEditMode.VIEW);
            lookUpBranchCode.Properties.ReadOnly = (this.editMode == FormEditMode.VIEW);
            cboStockType.Properties.ReadOnly = (this.editMode == FormEditMode.VIEW);
            chkInActive.Properties.ReadOnly = (this.editMode == FormEditMode.VIEW);

            gridViewItemAuto.OptionsBehavior.Editable = (this.editMode != FormEditMode.VIEW);
            //btn.Enabled = (this.editMode == FormEditMode.VIEW) && ;

            if (this.editMode == FormEditMode.ADD)
            {
                TxtStockCode.Focus();
                //TxtStockCode.BackColor = txtBackGround.BackColor;
                //TxtDescription.BackColor = txtBackGround.BackColor;
                //TxtStockName.BackColor = txtBackGround.BackColor;
                //TxtAddress.BackColor = txtBackGround.BackColor;
                //TxtFax.BackColor = txtBackGround.BackColor;
                //TxtPhone.BackColor = txtBackGround.BackColor;
                //TxtSoHieu.BackColor = txtBackGround.BackColor;
                //LookupController.BackColor = txtBackGround.BackColor;
            }
            if (this.editMode == FormEditMode.EDIT)
            {
                TxtStockName.Focus();
                //TxtStockCode.BackColor = lbStockCode.BackColor;
                //TxtDescription.BackColor = txtBackGround.BackColor;
                //TxtStockName.BackColor = txtBackGround.BackColor;
                //TxtAddress.BackColor = txtBackGround.BackColor;
                //TxtFax.BackColor = txtBackGround.BackColor;
                //TxtPhone.BackColor = txtBackGround.BackColor;
                //TxtSoHieu.BackColor = txtBackGround.BackColor;
                //LookupController.BackColor = txtBackGround.BackColor;
            }
            if (this.editMode == FormEditMode.VIEW)
            {
                //TxtStockCode.BackColor = lbStockCode.BackColor;
                //TxtDescription.BackColor = lbStockCode.BackColor;
                //TxtStockName.BackColor = lbStockCode.BackColor;
                //TxtAddress.BackColor = lbStockCode.BackColor;
                //TxtFax.BackColor = lbStockCode.BackColor;
                //TxtPhone.BackColor = lbStockCode.BackColor;
                //TxtSoHieu.BackColor = lbStockCode.BackColor;
                //LookupController.BackColor = lbStockCode.BackColor;
            }
            if (this.ChkHasLocation.Checked)
            {
                btn.Enabled = (this.editMode == FormEditMode.VIEW);
            }
            else
            {
                btn.Enabled = false ;
            }
            if (this.DataSource == null)
            {
                //this.LookupController.EditValue = (dataSource as Stock).Controller;
                //if (this.LookupController.EditValue == null)
                //{
                //    this.LookupController.ItemIndex = 0;
                //}
                this.TxtAddress.Text = "";
                this.TxtDescription.Text = "";
                this.TxtFax.Text = "";
                this.TxtPhone.Text = "";
                this.TxtStockCode.Text = "";
                this.TxtStockName.Text = "";
                this.ChkIsManufacture.Checked = false;
                this.ChkHasLocation.Checked = false;
                this.TxtSoHieu.Text = "";
                btn.Enabled = false;
            }
            base.RefreshControl();
        }
        private void TxtFax_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            string sCode = this.TxtStockCode.Text;
            DetailStockLocation.sCode = sCode;
            if (OnBtnClick != null) OnBtnClick(this, e, sCode, TxtStockName.Text);
        }

        private void ChkHasLocation_CheckedChanged(object sender, EventArgs e)
        {
            //if (frmParentMe.EditMode != FormEditMode.ADD)
            //{
            //    if (this.ChkHasLocation.Checked)
            //    {
            //        btn.Enabled = true;
            //    }
            //    else
            //    {
            //        btn.Enabled = false;
            //    }
            //}
        }

        private void btn_EditValueChanged(object sender, EventArgs e)
        {

        }
        //override 
     }
}
