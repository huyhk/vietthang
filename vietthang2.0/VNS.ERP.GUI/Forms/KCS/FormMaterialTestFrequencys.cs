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
    public partial class FormMaterialTestFrequencys : FormEditBase
    {
        MaterialTestFrequencysBLL obj = new MaterialTestFrequencysBLL();
        public FormMaterialTestFrequencys()
        {
            InitializeComponent();
            lookUpFrequencyType.DataSource = EnumDisplays.GetListenumFrequencyType();
            lookUpFrequencyType.DisplayMember = "EnumText";
            lookUpFrequencyType.ValueMember = "EnumName";

            lookUpTechName.DataSource = new TechnicalTestBLL().GetAll();
            lookUpTechName.DisplayMember = "TechName";
            lookUpTechName.ValueMember = "TechCode";

            this.ucMaterialTestFrequencys1.SetDss();
            this.Business = obj;
            this.colQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantity.DisplayFormat.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT;
        }

        private void FormMaterialTestFrequencys_Load(object sender, EventArgs e)
        {
            gridControlItems.DataSource = new ItemBLL().GetbyItemtype((int)enumItemType.Material);
            gridControlItems.RefreshDataSource();
            gridControlMaterialTestFrequency.RefreshDataSource();
        }
        public override void RefreshButtons()
        {
            gridControlItems.Enabled = this.EditMode == VNS.Windows.FormEditMode.VIEW;
            base.RefreshButtons();
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CurrencyManager cr = this.BindingContext[this.gridControlItems.DataSource] as CurrencyManager;
            this.ucMaterialTestFrequencys1.ItemCode = (cr.Current as Item).ItemCode;
            this.DataSource = obj.GetByItemCode((cr.Current as Item).ItemCode);
        }

    
    }
}