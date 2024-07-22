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
    public partial class UCEquipmentsxs : EditControlBase
    {
        public UCEquipmentsxs()
        {
            InitializeComponent();
        }

        protected override void BindData()
        {
            base.BindData();
            if (dataSource != null)
            {
                Equipmentsx equipmentsx = (dataSource as Equipmentsx);
                this.txtEquipmentsxCode.Text = equipmentsx.EquipmentsxCode;
                this.txtEquipmentsxName.Text = equipmentsx.EquipmentsxName;
                this.memoEditDescription.Text = equipmentsx.Description;
            }
        }

        protected override void AssignData()
        {
            if (dataSource == null) dataSource = new Equipmentsx();
            Equipmentsx equipmentsx = (dataSource as Equipmentsx);
            if (this.EditMode == FormEditMode.ADD)
            {
                equipmentsx.UserCreated = Contexts.CurrentUser.LoginName;
                //linesxs.DateCreated = DateTime.Now;
            }
            equipmentsx.EquipmentsxCode = this.txtEquipmentsxCode.Text.ToString();
            equipmentsx.EquipmentsxName = this.txtEquipmentsxName.Text.ToString();
            equipmentsx.Description = this.memoEditDescription.Text.ToString();
            equipmentsx.UserUpdated = Contexts.CurrentUser.LoginName;
            base.AssignData();
        }

        protected override void InitDataObject()
        {
            base.InitDataObject();
        }

        protected override int ValidateData()
        {
            if (this.txtEquipmentsxCode.Text.ToString() == String.Empty)
            {
                this.txtEquipmentsxCode.Focus();
                return -1;
            }
            if (this.txtEquipmentsxName.Text.ToString() == String.Empty)
            {
                this.txtEquipmentsxName.Focus();
                return -2;
            }

            return 0;
        }

        public override void RefreshControl()
        {
            if (this.EditMode == FormEditMode.ADD)
            {
                this.txtEquipmentsxCode.Properties.ReadOnly = false;
                this.txtEquipmentsxName.Properties.ReadOnly = false;
                this.memoEditDescription.Properties.ReadOnly = false;
                this.txtEquipmentsxCode.Focus();
            }

            else
            {
                if (this.EditMode == FormEditMode.EDIT)
                {
                    this.txtEquipmentsxCode.Properties.ReadOnly = true;
                    this.txtEquipmentsxName.Properties.ReadOnly = false;
                    this.memoEditDescription.Properties.ReadOnly = false;
                    this.txtEquipmentsxName.Focus();
                }
                else
                {
                    this.txtEquipmentsxCode.Properties.ReadOnly = true;
                    this.txtEquipmentsxName.Properties.ReadOnly = true;
                    this.memoEditDescription.Properties.ReadOnly = true;
                }
            }


            if (dataSource == null)
            {
                this.txtEquipmentsxCode.Text = String.Empty;
                this.txtEquipmentsxName.Text = String.Empty;
                this.memoEditDescription.Text = String.Empty;
            }

            base.RefreshControl();
        }
    }
}

