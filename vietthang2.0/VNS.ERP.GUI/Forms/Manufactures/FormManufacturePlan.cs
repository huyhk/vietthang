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
using System.Collections;

namespace VNS.ERP.GUI.Manufactures
{
    public partial class FormManufacturePlan : FormEditBase
    {
        private ManufacturePlanBLL manufacturePlanBLL = new ManufacturePlanBLL();
        private ListBase<ManufacturePlan> lstManufacturePlans = new ListBase<ManufacturePlan>();
        private ListBase<Period> lstPeriods = null;
        private DateTime startDate = Contexts.WorkingStartDate;
        private DateTime endDate = Contexts.WorkingEndDate;
        public FormManufacturePlan()
        {
            InitializeComponent();
            this.Business = manufacturePlanBLL;
        }

        private void FormManufacturePlan_Load(object sender, EventArgs e)
        {
            lstPeriods = new PeriodBLL().GetAll();
            this.cboPeriodCode.Properties.DataSource = lstPeriods;
            this.cboPeriodCode.EditValue = Contexts.WorkingPeriod.PeriodCode;

            this.lookUpStockCode.Properties.DataSource = (new StockBLL()).GetAllForMember(Contexts.CurrentUser.MemberID);
            this.lookUpStockCode.ItemIndex = 0;
        }

        private void lookUpStockCode_EditValueChanged(object sender, EventArgs e)
        {
            if (this.lookUpStockCode.ItemIndex >= 0)
            {
                lstManufacturePlans = manufacturePlanBLL.GetListObjectByTime(startDate, endDate, this.lookUpStockCode.EditValue.ToString());
                this.DataSource = lstManufacturePlans;
            }
        }
        public override void AddNewItem()
        {
            if (this.lookUpStockCode.ItemIndex >= 0)
            {
      
                FormManufacturePlanDetail frm = new FormManufacturePlanDetail(this.lookUpStockCode.EditValue.ToString(),this.lookUpStockCode.Text);
                SetFormPrivilege(frm);
                frm.DataSource = this.DataSource;
                frm.AddNewItem();
                this.ShowChildForm(frm);
                if ((this.DataSource as ListBase<ManufacturePlan>).Count > 0)
                {
                    this.CurrentItem = frm.CurrentItem;
                    this.gridView.FocusedRowHandle = lstManufacturePlans.IndexOf(this.CurrentItem as ManufacturePlan);
                }
                else
                    this.CurrentItem = null;
                gridControl.RefreshDataSource();
                this.RefreshButtons();
            }
        }
        public override void  EditItem()
        {
            FormManufacturePlanDetail frm = new FormManufacturePlanDetail(this.lookUpStockCode.EditValue.ToString(), this.lookUpStockCode.Text);
            SetFormPrivilege(frm);
            frm.DataSource = this.DataSource;
            frm.CurrentItem = this.CurrentItem;
            frm.EditItem();
            this.ShowChildForm(frm);
            if ((this.DataSource as ListBase<ManufacturePlan>).Count > 0)
                this.CurrentItem = frm.CurrentItem;
            else
                this.CurrentItem = null;
            gridControl.RefreshDataSource();
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            FormManufacturePlanDetail frm = new FormManufacturePlanDetail(this.lookUpStockCode.EditValue.ToString(),this.lookUpStockCode.Text);
            SetFormPrivilege(frm);
            frm.DataSource = this.DataSource;
            frm.CurrentItem = this.CurrentItem;
            this.ShowChildForm(frm);
            if ((this.DataSource as ListBase<ManufacturePlan>).Count > 0)
                this.CurrentItem = frm.CurrentItem;
            else
                this.CurrentItem = null;
            gridControl.RefreshDataSource();
        }

        private void cboPeriodCode_EditValueChanged(object sender, EventArgs e)
        {
            if (this.lookUpStockCode.ItemIndex != -1)
            {
                startDate = lstPeriods[this.cboPeriodCode.ItemIndex].StartDate;
                endDate = lstPeriods[this.cboPeriodCode.ItemIndex].EndDate;
                lstManufacturePlans = manufacturePlanBLL.GetListObjectByTime(startDate,endDate, this.lookUpStockCode.EditValue.ToString());
                this.DataSource = lstManufacturePlans;
            }
        }

    }
}