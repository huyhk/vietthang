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
using VNS.ERP.Data.Grinds;
using VNS.Windows;


namespace VNS.ERP.GUI
{
    public partial class FormGrindMaterialShifts : FormEditBase
    {
        private string stockCode;
        private GrindMaterialShiftBLL grindMaterialShiftBLL = new GrindMaterialShiftBLL();
        public FormGrindMaterialShifts()
        {
            InitializeComponent();
            this.Business = grindMaterialShiftBLL;
        
        }
        public FormGrindMaterialShifts(string pstockCode)
        {
            InitializeComponent();
            this.Business = grindMaterialShiftBLL;
            stockCode = pstockCode;
            this.ucGrindMaterialShifts1.stockCode = stockCode;
        }
        //public override void AddNewItem()
        //{
        //    this.ucGrindMaterialShifts1.stockCode = stockCode;
        //    base.AddNewItem();
        //}
        public override object AddNew()
        {
            GrindMaterialShift o = base.AddNew() as GrindMaterialShift;
            o.StockCode = stockCode;

            return o;
        }
        //public override void EditItem()
        //{
           
        //}
        //public override void RefreshButtons()
        //{
        //    base.RefreshButtons();
        //    this.btnEdit.Enabled = false;
        //}

        private void FormGrindMaterialShifts_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.EditMode == FormEditMode.ADD)
                CancelNew();
            if (this.EditMode == FormEditMode.EDIT)
                CancelItem();
        }
    }
}