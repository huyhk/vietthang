using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;
using VNS.Windows.Forms;
using VNS.Windows;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class FormObjectInserts : FormEditBase
    {
        private ListBase<SubjectType> lstSubjectType = null;
        private SubjectBLL objBLL = new SubjectBLL();
        public FormObjectInserts()
        {
            InitializeComponent();
            this.Business = objBLL;
        }

        private void cboSubject_EditValueChanged(object sender, EventArgs e)
        {
            if (cboSubject.ItemIndex != -1)
            {
                this.DataSource = objBLL.GetObjectByType(this.cboSubject.EditValue.ToString());
                this.ucObjectInserts1.SubjectType = this.cboSubject.EditValue.ToString();
            }

        }
        public override void RefreshButtons()
        {
            this.cboSubject.Properties.ReadOnly = this.EditMode != FormEditMode.VIEW;
            base.RefreshButtons();
        }

        private void FormObjectInserts_Load(object sender, EventArgs e)
        {
            int count = 0;
            if (!this.DesignMode)
            {
                lstSubjectType = (new SubjectTypeBLL()).GetAll();
                count = lstSubjectType.Count;
                for (int i = 0; i < count; i++)
                {
                    if (SystemType.CheckSystemType(lstSubjectType[i].SubjectTypeCode) == true)
                    {
                        lstSubjectType.RemoveAt(i);
                        i -= 1;
                        count -= 1;
                    }
                }
                this.cboSubject.Properties.DataSource = lstSubjectType;
                this.cboSubject.ItemIndex = 0;
            }
        }
    }
}