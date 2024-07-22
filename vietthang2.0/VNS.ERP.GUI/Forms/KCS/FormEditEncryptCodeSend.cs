using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.KCS;

namespace VNS.ERP.GUI.KCS
{
    public partial class FormEditEncryptCodeSend : VNS.Windows.Forms.FormEditBase
    {
        private string subjectCode = string.Empty;
        public string SubjectCode
        {
            get { return subjectCode; }
            set 
            { 
                subjectCode = value;
                this.ucEncryptCodeSend1.SubjectCode = value;
            }
        }
        public FormEditEncryptCodeSend()
        {
            InitializeComponent();
        }
        public FormEditEncryptCodeSend(string textForm)
        {
            InitializeComponent();
            this.Text = textForm;
            EncryptCodeSendBLL bll = new EncryptCodeSendBLL();
            this.Business = bll;
        }
        public FormEditEncryptCodeSend(string textForm, string subjectCode)
        {
            InitializeComponent();
            this.SubjectCode = subjectCode;
            this.Text = textForm;
            EncryptCodeSendBLL bll = new EncryptCodeSendBLL();
            this.Business = bll;
        }
    }
}

