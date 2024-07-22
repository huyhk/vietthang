using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.ERP.Data;
using VNS.ERP.Data.Manufactures;
using VNS.Common;
using VNS.Windows;
using VNS.ERP.GUI;
using DevExpress.Utils;
using VNS.Windows.Forms;

namespace VNS.ERP.GUI.Manufactures
{
    public partial class UCManufactures : EditControlBase
    {
        private DataSet ds;
        public ManufactureShift CurrentShift;
        private ManufactureBLL manufactureBLL;
        public UCManufactures()
        {
            InitializeComponent();
            
        }
        protected override void BindData()
        {
            if (CurrentShift != null)
            {
                this.cboKho.EditValue = CurrentShift.StockCode;
                this.cboTruongca.EditValue = CurrentShift.ShiftLeader;
                this.cboPhoca.EditValue = CurrentShift.ViceLeader;
                this.txtCa.Value = CurrentShift.Shift;
                this.cboNgay.EditValue = CurrentShift.ManufactureDate;
            }
            this.cboLoai.EditValue = (dataSource as Manufacture).ProductCode;

            this.lokItemProduct.EditValue = (dataSource as Manufacture).ItemProductCode;
            this.lokItemWrapping.EditValue = (dataSource as Manufacture).ItemWrappingCode;

            this.txtKehoach.EditValue = (dataSource as Manufacture).PlanNo;
            this.txtLine.EditValue = (dataSource as Manufacture).LinesxNo;
            this.cboNguoinghien.EditValue = (dataSource as Manufacture).EmployeeID1;
            this.cboNguoiep.EditValue = (dataSource as Manufacture).EmployeeID2;
            this.cboSize.EditValue = (dataSource as Manufacture).SizeCode;
            this.cboBaobi.EditValue = (dataSource as Manufacture).WeightCode;
            this.cboCongthuc.EditValue = (dataSource as Manufacture).FormulaCode;
            this.txtCongthuc.EditValue = (dataSource as Manufacture).FormulaCode;
            this.txtSoluongNap.EditValue = (dataSource as Manufacture).Nap;
            this.txtSoluong.EditValue = (dataSource as Manufacture).ProductWeight;
            this.txtLot.Text = (dataSource as Manufacture).Lot;
            this.txtEp.EditValue = (dataSource as Manufacture).Ep;
            this.txtDomin.Text = (dataSource as Manufacture).Domin;

            this.txtDocung.EditValue = (dataSource as Manufacture).Docung;
            this.txtTytrong.EditValue = (dataSource as Manufacture).Tytrong;

            this.txtAm.Text = (dataSource as Manufacture).Am;
            this.txtTilebot.Text = (dataSource as Manufacture).Tilebot;
            this.txtCodeBaoTP.Text = (dataSource as Manufacture).CodeBaoTP;
            this.txtBaobihu.EditValue = (dataSource as Manufacture).WrappingWaste;
            this.txtDescription.Text = (dataSource as Manufacture).Description;
            this.txtBaobi.EditValue = (dataSource as Manufacture).Wrapping;
            this.cboStartTime.DateTime = (dataSource as Manufacture).StartTime;
            this.cboEndTime.DateTime = (dataSource as Manufacture).EndTime;
            this.txtElectricity.EditValue = (dataSource as Manufacture).Electricity;
            this.txtDelayTime.EditValue = (dataSource as Manufacture).DTDelayTime;
                if ((dataSource as Manufacture).LstTaiche == null)
                {
                    Manufacture manu = (dataSource as Manufacture);
                    manu.LstTaiche = new ListBase<ManufactureTransaction>();
                    manu.LstNhienlieu = new ListBase<ManufactureTransaction>();
                    manu.LstDieuchinh = new ListBase<ManufactureTransaction>();
                    manu.LstPhepham = new ListBase<ManufactureTransaction>();
                    manu.LstMaterialIn = new ListBase<ManufactureTransaction>();
                    manu.LstWrappingIn = new ListBase<ManufactureTransaction>();
                    (new ManufactureBLL()).GetManufactureDetail(manu);
                }
            this.gridTaiche.DataSource = (dataSource as Manufacture).LstTaiche;
            this.gridNhienlieu.DataSource = (dataSource as Manufacture).LstNhienlieu;
            this.gridDieuchinh.DataSource = (dataSource as Manufacture).LstDieuchinh;
            this.gridPhepham.DataSource = (dataSource as Manufacture).LstPhepham;
            this.gridControlMaterialIn.DataSource = (dataSource as Manufacture).LstMaterialIn;

            this.chkIsSilo.Checked = (dataSource as Manufacture).IsSilo;
            this.txtFabNo.EditValue = (dataSource as Manufacture).FabNo;
            this.txtCodePremix.EditValue = (dataSource as Manufacture).CodePremix;

            if ((dataSource as Manufacture).LstManuTranCompare == null)
            {
                (dataSource as Manufacture).LstManuTranCompare = new ListBase<ManuTranCompare>();
                this.RefreshCompare();
            }
            this.gridControlCompare.DataSource = (dataSource as Manufacture).LstManuTranCompare;
        }
        protected override int ValidateData()
        {
            if (this.cboKho.Text == String.Empty)
            {
                this.cboKho.Focus();
                return -1;
            }
            if (this.txtCa.Text == String.Empty)
            {
                this.txtCa.Focus();
                return -2;
            }
            if (this.txtLine.Text == String.Empty)
            {
                this.txtLine.Focus();
                return -3;
            }
            if (this.cboTruongca.Text == String.Empty)
            {
                this.cboTruongca.Focus();
                return -4;
            }
            if (this.cboNguoinghien.Text == String.Empty)
            {
                this.cboNguoinghien.Focus();
                return -5;
            }
            if (this.cboNguoiep.Text == String.Empty)
            {
                this.cboNguoiep.Focus();
                return -6;
            }
            if (this.cboLoai.Text == String.Empty)
            {
                this.cboLoai.Focus();
                return -7;
            }
            if (this.cboSize.Text == String.Empty)
            {
                this.cboSize.Focus();
                return -8;
            }
            if (this.cboBaobi.Text == String.Empty)
            {
                this.cboBaobi.Focus();
                return -9;
            }
            if (this.cboCongthuc.Text == String.Empty)
            {
                this.cboCongthuc.Focus();
                return -10;
            }
            if (this.cboEndTime.DateTime < this.cboStartTime.DateTime)
            {
                this.cboEndTime.Focus();
                return -11;
            }
            int totalDelay=int.Parse(((DateTime)(this.txtDelayTime.EditValue)).TimeOfDay.TotalMinutes.ToString());
            if ((int)(this.cboEndTime.DateTime.Subtract(this.cboStartTime.DateTime).TotalMinutes) < totalDelay)
            {
                this.txtDelayTime.Focus();
                return -12;
            }
            return 0;
        }

