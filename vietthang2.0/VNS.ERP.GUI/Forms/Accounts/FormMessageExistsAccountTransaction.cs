using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;

namespace VNS.ERP.GUI
{
    public partial class FormMessageExistsAccountTransaction : FormBase
    {
        private enumFormMsgExistAccTransDialogResult answerResult = enumFormMsgExistAccTransDialogResult.Cancel;
        public enumFormMsgExistAccTransDialogResult AnswerResult
        {
            get { return answerResult; }
            set { answerResult = value; }
        }
        public FormMessageExistsAccountTransaction()
        {
            InitializeComponent();
        }
        public FormMessageExistsAccountTransaction(bool allowOpenEdit)
        {
            InitializeComponent();
            this.btnOpenEdit.Enabled = allowOpenEdit;
        }
        public enumFormMsgExistAccTransDialogResult ShowDialog(string msg, string title)
        {
            this.txtMessage.Text = msg;
            this.Text = title;
            this.ShowDialog();
            return this.AnswerResult;
        }

        private void btnOpenView_Click(object sender, EventArgs e)
        {
            this.AnswerResult = enumFormMsgExistAccTransDialogResult.OpenView;
            this.DialogResult = DialogResult.OK;
        }

        private void btnOpenEdit_Click(object sender, EventArgs e)
        {
            this.AnswerResult = enumFormMsgExistAccTransDialogResult.OpenEdit;
            this.DialogResult = DialogResult.OK;
        }

        private void btnDeleteAndCreat_Click(object sender, EventArgs e)
        {
            this.AnswerResult = enumFormMsgExistAccTransDialogResult.DeleteAndCreat;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.AnswerResult = enumFormMsgExistAccTransDialogResult.Cancel;
            this.DialogResult = DialogResult.Cancel;
        }
    }
}