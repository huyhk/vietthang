using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Accounting;
using VNS.Windows.Controls;
using VNS.Windows;
using VNS.Common;
using DevExpress.Utils;
using VNS.ERP.GUI.Forms.Manufactures;
using VNS.ERP.Data.Premixs;

namespace VNS.ERP.GUI
{
    public partial class UCProducCostFormula : EditControlBase
    {
        public string PeriodCode;
        private ListBase<Product> lstProduct;
        private ListBase<ProductCost> lstProductCost;
        public UCProducCostFormula()
        {
            InitializeComponent();
        }
        protected override void InitDataObject()
        {
            if (!this.DesignMode)
            {
                this.ItemLookMaterialCode.DataSource = (new ItemBLL()).GetListMaterial();
                lstProduct = (new ProductBLL()).GetAll();
                this.cboProduct.Properties.DataSource = lstProduct;

                this.lokWrappingCode.Properties.DataSource = new ProductWeightBLL().GetAll();
            }
        }
        protected override void BindData()
        {
            //lstProduct = (new ProductBLL()).GetAll();// GetbyItemtype((int)enumItemType.Product);
            if (this.DataSource == null)
                this.DataSource = new ProductCost();
            if ((this.DataSource as ProductCost).Details == null && this.EditMode == FormEditMode.ADD)
            {
                (this.DataSource as ProductCost).Details = new ListBase<ProductCostFormula>();
            }
            else
            {
 
            }
            //this.cboProduct.Properties.DataSource = lstProduct;
            this.gridControl1.DataSource = (this.DataSource as ProductCost).Details;
            //if (this.EditMode == FormEditMode.ADD)
            //{
            //    foreach (ProductCost pr in lstProductCost)
            //    {
            //        lstProduct.Remove(lstProduct.Search("ProductCode", pr.ProductCode));
            //    }
            //}
            this.cboProduct.EditValue = (this.DataSource as ProductCost).ProductCode;
            this.lokWrappingCode.EditValue = (this.DataSource as ProductCost).WrappingCode;
        }
        protected override int ValidateData()
        {
            if (this.cboProduct.ItemIndex == -1)
            {
                this.cboProduct.Focus();
                return -2;
            }
            return 0;
        }
        protected override void AssignData()
        {
            (this.DataSource as ProductCost).ProductCode = this.cboProduct.EditValue.ToString();
            (this.DataSource as ProductCost).WrappingCode = this.lokWrappingCode.EditValue.ToString();
            (this.DataSource as ProductCost).PeriodCode = PeriodCode;
            foreach (ProductCostFormula pr in (this.DataSource as ProductCost).Details)
            {
                (this.DataSource as ProductCost).TotalCostAmount += pr.CostAmount;
            }
        }
     
        public override void RefreshControl()
        {
            if (this.EditMode == FormEditMode.ADD)
            {
                this.cboProduct.Properties.ReadOnly = false;
                this.lokWrappingCode.Properties.ReadOnly = false;
                this.gridView1.OptionsBehavior.Editable = true;
                this.btnGetFormulaFromManu.Enabled =
                    this.btnSelectFormulaCode.Enabled = true;
            }
            else if (this.EditMode == FormEditMode.EDIT)
            {
                this.cboProduct.Properties.ReadOnly = true;
                this.lokWrappingCode.Properties.ReadOnly = true;
                this.gridView1.OptionsBehavior.Editable = true;
                this.btnGetFormulaFromManu.Enabled =
                    this.btnSelectFormulaCode.Enabled = true;
            }
            else
            {
                this.cboProduct.Properties.ReadOnly = true;
                this.lokWrappingCode.Properties.ReadOnly = true;
                this.gridView1.OptionsBehavior.Editable = false;
                this.btnGetFormulaFromManu.Enabled =
                    this.btnSelectFormulaCode.Enabled = false;
            }
            base.RefreshControl();
        }
        public void RefreshGridControl()
        {
            this.cboProduct.EditValue = "";
            this.gridControl1.DataSource = null;
        }

        public void SetDataSourceCboProduct(ListBase<ProductCost> lst)
        {
             lstProductCost = lst;
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.gridView1.RowCount > 0 && this.gridView1.OptionsBehavior.Editable == true)
            {
                if (e.KeyCode == Keys.Delete)
                    this.gridView1.DeleteRow(this.gridView1.FocusedRowHandle);
            }
        }

        private void btnGetFormulaFromManu_Click(object sender, EventArgs e)
        {
            Period p = new PeriodBLL().GetAll().Search("PeriodCode", PeriodCode);
            DataSet ds = new VNS.ERP.Data.GD.GDReportBLL().ReportGD_ThongkeNLSX(p.StartDate, p.EndDate, "");
            string productCode = this.cboProduct.EditValue.ToString();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (row["ProductCode"].ToString() == productCode)
                {
                    decimal productQuantity = (decimal)row["Quantity"];
                    ProductCost pc = (this.DataSource as ProductCost);
                    pc.Details.Clear();
                    foreach (DataRow rowD in row.GetChildRows("ThongkeNLSX"))
                    {
                        ProductCostFormula pcf = new ProductCostFormula();
                        pcf.MaterialCode = rowD["ItemCode"].ToString();
                        pcf.Quantity = Math.Round(((decimal)rowD["Quantity"] * 1000 / productQuantity), 2, MidpointRounding.AwayFromZero);
                        pc.Details.Add(pcf);
                    }
                    break;
                }
            }
        }

        private void btnSelectFormulaCode_Click(object sender, EventArgs e)
        {
            FormListProductFormula f = new FormListProductFormula();
            f.isSearch = true;
            f.ShowDialog();
            ProductFormula2 pf = f.SelectedItem as ProductFormula2;
            if (pf != null)
            {
                ProductCost pc = (this.DataSource as ProductCost);
                pc.Details.Clear();

                ListBase<Item> lstPremix = new ItemBLL().GetbyItemtypeAll((int)enumItemType.Premix);
                ProductCostFormula pcf1 = null;
                bool flag = false;
                foreach (FormulaDetail pfd in pf.FormulaDetails)
                {
                    ProductCostFormula pcf = new ProductCostFormula();
                    pcf.MaterialCode = pfd.MaterialCode;
                    pcf.Quantity = pfd.Weight;


                    if (pcf1 == null)
                        if (lstPremix.Search("ItemCode", pcf.MaterialCode) != null)
                        {
                            pcf1 = pcf;
                            flag = true;
                        }

                    if (!flag)
                        pc.Details.Add(pcf);
                    else
                        flag = false;

                    
                }

                Period p = new PeriodBLL().GetAll().Search("PeriodCode", PeriodCode);
                ListBase<PremixFormulaDetail> lstFD = new PremixFormulaDetailBLL().GetLast(pcf1.MaterialCode, p.EndDate);
                foreach (PremixFormulaDetail fd in lstFD)
                {
                    ProductCostFormula pcf = new ProductCostFormula();
                    pcf.MaterialCode = fd.MaterialCode;
                    pcf.Quantity = Math.Round(fd.Weight * pcf1.Quantity / 1000, 2);

                    pc.Details.Add(pcf);
                }

            }
        }
    }
}
