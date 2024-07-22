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
    public partial class FormProductTestFrequencys : FormEditBase
    {
        ProductTestFrequencyBLL obj = new ProductTestFrequencyBLL();

        public FormProductTestFrequencys()
        {
            InitializeComponent();
            this.EditControl = this.ucProductTestFrequencys1;
            this.Business = obj;
            this.DataSource = obj.GetAll();
            if (!this.DesignMode)
            {
                this.repChiTieu.DataSource = new TechnicalTestBLL().GetAll();
                this.repTanxuat.DataSource = EnumDisplays.GetListenumFrequencyType();
            }                                           
        }

        private void FormProductTestFrequencys_Load(object sender, EventArgs e)
        {
            
        }
    }
}