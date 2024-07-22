using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.ERP.Data;
using VNS.Common;
using VNS.Windows;
using DevExpress.XtraEditors.Controls;

namespace VNS.ERP.GUI.Equipments
{
    public partial class UCLinesx : EditControlBase
    {
        //private Linesxs linesxs = new Linesxs();

        public UCLinesx()
        {
            InitializeComponent();
        }

        protected override void BindData()
        {
            base.BindData();
            if (dataSource != null)
            {
                Linesxs linesxs = (dataSource as Linesxs);
                this.txtLinesxNo.EditValue = linesxs.LinesxNo.ToString();
                this.txtNangsuat.EditValue = linesxs.Nangsuat.ToString();
                this.txtNangsuatlot.EditValue = linesxs.NangsuatLot.ToString();
                this.lookUpEditStockCode.EditValue = linesxs.StockCode.ToString();
                this.memoEditDescription.Text = linesxs.Description;
            }
           
        }

        protected override void AssignData()
        {
            if(dataSource==null) dataSource = new Linesxs();
            Linesxs linesxs = (dataSource as Linesxs);
            if (this.EditMode == FormEditMode.ADD)
            {
                linesxs.UserCreated = Contexts.CurrentUser.LoginName;
                //linesxs.DateCreated = DateTime.Now;
            }
            linesxs.LinesxNo = Convert.ToInt32(this.txtLinesxNo.EditValue.ToString());
            linesxs.StockCode = this.lookUpEditStockCode.EditValue.ToString();
            linesxs.Nangsuat = Convert.ToInt32(this.txtNangsuat.EditValue.ToString());
            linesxs.NangsuatLot = Convert.ToInt32(this.txtNangsuatlot.EditValue.ToString());
            linesxs.Description = this.memoEditDescription.Text.ToString();
            linesxs.UserUpdated = Contexts.CurrentUser.LoginName;
            base.AssignData();
        }

        protected override void InitDataObject()
        {
            base.InitDataObject();

            if (!this.DesignMode)
            {
                //this.lookUpEditStockCode.Properties.DataSource = (new StockBLL().GetBaohiem());
                ListBase<Stock> ds = new StockBLL().GetAll();
                //Currency t = new Currency();
                //t.CurrencyCode = string.Empty;
                //ds.Insert(0, t);
                this.lookUpEditStockCode.Properties.DataSource = ds;
                //this.lookUpEditCurrencyCode.ItemIndex = 0;


                //this.lookUpEditCurrencyCode.Properties.DataSource = (new CurrencyBL().GetAll());
            }
        }
        protected override int ValidateData()
        {
            if (this.txtLinesxNo.Text == String.Empty)
            {
                this.txtLinesxNo.Focus();
                return -1;
            }
            if (this.lookUpEditStockCode.EditValue.ToString() == String.Empty)
            {
                this.lookUpEditStockCode.Focus();
                return -2;
            }
            return 0;
        }

        public override void RefreshControl()
        {

            if (this.EditMode == FormEditMode.ADD)
            {
                this.txtLinesxNo.Properties.ReadOnly = false;
                this.lookUpEditStockCode.Properties.ReadOnly = false;
                this.txtNangsuat.Properties.ReadOnly = false;
                this.txtNangsuatlot.Properties.ReadOnly = false;
                this.memoEditDescription.Properties.ReadOnly = false;
                this.txtLinesxNo.Focus();
            }

            else
            {
                if (this.EditMode == FormEditMode.EDIT)
                {
                    this.txtLinesxNo.Properties.ReadOnly = true;
                    this.lookUpEditStockCode.Properties.ReadOnly = false;
                    this.txtNangsuat.Properties.ReadOnly = false;
                    this.txtNangsuatlot.Properties.ReadOnly = false;
                    this.memoEditDescription.Properties.ReadOnly = false;
                    this.lookUpEditStockCode.Focus();
                }
                else
                {
                    this.txtLinesxNo.Properties.ReadOnly = true;
                    this.lookUpEditStockCode.Properties.ReadOnly = true;
                    this.txtNangsuat.Properties.ReadOnly = true;
                    this.txtNangsuatlot.Properties.ReadOnly = true;
                    this.memoEditDescription.Properties.ReadOnly = true;
                }
            }

   
            if (dataSource == null)
            {
                this.txtLinesxNo.Text = String.Empty;
                this.lookUpEditStockCode.EditValue = String.Empty;
                this.txtNangsuat.Text = String.Empty;
                this.txtNangsuatlot.Text = String.Empty;
                this.memoEditDescription.Text = String.Empty;
            }

            base.RefreshControl();
        }
    }
}

