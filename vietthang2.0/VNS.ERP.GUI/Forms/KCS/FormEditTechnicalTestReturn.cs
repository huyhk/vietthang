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

namespace VNS.ERP.GUI.KCS
{
    public partial class FormEditTechnicalTestReturn : VNS.Windows.Forms.FormEditBase
    {
        private enumKCSDepartment department = enumKCSDepartment.PTN;
        private enumKCSDepartment Department
        {
            get { return department; }
            set
            {
                department = value;
                this.ucTechnicalTestReturn1.Department = value;
            }
        }
        TechnicalTestReturnBLL bll = new TechnicalTestReturnBLL();
        private string stockCode = string.Empty;
        private string StockCode
        {
            get { return stockCode; }
            set
            {
                stockCode = value;
                this.ucTechnicalTestReturn1.StockCode = value;
            }
        }
        public FormEditTechnicalTestReturn()
        {
            InitializeComponent();
        }
        public FormEditTechnicalTestReturn(string stockCode, string textForm)
        {
            InitializeComponent();
            this.StockCode = stockCode;
            this.Text = textForm;
            this.Business = bll;
        }
        //public FormEditTechnicalTestReturn(string textForm)
        //{
        //    InitializeComponent();
        //    this.Text = textForm;
        //    this.Business = this.bll;
        //}
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
            //this.ucTechnicalTestReturn1.IsReveived = t.IsReceived;
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
            //this.ucTechnicalTestReturn1.IsReveived = t.IsReceived;
            if ((this.currentItem as TechnicalTestReturn).IsReceived == true)
            {
                this.editMode = FormEditMode.VIEW;
                MessageBox.Show(this.GetTextMessage("UpdateIsReceived", "Phiếu trả kết quả đã được QLCL nhận, không thể sửa!"));
            }
            else
            {
                base.EditItem();
            }
        }
        public FormEditTechnicalTestReturn(enumKCSDepartment department, string textForm, string stockCode)
        {
            InitializeComponent();
            this.StockCode = stockCode;
            this.Text = textForm;
            this.Department = department;
            this.Business = this.bll;
            this.ucTechnicalTestReturn1.OnUpdateIsReceved += new UCTechnicalTestReturn.UpdateIsReceved(ucTechnicalTestReturn1_OnUpdateIsReceved);
        }

        void ucTechnicalTestReturn1_OnUpdateIsReceved(bool IsReceived)
        {
            
            //TechnicalTestReturnBLL bll = new TechnicalTestReturnBLL();
            //TechnicalTestReturn t = bll.GetByReturnID((this.CurrentItem as TechnicalTestReturn).ReturnID);
            //if (t == null)
            //{
            //    MessageBox.Show(this.GetTextMessage("UPDATE-1", "Phiếu đã bị xóa!"));
            //    return;
            //}
            //if (t.IsReceived == IsReceived)
            //{
            //    if (IsReceived)
            //    {
            //        MessageBox.Show(this.GetTextMessage("IsReceived", "Phiếu đã được nhận trước đó!"));
            //    }
            //    else
            //    {
            //        MessageBox.Show(this.GetTextMessage("IsCancelReceived", "Phiếu đã được bỏ nhận trước đó!"));
            //    }
            //    return;
            //}
            TechnicalTestReturn ttr = this.CurrentItem as TechnicalTestReturn;
            ttr.IsReceived = IsReceived;
            if (IsReceived)
            {
                ttr.UserReceived = Contexts.CurrentUser.LoginName;
                ttr.DateReceived = DateTime.Now;
            }
            int iError = bll.UpdateIsReceived(ttr);
            if (iError != 0)
            {
                MessageBox.Show(this.GetTextMessage("UpdateIsReceived" + iError.ToString(), "Nhận/bỏ nhận phiếu yêu cầu không thành công!"));
                ttr.IsReceived = !IsReceived;
                this.ucTechnicalTestReturn1.IsReveived = !IsReceived;
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
    }
}

