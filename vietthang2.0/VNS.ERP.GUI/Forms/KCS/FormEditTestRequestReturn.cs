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
    public partial class FormEditTestRequestReturn : VNS.Windows.Forms.FormEditBase
    {
        private enumKCSDepartment department;// = enumKCSDepartment.PTN;
        private enumKCSDepartment Department
        {
            get { return department; }
            set
            {
                department = value;
                this.ucTestRequestReturn1.Department = value;
            }
        }
        TestRequestReturnBLL bll = new TestRequestReturnBLL();
        public FormEditTestRequestReturn()
        {
            InitializeComponent();
        }
        public FormEditTestRequestReturn(string textForm)
        {
            InitializeComponent();
            this.Text = textForm;
            this.Business = this.bll;
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
            //this.ucTestRequestReturn1.IsReveived = t.IsReceived;
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
        public override void EditItem()
        {
            //TestRequestReturnBLL bll = new TestRequestReturnBLL();
            //TestRequestReturn t = bll.GetByReturnID((this.CurrentItem as TestRequestReturn).ReturnID);
            //if (t == null)
            //{
            //    MessageBox.Show(this.GetTextMessage("DELETE-1", "Phiếu trả kết quả đã bị xóa!"));
            //    return;
            //}
            //(this.currentItem as TestRequestReturn).IsReceived = t.IsReceived;
            //this.ucTestRequestReturn1.IsReveived = t.IsReceived;
            if ((this.currentItem as TestRequestReturn).IsReceived == true)
            {
                this.editMode = FormEditMode.VIEW;
                MessageBox.Show(this.GetTextMessage("UpdateIsReceived", "Phiếu trả kết quả đã được QLCL nhận, không thể sửa!"));
            }
            else
            {
                base.EditItem();
            }
        }
        public FormEditTestRequestReturn(enumKCSDepartment department, string textForm)
        {
            InitializeComponent();
            this.Text = textForm;
            this.Department = department;
            this.Business = this.bll;
            this.ucTestRequestReturn1.OnUpdateIsReceved += new UCTestRequestReturn.UpdateIsReceved(ucTestRequestReturn1_OnUpdateIsReceved);
        }

        void ucTestRequestReturn1_OnUpdateIsReceved(bool IsReceived)
        {
            //TestRequestReturnBLL bll = new TestRequestReturnBLL();
            //TestRequestReturn t = bll.GetByReturnID((this.CurrentItem as TestRequestReturn).ReturnID);
            //if (t == null)
            //{
            //    MessageBox.Show(this.GetTextMessage("UPDATE-1", "Phiếu trả kết quả đã bị xóa!"));
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
            TestRequestReturn trr = this.CurrentItem as TestRequestReturn;
            trr.IsReceived = IsReceived;
            if (IsReceived)
            {
                trr.UserReceived = Contexts.CurrentUser.LoginName;
                trr.DateReceived = DateTime.Now;
            }
            int iError = bll.UpdateIsReceived(trr);
            if (iError != 0)
            {
                MessageBox.Show(this.GetTextMessage("UpdateIsReceived" + iError.ToString(), "Nhận/bỏ nhận phiếu yêu cầu không thành công!"));
                trr.IsReceived = !IsReceived;
                this.ucTestRequestReturn1.IsReveived = !IsReceived;
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

