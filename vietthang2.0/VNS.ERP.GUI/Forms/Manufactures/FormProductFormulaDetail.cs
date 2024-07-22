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
using System.Collections;
using VNS.Windows;


namespace VNS.ERP.GUI
{
    public partial class FormProductFormulaDetail : FormEditBase
    {
        object lstDataSourceProduct;
       
        public FormProductFormulaDetail()
        {
            InitializeComponent();
            this.gridControlBase = gridControl1;
            this.editControl = usrDetailProductFormulaDetail1;
            this.usrDetailProductFormulaDetail1.lookupEditFormulaCode = this.lookUpEditFormulaCode;

            usrDetailProductFormulaDetail1.SetLookupEditDataSources();
           

            lstDataSourceProduct = new ProductBLL().GetAll();
           

            this.Business = new ProductFormulaDetailBLL();
            this.repositoryItemLookUpEdit1.DataSource = lstDataSourceProduct;
            this.repositoryItemLookUpEdit2.DataSource = lstDataSourceProduct;
            this.repositoryItemLookUpEdit3.DataSource = lstDataSourceProduct;
           
        }
        public void SetFormulaCode(string _fc)
        {
            lookUpEditFormulaCode.EditValue = _fc;
            
        }
        public void SetDataSourceFormula(object obj)
        {
            lookUpEditFormulaCode.Properties.DataSource = obj;
        }
     
            

        private void lookUpEditFormulaCode_EditValueChanged(object sender, EventArgs e)
        {
            ProductFormula fd = (lookUpEditFormulaCode.Properties.DataSource as ListBase<ProductFormula>).Search("FormulaCode", lookUpEditFormulaCode.EditValue);
            this.DataSource = fd.ProductFormulaDetails;
            this.usrDetailProductFormulaDetail1.RefeshFormulaCode(lookUpEditFormulaCode.EditValue.ToString());
            if ((this.DataSource as ListBase<ProductFormulaDetail>).Count==0) this.usrDetailProductFormulaDetail1.SetDataSourceNull();
        }
     
        private void gridView1_CustomFilterDialog(object sender, DevExpress.XtraGrid.Views.Grid.CustomFilterDialogEventArgs e)
        {
           
        }

        private void gridControl1_DefaultViewChanged(object sender, EventArgs e)
        {
            
        }

        private void gridControl1_FocusedViewChanged(object sender, DevExpress.XtraGrid.ViewFocusEventArgs e)
        {
           
        }

        private void gridControl1_RegionChanged(object sender, EventArgs e)
        {
            
        }

        private void gridControl1_ViewRemoved(object sender, DevExpress.XtraGrid.ViewOperationEventArgs e)
        {
            //MessageBox.Show("abc");
        }

        private void gridControl1_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            
        }

        private void gridControl1_PaddingChanged(object sender, EventArgs e)
        {
            
        }
       

        private void gridControl1_BindingContextChanged(object sender, EventArgs e)
        {
            
        }

    

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            
        }

        private void gridView1_ShowFilterPopupListBox(object sender, DevExpress.XtraGrid.Views.Grid.FilterPopupListBoxEventArgs e)
        {
            //MessageBox.Show("abc");
        }
        FormulaDetail[] arrFormulaDetail;

        public override void AddNewItem()
        {
            base.AddNewItem();
            this.usrDetailProductFormulaDetail1.SetAddNewStatus(this.dataSource);
            int count = (this.currentItem as ProductFormulaDetail).FormulaDetails.Count;
            arrFormulaDetail = new FormulaDetail[count];
            //this.usrDetailProductFormulaDetail1.BeginUpdate();
            //(this.currentItem as ProductFormulaDetail).FormulaDetails.CopyTo(arrFormulaDetail,0);
            //for (int i = 0; i < count; i++)
            //{
            //    arrFormulaDetail[i] = (FormulaDetail)(this.currentItem as ProductFormulaDetail).FormulaDetails[i].Clone();
            //}
            //this.usrDetailProductFormulaDetail1.BeginUpdate();
            //(this.currentItem as ProductFormulaDetail).FormulaDetails.begin
            //this.lookUpEditFormulaCode.Enabled = false;
            //this.gridControl1.Enabled = false;
        }
        
        //ListBase<FormulaDetail> lstFormulaDetail;
        public override void EditItem()
        {
            base.EditItem();
            //int count = (this.currentItem as ProductFormulaDetail).FormulaDetails.Count;
            //arrFormulaDetail = new FormulaDetail[count];
            //this.usrDetailProductFormulaDetail1.BeginUpdate();
            //(this.currentItem as ProductFormulaDetail).FormulaDetails.CopyTo(arrFormulaDetail,0);
            //for (int i = 0; i < count; i++)
            //{
            //    arrFormulaDetail[i]=(FormulaDetail)(this.currentItem as ProductFormulaDetail).FormulaDetails[i].Clone();
            //}
            //CurrencyManager

        }
     
        public override void CancelItem()
        {
            //(this.currentItem as ProductFormulaDetail).FormulaDetails.Clear();
            //(this.currentItem as ProductFormulaDetail).FormulaDetails.re
            base.CancelItem();
            this.lookUpEditFormulaCode.Enabled = true;


            //foreach (FormulaDetail fd in arrFormulaDetail)
            //{
            //    (this.currentItem as ProductFormulaDetail).FormulaDetails.Add(fd);
            //}
            //(this.currentItem as ProductFormulaDetail).FormulaDetails = null;
            //(this.currentItem as ProductFormulaDetail).FormulaDetails = lstFormulaDetail;
            
            //this.usrDetailProductFormulaDetail1.CancelUpdate();
        }

        private void FormProductFormulaDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.EditMode == FormEditMode.ADD)
            {
                base.CancelItem();
            }
        }
    }
}