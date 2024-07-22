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
    public partial class FormListTechnicalTestReturn : VNS.Windows.Forms.FormEditBase
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
        TechnicalTestReturnBLL bll = new TechnicalTestReturnBLL();
        private string stockCode = string.Empty;
        public FormListTechnicalTestReturn(enumKCSDepartment department, string textForm)
        {
            InitializeComponent();
            this.Business = bll;
            this.Department = department;
            this.Text = textForm;
            lookUpPeriod.Properties.DataSource = new PeriodBLL().GetAll();
            lookUpPeriod.EditValue = Contexts.WorkingPeriod.PeriodCode;
            lookUpEditStockCode.Properties.DataSource = new StockBLL().GetAllForMember(Contexts.CurrentUser.LoginName);
        }
        public override void AddNewItem()
        {
            FormEditTechnicalTestReturn f = new FormEditTechnicalTestReturn(this.Department, this.Text, this.stockCode);
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.AddNewItem();
            this.ShowChildForm(f);
            this.RefreshButtons();
        }
        public override void EditItem()
        {
            //TechnicalTestReturnBLL bll = new TechnicalTestReturnBLL();
            //TechnicalTestReturn t = bll.GetByReturnID((this.CurrentItem as TechnicalTestReturn).ReturnID);
            //if (t == null)
            //{
            //    MessageBox.Show(this.GetTextMessage("DELETE-1", "Phiếu đã bị xóa!"));
            //    return;
            //}
            //(this.currentItem as TechnicalTestReturn).IsReceived = t.IsReceived;
            if ((this.currentItem as TechnicalTestReturn).IsReceived == true)
            {
                this.editMode = FormEditMode.VIEW;
                MessageBox.Show(this.GetTextMessage("UpdateIsReceived", "Phiếu trả kết quả đã được QLCL nhận, không thể sửa!"));
            }
            else
            {
                FormEditTechnicalTestReturn f = new FormEditTechnicalTestReturn(this.Department, this.Text, this.stockCode);
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
            //TechnicalTestReturnBLL bll = new TechnicalTestReturnBLL();
            //TechnicalTestReturn t = bll.GetByReturnID((this.CurrentItem as TechnicalTestReturn).ReturnID);
            //if (t == null)
            //{
            //    MessageBox.Show(this.GetTextMessage("DELETE-1", "Phiếu đã bị xóa!"));
            //    return;
            //}
            //(this.currentItem as TechnicalTestReturn).IsReceived = t.IsReceived;
            if ((this.currentItem as TechnicalTestReturn).IsReceived == true)
            {
                this.editMode = FormEditMode.VIEW;
                MessageBox.Show(this.GetTextMessage("DeleteIsReceived", "Phiếu trả kết quả đã được QLCL nhận, không thể xóa!"));
            }
            else
            {
                base.Delete();
            }
        }
        public FormListTechnicalTestReturn()
        {
            InitializeComponent();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FormEditTechnicalTestReturn f = new FormEditTechnicalTestReturn(this.Department, this.Text, this.stockCode);
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.CurrentItem = this.CurrentItem;
            this.ShowChildForm(f);
            this.RefreshButtons();
        }
        private void RefeshListDataSource()
        {
            Period p = (lookUpPeriod.Properties.DataSource as ListBase<Period>).Search("PeriodCode", lookUpPeriod.EditValue.ToString());
            //this.DataSource = this.bll.GetForPeriod(p.StartDate, p.EndDate);
            this.stockCode = this.lookUpEditStockCode.EditValue.ToString();
            this.DataSource = this.bll.GetForPeriodAndStock(p.StartDate, p.EndDate, this.stockCode);
            this.gridControl1.RefreshDataSource();
            this.gridControl1.Refresh();
            this.gridView1.RefreshData();
        }

        private void lookUpPeriod_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpPeriod.EditValue != null && lookUpEditStockCode.EditValue != null)
            {
                this.RefeshListDataSource();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (lookUpPeriod.EditValue != null && lookUpEditStockCode.EditValue != null)
            {
                this.RefeshListDataSource();
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            lookUpEditStockCode.ItemIndex = 0;
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

        private void lookUpEditStockCode_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpPeriod.EditValue != null && lookUpEditStockCode.EditValue != null)
            {
                this.RefeshListDataSource();
            }
        }
    }
}

