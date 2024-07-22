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

namespace VNS.ERP.GUI.UserControl
{
    public partial class UCInstrumentTransaction : EditControlBase
    {
        DataTable dtSourceSubject = null;
        DataTable dtSourceClassification = null;
       // InstrumentTransactionAccountBLL bll= new InstrumentTransactionAccountBLL();
        public DateTime TransactionDate
        {
            get { return dateEditTransaction.DateTime; }
        }
        private string transactionType;
        public string TransactionType
        {
            get { return transactionType; }
            set 
            { 
                transactionType = value;
                if (transactionType == enumStockTransaction.In.ToString())
                {
                    gridView1.Columns.Remove(colStockOutCode1);
                    gridView1.Columns.Remove(colDepType);
                    gridView1.Columns.Remove(colDepAccountCode);
                    gridView1.Columns.Remove(colDepSubjectCode);
                    gridView1.Columns.Remove(colDepClassificationCode);
                    gridView1.OptionsDetail.EnableMasterViewMode = false;
                }
                if (transactionType == enumStockTransaction.Out.ToString())
                {
                    gridView1.Columns.Remove(colStockInCode1);
                    gridView1.OptionsDetail.EnableMasterViewMode = true;
                }
                gridView2.Columns.Remove(colSubjectCode0);
            }
        }
        public UCInstrumentTransaction()
        {
            InitializeComponent();
            //this.Business = new InstrumentTransactionAccountBLL(); 
            this.repLookUpItemCode.EditValueChanged += new EventHandler(repLookUpItemCode_EditValueChanged);
            this.repBtnEditDepSubjectCode.Validating += new CancelEventHandler(repBtnEditDepSubjectCode_Validating);
            this.repBtnEditDepSubjectCode.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(repBtnEditDepSubjectCode_ButtonClick);
            this.repBtnEditDepClassification.Validating += new CancelEventHandler(repBtnEditDepClassification_Validating);
            this.repBtnEditDepClassification.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(repBtnEditDepClassification_ButtonClick);
            this.repBtnEditSubjectCode.Validating += new CancelEventHandler(repBtnEditSubjectCode_Validating);
            this.repBtnEditSubjectCode.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(repBtnEditSubjectCode_ButtonClick);

            colQuantity1.SummaryItem.DisplayFormat = AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING;
            colAmount2.SummaryItem.DisplayFormat = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;

            repLookUpStockInCode.Enter += new EventHandler(ItemLook_Enter);
            repLookUpStockOutCode.Enter += new EventHandler(ItemLook_Enter);
            repLookUpItemCode.Enter += new EventHandler(ItemLook_Enter);
        }
        void ItemLook_Enter(object sender, EventArgs e)
        {
            if ((this.Parent.Parent.Parent as VNS.Windows.Controls.EditControlBase).EditMode != VNS.Windows.FormEditMode.VIEW)
            {
                DevExpress.XtraEditors.LookUpEdit repLookup = sender as DevExpress.XtraEditors.LookUpEdit;
                if (repLookup != null)
                {
                    repLookup.ShowPopup();
                }
            }
        }

        void repBtnEditSubjectCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string rowFilter = "";
            CurrencyManager cr = this.BindingContext[gridControl1.DataSource] as CurrencyManager;
            InstrumentTransactionDetail iTDetail = null;
            if (cr.Count > 0)
            {
                iTDetail = cr.Current as InstrumentTransactionDetail;
            }
            Account acc = null;
            if (iTDetail != null)
            {
                acc = (repLookUpAccountCode.DataSource as VNS.Common.ListBase<Account>).Search("AccountCode", iTDetail.LstPrePaidExpense[0].AccountCode);
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
                gridView2.SetFocusedRowCellValue(colSubjectCode0, SubjectCode);
            }
        }

