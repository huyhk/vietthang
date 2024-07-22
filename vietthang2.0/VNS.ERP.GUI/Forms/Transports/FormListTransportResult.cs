using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data.Transports;
using VNS.Common;
using VNS.ERP.Data;

namespace VNS.ERP.GUI.Transports
{
    public partial class FormListTransportResult : VNS.Windows.Forms.FormEditBase
    {
        ListBase<TransportRoute> LstTransportRoute = null;
        public FormListTransportResult()
        {
            InitializeComponent();
            LstTransportRoute = new VNS.ERP.Data.TransportRouteBLL().GetAll();
            txtTransportRoute.Properties.DataSource = LstTransportRoute;
            this.repTransportRoute.DataSource = LstTransportRoute;
            this.business = new TransportResultBLL();
            this.txtSubject.DataSource = new VendorBLL().GetForVanchuyen(); //new VNS.ERP.Data.SubjectBLL().GetKhoVan();
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetDataSource(this.txtTransportRoute.EditValue.ToString(), this.ucDatePeriodSelection1.StartDate, this.ucDatePeriodSelection1.EndDate);
        }
        private void GetDataSource(string routeCode, DateTime fromDate, DateTime toDate)
        {
            routeCode = "";
            this.DataSource = new TransportResultBLL().GetByRouteAndDate(routeCode, fromDate, toDate);
        }
        public override void AddNewItem()
        {
            FormEditTransportResult f = new FormEditTransportResult(LstTransportRoute.Search("RouteCode", this.txtTransportRoute.EditValue));
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.AddNewItem();
            this.ShowChildForm(f);
            gridData.RefreshDataSource();
            this.RefreshButtons();
        }
        public override void EditItem()
        {
            FormEditTransportResult f = new FormEditTransportResult(LstTransportRoute.Search("RouteCode", this.txtTransportRoute.EditValue));
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.CurrentItem = this.CurrentItem;
            f.EditItem();
            this.ShowChildForm(f);
            gridData.RefreshDataSource();
            this.RefreshButtons();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FormEditTransportResult f = new FormEditTransportResult(LstTransportRoute.Search("RouteCode", this.txtTransportRoute.EditValue));
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.CurrentItem = this.CurrentItem;
            //f.EditItem();
            this.ShowChildForm(f);
            gridData.RefreshDataSource();
            this.RefreshButtons();
        }

        private void FormListTransportResult_Load(object sender, EventArgs e)
        {
            this.ucDatePeriodSelection1.WorkingDate = DateTime.Today;
            this.ucDatePeriodSelection1.SetCheckMonth();
            this.txtTransportRoute.ItemIndex = 0;
            this.txtTransportRoute.EditValue = "";
            GetDataSource(this.txtTransportRoute.EditValue.ToString(), this.ucDatePeriodSelection1.StartDate, this.ucDatePeriodSelection1.EndDate);
            //GetDataSource("", this.ucDatePeriodSelection1.StartDate, this.ucDatePeriodSelection1.EndDate);
        }
    }
}

