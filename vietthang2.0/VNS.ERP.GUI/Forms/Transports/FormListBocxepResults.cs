using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.Common;

namespace VNS.ERP.GUI.Transports
{
    public partial class FormListBocxepResults : FormEditBase
    {
        BocxepResultBLL obj = new BocxepResultBLL();
        public FormListBocxepResults()
        {
            InitializeComponent();
            if (!this.DesignMode)
            {
                this.lookUpEditBocxepSubject.Properties.DataSource = new VendorBLL().GetForBocxep(); //new SubjectBLL().GetKhoVan();
                this.lookUpEditStockCode.Properties.DataSource = new StockBLL().GetAll();
                this.repSubjectCode.DataSource = new SubjectBLL().GetAll();
                this.repStockCode.DataSource = new StockBLL().GetAll();
                this.lookUpPeriod.Properties.DataSource = new PeriodBLL().GetAll();
                lookUpPeriod.EditValue = Contexts.WorkingPeriod.PeriodCode;
            }    
            this.Business = obj;
            
           
        }

        public override void AddNewItem()
        {
            FormEditBocxepResults f = new FormEditBocxepResults(this.Text,lookUpEditBocxepSubject.EditValue.ToString(),lookUpEditStockCode.EditValue.ToString());
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.AddNewItem();
            this.ShowChildForm(f);
            gridControl1.RefreshDataSource();
            this.RefreshButtons();
        }


        private void RefeshListDataSource()
        {
            Period p = (lookUpPeriod.Properties.DataSource as ListBase<Period>).Search("PeriodCode", lookUpPeriod.EditValue.ToString());
            this.DataSource = obj.GetForBXSubjectCodeAndStockCode(lookUpEditBocxepSubject.EditValue.ToString(), lookUpEditStockCode.EditValue.ToString(),p.StartDate, p.EndDate);
            this.gridControl1.RefreshDataSource();
            this.gridControl1.Refresh();
            this.gridView1.RefreshData();
        }

        public override void EditItem()
        {

            FormEditBocxepResults f = new FormEditBocxepResults(this.Text, lookUpEditBocxepSubject.EditValue.ToString(), lookUpEditStockCode.EditValue.ToString());
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.CurrentItem = this.CurrentItem;
            f.EditItem();
            this.ShowChildForm(f);
            gridControl1.RefreshDataSource();
            this.RefreshButtons();

        }


        //private void gridView1_DoubleClick(object sender, EventArgs e)
        //{
           
        //}

        private void KT()
        {
        }

        private void FormListBocxepResults_Load(object sender, EventArgs e)
        {
            
            lookUpEditBocxepSubject.ItemIndex = 0;
            lookUpEditStockCode.ItemIndex = 0;
            //if (lookUpEditBocxepSubject.EditValue != null && lookUpEditStockCode.EditValue != null)
            //{
            //    this.DataSource = obj.GetForBXSubjectCodeAndStockCode(lookUpEditBocxepSubject.EditValue.ToString(), lookUpEditStockCode.EditValue.ToString());
            //}
        }

        private void lookUpEditBocxepSubject_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpEditBocxepSubject.EditValue != null && lookUpEditStockCode.EditValue != null && lookUpPeriod.EditValue!=null)
            {
                this.RefeshListDataSource();
            }
        }

        private void lookUpEditStockCode_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpEditBocxepSubject.EditValue != null && lookUpEditStockCode.EditValue != null && lookUpPeriod.EditValue != null)
            {
                this.RefeshListDataSource();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if(lookUpEditBocxepSubject.EditValue==null)
            {
                MessageBox.Show(this.GetTextMessage("a1","chưa chọn kho vận"));
                return;
            }
            if(lookUpEditStockCode.EditValue ==null)
            {
                MessageBox.Show(this.GetTextMessage("a2","chưa chọn kho "));
                return;
            }
            RefeshListDataSource();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FormEditBocxepResults f = new FormEditBocxepResults(this.Text, lookUpEditBocxepSubject.EditValue.ToString(), lookUpEditStockCode.EditValue.ToString());
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.CurrentItem = this.CurrentItem;
            //f.EditItem();
            this.ShowChildForm(f);
            gridControl1.RefreshDataSource();
            this.RefreshButtons();
        }

        private void lookUpPeriod_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpEditBocxepSubject.EditValue != null && lookUpEditStockCode.EditValue != null && lookUpPeriod.EditValue != null)
            {
                this.RefeshListDataSource();
            }
        }

        //private void gridView1_DoubleClick(object sender, EventArgs e)
        //{
        //    FormEditBocxepResults f = new FormEditBocxepResults(this.Text, lookUpEditBocxepSubject.EditValue.ToString(), lookUpEditStockCode.EditValue.ToString());
        //    SetFormPrivilege(f);
        //    f.DataSource = this.DataSource;
        //    f.CurrentItem = this.CurrentItem;
        //    //f.EditItem();
        //    this.ShowChildForm(f);
        //    gridControl1.RefreshDataSource();
        //    this.RefreshButtons();
        //}

        //private void gridView1_DoubleClick_1(object sender, EventArgs e)
        //{
        //    MessageBox.Show("hi");
        //}
       
    }
}