        void repBtnEditSubjectCode_Validating(object sender, CancelEventArgs e)
        {
            string rowFilter = "";
            CurrencyManager cr = this.BindingContext[gridControl1.DataSource] as CurrencyManager;
            InstrumentTransactionDetail iTDetail = null;
            if (cr.Count > 0)
            {
                iTDetail = cr.Current as InstrumentTransactionDetail;
            }
            Account acc = null;
            if (iTDetail != null)
            {
                acc = (repLookUpAccountCode.DataSource as VNS.Common.ListBase<Account>).Search("AccountCode", iTDetail.LstPrePaidExpense[0].AccountCode);
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

            string s = (gridView2.ActiveEditor as DevExpress.XtraEditors.ButtonEdit).Text;// gridViewSample1.GetRowCellDisplayText(this.gridViewSample2.FocusedRowHandle, this.gridViewSample2.FocusedColumn);// (colCreditSubjectCode);
            s = s.Trim();

            if ((dv.ToTable().Select("SubjectCode='" + s + "'")).Length == 0 && s != "")
            {
                e.Cancel = true;
                string subjectCode = this.GetSubjectCode(rowFilter);
                if (subjectCode != "")
                {
                    gridView2.SetFocusedRowCellValue(colSubjectCode0, subjectCode);
                }
            }
            else
            {
                gridView2.SetFocusedRowCellValue(colSubjectCode0, s);
            }
        }

        void repBtnEditDepClassification_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string rowFilter = "";
            CurrencyManager cr = this.BindingContext[gridControl1.DataSource] as CurrencyManager;
            InstrumentTransactionDetail iTDetail = null;
            if (cr.Count > 0)
            {
                iTDetail = cr.Current as InstrumentTransactionDetail;
            }
            Account acc = null;
            if (iTDetail != null)
            {
                acc = (repLookUpDepAccountCode.DataSource as VNS.Common.ListBase<Account>).Search("AccountCode", iTDetail.DepAccountCode);
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
                gridView1.SetFocusedRowCellValue(colDepClassificationCode, ClassificationCode);
            }
        }

