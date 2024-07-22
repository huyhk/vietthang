using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
namespace VNS.Windows.Forms
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FormSearch : FormBase
    {
        protected bool isMultiSelect = false;
        public FormSearch():this(null,null,null,-1)
        {}
        public FormSearch(object dataSource, string[] fields, string[] headers):this(dataSource,fields,headers,-1)
        {}
        public FormSearch(object dataSource, string[] fields, string[] headers,int groupColumn)
        {
            if ((fields ==null && headers != null) || (fields != null && headers == null) || (fields!=null  && fields.Length != headers.Length))
                throw new ArgumentException("\"Fields\" and \"Headers\" arrays must have the same length"); 
            InitializeComponent();
            
            this.dataSource = dataSource;
            this.fields = fields;
            this.headers = headers;
            this.groupColumn = groupColumn;                                 
            
        }
        
        public DevExpress.XtraGrid.GridControl GridControl
        {
            get { return this.grdSearch; }
            
        }
	
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CreateGrid();
            
            this.txtTerm.Focus();
        }
        private GridColumn[] cols;
        private string[] fields;

        public string[] Fields
        {
            get { return fields; }
            set { fields = value; }
        }

        private string[] headers;

        public string[] Headers
        {
            get { return headers; }
            set { headers = value; }
        }

        private int groupColumn;

        public int GroupColumn
        {
            get { return groupColumn; }
            set { groupColumn = value; }
        }
	
        private object dataSource;

        public object DataSource
        {
            get { return dataSource; }
            set { dataSource = value; }
        }
	

        protected object searchResult;

        public object SearchResult
        {
            get { return searchResult; }
            set { searchResult = value; }
        }

        #region DoSearch overloads
        protected void DoSearch()
        { 
            this.DoSearch(txtTerm.Text,cboFields.SelectedItem as GridColumn,false);
        }
        protected void DoSearch(bool findNext)
        {
            this.DoSearch(txtTerm.Text, cboFields.SelectedItem as GridColumn, findNext);        
        }
        /// <summary>
        /// Performs a search within a column
        /// </summary>
        /// <param name="text">text to seach</param>
        /// <param name="col">search within column</param>
        /// <param name="findNext"></param>
        protected virtual void DoSearch(string text,GridColumn col,bool findNext)
        {
            int i = findNext?this.gridView1.FocusedRowHandle+1:0; 
            bool found = false;
            while (!found && i< gridView1.RowCount)
            {
                string cellText = gridView1.GetRowCellDisplayText(i, col);
                if (cellText.IndexOf(text, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    found = true;
                    break;
                }
                i += 1;
            }
            if (found)
            {
                this.gridView1.FocusedRowHandle = i;
                this.grdSearch.Focus();
            }
        }
        #endregion

        /// <summary>
        /// Creates the grid control
        /// </summary>
        protected virtual void CreateGrid()
        {
            if (this.fields == null || this.fields.Length == 0 || this.dataSource == null)
                return;
            this.gridView1.Columns.Clear();
            this.cols = new GridColumn[this.fields.Length];
            for (int i = 0; i < this.fields.Length; i++)
            {
                this.cols[i] = new GridColumn();
                this.cols[i].FieldName = this.fields[i];
                this.cols[i].Caption = this.headers[i];
                this.cols[i].Visible = true;
                this.cols[i].VisibleIndex = i;
                this.cols[i].OptionsColumn.AllowEdit = false;
                this.cols[i].OptionsColumn.ReadOnly = true;
            }
            this.gridView1.Columns.AddRange(cols);

            this.cboFields.ComboBox.DataSource = cols;
            this.cboFields.ComboBox.DisplayMember = "Caption";
            this.cboFields.ComboBox.ValueMember = "FieldName";
            this.grdSearch.DataSource = this.dataSource;
            this.gridView1.DoubleClick += new EventHandler(gridView1_DoubleClick);

            if (groupColumn >= 0 && groupColumn < this.fields.Length)
            {
                this.cols[groupColumn].Group();
                this.gridView1.ExpandAllGroups();
            }
            
        }

        void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (!this.isMultiSelect)
            {
                GridView view = sender as GridView;
                GridHitInfo hi = view.CalcHitInfo(view.GridControl.PointToClient(MousePosition));
                if (hi.RowHandle >= 0)
                    SelectRow();
            }
        }

        /// <summary>
        /// Selects the current item as result and closes the form
        /// </summary>
        protected virtual void SelectRow()
        {

            if (this.BindingContext[this.dataSource].Position >= 0)
                this.searchResult = this.BindingContext[this.dataSource].Current;
            else
                this.searchResult = null;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.SelectRow();
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.DoSearch();
            
        }

        private void btnSearchNext_Click(object sender, EventArgs e)
        {
            this.DoSearch(true);
            

        }
        #region static methods
        public static object ShowSearch(object dataSource, string[] fields, string[] headers)
        {
            return ShowSearch(dataSource, fields, headers, -1);
        }
        /// <summary>
        /// Displays seach form for a specific data source
        /// </summary>
        /// <param name="dataSource">DataSource to search</param>
        /// <param name="fields">Array contains field names</param>
        /// <param name="headers">Array contains field headers</param>
        /// <param name="headers">Group by column, -1 to ungroup</param>
        /// <returns></returns>
        public static object ShowSearch(object dataSource, string[] fields, string[] headers, int groupColumn)
        {
            FormSearch frm = new FormSearch(dataSource, fields, headers, groupColumn);
            if (frm.ShowDialog() == DialogResult.OK)
                return frm.searchResult;
            else
                return null;
        }
        #endregion

        private void FormSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                if (this.ActiveControl == this.txtTerm.TextBox)
                    this.DoSearch();
            }
        }

        private void grdSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !this.isMultiSelect)
                this.SelectRow();
            
        }
    }
}