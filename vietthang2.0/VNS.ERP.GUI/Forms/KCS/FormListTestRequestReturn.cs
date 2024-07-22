using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.KCS;
using VNS.Windows;
using VNS.Common;

namespace VNS.ERP.GUI.KCS
{
    public partial class FormListTestRequestReturn : VNS.Windows.Forms.FormEditBase
    {
        private enumKCSDepartment department = enumKCSDepartment.PTN;
        private enumKCSDepartment Department
        {
            get { return department; }
            set
            {
                department = value;
            }
        }
        TestRequestReturnBLL bll = new TestRequestReturnBLL(); 
        public FormListTestRequestReturn()
        {
            InitializeComponent();
        }
        public FormListTestRequestReturn(enumKCSDepartment department, string textForm)
        {
            InitializeComponent();
            this.Business = bll;
            this.Department = department;
            this.Text = textForm;
            lookUpPeriod.Properties.DataSource = new PeriodBLL().GetAll();
            lookUpPeriod.EditValue = Contexts.WorkingPeriod.PeriodCode;
        }
        public override void AddNewItem()
        {
            FormEditTestRequestReturn f = new FormEditTestRequestReturn(this.Department, this.Text);
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.AddNewItem();
            this.ShowChildForm(f);
            this.RefreshButtons();
        }
        public override void EditItem()
        {
            //TestRequestReturnBLL bll = new TestRequestReturnBLL();
            //TestRequestReturn t = bll.GetByReturnID((this.CurrentItem as TestRequestReturn).ReturnID);
            //if (t == null)
            //{
            //    MessageBox.Show(this.GetTextMessage("DELETE-1", "Phiếu đã bị xóa!"));
            //    return;
            //}
            //(this.currentItem as TestRequestReturn).IsReceived = t.IsReceived;
            if ((this.currentItem as TestRequestReturn).IsReceived == true)
            {
                this.editMode = FormEditMode.VIEW;
                MessageBox.Show(this.GetTextMessage("UpdateIsReceived", "Phiếu trả kết quả đã được QLCL nhận, không thể sửa!"));
            }
            else
            {
                FormEditTestRequestReturn f = new FormEditTestRequestReturn(this.Department, this.Text);
                SetFormPrivilege(f);
                f.DataSource = this.DataSource;
                f.CurrentItem = this.CurrentItem;
                f.EditItem();
                this.ShowChildForm(f);
                this.RefreshButtons();
            }
        }

        public override void Delete()
        {
            //TestRequestReturnBLL bll = new TestRequestReturnBLL();
            //TestRequestReturn t = bll.GetByReturnID((this.CurrentItem as TestRequestReturn).ReturnID);
            //if (t == null)
            //{
            //    MessageBox.Show(this.GetTextMessage("DELETE-1", "Phiếu đã bị xóa!"));
            //    return;
            //}
            //(this.currentItem as TestRequestReturn).IsReceived = t.IsReceived;
            if ((this.currentItem as TestRequestReturn).IsReceived == true)
            {
                this.editMode = FormEditMode.VIEW;
                MessageBox.Show(this.GetTextMessage("DeleteIsReceived", "Phiếu trả kết quả đã được QLCL nhận, không thể xóa!"));
            }
            else
            {
                base.Delete();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FormEditTestRequestReturn f = new FormEditTestRequestReturn(this.Department, this.Text);
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
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (this.Department == enumKCSDepartment.QLCL)
            {
                this.btnAdd.Visible = false;
                this.btnEdit.Visible = false;
                this.btnRemove.Visible = false;
                this.btnSave.Visible = false;
                this.btnSaveClose.Visible = false;
                this.btnSaveNew.Visible = false;
            }
        }
        public override void RefreshButtons()
        {
            base.RefreshButtons();
            if (this.Department == enumKCSDepartment.QLCL)
            {
                this.btnAdd.Visible = false;
                this.btnEdit.Visible = false;
                this.btnRemove.Visible = false;
                this.btnSave.Visible = false;
                this.btnSaveClose.Visible = false;
                this.btnSaveNew.Visible = false;
            }
        }
    }
}

