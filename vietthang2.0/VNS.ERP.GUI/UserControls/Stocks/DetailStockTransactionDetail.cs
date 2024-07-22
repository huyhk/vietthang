using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.Windows;
using VNS.Windows.Forms;
using VNS.Common;
using VNS.ERP.Data;
using VNS.ERP.Data.Sales;
using System.Collections;
using DevExpress.XtraGrid.Views.Grid;
using System.Data.OleDb;

namespace VNS.ERP.GUI.UserControl
{
    public partial class DetailStockTransactionDetail : EditControlBase
    {
        //ListBase<WeightItemContainer> listBaseWIC = null;
        public bool IsOne;
        ListBase<StockTransactionSumDetail> lstBackupDetails = new ListBase<StockTransactionSumDetail>();
        bool allowGetByWeightItem = false;
        public bool IsInStock = false;
        public bool IsOutStock = false;
        public bool IsMove = true;

        protected ParameterStockTransactionGetData _pstgd;
        /// <summary>
        /// Get or set TransactionTypeCode property
        /// </summary>
        public object TransactionTypeCode
        {
            get { return lookupTransactionTypeCode.EditValue; }
            set { lookupTransactionTypeCode.EditValue = value; }
        }
        public string DescriptionTransTypeCode
        {
            get { return txtTransactionTypeCode.Text; }
            
        }
        public bool CheckTransTypeNx3
        {
            get 
            {
                return false;
                //btnCheck
                //colQuantityReg
                //ChkGetByWeightItem
                string transTypeCode = string.Empty;
                if (this.TransactionTypeCode != null)
                {
                    transTypeCode = this.TransactionTypeCode.ToString();
                }
                bool b = (transTypeCode == enumStockTransactionType.N13.ToString());
                b = (b || (transTypeCode == enumStockTransactionType.N23.ToString()));
                b = (b || (transTypeCode == enumStockTransactionType.N33.ToString()));
                return b;
            }
        }
        public void SetLookupEditDVVanChuyenDSr(object obj)
        {
            lookUpEditDVVanChuyen.Properties.DataSource = obj;
            lokDVTC.Properties.DataSource = obj;
        }
        public object DataSourceLookupItem
        {
            get { return LookupItem.DataSource; }
        }
        public string CurrentStockName
        {
            get 
            {
                if ((this.DataSource as StockTransaction).InStock != "")
                {
                    return txtInStockName.Text;
                    //colQuantity.OptionsColumn.ReadOnly
                }
                else
                {
                    return txtOutStockName.Text;
                }
            }
        }
        public string KhoGiaoNhan
        {
            get 
            {
                string s = string.Empty;
                if (lookUpEditKhoGiao.Visible)
                {
                    if (lookUpEditKhoGiao.EditValue != null)
                    {
                        object o = lookUpEditKhoGiao.GetColumnValue("StockName");
                        if (o != null)
                        {
                            s = o.ToString();
                        }
                    }
                }
                if (lookUpEditKhoNhan.Visible)
                {
                    if (lookUpEditKhoNhan.EditValue != null)
                    {
                        object o = lookUpEditKhoNhan.GetColumnValue("StockName");
                        if (o != null)
                        {
                            s = o.ToString();
                        }
                    }
                }
                return s;
            }
        }
        public ParameterStockTransactionGetData PSTGD
        {
            get { return _pstgd; }
            set
            {
                _pstgd = value;
                if (value.CreatedType == enumStockTransactionCreatedType.DefaultValue)
                {
                    //lbShift.Visible = false;
                    txtShift.Text = "0";
                    //txtShift.Visible = false;
                    lbStatus.Visible = false;
                    txtStatus.Visible = false;
                    txtStatus.Text = "0";
                    this.SetLookupTransactionTypeCodeDataSource(new TransactiontypeBLL().GetByStockTransaction(value.StockTransaction));
                }
                else
                {
                    //if(this.EditMode != FormEditMode.VIEW
                    //this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                    this.SetLookupTransactionTypeCodeDataSource(new TransactiontypeBLL().GetAll());
                    lbShift.Visible = true;
                    //txtShift.Text = "0";
                    txtShift.Visible = true;
                    lbStatus.Visible = true;
                    txtStatus.Visible = true;
                 
                    colItemCode.OptionsColumn.ReadOnly = true;
                    //colItemName.ReadOnly = true;
                    //txtStatus.Text = "0";
                }
            }
        }
        
        public DetailStockTransactionDetail()
        {
            allowGetByWeightItem = false;
            //colPriceOut.Visible
            InitializeComponent();
            //btnEditSoDH.Properties.ReadOnly
            //this.btnEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(btnEdit_ButtonClick);
            this.LookupItem.EditValueChanged += new EventHandler(LookupItem_EditValueChanged);
            colItemCode.SortIndex = 0;
            allowGetByWeightItem = true;
            chkConfirm.Top = ChkGetByWeightItem.Top;
            //LookupInLocation.vi
            //chkConfirm.Left = ChkGetByWeightItem.Left;
        }
        protected override void InitDataObject()
        {
            if (!this.DesignMode)
            {
                ListBase<Vessel> lstVessel = new VesselBLL().GetAll();
                lstVessel.Insert(0, new Vessel());
                lookUpEditVesselCode.Properties.DataSource = lstVessel;

                ListBase<TransportRoute> lstRoute = new TransportRouteBLL().GetVCRoute();
                lstRoute.Insert(0, new TransportRoute());
                txtTransportRoute.Properties.DataSource = lstRoute;

                ListBase<TransportRoute> lstTCRoute = new TransportRouteBLL().GetTCRoute();
                lstTCRoute.Insert(0, new TransportRoute());
                txtTCRoute.Properties.DataSource = lstTCRoute;

                this.txtVCItemType.Properties.DataSource = new TransportItemTypeBLL().GetAll();
                this.txtVCType.Properties.DataSource = this.txtTCType.Properties.DataSource = new TransportTypeBLL().GetAll();
            }
            base.InitDataObject();
        }

        //void btnEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        //{
        //    gridControl1.RefreshDataSource();
        //    if (this.EditMode != FormEditMode.VIEW)
        //    {
        //        try
        //        {
        //            StockTransaction st = (this.DataSource as StockTransaction);
        //            CurrencyManager cr = this.BindingContext[this.gridControl1.DataSource] as CurrencyManager;
        //            //gridView1.SourceView
        //            StockTransactionDetail std = new StockTransactionDetail();

                    
        //            std.ItemCode = (cr.Current as StockTransactionDetail).ItemCode;
        //            if (std.ItemCode == string.Empty || std.ItemCode == null || std.ItemCode == "") return;
        //            //std.OutLocation = (cr.Current as StockTransactionDetail).OutLocation;
        //            st.Details.Add(std);
        //        }
        //        catch { }
        //    }
        //    gridControl1.RefreshDataSource();
        //}
        public void SetLookupTransactionTypeCodeDataSource(Object obj)
        {
            this.lookupTransactionTypeCode.Properties.DataSource = obj;
        }
        public void SetLookupEditInStockDataSource(Object obj)
        {
            lookUpInStock.Properties.DataSource = obj;
        }
        public void SetLookupEditOutStockDataSource(Object obj)
        {
            lookUpOutStock.Properties.DataSource = obj;
            //gridView2.OptionsView.NewItemRowPosition
        }
        public void SetLookupEditForDepartmentDataSource(Object obj)
        {
            lookUpEditForDepartment.Properties.DataSource = obj;
        }
        public void SetLookupEditKhoGiaoDSr(object obj)
        {
            lookUpEditKhoGiao.Properties.DataSource = obj;
        }
        public void SetLookupEditKhoNhanDSr(object obj)
        {
            lookUpEditKhoNhan.Properties.DataSource = obj;
        }
        public void SetLookupEditDVGiaoDSr(object obj)
        {
            lookUpEditDVGiao.Properties.DataSource = obj;
        }
        public void SetLookupEditDVNhanDSr(object obj)
        {
            lookUpEditDVNhan.Properties.DataSource = obj;
        }
        public void SetlookupEditDVVanChuyen(object obj)
        {
            lookUpEditDVVanChuyen.Properties.DataSource = obj;
            lokDVTC.Properties.DataSource = obj;
        }
        
