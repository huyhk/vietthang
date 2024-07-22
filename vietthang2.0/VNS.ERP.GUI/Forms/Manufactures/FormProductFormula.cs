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
using VNS.Windows;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class FormProductFormula :VNS.Windows.Forms.FormEditBase
    {
        //FormulaDetailBLL objFormulaDetailBLL = new FormulaDetailBLL();
        ProductFormulaBLL objProductFormulaBLL = new ProductFormulaBLL();
        public FormProductFormula()
        {
            InitializeComponent();
           
          
            this.editControl = usrDetailProductFormula1;
            //this.usrDetailFormula.dataSourceGridControl1 = objFormulaDetailBLL.GetProductByFormulaCode("0001");
            this.gridControlBase = gridControl1;
            this.DataSource = objProductFormulaBLL.GetAll();
            this.gridControlBase.DataSource = this.dataSource;
            this.Business = objProductFormulaBLL;
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
           
            if (this.EditMode == FormEditMode.VIEW)
            {
                try
                {
                    FormProductFormulaDetail f = new FormProductFormulaDetail();
                    CurrencyManager cr = this.BindingContext[this.gridControlBase.DataSource] as CurrencyManager;
                    f.SetDataSourceFormula(this.DataSource);
                    f.SetFormulaCode((cr.Current as ProductFormula).FormulaCode);
                    SetFormPrivilege(f);
                    this.ShowChildForm(f);

                }
                catch (Exception)
                {
                   
                    string messageType, message;
                    message = "Error";
                    messageType = "ErrorClickbtnDetail-2";
                    MessageBox.Show(this.GetTextMessage(messageType, message));
                }
               
            }
            else
            {
                string messageType, message;
                message = "Error";
                messageType = "ErrorClickbtnDetail-1";
                MessageBox.Show(this.GetTextMessage(messageType, message));
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }      
    }
}