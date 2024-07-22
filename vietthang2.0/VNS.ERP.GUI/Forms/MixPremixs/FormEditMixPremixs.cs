using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Premixs;

using VNS.Windows;
using System.Collections;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class FormEditMixPremixs : FormEditBase
    {
        private string stockCode=string.Empty ;
        private MixPremixShift CurrentShift;
        public FormEditMixPremixs()
        {
            InitializeComponent();

        }
        public FormEditMixPremixs(MixPremixShift mixShift)
        {
            InitializeComponent();
            this.Business = new MixPremixBLL();
            CurrentShift =mixShift;
            this.UCPremixs1.CurrentShift = CurrentShift;
            this.DataSource = mixShift.LstMixPremix;
        }
       

        public override void AddNewItem()
        {
            this.UCPremixs1.stockCode = stockCode;
            base.AddNewItem();
          
        }
        public override void EditItem()
        {
            this.UCPremixs1.stockCode = stockCode;
            base.EditItem();
        }
       

        private void FormEditMixPremixs_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.EditMode == FormEditMode.ADD)
                CancelNew();
            if (this.EditMode == FormEditMode.EDIT)
                CancelItem();
        }
        public override void RefreshButtons()
        {
            base.RefreshButtons();

        }
    }
}