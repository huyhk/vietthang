using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.Common;
using VNS.ERP.Manufactures.Reports;

namespace VNS.ERP.GUI
{
    public partial class FormListNguyenlieu : FormBase
    {
        private ItemBLL _ItemBLL = new ItemBLL();
        public FormListNguyenlieu()
        {
            InitializeComponent();
        }

        protected ArrayList arrayNL;
        /// <summary>
        /// Gets or sets the object being displayed when is add new.
        /// </summary>
        [Browsable(false)]
        public ArrayList ArrayNL
        {
            get { return arrayNL; }
            set
            {
                this.arrayNL = value;
            }
        }
        protected DataTable dt;
        /// <summary>
        /// Gets or sets the object being displayed when is add new.
        /// </summary>
        [Browsable(false)]
        public DataTable DataTableSouced
        {
            get { return dt; }
            set
            {
                this.dt = value;
            }
        }
        private void FormListNguyenlieu_Load(object sender, EventArgs e)
        {
             this.gridControl.DataSource = dt;
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataView dv = VNS.Windows.GridUtils.GetDataView(this.gridControl);
            rptNguyenlieuFromManufacture rpt = new rptNguyenlieuFromManufacture(dv);
            rpt.BindDataMaster(ArrayNL);
            rpt.BindDataDetail();
            rpt.ShowPreviewDialog();
        }

    }
}