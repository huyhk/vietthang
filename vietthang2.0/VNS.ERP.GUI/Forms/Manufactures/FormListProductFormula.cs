using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data.Manufactures;
using VNS.ERP.Data;

namespace VNS.ERP.GUI.Forms.Manufactures
{
    public partial class FormListProductFormula : VNS.Windows.Forms.FormEditBase
    {
        ProductFormulaBLL2 bll = new ProductFormulaBLL2();
        public FormListProductFormula()
        {
            InitializeComponent();

            this.Business = bll;
        }

        private void FormListProductFormula_Load(object sender, EventArgs e)
        {
            this.DataSource = bll.GetAll4();

            this.repItemName.DataSource = new ProductBLL().GetAll();

            //this.gridView1.ActiveFilter.Add(colIsActive,new DevExpress.XtraGrid.Columns.ColumnFilterInfo(
        }
    }
}

