using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.Common;
using VNS.ERP.Data;
using VNS.ERP.Data.Premixs;
using VNS.Windows;

namespace VNS.ERP.GUI
{
    public partial class FormMixPremixShifts : FormEditBase

    {
        private string stockCode;
        private MixPremixShiftBLL mixPremixShiftBLL = new MixPremixShiftBLL();
        public FormMixPremixShifts()
        {
            InitializeComponent();
            this.Business = mixPremixShiftBLL;
        }
        public FormMixPremixShifts(string pstockCode)
        {
            InitializeComponent();
            this.Business = mixPremixShiftBLL;
            stockCode = pstockCode;
        }

        public override void AddNewItem()
        {
            this.ucMixPremixShifts1.stockCode = stockCode;
            base.AddNewItem();
        }
        public override void EditItem()
        {

        }
        public override void RefreshButtons()
        {
            base.RefreshButtons();
            this.btnEdit.Enabled = false;
        }

        private void FormMixPremixShifts_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.EditMode == FormEditMode.ADD)
                CancelNew();
            if (this.EditMode == FormEditMode.EDIT)
                CancelItem();
                }
    }
}