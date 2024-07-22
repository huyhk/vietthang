using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.ERP.Data;
using VNS.ERP.Data.Accounting;
using VNS.Common;

namespace VNS.ERP.GUI.UserControls
{
    public partial class UCAccountSample : EditControlBase
    {
        DataTable dtSourceSubject = null;
        DataTable dtSourceClassification = null;
        //bool inputDebitInfo = true;
        public UCAccountSample()
        {
            InitializeComponent();
            repButtonEditDebitSubject.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(repButtonEditDebitSubject_ButtonClick);
            repButtonEditDebitSubject.Validating += new CancelEventHandler(repButtonEditDebitSubject_Validating);
            repButtonEditCreditSubject.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(repButtonEditCreditSubject_ButtonClick);
            repButtonEditCreditSubject.Validating += new CancelEventHandler(repButtonEditCreditSubject_Validating);
            repButtonEditDebitClassificationCode.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(repButtonEditDebitClassificationCode_ButtonClick);
            repButtonEditDebitClassificationCode.Validating += new CancelEventHandler(repButtonEditDebitClassificationCode_Validating);
            repButtonEditCreditClassificationCode.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(repButtonEditCreditClassificationCode_ButtonClick);
            repButtonEditCreditClassificationCode.Validating += new CancelEventHandler(repButtonEditCreditClassificationCode_Validating);
            repItemButtonEditSubjectCode.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(repItemButtonEditSubjectCode_ButtonClick);
            repItemButtonEditSubjectCode.Validating += new CancelEventHandler(repItemButtonEditSubjectCode_Validating);
            repItemButtonEditClassification.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(repItemButtonEditClassification_ButtonClick);
            repItemButtonEditClassification.Validating += new CancelEventHandler(repItemButtonEditClassification_Validating);
        }

        void repItemButtonEditClassification_Validating(object sender, CancelEventArgs e)
        {
            string rowFilter = "";
            CurrencyManager cr = this.BindingContext[gridCtrSample1.DataSource] as CurrencyManager;
            AccountSampleDetail1 asd1 = null;
            if (cr.Count > 0)
            {
                asd1 = cr.Current as AccountSampleDetail1;
            }
            Account acc = null;
            if (asd1 != null)
            {
                acc = (repLookUpEditCreditAccount.DataSource as VNS.Common.ListBase<Account>).Search("AccountCode", asd1.AccountCode);
            }
            if (acc != null)
            {
                if (acc.DetailClassification)
                {
                    rowFilter = "ClassificationTypeCode='" + acc.ClassificationTypeCode + "'";
                }
                else
                {
                    rowFilter = "ClassificationCode=''";
                }

            }
            else
            {
                rowFilter = "ClassificationCode=''";
            }
            DataView dv = dtSourceClassification.DefaultView;
            dv.RowFilter = rowFilter;

            string s = (gridViewSample1.ActiveEditor as DevExpress.XtraEditors.ButtonEdit).Text;// gridViewSample2.GetRowCellDisplayText(this.gridViewSample2.FocusedRowHandle, this.gridViewSample2.FocusedColumn);// (colCreditSubjectCode);
            s = s.Trim();
            if ((dv.ToTable().Select("ClassificationCode='" + s + "'")).Length == 0 && s != "")
            {
                e.Cancel = true;
                string ClassificationCode = this.GetClassificationCode(rowFilter);
                if (ClassificationCode != "")
                {
                    gridViewSample1.SetFocusedRowCellValue(colClassificationCode, ClassificationCode);
                }
            }
            else
            {
                gridViewSample1.SetFocusedRowCellValue(colClassificationCode, s);
            }
        }

