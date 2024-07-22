using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VNS.ERP.GUI.Manufactures
{
    public partial class FormSelectSTType : VNS.Windows.Forms.FormBase
    {
        public FormSelectSTType()
        {
            InitializeComponent();
        }
        public bool[] SelectResult
        {
            get { return new bool[] { this.chkOutMaterial.Checked, this.chkOutFuel.Checked, this.chkInProduct.Checked, this.chkInWaste.Checked }; }
        }
    }
}