        private int ValidateDataHeader()
        {
            if (this.txtLine.Text == String.Empty)
            {
                this.txtLine.Focus();
                return -3;
            }
            if (this.cboNguoinghien.Text == String.Empty)
            {
                this.cboNguoinghien.Focus();
                return -5;
            }
            if (this.cboNguoiep.Text == String.Empty)
            {
                this.cboNguoiep.Focus();
                return -6;
            }
            return 0;
        }
        protected override void AssignData()
        {
            Manufacture manu = (dataSource as Manufacture);
            if (chckEditmanufacture.Checked == true)
            {
                manu.ItemProductCode = this.lokItemProduct.EditValue.ToString();

                manu.LinesxNo = this.txtLine.EditValue.ToString().Trim();
                manu.EmployeeID1 = this.cboNguoinghien.GetColumnValue("EmployeeID").ToString();
                manu.EmployeeID2 = this.cboNguoiep.GetColumnValue("EmployeeID").ToString();
                manu.Lot = this.txtLot.Text;
                manu.Ep = (decimal)(this.txtEp.EditValue);
                manu.Domin = this.txtDomin.Text;

                manu.Docung = (decimal)this.txtDocung.EditValue;
                manu.Tytrong = (decimal)this.txtTytrong.EditValue;

                manu.Am = this.txtAm.Text;
                manu.Tilebot = this.txtTilebot.Text;
                manu.CodeBaoTP = this.txtCodeBaoTP.Text;
                manu.Description = this.txtDescription.Text.Trim();
                if (this.cboStartTime.DateTime == DateTime.MinValue || this.cboEndTime.DateTime == DateTime.MinValue)
                {
                    manu.StartTime = this.cboNgay.DateTime;
                    manu.EndTime = this.cboNgay.DateTime;
                }
                else
                {
                    manu.StartTime = this.cboStartTime.DateTime;
                    manu.EndTime = this.cboEndTime.DateTime;
                }
                manu.PlanNo = this.txtKehoach.Text;
                manu.Electricity = (decimal)(this.txtElectricity.EditValue);
                manu.DTDelayTime = (DateTime)(this.txtDelayTime.EditValue);

                manu.FabNo = this.txtFabNo.Text;
                manu.CodePremix = this.txtCodePremix.Text;
            }
            else
            {
                manu.LstTaiche = new ListBase<ManufactureTransaction>();
                manu.LstNhienlieu = new ListBase<ManufactureTransaction>();
                manu.LstDieuchinh = new ListBase<ManufactureTransaction>();
                manu.LstPhepham = new ListBase<ManufactureTransaction>();
                manu.ManufactureShiftID = CurrentShift.ManufactureShiftID;
                manu.ProductCode = this.cboLoai.GetColumnValue("ProductCode").ToString();

                manu.ItemProductCode = this.lokItemProduct.EditValue.ToString();
                if (this.lokItemWrapping.EditValue != null)
                    manu.ItemWrappingCode = this.lokItemWrapping.EditValue.ToString();

                manu.LinesxNo = this.txtLine.EditValue.ToString().Trim();
                manu.EmployeeID1 = this.cboNguoinghien.GetColumnValue("EmployeeID").ToString();
                manu.EmployeeID2 = this.cboNguoiep.GetColumnValue("EmployeeID").ToString();
                manu.SizeCode = this.cboSize.GetColumnValue("SizeCode").ToString();
                manu.WeightCode = this.cboBaobi.GetColumnValue("WeightCode").ToString();
                manu.FormulaCode = this.cboCongthuc.GetColumnValue("FormulaCode").ToString();

                this.txtCongthuc.EditValue = manu.FormulaCode;

                manu.Nap = (decimal)(this.txtSoluongNap.EditValue);
                manu.ProductWeight = (decimal)(this.txtSoluong.EditValue);
                manu.Lot = this.txtLot.Text;
                manu.Ep = (decimal)(this.txtEp.EditValue);
                manu.Domin = this.txtDomin.Text;

                manu.Docung = (decimal)this.txtDocung.EditValue;
                manu.Tytrong = (decimal)this.txtTytrong.EditValue;

                manu.Am = this.txtAm.Text;
                manu.Tilebot = this.txtTilebot.Text;
                manu.CodeBaoTP = this.txtCodeBaoTP.Text;
                try
                { manu.WrappingWaste = (decimal)(this.txtBaobihu.EditValue); }
                catch { manu.WrappingWaste = 0; }
                try { manu.Wrapping = (decimal)(this.txtBaobi.EditValue); }
                catch { manu.Wrapping = 0; }
                
                manu.Description = this.txtDescription.Text.Trim();
                if (this.cboStartTime.DateTime == DateTime.MinValue || this.cboEndTime.DateTime == DateTime.MinValue)
                {
                    manu.StartTime = this.cboNgay.DateTime;
                    manu.EndTime = this.cboNgay.DateTime;
                }
                else
                {
                    manu.StartTime = this.cboStartTime.DateTime;
                    manu.EndTime = this.cboEndTime.DateTime;
                }
                //tri
                this.gridViewTaiche.CloseEditor();
                this.gridViewTaiche.RefreshData();
                this.gridViewTaiche.UpdateSummary();
                this.gridViewDieuchinh.CloseEditor();
                this.gridViewDieuchinh.UpdateSummary();
                this.gridViewNhienlieu.CloseEditor();
                this.gridViewNhienlieu.UpdateSummary();
                this.gridViewPhepham.CloseEditor();
                this.gridViewPhepham.RefreshData();
                this.gridViewPhepham.UpdateSummary();

                this.gridViewMaterialIn.CloseEditor();
                manu.IsSilo = this.chkIsSilo.Checked;
                //
                manu.PlanNo = this.txtKehoach.Text;
                manu.Electricity = (decimal)(this.txtElectricity.EditValue);
                
                manu.Phepham = (decimal)(this.colQuantityPP.SummaryItem.SummaryValue);
                manu.Taiche = (decimal)(this.colQuantityTC.SummaryItem.SummaryValue);
                manu.DTDelayTime = (DateTime)(this.txtDelayTime.EditValue);
                manu.LstTaiche = (ListBase<ManufactureTransaction>)this.gridTaiche.DataSource;
                manu.LstNhienlieu = (ListBase<ManufactureTransaction>)this.gridNhienlieu.DataSource;
                manu.LstDieuchinh = (ListBase<ManufactureTransaction>)this.gridDieuchinh.DataSource;
                manu.LstPhepham = (ListBase<ManufactureTransaction>)this.gridPhepham.DataSource;

                manu.FabNo = this.txtFabNo.Text;
                manu.CodePremix = this.txtCodePremix.Text;
            }
        }

