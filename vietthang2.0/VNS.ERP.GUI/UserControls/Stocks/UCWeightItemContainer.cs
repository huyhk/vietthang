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
using VNS.Windows;

namespace VNS.ERP.GUI.UserControl
{
    public partial class UCWeightItemContainer : EditControlBase
    {
        public delegate void NextWeight(object sender, EventArgs e);
        public event NextWeight OnNextWeight;
        private string stockCode = string.Empty;
        public string StockCode
        {
            set 
            { 
                stockCode=value;
                lookUpStock.EditValue = value;
                if (!this.DesignMode)
                {
                    lookUpStockLocation.Properties.DataSource = new StockLocationBLL().GetByStockCode(stockCode);
                }
            }
        }
        public string TransactionType
        {
            get { return txtTransactionTypeCode.Text; }
        }
        public string StockName
        {
            get { return lookUpStock.GetColumnValue("StockName").ToString(); }
        }
        public string ItemName
        {
            get { return txtItemName.Text; }
        }
        public string CustomerName
        {
            get { return lookUpEditDVNhan.GetColumnValue("SubjectName").ToString(); }
        }
        public string VendorName
        {
            get { return lookUpEditDVGiao.GetColumnValue("SubjectName").ToString(); }
        }
        public string EmployeeName
        {
            get { return lookUpEmp.GetColumnValue("EmployeeName").ToString(); }
        }
        private bool bindingData = false;
        public UCWeightItemContainer()
        {
            InitializeComponent();
        }
        private bool isReceive = true;
        public bool IsReceive
        {
            get { return isReceive; }
            set 
            { 
                isReceive = value;
                lbDVGiao.Visible = value;
                lookUpEditDVGiao.Visible = value;
                lbDVNhan.Visible = !value;
                lookUpEditDVNhan.Visible = !value;
                if (!isReceive)
                {
                    lbDVNhan.Left = lbDVGiao.Left;
                    lookUpEditDVNhan.Left = lookUpEditDVGiao.Left;
                    if (!this.DesignMode)
                    {
                        lookupTransactionTypeCode.Properties.DataSource = new TransactiontypeBLL().GetByStockTransaction(enumStockTransaction.Out);
                        ListBase<Customer> lstCustomer = new CustomerBLL().GetAll();
                        lstCustomer.Insert(0,new Customer());
                        lookUpEditDVNhan.Properties.DataSource = lstCustomer;
                    }
                }
                else
                {
                    if (!this.DesignMode)
                    {
                        ListBase<Vendor> lstVendor = new VendorBLL().GetAll();
                        lstVendor.Insert(0, new Vendor());
                        lookUpEditDVGiao.Properties.DataSource = lstVendor;
                        lookupTransactionTypeCode.Properties.DataSource = new TransactiontypeBLL().GetByStockTransaction(enumStockTransaction.In);
                    }
                }
            }
        }
        protected override void InitDataObject()
        {
            if (!this.DesignMode)
            {
                lookUpEmp.Properties.DataSource = new EmployeeBLL().GetByStockCodeAndGroupEmployee(this.stockCode, enumEmployeeGroup.EmployeeWeight.ToString());
                lookUpItem.Properties.DataSource = new ItemBLL().GetAll();
                ListBase<Stock> lstStock = new StockBLL().GetAllForMember(Contexts.CurrentUser.MemberID);
                lookUpStock.Properties.DataSource = lstStock;
                ListBase<Stock> lstKhoGiaoNhan = new StockBLL().GetAll();// new ListBase<Stock>();
                Stock s = new Stock();
                s.StockCode = string.Empty;
                lstKhoGiaoNhan.Insert(0, s);
                //foreach (Stock st in lstStock)
                //{
                //    s = st.Clone() as Stock;
                //    lstKhoGiaoNhan.Add(s);
                //}
                lookUpEditKhoGiaoNhan.Properties.DataSource = lstKhoGiaoNhan;
                ListBase<Vendor> lstTransport = new VendorBLL().GetForVanchuyen();// new TransportBLL().GetAll();
                lstTransport.Add(new Vendor());
                lookUpEditDVVanChuyen.Properties.DataSource = lstTransport;

                //lookUpStockLocation.Properties.DataSource = new StockLocationBLL().GetByStockCode(

                txtWrappingWeight.Properties.Mask.EditMask = AppConfigs.CONFIG_WEIGHT_WRAPPING_FORMAT;
                txtWrappingWeight.Properties.DisplayFormat.FormatString = AppConfigs.CONFIG_WEIGHT_WRAPPING_FORMAT;
                txtWrappingWeight.Properties.EditFormat.FormatString = AppConfigs.CONFIG_WEIGHT_WRAPPING_FORMAT;

                txtSoBao.Properties.Mask.EditMask = AppConfigs.CONFIG_QUANTITY_PRODUCT_FORMAT1;
                txtSoBao.Properties.DisplayFormat.FormatString = AppConfigs.CONFIG_QUANTITY_PRODUCT_FORMAT1;
                txtSoBao.Properties.EditFormat.FormatString = AppConfigs.CONFIG_QUANTITY_PRODUCT_FORMAT1;

                txtTongBiBao.Properties.Mask.EditMask = AppConfigs.CONFIG_WEIGHT_PRODUCT_FORMAT;
                txtTongBiBao.Properties.DisplayFormat.FormatString = AppConfigs.CONFIG_WEIGHT_PRODUCT_FORMAT;
                txtTongBiBao.Properties.EditFormat.FormatString = AppConfigs.CONFIG_WEIGHT_PRODUCT_FORMAT;

                txtWeight1.Properties.Mask.EditMask = AppConfigs.CONFIG_WEIGHT_PRODUCT_FORMAT;
                txtWeight1.Properties.DisplayFormat.FormatString = AppConfigs.CONFIG_WEIGHT_PRODUCT_FORMAT;
                txtWeight1.Properties.EditFormat.FormatString = AppConfigs.CONFIG_WEIGHT_PRODUCT_FORMAT;

                txtWeight2.Properties.Mask.EditMask = AppConfigs.CONFIG_WEIGHT_PRODUCT_FORMAT;
                txtWeight2.Properties.DisplayFormat.FormatString = AppConfigs.CONFIG_WEIGHT_PRODUCT_FORMAT;
                txtWeight2.Properties.EditFormat.FormatString = AppConfigs.CONFIG_WEIGHT_PRODUCT_FORMAT;

                txtTongTLHang.Properties.Mask.EditMask = AppConfigs.CONFIG_WEIGHT_PRODUCT_FORMAT;
                txtTongTLHang.Properties.DisplayFormat.FormatString = AppConfigs.CONFIG_WEIGHT_PRODUCT_FORMAT;
                txtTongTLHang.Properties.EditFormat.FormatString = AppConfigs.CONFIG_WEIGHT_PRODUCT_FORMAT;
            }
            base.InitDataObject();
        }
        protected override void BindData()
        {
            this.bindingData = true;
            if (this.dataSource != null)
            {
                WeightItemContainer wic = this.dataSource as WeightItemContainer;
                //lookUpStock.EditValue = wic.StockCode;
                txtWeightCode.Text = wic.WeightCode;
                dEdit.DateTime = wic.WeightDate;
                lookupTransactionTypeCode.EditValue = wic.TransactionTypeCode;
                txtWrappingType.Text = wic.WrappingType;
                txtWrappingWeight.EditValue = wic.WrappingWeight;
                txtSoBao.EditValue = wic.Quantity;
                txtTongBiBao.EditValue = wic.TotalWrappingWeight;
                lookUpEditKhoGiaoNhan.EditValue = wic.KhoGiaoNhan;
                lookUpEditDVGiao.EditValue = wic.DVGiao;
                lookUpEditDVNhan.EditValue = wic.DVNhan;
                lookUpItem.EditValue = wic.ItemCode;
                lookUpEmp.EditValue = wic.EmployeeID;
                txtWeight1.EditValue = wic.Weight1;
                txtWeight2.EditValue = wic.Weight2;
                dateEditWeight1.DateTime = wic.WeightTime1;
                dateEditWeight2.DateTime = wic.WeightTime2;
                txtDescription.Text = wic.Description;
                txtTongTLHang.EditValue = wic.ItemWeight;
                txtPTVanChuyen.Text = wic.PTVanChuyen;
                txtPTTayBoa.Text = wic.PTTrungChuyen;
                lookUpEditDVVanChuyen.EditValue = wic.DVVanChuyen;
                lookUpStockLocation.EditValue = wic.StockLocationCode;
                lookUpStockLocation2.EditValue = wic.StockLocationCode2;

                txtPalletWeight.EditValue = wic.PalletWeight;
                txtLuot.EditValue = wic.Luot;
            }
            this.bindingData = false;
            base.BindData();
        }
        public void BindData2()
        {
            this.BindData();
        }
        protected override void AssignData()
        {
            if (this.DataSource == null) this.DataSource = new WeightItemContainer();
            WeightItemContainer wic = this.DataSource as WeightItemContainer;
            wic.IsReceive = this.isReceive;
            wic.StockCode = lookUpStock.EditValue.ToString();// this.stockCode;
            wic.WeightCode = txtWeightCode.Text;
            wic.WeightDate = dEdit.DateTime;
            wic.TransactionTypeCode = lookupTransactionTypeCode.EditValue.ToString();
            wic.WrappingType = txtWrappingType.Text;
            wic.WrappingWeight = Convert.ToDecimal(txtWrappingWeight.EditValue);
            wic.Quantity = Convert.ToDecimal(txtSoBao.EditValue);
            wic.KhoGiaoNhan = lookUpEditKhoGiaoNhan.EditValue.ToString();
            if (this.isReceive)
            {
                wic.DVGiao = lookUpEditDVGiao.EditValue.ToString();
            }
            else
            {
                wic.DVNhan = lookUpEditDVNhan.EditValue.ToString();
            }
            wic.ItemCode = lookUpItem.EditValue.ToString();
            wic.EmployeeID = lookUpEmp.EditValue.ToString();
            wic.Weight1 = Convert.ToDecimal(txtWeight1.EditValue);
            wic.Weight2 = Convert.ToDecimal(txtWeight2.EditValue);
            wic.WeightTime1 = dateEditWeight1.DateTime;
            wic.WeightTime2 = dateEditWeight2.DateTime;
            wic.Description = txtDescription.Text;
            wic.PTVanChuyen = txtPTVanChuyen.Text;
            wic.PTTrungChuyen = txtPTTayBoa.Text;
            wic.DVVanChuyen = lookUpEditDVVanChuyen.EditValue.ToString();
            wic.StockLocationCode = lookUpStockLocation.EditValue.ToString();
            wic.StockLocationCode2 = lookUpStockLocation2.EditValue.ToString();

            wic.PalletWeight = Convert.ToDecimal(txtPalletWeight.EditValue);
            wic.Luot = Convert.ToInt32(txtLuot.EditValue);

            if (this.EditMode == FormEditMode.ADD)
            {
                wic.UserCreated = Contexts.CurrentUser.LoginName;
                wic.DateCreated = DateTime.Now;
            }
            wic.UserUpdated = Contexts.CurrentUser.LoginName;
            wic.DateUpdated = DateTime.Now;
            base.AssignData();
        }
        protected override int ValidateData()
        {
            if (lookUpStock.EditValue == null)
            {
                lookUpStock.Focus();
                return -1;
            }
            txtWeightCode.Text = txtWeightCode.Text.Trim();
            if (txtWeightCode.Text == string.Empty)
            {
                txtWeightCode.Focus();
                return -2;
            }
            if (lookupTransactionTypeCode.EditValue == null)
            {
                lookupTransactionTypeCode.Focus();
                return -3;
            }
            txtWrappingType.Text = txtWrappingType.Text.Trim();
            if (Convert.ToDecimal(txtWrappingWeight.EditValue) < 0)
            {
                txtWrappingWeight.Focus();
                return -4;
            }
            if (Convert.ToDecimal(txtSoBao.EditValue) < 0)
            {
                txtSoBao.Focus();
                return -5;
            }
            if (Convert.ToDecimal(txtWeight1.EditValue) < 0)
            {
                txtWeight1.Focus();
                return -6;
            }
            if (Convert.ToDecimal(txtWeight2.EditValue) < 0)
            {
                txtWeight2.Focus();
                return -7;
            }
            if (lookUpItem.EditValue == null)
            {
                lookUpItem.Focus();
                return -8;
            }
            if (lookUpEmp.EditValue == null)
            {
                lookUpEmp.Focus();
                return -9;
            }
            if (lookUpStockLocation.EditValue == null)
            {
                lookUpStockLocation.Focus();
                return -10;
            }
            txtDescription.Text = txtDescription.Text.Trim();
            txtPTVanChuyen.Text = txtPTVanChuyen.Text.Trim();
            txtPTTayBoa.Text = txtPTTayBoa.Text.Trim();
            return base.ValidateData();
        }
        public override void RefreshControl()
        {
            bool viewMode = this.EditMode == VNS.Windows.FormEditMode.VIEW;
            lookUpStock.Properties.ReadOnly = true;
            lookUpStockLocation.Properties.ReadOnly = viewMode;
            lookUpStockLocation2.Properties.ReadOnly = viewMode;
            txtWeightCode.Properties.ReadOnly = viewMode;
            dEdit.Properties.ReadOnly = viewMode;
            lookupTransactionTypeCode.Properties.ReadOnly = viewMode;
            txtWrappingType.Properties.ReadOnly = viewMode;
            txtWrappingWeight.Properties.ReadOnly = viewMode;
            txtSoBao.Properties.ReadOnly = viewMode;
            lookUpEditKhoGiaoNhan.Properties.ReadOnly = viewMode;
            lookUpEditDVGiao.Properties.ReadOnly = viewMode;
            lookUpEditDVNhan.Properties.ReadOnly = viewMode;
            lookUpItem.Properties.ReadOnly = viewMode;
            lookUpEmp.Properties.ReadOnly = viewMode;
            txtWeight1.Properties.ReadOnly = viewMode;
            dateEditWeight1.Properties.ReadOnly = viewMode;
            txtWeight2.Properties.ReadOnly = viewMode;
            dateEditWeight2.Properties.ReadOnly = viewMode;
            txtDescription.Properties.ReadOnly = viewMode;
            txtPTVanChuyen.Properties.ReadOnly = viewMode;
            txtPTTayBoa.Properties.ReadOnly = viewMode;
            lookUpEditDVVanChuyen.Properties.ReadOnly = viewMode;
            btnNextWeight.Enabled = viewMode;

            txtPalletWeight.Properties.ReadOnly = viewMode;
            txtLuot.Properties.ReadOnly = viewMode;

            if (this.DataSource == null)
            {
                txtWeightCode.Text = "";
                txtWrappingType.Text = "";
                txtWrappingWeight.EditValue = 0;
                txtSoBao.EditValue = 0;
                txtWeight1.EditValue = 0;
                txtWeight2.EditValue = 0;
                txtDescription.Text = "";
                txtPTTayBoa.Text = "";
                txtPTVanChuyen.Text = "";
            }

            if (this.EditMode == FormEditMode.EDIT)
            {
                if (Contexts.CurrentUser.IsAdmin || Contexts.MemberFunctions.Search("FunctionName", FunctionNames.STOCK_CHANGESTOCK) != null)
                {
                    lookUpStock.Properties.ReadOnly = false;
                }
            }
            base.RefreshControl();
        }
        private void lookupTransactionTypeCode_EditValueChanged(object sender, EventArgs e)
        {
            ListBase<TransactionType> lst = lookupTransactionTypeCode.Properties.DataSource as ListBase<TransactionType>;
            if (lookupTransactionTypeCode.ItemIndex == -1)
            {
                txtTransactionTypeCode.Text = "";
                if (lst.Count > 0)
                {
                    lookupTransactionTypeCode.EditValue = lst[0].TransactionTypeCode;
                }
            }
            else
            {
                TransactionType tt = lst.Search("TransactionTypeCode", lookupTransactionTypeCode.EditValue.ToString());
                if (tt != null)
                {
                    txtTransactionTypeCode.Text = tt.Description;
                }
            }
        }

