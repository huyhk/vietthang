using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Equipments;

namespace VNS.ERP.GUI.Equipments
{
    public partial class FormEquipmentsxs : FormEditBase
    {
        EquipmentsxBLL obj = new EquipmentsxBLL();
        public FormEquipmentsxs()
        {
            InitializeComponent();
            this.Business = obj;
            this.DataSource = obj.GetAll();
        }
    }
}

