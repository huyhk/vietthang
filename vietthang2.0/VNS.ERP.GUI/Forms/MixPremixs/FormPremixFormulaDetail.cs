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
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class FormPremixFormulaDetail : FormEditBase
    {
        ListBase<PremixFormulaDetail> lstPremix = new ListBase<PremixFormulaDetail>();
        public  GeneralPremix _GeneralPremix = new GeneralPremix();
        public  int iError=-1;
        private bool IsEdit = false;
        private bool IsAdd=false;
        public FormPremixFormulaDetail()
        {
            //_GeneralPremix = g;
            InitializeComponent();
            IsAdd = true;
            this.gridControlPremix.DataSource = new  PremixFormulaDetailBLL().GetDetail("","");
            lookUpPrimix.Properties.DataSource = new ItemBLL().GetbyItemtype((int)enumItemType.Premix);
            txtFormulaCode.Focus();
        }
        public FormPremixFormulaDetail(GeneralPremix g, bool _IsEdit)
        {

            InitializeComponent();
            txtFormulaCode.Properties.ReadOnly=true;
            txtFormulaCode.BackColor=Color.Azure;
            _GeneralPremix = g;
            IsEdit = _IsEdit;
            txtFormulaCode.Text = _GeneralPremix.FormulaCode;
            txtDescription.Text = _GeneralPremix.Description;
            chkIsActive.Checked = _GeneralPremix.IsActive;
           
        }
        private void GetListPremix()
        {
            lstPremix = (this.gridViewPremix.DataSource as ListBase<PremixFormulaDetail>);
            foreach (PremixFormulaDetail p in lstPremix)
            {
                p.FormulaCode = txtFormulaCode.Text;
                p.PremixCode = lookUpPrimix.EditValue.ToString();
            }
        }
        protected override bool SaveData()
        {
            
            ErrorMessageType messageType = ErrorMessageType.VALIDATE;
            iError = ValidateData2();
            if (IsAdd)
            {
                PremixFormula ItemPremixFormula = new PremixFormula();
                ItemPremixFormula = new PremixFormulaBLL().GetFormulaCode(txtFormulaCode.Text);
                if (ItemPremixFormula.FormulaCode != null) iError = -5;
            }
            if (iError != 0)
            {
                OnError(iError, messageType);
                return false;
            }
            _GeneralPremix.FormulaCode = txtFormulaCode.Text;
            _GeneralPremix.Description = txtDescription.Text;
            _GeneralPremix.PremixCode = lookUpPrimix.EditValue.ToString();
            _GeneralPremix.IsActive = chkIsActive.Checked;
            GetListPremix();
            messageType = ErrorMessageType.INSERT;
             iError = new PremixFormulaDetailBLL().Insert(lstPremix, _GeneralPremix);
             if (iError != 0 )
            {
                OnError(iError, messageType);
                return false;
            }
            return base.SaveData();
        }
        

       
        private int ValidateData2()
        {
            if (txtFormulaCode.Text == String.Empty)
            {
                txtFormulaCode.Focus();
                return -1;
            }
            if (lookUpPrimix.EditValue == null) return -2;
            ListBase <PremixFormulaDetail> lst= (ListBase<PremixFormulaDetail>) this.gridViewPremix.DataSource ;
            foreach(PremixFormulaDetail obj in lst)
            {
                if (obj.Weight == 0) 
                    return -3;
                if (obj.MaterialCode == null) return -4;
            }
          
            return 0;
        }
        public override void RefreshButtons()
        {
            base.RefreshButtons();
          
            this.btnSaveClose.Enabled = true;
          
        }

        private void gridViewPremix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms .Keys.Delete)  this.gridViewPremix.DeleteRow(this.gridViewPremix.FocusedRowHandle);
        }

        private void FormPremixFormulaDetail_Load(object sender, EventArgs e)
        {
            LookupItem.DataSource = new ItemBLL().GetAll(); //GetbyItemtype((int)enumItemType.Material);
            this.btnSaveClose.Enabled = true;
            this.navigatorFrmEditBase.Visible = false;
            if (IsEdit)
            {
                this.gridControlPremix.DataSource = new PremixFormulaDetailBLL().GetDetail(_GeneralPremix.FormulaCode, _GeneralPremix.PremixCode);
                lookUpPrimix.EditValue = _GeneralPremix.PremixCode;
                this.lookUpPrimix.Properties.ReadOnly = true;
                this.lookUpPrimix.BackColor = Color.Azure;
                lookUpPrimix.Properties.DataSource = new ItemBLL().GetbyItemtype((int)enumItemType.Premix);
                txtDescription.Focus();
                
            }
            else
            {
                if (IsAdd == false)
                {
                    txtDescription.Properties.ReadOnly = true;
                    txtDescription.BackColor = Color.Azure;
                    this.lookUpPrimix.Properties.DataSource = new ItemBLL().GetPremixCodeExcept((int)enumItemType.Premix, _GeneralPremix.FormulaCode);
                    
                }
                
                this.gridControlPremix.DataSource = new PremixFormulaDetailBLL().GetDetail("", "");
                this.lookUpPrimix.ItemIndex = 0;
            }
            
        }

        private void FormPremixFormulaDetail_Shown(object sender, EventArgs e)
        {
            if (IsAdd) txtFormulaCode.Focus();
            if (IsEdit) txtDescription.Focus();
            if (!IsEdit && !IsAdd) lookUpPrimix.Focus();
        }

      
        
       
    }
}