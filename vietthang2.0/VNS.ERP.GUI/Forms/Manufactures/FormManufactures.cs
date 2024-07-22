using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Manufactures;
using VNS.Common;
using VNS.Windows;
using System.Collections;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.XtraEditors;
namespace VNS.ERP.GUI.Manufactures
{
    public partial class FormManufactures : FormEditBase
    {
        private ManufactureShiftBLL _bllShift = new ManufactureShiftBLL();
        private ManufactureBLL _ManufactureBLL = new ManufactureBLL();
        private StockBLL _StockBLL = new StockBLL();
        private EmployeeBLL _EmployeeBLL = new EmployeeBLL();
        private int currenFocusGridview = 0;
        private ListBase<Period> lstPeriods = null;
        private DateTime startDate = Contexts.WorkingStartDate;
        private DateTime endDate=Contexts.WorkingEndDate;
        public FormManufactures()
        {
            InitializeComponent();
            this.Business = _ManufactureBLL;
            this.ItemButtonEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(ItemButtonEdit_ButtonClick);
            ItemLookStatus.DataSource = EnumDisplays.GetListStatusManufactureShift();
        }
        
        public override void AddNewItem()
        {
            FormEditManufactureShift f=new FormEditManufactureShift(this.cboKho.GetColumnValue("StockCode").ToString());
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.AddNewItem();
            this.ShowChildForm(f);
            if ((this.DataSource as ListBase<ManufactureShift>).Count > 0)
            {
                this.CurrentItem = f.CurrentItem;
            }
            else
            {
                this.CurrentItem = null;
            }
            gridControl.RefreshDataSource();
            this.RefreshButtons();
        }
        protected override void BeforeDelete()
        {
            if (currenFocusGridview == 0)
                base.BeforeDelete();
            else
            {
                if (!this.AllowDeleteOther && !VNS.Context.ContextBase.CurrentUser.IsAdmin)
                {
                    int i = gridView.FocusedRowHandle;
                    GridView gv = (GridView)gridView.GetDetailView(i, 0);
                    if (gv != null)
                    {
                        object obj = (this.CurrentItem as ManufactureShift).ListManufacture[gv.GetDataSourceRowIndex(gv.FocusedRowHandle)];
                        if (obj is UserTracking)
                            if ((obj as UserTracking).UserCreated != VNS.Context.ContextBase.CurrentUser.LoginName)
                            {
                                MessageBox.Show("Bạn không được xóa của người khác!", this.Text);
                                return;
                            }
                    }
                }
                this.Delete();
            }
        }
        protected override void BeforeEditItem()
        {
            if (currenFocusGridview == 0)
                base.BeforeEditItem();
            else
            {
                if (!this.AllowEditOther && !VNS.Context.ContextBase.CurrentUser.IsAdmin)
                {
                    int i = gridView.FocusedRowHandle;
                    GridView gv = (GridView)gridView.GetDetailView(i, 0);
                    if (gv != null)
                    {
                        object obj = (this.CurrentItem as ManufactureShift).ListManufacture[gv.GetDataSourceRowIndex(gv.FocusedRowHandle)];
                        if (obj is UserTracking)
                            if ((obj as UserTracking).UserCreated != VNS.Context.ContextBase.CurrentUser.LoginName)
                            {
                                MessageBox.Show("Bạn không được sửa của người khác!", this.Text);
                                return;
                            }
                    }
                }
                this.EditItem();
            }
        }
        public override void EditItem()
        {
            if (currenFocusGridview == 0)
            {
                FormEditManufactureShift f = new FormEditManufactureShift(this.cboKho.GetColumnValue("StockCode").ToString());
                SetFormPrivilege(f);
                if (this.DataSource != null)
                {
                    f.DataSource = this.DataSource;
                    f.CurrentItem = this.CurrentItem;
                    f.EditItem();
                    this.ShowChildForm(f);
                   if ((this.DataSource as ListBase<ManufactureShift>).Count > 0)
                    {
                        if ((this.CurrentItem as ManufactureShift).Status == 1)
                        {
                            (this.CurrentItem as ManufactureShift).Status = 2;
                        }
                    }
                    else
                    {
                        this.CurrentItem = null;
                    }
                }
                gridControl.RefreshDataSource();
            }
            else
            {
                int i = gridView.FocusedRowHandle;
                GridView gv = (GridView)gridView.GetDetailView(i, 0);
                if (gv != null)
                {
                    FormEditManufactures f = new FormEditManufactures(this.CurrentItem as ManufactureShift);
                    SetFormPrivilege(f);
                    f.DataSource = (this.CurrentItem as ManufactureShift).ListManufacture;
                    if ((this.CurrentItem as ManufactureShift).ListManufacture.Count > 0)
                    {
                        f.CurrentItem = (this.CurrentItem as ManufactureShift).ListManufacture[gv.GetDataSourceRowIndex(gv.FocusedRowHandle)];
                        f.EditItem();
                        this.ShowChildForm(f);
                    }
                }
                gridControl.RefreshDataSource();

            }
        }
       
