using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Accounting;
using VNS.Common;

namespace VNS.ERP.GUI.Accounting
{
    public partial class FormListAccountSample : VNS.Windows.Forms.FormEditBase
    {
        AccountSampleBLL obj = new AccountSampleBLL();
        public FormListAccountSample()
        {
            InitializeComponent();
            this.Business = obj;
          
        }
        public override void AddNewItem()
        {
            FormAccountSample f = new FormAccountSample();
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.AddNewItem();
            f.Text = this.Text;
            //this.shoe
            this.ShowChildForm(f);
            //f.ShowDialog();
            if ((this.DataSource as ListBase<AccountSample>).Count > 0)
            {
                this.CurrentItem = f.CurrentItem;
            }
            else
            {
                this.CurrentItem = null;
            }
            gridControl1.RefreshDataSource();
            this.RefreshButtons();

        }
        public override void EditItem()
        {
            FormAccountSample f = new FormAccountSample();
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.CurrentItem = this.CurrentItem;
            f.EditItem();
            f.Text = this.Text;
            this.ShowChildForm(f);
            //f.ShowDialog();
            if ((this.DataSource as ListBase<AccountSample>).Count > 0)
            {
                this.CurrentItem = f.CurrentItem;
            }
            else
            {
                this.CurrentItem = null;
            }
            gridControl1.RefreshDataSource();
            this.RefreshButtons();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {

            FormAccountSample f = new FormAccountSample();
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.CurrentItem = this.CurrentItem;
            f.Text = this.Text;
            this.ShowChildForm(f);
            if ((this.DataSource as ListBase<AccountSample>).Count > 0)
            {
                this.CurrentItem = f.CurrentItem;
            }
            else
            {
                this.CurrentItem = null;
            }
            gridControl1.RefreshDataSource();
            this.RefreshButtons();
        }

        private void FormListAccountSample_Load(object sender, EventArgs e)
        {
            repItemLookUpAccTransTypeCode.DataSource = new AccountTransactionTypesBLL().GetAll();
            this.DataSource = obj.GetAll();
        }
    }
}