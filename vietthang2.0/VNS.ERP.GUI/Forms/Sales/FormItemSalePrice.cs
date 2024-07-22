using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Sales;

namespace VNS.ERP.GUI.Sales
{
    public partial class FormItemSalePrice : FormEditBase
    {
        ItemSalePriceBLL obj = new ItemSalePriceBLL();
        public FormItemSalePrice()
        {
            InitializeComponent();
            this.Business = obj;
        }
        string sProductType = string.Empty;
        public FormItemSalePrice(string productType)
        {
            InitializeComponent();
            this.Business = obj;
            sProductType = productType;
            
        }
        private void FormItemSalePrice_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = new ItemBLL().GetProduct(sProductType);    //.GetbyItemtype((int)enumItemType.Product);
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CurrencyManager cr = this.BindingContext[this.gridControl1.DataSource] as CurrencyManager;
            this.ucItemSalePrice1.ItemCode = (cr.Current as Item).ItemCode;
            this.DataSource = obj.GetByItemCode((cr.Current as Item).ItemCode);
        }

        private void gridView1_ColumnFilterChanged(object sender, EventArgs e)
        {
            CurrencyManager cr = this.BindingContext[this.gridControl1.DataSource] as CurrencyManager;
            this.ucItemSalePrice1.ItemCode = (cr.Current as Item).ItemCode;
            this.DataSource = obj.GetByItemCode((cr.Current as Item).ItemCode);
        }
        public override void RefreshButtons()
        {
            gridControl1.Enabled = this.EditMode == VNS.Windows.FormEditMode.VIEW;
            base.RefreshButtons();
        }
    }
}