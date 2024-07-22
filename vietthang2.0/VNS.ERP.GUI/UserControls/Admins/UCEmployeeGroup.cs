using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.ERP.Data;
using VNS.Common;
using VNS.Windows.Forms;
using VNS.Windows;

namespace VNS.ERP.GUI
{
    public partial class UCEmployeeGroup : EditControlBase
    {

        private string employeeGroupCode = "";
        public UCEmployeeGroup()
        {
            InitializeComponent();
          
        }

        public void SetDataSourcedgrid(ListBase<Employee> lstSource, ListBase<Employee> lstSourceMove, string EmployeeGroupCode)
        {
            this.gridControl1.DataSource = lstSource;
            this.gridControl2.DataSource = lstSourceMove;
            employeeGroupCode = EmployeeGroupCode;
            RefreshControl();
        }
        //protected override void BindData()
        //{
        //    this.gridControl2.DataSource = this.dataSource;
        //}
        public override void RefreshControl()
        {
            if (this.EditMode == FormEditMode.EDIT)
            {
                if (this.gridView1.RowCount > 1)
                    this.btRight.Enabled = true;
                else
                    this.btRight.Enabled = false;
                if (this.gridView2.RowCount > 1)
                    this.btLeft.Enabled = true;
                else
                    this.btLeft.Enabled = false;
            }
            else
            {
                this.btRight.Enabled = false;
                this.btLeft.Enabled = false;
            }
        }
        private void btRight_Click(object sender, EventArgs e)
        {
            if (this.gridView1.RowCount >1 && this.gridView1.FocusedRowHandle >= 0)
            {
                Employee obj = new Employee();
                obj = (this.gridControl1.DataSource as ListBase<Employee>)[this.gridView1.FocusedRowHandle];
                (this.gridControl1.DataSource as ListBase<Employee>).RemoveAt(this.gridView1.FocusedRowHandle);
                (this.gridControl2.DataSource as ListBase<Employee>).Insert(this.gridView2.RowCount - 1, obj);
                this.btLeft.Enabled = true;
            }
            else
            {
                this.btRight.Enabled = false;
                this.btLeft.Enabled = true;
            }
        }

        private void btLeft_Click(object sender, EventArgs e)
        {
            if (this.gridView2.RowCount > 1 && this.gridView2.FocusedRowHandle >= 0)
            {
                Employee obj = new Employee();
                obj = (this.gridControl2.DataSource as ListBase<Employee>)[this.gridView2.FocusedRowHandle];
                (this.gridControl2.DataSource as ListBase<Employee>).RemoveAt(this.gridView2.FocusedRowHandle);
                (this.gridControl1.DataSource as ListBase<Employee>).Insert(this.gridView1.RowCount - 1, obj);
                this.btRight.Enabled = true;
            }
            else
            {
                this.btLeft.Enabled = false;
                this.btRight.Enabled = true;
            }
        }
        public override bool Save()
        {
            int iErorr = 0;
            if (editMode == FormEditMode.EDIT)
            {
                iErorr = new EmployeeBLL().InserEmployeeGroup(employeeGroupCode,this.gridControl2.DataSource as ListBase<Employee>);
            }

            if (iErorr != 0)
            {

                OnError(iErorr, ErrorMessageType.INSERT);
                return false;
            }
            return true;
        }
    }
}
