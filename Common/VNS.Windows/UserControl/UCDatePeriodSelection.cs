using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.Common;
using VNS.Data;
//using VNS.Utils;

namespace VNS.Windows.UserControls
{
    public partial class UCDatePeriodSelection : UserControl
    {
        public UCDatePeriodSelection()
        {
            InitializeComponent();
            this.WorkingDate = DateTime.Today;
        }
        private DateTime workingDate;
        [DefaultValue(null), Browsable(false), ReadOnly(true)]
        public DateTime WorkingDate
        {
            get
            {
                return workingDate;
            }
            set 
            {
                workingDate = value;
                int day, month, year;
                year = workingDate.Year;
                month = workingDate.Month;
                day = workingDate.Day;
                TxtYearNo.Text = year.ToString();
                numUpDnQuaterNo.Value = Convert.ToDecimal((int)((month + 2) / 3));
                txtYearOfQuater.Text = year.ToString();
                numUpDnMonthNo.Value = Convert.ToDecimal(month);
                txtYearOfMonth.Text = year.ToString();
                dateEditStart.DateTime = workingDate;
                dateEditEnd.DateTime = workingDate;
            }
        }
        public delegate void EditPeriodChanged(object sender, EventArgs e);
        public event EditPeriodChanged OnEditValueChanged;
        /// <summary>
        /// Get or set text for group option button
        /// </summary>
        [DefaultValue("Chọn khoảng thời gian"), Category("Default Text"), Browsable(true), Description("Text for group option button")]
        public string GroupText
        {
            get { return grBoxPeriodSelect.Text; }
            set { grBoxPeriodSelect.Text = value; }
        }
        private bool allowCheckDate = true;
        [DefaultValue(true), Category("OptionCheck"), Browsable(true), Description("Visible/Invisible a option check")]
        public bool AllowCheckDate
        {
            get { return allowCheckDate; }
            set 
            { 
                allowCheckDate = value;
                optDay.Visible = value;
                dateEditStart.Visible = value;
                lbEndDate.Visible = value;
                dateEditEnd.Visible = value;
                if (!value)
                {
                    optMonth.Checked = true;
                }
            }
        }
        private bool allowCheckQuarter = true;
        [DefaultValue(true), Category("OptionCheck"), Browsable(true), Description("Visible/Invisible a option check")]
        public bool AllowCheckQuarter
        {
            get { return allowCheckQuarter; }
            set
            {
                allowCheckQuarter = value;
                optQuater.Visible = value;
                numUpDnQuaterNo.Visible = value;
                txtYearOfQuater.Visible = value;
                if (!value)
                {
                    optMonth.Checked = true;
                }
            }
        }
        /// <summary>
        /// Return text for report
        /// </summary>
        [Browsable(false)]
        public string PeriodText
        {
            get 
            {
                string returnValue="";
                if (optDay.Checked)
                {
                    if (this.StartDate == this.EndDate)
                        returnValue = "Ngày " + this.StartDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
                    else
                    {
                        returnValue = "Từ ngày " + this.StartDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
                        returnValue += " đến ngày " + this.EndDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
                    }
                }
                if (optMonth.Checked)
                {
                    returnValue = "Tháng " + numUpDnMonthNo.Value.ToString() + " năm " + txtYearOfMonth.Text;
                }
                if (optQuater.Checked)
                {
                   returnValue = "Quý " + numUpDnQuaterNo.Value.ToString() + " năm " + txtYearOfQuater.Text;
                }
                if (optYear.Checked)
                {
                    returnValue = "Năm " + TxtYearNo.Text;
                }
                return returnValue;
            }
        }
        /// <summary>
        /// Return startdate
        /// </summary>
        [Browsable(false)]
        public DateTime StartDate
        {
            get 
            {
                int day, month, year;
                DateTime returnValue = new DateTime();
                if (optDay.Checked)
                {
                    returnValue = dateEditStart.DateTime;
                }
                if (optMonth.Checked)
                {
                    day = 1;
                    month = Convert.ToInt16(numUpDnMonthNo.Value);
                    year = Convert.ToInt16(txtYearOfMonth.Text);
                    returnValue = new DateTime(year, month, day);
                }
                if (optQuater.Checked)
                {
                    day = 1;
                    month = Convert.ToInt16(numUpDnQuaterNo.Value * 3 - 2);
                    year = Convert.ToInt16(txtYearOfQuater.Text);
                    returnValue = new DateTime(year, month, day);
                }
                if (optYear.Checked)
                {
                    day = 1;
                    month = 1;
                    year = Convert.ToInt16(TxtYearNo.Text);
                    returnValue = new DateTime(year, month, day);
                }
                return returnValue;
            }
        }
        /// <summary>
        /// Return end date
        /// </summary>
        [Browsable(false)]
        public DateTime EndDate
        {
            get
            {
                int day, month, year;
                DateTime returnValue = new DateTime();
                if (optDay.Checked)
                {
                    returnValue = dateEditEnd.DateTime;
                }
                if (optMonth.Checked)
                {
                    month = Convert.ToInt16(numUpDnMonthNo.Value);
                    year = Convert.ToInt16(txtYearOfMonth.Text);
                    day = DateTime.DaysInMonth(year, month);
                    returnValue = new DateTime(year, month, day);
                }
                if (optQuater.Checked)
                {
                    month = Convert.ToInt16(numUpDnQuaterNo.Value * 3);
                    year = Convert.ToInt16(txtYearOfQuater.Text);
                    day = DateTime.DaysInMonth(year, month);
                    returnValue = new DateTime(year, month, day);
                }
                if (optYear.Checked)
                {
                    month = 12;
                    year = Convert.ToInt16(TxtYearNo.Text);
                    day = DateTime.DaysInMonth(year, month);
                    returnValue = new DateTime(year, month, day);
                }
                return returnValue;
            }
        }
        private void opt_CheckedChanged(object sender, EventArgs e)
        {
            TxtYearNo.Enabled = optYear.Checked;
            numUpDnQuaterNo.Enabled = optQuater.Checked;
            txtYearOfQuater.Enabled = optQuater.Checked;
            numUpDnMonthNo.Enabled = optMonth.Checked;
            txtYearOfMonth.Enabled = optMonth.Checked;
            dateEditStart.Enabled = optDay.Checked;
            dateEditEnd.Enabled = optDay.Checked;
            if (OnEditValueChanged != null) OnEditValueChanged(sender, e);
        }