        public override bool Save()
        {
            if (this.chckEditmanufacture.Checked == false)
               return base.Save();
            else
            {
                int ret = 0;
                if (this.dataSource != null)
                {
                    ErrorMessageType messageType = ErrorMessageType.VALIDATE;

                    ret = ValidateDataHeader();
                    if (ret != 0)
                    {
                        OnError(ret, messageType);
                        return false;
                    }
                    AssignData();
                    if (this.editMode == FormEditMode.EDIT)
                    {
                        messageType = ErrorMessageType.UPDATE;
                        ret = manufactureBLL.UpdateHeader(this.dataSource as Manufacture);
                    }
                    if (ret != 0)
                    {

                        OnError(ret, messageType);
                        return false;

                    }
                    else
                    {
                        (dataSource as ObjectBase).EndEdit2();
                        this.OnDataChanged();
                    }
                 
                }
            }
            return true;
        }
        
        private void txtSoluong_Validated(object sender, EventArgs e)
        {

            decimal _Baobi = 0;
            if (this.EditMode != FormEditMode.VIEW)
            {

                if ((decimal)this.cboBaobi.GetColumnValue("Weight") != 0)// && (decimal)(this.txtSoluong.EditValue) != 0)
                {
                    _Baobi = ((decimal)(this.txtSoluong.EditValue) / ((decimal)(this.cboBaobi.GetColumnValue("Weight"))));
                    
                }
                this.txtBaobi.EditValue = _Baobi;
            }
        }
        private void DetailsManufactures_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {

                
                this.lokItemProduct.Properties.DataSource = (new ItemBLL()).GetbyItemtype((int)enumItemType.Product);
                this.lokItemWrapping.Properties.DataSource = (new ItemBLL()).GetbyItemtype((int)enumItemType.Wrapping);

                EmployeeBLL _EmployeeBLL = new EmployeeBLL();
                ItemBLL _ItemBLL = new ItemBLL();
                manufactureBLL = new ManufactureBLL();
                this.cboKho.Properties.DataSource = (new StockBLL()).GetAll();
                this.cboTruongca.Properties.DataSource = this.cboPhoca.Properties.DataSource = _EmployeeBLL.GetByStockCodeAndGroupEmployee(CurrentShift.StockCode, enumEmployeeGroup.EmployeeTruongCa.ToString());
                this.cboNguoinghien.Properties.DataSource = _EmployeeBLL.GetByStockCodeAndGroupEmployee(CurrentShift.StockCode, enumEmployeeGroup.EmployeeNghien.ToString());
                this.cboNguoiep.Properties.DataSource = _EmployeeBLL.GetByStockCodeAndGroupEmployee(CurrentShift.StockCode, enumEmployeeGroup.EmployeeEp.ToString());
                this.cboLoai.Properties.DataSource = (new ProductBLL()).GetAll();
                this.ItemLookUpDC.DataSource =
                    this.repMaterialInItemCode.DataSource = this.repMatInItemName.DataSource =
                    this.repCPItemCode.DataSource = this.repCPItemName.DataSource = _ItemBLL.GetAll();// .GetDynamic("ItemType in (" + ((int)enumItemType.Material).ToString() + "," + ((int)enumItemType.Premix).ToString() + ")", "");
                this.ItemLookUpNL.DataSource = _ItemBLL.GetbyItemtype((int)enumItemType.Fuel);
                this.ItemLookUpPP.DataSource = _ItemBLL.GetbyItemtype((int)enumItemType.Waste);
                this.ItemLookUpTC.DataSource = _ItemBLL.GetDynamic("ItemType in (" + ((int)enumItemType.Waste).ToString() + "," + ((int)enumItemType.Product).ToString() + ")", "");//.GetbyItemtype((int)enumItemType.Waste);
                if (this.editMode == FormEditMode.ADD)
                {
                    if (this.txtSoluong.EditValue != null && (decimal)this.cboBaobi.GetColumnValue("Weight") != 0)
                    {
                        decimal _Baobi = ((decimal)(this.txtSoluong.EditValue) / ((decimal)(this.cboBaobi.GetColumnValue("Weight"))));
                        this.txtBaobi.EditValue = _Baobi;
                    }
                    else
                        this.txtBaobi.EditValue = 0;
                }
                if (!Contexts.CurrentUser.IsAdmin)
                {
                    if (Contexts.MemberFunctions.Search("FunctionName", FunctionNames.MANUFACTURE_FUNCTION_VIEWDETAILMATERIAL) == null)
                        this.btnNguyenlieu.Visible = false;
                }
            }
        }
        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (this.editMode == FormEditMode.EDIT)
            {
                if ((decimal)(this.txtSoluong.EditValue) != 0 && (decimal)this.cboBaobi.GetColumnValue("Weight") != 0)
                {
                    decimal _Baobi = ((decimal)(this.txtSoluong.EditValue) / ((decimal)(this.cboBaobi.GetColumnValue("Weight"))));
                    this.txtBaobi.EditValue = _Baobi;
                }
                else
                    this.txtBaobi.EditValue = 0;
                this.cboStartTime.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
                this.cboStartTime.Properties.DisplayFormat.FormatType = FormatType.DateTime;
                this.cboStartTime.Properties.EditMask = "dd/MM/yyyy HH:mm";
                this.cboEndTime.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
                this.cboEndTime.Properties.DisplayFormat.FormatType = FormatType.DateTime;
                this.cboEndTime.Properties.EditMask = "dd/MM/yyyy HH:mm";
            }
            if (this.editMode == FormEditMode.ADD)
            {
                this.cboStartTime.DateTime = this.cboNgay.DateTime;
                this.cboEndTime.DateTime = this.cboNgay.DateTime;
                this.cboStartTime.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
                this.cboStartTime.Properties.DisplayFormat.FormatType = FormatType.DateTime;
                this.cboStartTime.Properties.EditMask = "dd/MM/yyyy HH:mm";
                this.cboEndTime.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
                this.cboEndTime.Properties.DisplayFormat.FormatType = FormatType.DateTime;
                this.cboEndTime.Properties.EditMask = "dd/MM/yyyy HH:mm";
            }
        }

        private void btnNguyenlieu_Click(object sender, EventArgs e)
        {
            ProductFormulaDetailBLL _ProductFormulaDetailBLL = new ProductFormulaDetailBLL();
            DataTable dt;
            if (this.cboLoai.ItemIndex != -1)
                {
                    if (this.cboSize.ItemIndex != -1)
                    {
                        if (this.cboBaobi.ItemIndex != -1)
                        {
                            if (this.cboCongthuc.ItemIndex != -1)
                            {
                                dt = _ProductFormulaDetailBLL.GetDetailForWeight(this.cboLoai.EditValue.ToString(), this.cboCongthuc.EditValue.ToString(), decimal.Parse(this.txtSoluongNap.EditValue.ToString()));
                                ArrayList array = new ArrayList();

                                array.Add(this.cboLoai.GetColumnValue("ProductName").ToString());
                                array.Add(this.cboCongthuc.GetColumnValue("FormulaCode").ToString());
                                array.Add(decimal.Parse(this.txtSoluongNap.EditValue.ToString()).ToString("###,###,###,##0.00"));
                                array.Add(this.txtCa.Value.ToString());
                                array.Add(this.txtLine.Text);
                                array.Add(this.cboKho.Text);
                                array.Add(this.cboNgay.DateTime.ToString("dd/MM/yyyy"));
                                array.Add("Danh sách nguyên liệu sản xuất");

                                FormListNguyenlieu frm = new FormListNguyenlieu();
                                frm.DataTableSouced = dt;
                                frm.ArrayNL = array;
                                frm.ShowDialog();
                            }
                            else
                                 MessageBox.Show("Vui lòng chọn công thức!", "Lỗi", MessageBoxButtons.OK);
              
                        }
                        else
                            MessageBox.Show("Vui lòng chọn Loại bao bì!", "Lỗi", MessageBoxButtons.OK);
                    }
                    else
                        MessageBox.Show("Vui lòng chọn Size!", "Lỗi", MessageBoxButtons.OK);
               
                }
                else
                    MessageBox.Show("Vui lòng chọn loại thành phẩm !", "Lỗi", MessageBoxButtons.OK);
        }

        private void cboLoai_EditValueChanged(object sender, EventArgs e)
        {
                try
                {
                    this.cboBaobi.Properties.DataSource = null;
                    this.cboSize.Properties.DataSource = null;
                    this.cboCongthuc.Properties.DataSource = null;
                    ds = manufactureBLL.Select_WCode_SCode_FCode_by_ProductCode(this.cboLoai.EditValue.ToString());
                    this.cboBaobi.Properties.DataSource = ds.Tables[1];
                    this.cboSize.Properties.DataSource = ds.Tables[0];
                    if (this.EditMode != FormEditMode.ADD)
                    {
                        DataView dv = (ds.Tables[2]).DefaultView;
                        dv.Sort = "FormulaCode";
                        if (dv.Find((this.DataSource as Manufacture).FormulaCode)>=0)
                        { }
                        else
                        {
                            if ((this.DataSource as Manufacture).ProductCode == this.cboLoai.EditValue.ToString())
                            {
                                DataRow dr = ds.Tables[2].NewRow();
                                dr["FormulaCode"] = (this.DataSource as Manufacture).FormulaCode;
                                ds.Tables[2].Rows.InsertAt(dr, 0);
                            }
                        }
                    }
                    this.cboCongthuc.Properties.DataSource = ds.Tables[2];
                    this.cboSize.ItemIndex = 0;
                    this.cboCongthuc.ItemIndex = 0;
                    this.cboBaobi.ItemIndex = 0;
                }
                catch
                { }
        }

        private void btnKehoach_Click(object sender, EventArgs e)
        {
            string []fields={"PlanNo","PlanDate"};
            string[] header ={ "Số phiếu", "Ngày"};
            FormSearch frm = new FormSearch((new ManufacturePlanBLL()).GetManufacturePlanByStockCode(this.cboKho.EditValue.ToString()), fields, header);
            frm.ShowDialog();
            if (this.editMode == FormEditMode.ADD || this.editMode == FormEditMode.EDIT)
            {
                if (frm.SearchResult != null)
                {
                    this.txtKehoach.Text = (frm.SearchResult as ManufacturePlan).PlanNo;
                }
            }
        }
        public override void RefreshControl()
        {
            SetStatus();
            base.RefreshControl();
         
        }
        private void SetStatus()
        {
            if (this.EditMode == FormEditMode.VIEW)
            {

                setStatusDetailManufacture(true);
                this.gridViewTaiche.OptionsBehavior.Editable = false;
                this.gridViewNhienlieu.OptionsBehavior.Editable = false;
                this.gridViewDieuchinh.OptionsBehavior.Editable = false;
                this.gridViewPhepham.OptionsBehavior.Editable = false;
                this.chckEditmanufacture.Visible = false;
                this.btnKehoach.Enabled = false;
            }
            if (this.EditMode == FormEditMode.EDIT)
            {
                setStatusDetailManufacture(false);
                this.gridViewTaiche.OptionsBehavior.Editable = true;
                this.gridViewNhienlieu.OptionsBehavior.Editable = true;
                this.gridViewDieuchinh.OptionsBehavior.Editable = true;
                this.gridViewPhepham.OptionsBehavior.Editable = true;
                this.btnKehoach.Enabled = true;
                this.chckEditmanufacture.Visible = true;
                this.txtLine.Focus();

            }
            if (this.EditMode == FormEditMode.ADD)
            {
                setStatusDetailManufacture(false);
                this.gridViewTaiche.OptionsBehavior.Editable = true;
                this.gridViewNhienlieu.OptionsBehavior.Editable = true;
                this.gridViewDieuchinh.OptionsBehavior.Editable = true;
                this.gridViewPhepham.OptionsBehavior.Editable = true;
                this.btnKehoach.Enabled = true;
                this.chckEditmanufacture.Visible = false;
                this.txtLine.Focus();
            }
            this.chckEditmanufacture.Checked = false;
            this.gridViewMaterialIn.OptionsBehavior.Editable = this.EditMode != FormEditMode.VIEW && this.chkIsSilo.Checked;
        }

        private void setStatusDetailManufacture(bool flat)
        {
            this.cboKho.Properties.ReadOnly = true;
            this.cboTruongca.Properties.ReadOnly = this.cboPhoca.Properties.ReadOnly = true;
            this.txtCa.Properties.ReadOnly = true;
            this.cboNgay.Properties.ReadOnly = true;
            this.cboLoai.Properties.ReadOnly = flat;

            this.lokItemProduct.Properties.ReadOnly = flat;
            this.lokItemWrapping.Properties.ReadOnly = flat;

            this.txtLine.Properties.ReadOnly = flat;
            this.cboNguoinghien.Properties.ReadOnly = flat;
            this.cboNguoiep.Properties.ReadOnly = flat;
            this.cboSize.Properties.ReadOnly = flat;
            this.cboBaobi.Properties.ReadOnly = flat;
            this.cboCongthuc.Properties.ReadOnly = flat;

            this.cboCongthuc.Visible = !flat;
            this.txtCongthuc.Visible = flat;

            this.txtSoluongNap.Properties.ReadOnly = flat;
            this.txtSoluong.Properties.ReadOnly = flat;
            this.txtLot.Properties.ReadOnly = flat;
            this.txtEp.Properties.ReadOnly = flat;
            this.txtDomin.Properties.ReadOnly = flat;

            this.txtDocung.Properties.ReadOnly = flat;
            this.txtTytrong.Properties.ReadOnly = flat;

            this.txtCodePremix.Properties.ReadOnly = flat;
            this.txtTilebot.Properties.ReadOnly = flat;
            this.txtCodeBaoTP.Properties.ReadOnly = flat;
            this.txtBaobihu.Properties.ReadOnly = flat;
            this.txtDescription.Properties.ReadOnly = flat;
            this.txtBaobi.Properties.ReadOnly = true;
            this.cboStartTime.Properties.ReadOnly = flat;
            this.cboEndTime.Properties.ReadOnly = flat;
            this.txtElectricity.Properties.ReadOnly = flat;
            this.txtDelayTime.Properties.ReadOnly = flat;

            this.chkIsSilo.Properties.ReadOnly = flat;
            this.txtFabNo.Properties.ReadOnly = flat;
            this.txtAm.Properties.ReadOnly = flat;
        }

        private void cboBaobi_EditValueChanged(object sender, EventArgs e)
        {
            decimal _Baobi = 0;
            if (this.EditMode != FormEditMode.VIEW)
            {

                if ((decimal)this.cboBaobi.GetColumnValue("Weight") != 0)// && (decimal)(this.txtSoluong.EditValue) != 0)
                {
                    _Baobi = ((decimal)(this.txtSoluong.EditValue) / ((decimal)(this.cboBaobi.GetColumnValue("Weight"))));
                    
                }
                this.txtBaobi.EditValue = _Baobi;
            }
        }

        private void chkIsSilo_CheckedChanged(object sender, EventArgs e)
        {
            this.gridViewMaterialIn.OptionsBehavior.Editable = this.EditMode != FormEditMode.VIEW && this.chkIsSilo.Checked;
        }

        private void btnRefreshCompare_Click(object sender, EventArgs e)
        {
            this.RefreshCompare();
        }
        private void RefreshCompare()
        {
            ProductFormulaDetailBLL _ProductFormulaDetailBLL = new ProductFormulaDetailBLL();
            DataTable dt;
            if (this.cboLoai.ItemIndex != -1)
            {
                if (this.cboSize.ItemIndex != -1)
                {
                    if (this.cboBaobi.ItemIndex != -1)
                    {
                        if (this.cboCongthuc.ItemIndex != -1)
                        {

                            dt = _ProductFormulaDetailBLL.GetDetailForWeight(this.cboLoai.EditValue.ToString(), this.cboCongthuc.EditValue.ToString(), decimal.Parse(this.txtSoluongNap.EditValue.ToString()));
                            Manufacture mn = this.dataSource as Manufacture;

                            mn.LstManuTranCompare.Clear();
                            foreach (ManufactureTransaction mt in mn.LstMaterialIn)
                            {
                                ManuTranCompare cp = new ManuTranCompare();
                                cp.ItemCode = mt.ItemCode;
                                cp.Quantity = mt.Quantity;
                                mn.LstManuTranCompare.Add(cp);
                            }
                            foreach (ManufactureTransaction mt in mn.LstDieuchinh)
                            {
                                ManuTranCompare cp = mn.LstManuTranCompare.Search("ItemCode", mt.ItemCode);
                                if (cp == null)
                                {
                                    cp = new ManuTranCompare();
                                    cp.ItemCode = mt.ItemCode;
                                    mn.LstManuTranCompare.Add(cp);
                                }
                                cp.Quantity += mt.Quantity;
                            }
                            foreach (DataRow row in dt.Rows)
                            {
                                string itemCode = (string)row["MaterialCode"];
                                decimal quantity = (decimal)row["Weight"];

                                ManuTranCompare cp = mn.LstManuTranCompare.Search("ItemCode", itemCode);
                                if (cp == null)
                                {
                                    cp = new ManuTranCompare();
                                    cp.ItemCode = itemCode;
                                    mn.LstManuTranCompare.Add(cp);
                                }
                                cp.FormulaQuantity = quantity;
                            }
                        }
                    }
                }
            }
        }

    }
}
