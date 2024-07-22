using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;

using VNS.Windows.Forms;
using VNS.Windows.Controls;
using VNS.Data.DAL;
using VNS.Data.BLL;
using VNS.Data;
using VNS.Windows;
using VNS.Common;
using VNS.Utils;
namespace VNS.Windows.Forms
{
    /// <summary>
    /// User only for simple Edit's Form (does not include a list).
    /// </summary>
    public partial class FormEditBase : FormBase
    {
        #region Owner's members

        protected bool isLoaded = false;
        protected bool isEdited = false;
        protected bool isNewItem = false;
        private object oldItem;

        private DataChangedEventArgs editControlDataChangedArgs;

        #endregion

        public FormEditBase()
        {
            InitializeComponent();
            this.saveGroup.DefaultItem = btnSave;
            this.saveGroup.Text = btnSave.Text;
            this.saveGroup.Image = btnSave.Image;
        }

        #region Properties
        private string deleteConfirm = "Bạn có thật sự muốn xóa mục này?";
        /// <summary>
        /// Gets or sets the default delete confirmation text
        /// </summary>
        [Category("Default Text"),Browsable(true),Description("Text message for delete confirmation")]
        public string DeleteConfirm
        {
            get { return XMLFunctions.GetTextFromXML(this.MessageDocument, "DeleteConfirm","Text",this.deleteConfirm); }
            set { this.deleteConfirm = value; }
        }
        
        private string closeConfirm = "Bạn có muốn lưu thay đổi trước khi đóng?";
        /// <summary>
        /// Gets or sets the default close confirmation text
        /// </summary>
        [Category("Default Text"), Browsable(true), Description("Text message for close confirmation")]
        public string CloseConfirm
        {
            get { return XMLFunctions.GetTextFromXML(this.MessageDocument, "CloseConnfirm", "Text", this.closeConfirm); }
            set { this.closeConfirm = value;  }
        }

        protected BindingSource bdSource = new BindingSource();
        protected object dataSource;
        /// <summary>
        /// Gets or sets DataSource of the form.
        /// </summary>
        [Browsable(false)]
        public virtual object DataSource
        {

            get { return this.dataSource; }
            set {                
                
                this.dataSource = value;                
                if (dataSource is IList)
                {
                    if (this.gridControl != null)
                        this.gridControl.DataSource = dataSource;                    
                    if ((dataSource as IList).Count > 0)
                        this.CurrentItem = (dataSource as IList)[0];
                    //else
                    //    this.CurrentItem = null;
                    // tri edit

                    this.itemCount = (dataSource as IList).Count;
                }
                else
                    this.CurrentItem = value;

                //this.RefreshButtons();   
            }
        }

        private int currentPosition;

        public int CurrentPosition
        {
            get { return this.currentPosition; }
            set { this.currentPosition = value; this.txtPosition.Text = this.currentPosition.ToString(); }
        }

        private int itemCount;
        [Browsable(false)]
        public int ItemCount
        {
            get {
                if (this.dataSource is IList)
                {
                    return (this.dataSource as IList).Count;
                }
                return itemCount; }
            
        }

        public event CurrentItemChangedHandler CurrentItemChanged;
        protected object currentItem;
        /// <summary>
        /// Gets or sets the current item being displayed.
        /// </summary>
        [Browsable(false)]
        public virtual object CurrentItem
        {
            get { return this.currentItem; }
            set
            {
                if (this.currentItem == value)
                    return;
                
                OnCurrentItemChanged(this.currentItem, value);
                
                this.oldItem = this.currentItem;
                this.currentItem = value;                              

                if (this.editControl != null)
                    this.editControl.DataSource = this.currentItem;
                                
                if (this.dataSource is IList)
                {
                    
                    if (this.gridControl != null)
                    {
                        if (this.gridView == null)
                            this.gridView = (this.gridControl.MainView as DevExpress.XtraGrid.Views.Grid.GridView);
                        if (this.currentItem != gridView.GetRow(gridView.FocusedRowHandle))
                            this.BindingContext[this.gridControl.DataSource].Position = (this.dataSource as IList).IndexOf(this.currentItem);
                        
                    }
                    this.SetCurrentPosition();
                }
                if (this.isLoaded)
                {
                    this.ReInitDataObjects();
                    this.BindData();
                }
            }
        }

