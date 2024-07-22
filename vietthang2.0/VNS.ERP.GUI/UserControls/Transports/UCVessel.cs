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
    public partial class UCVessel : EditControlBase
    {

        public UCVessel()
        {
            InitializeComponent();
           
        }
        protected override void BindData()
        {
            if (this.DataSource != null)
            {
                this.txtVesselCode.Text = (dataSource as Vessel).VesselCode;
                this.txtVesselName.Text = (dataSource as Vessel).VesselName;
                this.txtDescription.Text = (dataSource as Vessel).Description;
            }

            base.BindData();
        }
        protected override int ValidateData()
        {
            if (this.txtVesselCode.Text == string.Empty) 
            {
                this.txtVesselCode.Focus();
                return -1;
            }
            if (this.txtVesselName.Text == string.Empty) 
            {
                this.txtVesselName.Focus();
                return -2;
            }
            return base.ValidateData();
        }
        protected override void AssignData()
        {
            if (dataSource == null) dataSource = new Vessel();
            (dataSource as Vessel).VesselCode = this.txtVesselCode.Text;
            (dataSource as Vessel).VesselName = this.txtVesselName.Text;
            (dataSource as Vessel).Description = this.txtDescription.Text;           

            base.AssignData();
        }
        public override void RefreshControl()
        {
            this.txtVesselCode.Properties.ReadOnly = (this.editMode != FormEditMode.ADD);
            this.txtVesselName.Properties.ReadOnly = (this.editMode == FormEditMode.VIEW);
            this.txtDescription.ReadOnly = (this.editMode == FormEditMode.VIEW);
            if (this.editMode == FormEditMode.ADD)
            {
                this.txtVesselCode.Focus();
            }   
            if (this.editMode == FormEditMode.EDIT)
            {              
                this.txtVesselName.Focus();
            }           
            base.RefreshControl();
        }

    }
}
