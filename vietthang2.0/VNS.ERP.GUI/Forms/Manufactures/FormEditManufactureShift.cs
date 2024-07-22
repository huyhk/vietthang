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
using VNS.Windows;
namespace VNS.ERP.GUI.Manufactures
{
    public partial class FormEditManufactureShift : FormEditBase
    {
        private string stockCode = "";
        private ManufactureShiftBLL manufactureShiftBLL = new ManufactureShiftBLL();
        private ListBase<ManufactureShiftTransaction> lst;
        public FormEditManufactureShift()
        {
            InitializeComponent();
          this.Business = manufactureShiftBLL;
        }
        public FormEditManufactureShift(string pstockCode)
        {
            InitializeComponent();
          this.Business = manufactureShiftBLL;
          this.ucManufactureShifts1.StockCode = pstockCode;
            stockCode = pstockCode;
        }
        public override void AddNewItem()
        {
            //this.ucManufactureShifts1.StockCode = stockCode;
            base.AddNewItem();
        }
        public override void EditItem()
        {
          //  this.ucManufactureShifts1.StockCode = stockCode;
            base.EditItem();
            this.BackupDetail();
        }

        private void BackupDetail()
        {
            lst = new ListBase<ManufactureShiftTransaction>();
            if (this.CurrentItem != null)
            {
                if ((this.CurrentItem as ManufactureShift).ListFuelInTransaction != null)
                {
                    foreach (ManufactureShiftTransaction std in (this.CurrentItem as ManufactureShift).ListFuelInTransaction)
                    {
                        ManufactureShiftTransaction std1 = new ManufactureShiftTransaction();
                        std1 = (ManufactureShiftTransaction)std.Clone();
                        lst.Add(std1);
                    }
                }
            }
        }
        public override void CancelItem()
        {
            if (this.EditMode != FormEditMode.ADD)
            {
                (this.CurrentItem as ManufactureShift).ListFuelInTransaction = lst;
            }
            base.CancelItem();

        }

        private void FormEditManufactureShift_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.EditMode == FormEditMode.ADD)
                CancelNew();
            if (this.EditMode == FormEditMode.EDIT)
                CancelItem();
        }


      
       
    }
}