        private void TxtYearNo_EditValueChanged(object sender, EventArgs e)
        {
            if (OnEditValueChanged != null) OnEditValueChanged(sender, e);
        }

        private void txtYearOfQuater_EditValueChanged(object sender, EventArgs e)
        {
            if (OnEditValueChanged != null) OnEditValueChanged(sender, e);
        }

        private void txtYearOfMonth_EditValueChanged(object sender, EventArgs e)
        {
            if (OnEditValueChanged != null) OnEditValueChanged(sender, e);
        }

        private void dateEditStart_EditValueChanged(object sender, EventArgs e)
        {
            if (OnEditValueChanged != null) OnEditValueChanged(sender, e);
        }

        private void dateEditEnd_EditValueChanged(object sender, EventArgs e)
        {
            if (OnEditValueChanged != null) OnEditValueChanged(sender, e);
        }

        private void numUpDnQuaterNo_EditValueChanged(object sender, EventArgs e)
        {
            if (OnEditValueChanged != null) OnEditValueChanged(sender, e);
        }

        private void numUpDnMonthNo_EditValueChanged(object sender, EventArgs e)
        {
            if (OnEditValueChanged != null) OnEditValueChanged(sender, e);
        }
        public void SetCheckMonth()
        {
            this.optMonth.Checked = true;
        }
        public void SetCurrentYear()
        {
            this.TxtYearNo.EditValue = DateTime.Today.Year;
            this.optYear.Checked = true;
        }
        public bool SelectYear
        {
            get { return this.optYear.Checked; }
        }
        public void SetCurrentMonth()
        {
            this.txtYearOfMonth.EditValue = DateTime.Today.Year;
            this.numUpDnMonthNo.EditValue = DateTime.Today.Month;
            this.optMonth.Checked = true;
        }
        public int CheckedGroup
        {
            get
            {
                int i = 0;
                if (this.optYear.Checked)
                    i = 1;
                else if (this.optQuater.Checked)
                    i = 2;
                else if (this.optMonth.Checked)
                    i = 3;
                else
                    i = 4;
                return i;
            }
        }
    }
}
