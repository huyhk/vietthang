using System;
using System.Collections;
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
using VNS.Windows;
using VNS.Windows.Controls;

namespace VNS.ERP.GUI.Manufactures
{
    public partial class FormEditManufactures : FormEditBase
    {
        private ManufactureBLL _ManufactureBLL = new ManufactureBLL();
        private ListBase<Manufacture> lstManufactures=new ListBase<Manufacture>();


        private ManufactureShift CurrentShift;
        public FormEditManufactures()
        {
            InitializeComponent();
          
        }
        public FormEditManufactures(ManufactureShift _manufactureShift)
        {
            InitializeComponent();
            this.Business = _ManufactureBLL;
            CurrentShift = _manufactureShift;
            this.UCManufactures1.CurrentShift = CurrentShift;
            this.DataSource = _manufactureShift.ListManufacture;
        }
        
        public override void AddNewItem()
        {
            base.AddNewItem();
        }
        public override void EditItem()
        {
           base.EditItem();
        }

        private void FormEditManufactures_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.EditMode == FormEditMode.ADD)
                CancelNew();
            if (this.EditMode == FormEditMode.EDIT)
                CancelItem();
        }

    
    }
}