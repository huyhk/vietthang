using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using VNS.Windows.Controls;
using VNS.ERP.Data;
using VNS.ERP.Data.Premixs;
using VNS.Common;
using VNS.Windows;
using System.Collections;


namespace VNS.ERP.GUI.UserControl
{
    public partial class UCPremixs : EditControlBase
    {
        private ItemBLL itemBLL ;
        public MixPremixShift CurrentShift;
        public string stockCode;
        public UCPremixs()
        {
            InitializeComponent();
          
        }
     
       
        protected override void BindData()
        {
                if (CurrentShift != null)
                {
                    this.cboKho.EditValue = CurrentShift.StockCode;
                    this.cboCa.Value = CurrentShift.Shift;
                    this.cboNgay.EditValue = CurrentShift.MixDate;
                }
                this.cboLoai.EditValue = (dataSource as MixPremix).PremixCode;
                this.cboCongthuc.EditValue = (dataSource as MixPremix).FormulaCode;
                this.txtNap.EditValue = (dataSource as MixPremix).Nap;
                this.txtSoluong.EditValue = (dataSource as MixPremix).PremixWeight;
                this.txtBaobihu.EditValue = (dataSource as MixPremix).WrappingWaste;
                this.txtBaobi.EditValue = (dataSource as MixPremix).Wrapping;
                this.txtDescription.Text = (dataSource as MixPremix).Description;

                this.txtPremixer.Text = (dataSource as MixPremix).Premixer;
                this.txtPremixWrappingCode.Text = (dataSource as MixPremix).PremixWrappingCode;
                this.txtTonPerCode.EditValue = (dataSource as MixPremix).TonPerCode;

                if ((dataSource as MixPremix).LstDieuchinh == null)
                {
                    MixPremix mix = (dataSource as MixPremix);
                    mix.LstDieuchinh = new ListBase<MixPremixTransaction>();
                    (new MixPremixBLL()).GetMixPremixDetail(mix);
                }
                this.gridControl.DataSource = (dataSource as MixPremix).LstDieuchinh;
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
                    dataSource = new MixPremix();
                MixPremix mix = (dataSource as MixPremix);

               // mix.LstDieuchinh = new ListBase<MixPremixTransaction>();
                mix.PremixCode = this.cboLoai.EditValue.ToString();
                mix.FormulaCode = this.cboCongthuc.EditValue.ToString();
                mix.Nap = ((decimal)(this.txtNap.EditValue));
                mix.PremixWeight = ((decimal)(this.txtSoluong.EditValue));
                mix.Wrapping = ((decimal)(this.txtBaobi.EditValue));
                mix.WrappingWaste = ((decimal)(this.txtBaobihu.EditValue));
                mix.Description = this.txtDescription.Text;
                mix.MixPremixShiftID = CurrentShift.MixPremixShiftID;

                mix.Premixer = this.txtPremixer.Text;
                mix.PremixWrappingCode = this.txtPremixWrappingCode.Text;
                mix.TonPerCode = ((decimal)(this.txtTonPerCode.EditValue));
            
       }
          
        private void cboLoai_EditValueChanged(object sender, EventArgs e)
        {
            if (cboLoai.EditValue != null)
            {
                this.cboCongthuc.Properties.DataSource = null;
                if (this.EditMode == FormEditMode.ADD)
                    this.cboCongthuc.Properties.DataSource = (new PremixFormulaDetailBLL()).GetFormulaCode(this.cboLoai.GetColumnValue("ItemCode").ToString(), true);
                else
                    this.cboCongthuc.Properties.DataSource = (new PremixFormulaDetailBLL()).GetFormulaCode(this.cboLoai.GetColumnValue("ItemCode").ToString());
                this.cboCongthuc.ItemIndex = 0;
            }
           
        }

