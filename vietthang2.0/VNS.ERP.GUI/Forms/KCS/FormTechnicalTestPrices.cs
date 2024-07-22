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
    public partial class FormTechnicalTestPrices : FormEditBase
    {
        TechnicalTestPriceBLL obj = new TechnicalTestPriceBLL();
        public FormTechnicalTestPrices()
        {
            InitializeComponent();

            this.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrice.DisplayFormat.FormatString = AppConfigs.CONFIG_PRICEVNFORMATZ;

            lookUpTechnical.DataSource = new TechnicalTestBLL().GetAll();
            lookUpTechnical.DisplayMember = "TechName";
            lookUpTechnical.ValueMember = "TechCode";

            this.ucTechnicalTestPrices1.SetDss();

            this.Business = obj;
        }

        private void FormTechnicalTestPrices_Load(object sender, EventArgs e)
        {
            gridControlSubject.DataSource = new AnalizeSubjectBLL().GetAll();
            gridControlSubject.RefreshDataSource();
            gridControl2.RefreshDataSource();
        }

        public override void RefreshButtons()
        {
            gridControlSubject.Enabled = this.EditMode == VNS.Windows.FormEditMode.VIEW;
            base.RefreshButtons();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CurrencyManager cr = this.BindingContext[this.gridControlSubject.DataSource] as CurrencyManager;
            this.ucTechnicalTestPrices1.SubjectCode = (cr.Current as AnalizeSubject).SubjectCode;
            this.DataSource = obj.GetBySubjectCode((cr.Current as AnalizeSubject).SubjectCode);
        }


    }
}