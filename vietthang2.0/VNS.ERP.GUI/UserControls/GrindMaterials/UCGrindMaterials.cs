using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.ERP.Data;
using VNS.ERP.Data.Grinds;
using VNS.Common;
using VNS.Windows;
using System.Collections;

namespace VNS.ERP.GUI
{
    public partial class UCGrindMaterials : EditControlBase
    {
        private ItemBLL itemBLL;
        public GrindMaterialShift CurrentShift;
        public string stockCode;
        public UCGrindMaterials()
        {
            InitializeComponent();
        }

        protected override void BindData()
        {

            if (CurrentShift != null)
            {
                this.cboKho.EditValue = CurrentShift.StockCode;
                this.cboCa.Value = CurrentShift.Shift;
                this.cboNgay.EditValue = CurrentShift.GrindDate;
            }

            GrindMaterials obj = dataSource as GrindMaterials;
            this.cboLoai.EditValue = obj.GrindCode;
            this.cboCongthuc.EditValue = obj.FormulaCode;
            this.txtNap.EditValue = obj.Nap;
            this.txtSoluong.EditValue = obj.MaterialWeight;
            this.txtBaobihu.EditValue = obj.WrappingWaste;
            this.txtBaobi.EditValue = obj.Wrapping;
            this.txtDescription.Text = obj.Description;
            this.txtPlanNo.Text = obj.PlanNo;

            this.txtLine.EditValue = obj.LinesxNo;
            this.cboNguoinghien.EditValue = obj.EmployeeID1;
            this.cboNguoiep.EditValue = obj.EmployeeID2;
            this.txtAm.EditValue = obj.Am;
            this.cboStartTime.DateTime = obj.StartTime;
            this.cboEndTime.DateTime = obj.EndTime;
            this.txtDelayTime.EditValue = obj.DTDelayTime;

            if (obj.LstDieuchinh == null)
            {
                //GrindMaterials grind = (dataSource as GrindMaterials);
                //grind.LstDieuchinh = new ListBase<GrindMaterialTransactions>();
                (new GrindMaterialBLL()).GetGrindMaterialDetail(obj);
            }
            this.gridControl.DataSource = obj.LstDieuchinh;

            this.gridNhienlieu.DataSource = obj.LstNhienlieu;
            this.gridPhepham.DataSource = obj.LstPhepham;
            this.gridTaiche.DataSource = obj.LstTaiche;

            this.cboLoai.Focus();

        }
        protected override int ValidateData()
        {
            if (this.cboKho.Text == string.Empty)
            {
                this.cboKho.Focus();
                return -1;
            }
            if (this.cboCa.Text == string.Empty)
            {
                this.cboCa.Focus();
                return -2;
            }
            if (this.cboLoai.Text == string.Empty)
            {
                this.cboLoai.Focus();
                return -3;
            }
            if (this.cboCongthuc.Text == string.Empty)
            {
                this.cboCongthuc.Focus();
                return -4;
            }

            return 0;
        }
        protected override void AssignData()
        {
          
                if (dataSource == null)
                    dataSource = new GrindMaterials();
                GrindMaterials grind = (dataSource as GrindMaterials);

              //  grind.LstDieuchinh = new ListBase<GrindMaterialTransactions>();
                grind.GrindCode = this.cboLoai.EditValue.ToString();
                grind.FormulaCode = this.cboCongthuc.EditValue.ToString();
                grind.Nap = ((decimal)(this.txtNap.EditValue));
                grind.MaterialWeight = ((decimal)(this.txtSoluong.EditValue));
                grind.Wrapping = ((decimal)(this.txtBaobi.EditValue));
                grind.WrappingWaste = ((decimal)(this.txtBaobihu.EditValue));
                grind.Description = this.txtDescription.Text;
                grind.GrindMaterialShiftID = CurrentShift.GrindMaterialShiftID;
              //  grind.LstDieuchinh = (ListBase<GrindMaterialTransactions>)this.gridControl.DataSource;


                grind.PlanNo = this.txtPlanNo.Text;


                grind.LinesxNo = Convert.ToInt32(this.txtLine.EditValue.ToString());
                grind.EmployeeID1 = this.cboNguoinghien.GetColumnValue("EmployeeID").ToString();
                grind.EmployeeID2 = this.cboNguoiep.GetColumnValue("EmployeeID").ToString();
                grind.Am = (decimal)this.txtAm.EditValue;
                grind.StartTime = this.cboStartTime.DateTime;
                grind.EndTime = this.cboEndTime.DateTime;
                grind.DTDelayTime = (DateTime)(this.txtDelayTime.EditValue);
           
        }
        private void cboLoai_EditValueChanged(object sender, EventArgs e)
        {

            if (cboLoai.EditValue != null)
            {
                this.cboCongthuc.Properties.DataSource = null;
                this.cboCongthuc.Properties.DataSource = (new MaterialFormularDetailBLL()).GetFormularCode(this.cboLoai.GetColumnValue("ItemCode").ToString());
                this.cboCongthuc.ItemIndex = 0;
            }
        }

