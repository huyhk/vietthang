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
    public partial class FormEditEncryptCodeReturn : VNS.Windows.Forms.FormEditBase
    {
        private string subjectCode = string.Empty;
        public string SubjectCode
        {
            get { return subjectCode; }
            set
            {
                subjectCode = value;
                this.ucEncryptCodeReturn1.SubjectCode = value;
            }
        }
        public FormEditEncryptCodeReturn()
        {
            InitializeComponent();
        }
        public FormEditEncryptCodeReturn(string textForm, string subjectCode)
        {
            InitializeComponent();
            this.SubjectCode = subjectCode;
            this.Text = textForm;
            EncryptCodeReturnBLL bll = new EncryptCodeReturnBLL();
            this.Business = bll;
        }
    }
}