        private void cboKho_EditValueChanged(object sender, EventArgs e)
        {
            if (this.cboKho.ItemIndex >= 0)
            {
                this.DataSource = new ManufactureShift();
                this.gridControl.DataSource = null;
                this.DataSource = _bllShift.GetObjectByTimeStockCode(startDate, endDate, cboKho.EditValue.ToString());
            }
        }

        private void FormManufactures_Load(object sender, EventArgs e)
        {
            lstPeriods = new PeriodBLL().GetAll();
            this.cboPeriodCode.Properties.DataSource = lstPeriods;
            this.cboPeriodCode.EditValue = Contexts.WorkingPeriod.PeriodCode;

            this.cboKho.Properties.DataSource = (new StockBLL()).GetAllForMember(Contexts.CurrentUser.MemberID);
            this.cboKho.ItemIndex = 0;
            this.ItemLookUpEmployee.DataSource = _EmployeeBLL.GetAll();
       
            if (!Contexts.CurrentUser.IsAdmin)
            {
                if (this.AllowAddNew == false)
                {
                    this.ItemButtonEdit.Buttons[0].Visible = false;
                    this.colStatus.Visible = false;
                }
                if (Contexts.MemberFunctions.Search("FunctionName", FunctionNames.MANUFACTURE_FUNCTION_CREATEST)==null)
                    this.pTaoPX1.Visible = false;
                if (Contexts.MemberFunctions.Search("FunctionName", FunctionNames.MANUFACTURE_FUNCTION_DELETEST) == null)
                    this.pXoaPX2.Visible = false;
            }
            if (this.CurrentItem == null)
            {
                this.btnTaoPX.Enabled = false;
                this.btnXoaPX.Enabled = false;
            }
        }

