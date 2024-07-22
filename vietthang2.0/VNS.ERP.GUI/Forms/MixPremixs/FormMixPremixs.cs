using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Premixs;
using VNS.Common;
using VNS.Windows;
using System.Collections;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;

namespace VNS.ERP.GUI
{
    public partial class FormMixPremixs : FormEditBase
    {
        private MixPremixBLL _MixPremixBLL = new MixPremixBLL();
        private MixPremixShiftBLL bllShift = new MixPremixShiftBLL();
        private int currenFocusGridview = 0;
        private ListBase<Period> lstPeriods = null;
        private DateTime startDate = Contexts.WorkingStartDate;
        private DateTime endDate = Contexts.WorkingEndDate;
        public FormMixPremixs()
        {
            InitializeComponent();
            this.Business = _MixPremixBLL;
            this.ItemButtonEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(ItemButtonEdit_ButtonClick);
            this.ItemLookStatus.DataSource = EnumDisplays.GetListStatusManufactureShift();
        }



        public override void AddNewItem()
        {
            FormMixPremixShifts f = new FormMixPremixShifts(this.cbokho.GetColumnValue("StockCode").ToString());
            f.DataSource = this.DataSource;
            f.AddNewItem();
            this.ShowChildForm(f);
            if ((this.DataSource as ListBase<MixPremixShift>).Count > 0)
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

            }
            else
            {
                int i = gridView.FocusedRowHandle;
                GridView gv = (GridView)gridView.GetDetailView(i, 0);
                if (gv != null)
                {
                    FormEditMixPremixs f = new FormEditMixPremixs((this.CurrentItem as MixPremixShift));
                    SetFormPrivilege(f);
                    f.DataSource = (this.CurrentItem as MixPremixShift).LstMixPremix;
                    if ((this.CurrentItem as MixPremixShift).LstMixPremix.Count > 0)
                    {
                        f.CurrentItem = (this.CurrentItem as MixPremixShift).LstMixPremix[gv.GetDataSourceRowIndex(gv.FocusedRowHandle)];
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
                this.DataSource = new MixPremixShift();
                this.gridControl.DataSource = null;
                this.DataSource = bllShift.GetObjectByTimeStockCode(startDate, endDate, cbokho.EditValue.ToString());
            }
        }

        private void FormMixPremixs_Load(object sender, EventArgs e)
        {
            lstPeriods = new PeriodBLL().GetAll();
            this.cboPeriodCode.Properties.DataSource = lstPeriods;
            this.cboPeriodCode.EditValue = Contexts.WorkingPeriod.PeriodCode;

            this.cbokho.Properties.DataSource = (new StockBLL()).GetAllForMember(Contexts.CurrentUser.MemberID);
            this.cbokho.ItemIndex = 0;
            this.btnEdit.Enabled = false;
            if (!Contexts.CurrentUser.IsAdmin)
            {
                if (this.AllowAddNew == false)
                {

                    this.ItemButtonEdit.Buttons[0].Visible = false;
                    this.colStatus.Visible = false;
                }
                if (Contexts.MemberFunctions.Search("FunctionName", FunctionNames.MIXPREMIX_FUNCTION_CREATEST) == null)
                    this.pTaoPX1.Visible = false;
                if (Contexts.MemberFunctions.Search("FunctionName", FunctionNames.MIXPREMIX_FUNCTION_DELETEST) == null)
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
            FormEditMixPremixs f = new FormEditMixPremixs((this.CurrentItem as MixPremixShift));
            f.DataSource = (this.CurrentItem as MixPremixShift).LstMixPremix;
            f.AddNewItem();
            this.ShowChildForm(f);
            if ((this.DataSource as ListBase<MixPremixShift>).Count > 0)
            {
                if ((this.CurrentItem as MixPremixShift).Status == 1)
                {
                    (this.CurrentItem as MixPremixShift).Status = 2;
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
                        ret = _MixPremixBLL.Delete((this.CurrentItem as MixPremixShift).LstMixPremix[j].MixPremixID);
                        if (ret == 0)
                        {
                            if ((this.CurrentItem as MixPremixShift).Status == 1)
                                (this.CurrentItem as MixPremixShift).Status = 2;
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
                Str = MessageBox.Show("Bạn muốn xóa ngày " + (this.CurrentItem as MixPremixShift).MixDate.ToString("dd/MM/yyyy") + " - Ca " + (this.CurrentItem as MixPremixShift).Shift.ToString() + " ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (Str == DialogResult.Yes)
                {
                    ret = bllShift.Delete(this.CurrentItem as MixPremixShift);
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
           
            if ((this.CurrentItem as MixPremixShift).Status != 0)
            {
                StockTransactionBLL bll = new StockTransactionBLL();
                if (bll.TestExitsStockTransactionByGenID_Status((this.CurrentItem as MixPremixShift).MixPremixShiftID, 0) != 1)
                {
                    DialogResult Str;
                    Str = MessageBox.Show("Phiếu Nhập/Xuất kho ngày " + ((this.CurrentItem as MixPremixShift).MixDate.ToString("dd/MM/yyyy")) + " - Ca " + (this.CurrentItem as MixPremixShift).Shift.ToString() + " đã tạo, Bạn có muốn tạo lại không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (Str == DialogResult.Yes)
                    {
                        if (bll.GetDataFromMixPremix((this.CurrentItem as MixPremixShift).MixPremixShiftID) != 0)
                        {
                            MessageBox.Show("Tạo phiếu Nhập/Xuất không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            (this.CurrentItem as MixPremixShift).Status = 1;
                            this.gridControl.RefreshDataSource();
                            this.btnXoaPX.Enabled = true;
                            MessageBox.Show("Phiếu Nhập/Xuất đã được tạo lại.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Phiếu Nhập/Xuất đã được Kho xác nhận, Không tạo lại được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                StockTransactionBLL bll = new StockTransactionBLL();
                DialogResult Str;
                Str = MessageBox.Show("Bạn sẽ tạo phiếu Nhập/Xuất kho ngày " + ((this.CurrentItem as MixPremixShift).MixDate.ToString("dd/MM/yyyy")) + " - Ca " + (this.CurrentItem as MixPremixShift).Shift.ToString() + " ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (Str == DialogResult.Yes)
                {
                    if (bll.GetDataFromMixPremix((this.CurrentItem as MixPremixShift).MixPremixShiftID) != 0)
                    {
                        MessageBox.Show("Tạo phiếu Nhập/Xuất không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        (this.CurrentItem as MixPremixShift).Status = 1;
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
            if ((this.CurrentItem as MixPremixShift).Status != 0)
            {
                StockTransactionBLL bll = new StockTransactionBLL();
                if (bll.TestExitsStockTransactionByGenID_Status((this.CurrentItem as MixPremixShift).MixPremixShiftID, 0) != 1)
                {
                    DialogResult Str;
                    Str = MessageBox.Show("Bạn muốn xoá phiếu Nhập/Xuất kho ngày " + ((this.CurrentItem as MixPremixShift).MixDate.ToString("dd/MM/yyyy")) + " - Ca " + (this.CurrentItem as MixPremixShift).Shift.ToString() + " ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (Str == DialogResult.Yes)
                    {
                        ret = bll.DeleteByGenID((this.CurrentItem as MixPremixShift).MixPremixShiftID);
                        if (ret == 0)
                        {
                            ret = _MixPremixBLL.UpdateStatusMixPremixShift((this.CurrentItem as MixPremixShift).MixPremixShiftID, 0);
                            if (ret == 0)
                            {
                                (this.CurrentItem as MixPremixShift).Status = 0;
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
                    MessageBox.Show("Phiếu Nhập/Xuất đã được bộ phận Kho xác nhận, Không xoá được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ChangedButtonbtnXoaPX()
        {
            CurrencyManager cr = this.BindingContext[this.gridControl.DataSource] as CurrencyManager;
            if ((cr.Current as MixPremixShift).Status != 0)
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
            this.btnEdit.Enabled = false;
            currenFocusGridview = 0;
        }

        private void gridView1_GotFocus(object sender, EventArgs e)
        {
            this.btnEdit.Enabled = true;
            currenFocusGridview = 1;
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
                FormEditMixPremixs f = new FormEditMixPremixs((this.CurrentItem as MixPremixShift));
                SetFormPrivilege(f);
                f.DataSource = (this.CurrentItem as MixPremixShift).LstMixPremix;
                if ((this.CurrentItem as MixPremixShift).LstMixPremix.Count > 0)
                {
                    f.CurrentItem = (this.CurrentItem as MixPremixShift).LstMixPremix[gv.GetDataSourceRowIndex(gv.FocusedRowHandle)];
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
                this.DataSource = new MixPremixShift();
                this.gridControl.DataSource = null;
                this.DataSource = bllShift.GetObjectByTimeStockCode(startDate,endDate, cbokho.EditValue.ToString());
            }
        }
    }
}