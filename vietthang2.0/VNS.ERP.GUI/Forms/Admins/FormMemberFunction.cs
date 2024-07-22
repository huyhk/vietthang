using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;

namespace VNS.ERP.GUI
{
    public partial class FormMemberFunction : FormEditBase
    {
        string memberID;
        MemberFunctionBLL bll = new MemberFunctionBLL();
        public FormMemberFunction()
        {
            InitializeComponent();
            //repositoryItemCheckEdit2.CheckedChanged += new EventHandler(repositoryItemCheckEdit234_CheckedChanged);
            //repositoryItemCheckEdit3.CheckedChanged += new EventHandler(repositoryItemCheckEdit234_CheckedChanged);
            //repositoryItemCheckEdit4.CheckedChanged += new EventHandler(repositoryItemCheckEdit234_CheckedChanged);
            this.GridControl = gridControl2;
            this.DataSource = new MemberBLL<Member>().GetAll();
            this.LookUpModuleType.DataSource = EnumDisplays.GetListenumModuleType();
            this.LookupMemberType.DataSource = EnumDisplays.GetListenumMemberType();
            this.gridControl2.Refresh();
            this.gridControl2.RefreshDataSource();
           //gridView2.ExpandAllGroups();
            //gridControl2.DataSource = new MemberBLL<Member>().GetAll();
            //this.btnEdit.Enabled = true;
            //this.WindowState = FormWindowState.Maximized;
        }

        void repositoryItemCheckEdit234_CheckedChanged(object sender, EventArgs e)
        {
            CurrencyManager cr = this.BindingContext[this.gridControl1.DataSource] as CurrencyManager;
            DataRowView DR = (cr.Current as DataRowView);
            if ((sender as DevExpress.XtraEditors.CheckEdit).Checked)
            {
                DR["AllowView"] = true;
            }
        }
       

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CurrencyManager cr = this.BindingContext[this.gridControl2.DataSource] as CurrencyManager;
            memberID = (cr.Current as Member).MemberID;
            gridControl1.DataSource = bll.DTGetByMemberID(memberID);
           // gridView1.ExpandAllGroups();
            //gridControl1.Refresh();
        }
        protected override bool SaveData()
        {
            DataTable DT = gridControl1.DataSource as DataTable;
            int iError = bll.UpdateForMemberID(memberID, ref DT);
            if (iError == 0)
            {
                gridControl2.Enabled = true;
                colAllowAdd.OptionsColumn.AllowFocus = false;
                colAllowAdd.OptionsColumn.AllowEdit = false;
                colAllowAdd.OptionsColumn.ReadOnly = true;
                colAllowView.OptionsColumn.AllowFocus = false;
                colAllowView.OptionsColumn.AllowEdit = false;
                colAllowView.OptionsColumn.ReadOnly = true;
                colAllowEdit.OptionsColumn.AllowFocus = false;
                colAllowEdit.OptionsColumn.AllowEdit = !true;
                colAllowEdit.OptionsColumn.ReadOnly = !false;
                colAllowDelete.OptionsColumn.AllowFocus = !true;
                colAllowDelete.OptionsColumn.AllowEdit = !true;
                colAllowDelete.OptionsColumn.ReadOnly = !false;

                colAllowEditOther.OptionsColumn.AllowFocus = false;
                colAllowEditOther.OptionsColumn.AllowEdit = !true;
                colAllowEditOther.OptionsColumn.ReadOnly = !false;
                colAllowDeleteOther.OptionsColumn.AllowFocus = !true;
                colAllowDeleteOther.OptionsColumn.AllowEdit = !true;
                colAllowDeleteOther.OptionsColumn.ReadOnly = !false;
            }
            else MessageBox.Show("Lưu không thành công!");
            return (iError==0);
        }
        public override void EditItem()
        {
            gridControl2.Enabled = false;
            colAllowAdd.OptionsColumn.AllowFocus = true;
            colAllowAdd.OptionsColumn.AllowEdit = true;
            colAllowAdd.OptionsColumn.ReadOnly = false;
            colAllowView.OptionsColumn.AllowFocus = true;
            colAllowView.OptionsColumn.AllowEdit = true;
            colAllowView.OptionsColumn.ReadOnly = false;
            colAllowEdit.OptionsColumn.AllowFocus = true;
            colAllowEdit.OptionsColumn.AllowEdit = true; 
            colAllowEdit.OptionsColumn.ReadOnly = false;
            colAllowDelete.OptionsColumn.AllowFocus = true;
            colAllowDelete.OptionsColumn.AllowEdit = true;
            colAllowDelete.OptionsColumn.ReadOnly = false;

            colAllowEditOther.OptionsColumn.AllowFocus = true;
            colAllowEditOther.OptionsColumn.AllowEdit = true;
            colAllowEditOther.OptionsColumn.ReadOnly = false;
            colAllowDeleteOther.OptionsColumn.AllowFocus = true;
            colAllowDeleteOther.OptionsColumn.AllowEdit = true;
            colAllowDeleteOther.OptionsColumn.ReadOnly = false;

            base.EditItem();
        }
        public override void CancelItem()
        {
            gridControl1.DataSource = bll.DTGetByMemberID(memberID);
            gridControl2.Enabled = true;
            colAllowAdd.OptionsColumn.AllowFocus = false;
            colAllowAdd.OptionsColumn.AllowEdit = false;
            colAllowAdd.OptionsColumn.ReadOnly = true;
            colAllowView.OptionsColumn.AllowFocus = false;
            colAllowView.OptionsColumn.AllowEdit = false;
            colAllowView.OptionsColumn.ReadOnly = true;
            colAllowEdit.OptionsColumn.AllowFocus = false;
            colAllowEdit.OptionsColumn.AllowEdit = !true;
            colAllowEdit.OptionsColumn.ReadOnly = !false;
            colAllowDelete.OptionsColumn.AllowFocus = !true;
            colAllowDelete.OptionsColumn.AllowEdit = !true;
            colAllowDelete.OptionsColumn.ReadOnly = !false;

            colAllowEditOther.OptionsColumn.AllowFocus = false;
            colAllowEditOther.OptionsColumn.AllowEdit = !true;
            colAllowEditOther.OptionsColumn.ReadOnly = !false;
            colAllowDeleteOther.OptionsColumn.AllowFocus = !true;
            colAllowDeleteOther.OptionsColumn.AllowEdit = !true;
            colAllowDeleteOther.OptionsColumn.ReadOnly = !false;

            base.CancelItem();
        }

