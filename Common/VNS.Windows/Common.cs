using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;


namespace VNS.Windows
{
    /// <summary>
    /// Provides Dev Express xtraGrid utilities
    /// </summary>
    public class GridUtils
    {
        /// <summary>
        /// Returns filtered data of a grid
        /// Usage: DataView dv = VNS.Windows.GridUtils.GetDataView(gc);
        /// </summary>
        /// <param name="gc">grid control</param>
        /// <returns>A dataview contains filtered data</returns>
        public static DataView GetDataView(GridControl gc)
        {
            DataView dv = null;

            if (gc.FocusedView != null && gc.FocusedView.DataSource != null)
            {
                ColumnView view = (ColumnView)gc.FocusedView;
                DataView current = (DataView)view.DataSource;

                string filterExpression = GetFilterExpression(view);
                string sortExpression = GetSortExpression(view);

                string currentFilter = current.RowFilter;

                //create a new data view 
                dv = new DataView(current.Table);
                dv.Sort = sortExpression;

                if (filterExpression != String.Empty)
                {
                    if (currentFilter != String.Empty)
                    {
                        currentFilter += " AND ";
                    }
                    currentFilter += filterExpression;
                }
                dv.RowFilter = currentFilter;
            }
            return dv;
        }

        /// <summary>
        /// Returns filtered data of a gridview
        /// Usage: DataView dv = VNS.Windows.GridUtils.GetDataView(gv);
        /// </summary>
        /// <param name="gv">gridview control</param>
        /// <returns>A dataview contains filtered data</returns>
        public static DataTable GetDataTable(GridView gv)
        {
            DataView dv = null;

            if (gv.DataSource != null)
            {
                DataTable dt = ((DataView)gv.DataSource).ToTable();
                dv = dt.DefaultView;

                string filterExpression = GetFilterExpression(gv);
                string sortExpression = GetSortExpression(gv);

                string currentFilter = gv.RowFilter;

                dv.Sort = sortExpression;

                if (filterExpression != String.Empty)
                {
                    if (currentFilter != String.Empty)
                    {
                        currentFilter += " AND ";
                    }
                    currentFilter += filterExpression;
                }
                dv.RowFilter = currentFilter;
            }
            return dv.ToTable();
        }


        private static string GetFilterExpression(ColumnView view)
        {
            string expression = String.Empty;

            if (view.ActiveFilter != null && view.ActiveFilterEnabled
                          && view.ActiveFilter.Expression != String.Empty)
            {
                expression = view.ActiveFilter.Expression;
            }
            return expression;
        }

        private static string GetSortExpression(ColumnView view)
        {
            string expression = String.Empty;
            foreach (GridColumnSortInfo info in view.SortInfo)
            {
                expression += string.Format("[{0}]", info.Column.FieldName);

                if (info.SortOrder == DevExpress.Data.ColumnSortOrder.Descending)
                    expression += " DESC";
                else
                    expression += " ASC";
                expression += ", ";
            }
            return expression.TrimEnd(',', ' ');
        }


    }
    /// <summary>
    /// Unbound DevExpress checkbox column helper
    /// </summary>
    public class GridCheckMarksSelection
    {
        protected GridView view;
        protected ArrayList selection;
        private GridColumn column;
        private RepositoryItemCheckEdit edit;


        public GridCheckMarksSelection()
            : base()
        {
            selection = new ArrayList();
        }

        public GridCheckMarksSelection(GridView view)
            : this()
        {
            View = view;
        }

