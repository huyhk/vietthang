using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;

namespace VNS.ERP.GUI.Transports
{
    public partial class FormEditVesselTransactions : FormEditBase
    {
        VesselTransactionBLL obj = new VesselTransactionBLL();
        public FormEditVesselTransactions()
        {
            InitializeComponent();
            
            //this.EditControl = this.ucVesselTransactions1;
            this.Business = obj;
            //this.Business = obj.GetForPeriod();
        }
        public FormEditVesselTransactions(string textform)
        {
            InitializeComponent();
         //   this.EditControl = this.ucVesselTransactions1;
            this.Business = obj;
            this.Text = textform;
        }
    }
}