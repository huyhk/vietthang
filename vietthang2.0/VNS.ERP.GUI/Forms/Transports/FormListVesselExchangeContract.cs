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

    public partial class FormListVesselExchangeContract : FormEditBase
    {

        VesselExchangeContractBLL obj = new VesselExchangeContractBLL();
        public FormListVesselExchangeContract()
        {
            InitializeComponent();
            this.Business = obj;
         //   this.DataSource = obj.get();
            if (!DesignMode)
            {
                this.replkExchangeSubjectCode.DataSource = new VendorBLL().GetForVanchuyen(); //new SubjectBLL().GetKhoVan();
                this.spinEditYear.EditValue = DateTime.Now.Year;
            }
            this.RefeshListDataSource();
        }

        public override void AddNewItem()
        {
            FormEditVesselExchangeContract  f = new FormEditVesselExchangeContract(this.Text);
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

            FormEditVesselExchangeContract f = new FormEditVesselExchangeContract(this.Text);
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
            FormEditVesselExchangeContract f = new FormEditVesselExchangeContract(this.Text);
            SetFormPrivilege(f);
            f.DataSource = this.DataSource; 
            f.CurrentItem = this.CurrentItem;
            this.ShowChildForm(f);
            gridControl1.RefreshDataSource();
            this.RefreshButtons();
        }

        private void RefeshListDataSource()
        {
           // Period p = (this.spinEditYear.Properties. DataSource as ListBase<Period>).Search("PeriodCode", this.spinEditYear.EditValue.ToString());
        //    DateTime.
            //Period p = (lookUpPeriod.Properties.DataSource as ListBase<Period>).Search("PeriodCode", lookUpPeriod.EditValue.ToString());
            DateTime d = new DateTime();
            int Year = int.Parse(spinEditYear.EditValue.ToString());
            DateTime startdate = new DateTime(Year,1, 1);
            DateTime enddate = new DateTime(Year, 12, 31);
            this.DataSource = this.obj.GetByDate(startdate,enddate);

            //this.DataSource = this..GetForPeriod(p.StartDate, p.EndDate);
            this.gridControl1.RefreshDataSource();
            this.gridControl1.Refresh();
            this.gridView1.RefreshData(); 
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (this.spinEditYear.EditValue != null)
            {
                this.RefeshListDataSource();
            }
        }


    }
}