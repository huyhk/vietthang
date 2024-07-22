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
using VNS.ERP.GUI;

namespace VNS.ERP.GUI.KCS
{
    public partial class FormEditProductTestRequest : VNS.Windows.Forms.FormEditBase
    {
        private enumKCSDepartment department = enumKCSDepartment.QLCL;
        public enumKCSDepartment Department
        {
            get { return department; }
            set
            {
                department = value;
                this.ucProductTestRequest1.Department = value;

            }
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
        public FormEditProductTestRequest()
        {
            InitializeComponent();
            this.ucProductTestRequest1.OnUpdateIsReceved += new UCProductTestRequest.UpdateIsReceved(ucProductTestRequest1_OnUpdateIsReceved);
        }

        void ucProductTestRequest1_OnUpdateIsReceved(bool IsReceived)
        {
            ProductTestRequestBLL bll = new ProductTestRequestBLL();
            ProductTestRequest t = bll.GetByRequestID((this.CurrentItem as ProductTestRequest).RequestID);
            if (t == null)
            {
                MessageBox.Show(this.GetTextMessage("UpdateIsReceved-1", "Phiếu đã bị xóa trước đó!"));
                return;
            }
            if (t.IsReceived == IsReceived)
            {
                if (IsReceived)
                {
                    MessageBox.Show(this.GetTextMessage("IsReceived", "Phiếu đã được nhận trước đó!"));
                }
                else
                {
                    MessageBox.Show(this.GetTextMessage("IsCancelReceived", "Phiếu đã được bỏ nhận trước đó!"));
                }
                return;
            }

            ProductTestRequest ptr = this.CurrentItem as ProductTestRequest;
            ptr.IsReceived = IsReceived;
            if (IsReceived)
            {
                ptr.UserReceived = Contexts.CurrentUser.LoginName;
                ptr.DateReceived = DateTime.Now;
            }
            int iError = bll.UpdateIsReceived(ptr);
            if (iError != 0)
            {
                MessageBox.Show(this.GetTextMessage("UpdateIsReceved" + iError.ToString(), "Nhận/bỏ nhận phiếu yêu cầu không thành công!"));
                ptr.IsReceived = !IsReceived;
                this.ucProductTestRequest1.IsReveived = !IsReceived;
            }
        }
        /// <summary>
        /// Use to call from FormList
        /// </summary>
        /// <param name="department"></param>
        public FormEditProductTestRequest(enumKCSDepartment department, string textForm)
        {
            InitializeComponent();
            this.Department = department;
            this.Text = textForm;
            ProductTestRequestBLL bll = new ProductTestRequestBLL();
            this.Business = bll;
            this.ucProductTestRequest1.OnUpdateIsReceved += new UCProductTestRequest.UpdateIsReceved(ucProductTestRequest1_OnUpdateIsReceved);
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
            this.ucProductTestRequest1.IsReveived = t.IsReceived;
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
        public override void EditItem()
        {
            ProductTestRequestBLL bll = new ProductTestRequestBLL();
            ProductTestRequest t = bll.GetByRequestID((this.CurrentItem as ProductTestRequest).RequestID);
            if (t == null)
            {
                MessageBox.Show(this.GetTextMessage("UPDATE-1", "Phiếu đã bị xóa!"));
                return;
            }
            (this.currentItem as ProductTestRequest).IsReceived = t.IsReceived;
            this.ucProductTestRequest1.IsReveived = t.IsReceived;
            if ((this.currentItem as ProductTestRequest).IsReceived == true)
            {
                this.editMode = FormEditMode.VIEW;
                MessageBox.Show(this.GetTextMessage("UpdateIsReceived", "Phiếu yêu cầu kiểm tra đã được nhận, không thể sửa!"));
            }
            else
            {
                base.EditItem();
            }

        }

        private void btnViewResult_Click(object sender, EventArgs e)
        {
            FormMaterialTestRequestResult f = new FormMaterialTestRequestResult((this.currentItem as ProductTestRequest).RequestID, FormMaterialTestRequestResult.RequestType.ProductOutside);
            f.ShowDialog();
        }
        public override void RefreshButtons()
        {
            base.RefreshButtons();
            this.btnViewResult.Enabled = (this.EditMode == FormEditMode.VIEW);
        }

        
    }
}

