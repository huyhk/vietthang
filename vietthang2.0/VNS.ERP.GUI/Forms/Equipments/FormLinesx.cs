using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;

using VNS.Common;

namespace VNS.ERP.GUI.Equipments
{
    public partial class FormLinesx : FormEditBase
    {
        LinesxsBLL obj = new LinesxsBLL();
        public FormLinesx()
        {
            InitializeComponent();
            this.Business = obj;
            this.DataSource = obj.GetAll();
            this.repositoryItemLookUpEdit1.DataSource = new StockBLL().GetAll();

        }
    }
}

