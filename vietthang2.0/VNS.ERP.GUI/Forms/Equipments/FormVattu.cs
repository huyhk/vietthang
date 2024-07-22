using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
namespace VNS.ERP.GUI.Equipments
{
    public partial class FormVattu : FormEditBase
    {
        VattuBLL obj = new VattuBLL();
        public FormVattu()
        {
            InitializeComponent();
            this.Business=obj;
            this.DataSource = obj.GetAll();
        }
    }
}