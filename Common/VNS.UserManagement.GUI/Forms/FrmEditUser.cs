using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using VNS.UserManagement.Data;
using VNS.Common;
using VNS.Security;
namespace VNS.UserManagement.GUI
{
    public partial class FrmEditUser : VNS.Windows.Forms.FormEditBase
    {
        public FrmEditUser()
        {
            InitializeComponent();
            this.DataSource = new ListBase<User>();
            this.Business = new UserBLL();
        }
    }
}

