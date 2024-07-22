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
using VNS.Windows;

namespace VNS.ERP.GUI
{
    public partial class FormEmployeeGroup : FormEditBase
    {
        private EmployeeBLL employeeBLL=null;
        private ListBase<Employee> lst1 = null;
        private ListBase<Employee> lst2 = null;
        public FormEmployeeGroup()
        {
            InitializeComponent();
        }
        protected override void InitDataObjects()
        {
            if (!DesignMode)
            {
                this.Business = new EmployeeBLL();
            }
            base.InitDataObjects();
        }
        private void FormEmployeeGroup_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                employeeBLL = new EmployeeBLL();
                this.gridControlTitle.DataSource = EnumDisplays.GetListGroupEmployees();
                this.ItemLookUpText.DataSource = EnumDisplays.GetListGroupEmployeesText();
                this.btnCancel.Click += new EventHandler(btnCancel_Click);
                RefreshButtons();
            }
        }
        public override void RefreshButtons()
        {
            base.RefreshButtons();
            this.btnEdit.Enabled = this.editMode == FormEditMode.VIEW;
            this.btnSave.Enabled = this.editMode == FormEditMode.EDIT;
            this.btnCancel.Visible = this.editMode == FormEditMode.EDIT;
           this.navigatorFrmEditBase.Visible = false;
           this.gridControlTitle.Enabled = this.editMode == FormEditMode.VIEW;
         
        }
        CurrencyManager cr = null;
        private void gridViewTitle_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            cr = this.BindingContext[this.gridControlTitle.DataSource] as CurrencyManager;
            if (e.FocusedRowHandle >= 0)
            {
                lst1=employeeBLL.GetListObjectByEmployeeGroupCode((cr.Current as enums).EnumName);
                lst2 = employeeBLL.GetListObjectNotTableGroup((cr.Current as enums).EnumName);
                this.ucEmployeeGroup1.SetDataSourcedgrid(lst2, lst1,(cr.Current as enums).EnumName);
            }
        }
        void btnCancel_Click(object sender, EventArgs e)
        {
            lst1 = employeeBLL.GetListObjectByEmployeeGroupCode((cr.Current as enums).EnumName);
            lst2 = employeeBLL.GetListObjectNotTableGroup((cr.Current as enums).EnumName);
            this.ucEmployeeGroup1.SetDataSourcedgrid(lst2, lst1,(cr.Current as enums).EnumName);
         }
    }
}