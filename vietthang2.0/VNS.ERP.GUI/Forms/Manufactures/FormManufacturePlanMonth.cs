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

namespace VNS.ERP.GUI.Manufactures
{
    public partial class FormManufacturePlanMonth : FormEditBase
    {
        ManufacturePlanMonthBLL obj = new ManufacturePlanMonthBLL();
        public FormManufacturePlanMonth()
        {
            InitializeComponent();
            lookUpStock.Properties.DataSource = new StockBLL().GetAllForMember(Contexts.CurrentUser.MemberID);
           
            this.Business = obj;
        }

        private void lookUpStock_EditValueChanged(object sender, EventArgs e)
        {
            this.DataSource = obj.GetByStockCode(lookUpStock.EditValue.ToString());
        }

        private void FormManufacturePlanMonth_Load(object sender, EventArgs e)
        {
            try
            {
                lookUpStock.ItemIndex = 0;
            }
            catch
            {
            }
        }
        public override void AddNewItem()
        {
            string sCode="";
            if (lookUpStock.EditValue != null)
            {
                sCode = lookUpStock.EditValue.ToString();
            }

            FormEditManufacturePlanMonth f = new FormEditManufacturePlanMonth(sCode);
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.AddNewItem();
            f.Text = this.Text;
            this.ShowChildForm(f);
            if ((this.DataSource as ListBase<ManufacturePlanMonth>).Count > 0)
            {
                this.CurrentItem = f.CurrentItem;
            }
            else
            {
                this.CurrentItem = null;
            }
            gridControl1.RefreshDataSource();
            this.RefreshButtons();

            //base.AddNewItem();
        }
        public override void EditItem()
        {
            string sCode = "";
            if (lookUpStock.EditValue != null)
            {
                sCode = lookUpStock.EditValue.ToString();
            }
            FormEditManufacturePlanMonth f = new FormEditManufacturePlanMonth(sCode);
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.CurrentItem=this.CurrentItem;
            f.EditItem();
            f.Text = this.Text;
            this.ShowChildForm(f);
            if ((this.DataSource as ListBase<ManufacturePlanMonth>).Count > 0)
            {
                this.CurrentItem = f.CurrentItem;
            }
            else
            {
                this.CurrentItem = null;
            }
            gridControl1.RefreshDataSource();
            this.RefreshButtons();
            //base.EditItem();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            string sCode = "";
            if (lookUpStock.EditValue != null)
            {
                sCode = lookUpStock.EditValue.ToString();
            }
            FormEditManufacturePlanMonth f = new FormEditManufacturePlanMonth(sCode);
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.CurrentItem = this.CurrentItem;
            f.Text = this.Text;
            this.ShowChildForm(f);
            if ((this.DataSource as ListBase<ManufacturePlanMonth>).Count > 0)
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
    }
}