        protected override void AssignData()
        {
            if (dataSource == null) dataSource = new StockTransaction();
            StockTransaction st = (dataSource as StockTransaction);
            st.TransactionTypeCode = lookupTransactionTypeCode.EditValue.ToString();
            st.ForDepartment = (byte)lookUpEditForDepartment.EditValue;
            if (lookUpEditVesselCode.EditValue != null)
            {
                st.VesselCode = lookUpEditVesselCode.EditValue.ToString();
            }
            else
            {
                st.VesselCode = string.Empty;
            }
            st.TransportRouteCode = txtTransportRoute.EditValue.ToString();
            st.TCRouteCode = txtTCRoute.EditValue.ToString();
            st.KhoGiaoNhan = string.Empty;
            if (lookUpInStock.EditValue != null && lookUpInStock.EditValue.ToString() != "")
            {
                st.InStock = lookUpInStock.EditValue.ToString();
                if (lookUpEditKhoGiao.EditValue != null)
                {
                    st.KhoGiaoNhan = lookUpEditKhoGiao.EditValue.ToString();
                }
                st.NguoiGiaoNhan = txtNguoiGiao.Text;
                if (lookUpEditDVGiao.EditValue != null)
                {
                    st.DVGiao = lookUpEditDVGiao.EditValue.ToString();
                }
                st.SoHD = btnEditSoHD.Text;
            }
            if (lookUpOutStock.EditValue != null && lookUpOutStock.EditValue.ToString() != "")
            {
                st.OutStock = lookUpOutStock.EditValue.ToString();
                st.NguoiGiaoNhan = txtNguoiNhan.Text;
                if (lookUpEditKhoNhan.EditValue != null)
                {
                    st.KhoGiaoNhan = lookUpEditKhoNhan.EditValue.ToString();
                }
                if (lookUpEditDVNhan.EditValue != null)
                {
                    st.DVNhan = lookUpEditDVNhan.EditValue.ToString();
                }
                st.SoDH = btnEditSoDH.Text;
            }
            if (st.InStock == string.Empty)
            {
                st.InStock = DBNull.Value.ToString();
            }
            if (st.OutStock == string.Empty)
            {
                st.OutStock = DBNull.Value.ToString();
            }
            if (lookUpEditDVVanChuyen.EditValue != null)
            {
                st.DonviVC = lookUpEditDVVanChuyen.EditValue.ToString();
            }
            st.PTVC = txtPTVanChuyen.Text;
            if (lokDVTC.EditValue != null)
                st.DonviTC = lokDVTC.EditValue.ToString();
            st.PTTC = txtPTTC.Text;
            st.CTKemTheo = txtCTKemTheo.Text;

            //111101
            if (txtVCType.EditValue != null)
                st.VCType = txtVCType.EditValue.ToString();
            if (txtVCItemType.EditValue != null)
                st.VCItemType = txtVCItemType.EditValue.ToString();
            if (txtTCType.EditValue != null)
                st.TCType = txtTCType.EditValue.ToString();
            //


            if (this.EditMode == FormEditMode.ADD)
            {
                st.UserCreated = Contexts.CurrentUser.LoginName;
                st.DateCreated = DateTime.Now;
            }
            st.UserUpdated = Contexts.CurrentUser.LoginName;
            st.DateUpdated = DateTime.Now;
            st.Shift = Convert.ToByte(txtShift.EditValue);
            //if (!IsInStock) st.InStock = null;
            //if (!IsOutStock) st.OutStock = null;
            st.TransactionNo = txtTransactionNo.Text;
            st.TransactionDate = dateEditTransaction.DateTime;
            st.GetByWeightItems = ChkGetByWeightItem.Checked;
            st.GetByWeightItemContainer = ChkGetByWeightItemContainer.Checked;

            st.CanmeNo = txtCanmeNo.Text;

            st.Description = txtDescription.Text;
            if (chkConfirm.Checked)
            {
                st.Status = (byte)enumStockTransactionStatus.Confirm; 
            }
            else
            {
                st.Status = (byte)enumStockTransactionStatus.WaitingConfirm; 
            }
            //st.Status = (byte)enumStockTransactionStatus.Confirm;
            //switch (txtStatus.Text)
            //{
            //    case "Đã xác nhận":
            //        st.Status = enumStockTransactionStatus.Confirm;
            //        break;
            //    case "Chưa xác nhận":
            //        st.Status = enumStockTransactionStatus.WaitingConfirm;
            //        break;
            //    case "Cần xác nhận lại":
            //        st.Status = enumStockTransactionStatus.WaitingReConfirm;
            //        break;
            //    default:
            //        break;
            //}
            //st.Status = (enumStockTransactionStatus)Convert.ToByte(txtStatus.Text);
            base.AssignData();
        }
        void LookupItem_EditValueChanged(object sender, EventArgs e)
        {
            string ItemCode = (string)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("ItemCode");
            this.gridView1.SetRowCellValue(this.gridView1.FocusedRowHandle, this.colItemName, ItemCode);
           // this.gridView1.RefreshRow(this.gridView1.FocusedRowHandle);
        }
        private void RefeshStatus()
        {
            //string ttc = string.Empty;
            if (IsInStock)
            {
                //ModuleManufacture mm = new ModuleBLL().GetModuleManufacture();
               
                StockTransaction st = (this.DataSource as StockTransaction);
                if (st != null)
                {
                    if (st.GenType == (byte)enumStockTransactionGenType.InProduct || st.GenType == (byte)enumStockTransactionGenType.InWaste)
                    {
                        this.SetStatusForManufacture();
                    }
                    else
                    {
                        if (st.GenType == (byte)enumStockTransactionGenType.Premix_InPremix)
                        {
                            this.SetStatusForManufacture();
                        }
                        else
                        {
                            if (st.GenType == (byte)enumStockTransactionGenType.Grind_InMaterial)
                            {
                                this.SetStatusForManufacture();
                            }
                            else
                            {
                                this.SetDefaultStatus();
                            }
                        }
                            //this.SetDefaultStatus();
                    }
                    //ttc = (this.DataSource as StockTransaction).TransactionTypeCode;
                }
                //if (ttc == mm.StockTransType_InProduct || ttc == mm.StockTransType_InWaste)
                //{
                //    this.SetStatusForManufacture();
                //}
                //else
                //{
                //    this.SetDefaultStatus();
                //}
            }
            if (IsOutStock)
            {
               // ModuleManufacture mm = new ModuleBLL().GetModuleManufacture();
                
                StockTransaction st = (this.DataSource as StockTransaction);
                if (st != null)
                {
                    if (st.GenType == (byte)enumStockTransactionGenType.OutFuel || st.GenType == (byte)enumStockTransactionGenType.OutMaterial)
                    {
                        this.SetStatusForManufacture();
                    }
                    else
                    {
                        if (st.GenType == (byte)enumStockTransactionGenType.Premix_OutMaterial || st.GenType == (byte)enumStockTransactionGenType.Premix_OutWrapping)
                        {
                            this.SetStatusForManufacture();
                        }
                        else
                        {
                            if (st.GenType == (byte)enumStockTransactionGenType.Grind_OutMaterial || st.GenType == (byte)enumStockTransactionGenType.Grind_OutWrapping)
                            {
                                this.SetStatusForManufacture();
                            }
                            else
                            {
                                this.SetDefaultStatus();
                            }
                        }
                            
                    }
                    //ttc = (this.DataSource as StockTransaction).TransactionTypeCode;
                }
                //if ((this.DataSource as StockTransaction) != null)
                //{
                //    ttc = (this.DataSource as StockTransaction).TransactionTypeCode;
                //}
                //if (ttc == mm.StockTransType_OutMaterial || ttc == mm.StockTransType_OutFuel)
                //{
                //    this.SetStatusForManufacture();
                //}
                //else
                //{
                //    this.SetDefaultStatus();
                //}
            }
            if (IsMove)
            {
                this.SetMoveStatusForRefeshControl();
                lbForDepartment.Visible = false;
                lookUpEditForDepartment.Visible = false;
            }
        }
        protected override void BindData()
        {
            //this.btnEditSoHD
            allowGetByWeightItem = false;
            string InStock = string.Empty;
            string OutStock = string.Empty;
            //this.listBaseWIC = null;
            if (this.DataSource != null)
            {
                InStock = (this.DataSource as StockTransaction).InStock;
                OutStock = (this.DataSource as StockTransaction).OutStock;
            }
          
            if (this.PSTGD.CreatedType != enumStockTransactionCreatedType.DefaultValue)
            {
                lookUpOutStock.EditValue = OutStock;
                lookUpInStock.EditValue = InStock;
                if (InStock == string.Empty || InStock == "" || InStock == null)
                {
                    this.SetOutStockStatus();
                }
                else
                {
                    this.SetInStockStatus();
                }
            }
            else
            {
                this.RefeshStatus();
            }
            if (dataSource != null)
            {
                StockTransaction st = (dataSource as StockTransaction);
                chkDepartmentConfirm.Checked = (st.DepartmentStatus == (byte)enumStockTransactionDepartmentStatus.Confirm);
                chkConfirm.Checked = st.Status == 0;
                lookUpEditForDepartment.EditValue = st.ForDepartment;
                txtShift.Text = st.Shift.ToString();
                lookUpEditVesselCode.EditValue = st.VesselCode;
                txtTransportRoute.EditValue = st.TransportRouteCode;
                txtTCRoute.EditValue = st.TCRouteCode;
                if (this.IsInStock)
                {
                    txtNguoiGiao.Text = (this.DataSource as StockTransaction).NguoiGiaoNhan;
                    txtNguoiNhan.Text = "";
                    lookUpEditKhoGiao.EditValue = (this.DataSource as StockTransaction).KhoGiaoNhan;
                    lookUpEditKhoNhan.EditValue = "";
                }
                else
                {
                    txtNguoiNhan.Text = (this.DataSource as StockTransaction).NguoiGiaoNhan;
                    txtNguoiGiao.Text = "";
                    lookUpEditKhoNhan.EditValue = (this.DataSource as StockTransaction).KhoGiaoNhan;
                    lookUpEditKhoGiao.EditValue = "";
                }
               
                lookUpEditDVGiao.EditValue = (this.DataSource as StockTransaction).DVGiao;
                lookUpEditDVNhan.EditValue = (this.DataSource as StockTransaction).DVNhan;
                btnEditSoDH.Text = (this.DataSource as StockTransaction).SoDH;
                btnEditSoHD.Text = (this.DataSource as StockTransaction).SoHD;
                lookUpEditDVVanChuyen.EditValue = (this.DataSource as StockTransaction).DonviVC;
                txtPTVanChuyen.Text = (this.DataSource as StockTransaction).PTVC;
                //090813
                lokDVTC.EditValue = (this.DataSource as StockTransaction).DonviTC;
                txtPTTC.Text = (this.DataSource as StockTransaction).PTTC;
                //
                //111101
                txtVCType.EditValue = (this.DataSource as StockTransaction).VCType;
                txtVCItemType.EditValue = (this.DataSource as StockTransaction).VCItemType;
                txtTCType.EditValue = (this.DataSource as StockTransaction).TCType;
                //

                txtCTKemTheo.Text = (this.DataSource as StockTransaction).CTKemTheo;
                switch (st.Status)
                {
                    case (byte)enumStockTransactionStatus.Confirm:
                        txtStatus.Text = "Đã xác nhận";
                        break;
                    case (byte)enumStockTransactionStatus.WaitingConfirm:
                        txtStatus.Text = "Chưa xác nhận";
                        break;
                    case (byte)enumStockTransactionStatus.WaitingReConfirm:
                        txtStatus.Text = "Cần xác nhận lại";
                        break;
                    default:
                        break;
                }

                lookupTransactionTypeCode.EditValue = st.TransactionTypeCode;
                
                if (lookupTransactionTypeCode.EditValue == null)
                {
                    try
                    {
                        lookupTransactionTypeCode.EditValue = (lookupTransactionTypeCode.Properties.DataSource as ListBase<TransactionType>)[0].TransactionTypeCode;
                    }
                    catch{}
                }
                if (this.IsMove)
                {
                    lookUpInStock.EditValue = st.InStock;
                    if (lookUpInStock.EditValue == null)
                    {
                        try
                        {
                            lookUpInStock.EditValue = (lookUpInStock.Properties.DataSource as ListBase<Stock>)[0].StockCode;
                        }
                        catch 
                        {
                        }
                    }
                    lookUpOutStock.EditValue = st.OutStock;
                    if (lookUpOutStock.EditValue == null)
                    {
                        try
                        {
                            lookUpOutStock.EditValue = (lookUpInStock.Properties.DataSource as ListBase<Stock>)[0].StockCode;
                        }
                        catch
                        {
                            //CurrencyManager
                        }
                    }
                }
                if (this.editMode != FormEditMode.ADD)
                {
                    lookUpInStock.EditValue = st.InStock;
                    lookUpOutStock.EditValue = st.OutStock;
                }
                txtTransactionNo.Text = st.TransactionNo;
                dateEditTransaction.DateTime = st.TransactionDate;
                ChkGetByWeightItem.Checked = st.GetByWeightItems;
                ChkGetByWeightItemContainer.Checked = st.GetByWeightItemContainer;
                ChkGetByWeightItem.Visible = st.GenID == Guid.Empty;
                ChkGetByWeightItemContainer.Visible = st.GenID == Guid.Empty;
                btnCheck.Visible = ChkGetByWeightItem.Visible;
                btnCheckWeightItemContainer.Visible = ChkGetByWeightItemContainer.Visible;

                txtCanmeNo.Text = st.CanmeNo;
                txtCanmeNo.Visible = this.lblCanme.Visible = st.GenID == Guid.Empty;

                chkDepartmentConfirm.Visible = ChkGetByWeightItem.Visible;
                txtDescription.Text = st.Description;
                if (st.Details == null)
                {
                    if (this.EditMode == FormEditMode.ADD) st.Details = new ListBase<StockTransactionSumDetail>();
                    if (this.EditMode == FormEditMode.VIEW || this.EditMode == FormEditMode.EDIT) st.Details = new StockTransactionBLL().GetDetailsByTransactionID(st.TransactionID);
                }
                //FixTotal = 0;
                if (st.CreatedType != (byte)enumStockTransactionCreatedType.DefaultValue)
                {
                    lstBackupDetails = new ListBase<StockTransactionSumDetail>();
                    foreach (StockTransactionSumDetail stsd in st.Details)
                    {
                        lstBackupDetails.Add((StockTransactionSumDetail)stsd.Clone());
                    }
                
                }
                gridControl1.DataSource = null;
                gridControl1.DataSource = st.Details;
                gridControl1.RefreshDataSource();
            }
          
            //Stock s = new Stock();
            //if (lookUpOutStock.EditValue != null)
            //{
            //    s = (lookUpOutStock.Properties.DataSource as ListBase<Stock>).Search("StockCode", lookUpOutStock.EditValue.ToString());
            //}
            //else
            //{
            //    s = null;
            //}

            //if (s != null)
            //{
            //    if (s.HasLocation && lookUpOutStock.Visible)
            //    {
            //        colOutLocation.Visible = true;
            //    }
            //    else
            //    {
            //        colOutLocation.Visible = false;
            //    }
            //}
          
            //if (lookUpInStock.EditValue != null)
            //{
            //    s = (lookUpInStock.Properties.DataSource as ListBase<Stock>).Search("StockCode", lookUpInStock.EditValue.ToString());
            //}
            //else
            //{
            //    s = null;
            //}

            //if (s != null)
            //{
            //    if (s.HasLocation && lookUpInStock.Visible)
            //    {
            //        colInLocation.Visible = true;
            //    }
            //    else
            //    {
            //        colInLocation.Visible = false;
            //    }
            //}
            //if (!lookUpOutStock.Visible)
            //{
            //    colOutLocation.Visible = false;
            //}
            //if (!lookUpInStock.Visible)
            //{
            //    colInLocation.Visible = false;
            //}
            
           
            this.RefeshColQuantityReadOnly();
          
            base.BindData();
            allowGetByWeightItem = true;
            lookUpOutStock_VisibleChanged(new object(), new EventArgs());
            lookUpInStock_VisibleChanged(new object(), new EventArgs());
            this.RefreshControl();
        }
        /// <summary>
        /// 
        /// </summary>
        public void RefeshColQuantityReadOnly()
        {
            if (this.CheckTransTypeNx3)
            {
                colQuantityReg.OptionsColumn.AllowEdit = false;
                colQuantityReg.OptionsColumn.AllowFocus = false;
                colQuantityReg.OptionsColumn.ReadOnly = true;
                colQuantity.OptionsColumn.AllowEdit = this.EditMode != FormEditMode.VIEW;
                colQuantity.OptionsColumn.AllowFocus = this.EditMode != FormEditMode.VIEW;
                colQuantity.OptionsColumn.ReadOnly = this.EditMode == FormEditMode.VIEW;
                if (ChkGetByWeightItem.Checked || ChkGetByWeightItemContainer.Checked)
                {
                    colQuantity.OptionsColumn.AllowEdit = false;
                    colQuantity.OptionsColumn.AllowFocus = false;
                    colQuantity.OptionsColumn.ReadOnly = true;
                }
            }
            else
            {
                colQuantity.OptionsColumn.AllowEdit = false;
                colQuantity.OptionsColumn.AllowFocus = false;
                colQuantity.OptionsColumn.ReadOnly = true;
                colQuantityReg.OptionsColumn.AllowEdit = this.EditMode != FormEditMode.VIEW;
                colQuantityReg.OptionsColumn.AllowFocus = this.EditMode != FormEditMode.VIEW;
                colQuantityReg.OptionsColumn.ReadOnly = this.EditMode == FormEditMode.VIEW;
            }

            gridView1.OptionsView.ShowDetailButtons = true;
            gridView1.OptionsDetail.EnableMasterViewMode = true;
            if (!colInLocation.Visible && !colOutLocation.Visible)
            {
                //gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                gridView1.OptionsView.ShowDetailButtons = false;
                gridView1.OptionsDetail.EnableMasterViewMode = false;
                if (this.EditMode != FormEditMode.VIEW)
                {
                    if (PSTGD.CreatedType == enumStockTransactionCreatedType.DefaultValue)
                    {
                        if (!ChkGetByWeightItem.Checked || ChkGetByWeightItemContainer.Checked)
                        {
                            colQuantity.OptionsColumn.AllowEdit = true;
                            colQuantity.OptionsColumn.AllowFocus = true;
                            colQuantity.OptionsColumn.ReadOnly = false;

                            colQuantityReg.OptionsColumn.AllowEdit = true;
                            colQuantityReg.OptionsColumn.AllowFocus = true;
                            colQuantityReg.OptionsColumn.ReadOnly = false;
                        }

                    }
                }
            }
        }
        public void SetInStock(string _StockCode)
        {
            lookUpInStock.EditValue = _StockCode;
            //(this.DataSource as StockTransaction).InStock = _StockCode;
        }
        public void SetOutStock(string _StockCode)
        {
            lookUpOutStock.EditValue = _StockCode;
        }
        public void SetInStockStatus()
        {
            lbOutStock.Visible = false;
            lookUpOutStock.Visible = false;
            txtOutStockName.Visible = false;

            lookUpInStock.Properties.ReadOnly = true;
            lbInStock.Visible = true;
            lookUpInStock.Visible = true;
            txtInStockName.Visible = true;

            lbKhoNhan.Visible = false;
            lookUpEditKhoNhan.Visible = false;
            lbKhoGiao.Visible = true;
            lookUpEditKhoGiao.Visible = true;

            lbDVNhan.Visible = false;
            lookUpEditDVNhan.Visible = false;
            lbDVGiao.Visible = true;
            lookUpEditDVGiao.Visible = true;

            lbDVGiao.Visible = true;
            lookUpEditDVGiao.Visible = true;

            lbSoDH.Visible = false;
            btnEditSoDH.Visible = false;
            lbSoHD.Visible = true;
            btnEditSoHD.Visible = true;

            lbNguoiGiao.Visible = true;
            txtNguoiGiao.Visible = true;
            lbNguoiNhan.Visible = false;
            txtNguoiNhan.Visible = false;
            lbNguoiGiao.Left = lbNguoiNhan.Left;
            txtNguoiGiao.Left = txtNguoiNhan.Left;

            lbInStock.Left = lbOutStock.Left;
            lookUpInStock.Left = lookUpOutStock.Left;
            txtInStockName.Left = txtOutStockName.Left;
            colQuantityReg.Visible = true;
            //colQuantityReg.Caption
            //colPriceIn.Visible = true;
            //colAmountIn.Visible = true;
            colPriceOut.Visible = false;
            colAmountOut.Visible = false;
            //IsInStock = true;
            IsOutStock = false;
            IsMove = false;
            if (!lookUpOutStock.Visible)
            {
                colOutLocation.Visible = false;
            }
            if (!lookUpInStock.Visible)
            {
                colInLocation.Visible = false;
            }
            btnEdit.Buttons[0].Visible = false;

            colQuantityReg.Caption = "SL giao";
            //this.colInLocation.Visible = true;
            //this.colOutLocation.Visible = false;
            //allowGetByWeightItem = true;
        }
        public void SetOutStockStatus()
        {
            lbInStock.Visible = false;
            lookUpInStock.Visible = false;
            txtInStockName.Visible = false;

            lookUpOutStock.Properties.ReadOnly = true;
            lbOutStock.Visible = true;
            lookUpOutStock.Visible = true;
            txtOutStockName.Visible = true;

            lbKhoNhan.Visible = true;
            lookUpEditKhoNhan.Visible = true;
            lbKhoGiao.Visible = false;
            lookUpEditKhoGiao.Visible = false;
            lbKhoNhan.Left = lbKhoGiao.Left;
            lookUpEditKhoNhan.Left = lookUpEditKhoGiao.Left;

            lbDVNhan.Visible = true;
            lookUpEditDVNhan.Visible = true;
            lbDVGiao.Visible = false;
            lookUpEditDVGiao.Visible = false;
            //lbDVNhan.Left = lbDVGiao.Left;
            //lookUpEditDVNhan.Left = lookUpEditDVGiao.Left;

            lbSoDH.Visible = true;
            btnEditSoDH.Visible = true;
            lbSoHD.Visible = false;
            btnEditSoHD.Visible = false;
            lbSoDH.Left = lbSoHD.Left;
            btnEditSoDH.Left = btnEditSoHD.Left;

            lbNguoiGiao.Visible = false;
            txtNguoiGiao.Visible = false;
            lbNguoiNhan.Visible = true;
            txtNguoiNhan.Visible = true;

            //colQuantityReg.Visible = false;
            colPriceIn.Visible = false;
            colAmountIn.Visible = false;
            colPriceOut.Visible = false;
            colAmountOut.Visible = false;
           
            //IsOutStock = true
            IsInStock = false;
            IsMove = false;

            if (!lookUpOutStock.Visible)
            {
                colOutLocation.Visible = false;
            }
            if (!lookUpInStock.Visible)
            {
                colInLocation.Visible = false;
            }
            btnEdit.Buttons[0].Visible = false;

            colQuantityReg.Caption = "SL yêu cầu";
            //if (DataSource != null)
            //{
            //    if ((DataSource as StockTransaction).GenID == Guid.Empty)
            //    {
            //        ChkGetByWeightItem.Visible = true;
            //    }
            //}
            //this.colOutLocation.Visible = true;
            //this.colInLocation.Visible = false;
        }
        public void SetMoveStatus()
        {
            IsOutStock = false;
            IsInStock = false;
            IsMove = true;
            ChkGetByWeightItem.Checked = false;
            ChkGetByWeightItem.Visible = false;
            ChkGetByWeightItemContainer.Checked = false;
            ChkGetByWeightItemContainer.Visible = false;
            btnCheck.Visible = false;
            btnCheckWeightItemContainer.Visible = false;
            chkDepartmentConfirm.Visible = false;
        }
        public void SetInLocationDataSource(object obj)
        {
            this.LookupInLocation.DataSource = obj;
        }
        public void SetOutLocationDataSource(object obj)
        {
            this.LookupOutLocation.DataSource = obj;
        }
        public void SetItemDataSource(object obj)
        {
            this.LookupItem.DataSource = obj;
            this.LookUpItemName.DataSource = obj;
        }
        public override void RefreshControl()
        {
            lookUpInStock.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;
            lookupTransactionTypeCode.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;
            lookUpOutStock.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;
            txtTransactionNo.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;
            dateEditTransaction.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;
            txtDescription.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;
            ChkGetByWeightItem.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;
            ChkGetByWeightItemContainer.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;

            txtCanmeNo.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;

            chkConfirm.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;
            lookUpEditVesselCode.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;
            txtTransportRoute.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;
            txtTCRoute.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;
            lookUpEditKhoGiao.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;
            lookUpEditKhoNhan.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;
            lookUpEditDVGiao.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;
            lookUpEditDVNhan.Properties.ReadOnly = this.editMode == FormEditMode.VIEW || this.btnEditSoDH.Text!=string.Empty;
            lookUpEditDVVanChuyen.Properties.ReadOnly = this.editMode == FormEditMode.VIEW || this.btnEditSoDH.Text != string.Empty;
            txtPTVanChuyen.Properties.ReadOnly = this.editMode == FormEditMode.VIEW || this.btnEditSoDH.Text != string.Empty;
            //090813
            lokDVTC.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;
            txtPTTC.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;
            //
            //111101
            txtVCType.Properties.ReadOnly =
                txtVCItemType.Properties.ReadOnly =
                txtTCType.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;
            //

            txtCTKemTheo.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;
            // colQuantityReg.OptionsColumn.ReadOnly = this.editMode == FormEditMode.VIEW;
            colQuantityInclWrapping.OptionsColumn.ReadOnly = this.editMode == FormEditMode.VIEW;
            colWrappingCounter.OptionsColumn.ReadOnly = this.editMode == FormEditMode.VIEW;
            colPriceIn.OptionsColumn.ReadOnly = this.editMode == FormEditMode.VIEW;
            colAmountIn.OptionsColumn.ReadOnly = this.editMode == FormEditMode.VIEW;
            colPriceOut.OptionsColumn.ReadOnly = this.editMode == FormEditMode.VIEW;
            colAmountOut.OptionsColumn.ReadOnly = this.editMode == FormEditMode.VIEW;
            colPriceCost.OptionsColumn.ReadOnly = this.editMode == FormEditMode.VIEW;
            colAmountCost.OptionsColumn.ReadOnly = this.editMode == FormEditMode.VIEW;
            // colQuantity.OptionsColumn.ReadOnly = this.EditMode == FormEditMode.VIEW;
            // btnEditSoDH.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;
            btnEditSoHD.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;
            btnEditSoDH.Properties.ReadOnly = true;

            txtNguoiNhan.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW || this.btnEditSoDH.Text != string.Empty;
            txtNguoiGiao.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW;

            //tri
            this.colGoodCode.OptionsColumn.ReadOnly = this.EditMode == FormEditMode.VIEW;
            //
            this.colItemCode.OptionsColumn.ReadOnly = this.colQuantityReg.OptionsColumn.ReadOnly =
                this.EditMode == FormEditMode.VIEW || this.btnEditSoDH.Text != string.Empty;

            if (this.EditMode == FormEditMode.VIEW)
            {
                //lbSoHD.Visible
                lookUpInStock.BackColor = lbInStock.BackColor;
                lookupTransactionTypeCode.BackColor = lbInStock.BackColor;
                lookUpOutStock.BackColor = lbInStock.BackColor;
                txtTransactionNo.BackColor = lbInStock.BackColor;
                dateEditTransaction.BackColor = lbInStock.BackColor;
                txtDescription.BackColor = lbInStock.BackColor;
                lookUpEditForDepartment.BackColor = lbInStock.BackColor;


                this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                lookUpEditForDepartment.Properties.ReadOnly = true;
                this.colInLocation.OptionsColumn.ReadOnly = true;
                this.colItemCode.OptionsColumn.ReadOnly = true;
                this.colOutLocation.OptionsColumn.ReadOnly = true;
                this.colQuantity1.OptionsColumn.ReadOnly = true;
                //tri
                //this.colGoodCode.OptionsColumn.ReadOnly = true;
                //this.gridView2.OptionsBehavior.Editable = false;
                //
                colQuantity.OptionsColumn.ReadOnly = true;
                colQuantity.OptionsColumn.AllowEdit = false;
                colQuantity.OptionsColumn.AllowFocus = false;
                colQuantityReg.OptionsColumn.ReadOnly = true;
                colQuantityReg.OptionsColumn.AllowEdit = false;
                colQuantityReg.OptionsColumn.AllowFocus = false;
                //gridView2.OptionsView.NewItemRowPosition
                txtShift.Properties.ReadOnly = true;
                txtShift.BackColor = lbShift.BackColor;
                lookUpEditKhoGiao.BackColor = lbShift.BackColor;
                lookUpEditKhoNhan.BackColor = lbShift.BackColor;
                lookUpEditDVGiao.BackColor = lbShift.BackColor;
                lookUpEditDVNhan.BackColor = lbShift.BackColor;
                btnEditSoDH.BackColor = lbShift.BackColor;
                btnEditSoHD.BackColor = lbShift.BackColor;
                lookUpEditDVVanChuyen.BackColor = lbShift.BackColor;
                txtPTVanChuyen.BackColor = lbShift.BackColor;
                lokDVTC.BackColor = lbShift.BackColor;
                txtPTTC.BackColor = lbShift.BackColor;
                txtCTKemTheo.BackColor = lbShift.BackColor;
            }
            if (this.EditMode == FormEditMode.EDIT || this.EditMode == FormEditMode.ADD)
            {
                lookUpEditKhoGiao.BackColor = txtBackGround.BackColor;
                lookUpEditKhoNhan.BackColor = txtBackGround.BackColor;
                lookUpEditDVGiao.BackColor = txtBackGround.BackColor;
                lookUpEditDVNhan.BackColor = txtBackGround.BackColor;
                btnEditSoDH.BackColor = txtBackGround.BackColor;
                btnEditSoHD.BackColor = txtBackGround.BackColor;
                lookUpEditDVVanChuyen.BackColor = txtBackGround.BackColor;
                txtPTVanChuyen.BackColor = txtBackGround.BackColor;
                lokDVTC.BackColor = txtBackGround.BackColor;
                txtPTTC.BackColor = txtBackGround.BackColor;
                txtCTKemTheo.BackColor = txtBackGround.BackColor;

                if (this.PSTGD.CreatedType == enumStockTransactionCreatedType.DefaultValue)
                {
                    if (this.IsMove)
                    {
                        lookUpInStock.BackColor = txtBackGround.BackColor;
                        lookUpOutStock.BackColor = txtBackGround.BackColor;
                    }
                    else
                    {
                        //                        ChkGetByWeightItem
                        lookUpInStock.BackColor = lbInStock.BackColor;
                        lookUpOutStock.BackColor = lbInStock.BackColor;
                    }
                    //txtShift.Properties.ReadOnly = false;
                    this.RefeshStatus();
                }
                else
                {
                    if (this.PSTGD.CreatedType == enumStockTransactionCreatedType.ByManufacture || this.PSTGD.CreatedType == enumStockTransactionCreatedType.ByPremix || this.PSTGD.CreatedType == enumStockTransactionCreatedType.ByGrind)
                    {
                        this.SetStatusForManufacture();
                    }
                }
                txtTransactionNo.Focus();

            }
            if (this.DataSource == null)
            {

                StockTransaction st = (dataSource as StockTransaction);
                lookUpEditForDepartment.ItemIndex = -1;
                txtShift.Text = "";
                txtStatus.Text = "";
                txtTransactionNo.Text = "";
                ChkGetByWeightItem.Checked = false;
                ChkGetByWeightItemContainer.Checked = false;
                txtDescription.Text = "";
                gridControl1.DataSource = null;
                lookUpEditKhoGiao.ItemIndex = -1;
                lookUpEditKhoNhan.ItemIndex = -1;
                lookUpEditDVGiao.ItemIndex = -1;
                lookUpEditDVNhan.ItemIndex = -1;
                btnEditSoDH.Text = "";
                btnEditSoHD.Text = "";
                lookUpEditDVVanChuyen.ItemIndex = -1;
                txtPTVanChuyen.Text = "";
                lokDVTC.ItemIndex = -1;
                txtPTTC.Text = "";
                txtCTKemTheo.Text = "";
                txtNguoiGiao.Text = "";
                txtNguoiNhan.Text = "";
                lookUpEditVesselCode.EditValue = string.Empty;
                txtTransportRoute.EditValue = string.Empty;
                txtTCRoute.EditValue = string.Empty;
            }

            if (this.CheckTransTypeNx3)
            {
                colQuantityReg.OptionsColumn.AllowEdit = false;
                colQuantityReg.OptionsColumn.AllowFocus = false;
                colQuantityReg.OptionsColumn.ReadOnly = true;
                colQuantity.OptionsColumn.AllowEdit = this.EditMode != FormEditMode.VIEW;
                colQuantity.OptionsColumn.AllowFocus = this.EditMode != FormEditMode.VIEW;
                colQuantity.OptionsColumn.ReadOnly = this.EditMode == FormEditMode.VIEW;
                if (ChkGetByWeightItem.Checked || ChkGetByWeightItemContainer.Checked)
                {
                    colQuantity.OptionsColumn.AllowEdit = false;
                    colQuantity.OptionsColumn.AllowFocus = false;
                    colQuantity.OptionsColumn.ReadOnly = true;
                }
            }
            else
            {
                colQuantity.OptionsColumn.AllowEdit = false;
                colQuantity.OptionsColumn.AllowFocus = false;
                colQuantity.OptionsColumn.ReadOnly = true;
                colQuantityReg.OptionsColumn.AllowEdit = this.EditMode != FormEditMode.VIEW;
                colQuantityReg.OptionsColumn.AllowFocus = this.EditMode != FormEditMode.VIEW;
                colQuantityReg.OptionsColumn.ReadOnly = this.EditMode == FormEditMode.VIEW;

            }

            if (!colInLocation.Visible && !colOutLocation.Visible)
            {
                gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                if (this.EditMode != FormEditMode.VIEW)
                {
                    if (PSTGD.CreatedType == enumStockTransactionCreatedType.DefaultValue)
                    {
                        if (!ChkGetByWeightItem.Checked && !ChkGetByWeightItemContainer.Checked)
                        {
                            colQuantityReg.OptionsColumn.AllowEdit = true;
                            colQuantityReg.OptionsColumn.AllowFocus = true;
                            colQuantityReg.OptionsColumn.ReadOnly = false;
                            colQuantity.OptionsColumn.AllowEdit = true;
                            colQuantity.OptionsColumn.AllowFocus = true;
                            colQuantity.OptionsColumn.ReadOnly = false;
                        }
                    }
                }
            }

            if (this.EditMode == FormEditMode.EDIT)
            {
                if (Contexts.CurrentUser.IsAdmin || Contexts.MemberFunctions.Search("FunctionName", FunctionNames.STOCK_CHANGESTOCK) != null)
                {
                    lookUpInStock.Properties.ReadOnly = lookUpOutStock.Properties.ReadOnly = false;
                    lookUpEditKhoNhan.Properties.ReadOnly = lookUpEditKhoGiao.Properties.ReadOnly = false;
                }
            }
            base.RefreshControl();

            
        }
        private void SetMoveStatusForRefeshControl()
        {
            if (this.EditMode != FormEditMode.VIEW)
            {

               // lookUpInStock.Properties.ReadOnly = true;
               // lookUpOutStock.Properties.ReadOnly = true;

                lookupTransactionTypeCode.BackColor = txtBackGround.BackColor;
                txtTransactionNo.BackColor = txtBackGround.BackColor;
                dateEditTransaction.BackColor = txtBackGround.BackColor;
                txtDescription.BackColor = txtBackGround.BackColor;
                //ChkGetByWeightItem.BackColor = txtBackGround.BackColor;

                //   gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;


                if (!ChkGetByWeightItem.Checked && !ChkGetByWeightItemContainer.Checked)
                {
                    //colInLocation.OptionsColumn.ReadOnly
                    //colInLocation.Visible
                    this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
                    this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
                    this.colInLocation.OptionsColumn.ReadOnly = false;
                    this.colItemCode.OptionsColumn.ReadOnly = false;
                    this.colOutLocation.OptionsColumn.ReadOnly = false;
                    this.colQuantity1.OptionsColumn.ReadOnly = false;
                    //tri
                    //this.colGoodCode.OptionsColumn.ReadOnly = false;
                    //this.gridView2.OptionsBehavior.Editable = true;
                    //
                }
                else
                {
                    this.colInLocation.OptionsColumn.ReadOnly = !this.CheckTransTypeNx3;
                    this.colQuantity1.OptionsColumn.ReadOnly = !this.CheckTransTypeNx3;
                    this.colOutLocation.OptionsColumn.ReadOnly = !this.CheckTransTypeNx3;
                    //tri
                    //this.colGoodCode.OptionsColumn.ReadOnly = false;
                    //this.gridView2.OptionsBehavior.Editable = this.CheckTransTypeNx3;
                    //
                }
            }
            ChkGetByWeightItem.Checked = false;
            ChkGetByWeightItem.Visible = false;
            ChkGetByWeightItemContainer.Checked = false;
            ChkGetByWeightItemContainer.Visible = false;
            btnCheck.Visible = false;
            btnCheckWeightItemContainer.Visible = false;
            chkDepartmentConfirm.Visible = false;
        }
        private void SetDefaultStatus()
        {
            if (this.EditMode != FormEditMode.VIEW)
            {

                lookUpInStock.Properties.ReadOnly = true;
                lookUpOutStock.Properties.ReadOnly = true;

                lookupTransactionTypeCode.BackColor = txtBackGround.BackColor;
                txtTransactionNo.BackColor = txtBackGround.BackColor;
                dateEditTransaction.BackColor = txtBackGround.BackColor;
                txtDescription.BackColor = txtBackGround.BackColor;
                lookUpEditForDepartment.BackColor = txtBackGround.BackColor;
                //ChkGetByWeightItem.BackColor = txtBackGround.BackColor;

                //   gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
                lookUpEditForDepartment.Properties.ReadOnly = false;

                if (!ChkGetByWeightItem.Checked && !ChkGetByWeightItemContainer.Checked)
                {
                    //gridView2.OptionsView.NewItemRowPosition
                    this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
                    this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
                    this.colInLocation.OptionsColumn.ReadOnly = false;
                    //this.colItemCode.OptionsColumn.ReadOnly = false;
                    this.colOutLocation.OptionsColumn.ReadOnly = false;
                    this.colQuantity1.OptionsColumn.ReadOnly = false;
                    //tri
                    //this.colGoodCode.OptionsColumn.ReadOnly = false;
                    //this.gridView2.OptionsBehavior.Editable = true;
                    //
                }
                else
                {
                    this.colInLocation.OptionsColumn.ReadOnly = !this.CheckTransTypeNx3;
                    this.colOutLocation.OptionsColumn.ReadOnly = !this.CheckTransTypeNx3;
                    this.colQuantity1.OptionsColumn.ReadOnly = !this.CheckTransTypeNx3;
                    //tri
                    //this.gridView2.OptionsBehavior.Editable = this.CheckTransTypeNx3;
                    //
                    if (this.CheckTransTypeNx3)
                    {
                        this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
                    }
                }
                txtShift.Properties.ReadOnly = false;
                txtShift.BackColor = txtBackGround.BackColor;
            }
            else
            {
                txtShift.Properties.ReadOnly = true;
                txtShift.BackColor = lbShift.BackColor;
            }
            //lbForDepartment.Visible = false;
            //lookUpEditForDepartment.Visible = false;
            
            //ChkGetByWeightItem.Visible = true;
            //txtShift.Visible = false;
            //lbShift.Visible = false;
        }
        private void SetStatusForManufacture()
        {
            if (this.EditMode == FormEditMode.EDIT)
            {
                //lookUpInStock.Visible
                lookUpInStock.Properties.ReadOnly = true;
                lookupTransactionTypeCode.Properties.ReadOnly = true;
                lookUpOutStock.Properties.ReadOnly = true;
                dateEditTransaction.Properties.ReadOnly = true;
                lookupTransactionTypeCode.Properties.ReadOnly = true;
                lookupTransactionTypeCode.BackColor = lbInStock.BackColor;
                txtTransactionNo.BackColor = txtBackGround.BackColor;
                txtDescription.BackColor = txtBackGround.BackColor;

                lookUpInStock.BackColor = lbInStock.BackColor;
                lookupTransactionTypeCode.BackColor = lbInStock.BackColor;
                lookUpOutStock.BackColor = lbInStock.BackColor;
                //txtTransactionNo.BackColor = lbInStock.BackColor;
                dateEditTransaction.BackColor = lbInStock.BackColor;

                gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
                this.colInLocation.OptionsColumn.ReadOnly = false;
                //this.colItemCode.OptionsColumn.ReadOnly = false;
                this.colOutLocation.OptionsColumn.ReadOnly = false;
                this.colQuantity1.OptionsColumn.ReadOnly = false;
                //tri
                //this.gridView2.OptionsBehavior.Editable = true;
                //
            }
            txtShift.Properties.ReadOnly = true;
            txtShift.BackColor = lbShift.BackColor;
            lookUpEditForDepartment.Properties.ReadOnly = true;
            txtShift.Visible = true;
            lbShift.Visible = true;
            
        }
        private void lookUpInStock_MouseMove(object sender, MouseEventArgs e)
        {
            if (dataSource != null)
            {
                if ((dataSource as StockTransaction).Details.Count > 0)
                {
                    //lookUpInStock.Properties.ReadOnly = true;
                }
            }
        }

