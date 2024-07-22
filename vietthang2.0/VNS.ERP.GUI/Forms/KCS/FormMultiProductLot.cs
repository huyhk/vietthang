using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VNS.ERP.GUI.KCS
{
    public partial class FormMultiProductLot : VNS.Windows.Forms.FormBase
    {
        public FormMultiProductLot()
        {
            InitializeComponent();
        }
        public string LineCode
        {
            get { return this.txtLineCode.Text; }
        }
        public int Frequency
        {
            get { return (int)this.txtFrequency.Value; }
        }
        public int FromLot
        {
            get { return (int)this.txtFromLot.Value; }
        }
        public int ToLot
        {
            get { return (int)this.txtToLot.Value; }
        }
    }
}