        private void ItemButtonEdit_ButtonClick(object sender, EventArgs e)
        {
            FormEditManufactures f = new FormEditManufactures(this.CurrentItem as ManufactureShift);
            f.DataSource = (this.CurrentItem as ManufactureShift).ListManufacture;
            f.AddNewItem();
            this.ShowChildForm(f);
            if ((this.DataSource as ListBase<ManufactureShift>).Count > 0)
            {
                if ((this.CurrentItem as ManufactureShift).Status == 1)
                {
                    (this.CurrentItem as ManufactureShift).Status = 2;
                }
            }
            
            gridControl.RefreshDataSource();
            this.RefreshButtons();
        }
        FormSelectSTType formType = new FormSelectSTType();
        private void btnTaoPX_Click(object sender, EventArgs e)
        {
            
            if ((this.CurrentItem as ManufactureShift).Status != 0)
            {
                StockTransactionBLL bll = new StockTransactionBLL();
                if (Contexts.CurrentUser.IsAdmin || Contexts.MemberFunctions.Search("FunctionName", FunctionNames.MANUFACTURE_FUNCTION_CREATESTSPEC) != null)
                {
                    if (formType.ShowDialog() == DialogResult.OK)
                    {
                        if (bll.GetDataFromManufact((this.CurrentItem as ManufactureShift).ManufactureShiftID,formType.SelectResult) != 0)
                        {
                            MessageBox.Show("Tạo phiếu Nhập/Xuất không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            (this.CurrentItem as ManufactureShift).Status = 1;
                            this.gridControl.RefreshDataSource();
                            MessageBox.Show("Phiếu Nhập/Xuất đã được tạo lại.");
                        }
                    }
                }
                else
                {
                    if (bll.TestExitsStockTransactionByGenID_Status((this.CurrentItem as ManufactureShift).ManufactureShiftID, 0) != 1)
                    {
                        DialogResult Str;
                        Str = MessageBox.Show("Phiếu Nhập/Xuất kho ngày " + ((this.CurrentItem as ManufactureShift).ManufactureDate.ToString("dd/MM/yyyy")) + " - Ca " + ((this.CurrentItem as ManufactureShift).Shift).ToString() + " đã tạo, Bạn có muốn tạo lại không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (Str == DialogResult.Yes)
                        {
                            if (bll.TestExitsStockTransactionByGenID_Status((this.CurrentItem as ManufactureShift).ManufactureShiftID, 0) == 1)
                            {
                                MessageBox.Show("Phiếu Nhập/Xuất đã được bộ phận Kho xác nhận, Không tạo lại được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            if (bll.GetDataFromManufact((this.CurrentItem as ManufactureShift).ManufactureShiftID) != 0)
                            {
                                MessageBox.Show("Tạo phiếu Nhập/Xuất không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                (this.CurrentItem as ManufactureShift).Status = 1;
                                this.gridControl.RefreshDataSource();
                                MessageBox.Show("Phiếu Nhập/Xuất đã được tạo lại.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Phiếu Nhập/Xuất đã được bộ phận Kho xác nhận, Không tạo lại được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                StockTransactionBLL bll = new StockTransactionBLL();
                DialogResult Str;
                Str = MessageBox.Show("Bạn sẽ tạo phiếu Nhập/Xuất kho ngày " + (this.CurrentItem as ManufactureShift).ManufactureDate.ToString("dd/MM/yyyy") + " - Ca " + (this.CurrentItem as ManufactureShift).Shift.ToString() + " ?   ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (Str == DialogResult.Yes)
                {
                    if (!Contexts.CurrentUser.IsAdmin || Contexts.MemberFunctions.Search("FunctionName", FunctionNames.MANUFACTURE_FUNCTION_CREATESTSPEC) == null)
                        if (bll.TestExitsStockTransactionByGenID_Status((this.CurrentItem as ManufactureShift).ManufactureShiftID, 0) == 1)
                        {
                            MessageBox.Show("Phiếu Nhập/Xuất đã được bộ phận Kho xác nhận, Không tạo lại được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    if (bll.GetDataFromManufact((this.CurrentItem as ManufactureShift).ManufactureShiftID) != 0)
                    {
                        MessageBox.Show("Tạo phiếu Nhập/Xuất không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        (this.CurrentItem as ManufactureShift).Status = 1;
                        this.gridControl.RefreshDataSource();
                        this.btnXoaPX.Enabled = true;
                        MessageBox.Show("Phiếu nhập/xuất kho tạo thành công.");
                    }

                }
            }
        }

        public override void Delete()
        {
            int ret = 0;
            int i = gridView.FocusedRowHandle;
            GridView gv = (GridView)gridView.GetDetailView(i, 0);
            if (gv != null && currenFocusGridview !=0)
            {
                int j = gv.GetDataSourceRowIndex(gv.FocusedRowHandle);
                if (this.editMode != FormEditMode.ADD)
                {
                    if (MessageBox.Show(this.DeleteConfirm, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ret = _ManufactureBLL.Delete((this.CurrentItem as ManufactureShift).ListManufacture[j].ManufactureID);
                        if (ret == 0)
                        {
                            if ((this.CurrentItem as ManufactureShift).Status == 1)
                                (this.CurrentItem as ManufactureShift).Status = 2;
                            gv.DeleteRow(gv.FocusedRowHandle);
                        }
                        else
                            OnError(ret, ErrorMessageType.DELETE);
                    }
                }
            }
            else
            {
                DialogResult Str;
                Str = MessageBox.Show("Bạn muốn xóa ngày " + (this.CurrentItem as ManufactureShift).ManufactureDate.ToString("dd/MM/yyyy") + " - Ca " + (this.CurrentItem as ManufactureShift).Shift.ToString() + " ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (Str == DialogResult.Yes)
                {
                    ret = _bllShift.Delete(this.CurrentItem as ManufactureShift);
                    if (ret == 0)
                    {
                        this.gridView.DeleteRow(gridView.FocusedRowHandle);
                    }
                    else
                        OnError(ret, ErrorMessageType.DELETE);
                }
                this.RefreshButtons();
            }
        }
      

        private void btnXoaPX_Click(object sender, EventArgs e)
        {
            int ret = 0;
            if ((this.CurrentItem as ManufactureShift).Status != 0)
            {
                StockTransactionBLL bll = new StockTransactionBLL();
                if (bll.TestExitsStockTransactionByGenID_Status((this.CurrentItem as ManufactureShift).ManufactureShiftID, 0) != 1)
                {
                    DialogResult Str;
                    Str = MessageBox.Show("Bạn muốn xoá phiếu Nhập/Xuất kho ngày " + (this.CurrentItem as ManufactureShift).ManufactureDate.ToString("dd/MM/yyyy")+ " - Ca " + (this.CurrentItem as ManufactureShift).Shift.ToString() + " ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (Str == DialogResult.Yes)
                    {
                        ret = bll.DeleteByGenID((this.CurrentItem as ManufactureShift).ManufactureShiftID);
                        if (ret == 0)
                        {
                            ret = _ManufactureBLL.UpdateManufactureShiftStatus((this.CurrentItem as ManufactureShift).ManufactureShiftID, 0);
                            if (ret == 0)
                            {
                                (this.CurrentItem as ManufactureShift).Status = 0;
                                this.gridControl.RefreshDataSource();
                                this.btnXoaPX.Enabled = false;
                                MessageBox.Show("Phiếu Nhập/Xuất đã được xóa.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Xóa phiếu Nhập/Xuất không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Phiếu Nhập/Xuất đã được Kho xác nhận, Không xoá được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
           
        }

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (this.gridView.RowCount > 0)
            {
                this.btnTaoPX.Enabled = true;
                ChangedButtonbtnXoaPX();
            }
            else
            {
                this.RefreshButtons();
                this.gridControl.RefreshDataSource();
                this.CurrentItem = null;
                this.btnTaoPX.Enabled = false;
                this.btnXoaPX.Enabled = false;
            }
        }
        private void ChangedButtonbtnXoaPX()
        {
            CurrencyManager cr = this.BindingContext[this.gridControl.DataSource] as CurrencyManager;
            if ((cr.Current as ManufactureShift).Status != 0)
            {
                this.btnXoaPX.Enabled = true;
               
            }
            else
            {
                this.btnXoaPX.Enabled = false;
            
            }
        }

        private void gridView_GotFocus(object sender, EventArgs e)
        {
            currenFocusGridview = 0;
        }

        private void gridView1_GotFocus(object sender, EventArgs e)
        {
            currenFocusGridview = 1;
        }
        public override void RefreshButtons()
        {
            base.RefreshButtons();
            this.navigatorFrmEditBase.Visible = false;
        }

        private void gridView_DoubleClick1()//(object sender, EventArgs e)
        {
            //if (lockDoubleClick)
            //    return;
            FormEditManufactureShift f = new FormEditManufactureShift(this.cboKho.GetColumnValue("StockCode").ToString());
            SetFormPrivilege(f);
            if (this.DataSource != null)
            {
                f.DataSource = this.DataSource;
                f.CurrentItem = this.CurrentItem;
                this.ShowChildForm(f);
                if ((this.DataSource as ListBase<ManufactureShift>).Count > 0)
                {
                    if ((this.CurrentItem as ManufactureShift).Status == 1)
                    {
                        (this.CurrentItem as ManufactureShift).Status = 2;
                    }
                }
                else
                {
                    this.CurrentItem = null;
                }
            }
            gridControl.RefreshDataSource();
        }
        bool lockDoubleClick = false;
        private void gridView1_DoubleClick1()//(object sender, EventArgs e)
        {
            lockDoubleClick = true;
            //MessageBox.Show(currenFocusGridview.ToString());
            int i = gridView.FocusedRowHandle;
            GridView gv = (GridView)gridView.GetDetailView(i, 0);
            if (gv != null)
            {
                Manufacture mn = (this.CurrentItem as ManufactureShift).ListManufacture[gv.GetDataSourceRowIndex(gv.FocusedRowHandle)];
                FormEditManufactures f = new FormEditManufactures(this.CurrentItem as ManufactureShift);
                SetFormPrivilege(f);
                f.DataSource = (this.CurrentItem as ManufactureShift).ListManufacture;
                if ((this.CurrentItem as ManufactureShift).ListManufacture.Count > 0)
                {
                    f.CurrentItem = mn;
                    this.ShowChildForm(f);
                }
            }
            //MessageBox.Show(currenFocusGridview.ToString());
            //gridControl.RefreshDataSource();
            //MessageBox.Show(currenFocusGridview.ToString());
            lockDoubleClick = false;
        }

        private void cboPeriodCode_EditValueChanged(object sender, EventArgs e)
        {
            if (this.cboKho.ItemIndex != -1)
            {
                this.DataSource = new ManufactureShift();
                startDate=lstPeriods[this.cboPeriodCode.ItemIndex].StartDate;
                endDate =lstPeriods[this.cboPeriodCode.ItemIndex].EndDate;
                this.gridControl.DataSource = null;
                this.DataSource = _bllShift.GetObjectByTimeStockCode(startDate, endDate, cboKho.EditValue.ToString());
            }
        }
        private void ShowMasterDetailRows()
        {
            for (int i = 0; i < gridView.RowCount; i++)
                gridView.SetMasterRowExpanded(i, true);

        }
        private void btnLoadData_Click(object sender, EventArgs e)
        {
            if (this.btnLoadData.Text == "+")
            {
                ShowMasterDetailRows();
                this.btnLoadData.Text = "-";
                this.btnLoadData.ToolTip = "Collapse All";
            }
            else
            {
                this.gridView.CollapseAllDetails();
                this.btnLoadData.Text = "+";
                this.btnLoadData.ToolTip = "Expand All";
            }
        }

        private void gridControl_DoubleClick(object sender, EventArgs e)
        {
            if (currenFocusGridview == 0)
                this.gridView_DoubleClick1();
            else
                this.gridView1_DoubleClick1();
        }
    }
}