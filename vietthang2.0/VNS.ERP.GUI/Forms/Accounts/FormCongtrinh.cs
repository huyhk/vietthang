using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data.Accounting;
using VNS.ERP.Data;

namespace VNS.ERP.GUI
{
    public partial class FormCongtrinh : VNS.Windows.Forms.FormEditBase
    {
        CongtrinhBLL bll = new CongtrinhBLL();
        public FormCongtrinh()
        {
            InitializeComponent();

            this.Business = bll;

            this.DataSource = bll.GetAll();
        }
    }
}
