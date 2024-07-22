using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Sales;

namespace VNS.ERP.GUI.Sales
{
    public partial class FormReportDiscount : FormBase
    {
        DataRowView dr = null;
        DateTime startDate;
        DateTime endDate;
        CustomerDAL cusDal = new CustomerDAL();
        System.Data.DataTable dtDetail = new DataTable();
        private bool isYearDiscount;
        /// <summary>
        /// true: Use case YearDiscount, else: QuarterDiscount
        /// </summary>
        public bool IsYearDiscount
        {
            get { return isYearDiscount; }
            set 
            {
                isYearDiscount = value;
                colQuarterDiscount.Visible = !value;
                colQuarterDiscountAmount.Visible = !value;
                colQuarterDiscountAmount1.Visible = !value;
                colYearDiscount.Visible = value;
                colYearDiscountAmount.Visible = value;
                colYearDiscountAmount1.Visible = value;

                lbQuarter.Visible = !value;
                numUpDnQuarter.Visible = !value;
                if (value)
                {
                    TxtYearNo.Left -= (lbYear.Left - lbQuarter.Left);
                    btnBaoCao.Left -= (lbYear.Left - lbQuarter.Left);
                    lbYear.Left = lbQuarter.Left;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public FormReportDiscount()
        {
            InitializeComponent();
        }
        /// <summary>
        /// use
        /// </summary>
        /// <param name="isYearDiscountValue"></param>
        public FormReportDiscount(bool isYearDiscountValue)
        {
            InitializeComponent();
            this.IsYearDiscount = isYearDiscountValue;
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            int quarter;
            int year;
           

            if (this.IsYearDiscount)
            {
                year = Convert.ToInt32(TxtYearNo.EditValue);
                startDate = new DateTime(year, 1, 1);
                endDate = new DateTime(year, 12, DateTime.DaysInMonth(year, 12));
            }
            else
            {
                quarter = Convert.ToInt32(numUpDnQuarter.Value);
                year = Convert.ToInt32(TxtYearNo.EditValue);

                startDate = new DateTime(year, 3 * quarter - 2, 1);
                endDate = new DateTime(year, 3 * quarter, DateTime.DaysInMonth(year,3*quarter));
            }
            dtDetail = cusDal.ReportDiscountDetail(startDate, endDate);
            gridControl1.DataSource = cusDal.ReportDiscount(startDate, endDate);
            gridView1.ExpandAllGroups();
            btnReportDiscount.Enabled = true;
            btnReportDiscountDetail.Enabled = true;
           // gridControl2.DataSource = dtDetail;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
            string strFilter = "";
            CurrencyManager cr = this.BindingContext[gridControl1.DataSource] as CurrencyManager;
            try
            {
                dr = cr.Current as DataRowView;
                strFilter = "CustomerCode='" + dr["CustomerCode"].ToString() + "'";
            }
            catch 
            {
            }
            
            DataView dv = dtDetail.DefaultView;
            gridView2.ActiveFilter.Clear();
            
            dv.RowFilter = strFilter;
            gridControl2.DataSource = dv.ToTable();
        }

        private void btnReportDiscount_Click(object sender, EventArgs e)
        {
            RpDiscount rp = new RpDiscount(this.IsYearDiscount, VNS.Windows.GridUtils.GetDataView(gridControl1).ToTable(), this.startDate, this.endDate);
            rp.ShowPreviewDialog();
        }

        private void numUpDnQuarter_ValueChanged(object sender, EventArgs e)
        {
            btnReportDiscount.Enabled = false;
            btnReportDiscountDetail.Enabled = false;
        }

        private void TxtYearNo_EditValueChanged(object sender, EventArgs e)
        {
            btnReportDiscount.Enabled = false;
            btnReportDiscountDetail.Enabled = false;
        }

        private void btnReportDiscountDetail_Click(object sender, EventArgs e)
        {
            RpDiscountDetail rp = new RpDiscountDetail(this.IsYearDiscount, dr, VNS.Windows.GridUtils.GetDataView(gridControl2).ToTable(), this.startDate, this.endDate);
            rp.ShowPreviewDialog();
        }
    }
}