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
    public partial class FormListVesselTransactions : FormEditBase
    {
        VesselTransactionBLL obj = new VesselTransactionBLL();
        public FormListVesselTransactions()
        {
           
            InitializeComponent();
            if(!DesignMode)
            {
                lookUpEditTransactionDate.Properties.DataSource = new PeriodBLL().GetAll();
                this.repVesselCode.DataSource = new VesselBLL().GetAll();
                this.repVendorCode.DataSource = new VendorBLL().GetAll();
                this.lookUpEditTransactionDate.EditValue = Contexts.WorkingPeriod.PeriodCode;
                //this.lookUpEditTransactionDate.ItemIndex = 0;
            }
            this.Business = obj;
            
           //this.lookUpEditTransactionDate.EditValue = Contexts.WorkingPeriod.PeriodCode;
        }

        public override void AddNewItem()
        {
            FormEditVesselTransactions f = new FormEditVesselTransactions();
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.AddNewItem();
            this.ShowChildForm(f);
            gridControl1.RefreshDataSource();
            this.RefreshButtons();
        }


        private void RefeshListDataSource()
        {
            Period p = (this.lookUpEditTransactionDate.Properties.DataSource as ListBase<Period>).Search("PeriodCode", lookUpEditTransactionDate.EditValue.ToString());
            //Period p = (lookUpPeriod.Properties.DataSource as ListBase<Period>).Search("PeriodCode", lookUpPeriod.EditValue.ToString());
            this.DataSource = this.obj.GetForPeriod(p.StartDate, p.EndDate);
            
            //this.DataSource = this..GetForPeriod(p.StartDate, p.EndDate);
            this.gridControl1.RefreshDataSource();
            this.gridControl1.Refresh();
            this.gridView1.RefreshData();
        }

        public override void EditItem()
        {

            FormEditVesselTransactions f = new FormEditVesselTransactions();
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.CurrentItem = this.CurrentItem;
            f.EditItem();
            this.ShowChildForm(f);
            gridControl1.RefreshDataSource();
            this.RefreshButtons();

        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if(lookUpEditTransactionDate.EditValue==null)
            {
                MessageBox.Show(this.GetTextMessage("a1","chưa chọn kỳ"));
                return;
            }
            RefeshListDataSource();
        }

        private void lookUpEditTransactionDate_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpEditTransactionDate.EditValue != null)
            {
                RefeshListDataSource();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FormEditVesselTransactions f = new FormEditVesselTransactions();
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.CurrentItem = this.CurrentItem;
            //f.EditItem();
            this.ShowChildForm(f);
            gridControl1.RefreshDataSource();
            this.RefreshButtons();
        }

     }
}