        private void FormMemberFunction_Load(object sender, EventArgs e)
        {
            this.gridControl2.Refresh();
            this.gridControl2.RefreshDataSource();
            gridView2.ExpandAllGroups();
            this.gridControl1.Refresh();
            this.gridControl1.RefreshDataSource();
            //gridView1.ExpandAllGroups();
            this.WindowState = FormWindowState.Maximized;
        }

        private void gridView1_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            //if (e.RowHandle > 0)
            //{
            //    if (int.Parse(gridView1.GetDataRow(e.RowHandle)["FunctionType"].ToString()) == 2)
            //    {
            //        if (("AllowAdd/AllowEdit/AllowDelete").Contains(e.Column.FieldName))
            //            e.RepositoryItem = this.repositoryItemTextEdit1;
            //        if (e.Column.FieldName=="AllowEditOther" || e.Column.FieldName=="AllowDeleteOther")
            //            e.RepositoryItem = this.repositoryItemTextEdit1;
            //    }
            //    if (int.Parse(gridView1.GetDataRow(e.RowHandle)["FunctionType"].ToString()) == 1)
            //    {
            //        if (("AllowAdd/AllowDelete").Contains(e.Column.FieldName))
            //            e.RepositoryItem = this.repositoryItemTextEdit1;
            //        if (e.Column.FieldName == "AllowDeleteOther") //e.Column.FieldName == "AllowEditOther" || 
            //            e.RepositoryItem = this.repositoryItemTextEdit1;
            //    }
            //    if (int.Parse(gridView1.GetDataRow(e.RowHandle)["FunctionType"].ToString()) == 3)
            //    {
            //        if (("AllowAdd/AllowEdit/AllowDelete").Contains(e.Column.FieldName))
            //            e.RepositoryItem = this.repositoryItemTextEdit1;
            //        if (e.Column.FieldName == "AllowEditOther" || e.Column.FieldName == "AllowDeleteOther")
            //            e.RepositoryItem = this.repositoryItemTextEdit1;
            //    }
            //}
        }

        private void repbtnAll_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (this.EditMode == Windows.FormEditMode.VIEW)
                return;
            CurrencyManager cr = this.BindingContext[this.gridControl1.DataSource] as CurrencyManager;
            DataRowView DR = (cr.Current as DataRowView);
            
            DR["AllowView"] = true;
            DR["AllowAdd"] = true;
            DR["AllowEdit"] = true;
            DR["AllowDelete"] = true;
            DR["AllowEditOther"] = true;
            DR["AllowDeleteOther"] = true;
            this.gridView1.RefreshRow(gridView1.FocusedRowHandle);
            //gridView1.UpdateCurrentRow();
            //gridView1.RefreshData();
            
        }

        private void repchkView_Click(object sender, EventArgs e)
        {
            if (this.EditMode == Windows.FormEditMode.VIEW)
                return;
            CurrencyManager cr = this.BindingContext[this.gridControl1.DataSource] as CurrencyManager;
            DataRowView DR = (cr.Current as DataRowView);

            if ((sender as DevExpress.XtraEditors.CheckEdit).Checked)
            {
                DR["AllowAdd"] = false;
                DR["AllowEdit"] = false;
                DR["AllowDelete"] = false;
                DR["AllowEditOther"] = false;
                DR["AllowDeleteOther"] = false;
                this.gridView1.RefreshRow(gridView1.FocusedRowHandle);
            }
        }
    }
}