        public virtual void OnCurrentItemChanged(object oldItem, object newItem)
        {
            if (this.CurrentItemChanged != null)
                this.CurrentItemChanged(oldItem, newItem);
        }
        protected bool showNavigator = true;
        /// <summary>
        /// Determines whether the button bar is displayed
        /// </summary>
        [Browsable(true),Description("Determines whether the navigator button bar is displayed"),Category("VNS - Properties")]
        public bool ShowNavigator
        {
            get { return this.showNavigator; }
            set
            {
                this.showNavigator = value;                
            }
        }

        protected DevExpress.XtraGrid.Views.Grid.GridView gridView;
        protected DevExpress.XtraGrid.GridControl gridControl;
        /// <summary>
        /// Gets or sets the grid control to display data list
        /// </summary>
        [Category("VNS - Properties"), Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public DevExpress.XtraGrid.GridControl GridControl
        {
            get { return gridControl; }
            set
            {
                gridControl = value;
                if (gridControl != null)
                {
                    this.gridView = (this.gridControl.MainView as DevExpress.XtraGrid.Views.Grid.GridView);
                    this.gridView.EndSorting += new EventHandler(FormEditBase_EndSorting);                    
                    this.gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(FormEditBase_FocusedRowChanged);
                    this.gridView.DataSourceChanged += new EventHandler(gridView_DataSourceChanged);
                    //this.BindingContext[this.gridControl.DataSource].CurrentChanged += new EventHandler(FormEditBase_CurrentChanged);
            
                }
            }
        }
                
        void gridView_DataSourceChanged(object sender, EventArgs e)
        {
            this.cboColumn.ComboBox.DataSource = gridView.Columns;
            this.cboColumn.ComboBox.DisplayMember = "Caption";
        }               

        

        protected EditControlBase editControl;
        /// <summary>
        /// Determines the User Control to display/edit data
        /// </summary>
        [Category("VNS - Properties"), Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public EditControlBase EditControl
        {
            get { return editControl; }
            set
            {
                editControl = value;
                if (value != null)
                {
                    this.editControl.DataChanged += new DataChanged(editControl_DataChanged);
                    this.editControl.Error += new Error(editControl_Error);
                }
            }
        }

        

      

        protected IBusiness business;
        /// <summary>
        /// Determines the BusinessLayer instance to perform database actions
        /// </summary>
        public IBusiness Business
        {
            get { return business; }
            set
            {
                business = value; 
                if (this.editControl != null)
                    this.editControl.Business = value;
            }
        }

        protected FormEditMode defaultMode = FormEditMode.VIEW;
        [Browsable(true),Category("VNS - Properties")]
        public FormEditMode DefaultMode
        {
            get { return defaultMode; }
            set { defaultMode = value;}
        }
	
        protected FormEditMode editMode = FormEditMode.VIEW;
        /// <summary>
        /// Gets or sets the form mode, ADD, VIEW or EDIT
        /// </summary>
        [DefaultValue(FormEditMode.EDIT)]        
        public FormEditMode EditMode
        {
            get { return editMode; }
            set
            {
                editMode = value;
                if (this.isLoaded)
                    if (this.editControl != null)
                        this.editControl.EditMode = value;
                
                this.RefreshButtons();                
                this.toolStripStatusLabelRight.Caption = this.editMode.ToString();                                      
            }
        }

        private bool isListForm;
        [Category("VNS - Properties"),Description("Indicates wherether the form is a list form")]
        public bool IsListForm
        {
            get { return isListForm; }
            set {
                if (!value)
                    this.isSearchForm = false;
                isListForm = value; 
            }
        }

        private bool isSearchForm;
        [Category("VNS - Properties"),Description("Indicates wherether the form is a search form")]
        public bool IsSearchForm
        {
            get { return isSearchForm; }
            set {
                if (value)
                    this.isListForm = true;
                isSearchForm = value; 
            }
        }
	
        #endregion

        #region Form events

        private void FormEditBase_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                
                InitDataObjects();
                if (this.editControl != null)
                    this.editControl.ControlSettings();
                BindData();
                this.isLoaded = true;
                
                if (this.editControl != null)
                    this.editControl.EditMode = this.editMode;
                this.RefreshButtons(false);
            }
            
            
        }
        /// <summary>
        /// Form Close event, check if editing 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEditBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW)
            {
                DialogResult confirm = MessageBox.Show(this.closeConfirm, Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (confirm)
                {
                    case DialogResult.Yes:
                        if (!this.Save())
                            e.Cancel = true;
                        break;
                    case DialogResult.No:
                        this.CancelItem();
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }
        private void editControl_DataChanged(object sender, DataChangedEventArgs e)
        {
            this.editControlDataChangedArgs = e;
            this.OnDataChanged();
        }
        void FormEditBase_EndSorting(object sender, EventArgs e)
        {
            this.gridView.MoveNext(); this.gridView.MovePrev();
            this.SetCurrentPosition();
        }

        void FormEditBase_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (this.editMode == FormEditMode.VIEW)
            {
                if ((this.dataSource != null) && !this.gridView.IsGroupRow(this.gridView.FocusedRowHandle))
                {
                    if ((this.dataSource as IList).Count > 0)
                    {
                        this.CurrentItem = (this.BindingContext[gridControl.DataSource] as CurrencyManager).Current;

                    }
                }
            }
        }
        #endregion

        #region private methods
        private void SetCurrentPosition()
        {
            if (this.gridControl == null)
            {
                if (this.dataSource is IList)
                { 
                    this.CurrentPosition = (this.dataSource as IList).IndexOf(this.currentItem)+1;
                }
            }
            else if (this.gridView.IsValidRowHandle(this.gridView.FocusedRowHandle))
                this.CurrentPosition = this.gridView.FocusedRowHandle+1;

            this.btnPrev.Enabled = !(this.currentPosition == 1 || this.editMode != FormEditMode.VIEW);
            this.btnNext.Enabled = !(this.currentPosition == this.ItemCount || this.editMode != FormEditMode.VIEW);
        }

        private void ChangeCurrentPosition(int newPos)
        {
            if (this.gridControl != null)
            {
                this.gridView.FocusedRowHandle = newPos - 1;
            }
            else if (this.dataSource is IList)
                this.CurrentItem = (this.dataSource as IList)[newPos - 1];
        }
        private void editControl_Error(object sender, int errNumber, ErrorMessageType messageType)
        {
            this.OnError(errNumber, messageType);
        }
        #endregion

        #region Protected Method
        /// <summary>
        /// Initializes datasources
        /// </summary>
        protected virtual void InitDataObjects() { }
        protected virtual void ReInitDataObjects()
        {
            //InitDataObjects();
        }
        /// <summary>
        /// Binds datasource to Windows Form controls
        /// </summary>
        protected virtual void BindData() { }
        /// <summary>
        /// Validates input data
        /// </summary>
        /// <returns>0 if success, negative integer if otherwise</returns>
        protected virtual int ValidateData()
        {
            return 0;
        }
        /// <summary>
        /// Updates data from Windows Form controls to datasource
        /// </summary>
        protected virtual void AssignData()
        {
        }
        /// <summary>
        /// Saves data from datasource to database
        /// </summary>
        /// <returns>0 if success, negative integer if otherwise</returns>
        protected virtual bool SaveData() { return true; }

        /// <summary>
        /// Saves the changes and returns the result
        /// </summary>
        /// <returns>Result of saving, true if success, otherwise false</returns>
        protected virtual bool Save()
        {
            bool ret = false;
            if (this.editControl != null)
                ret = this.editControl.Save();
            else
                ret = SaveData();
            if (ret && this.editMode == FormEditMode.ADD && this.dataSource is ICancelAddNew)
                (this.dataSource as ICancelAddNew).EndNew((dataSource as IList).IndexOf(this.currentItem));
            if (ret)
            {
                this.EditMode = this.defaultMode;
                if (this.gridControl != null)
                    this.gridControl.RefreshDataSource();
                if (this.dataSource is IList)
                {
                    this.itemCount = (this.dataSource as IList).Count;
                }
            }
            //if (ret)
            //{
            //    if (this.DataSource is IListBase)
            //    {
            //        (this.DataSource as IListBase).LastUpdated = DateTime.Now;
            //    }
            //}
            return (ret);
        }
        #endregion

        #region Events

        //public event DataChanged DataChanged;
        protected virtual void OnDataChanged()
        {
            //if (this.DataChanged != null)
            //    this.DataChanged(this, dataChangedArgs);
        }

        public event Error Error;
        protected virtual void OnError(int errNumber, ErrorMessageType messageType)
        {
            if (this.Error != null)
                this.Error(this, errNumber, messageType);
            else
            {
                string message = "Error occured at " + messageType.ToString();
                MessageBox.Show(this.GetTextMessage(messageType.ToString() + errNumber.ToString(), message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Add/Remove button
        
        /// <summary>
        /// Adds a new record into datasource and refreshes the buttons
        /// </summary>
        public virtual void AddNewItem()
        {
            this.EditMode = FormEditMode.ADD;             
            this.CurrentItem = this.AddNew();                              

        }

        /// <summary>
        /// Adds a new record into datasource and refreshes the buttons
        /// </summary>
        /// <returns></returns>
        public virtual object AddNew()
        {
            
            if (dataSource == null) return null;

            //if (dataSource is IListBase)
            //{
            //    object oAdded = (dataSource as IListBase).NewItem;
            //    return oAdded;
            //}

            if (dataSource is IBindingList)
            {
                object oAdded = (dataSource as IBindingList).AddNew();                
                return oAdded;
            }
            if (dataSource is IList)
            {                
                Type elementType = (dataSource as IList)[0].GetType();
                try
                {
                    object oAdded = Activator.CreateInstance(elementType);
                    if ((dataSource as IList).Add(oAdded) != -1)
                    {                        
                        return oAdded;
                    }
                    return null;
                }
                catch
                {
                    return null;
                }
            }
            else
            {
                try
                {
                    Type elementType = dataSource.GetType();
                    object oAdded = Activator.CreateInstance(elementType);
                    return oAdded;
                }
                catch
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Cancels the previous Add New action
        /// </summary>
        public void CancelNew()
        {
            if (dataSource is ICancelAddNew)
            {
                (dataSource as ICancelAddNew).CancelNew((dataSource as IList).IndexOf(this.currentItem));
                //if (this.oldItem == null)
                //    this.Close();
                //else
                this.CurrentItem = this.oldItem;
            }
            else
                this.CurrentItem = dataSource;
            
        }
        /// <summary>
        /// Delete the selected item in the lst
        /// </summary>
        public virtual void Delete()
        {
            if (MessageBox.Show(this.DeleteConfirm,"Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int ret = this.business.Delete(this.currentItem);
                if (ret == 0)
                {
                    if (this.dataSource is IList)
                    {
                        IList list = this.dataSource as IList;
                        int i = list.IndexOf(this.currentItem);
                        list.RemoveAt(i);
                        if (i >= list.Count)
                            i = list.Count - 1;
                        if (i >= 0)
                            this.CurrentItem = list[i];
                        else
                            this.CurrentItem = null;

                        this.itemCount = list.Count;     
                    }
                    if (this.gridControl != null)
                        this.gridControl.RefreshDataSource();

                    this.RefreshButtons();
                }
                else
                    OnError(ret, ErrorMessageType.DELETE);
            }
        }

        /// <summary>
        /// Starts edit the current item
        /// </summary>
        public virtual void EditItem()
        {
            this.EditMode = FormEditMode.EDIT;
        }

        public virtual void OpenItem()
        {
            
        }

        /// <summary>
        /// Cancels editing/adding
        /// </summary>
        public virtual void CancelItem()
        {
            if (this.editMode == FormEditMode.ADD)
                this.CancelNew();
            else
            {
                if (this.editControl != null)
                    this.editControl.Cancel();
            }

            this.EditMode = this.defaultMode;
        }

        public virtual void Search()
        {
            this.toolStrip2.Visible = true;
            this.txtSearchTerm.Focus();
        }
        #endregion
        
        #region Button visible and allow properties
        private bool allowEdit = true;
        [Category("Button Behavior")]
        public bool AllowEdit
        {
            get { return this.allowEdit; }
            set { this.allowEdit = value; this.RefreshButtons(true); }
        }

        private bool allowSave = true;
        [Category("Button Behavior")]
        public bool AllowSave
        {
            get { return this.allowSave; }
            set { this.allowSave = value; this.RefreshButtons(true); }
        }
        private bool allowCancel = true;
        [Category("Button Behavior")]
        public bool AllowCancel
        {
            get { return this.allowCancel; }
            set { this.allowCancel = value; this.RefreshButtons(true); }
        }

        public bool AllowSaveAndNew
        {
            get { return true; }
            set { }
        }
        public bool AllowSaveAndClose
        {
            get { return true; }
            set { }
        }
        //private bool allowSaveAndClose = true;
        //[Category("Button Behavior")]
        //public bool AllowSaveAndClose
        //{
        //    get { return this.allowSaveAndClose; }
        //    set { this.allowSaveAndClose = value; this.RefreshButtons(true); }
        //}

        //private bool allowSaveAndNew = true;
        //[Category("Button Behavior")]
        //public bool AllowSaveAndNew
        //{
        //    get { return this.allowSaveAndNew; }
        //    set { this.allowSaveAndNew = value; this.RefreshButtons(true); }
        //}

        private bool allowDelete = true;
        [Category("Button Behavior")]
        public bool AllowDelete
        {
            get { return this.allowDelete; }
            set { this.allowDelete = value; this.RefreshButtons(true); }
        }

        private bool allowAddNew = true;
        [Category("Button Behavior")]
        public bool AllowAddNew
        {
            get { return this.allowAddNew; }
            set { this.allowAddNew = value; this.RefreshButtons(true); }
        }

        /// <summary>
        /// Updates buttons/navigator/grid status (enable/disable/visible...)
        /// </summary>
        public virtual void RefreshButtons()
        {
            this.RefreshButtons(false);          
                        
        }
        /// <summary>
        /// Updates button status (enable/disable/visible...)
        /// </summary>
        /// <param name="buttonOnly">true to refresh buttons only</param>
        public virtual void RefreshButtons(bool buttonOnly)
        {
            //this.panelTop.SuspendLayout ();
            this.btnSave.Visible = this.allowSave && (this.allowEdit || this.allowAddNew); 
            this.btnSaveNew.Visible = this.allowSave && this.allowAddNew ;
            this.btnSaveClose.Visible = this.allowSave && (this.allowEdit || this.allowAddNew);
            this.saveGroup.Visible = this.allowSave && (this.allowEdit || this.allowAddNew); 
            this.btnAdd.Visible = this.allowAddNew ;
            this.btnEdit.Visible = this.allowEdit ;
            //this.btnSearch.Visible = this.isListForm;
            this.sepSearch.Visible = this.btnSearch.Visible = this.gridControl != null;
            

            //this.btnSave.Enabled = (this.editMode != FormEditMode.VIEW);
            //this.btnSaveClose.Enabled = (this.editMode != FormEditMode.VIEW);
            //this.btnSaveNew.Enabled = (this.editMode != FormEditMode.VIEW);
            this.saveGroup.Enabled = (this.editMode != FormEditMode.VIEW);
            this.btnAdd.Enabled = (this.editMode == FormEditMode.VIEW);
            this.btnEdit.Enabled = (this.editMode == FormEditMode.VIEW && this.currentItem != null);
            this.btnRemove.Enabled = (this.editMode == FormEditMode.VIEW && this.currentItem != null);

            this.btnCancel.Visible = (this.editMode != FormEditMode.VIEW) && this.allowCancel;
            this.btnRemove.Visible = (this.editMode == FormEditMode.VIEW) && this.allowDelete;

            if (this.gridControl != null)
                this.gridControl.Enabled = this.editMode == FormEditMode.VIEW;

            if (!buttonOnly)
            {
                //this.navigatorFrmEditBase.Visible = (this.dataSource is IList);
                //this.navigatorFrmEditBase.Enabled = (this.editMode == FormEditMode.VIEW);
                //if (this.navigatorFrmEditBase.Enabled && this.navigatorFrmEditBase.Visible)
                //    this.navigatorFrmEditBase.RefreshButtons();

                //Refresh navigation

                this.sepNavigator.Visible = this.btnPrev.Visible = (this.dataSource is IList) && this.showNavigator;
                this.btnNext.Visible = (this.dataSource is IList) && this.showNavigator;
                this.txtPosition.Visible = (this.dataSource is IList) && this.showNavigator;
                this.btnPrev.Enabled = !(this.currentPosition <= 1 || this.editMode != FormEditMode.VIEW);
                this.btnNext.Enabled = !(this.currentPosition == this.ItemCount || this.editMode != FormEditMode.VIEW);
                this.txtPosition.Enabled = this.editMode == FormEditMode.VIEW;

                
                if (this.editControl != null)
                    this.editControl.RefreshControl();
            }
            //this.panelTop.ResumeLayout();
        }

        #endregion

        #region button click events
        private void btnSave_Clicked(object sender, EventArgs e)
        {
            this.Save();
        }
        private void btnSaveClose_Clicked(object sender, EventArgs e)
        {
            if (this.Save()) this.Close();
        }
        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            if (this.Save()) this.AddNewItem();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.AddNewItem();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (this.editMode != FormEditMode.ADD)
            {
                this.Delete();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.CancelItem();          
        }

        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.EditItem();
        }

        private void toolStripSplitButton1_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            (sender as ToolStripSplitButton).DefaultItem = e.ClickedItem;
            (sender as ToolStripSplitButton).Text = e.ClickedItem.Text;
            (sender as ToolStripSplitButton).Image = e.ClickedItem.Image;
        }
        

        #endregion

        protected void SetFormPrivilege(Form f)
        {

            if (f is FormEditBase)
            {
                FormEditBase fe = f as FormEditBase;

                fe.AllowAddNew = this.allowAddNew;
                fe.AllowEdit = this.allowEdit;
                fe.AllowDelete = this.allowDelete;                                
            }
        }
        
        private void txtPosition_Leave(object sender, EventArgs e)
        {
            int newPos = int.Parse(this.txtPosition.Text);
            if (newPos != this.currentPosition)
            {
                if (newPos < 1)
                    newPos = 1;
                else if (newPos > this.ItemCount)
                    newPos = this.ItemCount;
                this.ChangeCurrentPosition(newPos);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int newPos = this.currentPosition + 1;
            this.ChangeCurrentPosition(newPos);

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            int newPos = this.currentPosition - 1;
            this.ChangeCurrentPosition(newPos);
        }

        private void FormEditBase_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.N:
                        this.AddNewItem();
                        break;
                    case Keys.E:
                        this.EditItem();
                        break;
                    case Keys.F:
                        break;
                    case Keys.D:
                        this.Delete();
                        break;
                }

            }
            else {
                switch (e.KeyCode)
                {
                    case Keys.F2:
                        this.Save();
                        break;
                    case Keys.F3:
                        this.AddNewItem();
                        break;
                    case Keys.F4:
                        break;
                    case Keys.F5:
                        this.Delete();
                        break;
                }
            }
        }

        private void btnSearch_CheckedChanged(object sender, EventArgs e)
        {
            this.toolStrip2.Visible = (this.btnSearch.Checked);
        }

        private void toolStrip2_VisibleChanged(object sender, EventArgs e)
        {
            if (toolStrip2.Visible)
                this.txtSearchTerm.Focus();
        }

        #region DoSearch overloads
        private void DoSearch()
        {
            this.DoSearch(txtSearchTerm.Text, cboColumn.SelectedItem as GridColumn, false);
        }
        private void DoSearch(bool findNext)
        {
            this.DoSearch(txtSearchTerm.Text, cboColumn.SelectedItem as GridColumn, findNext);
        }
        /// <summary>
        /// Performs a search within a column
        /// </summary>
        /// <param name="text">text to seach</param>
        /// <param name="col">search within column</param>
        /// <param name="findNext"></param>
        private void DoSearch(string text, GridColumn col, bool findNext)
        {
            int i = findNext ? this.gridView.FocusedRowHandle + 1 : 0;
            bool found = false;
            while (!found && i < this.gridView.RowCount)
            {
                string cellText = this.gridView.GetRowCellDisplayText(i, col);
                if (cellText.IndexOf(text, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    found = true;
                    break;
                }
                i += 1;
            }
            if (found)
            {
                this.gridView.FocusedRowHandle = i;
                this.gridControl.Focus();
            }
        }
        #endregion

        private void btnFind_Click(object sender, EventArgs e)
        {
            this.DoSearch();
        }

        private void FormEditBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void FormEditBase_KeyDown(object sender, KeyEventArgs e)
        {
            //if (this.ActiveControl == this.gridControl)
            //    return;
            //switch (e.KeyCode)
            //{
            //    case Keys.Up:
            //        SendKeys.Send("+{TAB}");
            //        e.Handled = true;
            //        break;
            //    case Keys.Down:
            //        SendKeys.Send("{TAB}");
            //        e.Handled = true;
            //        break;
            //}
        }

    }
    public enum ErrorMessageType
    {
        DELETE,
        INSERT,
        UPDATE,
        VALIDATE
    }
    public delegate void Error(object sender, int errNumber, ErrorMessageType messageType);
    
    
}