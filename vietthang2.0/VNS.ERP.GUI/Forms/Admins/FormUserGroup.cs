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

namespace VNS.ERP.GUI
{
    public partial class FormUserGroup : FormEditBase
    {
        public FormUserGroup()
        {
            InitializeComponent();
            this.Business = new UserGroupBLL();
            this.DataSource = new UserGroupBLL().GetAllGroup();
            this.ucUserGroup1.SetLookup();
        }

      
    }
}