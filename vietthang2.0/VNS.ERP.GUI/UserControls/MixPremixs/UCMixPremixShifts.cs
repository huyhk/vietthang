using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using VNS.Windows.Controls;
using VNS.ERP.Data;
using VNS.ERP.Data.Premixs;
using VNS.Windows;
using VNS.Common;

namespace VNS.ERP.GUI.UserControls
{
    public partial class UCMixPremixShifts : EditControlBase
    {
        public string stockCode;
        public UCMixPremixShifts()
        {
            InitializeComponent();
          
        }
   
        protected override void BindData()
        {
              if (this.editMode == FormEditMode.VIEW)
              {
                  this.cboKho.EditValue = (dataSource as MixPremixShift).StockCode;
              }
              else
                this.cboKho.EditValue = stockCode;
            this.cboCa.Value = (dataSource as MixPremixShift).Shift;
            this.cboNgay.EditValue = (dataSource as MixPremixShift).MixDate;
            this.cboNgay.Focus();
        }

        protected override int ValidateData()
        {
           return 0;
        }
        protected override void AssignData()
        {
            if (dataSource == null)
                dataSource = new MixPremixShift();
            (dataSource as MixPremixShift).Shift = (int)this.cboCa.Value;
            (dataSource as MixPremixShift).StockCode = this.cboKho.GetColumnValue("StockCode").ToString();
            (dataSource as MixPremixShift).MixDate = this.cboNgay.DateTime;
        }

        private void UCMixPremixShifts_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                this.cboKho.Properties.Buttons.Clear();
                this.cboKho.Properties.DataSource = (new StockBLL()).GetAll();
            }
        }
       
        private void SetStatus()
        {
            if (this.EditMode == FormEditMode.VIEW)
            {
                this.cboCa.Properties.ReadOnly = true;
                this.cboNgay.Properties.ReadOnly = true;
            }
            else if (this.EditMode == FormEditMode.ADD)
            {
                this.cboCa.Properties.ReadOnly = false;
                 this.cboNgay.Properties.ReadOnly = false;
                 this.cboCa.Focus();
            }
            else
            {
                this.cboCa.Properties.ReadOnly = true;
                this.cboNgay.Properties.ReadOnly = true;
            }
        }
        public override void RefreshControl()
        {
            SetStatus();
            base.RefreshControl();
    
        }
    }
}
