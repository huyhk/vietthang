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
    public partial class UCEquipments : EditControlBase
    {
        public UCEquipments()
        {
            InitializeComponent();
        }

        protected override void BindData()
        {
            base.BindData();
            if (dataSource != null)
            {
                Equipment equipment = (dataSource as Equipment);
                this.txtEquipmentCode.Text = equipment.EquipmentCode.ToString();
                this.txtEquipmentName.Text = equipment.EquipmentName.ToString();
                this.lookUpEditGroupCode.EditValue = equipment.GroupCode.ToString();
                this.memoEditDescription.Text = equipment.Description;
            }

        }

        protected override void AssignData()
        {
            if (dataSource == null) dataSource = new Equipment();
            Equipment equipment = (dataSource as Equipment);
            if (this.EditMode == FormEditMode.ADD)
            {
                equipment.UserCreated = Contexts.CurrentUser.LoginName;
                //linesxs.DateCreated = DateTime.Now;
            }
            equipment.EquipmentCode = this.txtEquipmentCode.Text.ToString();
            equipment.EquipmentName = this.txtEquipmentName.Text.ToString();
            equipment.GroupCode = this.lookUpEditGroupCode.EditValue.ToString();
            equipment.Description = this.memoEditDescription.Text.ToString();
            equipment.UserUpdated = Contexts.CurrentUser.LoginName;
            base.AssignData();
        }

        protected override void InitDataObject()
        {
            base.InitDataObject();

            if (!this.DesignMode)
            {
                ListBase<EquipmentGroup> ds = new EquipmentGroupBLL().GetAll();
                this.lookUpEditGroupCode.Properties.DataSource = ds;
            }
        }
        protected override int ValidateData()
        {
            if (this.txtEquipmentCode.Text.ToString() == String.Empty)
            {
                this.txtEquipmentCode.Focus();
                return -1;
            }
            if (this.txtEquipmentName.Text.ToString() == String.Empty)
            {
                this.txtEquipmentName.Focus();
                return -2;
            }
            return 0;
        }

        public override void RefreshControl()
        {

            if (this.EditMode == FormEditMode.ADD)
            {
                this.txtEquipmentCode.Properties.ReadOnly = false;
                this.txtEquipmentName.Properties.ReadOnly = false;
                this.lookUpEditGroupCode.Properties.ReadOnly = false;
                this.memoEditDescription.Properties.ReadOnly = false;
                this.txtEquipmentCode.Focus();
            }

            else
            {
                if (this.EditMode == FormEditMode.EDIT)
                {
                    this.txtEquipmentCode.Properties.ReadOnly = true;
                    this.txtEquipmentName.Properties.ReadOnly = false;
                    this.lookUpEditGroupCode.Properties.ReadOnly = false;
                    this.memoEditDescription.Properties.ReadOnly = false;
                    this.txtEquipmentName.Focus();
                }
                else
                {
                    this.txtEquipmentCode.Properties.ReadOnly = true;
                    this.txtEquipmentName.Properties.ReadOnly = true;
                    this.lookUpEditGroupCode.Properties.ReadOnly = true;
                    this.memoEditDescription.Properties.ReadOnly = true;
                }
            }


            if (dataSource == null)
            {
                this.txtEquipmentCode.Text = String.Empty;
                this.txtEquipmentName.Text = String.Empty;
                this.lookUpEditGroupCode.EditValue = String.Empty;
                this.memoEditDescription.Text = String.Empty;
            }

            base.RefreshControl();
        }
    }
}

