using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.Common;
using VNS.ERP.Data;

namespace VNS.ERP.GUI.UserControl
{
    public partial class UCSelectBranch : EditControlBase
    {
        public delegate void BranchChanged(object sender, EventArgs e);
        public event BranchChanged OnBranchChanged;
        private ListBase<Branch> lstSourceBranch;
        public UCSelectBranch()
        {
            InitializeComponent();
        }
        public override string Text
        {
            get
            {
                return gbBranch.Text;
            }
            set
            {
                gbBranch.Text = value;
                
            }
        }
        
        public string TenTruSoKinhDoanh
        {
            get { return txtNameText.Text; }
        }
        public string BranchCode
        {
            get 
            {
                string s = null;
                if (this.lookUpBranchCode.EditValue != null)
                {
                    s = this.lookUpBranchCode.EditValue.ToString();
                }
                return s;
            }
        }
        public string MSThue
        {
            get { return txtMSThue.Text; }
        }
        public string DiaChi
        {
            get { return txtAddress.Text; }
        }
        
        private void lookUpBranchCode_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpBranchCode.EditValue != null && lookUpBranchCode.EditValue.ToString() != "")
            {
                txtAddress.Text = lookUpBranchCode.GetColumnValue("Address").ToString();
                txtMSThue.Text = lookUpBranchCode.GetColumnValue("TaxCode").ToString();
            }
            if(OnBranchChanged != null) OnBranchChanged(sender,e);
        }
        protected override void InitDataObject()
        {
            if (!this.DesignMode)
            {
                lstSourceBranch = new BranchBLL().GetAllByMemberID(enumSubjectType.Branch.ToString(), Contexts.CurrentUser.MemberID);
                if (Contexts.CurrentUser.BranchCode == string.Empty)
                {
                    Branch branch = new Branch();
                    branch.SubjectCode = "";
                    lstSourceBranch.Add(branch);
                }
               
                lookUpBranchCode.Properties.DataSource = lstSourceBranch;
            }
            base.InitDataObject();
        }
       
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            try
            {
                lookUpBranchCode.ItemIndex = 0;
            }
            catch
            {
            }
        }
    }
}
