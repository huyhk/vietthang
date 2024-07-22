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
    public partial class FormListTransportCompensationPrice : FormEditBase
    {
        TransportCompensationPriceBLL bll = new TransportCompensationPriceBLL();
        public FormListTransportCompensationPrice()
        {
            InitializeComponent();
            this.Business = bll;
            this.DataSource = bll.GetAll();
        }
        public override void AddNewItem()
        {
            FormEditTransportCompensationPrice f = new FormEditTransportCompensationPrice();
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.AddNewItem();
            this.ShowChildForm(f);
            gridControl1.RefreshDataSource();
            this.RefreshButtons();
        }
        public override void EditItem()
        {
            FormEditTransportCompensationPrice f = new FormEditTransportCompensationPrice();
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.CurrentItem = this.CurrentItem;
            f.EditItem();
            this.ShowChildForm(f);
            gridControl1.RefreshDataSource();
            this.RefreshButtons();

        }


        private void FormListTransportCompensationPrice_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
                repLookUpItemCode.DataSource = new ItemBLL().GetAll();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FormEditTransportCompensationPrice f = new FormEditTransportCompensationPrice();
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.CurrentItem = this.CurrentItem;
            this.ShowChildForm(f);
            gridControl1.RefreshDataSource();
            this.RefreshButtons();
        }

    }
}