        private void lookUpOutStock_MouseMove(object sender, MouseEventArgs e)
        {
            if (dataSource != null)
            {
                if ((dataSource as StockTransaction).Details.Count > 0)
                {
                    //lookUpOutStock.Properties.ReadOnly = true;
                }
            }
        }

        private void lookUpInStock_EditValueChanged(object sender, EventArgs e)
        {
            
            if (lookUpInStock.EditValue != null && lookUpInStock.Properties.DataSource != null)
            {
                try
                {
                    Stock t = (lookUpInStock.Properties.DataSource as ListBase<Stock>).Search("StockCode", lookUpInStock.EditValue.ToString());
                    txtInStockName.Text = t.StockName;
                    LookupInLocation.DataSource = new StockLocationBLL().GetByStockCode(t.StockCode);
                }
                catch
                {
                    txtInStockName.Text = "";
                    LookupInLocation.DataSource = null;
                }
                //lookUpInStock.Refresh();
                //Stock s = new Stock();
                //if (lookUpInStock.EditValue != null)
                //{
                //    s = (lookUpInStock.Properties.DataSource as ListBase<Stock>).Search("StockCode", lookUpInStock.EditValue.ToString());
                //}
                //else
                //{
                //    s = null;
                //}

                //if (s != null)
                //{
                //    if (s.HasLocation)
                //    {
                //        colInLocation.Visible = true;
                //    }
                //    else
                //    {
                //        colInLocation.Visible = false;
                //    }
                //}
            }
            else
            {
                LookupInLocation.DataSource = null;
                txtInStockName.Text = "";
            }
        }