        void repBtnEditDepClassification_Validating(object sender, CancelEventArgs e)
        {
            string rowFilter = "";
            CurrencyManager cr = this.BindingContext[gridControl1.DataSource] as CurrencyManager;
            InstrumentTransactionDetail iTDetail = null;
            if (cr.Count > 0)
            {
                iTDetail = cr.Current as InstrumentTransactionDetail;
            }
            Account acc = null;
            if (iTDetail != null)
            {
                acc = (repLookUpDepAccountCode.DataSource as VNS.Common.ListBase<Account>).Search("AccountCode", iTDetail.DepAccountCode);
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

            string s = (gridView1.ActiveEditor as DevExpress.XtraEditors.ButtonEdit).Text;// gridViewSample2.GetRowCellDisplayText(this.gridViewSample2.FocusedRowHandle, this.gridViewSample2.FocusedColumn);// (colCreditSubjectCode);
            s = s.Trim();
            if ((dv.ToTable().Select("ClassificationCode='" + s + "'")).Length == 0 && s != "")
            {
                e.Cancel = true;
                string ClassificationCode = this.GetClassificationCode(rowFilter);
                if (ClassificationCode != "")
                {
                    gridView1.SetFocusedRowCellValue(colDepClassificationCode, ClassificationCode);
                }
            }
            else
            {
                gridView1.SetFocusedRowCellValue(colDepClassificationCode, s);
            }
        }

        void repBtnEditDepSubjectCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string rowFilter = "";
            CurrencyManager cr = this.BindingContext[gridControl1.DataSource] as CurrencyManager;
            InstrumentTransactionDetail iTDetail = null;
            if (cr.Count > 0)
            {
                iTDetail = cr.Current as InstrumentTransactionDetail;
            }
            Account acc = null;
            if (iTDetail != null)
            {
                acc = (repLookUpDepAccountCode.DataSource as VNS.Common.ListBase<Account>).Search("AccountCode", iTDetail.DepAccountCode);
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
                gridView1.SetFocusedRowCellValue(colDepSubjectCode, SubjectCode);
            }
        }
        private string GetSubjectCode(string rowFilter)
        {
            DataView dv = dtSourceSubject.DefaultView;
            DataRowView drv = null;
            dv.RowFilter = rowFilter;
            string[] fields = { "SubjectCode", "SubjectName" };
            string[] header = { "Mã đối tượng", "Tên đối tượng" };
            drv = VNS.Windows.Forms.FormSearch.ShowSearch(dv.ToTable(), fields, header) as DataRowView;
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
        void repBtnEditDepSubjectCode_Validating(object sender, CancelEventArgs e)
        {
            string rowFilter = "";
            CurrencyManager cr = this.BindingContext[gridControl1.DataSource] as CurrencyManager;
            InstrumentTransactionDetail iTDetail = null;
            if (cr.Count > 0)
            {
                iTDetail = cr.Current as InstrumentTransactionDetail;
            }
            Account acc = null;
            if (iTDetail != null)
            {
                acc = (repLookUpDepAccountCode.DataSource as VNS.Common.ListBase<Account>).Search("AccountCode", iTDetail.DepAccountCode);
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

            string s = (gridView1.ActiveEditor as DevExpress.XtraEditors.ButtonEdit).Text;// gridViewSample1.GetRowCellDisplayText(this.gridViewSample2.FocusedRowHandle, this.gridViewSample2.FocusedColumn);// (colCreditSubjectCode);
            s = s.Trim();

            if ((dv.ToTable().Select("SubjectCode='" + s + "'")).Length == 0 && s != "")
            {
                e.Cancel = true;
                string subjectCode = this.GetSubjectCode(rowFilter);
                if (subjectCode != "")
                {
                    gridView1.SetFocusedRowCellValue(colDepSubjectCode, subjectCode);
                }
            }
            else
            {
                gridView1.SetFocusedRowCellValue(colDepSubjectCode, s);
            }
        }

        void repLookUpItemCode_EditValueChanged(object sender, EventArgs e)
        {
            string itemCode = gridView1.ActiveEditor.Text;
            this.gridView1.SetRowCellValue(this.gridView1.FocusedRowHandle, this.colItemName1, itemCode);
            //this.gridView1.RefreshRow(this.gridView1.FocusedRowHandle);
        }
        protected override void InitDataObject()
        {
            base.InitDataObject();
            dtSourceSubject = new SubjectBLL().GetAllToDataTable();
            dtSourceClassification = new AccountClassificationBLL().GetAllToDataTable();
            repLookUpStockInCode.DataSource = new StockBLL().GetAll();
            repLookUpStockOutCode.DataSource = new StockBLL().GetAll();
            repLookUpItemCode.DataSource = new InstrumentItemBLL().GetAll();
            repLookUpItemName.DataSource = repLookUpItemCode.DataSource;
            repLookUpDepType.DataSource = EnumDisplays.GetListenumDepType();
            repLookUpDepAccountCode.DataSource = new AccountBLL().GetListAccountIsNotParentAccount();
            repTxtDepRate.Mask.EditMask = AppConfigs.CONFIG_PERCENTFORMAT;
            repLookUpSubjectCode.DataSource = new BranchBLL().GetAll();
            string account1 = Account.PrePaidShortTerm.ToString();
            int len1 = account1.Length;
            string account2 = Account.PrePaidLongTerm.ToString();
            int len2 = account2.Length;
            repLookUpAccountCode.DataSource = new AccountBLL().GetObjectDynamic(" (left(AccountCode, " + len1.ToString() + ")='" + account1 + "' and AccountCode <> '" + account1+"') or (left(AccountCode, " + len2.ToString() + ") = '" + account2.ToString() + "') ", "");
        }
        protected override void AssignData()
        {
            if (this.DataSource == null) this.DataSource = new InstrumentTransactionAccount();
            InstrumentTransactionAccount itA = this.DataSource as InstrumentTransactionAccount;
            if (itA.InstrTrans == null) itA.InstrTrans = new InstrumentTransaction();
            InstrumentTransaction it = itA.InstrTrans;
            it.TransactionType = this.TransactionType;
            it.TransactionNo = txtTransactionNo.Text;
            it.TransactionDate = dateEditTransaction.DateTime;
            it.Description = txtDescription.Text;
            base.AssignData();
        }
        public override void RefreshControl()
        {
            bool viewMod = this.EditMode == VNS.Windows.FormEditMode.VIEW;
            bool editMod = this.EditMode == VNS.Windows.FormEditMode.EDIT;
            txtTransactionNo.Properties.ReadOnly = viewMod;
            dateEditTransaction.Properties.ReadOnly = viewMod;
            txtDescription.Properties.ReadOnly = viewMod;
            gridView1.OptionsBehavior.Editable = !viewMod;
            gridView2.OptionsBehavior.Editable = !viewMod;
            if (!viewMod)
            {
                gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            }
            else
            {
                gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            }
            if (this.DataSource == null)
            {
                txtTransactionNo.Text = "";
                txtDescription.Text = "";
                gridControl1.DataSource = null;
            }
            base.RefreshControl();
        }
        protected override int ValidateData()
        {
            txtTransactionNo.Text = txtTransactionNo.Text.Trim();
            txtDescription.Text = txtDescription.Text.Trim();
            InstrumentTransactionAccount itA = this.DataSource as InstrumentTransactionAccount;
            InstrumentTransaction it = itA.InstrTrans;
            if (txtTransactionNo.Text == "")
            {
                txtTransactionNo.Focus();
                return -150;
            }
            //if (itA.AccountTransactionDate.Month != it.TransactionDate.Month || itA.AccountTransactionDate.Year != it.TransactionDate.Year)
            //{
            //    return -157;
            //}
            foreach (InstrumentTransactionDetail itd in it.Detail)
            {
                if (this.TransactionType == enumStockTransaction.In.ToString())
                {
                    if (itd.StockInCode == string.Empty || itd.StockInCode == null)
                    {
                        return -151;
                    }
                }
                else
                {
                    if (itd.StockOutCode == string.Empty || itd.StockOutCode == null)
                    {
                        return -152;
                    }
                }
                if (itd.ItemCode == string.Empty || itd.ItemCode == null)
                {
                    return -153;
                }
                if (itd.LstPrePaidExpense.Count > 0)
                {
                    PrePaidExpense pPE = itd.LstPrePaidExpense[0];
                    if (pPE.PrePaidCode == string.Empty || pPE.PrePaidCode == null)
                    {
                        return -154;
                    }
                    if (pPE.PrePaidName == string.Empty || pPE.PrePaidName == null)
                    {
                        return -155;
                    }
                    if (pPE.Unit == string.Empty || pPE.Unit == null)
                    {
                        return -156;
                    }
                }
            }
            
            return base.ValidateData();
        }
        protected override void BindData()
        {
            if (this.DataSource != null)
            {
                InstrumentTransactionAccount itA = this.DataSource as InstrumentTransactionAccount;
                InstrumentTransaction it = itA.InstrTrans;
                if (it != null)
                {
                    txtTransactionNo.Text = it.TransactionNo;
                    txtDescription.Text = it.Description;
                    dateEditTransaction.DateTime = it.TransactionDate;
                    if (it.Detail == null)
                    {
                        if (this.EditMode == VNS.Windows.FormEditMode.ADD)
                        {
                            it.Detail = new VNS.Common.ListBase<InstrumentTransactionDetail>();
                        }
                        else
                        {
                            it.Detail = new InstrumentTransactionAccountBLL().GetDetail(it.TransactionID);
                        }
                    }
                    gridControl1.DataSource = it.Detail;
                }
            }
            base.BindData();
        }

        private void gridView1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.gridView1.RowCount > 0 && this.gridView1.OptionsBehavior.Editable == true)
            {
                if (e.KeyCode == Keys.Delete)
                    this.gridView1.DeleteRow(this.gridView1.FocusedRowHandle);
            }
        }
    }
}
