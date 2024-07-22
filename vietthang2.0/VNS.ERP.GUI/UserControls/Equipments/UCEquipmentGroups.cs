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
    public partial class UCEquipmentGroups : EditControlBase
    {
        public UCEquipmentGroups()
        {
            InitializeComponent();
        }

        protected override void BindData()
        {
            base.BindData();
            if (dataSource != null)
            {
                EquipmentGroup equipmentGroup = (dataSource as EquipmentGroup);
                this.txtGroupCode.Text = equipmentGroup.GroupCode;
                this.txtGroupName.Text = equipmentGroup.GroupName;
                this.memoEditDescription.Text = equipmentGroup.Description;
            }
        }

        protected override void AssignData()
        {
            if (dataSource == null) dataSource = new EquipmentGroup();
            EquipmentGroup equipmentGroup = (dataSource as EquipmentGroup);
            if (this.EditMode == FormEditMode.ADD)
            {
                equipmentGroup.UserCreated = Contexts.CurrentUser.LoginName;
                //linesxs.DateCreated = DateTime.Now;
            }
            equipmentGroup.GroupCode = this.txtGroupCode.Text.ToString();
            equipmentGroup.GroupName = this.txtGroupName.Text.ToString();
            equipmentGroup.Description = this.memoEditDescription.Text.ToString();
            equipmentGroup.UserUpdated = Contexts.CurrentUser.LoginName;
            base.AssignData();
        }

        protected override void InitDataObject()
        {
            base.InitDataObject();
        }

        protected override int ValidateData()
        {
            if (this.txtGroupCode.Text.ToString() == String.Empty)
            {
                this.txtGroupCode.Focus();
                return -1;
            }
            if (this.txtGroupName.Text.ToString() == String.Empty)
            {
                this.txtGroupName.Focus();
                return -2;
            }

            return 0;
        }

        public override void RefreshControl()
        {
            if (this.EditMode == FormEditMode.ADD)
            {
                this.txtGroupCode.Properties.ReadOnly = false;
                this.txtGroupName.Properties.ReadOnly = false;
                this.memoEditDescription.Properties.ReadOnly = false;
                this.txtGroupCode.Focus();
            }

            else
            {
                if (this.EditMode == FormEditMode.EDIT)
                {
                    this.txtGroupCode.Properties.ReadOnly = true;
                    this.txtGroupName.Properties.ReadOnly = false;
                    this.memoEditDescription.Properties.ReadOnly = false;
                    this.txtGroupName.Focus();
                }
                else
                {
                    this.txtGroupCode.Properties.ReadOnly = true;
                    this.txtGroupName.Properties.ReadOnly = true;
                    this.memoEditDescription.Properties.ReadOnly = true;
                }
            }


            if (dataSource == null)
            {
                this.txtGroupCode.Text = String.Empty;
                this.txtGroupName.Text = String.Empty;
                this.memoEditDescription.Text = String.Empty;
            }

            base.RefreshControl();
        }
    }
}

