using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Transports;
using VNS.Common;
using VNS.Windows;

namespace VNS.ERP.GUI.Transports
{
    public partial class FormListTransportContract : FormEditBase
    {
        TransportContractBLL bll = new TransportContractBLL();
        public FormListTransportContract()
        {
            InitializeComponent();
            this.Business = bll;
            //this.DataSource = bll.GetAll();
        }
        public override void AddNewItem()
        {
            FormEditTransportContract f = new FormEditTransportContract();
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.AddNewItem();
            this.ShowChildForm(f);
            gridControl1.RefreshDataSource();
            this.RefreshButtons();
        }
        public override void EditItem()
        {
            FormEditTransportContract f = new FormEditTransportContract();
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
            FormEditTransportContract f = new FormEditTransportContract();
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.CurrentItem = this.CurrentItem;
            this.ShowChildForm(f);
            gridControl1.RefreshDataSource();
            this.RefreshButtons();
        }
        private void FormListTransportContract_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                this.txtYear.EditValue = DateTime.Today.Year;
                repLookUpSubject.DataSource = new VendorBLL().GetForVanchuyen();
                GetData();
            }
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            GetData();
        }
        void GetData()
        {
            this.DataSource = bll.GetYear(Convert.ToInt32(this.txtYear.EditValue));
        }
    }
}

