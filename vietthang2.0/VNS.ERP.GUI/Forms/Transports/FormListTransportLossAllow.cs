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
    public partial class FormListTransportLossAllow : FormEditBase
    {
        TransportLossAllowBLL bll = new TransportLossAllowBLL();
        public FormListTransportLossAllow()
        {
            InitializeComponent();

            this.Business = bll;
            this.DataSource = bll.GetAll();
            this.repLKTransportType.DataSource = new TransportTypeBLL().GetAll();
            this.repLKTransportItemType.DataSource = new TransportItemTypeBLL().GetAll();
            this.repLKItemCode.DataSource = new ItemBLL().GetAll();
        }

        public override void AddNewItem()
        {
            FormEditTransportLossAllow f = new FormEditTransportLossAllow();
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.AddNewItem();
            this.ShowChildForm(f);
            gridControl1.RefreshDataSource();
            this.RefreshButtons();
        }

        public override void EditItem()
        {

            FormEditTransportLossAllow f = new FormEditTransportLossAllow();
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
            FormEditTransportLossAllow f = new FormEditTransportLossAllow();
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.CurrentItem = this.CurrentItem;
            this.ShowChildForm(f);
            gridControl1.RefreshDataSource();
            this.RefreshButtons();
        }
    }
}

