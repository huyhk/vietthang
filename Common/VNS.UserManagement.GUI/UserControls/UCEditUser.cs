using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VNS.UserManagement.GUI
{
    public partial class UCEditUser : VNS.Windows.Controls.EditControlBase
    {
        public UCEditUser()
        {
            InitializeComponent();
        }
        public override void ControlSettings()
        {
            this.SetControlStatus(this.txtMemberID, enumControlStatus.IDData);
            this.SetControlDataBind(this.txtMemberID, "MemberID");

            this.SetControlStatus(this.txtMemberName, enumControlStatus.NormalData);
            this.SetControlDataBind(this.txtMemberName, "MemberName");

            this.SetControlStatus(this.chkIsAdmin, enumControlStatus.NormalData);
            this.SetControlDataBind(this.chkIsAdmin, "IsAdmin");

            this.SetControlStatus(this.txtDescription, enumControlStatus.NormalData);
            this.SetControlDataBind(this.txtDescription, "Description");

            //this.SetControlStatus(this.chkInActive, enumControlStatus.NormalData);
            //this.SetControlDataBind(this.chkInActive, "InActive");

            base.ControlSettings();
        }
        protected override int ValidateData()
        {
            this.txtMemberID.Text = this.txtMemberID.Text.Trim();
            if (this.txtMemberID.Text == string.Empty)
            {
                this.txtMemberID.Focus();
                return -1;
            }
            if (this.txtMemberName.Text == string.Empty)
            {
                this.txtMemberName.Focus();
                return -2;
            }

            return base.ValidateData();
        }
    }
}