        private void lookUpStock_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpStock.ItemIndex == -1)
            {
                //ListBase<Stock> lstStock = lookUpStock.Properties.DataSource as ListBase<Stock>;
                //if (lstStock != null && lstStock.Count > 0)
                //{
                //    lookUpStock.EditValue = lstStock[0].StockCode;
                //}
            }
        }

        private void lookUpItem_EditValueChanged(object sender, EventArgs e)
        {
            ListBase<Item> lstItem = lookUpItem.Properties.DataSource as ListBase<Item>;
            if (lookUpItem.ItemIndex == -1)
            {
                txtItemName.Text = "";
                if (lstItem.Count > 0)
                {
                    lookUpItem.EditValue = lstItem[0].ItemCode;
                }
            }
            else
            {
                Item i = lstItem.Search("ItemCode", lookUpItem.EditValue.ToString());
                if (i != null)
                {
                    txtItemName.Text = i.ItemName;
                }
            }
        }

        private void lookUpEmp_EditValueChanged(object sender, EventArgs e)
        {
            ListBase<Employee> lst = lookUpEmp.Properties.DataSource as ListBase<Employee>;
            if (lookUpEmp.ItemIndex == -1)
            {
                txtEmployeeName.Text = "";
                if (lst.Count > 0)
                {
                    lookUpEmp.EditValue = lst[0].EmployeeID;
                }
            }
            else
            {
                Employee emp = lst.Search("EmployeeID", lookUpEmp.EditValue.ToString());
                if (emp != null)
                {
                    txtEmployeeName.Text = emp.EmployeeName;
                }
            }
        }

        private void btnNextWeight_Click(object sender, EventArgs e)
        {
            if (this.OnNextWeight != null) this.OnNextWeight(sender, e);
        }

        private void lookUpStockLocation_EditValueChanged(object sender, EventArgs e)
        {
            ListBase<StockLocation> lst = lookUpStockLocation.Properties.DataSource as ListBase<StockLocation>;
            if (lookUpStockLocation.ItemIndex == -1)
            {
                if (lst.Count > 0)
                    lookUpStockLocation.EditValue = lst[0].StockLocationCode;
            }
        }

        private void txtWrappingWeight_EditValueChanged(object sender, EventArgs e)
        {
            this.RefreshResult();
            //timeEdit1.date
        }
        private void RefreshResult()
        {
            if (!this.bindingData)
            {
                WeightItemContainer wic = this.DataSource as WeightItemContainer;
                if (wic != null)
                {
                    wic.PalletWeight = Convert.ToDecimal(txtPalletWeight.EditValue);
                    wic.WrappingWeight = Convert.ToDecimal(txtWrappingWeight.EditValue);
                    wic.Quantity = Convert.ToDecimal(txtSoBao.EditValue);
                    wic.Weight1 = Convert.ToDecimal(txtWeight1.EditValue);
                    wic.Weight2 = Convert.ToDecimal(txtWeight2.EditValue);
                    txtTongBiBao.EditValue = wic.TotalWrappingWeight;
                    txtTongTLHang.EditValue = wic.ItemWeight;
                }
            }
        }

        private void txtSoBao_EditValueChanged(object sender, EventArgs e)
        {
            this.RefreshResult();
        }

        private void txtWeight1_EditValueChanged(object sender, EventArgs e)
        {
            this.RefreshResult();
        }

        private void txtWeight2_EditValueChanged(object sender, EventArgs e)
        {
            this.RefreshResult();
        }

        private void txtPalletWeight_EditValueChanged(object sender, EventArgs e)
        {
            this.RefreshResult();
        }

        private void txtWeightCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (this.EditMode == FormEditMode.VIEW)
                return;
            txtWeightCode.Text = new WeightItemContainerBLL().GetNextNo(lookUpStock.EditValue.ToString(), this.dEdit.DateTime,
                this.lookupTransactionTypeCode.EditValue.ToString());
        }

        private void lookUpEditKhoGiaoNhan_EditValueChanged(object sender, EventArgs e)
        {
            lookUpStockLocation2.Properties.DataSource = new StockLocationBLL().GetByStockCode(lookUpEditKhoGiaoNhan.EditValue.ToString());
        }
    }
}
