using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.ERP.Data;
using VNS.Windows;
using VNS.Common;
namespace VNS.ERP.GUI
{
    public partial class UCTransportRoute : EditControlBase
    {
        public UCTransportRoute()
        {
            InitializeComponent();
        }
        protected override void InitDataObject()
        {
            base.InitDataObject();
            ListBase<Stock> listStock = new StockBLL().GetAll();
            Stock stock = new Stock();
            listStock.Insert(0, stock);
            this.lkStockIn.Properties.DataSource = listStock;
            this.lkStockOut.Properties.DataSource = listStock;
        }
        protected override void BindData()
        {
            if (this.DataSource != null)
            {
                this.txtMaLoai.Text = (dataSource as TransportRoute).RouteCode;
                this.txtTenLoai.Text = (dataSource as TransportRoute).RouteName;
                this.lkStockIn.EditValue = (dataSource as TransportRoute).StockIn;
                this.lkStockOut.EditValue = (dataSource as TransportRoute).StockOut;
                this.chIsTrungchuyen.Checked = (dataSource as TransportRoute).IsTrungchuyen;
                this.memoMoTa.Text = (dataSource as TransportRoute).Description;
                
            }

        }
        protected override int ValidateData()
        {
            if (this.txtMaLoai.Text == string.Empty)
            {
                this.txtMaLoai.Focus();
                return -1;
            }
            if (this.txtTenLoai.Text == string.Empty)
            {
                this.txtTenLoai.Focus();
                return -2;
            }

            return 0;
        }
        protected override void AssignData()
        {

            if (dataSource == null)
                dataSource = new TransportRoute();
            (dataSource as TransportRoute).RouteCode = this.txtMaLoai.Text;
            (dataSource as TransportRoute).RouteName = this.txtTenLoai.Text;
            (dataSource as TransportRoute).StockIn = (string)this.lkStockIn.EditValue;
            (dataSource as TransportRoute).StockOut = (string)this.lkStockOut.EditValue;
            (dataSource as TransportRoute).IsTrungchuyen = this.chIsTrungchuyen.Checked;
            (dataSource as TransportRoute).Description = this.memoMoTa.Text;
            if (this.EditMode == VNS.Windows.FormEditMode.ADD)
            {

                (dataSource as TransportRoute).UserCreated = Contexts.CurrentUser.LoginName;
                (dataSource as TransportRoute).DateCreated = DateTime.Now;
            }
            (dataSource as TransportRoute).UserUpdated = Contexts.CurrentUser.LoginName;
            (dataSource as TransportRoute).DateUpdated = DateTime.Now;
            base.AssignData();
        }
        public override void RefreshControl()
        {
            if (this.editMode == FormEditMode.ADD)
            {
                this.txtMaLoai.Properties.ReadOnly = false;
                this.txtTenLoai.Properties.ReadOnly = false;
                this.lkStockIn.Properties.ReadOnly = false;
                this.lkStockOut.Properties.ReadOnly = false;
                this.chIsTrungchuyen.Properties.ReadOnly = false;
                this.memoMoTa.Properties.ReadOnly = false;
                this.txtTenLoai.Focus();
                this.txtMaLoai.Focus();
            }
            else if (this.editMode == FormEditMode.EDIT)
            {
                this.txtTenLoai.Properties.ReadOnly = false;
                this.txtMaLoai.Properties.ReadOnly = true;
                this.lkStockIn.Properties.ReadOnly = false;
                this.lkStockOut.Properties.ReadOnly = false;
                this.chIsTrungchuyen.Properties.ReadOnly = false;
                this.memoMoTa.Properties.ReadOnly = false;
                this.txtTenLoai.Focus();

            }
            else// (this.editMode == FormEditMode.VIEW)
            {

                this.txtMaLoai.Properties.ReadOnly = true;
                this.txtTenLoai.Properties.ReadOnly = true;
                this.lkStockIn.Properties.ReadOnly = true;
                this.lkStockOut.Properties.ReadOnly = true;
                this.chIsTrungchuyen.Properties.ReadOnly = true;
                this.memoMoTa.Properties.ReadOnly = true;
            }
            base.RefreshControl();
        }

   
    }
}
