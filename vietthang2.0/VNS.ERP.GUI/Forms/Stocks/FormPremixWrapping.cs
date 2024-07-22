using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using VNS.Windows.Forms;
using VNS.ERP.Data;



namespace VNS.ERP.GUI
{
    public partial class FormPremixWrapping : FormEditBase
    {
        public FormPremixWrapping()
        {
            InitializeComponent();
            this.Business = new PremixWrappingBLL();
            this.DataSource = new PremixWrappingBLL().GetAll();
            //ucPremixWrappings1.SetLookupPremix();
        }

       
    }
}