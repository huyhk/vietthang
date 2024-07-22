using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Premixs;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class FormPremixFormula : FormEditBase
    {
        GeneralPremix _GeneralPremix = new GeneralPremix();
        public FormPremixFormula()
        {
            InitializeComponent();
            this.Business = new GeneralPremixBLL();
            this.DataSource = new PremixFormulaBLL().GetAll();
            this.AddNewRow.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(AddNewRow_ButtonClick);
           
        }

        void AddNewRow_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            object obj=(this.BindingContext[gridControl1.DataSource] as CurrencyManager).Current;
            _GeneralPremix = new GeneralPremix();
            _GeneralPremix.FormulaCode = (obj as GeneralPremix).FormulaCode;
            _GeneralPremix.Description = (obj as GeneralPremix).Description;
            FormPremixFormulaDetail f = new FormPremixFormulaDetail(_GeneralPremix, false);
            f.ShowDialog();
            if (f.iError == 0)
            {
                (this.gridView1.DataSource as IBindingList).Add(f._GeneralPremix);
                RefreshIsActive(f._GeneralPremix);
            }
           
        }
        void RefreshIsActive(GeneralPremix gp)
        {
            foreach (GeneralPremix p in (this.DataSource as ListBase<GeneralPremix>))
            {
                if (p.FormulaCode == gp.FormulaCode)
                {
                    p.IsActive = gp.IsActive;
                }
            }
        }
        public override void RefreshButtons()
        {
    
            base.RefreshButtons();
            this.btnAdd.Enabled = true;
            if (this.gridView1.DataRowCount == 0)
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
         
            FormPremixFormulaDetail f = new FormPremixFormulaDetail();
            //SetFormPrivilege(f);
            f.ShowDialog();
            if (f.iError == 0)
            {
                (this.gridView1.DataSource as IBindingList).Add(f._GeneralPremix);
                RefreshIsActive(f._GeneralPremix);
            }
            RefreshButtons();
        }
        public override void EditItem()
        {
            _GeneralPremix = ((this.BindingContext[gridControl1.DataSource] as CurrencyManager).Current as GeneralPremix);
            FormPremixFormulaDetail f = new FormPremixFormulaDetail(_GeneralPremix,true);
            //SetFormPrivilege(f);
            f.ShowDialog();
            if (f.iError == 0)
            {
                foreach (GeneralPremix obj in (this.gridView1.DataSource as ListBase<GeneralPremix>))
                {
                    if (obj.FormulaCode == _GeneralPremix.FormulaCode)
                    {
                        obj.Description = _GeneralPremix.Description;
                        obj.IsActive = _GeneralPremix.IsActive;
                    }
                }
                this.gridControl1.RefreshDataSource();
            }
        }

        private void FormPremixFormula_Load(object sender, EventArgs e)
        {
            if (!this.AllowAddNew)
            {
                AddNewRow.Buttons[0].Visible = false;
            }
        }
       
    }
}