        protected virtual void Attach(GridView view)
        {
            if (view == null) return;
            selection.Clear();
            this.view = view;
            edit = view.GridControl.RepositoryItems.Add("CheckEdit") as RepositoryItemCheckEdit;
            column = view.Columns.Add();
            column.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            column.VisibleIndex = int.MaxValue;
            column.FieldName = "CheckMarkSelection";
            column.Caption = "Mark";
            column.OptionsColumn.ShowCaption = false;
            column.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            column.ColumnEdit = edit;
            edit.EditValueChanged += new EventHandler(edit_EditValueChanged);
            
            view.Click += new EventHandler(View_Click);
            view.CustomDrawColumnHeader += new ColumnHeaderCustomDrawEventHandler(View_CustomDrawColumnHeader);
            view.CustomDrawGroupRow += new RowObjectCustomDrawEventHandler(View_CustomDrawGroupRow);
            view.CustomUnboundColumnData += new CustomColumnDataEventHandler(view_CustomUnboundColumnData);
            view.RowStyle += new RowStyleEventHandler(view_RowStyle);
        }

        void edit_EditValueChanged(object sender, EventArgs e)
        {
            SelectRow(view.FocusedRowHandle, (sender as DevExpress.XtraEditors.CheckEdit).Checked);
            view.UpdateSummary();
        }

        

        protected virtual void Detach()
        {
            if (view == null) return;
            if (column != null)
                column.Dispose();
            if (edit != null)
                edit.Dispose();

            view.Click -= new EventHandler(View_Click);
            view.CustomDrawColumnHeader -= new ColumnHeaderCustomDrawEventHandler(View_CustomDrawColumnHeader);
            view.CustomDrawGroupRow -= new RowObjectCustomDrawEventHandler(View_CustomDrawGroupRow);
            view.CustomUnboundColumnData -= new CustomColumnDataEventHandler(view_CustomUnboundColumnData);
            view.RowStyle -= new RowStyleEventHandler(view_RowStyle);

            view = null;
        }

        protected void DrawCheckBox(Graphics g, Rectangle r, bool Checked)
        {
            DevExpress.XtraEditors.ViewInfo.CheckEditViewInfo info;
            DevExpress.XtraEditors.Drawing.CheckEditPainter painter;
            DevExpress.XtraEditors.Drawing.ControlGraphicsInfoArgs args;
            info = edit.CreateViewInfo() as DevExpress.XtraEditors.ViewInfo.CheckEditViewInfo;
            painter = edit.CreatePainter() as DevExpress.XtraEditors.Drawing.CheckEditPainter;
            info.EditValue = Checked;
            info.Bounds = r;
            info.CalcViewInfo(g);
            args = new DevExpress.XtraEditors.Drawing.ControlGraphicsInfoArgs(info, new DevExpress.Utils.Drawing.GraphicsCache(g), r);
            painter.Draw(args);
            args.Cache.Dispose();
        }

        private void View_Click(object sender, EventArgs e)
        {
            GridHitInfo info;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            info = view.CalcHitInfo(pt);
            if (info.InColumn && info.Column == column)
            {
                if (SelectedCount == view.DataRowCount)
                    ClearSelection();
                else
                    SelectAll();
            }
            if (info.InRow && view.IsGroupRow(info.RowHandle) && info.HitTest != GridHitTest.RowGroupButton)
            {
                bool selected = IsGroupRowSelected(info.RowHandle);
                SelectGroup(info.RowHandle, !selected);
            }
        }

        private void View_CustomDrawColumnHeader(object sender, ColumnHeaderCustomDrawEventArgs e)
        {
            if (e.Column == column)
            {
                e.Info.InnerElements.Clear();
                e.Painter.DrawObject(e.Info);
                DrawCheckBox(e.Graphics, e.Bounds, SelectedCount == view.DataRowCount);
                e.Handled = true;
            }
        }

        private void View_CustomDrawGroupRow(object sender, RowObjectCustomDrawEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridGroupRowInfo info;
            info = e.Info as DevExpress.XtraGrid.Views.Grid.ViewInfo.GridGroupRowInfo;

            info.GroupText = "         " + info.GroupText.TrimStart();
            e.Info.Paint.FillRectangle(e.Graphics, e.Appearance.GetBackBrush(e.Cache), e.Bounds);
            e.Painter.DrawObject(e.Info);

            Rectangle r = info.ButtonBounds;
            r.Offset(r.Width * 2, 0);
            DrawCheckBox(e.Graphics, r, IsGroupRowSelected(e.RowHandle));
            e.Handled = true;
        }

