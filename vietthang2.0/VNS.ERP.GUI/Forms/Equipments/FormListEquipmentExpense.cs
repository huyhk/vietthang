using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Equipments;
using VNS.Common;

namespace VNS.ERP.GUI.Equipments
{
    public partial class FormListEquipmentExpense : FormEditBase
    {
        EquipmentExpensBLL obj = new EquipmentExpensBLL();
        public FormListEquipmentExpense()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                this.lkStockCode.Properties.DataSource = new StockBLL().GetAll();
                this.lkPeriod.Properties.DataSource = new PeriodBLL().GetAll();
                this.lkPeriod.EditValue = Contexts.WorkingPeriod.PeriodCode;
            }
                //this.lkStockCode.ItemIndex = 1;
            this.Business = obj;
            //RefeshListDataSource();
        }

        public override void AddNewItem()
        {
            FormEditEquipmentExpense f = new FormEditEquipmentExpense(this.Text,lkStockCode.EditValue.ToString());
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
           
            f.AddNewItem();
            this.ShowChildForm(f);
            gridControl1.RefreshDataSource();
            this.RefreshButtons();
        }


        //private void RefeshListDataSource()
        //{
        //    this.DataSource = obj.GetAll() ;
        //    this.gridControl1.RefreshDataSource();
        //    this.gridControl1.Refresh();
        //    this.gridView1.RefreshData();
        //}

        public override void EditItem()
        {

            FormEditEquipmentExpense f = new FormEditEquipmentExpense(this.Text, this.lkStockCode.EditValue.ToString());
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.CurrentItem = this.CurrentItem;
            f.EditItem();
            this.ShowChildForm(f);
            gridControl1.RefreshDataSource();
            this.RefreshButtons();

        }

 

        private void RefeshListDataSource()
        {
            Period p = (this.lkPeriod.Properties. DataSource as ListBase<Period>).Search("PeriodCode", this.lkPeriod .EditValue.ToString());
            //    DateTime.
            //Period p = (lookUpPeriod.Properties.DataSource as ListBase<Period>).Search("PeriodCode", lookUpPeriod.EditValue.ToString());
            //        DateTime d = new DateTime();
            //int Year = int.Parse(spinEditYear.EditValue.ToString());
            //DateTime startdate = new DateTime(Year, 1, 1);
            //DateTime enddate = new DateTime(Year, 12, 31);
           // this.DataSource = this.obj(startdate, enddate);
            this.DataSource = obj.GetByDateAndStockCode(p.StartDate, p.EndDate, lkStockCode.EditValue.ToString());

            //this.DataSource = this..GetForPeriod(p.StartDate, p.EndDate);
            this.gridControl1.RefreshDataSource();
            this.gridControl1.Refresh();
            this.gridView1.RefreshData();
        }

     

        //private void gridView1_DoubleClick(object sender, EventArgs e)
        //{
        //    FormEditExchangeResult f = new FormEditExchangeResult(this.Text);
        //    SetFormPrivilege(f);
        //    f.DataSource = this.DataSource;
        //    f.CurrentItem = this.CurrentItem;
        //    this.ShowChildForm(f);
        //    gridControl1.RefreshDataSource();
        //    this.RefreshButtons();
        //}

     

        private void lkStockCode_EditValueChanged(object sender, EventArgs e)
        {
            if (this.lkPeriod.EditValue != null && this.lkStockCode.EditValue != null)
            {
                RefeshListDataSource();
            }
        }

        private void lkPeriod_EditValueChanged(object sender, EventArgs e)
        {
            if (this.lkPeriod.EditValue != null && this.lkStockCode.EditValue != null)
            {
                RefeshListDataSource();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FormEditEquipmentExpense f = new FormEditEquipmentExpense(this.Text, this.lkStockCode.EditValue.ToString());
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.CurrentItem = this.CurrentItem;
            this.ShowChildForm(f);
            gridControl1.RefreshDataSource();
            this.RefreshButtons();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefeshListDataSource();
        }

        private void FormListEquipmentExpense_Load(object sender, EventArgs e)
        {
         
            this.lkStockCode.ItemIndex = 0;
            //this.lkPeriod.ItemIndex = 0;  
           
        }

    
    }
}