        private void txtSoluong_Validated(object sender, EventArgs e)
        {
            decimal _Baobi = 0;
            if (this.EditMode != FormEditMode.VIEW)
            {
               
                Item _item = itemBLL.GetUnitWeight(this.cboLoai.EditValue.ToString());
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
                if (this.cboCongthuc.ItemIndex>=0 )
                {

                    dt = (new PremixFormulaDetailBLL()).GetMaterialCode(this.cboCongthuc.EditValue.ToString(), this.cboLoai.EditValue.ToString(), decimal.Parse(this.txtNap.EditValue.ToString()));
                    if (dt!=null)
                    {
                        ArrayList array = new ArrayList();
                        array.Add(this.cboLoai.GetColumnValue("ItemName").ToString());
                        array.Add(this.cboCongthuc.GetColumnValue("FormulaCode").ToString());
                        array.Add(((decimal)(this.txtNap.EditValue)).ToString(AppConfigs.CONFIG_QUANTITYFORMAT));
                        array.Add(this.cboCa.Value.ToString());
                        array.Add("");
                        array.Add(this.cboKho.Text);
                        array.Add(this.cboNgay.DateTime.ToString(AppConfigs.CONFIG_DATEFORMAT));
                        array.Add("Danh sách nguyên liệu trộn thuốc");
                        FormListNguyenlieu frm = new FormListNguyenlieu();
                        frm.DataTableSouced = dt;
                        frm.ArrayNL = array;
                        frm.ShowDialog();
                    }
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

        private void UsrDetailsPremixs_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                itemBLL = new ItemBLL();
                this.cboKho.Properties.DataSource = (new StockBLL()).GetAll();
                this.cboLoai.Properties.DataSource = itemBLL.GetbyItemtype((int)enumItemType.Premix);
                this.ItemLookUpDieuchinh.DataSource = itemBLL.GetbyItemtype((int)enumItemType.Material);
                if (!Contexts.CurrentUser.IsAdmin)
                {
                    if (Contexts.MemberFunctions.Search("FunctionName", FunctionNames.MIXPREMIX_FUNCTION_VIEWDETAILMATERIAL) == null)
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
            if (this.EditMode == FormEditMode.VIEW)
            {
                this.txtBaobihu.Properties.ReadOnly = true;
                this.txtDescription.Properties.ReadOnly = true;
                this.txtNap.Properties.ReadOnly = true;
                this.txtSoluong.Properties.ReadOnly = true;
                this.cboCa.Properties.ReadOnly = true;
                this.cboCongthuc.Properties.ReadOnly = true;
                this.cboLoai.Properties.ReadOnly = true;
                this.cboNgay.Properties.ReadOnly = true;

                this.gridView.OptionsBehavior.Editable = false;

                this.txtPremixer.Properties.ReadOnly = true;
                this.txtPremixWrappingCode.Properties.ReadOnly = true;
                this.txtTonPerCode.Properties.ReadOnly = true;

            }
            else if (this.EditMode == FormEditMode.EDIT)
            {
                this.txtBaobihu.Properties.ReadOnly = false;
                this.txtDescription.Properties.ReadOnly = false;
                this.txtNap.Properties.ReadOnly = false;
                this.txtSoluong.Properties.ReadOnly = false;
                this.cboCa.Properties.ReadOnly = true;
                this.cboCongthuc.Properties.ReadOnly = false;
                this.cboLoai.Properties.ReadOnly = false;
                this.cboNgay.Properties.ReadOnly = true;
                this.gridView.OptionsBehavior.Editable = true;

                this.txtPremixer.Properties.ReadOnly = false;
                this.txtPremixWrappingCode.Properties.ReadOnly = false;
                this.txtTonPerCode.Properties.ReadOnly = false;
            }
            else
            {
                this.cboCa.Properties.ReadOnly = true;
                this.cboNgay.Properties.ReadOnly = true;
                this.txtBaobihu.Properties.ReadOnly = false;
                this.txtDescription.Properties.ReadOnly = false;
                this.txtNap.Properties.ReadOnly = false;
                this.txtSoluong.Properties.ReadOnly = false;
                this.cboCongthuc.Properties.ReadOnly = false;
                this.cboLoai.Properties.ReadOnly = false;
                this.gridView.OptionsBehavior.Editable = true;

                this.txtPremixer.Properties.ReadOnly = false;
                this.txtPremixWrappingCode.Properties.ReadOnly = false;
                this.txtTonPerCode.Properties.ReadOnly = false;
            }
        }
    }
}
