using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.KCS;
using VNS.Common;

namespace VNS.ERP.GUI.KCS
{
    public partial class FormListEncryptCodeReturn : VNS.Windows.Forms.FormEditBase
    {
        private string subjectCode = string.Empty;
        ListBase<Subject> lstSubject = null;
        public FormListEncryptCodeReturn()
        {
            InitializeComponent();
        }
        public FormListEncryptCodeReturn(string textForm)
        {
            InitializeComponent();
            EncryptCodeReturnBLL bll = new EncryptCodeReturnBLL();
            this.Business = bll;
            this.Text = textForm;
            lookUpPeriod.Properties.DataSource = new PeriodBLL().GetAll();
            lookUpPeriod.EditValue = Contexts.WorkingPeriod.PeriodCode;
            lstSubject = new SubjectBLL().GetTTPT();
            lookUpSubjectCode.Properties.DataSource = lstSubject;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (this.lstSubject.Count > 0)
            {
                lookUpSubjectCode.EditValue = this.lstSubject[0].SubjectCode;
            }
        }
        public override void AddNewItem()
        {
            FormEditEncryptCodeReturn f = new FormEditEncryptCodeReturn(this.Text, this.subjectCode);
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.AddNewItem();
            this.ShowChildForm(f);
            this.RefreshButtons();
        }
        public override void EditItem()
        {
            FormEditEncryptCodeReturn f = new FormEditEncryptCodeReturn(this.Text, this.subjectCode);
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.CurrentItem = this.CurrentItem;
            f.EditItem();
            this.ShowChildForm(f);
            this.RefreshButtons();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FormEditEncryptCodeReturn f = new FormEditEncryptCodeReturn(this.Text, this.subjectCode);
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.CurrentItem = this.CurrentItem;
            this.ShowChildForm(f);
            this.RefreshButtons();
        }
        private void RefeshListDataSource()
        {
            Period p = (lookUpPeriod.Properties.DataSource as ListBase<Period>).Search("PeriodCode", lookUpPeriod.EditValue.ToString());
            this.subjectCode = lookUpSubjectCode.EditValue.ToString();
            EncryptCodeReturnBLL bll = new EncryptCodeReturnBLL();
            this.DataSource = bll.GetForPeriodAndSubjectCode(p.StartDate, p.EndDate, subjectCode);
            this.gridControl1.RefreshDataSource();
            this.gridControl1.Refresh();
            this.gridView1.RefreshData();
        }

        private void lookUpSubjectCode_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpPeriod.EditValue != null && lookUpSubjectCode.EditValue != null)
            {
                this.RefeshListDataSource();
            }
        }

        private void lookUpPeriod_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpPeriod.EditValue != null && lookUpSubjectCode.EditValue != null)
            {
                this.RefeshListDataSource();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (lookUpPeriod.EditValue != null && lookUpSubjectCode.EditValue != null)
            {
                this.RefeshListDataSource();
            }
        }
    }
}

