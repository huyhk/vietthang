using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using DevExpress.Data;
namespace VNS.Windows.Forms
{
    public partial class FormCheck : FormSearch
    {
        public FormCheck()
            : this(null, null, null, -1,null,null)
        {
            //InitializeComponent();
        }

        private string checkField = string.Empty;
        private IList checkedValues = null;
        private System.Collections.ArrayList listValues ;
        System.Reflection.PropertyInfo prop;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataSource"></param>
        /// <param name="fields"></param>
        /// <param name="headers"></param>
        /// <param name="checkField"></param>
        public FormCheck(object dataSource, string[] fields, string[] headers,string checkField)
            : this(dataSource, fields, headers, -1,checkField,null)
        { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataSource"></param>
        /// <param name="fields"></param>
        /// <param name="headers"></param>
        /// <param name="checkField"></param>
        /// <param name="checkValues"></param>
        public FormCheck(object dataSource, string[] fields, string[] headers, string checkField,IList checkValues)
            : this(dataSource, fields, headers, -1,checkField,checkValues)
        { } 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataSource"></param>
        /// <param name="fields"></param>
        /// <param name="headers"></param>
        /// <param name="groupColumn"></param>
        /// <param name="checkField"></param>
        public FormCheck(object dataSource, string[] fields, string[] headers, int groupColumn,string checkField)
            : this(dataSource, fields, headers, groupColumn,checkField,null)
        {                        
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataSource">The data source to search</param>
        /// <param name="fields">Array of properties to search</param>
        /// <param name="headers">Array of field headers to display</param>
        /// <param name="groupColumn">Index of group column, -1 if no group</param>
        /// <param name="checkField">Property of DataSource objects contains value to compare with check values</param>
        /// <param name="checkedValues">List of  check values</param>
        public FormCheck(object dataSource, string[] fields, string[] headers, int groupColumn, string checkField,IList checkedValues)
            : base(dataSource, fields, headers, groupColumn)
        {
            this.isMultiSelect = true;
            this.checkField = checkField;
            if ((checkField != null) && (dataSource as IList).Count>0)
                prop = (dataSource as IList)[0].GetType().GetProperty(checkField);
            this.checkedValues = checkedValues;
            if (checkedValues!=null)
                listValues = new System.Collections.ArrayList(checkedValues);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataSource">The data source to search</param>
        /// <param name="fields">Array of properties to search</param>
        /// <param name="headers">Array of field headers to display</param>
        /// <param name="groupColumn">Index of group column, -1 if no group</param>
        /// <param name="checkField">Property of DataSource objects contains value to compare with check values</param>
        /// <param name="checkedValues">List of objects contains check values</param>
        /// <param name="valueField">Property of check objects contains value to check</param>
        public FormCheck(object dataSource, string[] fields, string[] headers, int groupColumn, string checkField, IList checkedValues, string valueField)
            : base(dataSource, fields, headers, groupColumn)
        {
            this.isMultiSelect = true;
            this.checkField = checkField;
            if ((checkField != null) && (dataSource as IList).Count > 0)
                prop = (dataSource as IList)[0].GetType().GetProperty(checkField);            
            if (checkedValues != null && checkedValues.Count > 0)
            {
                listValues = new ArrayList();
                System.Reflection.PropertyInfo vprop = checkedValues[0].GetType().GetProperty(valueField);
                if (vprop != null)
                {
                    foreach (object o in checkedValues)
                    {
                        listValues.Add(vprop.GetValue(o,null));
                    }
                }
            }
        }
        VNS.Windows.GridCheckMarksSelection checkSel;
        protected override void CreateGrid()
        {
            base.CreateGrid();
            DevExpress.XtraGrid.Views.Grid.GridView view = this.GridControl.DefaultView as DevExpress.XtraGrid.Views.Grid.GridView;

            checkSel = new GridCheckMarksSelection(view);
            
            checkSel.CheckMarkColumn.Width = 20;
            checkSel.CheckMarkColumn.VisibleIndex = 0;
            view.SortInfo.Add(checkSel.CheckMarkColumn, DevExpress.Data.ColumnSortOrder.Ascending);
            DevExpress.XtraGrid.Columns.GridColumn colQty = checkSel.View.Columns["Soluong"];
            if (colQty != null)
            {
                colQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom;
                colQty.SummaryItem.DisplayFormat = "{0:n0}";
                checkSel.View.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(View_CustomSummaryCalculate);
            }
            if (this.checkField != null && this.listValues != null)
            {
                if (prop!=null)
                {
                    for (int i = 0; i < view.RowCount; i++)
                    {
                        object val = prop.GetValue((DataSource as IList)[view.GetDataSourceRowIndex(i)], null);
                        if (listValues.Contains(val))
                        {
                            checkSel.SelectRow(i, true);
                        }
                    }
                }
            }      
            
        }

        decimal sluong = 0;
        void View_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView View = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            // Initialization
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start)
            {
                sluong = 0;
            }
            // Calculation
            if (e.SummaryProcess == CustomSummaryProcess.Calculate)
            {
                bool isDiscontinued = (bool)View.GetRowCellValue(e.RowHandle, checkSel.CheckMarkColumn);
                if (isDiscontinued) sluong += Convert.ToDecimal(e.FieldValue);
            }
            // Finalization
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Finalize)
            {
                e.TotalValue = sluong;
            }      

        }


        protected override void SelectRow()
        {

            this.searchResult = checkSel.GetSelectedRows();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        #region static methods
        public static object Show(object dataSource, string[] fields, string[] headers,string checkField)
        {
            return Show(dataSource, fields, headers, -1,null,null);
        }
        /// <summary>
        /// Displays seach form for a specific data source
        /// </summary>
        /// <param name="dataSource">DataSource to search</param>
        /// <param name="fields">Array contains field names</param>
        /// <param name="headers">Array contains field headers</param>
        /// <param name="headers">Group by column, -1 to ungroup</param>
        /// <returns></returns>
        public static object Show(object dataSource, string[] fields, string[] headers, int groupColumn,string checkField, IList checkedValues)
        {
            FormCheck frm = new FormCheck(dataSource, fields, headers,-1,checkField,checkedValues);
            if (frm.ShowDialog() == DialogResult.OK)
                return frm.searchResult;
            else
                return null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataSource">The data source to search</param>
        /// <param name="fields">Array of properties to search</param>
        /// <param name="headers">Array of field headers to display</param>
        /// <param name="groupColumn">Index of group column, -1 if no group</param>
        /// <param name="checkField">Property of DataSource objects contains value to compare with check values</param>
        /// <param name="checkedValues">List of objects contains check values</param>
        /// <param name="valueField">Property of check objects contains value to check</param>
        /// <returns>A list of selected objects</returns>
        public static object Show(object dataSource, string[] fields, string[] headers, int groupColumn, string checkField, IList checkedValues,string valueField)
        {
            FormCheck frm = new FormCheck(dataSource, fields, headers, -1, checkField, checkedValues,valueField);
            if (frm.ShowDialog() == DialogResult.OK)
                return frm.searchResult;
            else
                return null;
        }
        #endregion
    }
     
}