        private void lookUpOutStock_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpOutStock.EditValue != null && lookUpOutStock.Properties.DataSource != null)
            {
                try
                {
                    // MessageBox.Show(lookUpOutStock.EditValue.ToString());
                    Stock t = (lookUpOutStock.Properties.DataSource as ListBase<Stock>).Search("StockCode", lookUpOutStock.EditValue.ToString());
                    txtOutStockName.Text = t.StockName;
                    LookupOutLocation.DataSource = new StockLocationBLL().GetByStockCode(t.StockCode);
                }
                catch 
                {
                    txtOutStockName.Text = "";
                    LookupOutLocation.DataSource = null;
                }
                //Stock s = new Stock();
                //if (lookUpOutStock.EditValue != null)
                //{
                //    s = (lookUpOutStock.Properties.DataSource as ListBase<Stock>).Search("StockCode", lookUpOutStock.EditValue.ToString());
                //}
                //else
                //{
                //    s = null;
                //}

                //if (s != null)
                //{
                //    if (s.HasLocation)
                //    {
                //        colOutLocation.Visible = true;
                //    }
                //    else
                //    {
                //        colOutLocation.Visible = false;
                //    }
                //}
            }
            else
            {
                txtOutStockName.Text = "";
                LookupOutLocation.DataSource = null;
            }
        }

        protected override int ValidateData()
        {
            //gridView1.OptionsView.ShowDetailButtons
            txtNguoiGiao.Text = txtNguoiGiao.Text.Trim();
            txtNguoiNhan.Text = txtNguoiNhan.Text.Trim();
            btnEditSoDH.Text = btnEditSoDH.Text.Trim();
            btnEditSoHD.Text = btnEditSoHD.Text.Trim();
            txtPTVanChuyen.Text = txtPTVanChuyen.Text.Trim();
            txtCTKemTheo.Text = txtCTKemTheo.Text.Trim();
            txtTransactionNo.Text = txtTransactionNo.Text.Trim();
            if (IsInStock && (lookUpInStock.EditValue == null || lookUpInStock.EditValue.ToString() == ""))
            {
                lookUpInStock.Focus();
                return -1;
            }
            if (IsOutStock && (lookUpOutStock.EditValue == null || lookUpOutStock.EditValue.ToString() == ""))
            {
                lookUpOutStock.Focus();
                return -1;
            }
            if (IsMove && (lookUpOutStock.EditValue == null || lookUpOutStock.EditValue.ToString() == ""))
            {
                lookUpOutStock.Focus();
                return -2;
            }
            if (IsMove && (lookUpInStock.EditValue == null || lookUpInStock.EditValue.ToString() == ""))
            {
                lookUpInStock.Focus();
                return -3;
            }
            if (IsMove && (lookUpOutStock.EditValue != null && lookUpOutStock.EditValue.ToString() != "" && lookUpOutStock.EditValue.ToString() == lookUpInStock.EditValue.ToString())) return -4;

            if (txtTransactionNo.Text == "" && (chkConfirm.Checked || !chkConfirm.Visible))
            {
                txtTransactionNo.Focus();
                return -5;
            }
            if (lookupTransactionTypeCode.EditValue == null || lookupTransactionTypeCode.EditValue.ToString() == "")
            {
                lookupTransactionTypeCode.Focus();
                return -6;
            }
//            colQuantity.OptionsColumn.ReadOnly
            StockTransaction st = (dataSource as StockTransaction);
            foreach (StockTransactionSumDetail stsd in st.Details)
            {
                //if (btnEditSoDH.Text != string.Empty && stsd.Quantity > stsd.QuantityReg)
                //    return -101;

                stsd.TransactionID = st.TransactionID;
                if (stsd.ItemCode == null && stsd.Quantity !=0) 
                    return -7;
                foreach (StockTransactionDetail std in stsd.lstStockTransactionDetail)
                {
                    std.ItemCode = stsd.ItemCode;
                    std.TransactionID = st.TransactionID;

                    if (colInLocation.Visible && (std.InLocation == null || std.InLocation == "" || std.InLocation == string.Empty) && std.Quantity != 0 && stsd.Quantity!=0) 
                        return -8;
                    if (colOutLocation.Visible && (std.OutLocation == null || std.OutLocation == "" || std.OutLocation == string.Empty) && std.Quantity != 0 && stsd.Quantity != 0) 
                        return -8;
                    //if (IsMove && (std.OutLocation == null || std.OutLocation == "" || std.OutLocation == string.Empty) && std.Quantity != 0) return -9;
                    //if (IsMove && (std.InLocation == null || std.InLocation == "" || std.InLocation == string.Empty) && std.Quantity != 0) return -10;
                    if (st.CreatedType == (byte)enumStockTransactionCreatedType.ByManufacture)
                    {
                        //ModuleManufacture mmbll = new ModuleBLL().GetModuleManufacture();
                        StockTransaction st1 = (this.DataSource as StockTransaction);
                        // string ttc = (this.DataSource as StockTransaction).TransactionTypeCode;

                        if (st1.GenType == (byte)enumStockTransactionGenType.InProduct || st1.GenType == (byte)enumStockTransactionGenType.InWaste)
                        {
                            if (colInLocation.Visible && (std.InLocation == null || std.InLocation == "" || std.InLocation == string.Empty) && std.Quantity != 0) 
                                return -8;
                        }
                        else
                        {
                            if (colOutLocation.Visible && (std.OutLocation == null || std.OutLocation == "" || std.OutLocation == string.Empty) && std.Quantity != 0) 
                                return -8;
                        }
                    }
                    if (st.CreatedType == (byte)enumStockTransactionCreatedType.ByPremix)
                    {
                        //ModuleManufacture mmbll = new ModuleBLL().GetModuleManufacture();
                        StockTransaction st1 = (this.DataSource as StockTransaction);
                        // string ttc = (this.DataSource as StockTransaction).TransactionTypeCode;

                        if (st1.GenType == (byte)enumStockTransactionGenType.Premix_InPremix)
                        {
                            if (colInLocation.Visible && (std.InLocation == null || std.InLocation == "" || std.InLocation == string.Empty) && std.Quantity != 0) 
                                return -8;
                        }
                        else
                        {
                            if (colOutLocation.Visible && (std.OutLocation == null || std.OutLocation == "" || std.OutLocation == string.Empty) && std.Quantity != 0) 
                                return -8;
                        }
                    }
                    if (st.CreatedType == (byte)enumStockTransactionCreatedType.ByGrind)
                    {
                        //ModuleManufacture mmbll = new ModuleBLL().GetModuleManufacture();
                        StockTransaction st1 = (this.DataSource as StockTransaction);
                        // string ttc = (this.DataSource as StockTransaction).TransactionTypeCode;

                        if (st1.GenType == (byte)enumStockTransactionGenType.Grind_InMaterial)
                        {
                            if (colInLocation.Visible && (std.InLocation == null || std.InLocation == "" || std.InLocation == string.Empty) && std.Quantity != 0) 
                                return -8;
                        }
                        else
                        {
                            if (colOutLocation.Visible && (std.OutLocation == null || std.OutLocation == "" || std.OutLocation == string.Empty) && std.Quantity != 0) 
                                return -8;
                        }
                    }
                }
                //if (stsd.Quantity < 0) return -11;
            }
          
            for (int i = 0; i <= st.Details.Count-1; i++)
            {
                bool ErrorFound=false;

                if (PSTGD.CreatedType == enumStockTransactionCreatedType.DefaultValue && st.CreatedType == (byte)enumStockTransactionCreatedType.DefaultValue
                    && (colInLocation.Visible || colOutLocation.Visible)
                    && this.txtCanmeNo.Text == string.Empty)
                {
                    if (this.CheckTransTypeNx3)
                    {
                        st.Details[i].QuantityReg = 0;
                        foreach (StockTransactionDetail std in st.Details[i].lstStockTransactionDetail)
                        {
                            st.Details[i].QuantityReg += std.Quantity;
                        }
                    }
                    else
                    {
                        st.Details[i].Quantity = 0;
                        foreach (StockTransactionDetail std in st.Details[i].lstStockTransactionDetail)
                        {
                            st.Details[i].Quantity += std.Quantity;
                        }
                    }
                }
                else
                {

                }
                for (int j = i + 1; j < st.Details.Count; j++)
                { 
                    ErrorFound=st.Details[i].ItemCode == st.Details[j].ItemCode && st.Details[i].Quantity!=0 && st.Details[j].Quantity!=0;
                    if (ErrorFound) return -13;
                }
            }
            if ((st.CreatedType != (byte)enumStockTransactionCreatedType.DefaultValue) 
                && (colInLocation.Visible || colOutLocation.Visible))
            {
                decimal NewSum;

                foreach (StockTransactionSumDetail stocktsd in lstBackupDetails)
                {
                    NewSum = 0;
                    StockTransactionSumDetail obj = st.Details.Search("ItemCode", stocktsd.ItemCode);
                    foreach (StockTransactionDetail stdetail in obj.lstStockTransactionDetail)
                    {
                        NewSum += stdetail.Quantity;
                    }
                    if ((obj.Quantity != NewSum && !this.CheckTransTypeNx3) || (obj.QuantityReg != NewSum && this.CheckTransTypeNx3))
                    {
                        return -12;
                    }
                }
            }

            if (this.txtCanmeNo.Text != string.Empty)
            {
                foreach (StockTransactionSumDetail stsd in st.Details)
                {
                    decimal sum = 0;
                    foreach (StockTransactionDetail std in stsd.lstStockTransactionDetail)
                        sum += std.Quantity;

                    if (stsd.Quantity != sum)
                        return -13;
                }
            }
            txtDescription.Text = txtDescription.Text.Trim();


            foreach (StockTransactionSumDetail stsd in st.Details)
            {
                if (btnEditSoDH.Text != string.Empty && stsd.Quantity > stsd.QuantityReg)
                    return -101;

            }
            return base.ValidateData();
        }

        private void lookupTransactionTypeCode_EditValueChanged(object sender, EventArgs e)
        {
            if (lookupTransactionTypeCode.EditValue != null && lookupTransactionTypeCode.Properties.DataSource != null)
            {
                try
                {
                    TransactionType tt = (lookupTransactionTypeCode.Properties.DataSource as ListBase<TransactionType>).Search("TransactionTypeCode", lookupTransactionTypeCode.EditValue.ToString());
                    txtTransactionTypeCode.Text = tt.Description;
                }
                catch
                {
                    txtTransactionTypeCode.Text = "";
                }

            }
            else
            {
                txtTransactionTypeCode.Text = "";
            }
            this.RefeshColQuantityReadOnly();
            if (ChkGetByWeightItem.Checked || ChkGetByWeightItemContainer.Checked)
            {
                if (this.CheckTransTypeNx3)
                {
                    gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
                    colQuantity1.OptionsColumn.ReadOnly = false;
                    //tri
                    //this.gridView2.OptionsBehavior.Editable = true;
                    //
                    if (colInLocation.Visible)
                    {
                        colInLocation.OptionsColumn.ReadOnly = false;
                    }
                    if (colOutLocation.Visible)
                    {
                        colOutLocation.OptionsColumn.ReadOnly = false;
                    }
                }
                else
                {
                    gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                    colQuantity1.OptionsColumn.ReadOnly = true;
                    //tri
                    //this.gridView2.OptionsBehavior.Editable = false;
                    //
                    if (colInLocation.Visible)
                    {
                        colInLocation.OptionsColumn.ReadOnly = true;
                    }
                    if (colOutLocation.Visible)
                    {
                        colOutLocation.OptionsColumn.ReadOnly = true;
                    }
                }
            }
        }

        private void ChkGetByWeightItem_CheckedChanged(object sender, EventArgs e)
        {
            string scode="";
            ChkGetByWeightItemContainer.Enabled = !ChkGetByWeightItem.Checked;
            btnCheckWeightItemContainer.Enabled = !ChkGetByWeightItem.Checked;

            txtCanmeNo.Enabled = !ChkGetByWeightItem.Checked;
            if (ChkGetByWeightItem.Checked)
                txtCanmeNo.Text = string.Empty;
            //Guid transactionID = (DataSo)
            if (ChkGetByWeightItem.Checked)
            {
                if (allowGetByWeightItem)
                {
                    if (this.IsInStock && lookUpInStock.EditValue!=null) scode = lookUpInStock.EditValue.ToString();
                    if (this.IsOutStock && lookUpOutStock.EditValue!=null) scode = lookUpOutStock.EditValue.ToString();
                    FormCheckWeightItem f = new FormCheckWeightItem((this.DataSource as StockTransaction).TransactionID, this.IsInStock,scode);
                    //f.Text = 
                    if (DialogResult.OK == f.ShowDialog())
                    {
                        if ((dataSource as StockTransaction).Details != null)
                        {
                            //colQuantity.OptionsColumn.ReadOnly
                            foreach (StockTransactionSumDetail stsd in (dataSource as StockTransaction).Details)
                            {
                                stsd.Quantity = 0;
                                stsd.lstStockTransactionDetail.Clear();
                            }
                        }
                        if (f.lststsd != null)
                        {
                            foreach (StockTransactionSumDetail stsd in f.lststsd)
                            {
                                StockTransactionSumDetail stsd1 = (dataSource as StockTransaction).Details.Search("ItemCode", stsd.ItemCode);
                                if (stsd1 == null)
                                {
                                    (dataSource as StockTransaction).Details.Add((StockTransactionSumDetail)stsd.Clone());
                                }
                                else
                                {
                                    stsd1.Quantity = stsd.Quantity;
                                    stsd1.lstStockTransactionDetail = stsd.lstStockTransactionDetail;
                                    stsd1.WrappingCounter = stsd.WrappingCounter;
                                    stsd1.QuantityInclWrapping = stsd.QuantityInclWrapping;
                                }
                            }
                        }
                        //(dataSource as StockTransaction).Details = f.lststsd;
                        gridControl1.RefreshDataSource();
                        StockTransactionBLL.lstWeightItemChose = f.lstWeightItemChose;
                        gridControl1.DataSource = (dataSource as StockTransaction).Details;

                        this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                        this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                        if (this.CheckTransTypeNx3)
                        {
                            this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
                        }
                        this.colInLocation.OptionsColumn.ReadOnly = !this.CheckTransTypeNx3;
                        this.colItemCode.OptionsColumn.ReadOnly = true;
                        this.colOutLocation.OptionsColumn.ReadOnly = !this.CheckTransTypeNx3;
                        this.colQuantity1.OptionsColumn.ReadOnly = !this.CheckTransTypeNx3;
                        //tri
                        //this.gridView2.OptionsBehavior.Editable = this.CheckTransTypeNx3;
                        //
                    }
                    else
                    {
                        StockTransactionBLL.lstWeightItemChose = null;
                        ChkGetByWeightItem.Checked = false;
                    }
                }
                else
                {
                    this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                    this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                    this.colInLocation.OptionsColumn.ReadOnly = true;
                    this.colItemCode.OptionsColumn.ReadOnly = true;
                    this.colOutLocation.OptionsColumn.ReadOnly = true;
                    this.colQuantity1.OptionsColumn.ReadOnly = !this.CheckTransTypeNx3;
                    //tri
                    //this.gridView2.OptionsBehavior.Editable = this.CheckTransTypeNx3;
                    //
                }
                colQuantity.OptionsColumn.AllowEdit = false;
                colQuantity.OptionsColumn.AllowFocus = false;
                this.colQuantity.OptionsColumn.ReadOnly = true;
            }
            else
            {
                if (this.EditMode != FormEditMode.VIEW)
                {
                    this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
                    this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
                    this.colInLocation.OptionsColumn.ReadOnly = false;
                    this.colItemCode.OptionsColumn.ReadOnly = false;
                    this.colOutLocation.OptionsColumn.ReadOnly = false;
                    this.colQuantity1.OptionsColumn.ReadOnly = false;
                    //tri
                    //this.gridView2.OptionsBehavior.Editable = true;
                    //
                    if (this.CheckTransTypeNx3)
                    {
                        this.colQuantity.OptionsColumn.AllowEdit = true;
                        this.colQuantity.OptionsColumn.AllowFocus = true;
                        this.colQuantity.OptionsColumn.ReadOnly = false;
                    }
                }
            }
        }

        private void txtTransactionNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
           
            if (this.EditMode != FormEditMode.VIEW)
            {
                string SoHieu = "";
                string year="";
                string code="";
                bool existscode = false;
                bool existsSoHieu = false;
                string suffix="";
                if (lookUpInStock.Visible && !lookUpOutStock.Visible)
                {
                    if (lookUpInStock.ItemIndex >= 0)
                    {
                        SoHieu = (lookUpInStock.Properties.DataSource as ListBase<Stock>)[lookUpInStock.ItemIndex].SoHieu;
                        existsSoHieu = true;
                    }
                }
                if (!lookUpInStock.Visible && lookUpOutStock.Visible)
                {
                    if (lookUpOutStock.ItemIndex >= 0)
                    {
                        SoHieu = (lookUpOutStock.Properties.DataSource as ListBase<Stock>)[lookUpOutStock.ItemIndex].SoHieu;
                        existsSoHieu = true;
                    }
                }
                year = dateEditTransaction.DateTime.Year.ToString().Substring(4-2);
                if (lookupTransactionTypeCode.ItemIndex >= 0)
                {
                    code = lookupTransactionTypeCode.EditValue.ToString();
                    existscode = true;
                }
                if (!existsSoHieu)
                {
                    MessageBox.Show("Chưa chọn kho", "Error", MessageBoxButtons.OK);
                    return;
                }
                if (!existscode)
                {
                    MessageBox.Show("Chưa chọn mã", "Error", MessageBoxButtons.OK);
                    return;
                }
                suffix = "/" + year + "-" + SoHieu + code;
                StockTransaction st = new StockTransactionBLL().GetTop1BySuffixTNo(suffix);
                if (st == null)
                {
                    txtTransactionNo.Text = "0001" + suffix;
                }
                else
                {
                    if (this.EditMode == FormEditMode.EDIT)
                    {
                        if ((DataSource as StockTransaction).TransactionNo != st.TransactionNo)
                        {

                            int iprefix = Convert.ToInt32(st.TransactionNo.Substring(0, 4));
                            iprefix += 1;
                            string sprefix = iprefix.ToString();
                            while (sprefix.Length < 4) sprefix = "0" + sprefix;
                            txtTransactionNo.Text = sprefix+suffix;
                        }
                        else
                        {
                            if ((DataSource as StockTransaction).TransactionNo != txtTransactionNo.Text.Trim())
                            {
                                txtTransactionNo.Text = (DataSource as StockTransaction).TransactionNo;
                            }
                        }
                    }
                    else
                    {
                        int iprefix = Convert.ToInt32(st.TransactionNo.Substring(0, 4));
                        iprefix += 1;
                        string sprefix = iprefix.ToString();
                        while (sprefix.Length < 4) sprefix = "0" + sprefix;
                        txtTransactionNo.Text = sprefix + suffix;
                    }
                }
                //if(this.EditMode== FormEditMode.EDIT)
            }
        }

        private void lookUpOutStock_VisibleChanged(object sender, EventArgs e)
        {
            Stock s = new Stock();
            if (lookUpOutStock.EditValue != null)
            {
                s = (lookUpOutStock.Properties.DataSource as ListBase<Stock>).Search("StockCode", lookUpOutStock.EditValue.ToString());
            }
            else
            {
                s = null;
            }

            if (s != null)
            {
                colOutLocation.Visible = lookUpOutStock.Visible && s.HasLocation;
            }
            else
            {
                colOutLocation.Visible = false;
            }
            //btnEdit.Buttons[0].Visible = colInLocation.Visible || colOutLocation.Visible;
            btnEdit.Buttons[0].Visible = false;
        }

        private void lookUpInStock_VisibleChanged(object sender, EventArgs e)
        {
            
            Stock s = new Stock();
            if (lookUpInStock.EditValue != null)
            {
                s = (lookUpInStock.Properties.DataSource as ListBase<Stock>).Search("StockCode", lookUpInStock.EditValue.ToString());
            }
            else
            {
                s = null;
                //colQuantityReg.Visible
            }

            if (s != null)
            {
                colInLocation.Visible = lookUpInStock.Visible && s.HasLocation;
                //colInLocation.
            }
            else
            {
                colInLocation.Visible = false;
            }
            //btnEdit.Buttons[0].Visible = colInLocation.Visible || colOutLocation.Visible;
            btnEdit.Buttons[0].Visible = false;
        }

        private void ChkGetByWeightItem_VisibleChanged(object sender, EventArgs e)
        {
            chkConfirm.Visible = !ChkGetByWeightItem.Visible;
            btnCheck.Visible = ChkGetByWeightItem.Visible;
            btnCheckWeightItemContainer.Visible = ChkGetByWeightItem.Visible;
            chkDepartmentConfirm.Visible = ChkGetByWeightItem.Visible;
        }

        private void txtOutStockName_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void gridView2_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            StockTransaction st = this.dataSource as StockTransaction;
            if (PSTGD.CreatedType == enumStockTransactionCreatedType.DefaultValue && st.CreatedType == (byte)enumStockTransactionCreatedType.DefaultValue
                && this.txtCanmeNo.Text == string.Empty)
            {
                StockTransactionSumDetail stsd = ((this.BindingContext[gridView1.DataSource] as CurrencyManager).Current as StockTransactionSumDetail);
                //colQuantity.OptionsColumn.ReadOnly
                if (this.CheckTransTypeNx3)
                {
                    stsd.QuantityReg = 0;
                    foreach (StockTransactionDetail std in stsd.lstStockTransactionDetail)
                    {
                        stsd.QuantityReg += std.Quantity;
                    }
                }
                else
                {
                    stsd.Quantity = 0;
                    foreach (StockTransactionDetail std in stsd.lstStockTransactionDetail)
                    {
                        stsd.Quantity += std.Quantity;
                    }
                }
                gridView1.RefreshData();
            }
        }

        private void btnCheck_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string scode = "";
            if (this.EditMode != FormEditMode.VIEW)
            {
                if (this.IsInStock && lookUpInStock.EditValue != null) scode = lookUpInStock.EditValue.ToString();
                if (this.IsOutStock && lookUpOutStock.EditValue != null) scode = lookUpOutStock.EditValue.ToString();
                FormCheckWeightItem f = new FormCheckWeightItem((this.DataSource as StockTransaction).TransactionID, this.IsInStock, scode);
                //f.Text = 
                if (DialogResult.OK == f.ShowDialog())
                {
                    if ((dataSource as StockTransaction).Details != null)
                    {
                        foreach (StockTransactionSumDetail stsd in (dataSource as StockTransaction).Details)
                        {
                            stsd.Quantity = 0;
                            stsd.lstStockTransactionDetail.Clear();
                        }
                       
                    }
                    if (f.lststsd != null)
                    {
                        foreach (StockTransactionSumDetail stsd in f.lststsd)
                        {
                            StockTransactionSumDetail stsd1 = (dataSource as StockTransaction).Details.Search("ItemCode", stsd.ItemCode);
                            if (stsd1 == null)
                            {
                                (dataSource as StockTransaction).Details.Add((StockTransactionSumDetail)stsd.Clone());
                            }
                            else
                            {
                                stsd1.Quantity = stsd.Quantity;
                                stsd1.lstStockTransactionDetail = stsd.lstStockTransactionDetail;
                                stsd1.WrappingCounter = stsd.WrappingCounter;
                                stsd1.QuantityInclWrapping = stsd.QuantityInclWrapping;
                            }
                        }
                    }
                    allowGetByWeightItem = false;
                    ChkGetByWeightItem.Checked = true;
                    allowGetByWeightItem = true;
                    gridControl1.RefreshDataSource();
                    StockTransactionBLL.lstWeightItemChose = f.lstWeightItemChose;
                    gridControl1.DataSource = null;
                    gridControl1.DataSource = (dataSource as StockTransaction).Details;

                    this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                    this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                    if (this.CheckTransTypeNx3)
                    {
                        this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
                    }
                    this.colInLocation.OptionsColumn.ReadOnly = !this.CheckTransTypeNx3;
                    this.colItemCode.OptionsColumn.ReadOnly = true;
                    this.colOutLocation.OptionsColumn.ReadOnly = !this.CheckTransTypeNx3;
                    this.colQuantity1.OptionsColumn.ReadOnly = !this.CheckTransTypeNx3;
                    //tri
                    //this.gridView2.OptionsBehavior.Editable = this.CheckTransTypeNx3;
                    //
                   
                }
                else
                {
//                    btnEditSoDH.Properties.ReadOnly
                    //StockTransactionBLL.lstWeightItemChose = null;
                    //ChkGetByWeightItem.Checked = false;
                }
            }
        }

        private void btnEditSoDH_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            StockTransaction st = (this.DataSource as StockTransaction);
            if (st.CreatedType == (byte)enumStockTransactionCreatedType.DefaultValue)
            {
                string sCode = null;
                string[] fields = { "CustomerName", "TransportName", "SaleRequestNo", "SaleRequestDate", "PTVC" };
                string[] headers = { "Tên khách hàng", "ĐV vận chuyển", "Số", "Ngày", "PTVC" };
                DataRowView dr;
                

                if (lookUpInStock.Visible && lookUpInStock.EditValue != null)
                {
                    sCode = lookUpInStock.EditValue.ToString();
                }
                else if (lookUpOutStock.EditValue != null)
                {
                    sCode = lookUpOutStock.EditValue.ToString();
                }
                if (sCode == null)
                {
                    MessageBox.Show("Bạn chưa chọn kho!", "Lỗi", MessageBoxButtons.OK);
                }
                else
                {
                    if (this.EditMode != FormEditMode.VIEW)
                    {
                        DataTable obj = new SaleRequestBLL().GetForSTCheck(sCode, dateEditTransaction.DateTime, st.SoDH);
                        dr = (FormSearch.ShowSearch(obj, fields, headers) as DataRowView);
                        if (dr != null)
                        {
                            lookUpEditDVVanChuyen.EditValue = dr["TransportCode"].ToString();
                            lookUpEditDVVanChuyen.Properties.ReadOnly = true;
                            txtPTVanChuyen.Text = dr["PTVC"].ToString();
                            txtPTVanChuyen.Properties.ReadOnly = true;
                            btnEditSoDH.Text = dr["SaleRequestNo"].ToString();
                            lookUpEditDVNhan.EditValue = dr["CustomerCode"].ToString();
                            lookUpEditDVNhan.Properties.ReadOnly = true;
                            txtNguoiNhan.Text = dr["Nguoigiaonhan"].ToString();
                            txtNguoiNhan.Properties.ReadOnly = true;
                            st.Details = new StockTransactionBLL().GetDetailFromSaleRequest(btnEditSoDH.Text);
                            gridControl1.DataSource = null;
                            gridControl1.DataSource = st.Details;
                            gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                            if (colOutLocation.Visible || colInLocation.Visible)
                            {
                                gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
                            }
                            colItemCode.OptionsColumn.ReadOnly = true;
                            colQuantityReg.OptionsColumn.ReadOnly = true;
                            //this.RefreshControl();
                        }
                    }
                }
            }
        }

        private void ChkGetByWeightItemContainer_CheckedChanged(object sender, EventArgs e)
        {
            string sCode = "";
            ChkGetByWeightItem.Enabled = !ChkGetByWeightItemContainer.Checked;
            btnCheck.Enabled = !ChkGetByWeightItemContainer.Checked;

            txtCanmeNo.Enabled = !ChkGetByWeightItemContainer.Checked;
            if (ChkGetByWeightItemContainer.Checked)
                txtCanmeNo.Text = string.Empty;



            StockTransaction st = this.DataSource as StockTransaction;
            //if (st.TransactionID == null) st.TransactionID = Guid.Empty;
            string transTypeCode = string.Empty;
            if (ChkGetByWeightItemContainer.Checked)
            {
                if (allowGetByWeightItem)
                {
                    if (this.IsInStock && lookUpInStock.EditValue != null) sCode = lookUpInStock.EditValue.ToString();
                    if (this.IsOutStock && lookUpOutStock.EditValue != null) sCode = lookUpOutStock.EditValue.ToString();
                    string[] fields = { "WeightDate", "WeightCode", "ItemCode", "Quantity", "WrappingWeight", "ItemWeight", "StockLocationCode", "WrappingType", "Weight1", "WeightTime1", "Weight2", "WeightTime2", "PTVanChuyen", "PTTrungChuyen", "DVVanChuyen", "TransactionTypeCode", "KhoGiaoNhan", "Description" };
                    string[] header = { "Ngày cân", "Số phiếu", "Mã hàng", "Số bao", "Bì bao", "Trọng lượng hàng", "Lô hàng", "Loại bao bì", "Cân lần 1", "Thời gian cân", "Cân lần 2", "Thời gian cân", "PT vận chuyển", "PT trung chuyển", "ĐV vận chuyển", "Mã NX", "Kho giao/nhận", "Diễn giải" };
                    ListBase<WeightItemContainer> lstWIC = new WeightItemContainerBLL().GetByStockCodeAndIsReceive(st.TransactionID, transTypeCode, sCode, this.IsInStock);
                    if (st.LstWICCheck == null)
                    {
                        st.LstWICCheck = new ListBase<WeightItemContainer>();
                        foreach (WeightItemContainer wic1 in lstWIC)
                        {
                            if (wic1.TransactionID != Guid.Empty && wic1.TransactionID != null)
                            {
                                st.LstWICCheck.Add(wic1.Clone() as WeightItemContainer);
                            }
                        }
                    }
                    object lstWICChecktmp = VNS.Windows.Forms.FormCheck.Show(lstWIC, fields, header, -1, "WeightContainerID", st.LstWICCheck, "WeightContainerID");

                    if (lstWICChecktmp != null)
                    {
                        System.Collections.ArrayList arrWICCheck = lstWICChecktmp as System.Collections.ArrayList;
                        // ListBase<WeightItemContainer> lstWICCheck = new ListBase<WeightItemContainer>();

                        st.LstWICCheck.Clear();
                        foreach (WeightItemContainer wic1 in arrWICCheck)
                        {
                            st.LstWICCheck.Add(wic1.Clone() as WeightItemContainer);
                        }
                        if (arrWICCheck.Count > 0)
                        {
                            foreach (StockTransactionSumDetail stsd in (dataSource as StockTransaction).Details)
                            {
                                stsd.Quantity = 0;
                                stsd.lstStockTransactionDetail.Clear();
                            }
                        }
                        ListBase<StockTransactionSumDetail> lstStockTransSumDetail = st.Details as ListBase<StockTransactionSumDetail>;
                        StockTransactionSumDetail stsd1 = null;
                        foreach (WeightItemContainer wic in st.LstWICCheck)
                        {
                            stsd1 = lstStockTransSumDetail.Search("ItemCode", wic.ItemCode);
                            if (stsd1 == null)
                            {
                                stsd1 = new StockTransactionSumDetail();
                                stsd1.ItemCode = wic.ItemCode;
                                stsd1.Quantity = wic.ItemWeight;
                                //stsd.QuantityReg = wic.ItemWeight;
                                stsd1.QuantityInclWrapping = wic.ItemWeight + wic.TotalWrappingWeight;
                                stsd1.WrappingCounter = Convert.ToInt32(wic.Quantity);
                                stsd1.lstStockTransactionDetail = new ListBase<StockTransactionDetail>();
                                StockTransactionDetail std = new StockTransactionDetail();
                                std.ItemCode = wic.ItemCode;
                                if (wic.IsReceive) std.InLocation = wic.StockLocationCode;
                                else std.OutLocation = wic.StockLocationCode;
                                std.Quantity = wic.ItemWeight;
                                stsd1.lstStockTransactionDetail.Add(std);
                                lstStockTransSumDetail.Add(stsd1);
                            }
                            else
                            {
                                stsd1.Quantity += wic.ItemWeight;
                                stsd1.QuantityInclWrapping += wic.ItemWeight + wic.TotalWrappingWeight;
                                stsd1.WrappingCounter += Convert.ToInt32(wic.Quantity);
                                StockTransactionDetail std = null;
                                if (wic.IsReceive)
                                    std = stsd1.lstStockTransactionDetail.Search("InLocation", wic.StockLocationCode);
                                else std = stsd1.lstStockTransactionDetail.Search("OutLocation", wic.StockLocationCode);
                                if (std == null)
                                {
                                    std = new StockTransactionDetail();
                                    std.ItemCode = wic.ItemCode;
                                    if (wic.IsReceive) std.InLocation = wic.StockLocationCode;
                                    else std.OutLocation = wic.StockLocationCode;
                                    std.Quantity = wic.ItemWeight;
                                    stsd1.lstStockTransactionDetail.Add(std);
                                }
                                else
                                {
                                    std.Quantity += wic.ItemWeight;
                                }
                            }
                        }
                        if (arrWICCheck.Count > 0)
                        {
                            gridControl1.RefreshDataSource();
                            //foreach (WeightItemContainer wic2 in lstWICCheck)
                            //{
                            //    wic2.TransactionID = st.TransactionID;
                            //}
                            //st.LstWICCheck = lstWICCheck;
                            gridControl1.DataSource = (dataSource as StockTransaction).Details;
                            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                            this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                            if (this.CheckTransTypeNx3)
                            {
                                this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
                            }
                            this.colInLocation.OptionsColumn.ReadOnly = !this.CheckTransTypeNx3;
                            this.colItemCode.OptionsColumn.ReadOnly = true;
                            this.colOutLocation.OptionsColumn.ReadOnly = !this.CheckTransTypeNx3;
                            this.colQuantity1.OptionsColumn.ReadOnly = !this.CheckTransTypeNx3;
                            //tri
                            //this.gridView2.OptionsBehavior.Editable = this.CheckTransTypeNx3;
                            //
                        }
                        else
                        {
                            ChkGetByWeightItemContainer.Checked = false;
                        }
                    }
                    else
                    {
                       // st.LstWICCheck = null;
                        ChkGetByWeightItemContainer.Checked = false;
                    }
                }
                else
                {
                    this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                    this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                    this.colInLocation.OptionsColumn.ReadOnly = true;
                    this.colItemCode.OptionsColumn.ReadOnly = true;
                    this.colOutLocation.OptionsColumn.ReadOnly = true;
                    this.colQuantity1.OptionsColumn.ReadOnly = !this.CheckTransTypeNx3;
                    //tri
                    //this.gridView2.OptionsBehavior.Editable = this.CheckTransTypeNx3;
                    //
                }
                colQuantity.OptionsColumn.AllowEdit = false;
                colQuantity.OptionsColumn.AllowFocus = false;
                this.colQuantity.OptionsColumn.ReadOnly = true;
            }
            else
            {
                if (this.EditMode != FormEditMode.VIEW)
                {
                    this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
                    this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
                    this.colInLocation.OptionsColumn.ReadOnly = false;
                    this.colItemCode.OptionsColumn.ReadOnly = false;
                    this.colOutLocation.OptionsColumn.ReadOnly = false;
                    this.colQuantity1.OptionsColumn.ReadOnly = false;
                    //tri
                    //this.gridView2.OptionsBehavior.Editable = true;
                    //
                    if (this.CheckTransTypeNx3)
                    {
                        this.colQuantity.OptionsColumn.AllowEdit = true;
                        this.colQuantity.OptionsColumn.AllowFocus = true;
                        this.colQuantity.OptionsColumn.ReadOnly = false;
                    }
                }
            }
        }

        private void ChkGetByWeightItemContainer_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void btnCheckWeightItemContainer_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string scode = "";
            StockTransaction st = this.DataSource as StockTransaction;
            //if (st.TransactionID == null) st.TransactionID = Guid.Empty;
            string transTypeCode = string.Empty;
            if (lookupTransactionTypeCode.EditValue != null) transTypeCode = lookupTransactionTypeCode.EditValue.ToString();
            if (this.EditMode != FormEditMode.VIEW)
            {
                if (this.IsInStock && lookUpInStock.EditValue != null) scode = lookUpInStock.EditValue.ToString();
                if (this.IsOutStock && lookUpOutStock.EditValue != null) scode = lookUpOutStock.EditValue.ToString();
                string[] fields = { "WeightDate", "WeightCode", "ItemCode", "Quantity", "WrappingWeight", "ItemWeight", "StockLocationCode", "WrappingType", "Weight1", "WeightTime1", "Weight2", "WeightTime2", "PTVanChuyen", "PTTrungChuyen", "DVVanChuyen", "TransactionTypeCode", "KhoGiaoNhan", "Description" };
                string[] header = { "Ngày cân", "Số phiếu", "Mã hàng", "Số bao", "Bì bao", "Trọng lượng hàng", "Lô hàng", "Loại bao bì", "Cân lần 1", "Thời gian cân", "Cân lần 2", "Thời gian cân", "PT vận chuyển", "PT trung chuyển", "ĐV vận chuyển", "Mã NX", "Kho giao/nhận", "Diễn giải" };
                ListBase<WeightItemContainer> lstWIC = new WeightItemContainerBLL().GetByStockCodeAndIsReceive(st.TransactionID, transTypeCode, scode, this.IsInStock);
               
                if (st.LstWICCheck == null)
                {
                    st.LstWICCheck = new ListBase<WeightItemContainer>();
                    foreach (WeightItemContainer wic1 in lstWIC)
                    {
                        if (wic1.TransactionID != Guid.Empty && wic1.TransactionID != null)
                        {
                            st.LstWICCheck.Add(wic1.Clone() as WeightItemContainer);
                        }
                    }
                }
                object lstWICChecktmp = VNS.Windows.Forms.FormCheck.Show(lstWIC, fields, header, -1, "WeightContainerID", st.LstWICCheck, "WeightContainerID");

                if (lstWICChecktmp != null)
                {
                    //tri
                    (dataSource as StockTransaction).Details.Clear();
                    //
                    System.Collections.ArrayList arrWICCheck = lstWICChecktmp as System.Collections.ArrayList;
                   // st.LstWICCheck = new ListBase<WeightItemContainer>();
                    st.LstWICCheck.Clear();
                    foreach (WeightItemContainer wic1 in arrWICCheck)
                    {
                        //wic1.TransactionID = st.TransactionID;
                        WeightItemContainer w = new WeightItemContainer();
                        w.CopyFrom(wic1);
                        st.LstWICCheck.Add(w);
                        //st.LstWICCheck.Add(wic1.Clone() as WeightItemContainer);
                    }
                    if (arrWICCheck.Count > 0)
                    {
                        if ((dataSource as StockTransaction).Details != null)
                        {
                            foreach (StockTransactionSumDetail stsd in (dataSource as StockTransaction).Details)
                            {
                                stsd.Quantity = 0;
                                stsd.lstStockTransactionDetail.Clear();
                            }
                        }
                    }
//                    if(st.Details == null) st.de
                    ListBase<StockTransactionSumDetail> lstStockTransSumDetail = st.Details as ListBase<StockTransactionSumDetail>;
                    StockTransactionSumDetail stsd1 = null;
                    foreach (WeightItemContainer wic in st.LstWICCheck)
                    {
                        stsd1 = lstStockTransSumDetail.Search("ItemCode", wic.ItemCode);
                        if (stsd1 == null)
                        {
                            stsd1 = new StockTransactionSumDetail();
                            stsd1.ItemCode = wic.ItemCode;
                            stsd1.Quantity = wic.ItemWeight;
                            //stsd.QuantityReg = wic.ItemWeight;
                            //stsd1.QuantityInclWrapping = wic.ItemWeight + wic.TotalWrappingWeight;
                            //tri
                            stsd1.QuantityInclWrapping = Math.Abs(wic.Weight1 - wic.Weight2);
                            stsd1.WrappingCounter = Convert.ToInt32(wic.Quantity);
                            stsd1.lstStockTransactionDetail = new ListBase<StockTransactionDetail>();
                            StockTransactionDetail std = new StockTransactionDetail();
                            std.ItemCode = wic.ItemCode;
                            if (wic.IsReceive) std.InLocation = wic.StockLocationCode;
                            else std.OutLocation = wic.StockLocationCode;
                            std.Quantity = wic.ItemWeight;
                            stsd1.lstStockTransactionDetail.Add(std);
                            lstStockTransSumDetail.Add(stsd1);
                        }
                        else
                        {
                            stsd1.Quantity += wic.ItemWeight;
                            //stsd1.QuantityInclWrapping += wic.ItemWeight + wic.TotalWrappingWeight;
                            //tri
                            stsd1.QuantityInclWrapping += Math.Abs(wic.Weight1 - wic.Weight2);
                            stsd1.WrappingCounter += Convert.ToInt32(wic.Quantity);
                            StockTransactionDetail std = null;
                            if (wic.IsReceive)
                                std = stsd1.lstStockTransactionDetail.Search("InLocation", wic.StockLocationCode);
                            else std = stsd1.lstStockTransactionDetail.Search("OutLocation", wic.StockLocationCode);
                            if (std == null)
                            {
                                std = new StockTransactionDetail();
                                std.ItemCode = wic.ItemCode;
                                if (wic.IsReceive) std.InLocation = wic.StockLocationCode;
                                else std.OutLocation = wic.StockLocationCode;
                                std.Quantity = wic.ItemWeight;
                                stsd1.lstStockTransactionDetail.Add(std);
                            }
                            else
                            {
                                std.Quantity += wic.ItemWeight;
                            }
                        }
                    }
                    if (arrWICCheck.Count > 0)
                    {
                        allowGetByWeightItem = false;
                        ChkGetByWeightItemContainer.Checked = true;
                        allowGetByWeightItem = true;
                        gridControl1.RefreshDataSource();
                        //foreach (WeightItemContainer wic2 in lstWICCheck)
                        //{
                        //    wic2.TransactionID = st.TransactionID;
                        //}
                        // st.LstWICCheck = lstWICCheck;
                        gridControl1.DataSource = null;
                        gridControl1.DataSource = (dataSource as StockTransaction).Details;

                        this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                        this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                        if (this.CheckTransTypeNx3)
                        {
                            this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
                        }
                        this.colInLocation.OptionsColumn.ReadOnly = !this.CheckTransTypeNx3;
                        this.colItemCode.OptionsColumn.ReadOnly = true;
                        this.colOutLocation.OptionsColumn.ReadOnly = !this.CheckTransTypeNx3;
                        this.colQuantity1.OptionsColumn.ReadOnly = !this.CheckTransTypeNx3;
                        //tri
                        //this.gridView2.OptionsBehavior.Editable = this.CheckTransTypeNx3;
                        //
                    }
                    else
                    {
                        ChkGetByWeightItemContainer.Checked = false;
                    }

                }
                else
                {
                    //                    btnEditSoDH.Properties.ReadOnly
                    //StockTransactionBLL.lstWeightItemChose = null;
                    //ChkGetByWeightItem.Checked = false;
                }
            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW && !this.ChkGetByWeightItem.Checked && !this.ChkGetByWeightItemContainer.Checked)
            {
                if (this.gridView1.RowCount > 0 && this.gridView1.OptionsBehavior.Editable == true)
                {
                    if (e.KeyCode == Keys.Delete)
                        if (this.gridView1.FocusedRowHandle < 0)
                        { }
                        else
                            this.gridView1.DeleteRow(this.gridView1.FocusedRowHandle);
                    if (e.KeyCode == Keys.Insert)
                        if (this.gridView1.FocusedRowHandle < 0)
                        { }
                        else
                        {
                            System.Type type = (gridView1.DataSource as IList)[0].GetType();
                            object obj = Activator.CreateInstance(type);
                            (gridView1.DataSource as IList).Insert(this.gridView1.FocusedRowHandle, obj);
                        }
                }
            }
        }

        private void gridView2_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW && !this.ChkGetByWeightItem.Checked && !this.ChkGetByWeightItemContainer.Checked)
            {
                GridView gv = this.gridControl1.FocusedView as GridView;
                if (gv.RowCount > 0 && gv.OptionsBehavior.Editable == true)
                {
                    if (e.KeyCode == Keys.Delete)
                        if (gv.FocusedRowHandle < 0)
                        { }
                        else
                            gv.DeleteRow(gv.FocusedRowHandle);
                    if (e.KeyCode == Keys.Insert)
                        if (gv.FocusedRowHandle < 0)
                        { }
                        else
                        {
                            System.Type type = (gv.DataSource as IList)[0].GetType();
                            object obj = Activator.CreateInstance(type);
                            (gv.DataSource as IList).Insert(gv.FocusedRowHandle, obj);
                        }
                }
            }
        }

        

        void GetDataCanme(DateTime date)
        {
            string preNo = date.ToString("yyMMdd");

            ModuleStock ms = new ModuleBLL().GetModuleStock();
            OleDbConnection objConnect = new OleDbConnection();

            objConnect.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source=" + ms.CanmeDBFilePath;
            objConnect.Open();

            OleDbDataAdapter ole = new OleDbDataAdapter();
            ole.SelectCommand = new OleDbCommand();
            ole.SelectCommand.Connection = objConnect;
            ole.SelectCommand.CommandText = "Select p.*,h.MaHH,h.TenHang,m.TrongLuongS as TrongLuong from (PhieuCan p inner join HangHoa h on p.IDMaHH=h.IDMaHH)"+
                " inner join (select MaPhieu,sum(TrongLuong) as TrongLuongS from MeCan group by MaPhieu) m on p.MaPhieu=m.MaPhieu"+
            " where left(p.SoPhieu,6)='" + date.ToString("yyMMdd") + "'";

            DataTable dt = new DataTable();
            ole.Fill(dt);

            objConnect.Close();
            objConnect.Dispose();

            string[] fields = { "SoPhieu", "MaHH","TenHang","TrongLuong","PhuongTien", "GhiChu" };
            string[] headers = { "Số phiếu cân","Mã hàng","Tên hàng","Trọng lượng", "Phương tiện", "Ghi chú" };
            DataRowView dr;

            dr = (FormSearch.ShowSearch(dt, fields, headers) as DataRowView);
            if (dr != null)
            {
                txtCanmeNo.EditValue = dr["SoPhieu"].ToString();

                StockTransaction st = this.DataSource as StockTransaction;
                st.Details.Clear();
                StockTransactionSumDetail stsd = new StockTransactionSumDetail();
                stsd.ItemCode = dr["MaHH"].ToString();
                stsd.Quantity = Math.Round(Convert.ToDecimal(dr["TrongLuong"]), 0, MidpointRounding.AwayFromZero);
                st.Details.Add(stsd);
            }
        }

        private void txtCanmeNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (this.EditMode == FormEditMode.VIEW)
                return;
            GetDataCanme(this.dateEditTransaction.DateTime);
        }

    }
}
