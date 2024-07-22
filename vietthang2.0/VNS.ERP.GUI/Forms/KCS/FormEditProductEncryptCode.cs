using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows;
using VNS.ERP.Data;
using VNS.ERP.Data.KCS;

namespace VNS.ERP.GUI.KCS
{
    public partial class FormEditProductEncryptCode : VNS.Windows.Forms.FormBase
    {
        private ProductTestEncryptCodeBLL bll = new ProductTestEncryptCodeBLL();
        ProductTestEncryptCode encryptCodeEdit = null;
        FormEditMode mode = FormEditMode.ADD;
        public FormEditProductEncryptCode()
        {
            InitializeComponent();
        }
        public FormEditProductEncryptCode(FormEditMode mode, ref ProductTestEncryptCode encryptCodeEdit)
        {
            InitializeComponent();
            this.mode = mode;
            this.encryptCodeEdit = encryptCodeEdit;
            if (mode == FormEditMode.EDIT)
            {

                txtEncryptCode.Text = this.encryptCodeEdit.ItemEncryptCode;
                txtDescription.Text = this.encryptCodeEdit.Description;
                txtEncryptCode.Properties.ReadOnly = true;
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
                txtEncryptCode.Focus();
                return;
            }
            txtDescription.Text = txtDescription.Text.Trim();
            if (this.mode == FormEditMode.ADD)
            {
                ProductTestEncryptCode ptec = new ProductTestEncryptCode();
                ptec.StockCode = this.encryptCodeEdit.StockCode;
                ptec.ManuDate = this.encryptCodeEdit.ManuDate;
                ptec.Shift = this.encryptCodeEdit.Shift;
                ptec.ProductCode = this.encryptCodeEdit.ProductCode;
                ptec.SizeCode = this.encryptCodeEdit.SizeCode;
                ptec.FormulaCode = this.encryptCodeEdit.FormulaCode;
                ptec.Lot = this.encryptCodeEdit.Lot;
                ptec.ItemEncryptCode = txtEncryptCode.Text;
                ptec.Description = txtDescription.Text;
                ptec.UserCreated = Contexts.CurrentUser.LoginName;
                iError = this.bll.Insert(ptec);
                if (iError != 0)
                {
                    string idMsg = "INSERT" + iError.ToString();
                    MessageBox.Show(this.GetTextMessage(idMsg, "Lưu không thành công!"));
                }
            }
            if (this.mode == FormEditMode.EDIT)
            {
                ProductTestEncryptCode ptec = new ProductTestEncryptCode();
                ptec.StockCode = this.encryptCodeEdit.StockCode;
                ptec.ManuDate = this.encryptCodeEdit.ManuDate;
                ptec.Shift = this.encryptCodeEdit.Shift;
                ptec.ProductCode = this.encryptCodeEdit.ProductCode;
                ptec.SizeCode = this.encryptCodeEdit.SizeCode;
                ptec.FormulaCode = this.encryptCodeEdit.FormulaCode;
                ptec.Lot = this.encryptCodeEdit.Lot;
                ptec.ItemEncryptCode = txtEncryptCode.Text;
                ptec.Description = txtDescription.Text;
                ptec.UserUpdated = Contexts.CurrentUser.LoginName;
                iError = this.bll.Update(ptec, this.encryptCodeEdit.ItemEncryptCode);
                if (iError != 0)
                {
                    string idMsg = "UPDATE" + iError.ToString();
                    MessageBox.Show(this.GetTextMessage(idMsg, "Lưu không thành công!"));
                }
            }
            if (iError == 0)
            {
                this.encryptCodeEdit.ItemEncryptCode = txtEncryptCode.Text;
                this.encryptCodeEdit.Description = txtDescription.Text;

                this.DialogResult = DialogResult.Yes;
            }
        }
    }
}

