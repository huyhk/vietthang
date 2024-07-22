using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.KCS;
using VNS.Common;
using VNS.Windows;

namespace VNS.ERP.GUI.KCS
{
    public partial class FormListProductTestRequest : VNS.Windows.Forms.FormEditBase
    {
        private enumKCSDepartment department = enumKCSDepartment.QLCL;
        public enumKCSDepartment Department
        {
            get { return department; }
            set
            {
                department = value;
            }
        }
        ProductTestRequestBLL bll = new ProductTestRequestBLL();
        public FormListProductTestRequest()
        {
            InitializeComponent();
        }
          /// <summary>
        /// Use to call from MainForm
        /// </summary>
        /// <param name="department"></param>
        /// <param name="textForm"></param>
        public FormListProductTestRequest(enumKCSDepartment department, string textForm)
        {
            InitializeComponent();
            this.Business = bll;
            this.Department = department;
            this.Text = textForm;
            lookUpPeriod.Properties.DataSource = new PeriodBLL().GetAll();
            lookUpPeriod.EditValue = Contexts.WorkingPeriod.PeriodCode;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (this.Department == enumKCSDepartment.PTN)
            {
                this.btnAdd.Visible = false;
                this.btnEdit.Visible = false;
                this.btnRemove.Visible = false;
                this.btnSave.Visible = false;
                this.btnSaveClose.Visible = false;
                this.btnSaveNew.Visible = false;
            }
        }
        public override void AddNewItem()
        {
            FormEditProductTestRequest f = new FormEditProductTestRequest(this.Department, this.Text);
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.AddNewItem();
            this.ShowChildForm(f);
            this.RefreshButtons();
        }
        public override void EditItem()
        {
            ProductTestRequestBLL bll = new ProductTestRequestBLL();
            ProductTestRequest t = bll.GetByRequestID((this.CurrentItem as ProductTestRequest).RequestID);
            if (t == null)
            {
                MessageBox.Show(this.GetTextMessage("DELETE-1", "Phiếu đã bị xóa trước đó!"));
                return;
            }
            (this.currentItem as ProductTestRequest).IsReceived = t.IsReceived;
            if ((this.currentItem as ProductTestRequest).IsReceived == true)
            {
                this.editMode = FormEditMode.VIEW;
                MessageBox.Show(this.GetTextMessage("UpdateIsReceived", "Phiếu yêu cầu kiểm tra đã được nhận, không thể sửa!"));
            }
            else
            {
                FormEditProductTestRequest f = new FormEditProductTestRequest(this.Department, this.Text);
                SetFormPrivilege(f);
                f.DataSource = this.DataSource;
                f.CurrentItem = this.CurrentItem;
                f.EditItem();
                this.ShowChildForm(f);
                this.RefreshButtons();
            }
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FormEditProductTestRequest f = new FormEditProductTestRequest(this.Department, this.Text);
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.CurrentItem = this.CurrentItem;
            this.ShowChildForm(f);
            this.RefreshButtons();
        }
        private void RefeshListDataSource()
        {
            Period p = (lookUpPeriod.Properties.DataSource as ListBase<Period>).Search("PeriodCode", lookUpPeriod.EditValue.ToString());
            this.DataSource = this.bll.GetForPeriod(p.StartDate, p.EndDate);
            this.gridControl1.RefreshDataSource();
            this.gridControl1.Refresh();
            this.gridView1.RefreshData();
        }

        private void lookUpPeriod_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpPeriod.EditValue != null)
            {
                this.RefeshListDataSource();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (lookUpPeriod.EditValue != null)
            {
                this.RefeshListDataSource();
            }
        }
        public override void Delete()
        {
            ProductTestRequestBLL bll = new ProductTestRequestBLL();
            ProductTestRequest t = bll.GetByRequestID((this.CurrentItem as ProductTestRequest).RequestID);
            if (t == null)
            {
                MessageBox.Show(this.GetTextMessage("DELETE-1", "Phiếu đã bị xóa trước đó!"));
                return;
            }
            (this.currentItem as ProductTestRequest).IsReceived = t.IsReceived;
            if ((this.currentItem as ProductTestRequest).IsReceived == true)
            {
                this.editMode = FormEditMode.VIEW;
                MessageBox.Show(this.GetTextMessage("DeleteIsReceived", "Phiếu yêu cầu kiểm tra đã được nhận, không thể xóa!"));
            }
            else
            {
                base.Delete();
            }
        }
    }
}

