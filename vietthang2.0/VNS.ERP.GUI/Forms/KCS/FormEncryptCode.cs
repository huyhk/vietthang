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
    public partial class FormEncryptCode : VNS.Windows.Forms.FormBase
    {
        private string testTransactionNo = string.Empty;
        private MaterialTestEncryptCodeBLL bll = new MaterialTestEncryptCodeBLL();
        MaterialTestEncryptCode encryptCodeEdit = null;
        FormEditMode mode = FormEditMode.ADD;
        public FormEncryptCode()
        {
            InitializeComponent();
        }
        public FormEncryptCode(string testTransactionNo, FormEditMode mode, ref MaterialTestEncryptCode encryptCodeEdit)
        {
            InitializeComponent();
            this.testTransactionNo = testTransactionNo;
            this.mode = mode;
            this.encryptCodeEdit = encryptCodeEdit;
            if (mode == FormEditMode.EDIT)
            {
                txtEncryptCode.Text = this.encryptCodeEdit.ItemEncryptCode;
                txtEncryptCode.Properties.ReadOnly = true;
                txtDescription.Text = this.encryptCodeEdit.Description;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtEncryptCode.Text = txtEncryptCode.Text.Trim();
            int iError = 0;
            if (txtEncryptCode.Text == string.Empty)
            {
                MessageBox.Show(this.GetTextMessage("VALIDATE-1", "Bạn chưa nhập mã mẫu!"));
                return;
            }
            txtDescription.Text = txtDescription.Text.Trim();
            if (this.mode == FormEditMode.ADD)
            {
                MaterialTestEncryptCode mtec = new MaterialTestEncryptCode();
                mtec.TestTransactionNo = this.testTransactionNo;
                mtec.ItemEncryptCode = txtEncryptCode.Text;
                mtec.Description = txtDescription.Text;
                mtec.UserCreated = Contexts.CurrentUser.LoginName;
                iError = this.bll.Insert(mtec);
                if (iError != 0)
                {
                    string idMsg = "INSERT" + iError.ToString();
                    MessageBox.Show(this.GetTextMessage(idMsg, "Lưu không thành công!"));
                }
            }
            if (this.mode == FormEditMode.EDIT)
            {
                MaterialTestEncryptCode mtec = new MaterialTestEncryptCode();
                mtec.TestTransactionNo = this.testTransactionNo;
                mtec.ItemEncryptCode = txtEncryptCode.Text;
                mtec.Description = txtDescription.Text;
                mtec.UserUpdated = Contexts.CurrentUser.LoginName;
                iError = this.bll.Update(mtec,this.encryptCodeEdit.ItemEncryptCode);
                if (iError != 0)
                {
                    string idMsg = "UPDATE" + iError.ToString();
                    MessageBox.Show(this.GetTextMessage(idMsg, "Lưu không thành công!"));
                }
            }
            if (iError == 0)
            {
                this.encryptCodeEdit.ItemEncryptCode = txtEncryptCode.Text;
                this.DialogResult = DialogResult.Yes;
            }
        }
    }
}

