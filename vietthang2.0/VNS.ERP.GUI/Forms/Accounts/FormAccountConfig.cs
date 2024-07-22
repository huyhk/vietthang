using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;

namespace VNS.ERP.GUI.Accounting
{
    public partial class FormAccountConfig : VNS.Windows.Forms.FormBase
    {
        public FormAccountConfig()
        {
            InitializeComponent();
        }

        private void FormAccountConfig_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            ModuleAccounting md = new ModuleBLL().GetModuleAccounting();

            txtTendonvi.Text = md.TenDonvi;
            txtDiachi.Text = md.Diachi;
        }
        void SaveData()
        {
            ModuleAccounting md = new ModuleAccounting();
            md.TenDonvi = txtTendonvi.Text;
            md.Diachi = txtDiachi.Text;

            new ModuleBLL().UpdateModuleConfig(md);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
            this.Close();
        }
    }
}

