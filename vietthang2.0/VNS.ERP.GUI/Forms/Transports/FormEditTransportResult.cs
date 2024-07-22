using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data.Transports;

namespace VNS.ERP.GUI.Transports
{
    public partial class FormEditTransportResult : VNS.Windows.Forms.FormEditBase
    {
        private VNS.ERP.Data.TransportRoute myTransportRoute = new VNS.ERP.Data.TransportRoute();
        public VNS.ERP.Data.TransportRoute MyTransportRoute
        {
            get { return myTransportRoute; }
            set
            {
                myTransportRoute = value;
                //this.ucTransportResult1.MyTransportRoute = myTransportRoute;
            }
        }
        public FormEditTransportResult()
        {
            InitializeComponent();
            this.Business = new TransportResultBLL();
        }
        public FormEditTransportResult(VNS.ERP.Data.TransportRoute transportRoute)
        {
            InitializeComponent();
            this.Business = new TransportResultBLL();
            MyTransportRoute = transportRoute;
        }
    }
}