        private void view_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (IsRowSelected(e.RowHandle))
            {
                e.Appearance.BackColor = SystemColors.Highlight;
                e.Appearance.ForeColor = SystemColors.HighlightText;
            }
        }

        public GridView View
        {
            get
            {
                return view;
            }
            set
            {
                if (view != value)
                {
                    Detach();
                    Attach(value);
                }
            }
        }

        public GridColumn CheckMarkColumn
        {
            get
            {
                return column;
            }
        }

        public int SelectedCount
        {
            get
            {
                return selection.Count;
            }
        }

        public object GetSelectedRow(int index)
        {
            return selection[index];
        }

        public object GetSelectedRows()
        {
            return selection;
        }

        public int GetSelectedIndex(object row)
        {
            return selection.IndexOf(row);
        }

        public void ClearSelection()
        {
            selection.Clear();
            Invalidate();
        }

        private void Invalidate()
        {
            view.BeginUpdate();
            view.EndUpdate();
        }

        public void SelectAll()
        {
            selection.Clear();
            if (view.DataSource is ICollection)
                selection.AddRange(((ICollection)view.DataSource));  // fast
            else
                for (int i = 0; i < view.DataRowCount; i++)  // slow
                    selection.Add(view.GetRow(i));
            Invalidate();
        }

        public void SelectGroup(int rowHandle, bool select)
        {
            if (IsGroupRowSelected(rowHandle) && select) return;
            for (int i = 0; i < view.GetChildRowCount(rowHandle); i++)
            {
                int childRowHandle = view.GetChildRowHandle(rowHandle, i);
                if (view.IsGroupRow(childRowHandle))
                    SelectGroup(childRowHandle, select);
                else
                    SelectRow(childRowHandle, select, false);
            }
            Invalidate();
        }

        public void SelectRow(int rowHandle, bool select)
        {
            SelectRow(rowHandle, select, true);
        }

        private void SelectRow(int rowHandle, bool select, bool invalidate)
        {
            if (IsRowSelected(rowHandle) == select) return;
            object row = view.GetRow(rowHandle);
            if (select)
                selection.Add(row);
            else
                selection.Remove(row);
            if (invalidate)
            {
                Invalidate();
            }
        }

        public bool IsGroupRowSelected(int rowHandle)
        {
            for (int i = 0; i < view.GetChildRowCount(rowHandle); i++)
            {
                int row = view.GetChildRowHandle(rowHandle, i);
                if (view.IsGroupRow(row))
                {
                    if (!IsGroupRowSelected(row)) return false;
                }
                else
                    if (!IsRowSelected(row)) return false;
            }
            return true;
        }

        public bool IsRowSelected(int rowHandle)
        {
            object row = view.GetRow(rowHandle);
            return GetSelectedIndex(row) != -1;
        }

        private void view_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            if (e.Column == CheckMarkColumn)
            {
                if (e.IsGetData)
                    e.Value = IsRowSelected(e.RowHandle);
                else
                    SelectRow(e.RowHandle, (bool)e.Value);
            }
        }
    }

    public class ButtonClickArgs : System.EventArgs
    {
        public ButtonClickArgs(NavigatorButton button)
        {
            this.button = button;
        }

        private NavigatorButton button;
        /// <summary>
        /// Gets special button clicked.
        /// </summary>
        public NavigatorButton Button
        {
            get { return this.button; }
        }

    }
    public delegate void ButtonClick(object sender, ButtonClickArgs button);
    /// <summary>
    /// Determines the special button clicked.
    /// </summary>
    public enum NavigatorButton
    {
        None,
        Position,
        Remove,
        Add
    }
    public enum FormEditMode
    {
        VIEW,
        ADD,
        EDIT        
    }
    public delegate void CurrentItemChangedHandler(object oldItem, object newItem);
}
