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
    public partial class FormItemGroup : VNS.Windows.Forms.FormEditBase
    {
        ItemGroupBLL bll = new ItemGroupBLL();
        public FormItemGroup()
        {
            InitializeComponent();
            this.Business = bll;
            this.DataSource = bll.GetAll();
        }
    }
}

