using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VNS.ERP.GUI
{
    public partial class FormMainAdmin : FormMainBase
    {
        public FormMainAdmin()
        {
            InitializeComponent();
        }

        private void MenuUser_Click(object sender, EventArgs e)
        {
            FormUser f = new FormUser();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuUserGroup_Click(object sender, EventArgs e)
        {
            FormUserGroup f = new FormUserGroup();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuSetPrivilege_Click(object sender, EventArgs e)
        {
            FormMemberFunction f = new FormMemberFunction();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuEmployee_Click(object sender, EventArgs e)
        {
            FormEmployee f = new FormEmployee();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuVendor_Click(object sender, EventArgs e)
        {
            FormVendor f = new FormVendor();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuTransport_Click(object sender, EventArgs e)
        {
            //FormTransport f = new FormTransport();
            //this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuUpdateDatabase_Click(object sender, EventArgs e)
        {
            FormUpdateDB f = new FormUpdateDB();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuEmployeeGroup_Click(object sender, EventArgs e)
        {
            FormEmployeeGroup f = new FormEmployeeGroup();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuVessel_Click(object sender, EventArgs e)
        {
            FormVessel f = new FormVessel();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuJobHistory_Click(object sender, EventArgs e)
        {
            FormJobHistory f = new FormJobHistory();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void testWSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTestWS f = new FormTestWS();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuConfigMTS_Click(object sender, EventArgs e)
        {
            FormDBConfigMTS f = new FormDBConfigMTS();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }
    }
}