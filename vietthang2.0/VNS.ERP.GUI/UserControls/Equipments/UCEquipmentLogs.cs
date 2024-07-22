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
using VNS.ERP.Data.Equipments;
using DevExpress.XtraEditors.Controls;


namespace VNS.ERP.GUI.Equipments
{
    public partial class UCEquipmentLogs : EditControlBase
    {
        public UCEquipmentLogs()
        {
            InitializeComponent();
        }
        protected override void BindData()
        {
            base.BindData();
            if (dataSource != null)
            {
                EquipmentLog equipmentLog = (dataSource as EquipmentLog);
                this.lookUpEditEquipmentCode.EditValue = equipmentLog.EquipmentCode.ToString();
                this.dateEditStartDate.DateTime = equipmentLog.StartDate;
                this.lookUpEditStockCode.EditValue = equipmentLog.StockCode.ToString();
                this.memoEditDescription.Text = equipmentLog.Description;
            }

        }

        protected override void AssignData()
        {
            if (dataSource == null) dataSource = new EquipmentLog();
            EquipmentLog equipmentLog = (dataSource as EquipmentLog);
            if (this.EditMode == FormEditMode.ADD)
            {
                equipmentLog.UserCreated = Contexts.CurrentUser.LoginName;
                //linesxs.DateCreated = DateTime.Now;
            }
            equipmentLog.EquipmentCode = this.lookUpEditEquipmentCode.EditValue.ToString();
            equipmentLog.StartDate = this.dateEditStartDate.DateTime;
            equipmentLog.StockCode = this.lookUpEditStockCode.EditValue.ToString();
            equipmentLog.Description = this.memoEditDescription.Text.ToString();
            equipmentLog.UserUpdated = Contexts.CurrentUser.LoginName;
            base.AssignData();
        }

        protected override void InitDataObject()
        {
            base.InitDataObject();

            if (!this.DesignMode)
            {
                ListBase<Equipment> ds = new EquipmentBLL().GetAll();
                this.lookUpEditEquipmentCode.Properties.DataSource = ds;
                ListBase<Stock> ds2 = new StockBLL().GetAll();
                this.lookUpEditStockCode.Properties.DataSource = ds2;
            }
        }
        protected override int ValidateData()
        {
            if (this.lookUpEditEquipmentCode.EditValue.ToString() == String.Empty)
            {
                this.lookUpEditEquipmentCode.Focus();
                return -1;
            }
            //if (this.txtLinesxNo.Text == String.Empty)
            //{
            //    this.txtLinesxNo.Focus();
            //    return -2;
            //}
            return 0;
        }

        public override void RefreshControl()
        {

            if (this.EditMode == FormEditMode.ADD)
            {
                this.lookUpEditEquipmentCode.Properties.ReadOnly = false;
                this.dateEditStartDate.Properties.ReadOnly = false;
                this.lookUpEditStockCode.Properties.ReadOnly = false;
                this.memoEditDescription.Properties.ReadOnly = false;
                this.lookUpEditEquipmentCode.Focus();
            }

            else
            {
                if (this.EditMode == FormEditMode.EDIT)
                {
                    this.lookUpEditEquipmentCode.Properties.ReadOnly = true;
                    this.dateEditStartDate.Properties.ReadOnly = true;
                    this.lookUpEditStockCode.Properties.ReadOnly = false;
                    this.memoEditDescription.Properties.ReadOnly = false;
                    this.lookUpEditStockCode.Focus();
                }
                else
                {
                    this.lookUpEditEquipmentCode.Properties.ReadOnly = true;
                    this.dateEditStartDate.Properties.ReadOnly = true;
                    this.lookUpEditStockCode.Properties.ReadOnly = true;
                    this.memoEditDescription.Properties.ReadOnly = true;
                }
            }


            if (dataSource == null)
            {
                this.lookUpEditEquipmentCode.EditValue = String.Empty;
                //this.dateEditStartDate.DateTime = String.Empty;
                this.lookUpEditStockCode.EditValue = String.Empty;
                this.memoEditDescription.Text = String.Empty;
            }

            base.RefreshControl();
        }
    }
}

