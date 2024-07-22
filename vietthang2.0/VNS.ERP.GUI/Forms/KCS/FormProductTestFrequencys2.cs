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

namespace VNS.ERP.GUI.KCS
{
    public partial class FormProductTestFrequencys2 : FormEditBase
    {
        ProductTestFrequencyBLL obj = new ProductTestFrequencyBLL();
        public FormProductTestFrequencys2()
        {
            InitializeComponent();
//            this.EditControl = this.ucProductTestFrequencys1;
            this.Business = obj;
            this.DataSource = obj.GetAll();
            //this.EditControl = this.ucBocXepType1;
            //this.Business = obj;
            //this.DataSource = obj.GetAll();
            if (!this.DesignMode)
            {
                this.repoChiTieu.DataSource = new TechnicalTestBLL().GetAll();
                this.repTanxuat.DataSource = EnumDisplays.GetListenumFrequencyType();
                //lookUpFrequencyType.DataSource = EnumDisplays.GetListenumFrequencyType();
            }
        }

        private void FormProductTestFrequencys2_Load(object sender, EventArgs e)
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
            this.ucProductTestFrequencys1.ProductCode = (cr.Current as Product).ProductCode;
            this.DataSource = obj.GetByProductCode((cr.Current as Product).ProductCode);
        }
    }
}