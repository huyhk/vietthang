using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Manufactures;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class FormProductFormula2 : FormEditBase
    {
        ProductFormulaBLL2 bll = new ProductFormulaBLL2();
        public FormProductFormula2()
        {
            InitializeComponent();
            //this.AllowAddNew = true;
            this.Business = bll;
            gridControl1.DataSource = new ProductBLL().GetAll();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.RefeshDataSource();
        }

        private void gridView1_ColumnFilterChanged(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                this.RefeshDataSource();
            }
            else
            {
                this.ucProductFormula21.ProductCode = string.Empty;
                this.DataSource = null;
                gridControl2.DataSource = null;
                this.btnAdd.Enabled = false;
                //this.AllowAddNew = false;
            }
        }
        private void RefeshDataSource()
        {
            CurrencyManager cr = this.BindingContext[gridControl1.DataSource] as CurrencyManager;
            if (cr != null)
            {
                Product p = cr.Current as Product;
                if (p != null)
                {
                    this.DataSource = bll.GetByProductCode(p.ProductCode);
                    //this.AllowAddNew = true;
                    this.btnAdd.Enabled = true;
                    this.ucProductFormula21.ProductCode = p.ProductCode;
                }
            }
            
        }
        public override void RefreshButtons()
        {
            base.RefreshButtons();
            gridControl1.Enabled = this.EditMode == VNS.Windows.FormEditMode.VIEW;
        }

        private void FormProductFormula2_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.AllowEditOther = true;
            this.AllowDeleteOther = true;
        }
    }
}