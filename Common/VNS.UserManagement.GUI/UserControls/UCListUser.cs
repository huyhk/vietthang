using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using VNS.UserManagement.Data;
namespace VNS.UserManagement.GUI
{
    public partial class UCListUser : VNS.Windows.Controls.UCListBase
    {
        public UCListUser()
        {
            InitializeComponent();
            this.Business = new UserBLL();
        }

        private void UCListUser_Load(object sender, EventArgs e)
        {
            this.DataSource = (this.Business as UserBLL).GetAllUser();
            this.FormOpenType = typeof(FrmEditUser);
        }
    }
}

