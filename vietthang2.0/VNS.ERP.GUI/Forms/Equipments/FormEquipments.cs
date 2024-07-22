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
    public partial class FormEquipments : FormEditBase
    {
        EquipmentBLL obj = new EquipmentBLL();
        public FormEquipments()
        {
            InitializeComponent();
            this.repositoryItemLookUpEdit1.DataSource = new EquipmentGroupBLL().GetAll();
            this.Business = obj;
            this.DataSource = obj.GetAll();
            //this.repositoryItemLookUpEdit1.DataSource = new EquipmentGroupBLL().GetAll();
        }
    }
}

