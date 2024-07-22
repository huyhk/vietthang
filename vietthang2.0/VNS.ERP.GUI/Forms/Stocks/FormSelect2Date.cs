using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VNS.ERP.GUI
{
    public partial class FormSelect2Date : VNS.Windows.Forms.FormBase
    {
        public FormSelect2Date()
        {
            InitializeComponent();
        }

        public DateTime StartDate
        {
            get { return this.txtStartDate.DateTime; }
            set { this.txtStartDate.DateTime = value; }
        }
        public DateTime EndDate
        {
            get { return this.txtEndDate.DateTime; }
            set { this.txtEndDate.DateTime = value; }
        }
    }
}

