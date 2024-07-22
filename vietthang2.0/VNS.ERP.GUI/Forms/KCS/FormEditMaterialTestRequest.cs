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
    public partial class FormEditMaterialTestRequest : VNS.Windows.Forms.FormEditBase
    {
        private enumKCSDepartment department = enumKCSDepartment.QLCL;
        public enumKCSDepartment Department
        {
            get { return department; }
            set
            {
                department = value;
                this.ucMaterialTestRequest1.Department = value;
                
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
        public FormEditMaterialTestRequest()
        {
            InitializeComponent();
            this.ucMaterialTestRequest1.OnUpdateIsReceved += new UCMaterialTestRequest.UpdateIsReceved(ucMaterialTestRequest1_OnUpdateIsReceved);
        }

        void ucMaterialTestRequest1_OnUpdateIsReceved(bool IsReceived)
        {
            MaterialTestRequestBLL bll = new MaterialTestRequestBLL();
            MaterialTestRequest t = bll.GetByRequestID((this.CurrentItem as MaterialTestRequest).RequestID);
            if (t == null)
            {
                MessageBox.Show(this.GetTextMessage("DELETE-1", "Phiếu yêu cầu đã bị xóa trước đó!"));
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
            MaterialTestRequest mtr = this.CurrentItem as MaterialTestRequest;
            
            mtr.IsReceived = IsReceived;
            if (IsReceived)
            {
                mtr.UserReceived = Contexts.CurrentUser.LoginName;
                mtr.DateReceived = DateTime.Now;
            }
            int iError = bll.UpdateIsReceived(mtr);
            if (iError != 0)
            {
                MessageBox.Show(this.GetTextMessage("UpdateIsReceved" + iError.ToString(), "Nhận/bỏ nhận phiếu yêu cầu không thành công!"));
                mtr.IsReceived = !IsReceived;
                this.ucMaterialTestRequest1.IsReveived = !IsReceived;
            }
        }

        public override void RefreshButtons()
        {
            base.RefreshButtons();
            if (this.Department == enumKCSDepartment.PTN)
            {
                this.btnAdd.Visible = false;
                this.btnEdit.Visible = false;
                this.btnRemove.Visible = false;
                this.btnSave.Visible = false;
                this.btnSaveClose.Visible = false;
                this.btnSaveNew.Visible = false;
            }
            this.btnViewResult.Enabled = (this.EditMode == FormEditMode.VIEW);
        }
        /// <summary>
        /// Use to call from FormList
        /// </summary>
        /// <param name="department"></param>
        public FormEditMaterialTestRequest(enumKCSDepartment department, string textForm)
        {
            InitializeComponent();
            this.Department = department;
            this.Text = textForm;
            MaterialTestRequestBLL bll = new MaterialTestRequestBLL();
            this.Business = bll;
            this.ucMaterialTestRequest1.OnUpdateIsReceved += new UCMaterialTestRequest.UpdateIsReceved(ucMaterialTestRequest1_OnUpdateIsReceved);
        }
        public override void Delete()
        {
            MaterialTestRequestBLL bll = new MaterialTestRequestBLL();
            MaterialTestRequest t = bll.GetByRequestID((this.CurrentItem as MaterialTestRequest).RequestID);
            if (t == null)
            {
                MessageBox.Show(this.GetTextMessage("UpdateIsReceved-1", "Phiếu đã bị xóa trước đó!"));
                return;
            }
            (this.currentItem as MaterialTestRequest).IsReceived = t.IsReceived;
            this.ucMaterialTestRequest1.IsReveived = t.IsReceived;
            if ((this.currentItem as MaterialTestRequest).IsReceived == true)
            {
                this.editMode = FormEditMode.VIEW;
                MessageBox.Show(this.GetTextMessage("DeleteIsReceived","Phiếu yêu cầu kiểm tra đã được nhận, không thể xóa!"));
            }
            else
            {
                base.Delete();
            }
        }
        public override void EditItem()
        {
            MaterialTestRequestBLL bll = new MaterialTestRequestBLL();
            MaterialTestRequest t = bll.GetByRequestID((this.CurrentItem as MaterialTestRequest).RequestID);
            if (t == null)
            {
                MessageBox.Show(this.GetTextMessage("UpdateIsReceved-1", "Phiếu đã bị xóa!"));
                return;
            }
            (this.currentItem as MaterialTestRequest).IsReceived = t.IsReceived;
            this.ucMaterialTestRequest1.IsReveived = t.IsReceived;
            if ((this.currentItem as MaterialTestRequest).IsReceived == true)
            {
                this.editMode = FormEditMode.VIEW;
                MessageBox.Show(this.GetTextMessage("EditIsReceived", "Phiếu yêu cầu kiểm tra đã được nhận, không thể sửa!"));
            }
            else
            {
                base.EditItem();
            }

        }

        private void btnViewResult_Click(object sender, EventArgs e)
        {
            FormMaterialTestRequestResult f = new FormMaterialTestRequestResult((this.currentItem as MaterialTestRequest).RequestID,FormMaterialTestRequestResult.RequestType.Material);
            f.ShowDialog();
        }


    }
}

