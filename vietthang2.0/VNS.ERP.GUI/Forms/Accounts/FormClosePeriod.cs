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
    public partial class FormClosePeriod : FormBase
    {
        ListBase<Period> lst = null;
        private string moduleCode="Stock";
        public string ModuleCode
        {
            get { return moduleCode; }
            set { moduleCode = value; }
        }
        PeriodBLL bll = new PeriodBLL();
        /// <summary>
        /// Default Construtor
        /// </summary>
        public FormClosePeriod()
        {
            InitializeComponent();
            lst= bll.SelectIsClosedFalse("");
            lookUpPeriod.Properties.DataSource = lst;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="moduleCode"></param>
        public FormClosePeriod(string moduleCode)
        {
            InitializeComponent();
            this.ModuleCode = moduleCode;
            lst = bll.SelectIsClosedFalse(moduleCode);
            lookUpPeriod.Properties.DataSource = lst;
        }

        private void FormClosePeriod_Load(object sender, EventArgs e)
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

        private void btnClosePeriod_Click(object sender, EventArgs e)
        {
            int iError = 0;
            if(lookUpPeriod.ItemIndex==-1)
            {
                MessageBox.Show(this.GetTextMessage("VALIDATE-1","Chưa chọn kỳ kế toán"));
                return;
            }
            DateTime dateDataError = DateTime.Today;
            string transactionNoDataError = string.Empty;
           
            if (MessageBox.Show(this.GetTextMessage("Info-1", "Bạn có đồng ý khoá sổ?"), this.GetTextMessage("Info-0", "Thông báo!"), MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Period obj = lst.Search("PeriodCode", lookUpPeriod.EditValue.ToString());
                DateTime startDate = obj.StartDate;
                
                int count = lst.Count;
                for (int i = 0; i < count; i++)
                {
                    Period obj1 = lst[i];
                    if (obj1.StartDate < obj.StartDate)
                    {
                        startDate = obj1.StartDate;
                        i = count;
                    }
                    else
                    {
                        i = count;
                    }
                }
                //if (bll.CheckDataBeforeClosePeriod(ref dateDataError, ref transactionNoDataError, startDate, obj.EndDate, this.ModuleCode) == -1)
                //{
                //    //if (this.ModuleCode == enumModuleID.Sale.ToString())
                //    //{
                //    //    MessageBox.Show("Khoá sổ không thành công vì phiếu yêu cầu bán hàng ngày " + dateDataError.ToShortDateString() + "(số: \"" + transactionNoDataError + "\") chưa được thực hiện");
                //    //    return;
                //    //}
                //    MessageBox.Show("Khoá sổ không thành công vì phiếu nhập/xuất kho ngày " + dateDataError.ToShortDateString() + "(số: \"" + transactionNoDataError + "\") chưa được xác nhận hoặc chưa được bộ phận xác nhận");
                //    return;
                //}
                iError = bll.ClosePeriod(obj, this.ModuleCode, lst);
                if (iError == 0)
                {
                    obj = bll.SelectObjectLastMonthSpecify(obj.EndDate);
                    lst = bll.SelectIsClosedFalse(moduleCode);
                    lookUpPeriod.Properties.DataSource = lst;
                    try
                    {
                        lookUpPeriod.ItemIndex = 0;
                    }
                    catch
                    {
                        //throw;
                    }
                    MessageBox.Show(this.GetTextMessage("Info-2", "Đã khoá sổ thành công"));
                }
                else
                {
                    if (iError == -2)
                    {
                        //if(this.ModuleCode == enumModuleID.Sale.ToString())
                        //{
                        //    MessageBox.Show(this.GetTextMessage("Info-5", "Khoá sổ không thành công do có phiếu phiếu yêu cầu xuất bán chưa được thực hiện"));
                        //    return;
                        //}
                        MessageBox.Show(this.GetTextMessage("Info-4", "Khoá sổ không thành công do có phiếu xuất/nhập kho chưa được xác nhận hoặc chưa được bộ phận xác nhận"));
                    }
                    else
                    {
                        MessageBox.Show(this.GetTextMessage("Info-3", "Khoá sổ không thành công"));
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}