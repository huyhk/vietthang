using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.KCS;
using System.Windows.Forms;
using VNS.Common;

namespace VNS.ERP.GUI.KCS
{
    public partial class FormProductQualityStandards : FormEditBase
    {
        ProductQualityStandardsBLL obj = new ProductQualityStandardsBLL();
        public FormProductQualityStandards()
        {
            InitializeComponent();
            this.Business = obj;
            this.DataSource = obj.GetAll();
            if (!this.DesignMode)
            {
                this.repoChiTieu.DataSource = new TechnicalTestBLL().GetAll();
                this.repConditionType.DataSource = EnumDisplays.GetListenumKCSConditionType();
                this.repPercent.Mask.EditMask = ModuleKCS.CONFIG_TECH_PERCENTFORMAT;
              
                //lookUpFrequencyType.DataSource = EnumDisplays.GetListenumFrequencyType();
            }
        }

        private void FormProductQualityStandards_Load(object sender, EventArgs e)
        {
            this.gridControl1.DataSource = new ProductBLL().GetAll();
            //(dataSource as Product).
            this.gridControl1.RefreshDataSource();
            gridControl3.RefreshDataSource();
        }

        public override void RefreshButtons()
        {
            gridControl1.Enabled = this.EditMode == VNS.Windows.FormEditMode.VIEW;
            base.RefreshButtons();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CurrencyManager cr = this.BindingContext[this.gridControl1.DataSource] as CurrencyManager;
            this.ucProductQualityStandards1.ProductCode = (cr.Current as Product).ProductCode;
            this.DataSource = obj.GetByProductCode((cr.Current as Product).ProductCode);
        }

        private void gridView3_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column.FieldName != "ValueString")
                return;
            //if (e.RowHandle >= 0)
            //{
            object o = gridView3.GetRow(e.RowHandle);
            if (o == null)
                return;
            string techCode = (o as ProductQualityStandards).TechCode;
            TechnicalTest tt = (this.repoChiTieu.DataSource as ListBase<TechnicalTest>).Search("TechCode", techCode);
            if (tt != null)
            {
                if (tt.ResultType == enumResultTypeTechnicalTest.Decimal.ToString())
                {
                    //if (("ValueString").Contains(e.Column.FieldName))
                        e.RepositoryItem = this.repDecimal;
                }
                if (tt.ResultType == enumResultTypeTechnicalTest.Text.ToString())
                {
                //    if (("ValueString").Contains(e.Column.FieldName))
                        e.RepositoryItem = this.repText;
                }
                if (tt.ResultType == enumResultTypeTechnicalTest.Percent.ToString())
                {
                  //  if (("Result").Contains(e.Column.FieldName))
                        e.RepositoryItem = this.repPercent;
                }

            }
        }
    }
}