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
using VNS.Common;
namespace VNS.ERP.GUI
{
    public partial class FormMaterialFormula : FormEditBase
    {
        GeneralMaterial _GeneralMaterial = new  GeneralMaterial();
        public FormMaterialFormula()
        {
            InitializeComponent();
            this.Business = new  GeneralMaterialBLL();
            this.DataSource = new  MaterialFormularBLL().GetAll();
            this.AddNewRow.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(AddNewRow_ButtonClick);
        }

        void AddNewRow_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            _GeneralMaterial = new GeneralMaterial();
            object obj = (this.BindingContext[gridControlMaterial.DataSource] as CurrencyManager).Current;
            _GeneralMaterial.FormulaCode = (obj as GeneralMaterial).FormulaCode;
            _GeneralMaterial.Description = (obj as GeneralMaterial).Description;
            FormMaterialFormulaDetail f = new FormMaterialFormulaDetail(_GeneralMaterial, false);
            f.ShowDialog();
            if (f.iError == 0)
                (this.gridViewMaterial.DataSource as IBindingList).Add(f._GeneralMaterial);
        }
        
        public override void RefreshButtons()
        {
            base.RefreshButtons();
            this.btnAdd.Enabled = true;
            if (this.gridViewMaterial.DataRowCount == 0)
            {
                this.btnRemove.Enabled = false;
                this.btnEdit.Enabled = false;
            }
            else
            {
                this.btnRemove.Enabled = true;
                this.btnEdit.Enabled = true;
            }
        }
        public override void AddNewItem()
        {

            _GeneralMaterial = ((this.gridViewMaterial.DataSource as IBindingList).AddNew() as GeneralMaterial);
            FormMaterialFormulaDetail f = new FormMaterialFormulaDetail(_GeneralMaterial);
            f.ShowDialog();
            if (f.iError != 0)
                (this.gridViewMaterial.DataSource as IBindingList).Remove(_GeneralMaterial);
            else
                this.gridControlMaterial.RefreshDataSource();
            RefreshButtons();

        }
        public override void EditItem()
        {
     

            _GeneralMaterial = ((this.BindingContext[gridControlMaterial.DataSource] as CurrencyManager).Current as GeneralMaterial);
            FormMaterialFormulaDetail f = new FormMaterialFormulaDetail(_GeneralMaterial, true);
            f.ShowDialog();
            gridControlMaterial.RefreshDataSource();
         

            foreach (GeneralMaterial obj in (this.gridViewMaterial.DataSource as ListBase<GeneralMaterial>))
            {
                if (obj.FormulaCode == _GeneralMaterial.FormulaCode) obj.Description = _GeneralMaterial.Description;
            }
            this.gridControlMaterial.RefreshDataSource();
        }

        private void FormMaterialFormula_Load(object sender, EventArgs e)
        {
            if (!AllowAddNew)
                AddNewRow.Buttons[0].Visible = false;
        }
    }
}