        void repItemButtonEditSubjectCode_Validating(object sender, CancelEventArgs e)
        {
            string rowFilter = "";
            CurrencyManager cr = this.BindingContext[gridCtrSample1.DataSource] as CurrencyManager;
            AccountSampleDetail1 asd1 = null;
            if (cr.Count > 0)
            {
                asd1 = cr.Current as AccountSampleDetail1;
            }
            Account acc = null;
            if (asd1 != null)
            {
                acc = (repItemLookUpAccountCode.DataSource as VNS.Common.ListBase<Account>).Search("AccountCode", asd1.AccountCode);
            }
            if (acc != null)
            {
                if (acc.DetailSubject)
                {
                    if (acc.LstAccSubjectType == null) acc.LstAccSubjectType = new AccountBLL().GetAccountSubjectType(acc.AccountCode);
                    foreach (AccountSubjectType ast in acc.LstAccSubjectType)
                    {
                        if (rowFilter == "")
                        {
                            rowFilter = "SubjectTypeCode='" + ast.SubjectTypeCode + "'";
                        }
                        else
                        {
                            rowFilter += " or SubjectTypeCode='" + ast.SubjectTypeCode + "'";
                        }
                    }
                }
                else
                {
                    rowFilter = "SubjectCode=''";
                }
            }
            else
            {
                rowFilter = "SubjectCode=''";
            }
            DataView dv = dtSourceSubject.DefaultView;
            dv.RowFilter = rowFilter;

            string s = (gridViewSample1.ActiveEditor as DevExpress.XtraEditors.ButtonEdit).Text;// gridViewSample1.GetRowCellDisplayText(this.gridViewSample2.FocusedRowHandle, this.gridViewSample2.FocusedColumn);// (colCreditSubjectCode);
            s = s.Trim();

            if ((dv.ToTable().Select("SubjectCode='" + s + "'")).Length == 0 && s != "")
            {
                e.Cancel = true;
                string subjectCode = this.GetSubjectCode(rowFilter);
                if (subjectCode != "")
                {
                    gridViewSample1.SetFocusedRowCellValue(colSubjectCode, subjectCode);
                }
            }
            else
            {
                gridViewSample1.SetFocusedRowCellValue(colSubjectCode, s);
            }
        }

        void repItemButtonEditClassification_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string rowFilter = "";
            CurrencyManager cr = this.BindingContext[gridCtrSample1.DataSource] as CurrencyManager;
            AccountSampleDetail1 asd1 = null;
            if (cr.Count > 0)
            {
                asd1 = cr.Current as AccountSampleDetail1;
            }
            Account acc = null;
            if (asd1 != null)
            {
                acc = (repItemLookUpAccountCode.DataSource as VNS.Common.ListBase<Account>).Search("AccountCode", asd1.AccountCode);
            }
            if (acc != null)
            {
                if (acc.DetailClassification)
                {
                    rowFilter = "ClassificationTypeCode='" + acc.ClassificationTypeCode + "'";
                }
                else
                {
                    rowFilter = "ClassificationCode=''";
                }

            }
            else
            {
                rowFilter = "ClassificationCode=''";
            }
            string ClassificationCode = this.GetClassificationCode(rowFilter);
            if (ClassificationCode != "")
            {
                gridViewSample1.SetFocusedRowCellValue(colClassificationCode, ClassificationCode);
            }
        }

        void repItemButtonEditSubjectCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string rowFilter = "";
            CurrencyManager cr = this.BindingContext[gridCtrSample1.DataSource] as CurrencyManager;
            AccountSampleDetail1 asd1 = null;
            if (cr.Count > 0)
            {
                asd1 = cr.Current as AccountSampleDetail1;
            }
            Account acc = null;
            if (asd1 != null)
            {
                acc = (repItemLookUpAccountCode.DataSource as VNS.Common.ListBase<Account>).Search("AccountCode", asd1.AccountCode);
            }
            if (acc != null)
            {
                if (acc.DetailSubject)
                {
                    if (acc.LstAccSubjectType == null) acc.LstAccSubjectType = new AccountBLL().GetAccountSubjectType(acc.AccountCode);
                    foreach (AccountSubjectType ast in acc.LstAccSubjectType)
                    {
                        if (rowFilter == "")
                        {
                            rowFilter = "SubjectTypeCode='" + ast.SubjectTypeCode + "'";
                        }
                        else
                        {
                            rowFilter += " or SubjectTypeCode='" + ast.SubjectTypeCode + "'";
                        }
                    }
                }
                else
                {
                    rowFilter = "SubjectCode=''";
                }

            }
            else
            {
                rowFilter = "SubjectCode=''";
            }
            string SubjectCode = this.GetSubjectCode(rowFilter);
            if (SubjectCode != "")
            {
                gridViewSample1.SetFocusedRowCellValue(colSubjectCode, SubjectCode);
            }
        }
        protected override void InitDataObject()
        {
            ListBase<AccountTransactionTypes> lst = new AccountTransactionTypesBLL().GetAll();
            lookUpEditAccTransTypeCode.Properties.DataSource = lst;
            base.InitDataObject();
        }
        void repButtonEditDebitClassificationCode_Validating(object sender, CancelEventArgs e)
        {
            string rowFilter = "";
            CurrencyManager cr = this.BindingContext[gridCtrSample2.DataSource] as CurrencyManager;
            AccountSampleDetail2 asd2 = null;
            if (cr.Count > 0)
            {
                asd2 = cr.Current as AccountSampleDetail2;
            }
            
            Account acc = null;
            if (asd2 != null)
            {
                acc = (repLookUpEditCreditAccount.DataSource as VNS.Common.ListBase<Account>).Search("AccountCode", asd2.DebitAccountCode);
            }
            if (acc != null)
            {
                if (acc.DetailClassification)
                {
                    rowFilter = "ClassificationTypeCode='" + acc.ClassificationTypeCode + "'";
                }
                else
                {
                    rowFilter = "ClassificationCode=''";
                }

            }
            else
            {
                rowFilter = "ClassificationCode=''";
            }
            DataView dv = dtSourceClassification.DefaultView;
            dv.RowFilter = rowFilter;

            string s = (gridViewSample2.ActiveEditor as DevExpress.XtraEditors.ButtonEdit).Text;// gridViewSample2.GetRowCellDisplayText(this.gridViewSample2.FocusedRowHandle, this.gridViewSample2.FocusedColumn);// (colCreditSubjectCode);
            s = s.Trim();
            if ((dv.ToTable().Select("ClassificationCode='" + s + "'")).Length == 0 && s != "")
            {
                e.Cancel = true;
                string ClassificationCode = this.GetClassificationCode(rowFilter);
                if (ClassificationCode != "")
                {
                    gridViewSample2.SetFocusedRowCellValue(colDebitClassificationCode, ClassificationCode);
                }
            }
            else
            {
                gridViewSample2.SetFocusedRowCellValue(colDebitClassificationCode, s);
            }
        }

        void repButtonEditCreditClassificationCode_Validating(object sender, CancelEventArgs e)
        {
            string rowFilter = "";
            CurrencyManager cr = this.BindingContext[gridCtrSample2.DataSource] as CurrencyManager;
            AccountSampleDetail2 asd2 = null;
            if (cr.Count > 0)
            {
                asd2 = cr.Current as AccountSampleDetail2;
            }
            Account acc = null;
            if (asd2 != null)
            {
                acc = (repLookUpEditCreditAccount.DataSource as VNS.Common.ListBase<Account>).Search("AccountCode", asd2.CreditAccountCode);
            }
            if (acc != null)
            {
                if (acc.DetailClassification)
                {
                    rowFilter = "ClassificationTypeCode='" + acc.ClassificationTypeCode + "'";
                }
                else
                {
                    rowFilter = "ClassificationCode=''";
                }

            }
            else
            {
                rowFilter = "ClassificationCode=''";
            }
            DataView dv = dtSourceClassification.DefaultView;
            dv.RowFilter = rowFilter;

            string s = (gridViewSample2.ActiveEditor as DevExpress.XtraEditors.ButtonEdit).Text;// gridViewSample2.GetRowCellDisplayText(this.gridViewSample2.FocusedRowHandle, this.gridViewSample2.FocusedColumn);// (colCreditSubjectCode);
            s = s.Trim();
            if ((dv.ToTable().Select("ClassificationCode='" + s + "'")).Length == 0 && s != "")
            {
                e.Cancel = true;
                string ClassificationCode = this.GetClassificationCode(rowFilter);
                if (ClassificationCode != "")
                {
                    gridViewSample2.SetFocusedRowCellValue(colCreditClassificationCode, ClassificationCode);
                }
            }
            else
            {
                gridViewSample2.SetFocusedRowCellValue(colCreditClassificationCode, s);
            }
        }

        void repButtonEditDebitSubject_Validating(object sender, CancelEventArgs e)
        {
            string rowFilter = "";
            CurrencyManager cr = this.BindingContext[gridCtrSample2.DataSource] as CurrencyManager;
            AccountSampleDetail2 asd2 = null;
            if (cr.Count > 0)
            {
                asd2 = cr.Current as AccountSampleDetail2;
            }
            Account acc = null;
            if (asd2 != null)
            {
                acc = (repLookUpEditCreditAccount.DataSource as VNS.Common.ListBase<Account>).Search("AccountCode", asd2.DebitAccountCode);
            }
            if (acc != null)
            {
                if (acc.DetailSubject)
                {
                    if (acc.LstAccSubjectType == null) acc.LstAccSubjectType = new AccountBLL().GetAccountSubjectType(acc.AccountCode);
                    foreach (AccountSubjectType ast in acc.LstAccSubjectType)
                    {
                        if (rowFilter == "")
                        {
                            rowFilter = "SubjectTypeCode='" + ast.SubjectTypeCode + "'";
                        }
                        else
                        {
                            rowFilter += " or SubjectTypeCode='" + ast.SubjectTypeCode + "'";
                        }
                    }
                }
                else
                {
                    rowFilter = "SubjectCode=''";
                }
            }
            else
            {
                rowFilter = "SubjectCode=''";
            }
            DataView dv = dtSourceSubject.DefaultView;
            dv.RowFilter = rowFilter;

            string s = (gridViewSample2.ActiveEditor as DevExpress.XtraEditors.ButtonEdit).Text;// gridViewSample2.GetRowCellDisplayText(this.gridViewSample2.FocusedRowHandle, this.gridViewSample2.FocusedColumn);// (colCreditSubjectCode);
            s = s.Trim();
            
            if ((dv.ToTable().Select("SubjectCode='" + s + "'")).Length == 0 && s != "")
            {
                e.Cancel = true;
                string subjectCode = this.GetSubjectCode(rowFilter);
                if (subjectCode != "")
                {
                    gridViewSample2.SetFocusedRowCellValue(colDebitSubjectCode, subjectCode);
                }
            }
            else
            {
                gridViewSample2.SetFocusedRowCellValue(colCreditSubjectCode, s);
            }
        }

        void repButtonEditCreditSubject_Validating(object sender, CancelEventArgs e)
        {
            string rowFilter = "";
            CurrencyManager cr = this.BindingContext[gridCtrSample2.DataSource] as CurrencyManager;
            AccountSampleDetail2 asd2 = null;
            if (cr.Count > 0)
            {
                asd2 = cr.Current as AccountSampleDetail2;
            }
            Account acc = null;
            if (asd2 != null)
            {
                acc = (repLookUpEditCreditAccount.DataSource as VNS.Common.ListBase<Account>).Search("AccountCode", asd2.CreditAccountCode);
            }
            if (acc != null)
            {
                if (acc.DetailSubject)
                {
                    if (acc.LstAccSubjectType == null) acc.LstAccSubjectType = new AccountBLL().GetAccountSubjectType(acc.AccountCode);
                    foreach (AccountSubjectType ast in acc.LstAccSubjectType)
                    {
                        if (rowFilter == "")
                        {
                            rowFilter = "SubjectTypeCode='" + ast.SubjectTypeCode + "'";
                        }
                        else
                        {
                            rowFilter += " or SubjectTypeCode='" + ast.SubjectTypeCode + "'";
                        }
                    }
                }
                else
                {
                    rowFilter = "SubjectCode=''";
                }
            }
            else
            {
                rowFilter = "SubjectCode=''";
            }
            DataView dv = dtSourceSubject.DefaultView;
            dv.RowFilter = rowFilter;

            string s = (gridViewSample2.ActiveEditor as DevExpress.XtraEditors.ButtonEdit).Text;// gridViewSample2.GetRowCellDisplayText(this.gridViewSample2.FocusedRowHandle, this.gridViewSample2.FocusedColumn);// (colCreditSubjectCode);
            s = s.Trim();
            if ((dv.ToTable().Select("SubjectCode='" + s + "'")).Length == 0 && s != "")
            {
                e.Cancel = true;
                string subjectCode = this.GetSubjectCode(rowFilter);
                if (subjectCode != "")
                {
                    gridViewSample2.SetFocusedRowCellValue(colCreditSubjectCode, subjectCode);
                }
            }
            else
            {
                gridViewSample2.SetFocusedRowCellValue(colCreditSubjectCode, s);
            }
        }

        void repButtonEditCreditClassificationCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string rowFilter = "";
            CurrencyManager cr = this.BindingContext[gridCtrSample2.DataSource] as CurrencyManager;
            AccountSampleDetail2 asd2 = null;
            if (cr.Count > 0)
            {
                asd2 = cr.Current as AccountSampleDetail2;
            }
            Account acc = null;
            if (asd2 != null)
            {
                acc = (repLookUpEditCreditAccount.DataSource as VNS.Common.ListBase<Account>).Search("AccountCode", asd2.CreditAccountCode);
            }
            if (acc != null)
            {
                if (acc.DetailClassification)
                {
                    rowFilter = "ClassificationTypeCode='" + acc.ClassificationTypeCode + "'";
                }
                else
                {
                    rowFilter = "ClassificationCode=''";
                }

            }
            else
            {
                rowFilter = "ClassificationCode=''";
            }
            string ClassificationCode = this.GetClassificationCode(rowFilter);
            if(ClassificationCode!="")
            {
                gridViewSample2.SetFocusedRowCellValue(colCreditClassificationCode, ClassificationCode);
            }
        }

        void repButtonEditDebitClassificationCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string rowFilter = "";
            CurrencyManager cr = this.BindingContext[gridCtrSample2.DataSource] as CurrencyManager;
            AccountSampleDetail2 asd2 = null;
            if (cr.Count > 0)
            {
                asd2 = cr.Current as AccountSampleDetail2;
            }
            Account acc = null;
            if (asd2 != null)
            {
                acc = (repLookUpEditCreditAccount.DataSource as VNS.Common.ListBase<Account>).Search("AccountCode", asd2.DebitAccountCode);
            }
            if (acc != null)
            {
                if (acc.DetailClassification)
                {
                    rowFilter = "ClassificationTypeCode='" + acc.ClassificationTypeCode + "'";
                }
                else
                {
                    rowFilter = "ClassificationCode=''";
                }

            }
            else
            {
                rowFilter = "ClassificationCode=''";
            }
            string ClassificationCode = this.GetClassificationCode(rowFilter);
            if (ClassificationCode != "")
            {
                gridViewSample2.SetFocusedRowCellValue(colDebitClassificationCode, ClassificationCode);
            }
        }

        void repButtonEditCreditSubject_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string rowFilter = "";
            CurrencyManager cr = this.BindingContext[gridCtrSample2.DataSource] as CurrencyManager;
            AccountSampleDetail2 asd2 = null;
            if (cr.Count > 0)
            {
                asd2 = cr.Current as AccountSampleDetail2;
            }
            Account acc = null;
            if (asd2 != null)
            {
                acc = (repLookUpEditCreditAccount.DataSource as VNS.Common.ListBase<Account>).Search("AccountCode", asd2.CreditAccountCode);
            }
            if (acc != null)
            {
                if (acc.DetailSubject)
                {
                    if (acc.LstAccSubjectType == null) acc.LstAccSubjectType = new AccountBLL().GetAccountSubjectType(acc.AccountCode);
                    foreach (AccountSubjectType ast in acc.LstAccSubjectType)
                    {
                        if (rowFilter == "")
                        {
                            rowFilter = "SubjectTypeCode='" + ast.SubjectTypeCode + "'";
                        }
                        else
                        {
                            rowFilter += " or SubjectTypeCode='" + ast.SubjectTypeCode + "'";
                        }
                    }
                }
                else
                {
                    rowFilter = "SubjectCode=''";
                }
                
            }
            else
            {
                rowFilter = "SubjectCode=''"; 
            }
            string SubjectCode = this.GetSubjectCode(rowFilter);
            if (SubjectCode != "")
            {
                gridViewSample2.SetFocusedRowCellValue(colCreditSubjectCode, SubjectCode);
            }
        }
        void repButtonEditDebitSubject_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string rowFilter = "";
            CurrencyManager cr = this.BindingContext[gridCtrSample2.DataSource] as CurrencyManager;
            AccountSampleDetail2 asd2 = null;
            if (cr.Count > 0)
            {
                asd2 = cr.Current as AccountSampleDetail2;
            }
            Account acc = null;
            if (asd2 != null)
            {
                acc = (repLookUpEditCreditAccount.DataSource as VNS.Common.ListBase<Account>).Search("AccountCode", asd2.DebitAccountCode);
            }
            if (acc != null)
            {
                if (acc.DetailSubject)
                {
                    if (acc.LstAccSubjectType == null) acc.LstAccSubjectType = new AccountBLL().GetAccountSubjectType(acc.AccountCode);
                    foreach (AccountSubjectType ast in acc.LstAccSubjectType)
                    {
                        if (rowFilter == "")
                        {
                            rowFilter = "SubjectTypeCode='" + ast.SubjectTypeCode + "'";
                        }
                        else
                        {
                            rowFilter += " or SubjectTypeCode='" + ast.SubjectTypeCode + "'";
                        }
                    }
                }
                else
                {
                    rowFilter = "SubjectCode=''";
                }

            }
            else
            {
                rowFilter = "SubjectCode=''";
            }
            string SubjectCode = this.GetSubjectCode(rowFilter);
            if (SubjectCode != "")
            {
                gridViewSample2.SetFocusedRowCellValue(colDebitSubjectCode, SubjectCode);
            }
        }
            
        private string GetSubjectCode(string rowFilter)
        {
            DataView dv = dtSourceSubject.DefaultView;
            DataRowView drv = null;
            dv.RowFilter = rowFilter;
            string[] fields = { "SubjectCode", "SubjectName" };
            string[] header= {"Mã đối tượng", "Tên đối tượng"};
            drv=VNS.Windows.Forms.FormSearch.ShowSearch(dv.ToTable(), fields, header) as DataRowView;
            if (drv != null)
            {
                return drv["SubjectCode"].ToString();
            }
            return "";
        }
        private string GetClassificationCode(string rowFilter)
        {
            DataView dv = dtSourceClassification.DefaultView;
            DataRowView drv = null;
            dv.RowFilter = rowFilter;
            string[] fields = { "ClassificationCode", "ClassificationName" };
            string[] header = { "Mã yếu tố", "Tên yếu tố" };
            drv = VNS.Windows.Forms.FormSearch.ShowSearch(dv.ToTable(), fields, header) as DataRowView;
            if (drv != null)
            {
                return drv["ClassificationCode"].ToString();
            }
            return "";
        }
        protected override void BindData()
        {
            AccountSample accSample;
            if (this.DataSource != null)
            { 
                accSample = this.DataSource as AccountSample;
                txtAccountSampleCode.Text = accSample.AccountSampleCode;
                txtAccountSampleName.Text = accSample.AccountSampleName;
                txtDescription.Text = accSample.Description;
                lookUpEditAccTransTypeCode.EditValue = accSample.AccountTransactionTypeCode;
                if (accSample.Detail1 == null)
                {
                    if (this.EditMode == VNS.Windows.FormEditMode.ADD)
                    {
                        accSample.Detail1 = new VNS.Common.ListBase<AccountSampleDetail1>();
                    }
                    else
                    {
                        accSample.Detail1 = new AccountSampleBLL().GetDetail1ByID(accSample.AccountSampleCode);
                    }
                }
                if (accSample.Detail2 == null)
                {
                    if (this.EditMode == VNS.Windows.FormEditMode.ADD)
                    {
                        accSample.Detail2 = new VNS.Common.ListBase<AccountSampleDetail2>();
                    }
                    else
                    {
                        accSample.Detail2 = new AccountSampleBLL().GetDetail2ByID(accSample.AccountSampleCode);
                    }
                }
                gridCtrSample1.DataSource = accSample.Detail1;
                gridCtrSample2.DataSource = accSample.Detail2;
            }
            base.BindData();
        }
        protected override void AssignData()
        {
            if (this.DataSource == null) this.DataSource = new AccountSample();
            AccountSample accSample = this.DataSource as AccountSample;
            accSample.AccountTransactionTypeCode = lookUpEditAccTransTypeCode.EditValue.ToString();
            accSample.AccountSampleCode = txtAccountSampleCode.Text;
            accSample.AccountSampleName = txtAccountSampleName.Text;
            accSample.Description = txtDescription.Text;
            if (this.EditMode == VNS.Windows.FormEditMode.ADD)
            {
                accSample.UserCreated = Contexts.CurrentUser.LoginName;
                accSample.DateCreated = DateTime.Now;
            }
            accSample.UserUpdated = Contexts.CurrentUser.LoginName;
            accSample.DateUpdated = DateTime.Now;
            base.AssignData();
        }
        protected override int ValidateData()
        {
            txtAccountSampleCode.Text = txtAccountSampleCode.Text.Trim();
            txtAccountSampleName.Text = txtAccountSampleName.Text.Trim();
            txtDescription.Text = txtDescription.Text.Trim();
            if (txtAccountSampleCode.Text == "")
            {
                txtAccountSampleCode.Focus();
                return -1;
            }
            if (txtAccountSampleName.Text == "")
            {
                txtAccountSampleName.Focus();
                return -2;
            }
           
            foreach(AccountSampleDetail2 asd2 in (this.DataSource as AccountSample).Detail2)
            {
                if (asd2.CreditAccountCode == null && asd2.DebitAccountCode == null)
                {
                    return -3;
                }
            }

            if (!(new AccountSampleBLL().CompareDetail1(this.DataSource as AccountSample)))
            {
                new AccountSampleBLL().RefeshDetail1(this.DataSource as AccountSample);
            }
            if (lookUpEditAccTransTypeCode.EditValue == null)
            {
                lookUpEditAccTransTypeCode.Focus();
                return -5;
            }
            return base.ValidateData();
        }
        public override void RefreshControl()
        {
            bool viewMode = this.EditMode == VNS.Windows.FormEditMode.VIEW;
            txtAccountSampleCode.Properties.ReadOnly = this.EditMode != VNS.Windows.FormEditMode.ADD;
            colDescription1.OptionsColumn.ReadOnly = this.EditMode == VNS.Windows.FormEditMode.VIEW;
            txtAccountSampleName.Properties.ReadOnly = viewMode;
            txtDescription.Properties.ReadOnly = viewMode;
            lookUpEditAccTransTypeCode.Properties.ReadOnly = viewMode;
            gridViewSample1.OptionsBehavior.Editable = !viewMode;
            gridViewSample2.OptionsBehavior.Editable = !viewMode;
            if (this.DataSource == null)
            {
                txtAccountSampleCode.Text = "";
                txtAccountSampleName.Text = "";
                txtDescription.Text = "";
                gridCtrSample1.DataSource = null;
                gridCtrSample2.DataSource = null;
            }
            if (this.EditMode == VNS.Windows.FormEditMode.VIEW)
            {
                gridViewSample1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                gridViewSample2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            }
            if (this.EditMode == VNS.Windows.FormEditMode.EDIT)
            {
                txtAccountSampleName.Focus();
                gridViewSample1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
                gridViewSample2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            }
            if (this.EditMode == VNS.Windows.FormEditMode.ADD)
            {
                txtAccountSampleCode.Focus();
                gridViewSample1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
                gridViewSample2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            }
            base.RefreshControl();
        }

        public void InitDss()
        {
            VNS.Common.ListBase<Account> lst = new AccountBLL().GetListAccountIsNotParentAccount();
            VNS.Common.ListBase<Account> lst1 = new AccountBLL().GetListAccountIsNotParentAccount();
            VNS.Common.ListBase<Account> lst2 = new AccountBLL().GetListAccountIsNotParentAccount();
            Account acc = new Account();
            lst.Add(acc);
            acc = new Account();
            lst1.Add(acc);
            repLookUpEditCreditAccount.DataSource = lst;
            repLookUpEditDebitAccount.DataSource = lst1;
            repItemLookUpAccountCode.DataSource = lst2;
            dtSourceSubject = new SubjectBLL().GetAllToDataTable();
            dtSourceClassification = new AccountClassificationBLL().GetAllToDataTable();

        }

        private void btnRefeshDetail2_Click(object sender, EventArgs e)
        {
            if (this.EditMode != VNS.Windows.FormEditMode.VIEW)
            {
                if (tabControl1.SelectedIndex == 1)
                {
                    new AccountSampleBLL().RefeshDetail1(this.DataSource as AccountSample);
                }
            }
        }

        private void gridViewSample2_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.gridViewSample2.RowCount > 0 && this.gridViewSample2.OptionsBehavior.Editable == true)
            {
                if (e.KeyCode == Keys.Delete)
                    this.gridViewSample2.DeleteRow(this.gridViewSample2.FocusedRowHandle);
            }
        }

        private void gridViewSample2_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

        }

        private void gridViewSample1_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.gridViewSample1.RowCount > 0 && this.gridViewSample1.OptionsBehavior.Editable == true)
            {
                if (e.KeyCode == Keys.Delete)
                    this.gridViewSample1.DeleteRow(this.gridViewSample1.FocusedRowHandle);
            }
        }

    }
}
