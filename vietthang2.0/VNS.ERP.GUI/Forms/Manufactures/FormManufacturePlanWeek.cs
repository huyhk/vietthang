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
    public partial class FormManufacturePlanWeek : FormEditBase
    {
        ManufacturePlanWeekBLL obj = new ManufacturePlanWeekBLL();
        public FormManufacturePlanWeek()
        {
            InitializeComponent();
        }


        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            string sCode = "";
            if (lookUpStock.EditValue != null)
            {
                sCode = lookUpStock.EditValue.ToString();
            }
            FormEditManufacturePlanWeek f = new FormEditManufacturePlanWeek(sCode);
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.CurrentItem = this.CurrentItem;
            f.Text = this.Text;
            f.ShowDialog();
            //this.ShowChildForm(f);
            if ((this.DataSource as ListBase<ManufacturePlanWeek>).Count > 0)
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


        private void RefreshGridControl()
        {
            this.DataSource = obj.GetByStockCode(lookUpStock.EditValue.ToString(), Convert.ToInt32(spinYear.Value));
        }


        private void FormManufacturePlanWeek_Load(object sender, EventArgs e)
        {
            lookUpStock.Properties.DataSource = new StockBLL().GetAllForMember(Contexts.CurrentUser.MemberID);
            lookUpStock.ItemIndex = 0;
            spinYear.Value = DateTime.Today.Year;
            RefreshGridControl();
            spinYear.EditValueChanged += new EventHandler(spinYear_EditValueChanged);
            lookUpStock.EditValueChanged += new EventHandler(lookUpStock_EditValueChanged);
            this.Business = obj;
        }

        void lookUpStock_EditValueChanged(object sender, EventArgs e)
        {
            RefreshGridControl();
        }

        void spinYear_EditValueChanged(object sender, EventArgs e)
        {
            RefreshGridControl();
        }

        public override void AddNewItem()
        {

            string sCode = "";
            if (lookUpStock.EditValue != null)
            {
                sCode = lookUpStock.EditValue.ToString();
            }

            FormEditManufacturePlanWeek frm = new FormEditManufacturePlanWeek(sCode);
            SetFormPrivilege(frm);
            frm.DataSource = this.DataSource;
            frm.AddNewItem();
            frm.Text = this.Text;
            frm.ShowDialog();
            if ((this.DataSource as ListBase<ManufacturePlanWeek>).Count > 0)
            {
                this.CurrentItem = frm.CurrentItem;
                //this.gridView1.FocusedRowHandle =  lstPurchasePlanWeek.IndexOf(this.CurrentItem as PurchasePlanWeek);
            }
            else
            {
                this.CurrentItem = null;
            }
            this.gridControl1.RefreshDataSource();
            this.RefreshButtons();
        }
        public override void EditItem()
        {
            string sCode = "";
            if (lookUpStock.EditValue != null)
            {
                sCode = lookUpStock.EditValue.ToString();
            }
            FormEditManufacturePlanWeek f = new FormEditManufacturePlanWeek(sCode);
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.CurrentItem = this.CurrentItem;
            f.EditItem();
            f.Text = this.Text;
            this.ShowChildForm(f);
            if ((this.DataSource as ListBase<ManufacturePlanWeek>).Count > 0)
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
      
    }
}