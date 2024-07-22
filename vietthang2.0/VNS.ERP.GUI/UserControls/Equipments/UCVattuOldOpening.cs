using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.ERP.Data;
using VNS.ERP.Data.Equipments;
using VNS.Windows;
using System.Collections;

namespace VNS.ERP.GUI.Equipments
{
    public partial class UCVattuOldOpening : EditControlBase
    {
        public UCVattuOldOpening()
        {
            InitializeComponent();
            
        }
        protected override void BindData()
        {
            base.BindData();
            if (this.DataSource != null)
            {
                this.gridControl1.DataSource = (DataSource as VattuOldOpeningList).ListVattuOldOpening; 
            }
        }
        protected override void InitDataObject()
        {
            base.InitDataObject();
            if(!DesignMode)
            {
                this.replkStockCode.DataSource=new StockBLL().GetAll();
                this.replkVattu.DataSource=new VattuBLL().GetAll();
                this.replkVattuOldType.DataSource = new VattuOldTypeBLL().GetAll();
            }
        }
        public override void RefreshControl()
        {
            this.gridView1.OptionsBehavior.Editable = (this.EditMode != FormEditMode.VIEW);
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            
            base.RefreshControl();

        }

        private void gridView1_GotFocus(object sender, EventArgs e)
        {
            if (gridView1.DataRowCount == 0)
                gridView1.MoveFirst();
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.gridView1.FocusedRowHandle >= 0 && this.gridView1.OptionsBehavior.Editable == true)
            {
                if (e.KeyCode == Keys.Delete)
                    this.gridView1.DeleteRow(this.gridView1.FocusedRowHandle);
            }
            if (e.KeyCode == Keys.Insert && this.gridView1.OptionsBehavior.Editable == true)
            {
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
}
