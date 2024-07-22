using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Common;
using VNS.ERP.Data;
using VNS.Windows.Forms;

namespace VNS.ERP.GUI
{
    public partial class FormOpenPeriod : FormBase
    {
        ListBase<Period> lst = null;
        private string moduleCode = "Stock";
        public string ModuleCode
        {
            get { return moduleCode; }
            set { moduleCode = value; }
        }
        PeriodBLL bll = new PeriodBLL();
        public FormOpenPeriod()
        {
            InitializeComponent();
        }
        public FormOpenPeriod(string moduleCode)
        {
            InitializeComponent();
            this.ModuleCode = moduleCode;
            lst = bll.SelectIsClosedTrue(moduleCode);
            lookUpPeriod.Properties.DataSource = lst;
        }

        private void FormOpenPeriod_Load(object sender, EventArgs e)
        {
            try
            {
                lookUpPeriod.ItemIndex = 0;
            }
            catch
            {
                //throw;
            }
        }

        private void btnOpenPeriod_Click(object sender, EventArgs e)
        {
            int iError = 0;
            if (lookUpPeriod.ItemIndex == -1)
            {
                MessageBox.Show(this.GetTextMessage("VALIDATE-1", "Chưa chọn kỳ kế toán"));
                return;
            }

            if (MessageBox.Show(this.GetTextMessage("Info-1", "Bạn có đồng ý mở sổ?"), this.GetTextMessage("Info-0", "Thông báo!"), MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Period obj = lst.Search("PeriodCode", lookUpPeriod.EditValue.ToString());
                iError = bll.OpenPeriod(obj.PeriodCode, this.ModuleCode);
                if (iError == 0)
                {
                    lst = bll.SelectIsClosedTrue(moduleCode);
                    lookUpPeriod.Properties.DataSource = lst;
                    try
                    {
                        lookUpPeriod.ItemIndex = 0;
                    }
                    catch
                    {
                        //throw;
                    }
                    MessageBox.Show(this.GetTextMessage("Info-2", "Đã mở sổ thành công"));
                }
                else
                {
                    MessageBox.Show(this.GetTextMessage("Info-3", "Mở sổ không thành công"));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}