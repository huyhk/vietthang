using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Grinds;
using VNS.Windows;
using System.Collections;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class FormEditGrindMaterials : FormEditBase
    {
        private string stockCode=string.Empty;
        private GrindMaterialShift CurrentShift;
        public FormEditGrindMaterials()
        {
            InitializeComponent();

        }
        public FormEditGrindMaterials(GrindMaterialShift grindShift)
        {
            InitializeComponent();
            this.Business = new GrindMaterialBLL();
            CurrentShift = grindShift;
            this.UCGrindMaterials1.CurrentShift = CurrentShift;
            this.DataSource = grindShift.LstGrindMaterial;
        }

        
        public override void AddNewItem()
        {
            this.UCGrindMaterials1.stockCode = stockCode;
            base.AddNewItem();
        }
        public override void EditItem()
        {
            this.UCGrindMaterials1.stockCode = stockCode;
            base.EditItem();
        }

        private void FormEditGrindMaterials_FormClosing(object sender, FormClosingEventArgs e)
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