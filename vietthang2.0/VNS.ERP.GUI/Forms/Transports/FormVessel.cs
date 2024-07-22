using System;
//using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.Common;
using VNS.Windows;

namespace VNS.ERP.GUI
{
    public partial class FormVessel : FormEditBase
    {
        VesselBLL obj = new VesselBLL();
        public FormVessel()
        {
            InitializeComponent();
            this.Business = obj;
        }

        private void FormVessel_Load(object sender, EventArgs e)
        {
            this.DataSource = obj.GetAll();
        }
    }
}