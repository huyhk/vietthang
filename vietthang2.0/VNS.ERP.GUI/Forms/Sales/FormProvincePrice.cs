using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Sales;

namespace VNS.ERP.GUI.Sales
{
    public partial class FormProvincePrice : VNS.Windows.Forms.FormEditBase
    {
        ProvincePriceBLL bll = new ProvincePriceBLL();
        public FormProvincePrice()
        {
            InitializeComponent();
            this.Business = bll;
            this.DataSource = bll.GetAll();
            //this.repLookUpSubjectName.DataSource = new CustomerBLL().GetAll();
        }
    }
}