        private void txtSoluong_Validated(object sender, EventArgs e)
        {

            decimal _Baobi = 0;
            if (this.EditMode != FormEditMode.VIEW)
            {
                Item _item = (itemBLL).GetUnitWeight(this.cboLoai.EditValue.ToString());
                if (_item.UnitWeight != 0)
                {

                    _Baobi = (((decimal)(this.txtSoluong.EditValue)) / _item.UnitWeight);
                    this.txtBaobi.EditValue = _Baobi;
                }
            }
        }

        private void btnNguyenlieu_Click(object sender, EventArgs e)
        {
            DataTable dt;

            if (this.cboLoai.ItemIndex>=0)
            {
                if (this.cboCongthuc.ItemIndex >= 0)
                {
                    dt = (new MaterialFormularDetailBLL()).GetMaterialPCode(this.cboCongthuc.EditValue.ToString(), this.cboLoai.EditValue.ToString(), decimal.Parse(this.txtNap.EditValue.ToString()));
                    ArrayList array = new ArrayList();
                    array.Add(this.cboLoai.GetColumnValue("ItemName").ToString());
                    array.Add(this.cboCongthuc.GetColumnValue("FormulaCode").ToString());
                    array.Add(((decimal)(this.txtNap.EditValue)).ToString(AppConfigs.CONFIG_QUANTITYFORMAT));
                    array.Add(this.cboCa.Value.ToString());
                    array.Add("");
                    array.Add(this.cboKho.Text);
                    array.Add(this.cboNgay.DateTime.ToString(AppConfigs.CONFIG_DATEFORMAT));
                    array.Add("Dang sách nguyên liệu nghiền");
                    FormListNguyenlieu frm = new FormListNguyenlieu();
                    frm.DataTableSouced = dt;
                    frm.ArrayNL = array;
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn công thức!!!", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại thành phẩm !!!", "Error", MessageBoxButtons.OK);
            }
        }

        private void UsrDetailsGrindMaterials_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                itemBLL = new ItemBLL();
                this.cboKho.Properties.DataSource = (new StockBLL()).GetAll();
                ListBase<Item> lstMaterial = itemBLL.GetbyItemtype((int)enumItemType.Material);
                this.cboLoai.Properties.DataSource = lstMaterial;
                this.ItemLookUpDieuchinh.DataSource =
                    //this.ItemLookUpPP.DataSource=
                    this.ItemLookUpTC.DataSource = lstMaterial;

                EmployeeBLL eBLL = new EmployeeBLL();
                this.cboNguoinghien.Properties.DataSource = eBLL.GetByStockCodeAndGroupEmployee(CurrentShift.StockCode, enumEmployeeGroup.EmployeeNghien.ToString());
                this.cboNguoiep.Properties.DataSource = eBLL.GetByStockCodeAndGroupEmployee(CurrentShift.StockCode, enumEmployeeGroup.EmployeeEp.ToString());

                this.ItemLookUpPP.DataSource = itemBLL.GetbyItemtype((int)enumItemType.Waste);

                this.ItemLookUpNL.DataSource = itemBLL.GetbyItemtype((int)enumItemType.Fuel);


                if (!Contexts.CurrentUser.IsAdmin)
                {
                    if (Contexts.MemberFunctions.Search("FunctionName", FunctionNames.GRIND_FUNCTION_VIEWDETAILMATERIAL) == null)
                        this.btnNguyenlieu.Visible = false;
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
            bool view = this.EditMode == FormEditMode.VIEW;

            this.cboCa.Properties.ReadOnly =
                this.cboNgay.Properties.ReadOnly = true;

            this.txtBaobihu.Properties.ReadOnly =
            this.txtDescription.Properties.ReadOnly =
            this.txtNap.Properties.ReadOnly =
            this.txtSoluong.Properties.ReadOnly =
            this.cboCongthuc.Properties.ReadOnly =
            this.cboLoai.Properties.ReadOnly = view;



            this.txtPlanNo.Properties.ReadOnly = view;
            this.gridView.OptionsBehavior.Editable =
            this.gridViewNhienlieu.OptionsBehavior.Editable =
                this.gridViewPhepham.OptionsBehavior.Editable =
                this.gridViewTaiche.OptionsBehavior.Editable = !view;

            this.txtLine.Properties.ReadOnly =
                this.cboNguoinghien.Properties.ReadOnly =
                this.cboNguoiep.Properties.ReadOnly =
                this.txtAm.Properties.ReadOnly =
                this.cboStartTime.Properties.ReadOnly =
                this.cboEndTime.Properties.ReadOnly =
                this.txtDelayTime.Properties.ReadOnly = view;

       }
    }
}
