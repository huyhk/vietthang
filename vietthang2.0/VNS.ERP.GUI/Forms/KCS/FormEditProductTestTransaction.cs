using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.KCS;
using VNS.ERP.GUI;
namespace VNS.ERP.GUI.KCS
{
    public partial class FormEditProductTestTransaction : VNS.Windows.Forms.FormEditBase
    {
        ProductTestTransactionBLL bll = new ProductTestTransactionBLL();
        private string stockCode;
        private enumKCSDepartment department = enumKCSDepartment.KCS;
        public enumKCSDepartment Department
        {
            get { return department; }
            set
            {
                department = value;
                this.ucProductTestTransaction1.Department = value;
            }
        }
        public FormEditProductTestTransaction()
        {
            InitializeComponent();
        }
        public FormEditProductTestTransaction(string stockCode, string textForm)
        {
            InitializeComponent();
            this.Text = textForm;
            this.stockCode = stockCode;
            this.Business = this.bll;
        }
        public FormEditProductTestTransaction(string stockCode, string textForm, enumKCSDepartment department)
        {
            InitializeComponent();
            this.Text = textForm;
            this.stockCode = stockCode;
            this.Department = department;
            this.Business = this.bll;
            
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.ucProductTestTransaction1.StockCode = this.stockCode;
            if (this.Department == enumKCSDepartment.PTN)
            {
                this.btnAdd.Visible = false;
                this.btnEdit.Visible = false;
                this.btnRemove.Visible = false;
                this.btnSave.Visible = false;
                this.btnSaveClose.Visible = false;
                this.btnSaveNew.Visible = false;
            }
        }

        private void btnViewResult_Click(object sender, EventArgs e)
        {
            FormMaterialTestRequestResult f = new FormMaterialTestRequestResult((this.currentItem as ProductTestTransaction).TestTransactionID, FormMaterialTestRequestResult.RequestType.ProductLocal);
            f.ShowDialog();
        }
        public override void RefreshButtons()
        {
            base.RefreshButtons();

            this.btnViewResult.Enabled = (this.EditMode == VNS.Windows.FormEditMode.VIEW);
        }
    }
}

