using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using VNS.Common;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.Windows;
using VNS.ERP.Data;
using VNS.Windows.Forms;


namespace VNS.ERP.GUI.UserControl
{
    public partial class UCUserGroup : EditControlBase
    {
        public UCUserGroup()
        {
            InitializeComponent();
            this.LoopkupUser.EditValueChanged += new EventHandler(LoopkupUser_EditValueChanged);
        }

        void LoopkupUser_EditValueChanged(object sender, EventArgs e)
        {
            string MemberName = (string)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("MemberName");
            this.gridView2.SetRowCellValue(this.gridView2.FocusedRowHandle, this.gridColumn2, MemberName);
        }
        protected override void BindData()
        {
            txtMemberID.Text = (this.dataSource as Member).MemberID;
            txtMemberName.Text = (this.dataSource as Member).MemberName;
            txtDescription.Text = (this.dataSource as Member).Description;
            this.gridControl1.DataSource = new UserGroupBLL().GetMemberNotOf(txtMemberID.Text);
            this.gridControl2.DataSource = new UserGroupBLL().GetMemberOf(txtMemberID.Text);
            base.BindData();
        }
        protected override void AssignData()
        {
            base.AssignData();
            (this.dataSource as Member).MemberID=txtMemberID.Text ;
             (this.dataSource as Member).MemberName=txtMemberName.Text ;
             (this.dataSource as Member).Description=txtDescription.Text ;
             (this.dataSource as Member).UserCreated = Contexts.CurrentUser.LoginName;
             (this.dataSource as Member).UserUpdated = Contexts.CurrentUser.LoginName;
        }
        //private void AssignData()
        //{
        //     (this.dataSource as Member).MemberID=txtMemberID.Text ;
        //     (this.dataSource as Member).MemberName=txtMemberName.Text ;
        //     (this.dataSource as Member).Description=txtDescription.Text ;
          
        //}
        public override void RefreshControl()
        {
            txtMemberID.Properties.ReadOnly = this.editMode != FormEditMode.ADD;
            if (this.editMode != FormEditMode.ADD)
                txtMemberID.BackColor = lbDescription.BackColor;
            else
            {
                txtMemberID.Focus();
                txtMemberID.BackColor = Color.White;
            }

            if (editMode == FormEditMode.VIEW)

                RefreshUC(true, lbDescription.BackColor);
            else
                RefreshUC(false, Color.White);
            base.RefreshControl();
        }
        private void RefreshUC(bool value, Color color)
        {
            //txtMemberID.Properties.ReadOnly = value;
            txtMemberName.Properties.ReadOnly = value;
            txtDescription.Properties.ReadOnly = value;
            btLeft.Enabled = !value;
            btRight.Enabled = !value;

            txtMemberID.BackColor = color;
            txtMemberName.BackColor = color;
            txtDescription.BackColor = color;
        }

       

        private void btRight_Click(object sender, EventArgs e)
        {
            if (editMode != FormEditMode.VIEW)
            {
                if (gridView1.DataRowCount > 0)
                {
                    object obj = (this.BindingContext[gridControl1.DataSource] as CurrencyManager).Current;
                    (this.gridView1.DataSource as IBindingList).Remove(obj);
                    (this.gridView2.DataSource as IBindingList).Add(obj);
                    gridView2.FocusedRowHandle=(this.gridView2.DataSource as ListBase<Member>).IndexOf((obj as Member)); 
                    
                }
            }
        }

        private void btLeft_Click(object sender, EventArgs e)
        {
            if (editMode != FormEditMode.VIEW)
            {
                if (gridView2.DataRowCount > 0)
                {
                    object obj = (this.BindingContext[gridControl2.DataSource] as CurrencyManager).Current;
                    (this.gridView2.DataSource as IBindingList).Remove(obj);
                    (this.gridView1.DataSource as IBindingList).Add(obj);
                    gridView1.FocusedRowHandle = (this.gridView1.DataSource as ListBase<Member>).IndexOf((obj as Member)); 
                }
            }
        }

       
        public void SetLookup()
        {
            LoopkupUser.DataSource = new UserBLL().GetAllUser();
        }

      
       
        public override bool Save()
        {
            int Erorr = 0;
            //string message = "Error while save data!";
            ErrorMessageType messageType = ErrorMessageType.VALIDATE;
            Erorr = ValadateData();
            if (Erorr != 0)
            {
                OnError(Erorr, messageType);
                return false;
            }
            AssignData();
            if (editMode == FormEditMode.EDIT)
            {
                messageType = ErrorMessageType.UPDATE;
                Erorr = new UserGroupBLL().UpdateMemberOf((UserGroup)this.dataSource, (ListBase<Member>)gridView2.DataSource);
            }
            if (editMode == FormEditMode.ADD)
            {
                messageType = ErrorMessageType.INSERT;
                Erorr = new UserGroupBLL().InsertMemberOf((Member)this.dataSource, (ListBase<Member>)gridView2.DataSource);
            }

            if (Erorr != 0)
            {
              
                OnError(Erorr, messageType);
                return false;
            }
            return true;
        }
        private int ValadateData()
        {
          
            if (txtMemberID.Text.Trim() == "") return -1;
            //if (this.gridView2.DataRowCount == 0) return -2;
            return 0;
        }

       

        
    }
}
