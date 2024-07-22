using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.KCS;
using VNS.ERP.Data.Manufactures;
using VNS.Windows;
using VNS.Common;

namespace VNS.ERP.GUI.KCS
{
    public partial class FormProductEncryptCode : VNS.Windows.Forms.FormBase
    {
        private DateTime transactionDate = DateTime.Today;
        private ProductTestEncryptCodeBLL bll = new ProductTestEncryptCodeBLL();
        ProductTestEncryptCode encryptCodeEdit = null;
        FormEditMode mode = FormEditMode.ADD;
        private string stockName = string.Empty;
        public string StockName
        {
            get { return stockName; }
            set { stockName = value; }
        }
        public FormProductEncryptCode()
        {
            InitializeComponent();
            lookUpEditStock.Properties.DataSource = new StockBLL().GetAll();
            lookUpEditProductCode.Properties.DataSource = new ProductBLL().GetAll();
            ListBase<ProductFormula2> lst = new ProductFormulaBLL2().GetAll();
            lst.Insert(0,new ProductFormula2());
            lookUpEditFormula.Properties.DataSource = new ProductFormulaBLL2().GetAll();
            lookUpEditSizeCode.Properties.DataSource = new ProductSizeBLL().GetAll();
        }
        public FormProductEncryptCode(FormEditMode mode, ref ProductTestEncryptCode encryptCodeEdit)
        {
            InitializeComponent();
            lookUpEditStock.Properties.DataSource = new StockBLL().GetAll();
            lookUpEditProductCode.Properties.DataSource = new ProductBLL().GetAll();
            ListBase<ProductFormula2> lst = new ProductFormulaBLL2().GetAll();
            lst.Insert(0, new ProductFormula2());
            lookUpEditFormula.Properties.DataSource = lst;
            lookUpEditSizeCode.Properties.DataSource = new ProductSizeBLL().GetAll();
            this.mode = mode;
            this.encryptCodeEdit = encryptCodeEdit;
            lookUpEditStock.EditValue = this.encryptCodeEdit.StockCode;
            dateEdit1.DateTime = this.encryptCodeEdit.ManuDate;
            txtShift.Value = Convert.ToDecimal(this.encryptCodeEdit.Shift);
            lookUpEditProductCode.EditValue = this.encryptCodeEdit.ProductCode;
            lookUpEditSizeCode.EditValue = this.encryptCodeEdit.SizeCode;
            lookUpEditFormula.EditValue = this.encryptCodeEdit.FormulaCode;
            txtLot.Text = this.encryptCodeEdit.Lot;
            if (mode == FormEditMode.EDIT)
            {
                txtEncryptCode.Text = this.encryptCodeEdit.ItemEncryptCode;
                txtEncryptCode.Properties.ReadOnly = false;
                txtDescription.Text = this.encryptCodeEdit.Description;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtEncryptCode.Text = txtEncryptCode.Text.Trim();
            txtLot.Text = txtLot.Text.ToString();
            int iError = 0;
            if (txtEncryptCode.Text == string.Empty)
            {
                MessageBox.Show(this.GetTextMessage("VALIDATE-1", "Bạn chưa nhập mã mẫu!"));
                txtEncryptCode.Focus();
                return;
            }
            if (lookUpEditStock.EditValue == null || lookUpEditStock.EditValue.ToString() == string.Empty)
            {
                MessageBox.Show(this.GetTextMessage("VALIDATE-2", "Bạn chưa chọn nhà máy!"));
                lookUpEditStock.Focus();
                return;
            }
            else
            {
                this.StockName = this.lookUpEditStock.GetColumnValue("StockName").ToString();
            }
            if (lookUpEditProductCode.EditValue == null || lookUpEditProductCode.EditValue.ToString() == string.Empty)
            {
                MessageBox.Show(this.GetTextMessage("VALIDATE-3", "Bạn chưa chọn thành phẩm!"));
                lookUpEditProductCode.Focus();
                return;
            }
            if (lookUpEditSizeCode.EditValue == null || lookUpEditSizeCode.EditValue.ToString() == string.Empty)
            {
                MessageBox.Show(this.GetTextMessage("VALIDATE-4", "Bạn chưa chọn kích thước!"));
                lookUpEditSizeCode.Focus();
                return;
            }
            string formulaCode = string.Empty;
            if (lookUpEditFormula.EditValue != null)
            {
                formulaCode = lookUpEditFormula.EditValue.ToString();
            }
            txtDescription.Text = txtDescription.Text.Trim();
            if (this.mode == FormEditMode.ADD)
            {
                ProductTestEncryptCode ptec = new ProductTestEncryptCode();
                ptec.StockCode = lookUpEditStock.EditValue.ToString();
                ptec.ManuDate = dateEdit1.DateTime;
                ptec.Shift = Convert.ToByte(txtShift.Value);
                ptec.ProductCode = this.lookUpEditProductCode.EditValue.ToString();
                ptec.SizeCode = lookUpEditSizeCode.EditValue.ToString();
                ptec.FormulaCode = formulaCode;
                ptec.Lot = txtLot.Text;
                ptec.ItemEncryptCode = txtEncryptCode.Text;
                ptec.Description = txtDescription.Text;
                ptec.UserCreated = Contexts.CurrentUser.LoginName;
                iError = this.bll.Insert(ptec);
                if (iError != 0)
                {
                    string idMsg = "INSERT" + iError.ToString();
                    MessageBox.Show(this.GetTextMessage(idMsg, "Lưu không thành công!"));
                }
            }
            if (this.mode == FormEditMode.EDIT)
            {
                ProductTestEncryptCode ptec = new ProductTestEncryptCode();
                ptec.StockCode = lookUpEditStock.EditValue.ToString();
                ptec.ManuDate = dateEdit1.DateTime;
                ptec.Shift = Convert.ToByte(txtShift.Value);
                ptec.ProductCode = this.lookUpEditProductCode.EditValue.ToString();
                ptec.SizeCode = lookUpEditSizeCode.EditValue.ToString();
                ptec.FormulaCode = formulaCode;
                ptec.Lot = txtLot.Text;
                ptec.ItemEncryptCode = txtEncryptCode.Text;
                ptec.Description = txtDescription.Text;
                ptec.UserUpdated = Contexts.CurrentUser.LoginName;
                iError = this.bll.Update(ptec, this.encryptCodeEdit.ItemEncryptCode);
                if (iError != 0)
                {
                    string idMsg = "UPDATE" + iError.ToString();
                    MessageBox.Show(this.GetTextMessage(idMsg, "Lưu không thành công!"));
                }
            }
            if (iError == 0)
            {
                this.encryptCodeEdit.StockCode = lookUpEditStock.EditValue.ToString();
                this.encryptCodeEdit.ManuDate = dateEdit1.DateTime;
                this.encryptCodeEdit.Shift = Convert.ToByte(txtShift.Value);
                this.encryptCodeEdit.ProductCode = lookUpEditProductCode.EditValue.ToString();
                this.encryptCodeEdit.SizeCode = lookUpEditSizeCode.EditValue.ToString();
                this.encryptCodeEdit.FormulaCode = formulaCode;
                this.encryptCodeEdit.Lot = txtLot.Text;
                this.encryptCodeEdit.ItemEncryptCode = txtEncryptCode.Text;
                this.encryptCodeEdit.Description = txtDescription.Text;

                this.DialogResult = DialogResult.Yes;
            }
        }

        private void FormProductEncryptCode_Load(object sender, EventArgs e)
        {

        }

        private void txtEncryptCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            this.BuildItemEncryptCode();
        }
        private void BuildItemEncryptCode()
        {
            //if (lookUpEditStock.EditValue == null || lookUpEditStock.EditValue.ToString() == string.Empty)
            //{
            //    MessageBox.Show(this.GetTextMessage("VALIDATE-2", "Bạn chưa chọn nhà máy!"));
            //    lookUpEditStock.Focus();
            //    return;
            //}
            //else
            //{
            //    this.StockName = this.lookUpEditStock.GetColumnValue("StockName").ToString();
            //}
            if (lookUpEditProductCode.EditValue == null || lookUpEditProductCode.EditValue.ToString() == string.Empty)
            {
                MessageBox.Show(this.GetTextMessage("VALIDATE-3", "Bạn chưa chọn thành phẩm!"));
                lookUpEditProductCode.Focus();
                return;
            }
            if (lookUpEditSizeCode.EditValue == null || lookUpEditSizeCode.EditValue.ToString() == string.Empty)
            {
                MessageBox.Show(this.GetTextMessage("VALIDATE-4", "Bạn chưa chọn kích thước!"));
                lookUpEditSizeCode.Focus();
                return;
            }
            this.transactionDate = dateEdit1.DateTime;
            string productCode = lookUpEditProductCode.EditValue.ToString();
            string sizeCode = lookUpEditSizeCode.EditValue.ToString();
            string d = this.transactionDate.Day.ToString();
            string m = this.transactionDate.Month.ToString();
            string y = this.transactionDate.Year.ToString();
            if (d.Length == 1) d = "0" + d;
            if (m.Length == 1) m = "0" + m;
            txtLot.Text = txtLot.Text.Trim();
            txtEncryptCode.Text = productCode + sizeCode + "-" + d + m + y.Substring(2) + "-" + txtLot.Text; ;
        }
    }
}

