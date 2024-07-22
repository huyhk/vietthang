using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.ERP.Data;
using VNS.Common;
using VNS.Windows;

namespace VNS.ERP.GUI.UserControl
{
    public partial class DetailProductFormulaDetail : EditControlBase
    {
       public  DevExpress.XtraEditors.LookUpEdit lookupEditFormulaCode;
        object lstDataSourceProduct;
        object lstDataSourceItem;
        private string formulaCode;
        public DetailProductFormulaDetail()
        {
            InitializeComponent();
            //this.repositoryItemLookUpEdit4.Columns[0].
            this.repositoryItemLookUpEdit4.EditValueChanged += new EventHandler(repositoryItemLookUpEdit4_EditValueChanged);
        }
        public void SetDataSourceNull()
        {
            gridControl2.DataSource = null;
        }
        public void RefeshFormulaCode(string _FormulaCode)
        {
            formulaCode = _FormulaCode;
        }
        protected override void BindData()
        {
            if (dataSource != null)
            {
                //formulaCode = (dataSource as ProductFormulaDetail).FormulaCode;
                this.lookUpEditProductCode.EditValue = (dataSource as ProductFormulaDetail).ProductCode;
                if (this.lookUpEditProductCode.EditValue == null)
                {
                    this.lookUpEditProductCode.ItemIndex = 0;
                }
                chkIsActive.Checked = (dataSource as ProductFormulaDetail).IsActive;
                this.gridControl2.DataSource = (dataSource as ProductFormulaDetail).FormulaDetails;
            }
            //else
            //{
            //    this.gridControl2.DataSource = null;
            //}
            base.BindData();
        }
        protected override void AssignData()
        {
            if (dataSource == null) dataSource = new ProductFormulaDetail();
            (dataSource as ProductFormulaDetail).FormulaCode = formulaCode;
            (dataSource as ProductFormulaDetail).ProductCode = this.lookUpEditProductCode.EditValue.ToString();
            (dataSource as ProductFormulaDetail).FormulaDetails = (this.gridControl2.DataSource as ListBase<FormulaDetail>);
            (dataSource as ProductFormulaDetail).IsActive = chkIsActive.Checked;
            base.AssignData();
        }
        public void SetLookupEditDataSources()
        {
            lstDataSourceProduct = new ProductBLL().GetAll();
            lstDataSourceItem = new ItemBLL().GetAll();// .GetByGroup2ItemType((Int16)enumItemType.Material, (Int16)enumItemType.Premix);

            this.lookUpEditProductCode.Properties.DataSource = lstDataSourceProduct;
          
            this.colMaterialCode.Visible = true;
            this.repositoryItemLookUpEdit4.DataSource = lstDataSourceItem;
            this.repositoryItemLookUpEdit5.DataSource = lstDataSourceItem;
        }
        public void RefeshLookupEditProductCodeDataSource()
        { 
            this.lookUpEditProductCode.Properties.DataSource =new ProductBLL().GetAll();
        }
     
       
        void repositoryItemLookUpEdit4_EditValueChanged(object sender, EventArgs e)
        {
            string materialCode = (string)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("ItemCode");
            this.gridView2.SetRowCellValue(this.gridView2.FocusedRowHandle, this.colMaterialName, materialCode);
            //this.gridView2.RefreshRow(this.gridView2.FocusedRowHandle);
        }

        private void DetailProductFormulaDetail_Resize(object sender, EventArgs e)
        {
            gridControl2.Width = this.Width-10;
        }
        public void SetAddNewStatus(object lstProductCodeExists)
        {
            Product pr;

            string productCodeSearch;
            int count = (lstProductCodeExists as ListBase<ProductFormulaDetail>).Count-1;
            for (int i = 0; i <= count - 1; i++)
            { 

                productCodeSearch = (lstProductCodeExists as ListBase<ProductFormulaDetail>)[i].ProductCode;
                if ((this.lookUpEditProductCode.Properties.DataSource as ListBase<Product>).Count > 0)
                {
                    pr = (this.lookUpEditProductCode.Properties.DataSource as ListBase<Product>).Search("ProductCode", productCodeSearch);
                    if (pr != null)
                    {
                        (this.lookUpEditProductCode.Properties.DataSource as ListBase<Product>).Remove(pr);
                    }
                }
            }
            try
            {
                this.lookUpEditProductCode.ItemIndex = 0;
            }
            catch 
            {
                this.lookUpEditProductCode.ItemIndex = -1;
            }
        }
       
        protected override int ValidateData()
        {
            int count = (this.gridControl2.DataSource as ListBase<FormulaDetail>).Count;
            if ((this.lookUpEditProductCode.Properties.DataSource as ListBase<Product>).Count == 0)
            {
                lookUpEditProductCode.Focus();
                return -1;
            }
            if (count <= 0) return -2;

            for (int i = 0; i <= count - 1; i++)
            {
                if (((this.gridControl2.DataSource as ListBase<FormulaDetail>)[i].Weight < 0)) return -3;
                if (((this.gridControl2.DataSource as ListBase<FormulaDetail>)[i].MaterialCode == null)) return -4;
            }
            //foreach (FormulaDetail fd in (this.gridControl2.DataSource as ListBase<FormulaDetail>))
            //{
            //    FormulaDetail fd1 = (this.gridControl2.DataSource as ListBase<FormulaDetail>).Search("MaterialCode", fd.MaterialCode);
            //    if (fd1 != null && fd1 != fd)
            //    {
            //        return -4;
            //    }
            //}
            return base.ValidateData();
        }
        //public void BeginUpdate()
        //{
        //    gridView2.OptionsView.BeginUpdate();
        //}

        //public void EndUpdate()
        //{
        //    gridView2.OptionsView.EndUpdate();
        //}
        //public void CancelUpdate()
        //{
        //    this.Cancel();
        //}

        public override void RefreshControl()
        {
            colMaterialCode.OptionsColumn.ReadOnly = (this.editMode == FormEditMode.VIEW);
            colWeight.OptionsColumn.ReadOnly = (this.editMode == FormEditMode.VIEW);
            lookupEditFormulaCode.Enabled = (this.editMode == FormEditMode.VIEW);
            lookUpEditProductCode.Enabled = (this.editMode == FormEditMode.ADD);
            chkIsActive.Enabled = this.EditMode != FormEditMode.VIEW;
            if (this.editMode != FormEditMode.ADD)
            {
                this.lookUpEditProductCode.Properties.DataSource = new ProductBLL().GetAll();
                lookUpEditProductCode.Focus();
            }
            if (this.editMode == FormEditMode.VIEW)
            {
                this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            }
            else
            {
                this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            }
            if (this.DataSource == null)
            {
                //this.lookUpEditProductCode.EditValue = (dataSource as ProductFormulaDetail).ProductCode;
                //if (this.lookUpEditProductCode.EditValue == null)
                //{
                //    this.lookUpEditProductCode.ItemIndex = 0;
                //}
                this.gridControl2.DataSource = null;
            }
            base.RefreshControl();
        }    
        #region Method
        
        #endregion
    }
}
