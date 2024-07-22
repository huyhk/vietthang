using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data.Transports;
using VNS.ERP.Data;

namespace VNS.ERP.GUI.Transports
{
    public partial class FormListTCContract : VNS.Windows.Forms.FormEditBase
    {
        TCContractBLL bll = new TCContractBLL();
        public FormListTCContract()
        {
            InitializeComponent();
            this.Business = bll;
            this.DataSource = bll.GetAll();
        }
        public override void AddNewItem()
        {
            FormEditTCContract f = new FormEditTCContract();
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.AddNewItem();
            this.ShowChildForm(f);
            gridControl1.RefreshDataSource();
            this.RefreshButtons();
        }
        public override void EditItem()
        {
            FormEditTCContract f = new FormEditTCContract();
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.CurrentItem = this.CurrentItem;
            f.EditItem();
            this.ShowChildForm(f);
            gridControl1.RefreshDataSource();
            this.RefreshButtons();

        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FormEditTCContract f = new FormEditTCContract();
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.CurrentItem = this.CurrentItem;
            this.ShowChildForm(f);
            gridControl1.RefreshDataSource();
            this.RefreshButtons();
        }

        private void FormListTCContract_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
                repLookUpSubject.DataSource = new VendorBLL().GetForVanchuyen();
        }
    }
}

