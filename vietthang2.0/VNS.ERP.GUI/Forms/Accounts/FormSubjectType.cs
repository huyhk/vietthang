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
    public partial class FormSubjectType : FormEditBase
    {
        private SubjectTypeBLL subjectTypeBLL = new SubjectTypeBLL();
        public FormSubjectType()
        {
            InitializeComponent();
            this.Business = subjectTypeBLL;
        }

        private void FormSubjectType_Load(object sender, EventArgs e)
        {
            this.DataSource = subjectTypeBLL.GetAll();
        }
        public override void Delete()

        {
            if(SystemType.CheckSystemType((this.CurrentItem as SubjectType).SubjectTypeCode)==false)
                base.Delete();
            else
                MessageBox.Show("Không cho phép xóa!!!", "Thông báo", MessageBoxButtons.OK);
        }
    }
}