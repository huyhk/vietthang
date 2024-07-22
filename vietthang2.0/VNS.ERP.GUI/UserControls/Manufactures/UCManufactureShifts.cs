using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using VNS.Windows.Controls;
using VNS.ERP.Data;
using VNS.ERP.Data.Manufactures;
using VNS.Windows;
using VNS.Common;

namespace VNS.ERP.GUI.Manufactures
{
    public partial class UCManufactureShifts : EditControlBase
    {
       
        public UCManufactureShifts()
        {
            InitializeComponent();
          
        }
        protected string stockCode;
        ///<summary>
        ///Gets or sets the object being displayed when is AddNew or Edit.
        ///</summary>
        [Browsable(false)]
        public string StockCode
        {
            get { return stockCode; }
            set
            {
                this.stockCode = value;
            }
        }
        protected override void BindData()
        {
              if (this.editMode == FormEditMode.VIEW)
              {
                  this.cboKho.EditValue = (dataSource as ManufactureShift).StockCode;
              }
              else
                this.cboKho.EditValue = StockCode;
              this.cboCa.Value = (dataSource as ManufactureShift).Shift;
              this.cboTruongca.EditValue = (dataSource as ManufactureShift).ShiftLeader;
              this.cboPhoca.EditValue = (dataSource as ManufactureShift).ViceLeader;
              this.cboNgay.EditValue = (dataSource as ManufactureShift).ManufactureDate;
              if ((dataSource as ManufactureShift).ListFuelInTransaction.Count==0)
              {
                  (dataSource as ManufactureShift).ListFuelInTransaction = (new ManufactureShiftBLL()).GetObjectByManutransactionShiftID((dataSource as ManufactureShift).ManufactureShiftID);
              }
                this.gridNhienlieu.DataSource= (dataSource as ManufactureShift).ListFuelInTransaction;
               
                this.cboNgay.Focus();
        }

        protected override int ValidateData()
        {
            if (this.cboTruongca.EditValue.ToString() == string.Empty)
            {
                this.cboTruongca.Focus();
                return -1;
            }
            return 0;
        }
        protected override void AssignData()
        {
            if (dataSource == null)
                dataSource = new ManufactureShift();
            (dataSource as ManufactureShift).Shift = int.Parse(this.cboCa.Text);
            (dataSource as ManufactureShift).StockCode = this.cboKho.EditValue.ToString();
            (dataSource as ManufactureShift).ShiftLeader = this.cboTruongca.EditValue.ToString();
            (dataSource as ManufactureShift).ViceLeader = this.cboPhoca.EditValue.ToString();
            (dataSource as ManufactureShift).ManufactureDate = this.cboNgay.DateTime;
        }

        private void UCManufactureShifts_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                this.cboKho.Properties.Buttons.Clear();
                this.cboKho.Properties.DataSource = (new StockBLL()).GetAll();
                this.cboTruongca.Properties.DataSource = (new EmployeeBLL()).GetByStockCodeAndGroupEmployee(StockCode, enumEmployeeGroup.EmployeeTruongCa.ToString());
                this.cboPhoca.Properties.DataSource = (new EmployeeBLL()).GetByStockCodeAndGroupEmployee(StockCode, enumEmployeeGroup.EmployeePhoca.ToString());
                this.ItemLookUpNL.DataSource = (new ItemBLL()).GetbyItemtype((int)enumItemType.Fuel);
                if (!Contexts.CurrentUser.IsAdmin)
                {
                    if (Contexts.MemberFunctions.Search("FunctionName", FunctionNames.MANUFACTURE_FUNCTION_DIVIDEFUEL) == null)
                        this.btnPhanboNL.Visible = false;
                }
            }
        }
        private void gridViewNhienlieu_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.gridViewNhienlieu.RowCount > 0 && this.gridViewNhienlieu.OptionsBehavior.Editable == true)
            {
                if (e.KeyCode == Keys.Delete)
                    this.gridViewNhienlieu.DeleteRow(this.gridViewNhienlieu.FocusedRowHandle);

            }

        }
        private void SetStatus()
        {
            if (this.EditMode == FormEditMode.VIEW)
            {
                this.cboCa.Properties.ReadOnly = true;
                this.cboNgay.Properties.ReadOnly = true;
                this.cboTruongca.Properties.ReadOnly = this.cboPhoca.Properties.ReadOnly = true;
                this.btnPhanboNL.Enabled = true;
                this.gridViewNhienlieu.OptionsBehavior.Editable = false;
                RefreshGridControl();
                this.gridNhienlieu.RefreshDataSource();
            }
            if (this.EditMode == FormEditMode.ADD)
            {
                this.cboCa.Properties.ReadOnly =false;
                this.cboNgay.Properties.ReadOnly = false;
                this.cboTruongca.Properties.ReadOnly = this.cboPhoca.Properties.ReadOnly = false;
                this.gridViewNhienlieu.OptionsBehavior.Editable = true;
                this.btnPhanboNL.Enabled = false;
                this.cboCa.Focus();
            }
            if (this.EditMode == FormEditMode.EDIT)
            {
                this.cboCa.Properties.ReadOnly = true;
                this.cboNgay.Properties.ReadOnly = true;
                this.cboTruongca.Properties.ReadOnly = this.cboPhoca.Properties.ReadOnly = false;
                this.gridViewNhienlieu.OptionsBehavior.Editable = true;
                this.btnPhanboNL.Enabled = false;
                this.cboTruongca.Focus();
            }
        }
        public override void RefreshControl()
        {
            SetStatus();
            base.RefreshControl();
    
        }
        private void RefreshGridControl()
        {
            try
            {
                foreach (ManufactureShiftTransaction manu in (this.gridNhienlieu.DataSource as ListBase<ManufactureShiftTransaction>))
                {
                    if (manu.Quantity == 0)
                        (this.gridNhienlieu.DataSource as ListBase<ManufactureShiftTransaction>).Remove(manu);
                }
            }
            catch
            {
            }

        }

        private void btnPhanboNL_Click(object sender, EventArgs e)
        {
            int iError=0;
            if (this.editMode == FormEditMode.VIEW)
            {
                if ((dataSource as ManufactureShift).ListManufacture.Count>0)
                {
                    iError = (new ManufactureShiftBLL()).DivideTotalFuel(dataSource as ManufactureShift);
                    if(iError==0)
                        MessageBox.Show("Nhiên liệu đã được phân bổ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (iError==-100)
                        MessageBox.Show("Thời gian làm việc phải lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (iError == -99)
                        MessageBox.Show("Chưa nhập nhiêu liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        MessageBox.Show("Nhiên liệu phân bổ không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Vui lòng nhập phiếu sản xuất!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
