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
    public partial class FormEquipmentLogs : FormEditBase
    {
        EquipmentLogBLL obj = new EquipmentLogBLL();
        public FormEquipmentLogs()
        {
            InitializeComponent();
            this.Business = obj;
            this.DataSource = obj.GetAll();
            this.repositoryItemLookUpEditEquipmentCode.DataSource = new EquipmentBLL().GetAll();
            this.repositoryItemLookUpEditStockCode.DataSource = new StockBLL().GetAll();
        }
    }
}

