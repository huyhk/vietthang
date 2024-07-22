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
    public partial class FormMaterialFormulaDetail : FormEditBase
    {
        ListBase<MaterialFormularDetail> lstMaterail = new ListBase<MaterialFormularDetail>();
        public GeneralMaterial _GeneralMaterial = new  GeneralMaterial();
        public int iError = -1;
        bool IsAdd = false;
        bool IsEdit = false;
        public FormMaterialFormulaDetail(GeneralMaterial M)
        {
            InitializeComponent();
            _GeneralMaterial = M;
            IsAdd = true;
            this.gridControlMaterial.DataSource = new MaterialFormularDetailBLL().GetDetail("", "");
            lookUpMaterial.Properties.DataSource = new ItemBLL().GetbyItemtype((int)enumItemType.Material);
            btnSaveClose.Enabled = true;
         
        }
        public FormMaterialFormulaDetail(GeneralMaterial M, bool _IsEdit)
        {

            InitializeComponent();
            txtFormulaCode.Properties.ReadOnly=true;
            txtFormulaCode.BackColor=Color.Azure;
            txtFormulaCode.Text = M.FormulaCode;
            txtDescription.Text = M.Description;
            _GeneralMaterial = M;
            IsEdit = _IsEdit;
            btnSaveClose.Enabled = true;
           
        
        }
        public override void RefreshButtons()
        {
            base.RefreshButtons();
            this.btnSaveClose.Enabled = true;
        }
        private void GetListMaterial()
        {
            lstMaterail = (this.gridControlMaterial.DataSource as ListBase<MaterialFormularDetail>);
            foreach (MaterialFormularDetail M in lstMaterail)
            {
                M.FormulaCode = txtFormulaCode.Text;
                M.MaterialPCode = this.lookUpMaterial.EditValue.ToString();
            }
        }
        protected override bool SaveData()
        {

            ErrorMessageType messageType = ErrorMessageType.VALIDATE;
            iError = ValidateData2();
            if (IsAdd)
            {
                MaterialFormular ItemMaterialFormula = new  MaterialFormular();
                ItemMaterialFormula = new MaterialFormularBLL().GetFormulaCode(txtFormulaCode.Text);
                if (ItemMaterialFormula.FormulaCode != null) iError = -5;
            }
            if (iError != 0)
            {
                OnError(iError, messageType);
                return false;
            }
            _GeneralMaterial.FormulaCode = txtFormulaCode.Text;
            _GeneralMaterial.Description = txtDescription.Text;
            _GeneralMaterial.MaterialPCode = this.lookUpMaterial.EditValue.ToString();
            GetListMaterial();
            messageType = ErrorMessageType.INSERT;
            iError = new MaterialFormularDetailBLL().Insert(lstMaterail, _GeneralMaterial);
            if (iError != 0)
            {
                OnError(iError, messageType);
                return false;
            }
            return base.SaveData();
        }
        private int ValidateData2()
        {
            if (txtFormulaCode.Text == "") return -1;
            if (this.lookUpMaterial.EditValue == null) return -2;
            ListBase<MaterialFormularDetail> lst = (ListBase<MaterialFormularDetail>)this.gridControlMaterial.DataSource;
            foreach (MaterialFormularDetail obj in lst)
            {
                if (obj.Weight == 0) return -3;
                if (obj.MaterialCode == null) return -4;
            }

            return 0;
        }
      
        private void gridControlMaterial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Delete) this.gridViewMaterial.DeleteRow(this.gridViewMaterial.FocusedRowHandle);
        }

        private void FormMaterialFormulaDetail_Load(object sender, EventArgs e)
        {
            LookupItem.DataSource = new ItemBLL().GetbyItemtype((int)enumItemType.Material);
            btnSaveClose.Enabled = true;
            this.navigatorFrmEditBase.Visible = false;
            if (IsEdit)
            {
                this.gridControlMaterial.DataSource = new MaterialFormularDetailBLL().GetDetail(_GeneralMaterial.FormulaCode, _GeneralMaterial.MaterialPCode);
                lookUpMaterial.EditValue = _GeneralMaterial.MaterialPCode;
                this.lookUpMaterial.Properties.ReadOnly = true;
                this.lookUpMaterial.BackColor = Color.Azure;
                this.lookUpMaterial.Properties.DataSource = new ItemBLL().GetbyItemtype((int)enumItemType.Material);
            }
            else
            {
                if (!IsAdd)
                {
                    txtDescription.Properties.ReadOnly = true;
                    txtDescription.BackColor = Color.Azure;
                    this.lookUpMaterial.Properties.DataSource = new ItemBLL().GetMatrialCodeExcept((int)enumItemType.Material, _GeneralMaterial.FormulaCode);
                }
                else
                    txtFormulaCode.Focus();
                this.gridControlMaterial.DataSource = new MaterialFormularDetailBLL().GetDetail("", "");
                this.lookUpMaterial.ItemIndex = 0;
            }
        }

        private void FormMaterialFormulaDetail_Shown(object sender, EventArgs e)
        {
            if (IsAdd) txtFormulaCode.Focus();
            if (IsEdit) txtDescription.Focus();
            if (!IsEdit && !IsAdd) lookUpMaterial.Focus();
        }

       

        
    }
}