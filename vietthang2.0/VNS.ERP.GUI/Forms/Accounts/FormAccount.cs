using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Accounting;
using Microsoft.Office.Interop.Excel;
using VNS.Common;

namespace VNS.ERP.GUI.Accounting
{
    public partial class FormAccount : FormEditBase
    {
        AccountBLL obj = new AccountBLL();
        ListBase<Account> lst;
        ListBase<enums> lstAccountType;
        public FormAccount()
        {
            InitializeComponent();
            this.Business = obj;
            this.ucAccount1.SetDss();
            lst  = obj.GetAll();
            lstAccountType = EnumDisplays.GetListenumAccountType();
            this.LookUpEditAccountType.DataSource = lstAccountType;
            this.ItemLookUpEditClsTypeCode.DataSource = new AccountClassificationTypeBLL().GetAll();
            //loo
            this.DataSource = lst;
        }
        protected override bool Save()
        {
            VNS.Windows.FormEditMode mode = this.editMode;
            bool ret = base.Save();
            if (ret && mode == VNS.Windows.FormEditMode.ADD)
            {
                this.ucAccount1.UpdateNewAcc(this.CurrentItem as Account);
            }
            return ret;
        }
        public override void Delete()
        {
            object deleted = this.currentItem;
            base.Delete();
            if (deleted != this.currentItem)
            {
                this.ucAccount1.UpdateRemoveAcc(deleted as Account);
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            FormProgressBar dlg = new FormProgressBar();
            if (dlg != null)
            {
                dlg.Text = this.Text;
                dlg.Show();
                dlg.SetProgressText("Kết xuất ra file Excel...");
                dlg.SetProgressBarMaximum(this.lst.Count);
            }
            if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KeToan\\DanhMucTaiKhoan.xls"))
            {
                MessageBox.Show(this.GetTextMessage("TemplateFileNotExists", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\KeToan\\DanhMucTaiKhoan.xls"));
                if (dlg != null)
                    dlg.Dispose();
                dlg = null;
                return;
            }

            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = false;
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            //Workbook wb = excelApp.Workbooks.Open(fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            Workbook wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KeToan\\DanhMucTaiKhoan.xls");
            Worksheet ws = (Worksheet)wb.Worksheets[1];
            
            int rowCount = this.lst.Count;
            int row = 6;
            ListBase<SubjectType> lstSubType = new SubjectTypeBLL().GetAll();
            for (int i = 0; i < rowCount; i++)
            {
                if (dlg != null)
                    dlg.IncreProgressBarValue();
                row += 1;
                ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Copy(Type.Missing);
                ((Range)(ws.Cells[row + 1, 1])).EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);
                ws.Cells[row, 3] = lst[i].AccountCode;
                ws.Cells[row, 4] = lst[i].AccountName;
                foreach (enums enu in lstAccountType)
                {
                    if (enu.EnumID == lst[i].AccountType)
                    {
                        ws.Cells[row, 5] = enu.EnumText;
                        break;
                    }
                }
                ws.Cells[row, 6] = lst[i].Description;
                AccountClassificationType act = (ItemLookUpEditClsTypeCode.DataSource as ListBase<AccountClassificationType>).Search("ClassificationTypeCode", lst[i].ClassificationTypeCode);
                if (act != null)
                {
                    ws.Cells[row, 8] = act.ClassificationTypeName;
                }
                SubjectType st = null;
                if (lst[i].LstAccSubjectType == null)
                {
                    lst[i].LstAccSubjectType = obj.GetAccountSubjectType(lst[i].AccountCode);
                }
                string accSubjectTypeName = string.Empty;
                foreach (AccountSubjectType ast in lst[i].LstAccSubjectType)
                {
                    st = lstSubType.Search("SubjectTypeCode", ast.SubjectTypeCode);
                    if (st != null)
                    {
                        if(accSubjectTypeName==string.Empty) accSubjectTypeName = st.SubjectTypeName;
                        else accSubjectTypeName += ", " + st.SubjectTypeName;
                    }
                }
                ws.Cells[row, 7] = accSubjectTypeName;
            }
            ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);
            ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);
            excelApp.Visible = true;
            if (dlg != null)
                dlg.Dispose();
            dlg = null;
        }
        public override void RefreshButtons()
        {
            base.RefreshButtons();
            btnExportExcel.Enabled = this.EditMode == VNS.Windows.FormEditMode.VIEW;
        }
    }
}