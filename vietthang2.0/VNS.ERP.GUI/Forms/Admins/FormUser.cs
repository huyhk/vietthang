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
    public partial class FormUser :FormEditBase
    {
        ListBase<Employee> datsource = new ListBase<Employee>();
        Employee user = new Employee();
        public FormUser()
        {

            InitializeComponent();
            this.Business = new UserBLL();
            this.DataSource = new UserBLL().GetAllUser();
            datsource = new EmployeeBLL().GetAll();
            datsource.Add(user);
            LookupEmployee.DataSource = datsource;
            usrUser1.SetLookupEmploy(datsource);
        }
        public override void Delete()
        {
            if ((this.currentItem as UserERP).MemberID == Contexts.CurrentUser.MemberID)
            {
                MessageBox.Show("Không thể xóa user " + Contexts.CurrentUser.MemberID);
                return;
            }
            base.Delete();
        }
    }
}