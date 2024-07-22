using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.Common;

namespace VNS.ERP.GUI.Transports
{
    public partial class FormToBocxeps : FormEditBase
    {
        ToBocxepBLL bll = new ToBocxepBLL();
        private ListBase<ToBocxep> lstToBocxep = new ListBase<ToBocxep>();
        public FormToBocxeps()
        {
            InitializeComponent();
            this.Business = bll;
            //this.DataSource = bll.GetAll();
        }
        private void FormToBocxeps_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                this.gridControl1.DataSource = new VendorBLL().GetForBocxep(); //new SubjectBLL().GetKhoVan();
                this.gridControl1.RefreshDataSource();
                this.gridControl2.RefreshDataSource();
            }

        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CurrencyManager cr = this.BindingContext[this.gridControl1.DataSource] as CurrencyManager;
            this.ucToBocxeps1.SubjectCode = (cr.Current as Subject).SubjectCode;
            this.DataSource = bll.GetBySubjectCode((cr.Current as Subject).SubjectCode);
        }
        public override void RefreshButtons()
        {
            gridControl1.Enabled = this.EditMode == VNS.Windows.FormEditMode.VIEW;
            base.RefreshButtons();
        }
    }
}

