using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.KCS;
using VNS.Common;

namespace VNS.ERP.GUI.KCS
{
    public partial class FormMaterialQualityStandards : FormEditBase
    {
        
        MaterialQualityStandardsBLL obj = new MaterialQualityStandardsBLL();
        public FormMaterialQualityStandards()
        {
            InitializeComponent();
            this.lookUpConditionType.DataSource = EnumDisplays.GetListenumKCSConditionType();
            lookUpConditionType.DisplayMember = "EnumText";
            lookUpConditionType.ValueMember = "EnumName";

            lookUpTechName.DataSource = new TechnicalTestBLL().GetAll();
            lookUpTechName.DisplayMember = "TechName";
            lookUpTechName.ValueMember = "TechCode";

            this.ucMaterialQualityStandards1.SetDss();
            this.Business = obj;
            this.DataSource = obj.GetAll();
            //this.colQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            //this.colQuantity.DisplayFormat.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT;
            repPercent.Mask.EditMask = ModuleKCS.CONFIG_TECH_PERCENTFORMAT;
        }

        public override void RefreshButtons()
        {
            gridControlItems.Enabled = this.EditMode == VNS.Windows.FormEditMode.VIEW;
            base.RefreshButtons();
        }
   
        private void FormMaterialQualityStandards_Load(object sender, EventArgs e)
        {
            gridControlItems.DataSource = new ItemBLL().GetbyItemtype((int)enumItemType.Material);
            gridControlItems.RefreshDataSource();
            this.gridControlMaterialQualityStandarts.RefreshDataSource();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CurrencyManager cr = this.BindingContext[this.gridControlItems.DataSource] as CurrencyManager;
            this.ucMaterialQualityStandards1.ItemCode = (cr.Current as Item).ItemCode;
            this.DataSource = obj.GetByItemCode((cr.Current as Item).ItemCode);
        }

        private void gridView2_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
          
            if (e.Column.FieldName != "ValueString")
                return;
            //if (e.RowHandle >= 0)
            //{
            object o = gridView2.GetRow(e.RowHandle);
            if (o == null)
                return;
            string techCode = (o as MaterialQualityStandards).TechCode;
            TechnicalTest tt = (this.lookUpTechName.DataSource as ListBase<TechnicalTest>).Search("TechCode", techCode);
            if (tt != null)
            {
                if (tt.ResultType == enumResultTypeTechnicalTest.Decimal.ToString())
                {
                  //  if (("ValueString").Contains(e.Column.FieldName))//kiểm tra xem có phải là  cot valuetstring ko
                        e.RepositoryItem = this.repDecimal;
                }
                if (tt.ResultType == enumResultTypeTechnicalTest.Text.ToString())
                {
                    //if (("ValueString").Contains(e.Column.FieldName))
                        e.RepositoryItem = this.repText;
                }
                if (tt.ResultType == enumResultTypeTechnicalTest.Percent.ToString())
                {
                 //   if (("Result").Contains(e.Column.FieldName))
                        e.RepositoryItem = this.repPercent;
                }

            }
        }

 
    }
}