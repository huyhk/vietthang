using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace VNS.ERP.GUI
{
	public class GridCheckMarksSelection {
		protected GridView view;
		protected ArrayList selection;
		private GridColumn column;
		private RepositoryItemCheckEdit edit; 
		

		public GridCheckMarksSelection() : base() {
			selection = new ArrayList();
		}

		public GridCheckMarksSelection(GridView view) : this() {
			View = view;
		}

		protected virtual void Attach(GridView view) {
			if(view == null) return;
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
			

			view.Click += new EventHandler(View_Click);
			view.CustomDrawColumnHeader += new ColumnHeaderCustomDrawEventHandler(View_CustomDrawColumnHeader);
			view.CustomDrawGroupRow += new RowObjectCustomDrawEventHandler(View_CustomDrawGroupRow);
			view.CustomUnboundColumnData += new CustomColumnDataEventHandler(view_CustomUnboundColumnData);
			view.RowStyle += new RowStyleEventHandler(view_RowStyle);
		}

		protected virtual void Detach() {
			if(view == null) return;
			if(column != null)
				column.Dispose();
			if(edit != null)
				edit.Dispose();
			
			view.Click -= new EventHandler(View_Click);
			view.CustomDrawColumnHeader -= new ColumnHeaderCustomDrawEventHandler(View_CustomDrawColumnHeader);
			view.CustomDrawGroupRow -= new RowObjectCustomDrawEventHandler(View_CustomDrawGroupRow);
			view.CustomUnboundColumnData -= new CustomColumnDataEventHandler(view_CustomUnboundColumnData);
			view.RowStyle -= new RowStyleEventHandler(view_RowStyle);

			view = null;
		}

		protected void DrawCheckBox(Graphics g, Rectangle r, bool Checked, bool Grayed) {
			DevExpress.XtraEditors.ViewInfo.CheckEditViewInfo info;
			DevExpress.XtraEditors.Drawing.CheckEditPainter painter;
			DevExpress.XtraEditors.Drawing.ControlGraphicsInfoArgs args;
			info = edit.CreateViewInfo() as DevExpress.XtraEditors.ViewInfo.CheckEditViewInfo;
			painter = edit.CreatePainter() as DevExpress.XtraEditors.Drawing.CheckEditPainter;
			if(Grayed)
				info.EditValue = edit.ValueGrayed;
			else
				info.EditValue = Checked;
			info.Bounds = r;
			info.CalcViewInfo(g);
			args = new DevExpress.XtraEditors.Drawing.ControlGraphicsInfoArgs(info, new DevExpress.Utils.Drawing.GraphicsCache(g), r);
			painter.Draw(args);
			args.Cache.Dispose();
		}

		private void View_Click(object sender, EventArgs e) {
			GridHitInfo info;
			Point pt = view.GridControl.PointToClient(Control.MousePosition);
			info = view.CalcHitInfo(pt);
			if(info.InColumn && info.Column == column) {
				if(SelectedCount == view.DataRowCount)
					ClearSelection();
				else
					SelectAll();
			}
			if(info.InRow && view.IsGroupRow(info.RowHandle) && info.HitTest != GridHitTest.RowGroupButton) {
				bool selected = IsGroupRowSelected(info.RowHandle);
				SelectGroup(info.RowHandle, !selected);
			}
		}

		private void View_CustomDrawColumnHeader(object sender, ColumnHeaderCustomDrawEventArgs e) {
			if(e.Column == column) {
				e.Info.InnerElements.Clear();
				e.Painter.DrawObject(e.Info);
				bool gray = SelectedCount > 0 && SelectedCount < view.DataRowCount ;
				DrawCheckBox(e.Graphics, e.Bounds, SelectedCount == view.DataRowCount, gray);
				e.Handled = true;
			}
		}

		private void View_CustomDrawGroupRow(object sender, RowObjectCustomDrawEventArgs e) {
			DevExpress.XtraGrid.Views.Grid.ViewInfo.GridGroupRowInfo info;
			info = e.Info as DevExpress.XtraGrid.Views.Grid.ViewInfo.GridGroupRowInfo;

			info.GroupText = "         " + info.GroupText.TrimStart();
			e.Info.Paint.FillRectangle(e.Graphics, e.Appearance.GetBackBrush(e.Cache), e.Bounds);
			e.Painter.DrawObject(e.Info);
			
			Rectangle r = info.ButtonBounds;
			r.Offset(r.Width * 2, 0);
			int g = GroupRowSelectionStatus(e.RowHandle);
			DrawCheckBox(e.Graphics, r, g>0, g<0);
			e.Handled = true;
		}

		private void view_RowStyle(object sender, RowStyleEventArgs e) {
			if(IsRowSelected(e.RowHandle)) {
				e.Appearance.BackColor = SystemColors.Highlight;
				e.Appearance.ForeColor = SystemColors.HighlightText;
			}
		}

		public GridView View {
			get {
				return view;
			}
			set {
				if(view != value) {
					Detach();
					Attach(value);
				}
			}
		}

		public GridColumn CheckMarkColumn {
			get {
				return column;
			}
		}

		public int SelectedCount {
			get {
				return selection.Count;
			}
		}

		public object GetSelectedRow(int index) {
			return selection[index];
		}

		public int GetSelectedIndex(object row) {
			return selection.IndexOf(row);
		}

		public void ClearSelection() {
			selection.Clear();
			Invalidate();
		}

		private void Invalidate() {
			view.BeginUpdate();
			view.EndUpdate();
		}

		public void SelectAll() {
			selection.Clear();
			if(view.DataSource is ICollection)
				selection.AddRange(((ICollection)view.DataSource));  // fast
			else
				for(int i = 0; i < view.DataRowCount; i++)  // slow
					selection.Add(view.GetRow(i));
			Invalidate();
		}

		public void SelectGroup(int rowHandle, bool select) {
			if(IsGroupRowSelected(rowHandle) && select) return;
			for(int i = 0; i < view.GetChildRowCount(rowHandle); i++) {
				int childRowHandle = view.GetChildRowHandle(rowHandle, i);
				if(view.IsGroupRow(childRowHandle))
					SelectGroup(childRowHandle, select);
				else
					SelectRow(childRowHandle, select, false);
			}
			Invalidate();
		}

		public void SelectRow(int rowHandle, bool select) {
			SelectRow(rowHandle, select, true);
		}

		private void SelectRow(int rowHandle, bool select, bool invalidate) {
			if(IsRowSelected(rowHandle) == select) return;
			object row = view.GetRow(rowHandle);
            if(select) 
				selection.Add(row);
			else
				selection.Remove(row);
			if(invalidate) {
				Invalidate();
			}
		}

		public int GroupRowSelectionStatus(int rowHandle) 
		{
			int count = 0;
			for(int i = 0; i < view.GetChildRowCount(rowHandle); i++) 
			{
				int row = view.GetChildRowHandle(rowHandle, i);
				if(view.IsGroupRow(row)) 
				{
					int g = GroupRowSelectionStatus(row);
					if( g < 0 ) return g;
					if( g > 0 ) count++;
				}
				else
				{
					if(IsRowSelected(row)) count++;
				}
			}
			if(count == 0) return 0;
			if(count == view.GetChildRowCount(rowHandle)) return 1;
			return -1;
		}

		public bool IsGroupRowSelected(int rowHandle) 
		{
			for(int i = 0; i < view.GetChildRowCount(rowHandle); i++) {
				int row = view.GetChildRowHandle(rowHandle, i);
				if(view.IsGroupRow(row)) {
					if(!IsGroupRowSelected(row)) return false;
				}
				else
					if(!IsRowSelected(row)) return false;
			}
			return true;
		}

		public bool IsRowSelected(int rowHandle) {
			object row = view.GetRow(rowHandle);
			return GetSelectedIndex(row) != -1;
		}

		private void view_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e) {
			if(e.Column == CheckMarkColumn) {
				if(e.IsGetData)
					e.Value = IsRowSelected(e.RowHandle);
				else
					SelectRow(e.RowHandle, (bool)e.Value);
			}
		}
	}
}
