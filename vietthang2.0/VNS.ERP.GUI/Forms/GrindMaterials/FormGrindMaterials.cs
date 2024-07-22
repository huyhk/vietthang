using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Grinds;
using VNS.Common;
using VNS.Windows;
using System.Collections;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;

namespace VNS.ERP.GUI
{
    public partial class FormGrindMaterials : FormEditBase
    {

        private GrindMaterialBLL _GrindMaterialBLL = new GrindMaterialBLL();
        private GrindMaterialShiftBLL bllShift = new GrindMaterialShiftBLL();
        private ListBase<Period> lstPeriods = null;
        private DateTime startDate = Contexts.WorkingStartDate;
        private DateTime endDate = Contexts.WorkingEndDate;
        private int currenFocusGridview = 0;

        public FormGrindMaterials()
        {
            InitializeComponent();
            this.Business = _GrindMaterialBLL;
            this.ItemButtonEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(ItemButtonEdit_ButtonClick);
            this.ItemLookStatus.DataSource = EnumDisplays.GetListStatusManufactureShift();
        }
        public override void AddNewItem()
        {
            FormGrindMaterialShifts f = new FormGrindMaterialShifts(this.cbokho.GetColumnValue("StockCode").ToString());
            f.DataSource = this.DataSource;
            f.AddNewItem();
            this.ShowChildForm(f);
            if ((this.DataSource as ListBase<GrindMaterialShift>).Count > 0)
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
        public override void EditItem()
        {
            if (currenFocusGridview == 0)
            {
                FormGrindMaterialShifts f = new FormGrindMaterialShifts(this.cbokho.GetColumnValue("StockCode").ToString());
                f.DataSource = this.DataSource;
                f.CurrentItem = this.CurrentItem;
                f.EditItem();
                this.ShowChildForm(f);

            }
            else
            {
                int i = gridView.FocusedRowHandle;
                GridView gv = (GridView)gridView.GetDetailView(i, 0);
                if (gv != null)
                {
                    FormEditGrindMaterials f = new FormEditGrindMaterials((this.CurrentItem as GrindMaterialShift));
                    SetFormPrivilege(f);
                    f.DataSource = (this.CurrentItem as GrindMaterialShift).LstGrindMaterial;
                    if ((this.CurrentItem as GrindMaterialShift).LstGrindMaterial.Count > 0)
                    {
                        f.CurrentItem = (this.CurrentItem as GrindMaterialShift).LstGrindMaterial[gv.GetDataSourceRowIndex(gv.FocusedRowHandle)];
                        f.EditItem();
                        this.ShowChildForm(f);
                    }
                }
                gridControl.RefreshDataSource();
            }
        }
        private void cbokho_EditValueChanged(object sender, EventArgs e)
        {
            if (this.cbokho.ItemIndex >= 0)
            {
                this.DataSource = new GrindMaterialShift();
                this.gridControl.DataSource = null;
                this.DataSource = bllShift.GetObjectByTimeStockCode(startDate, endDate, cbokho.EditValue.ToString());
            }
        }

        private void FormGrindMaterials_Load(object sender, EventArgs e)
        {
            lstPeriods = new PeriodBLL().GetAll();
            this.cboPeriodCode.Properties.DataSource = lstPeriods;
            this.cboPeriodCode.EditValue = Contexts.WorkingPeriod.PeriodCode;

            cbokho.Properties.DataSource = (new StockBLL()).GetAllForMember(Contexts.CurrentUser.MemberID);
            this.cbokho.ItemIndex = 0;

            this.ItemLookUpEmployee.DataSource = new EmployeeBLL().GetAll();

            //this.btnEdit.Enabled = false;
            if (!Contexts.CurrentUser.IsAdmin)
            {
                if (this.AllowAddNew == false)
                {
                    this.ItemButtonEdit.Buttons[0].Visible = false;
                    this.colStatus.Visible = false;
                }
                if (Contexts.MemberFunctions.Search("FunctionName", FunctionNames.GRIND_FUNCTION_CREATEST) == null)
                    this.pTaoPX1.Visible = false;
                if (Contexts.MemberFunctions.Search("FunctionName", FunctionNames.GRIND_FUNCTION_DELETEST) == null)
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
            FormEditGrindMaterials f = new FormEditGrindMaterials((this.CurrentItem as GrindMaterialShift));
            f.DataSource = (this.CurrentItem as GrindMaterialShift).LstGrindMaterial;
            f.AddNewItem();
            this.ShowChildForm(f);
            if ((this.DataSource as ListBase<GrindMaterialShift>).Count > 0)
            {
                if ((this.CurrentItem as GrindMaterialShift).Status == 1)
                {
                    (this.CurrentItem as GrindMaterialShift).Status = 2;
                }
            }
            gridControl.RefreshDataSource();
            this.RefreshButtons();
        }
        public override void Delete()
        {
            int ret = 0;
            int i = gridView.FocusedRowHandle;
            GridView gv = (GridView)gridView.GetDetailView(i, 0);
            if (gv != null && currenFocusGridview != 0)
            {
                int j = gv.GetDataSourceRowIndex(gv.FocusedRowHandle);
                if (this.editMode != FormEditMode.ADD)
                {
                    if (MessageBox.Show(this.DeleteConfirm, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ret = _GrindMaterialBLL.Delete((this.CurrentItem as GrindMaterialShift).LstGrindMaterial[j].GrindMaterialID);
                        if (ret == 0)
                        {
                            if ((this.CurrentItem as GrindMaterialShift).Status == 1)
                                (this.CurrentItem as GrindMaterialShift).Status = 2;
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
                Str = MessageBox.Show("Bạn muốn xóa ngày " + (this.CurrentItem as GrindMaterialShift).GrindDate.ToString("dd/MM/yyyy") + " - Ca " + (this.CurrentItem as GrindMaterialShift).Shift.ToString() + " ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (Str == DialogResult.Yes)
                {
                    ret = bllShift.Delete(this.CurrentItem as GrindMaterialShift);
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
       

        private void btnTaoPX_Click(object sender, EventArgs e)
        {

            if ((this.CurrentItem as GrindMaterialShift).Status != 0)
            {
                StockTransactionBLL bll = new StockTransactionBLL();
                if (bll.TestExitsStockTransactionByGenID_Status((this.CurrentItem as GrindMaterialShift).GrindMaterialShiftID, 0) != 1)
                {
                    DialogResult Str;
                    Str = MessageBox.Show("Phiếu Nhập/Xuất kho ngày " + ((this.CurrentItem as GrindMaterialShift).GrindDate.ToString("dd/MM/yyyy")) + " - Ca " + ((this.CurrentItem as GrindMaterialShift).Shift).ToString() + " ? " + " đã tạo, Bạn có muốn tạo lại không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (Str == DialogResult.Yes)
                    {
                        if (bll.GetDataFromGrindMaterial((this.CurrentItem as GrindMaterialShift).GrindMaterialShiftID) != 0)
                        {
                            MessageBox.Show("Tạo phiếu Nhập/Xuất không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            (this.CurrentItem as GrindMaterialShift).Status = 1;
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
            else
            {
                StockTransactionBLL bll = new StockTransactionBLL();
                DialogResult Str;
                Str = MessageBox.Show("Bạn sẽ tạo phiếu Nhập/Xuất kho ngày " + ((this.CurrentItem as GrindMaterialShift).GrindDate.ToString("dd/MM/yyyy")) + " - Ca " + (this.CurrentItem as GrindMaterialShift).Shift.ToString() + " ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (Str == DialogResult.Yes)
                {
                    if (bll.GetDataFromGrindMaterial((this.CurrentItem as GrindMaterialShift).GrindMaterialShiftID) != 0)
                    {
                        MessageBox.Show("Tạo phiếu Nhập/Xuất không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        (this.CurrentItem as GrindMaterialShift).Status = 1;
                        this.gridControl.RefreshDataSource();
                        this.btnXoaPX.Enabled = true;
                        MessageBox.Show("Phiếu nhập/xuất kho tạo thành công.");
                    }
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

    
        private void btnXoaPX_Click(object sender, EventArgs e)
        {
            int ret = 0;
            if ((this.CurrentItem as GrindMaterialShift).Status != 0)
            {
                StockTransactionBLL bll = new StockTransactionBLL();
                if (bll.TestExitsStockTransactionByGenID_Status((this.CurrentItem as GrindMaterialShift).GrindMaterialShiftID, 0) != 1)
                {
                    DialogResult Str;
                    Str = MessageBox.Show("Bạn muốn xoá phiếu Nhập/Xuất kho ngày " + ((this.CurrentItem as GrindMaterialShift).GrindDate.ToString("dd/MM/yyyy")) + " - Ca " + (this.CurrentItem as GrindMaterialShift).Shift.ToString() + " ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (Str == DialogResult.Yes)
                    {
                        ret = bll.DeleteByGenID((this.CurrentItem as GrindMaterialShift).GrindMaterialShiftID);
                        if (ret == 0)
                        {
                            ret = _GrindMaterialBLL.UpdateStatusGrindMaterialShift((this.CurrentItem as GrindMaterialShift).GrindMaterialShiftID, 0);
                            if (ret == 0)
                            {
                                (this.CurrentItem as GrindMaterialShift).Status = 0;
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

        private void ChangedButtonbtnXoaPX()
        {
            CurrencyManager cr = this.BindingContext[this.gridControl.DataSource] as CurrencyManager;
            if ((cr.Current as GrindMaterialShift).Status != 0)
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
            //this.btnEdit.Enabled = false;
        }

        private void gridView1_GotFocus(object sender, EventArgs e)
        {
            currenFocusGridview = 1;
            //this.btnEdit.Enabled = true;
        }
        public override void RefreshButtons()
        {
            base.RefreshButtons();
            this.navigatorFrmEditBase.Visible = false;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            int i = gridView.FocusedRowHandle;
            GridView gv = (GridView)gridView.GetDetailView(i, 0);
            if (gv != null)
            {
                FormEditGrindMaterials f = new FormEditGrindMaterials((this.CurrentItem as GrindMaterialShift));
                SetFormPrivilege(f);
                f.DataSource = (this.CurrentItem as GrindMaterialShift).LstGrindMaterial;
                if ((this.CurrentItem as GrindMaterialShift).LstGrindMaterial.Count > 0)
                {
                    f.CurrentItem = (this.CurrentItem as GrindMaterialShift).LstGrindMaterial[gv.GetDataSourceRowIndex(gv.FocusedRowHandle)];
                    this.ShowChildForm(f);
                }
            }
            gridControl.RefreshDataSource();
        }

        private void cboPeriodCode_EditValueChanged(object sender, EventArgs e)
        {
            if (this.cbokho.ItemIndex != -1)
            {
                startDate = lstPeriods[this.cboPeriodCode.ItemIndex].StartDate;
                endDate = lstPeriods[this.cboPeriodCode.ItemIndex].EndDate;
                this.DataSource = new GrindMaterialShift();
                this.gridControl.DataSource = null;
                this.DataSource = bllShift.GetObjectByTimeStockCode(startDate, endDate, cbokho.EditValue.ToString());
            }
        }
    }
}