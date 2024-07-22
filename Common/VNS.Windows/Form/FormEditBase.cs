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

using VNS.Windows.Forms;
using VNS.Windows.Controls;
using VNS.Data.DAL;
using VNS.Data.BLL;
using VNS.Data;
using VNS.Windows;
using VNS.Common;
using VNS.Utils;
using DevExpress.XtraGrid.Columns;
using VNS.Context;
namespace VNS.Windows.Forms
{
    /// <summary>
    /// User only for simple Edit's Form (does not include a list).
    /// </summary>
    public partial class FormEditBase : FormBase
    {
        #region Owner's members
        public bool isSearch = false;
        public object SelectedItem;
        protected bool isLoaded = false;
        protected bool isEdited = false;
        protected bool isNewItem = false;
        private object oldItem;
        private DataChangedEventArgs dataChangedArgs;
        private DataChangedEventArgs editControlDataChangedArgs;

        #endregion

        public FormEditBase()
        {
            InitializeComponent();
            
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
                    if (this.gridControlBase != null)
                        this.gridControlBase.DataSource = dataSource;
                    this.navigatorFrmEditBase.DataSource = dataSource;
                    if ((dataSource as IList).Count > 0)
                    {
                        if (this.GridControl != null)
                            this.CurrentItem = (this.BindingContext[gridControlBase.DataSource] as CurrencyManager).Current;
                        else
                            this.CurrentItem = (dataSource as IList)[0];
                    }
                    else
                        this.CurrentItem = null;
                    
                }
                else
                    this.CurrentItem = value;

                this.RefreshButtons();   
            }
        }

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

                
                this.currentItem = value;

                //this.dataChangedArgs = new DataChangedEventArgs(this.currentItem);

                if (this.editControl != null)
                    this.editControl.DataSource = this.currentItem;
                if (this.navigatorFrmEditBase != null && this.dataSource is IList)
                {

                    if (this.gridControlBase != null)
                    {                   
                        if (this.gridViewBase == null)
                            this.gridViewBase = (this.gridControlBase.MainView as DevExpress.XtraGrid.Views.Grid.GridView);
                        if (this.currentItem != gridViewBase.GetRow(gridViewBase.FocusedRowHandle))
                            this.BindingContext[this.dataSource].Position = (this.dataSource as IList).IndexOf(this.currentItem);
                        else
                            this.navigatorFrmEditBase.CurrentPosition = gridViewBase.FocusedRowHandle;
                    }
                    else
                        this.navigatorFrmEditBase.CurrentPosition = (this.dataSource as IList).IndexOf(this.currentItem);
                }
                if (this.isLoaded)
                {
                    this.ReInitDataObjects();
                    this.BindData();
                }
            }
        }
        private bool showButtonBar = true;
        /// <summary>
        /// Determines whether the button bar is displayed
        /// </summary>
        [Browsable(true),Description("Determines whether the button bar is displayed"),Category("VNS - Properties")]
        public bool ShowButtonBar
        {
            get { return this.showButtonBar; }
            set
            {
                this.showButtonBar = value;
                this.panelTop.Visible = value;
            }
        }

        protected DevExpress.XtraGrid.Views.Base.ColumnView gridViewBase;
        protected DevExpress.XtraGrid.GridControl gridControlBase;
        /// <summary>
        /// Gets or sets the grid control to display data list
        /// </summary>
        [Category("VNS - Properties"), Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public DevExpress.XtraGrid.GridControl GridControl
        {
            get { return gridControlBase; }
            set
            {
                gridControlBase = value;
                if (gridControlBase != null)
                {
                    this.gridViewBase = (this.gridControlBase.MainView as DevExpress.XtraGrid.Views.Grid.GridView);
                    this.gridViewBase.EndSorting += new EventHandler(FormEditBase_EndSorting);
                    this.gridViewBase.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(FormEditBase_FocusedRowChanged);
                    this.gridViewBase.ColumnFilterChanged += new EventHandler(gridViewBase_ColumnFilterChanged);
                    gridControlBase.ShowOnlyPredefinedDetails = true;

                    //if (this.isSearch)
                    //{
                    //    this.gridViewBase.DoubleClick+= new EventHandler(GridViewBase_DoubleClick);
                    //}
                }
            }
        }

        private void GridViewBase_DoubleClick(object sender, EventArgs e)
        {
            this.SelectedItem = this.currentItem;
            this.Close();
        }

        void gridViewBase_ColumnFilterChanged(object sender, EventArgs e)
        {
            if (this.dataSource != null)
            {
                if ((this.dataSource as IList).Count > 0)
                {
                    this.CurrentItem = (this.BindingContext[gridControlBase.DataSource] as CurrencyManager).Current;
                    if (this.navigatorFrmEditBase.DataSource != null)
                        this.navigatorFrmEditBase.CurrentPosition = gridViewBase.FocusedRowHandle;// (this.BindingContext[gridControl.DataSource] as CurrencyManager).Position;

                }
            }
        }

        void FormEditBase_EndSorting(object sender, EventArgs e)
        {
             
            
        }

        void FormEditBase_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (this.EditMode != FormEditMode.VIEW)
                return;
            if (this.dataSource != null)
            {
                if ((this.dataSource as IList).Count > 0)
                {
                    this.CurrentItem = (this.BindingContext[gridControlBase.DataSource] as CurrencyManager).Current;
                    if (this.navigatorFrmEditBase.DataSource != null)
                        this.navigatorFrmEditBase.CurrentPosition = e.FocusedRowHandle;// (this.BindingContext[gridControl.DataSource] as CurrencyManager).Position;
                    
                }
            }
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

        private void editControl_Error(object sender, int errNumber, ErrorMessageType messageType)
        {
            this.OnError(errNumber, messageType);
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
                if (this.editControl != null)
                    this.editControl.EditMode = value;
                
                this.RefreshButtons();                
                this.toolStripStatusLabelRight.Caption = this.editMode.ToString();                                      
            }
        }        
        #endregion

        #region Private Base Methods

        private void FormEditBase_Load(object sender, EventArgs e)
        {
            if (this.editControl != null)
                this.editControl.EditMode = this.editMode;
            InitDataObjects();
            BindData();
            this.isLoaded = true;
            this.RefreshButtons(false);     
          
            //
            if (this.GridControl != null)
            {
                GridColumn gc = this.gridViewBase.Columns.Add();
                gc.Caption = "Nơi tạo";
                gc.Visible = false;
                gc.FieldName = "ServerCreated";
                gc.OptionsColumn.AllowEdit = false;

                //this.gridView.OptionsBehavior.Editable = false;
                (this.gridViewBase as GridView).OptionsView.ShowAutoFilterRow = true;
                foreach (GridColumn col in (this.gridViewBase as GridView).Columns)
                {
                    if (col.ColumnType.FullName == "System.String")
                        col.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
                }
            }
            //
            if (this.isSearch)
            {
                this.AllowAddNew =
                    this.AllowDelete =
                    this.AllowEdit = false;

                if (this.isSearch)
                {
                    this.gridViewBase.DoubleClick += new EventHandler(GridViewBase_DoubleClick);
                }
            }
        }


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
                if (this.gridControlBase != null)
                    this.gridControlBase.RefreshDataSource();
            }
            return (ret);
        }

        private void navigatorFrmEditBase_PositionChanged(object sender, EventArgs e)
        {            
            if (this.gridControlBase != null && this.dataSource is IList)
            {                
                this.gridViewBase.FocusedRowHandle = this.navigatorFrmEditBase.CurrentPosition;                
                this.gridControlBase.FocusedView = this.gridViewBase;
                this.CurrentItem = (this.BindingContext[this.gridControlBase.DataSource] as CurrencyManager).Current;
            }
            else
                this.CurrentItem = navigatorFrmEditBase.SelectedItem;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editControl_DataChanged(object sender, DataChangedEventArgs e)
        {
            this.editControlDataChangedArgs = e;
            this.OnDataChanged();
        }

        #endregion


        #region Protected Method
        /// <summary>
        /// Initializes datasources
        /// </summary>
        protected virtual void InitDataObjects() { }
        protected virtual void ReInitDataObjects()
        {
            InitDataObjects();
        }
        /// <summary>
        /// Binds datasource to Windows Form controls
        /// </summary>
        protected virtual void BindData(){}
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

        #endregion

        #region Events

        public event DataChanged DataChanged;
        protected virtual void OnDataChanged()
        {
            if (this.DataChanged != null)
                this.DataChanged(this, dataChangedArgs);
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
            this.oldItem = this.currentItem;
            this.CurrentItem = this.AddNew();
            //if (this.EditControl != null)
            //    if (this.EditControl.FirstControl != null)
            //        this.EditControl.FirstControl.Focus();

        }

        /// <summary>
        /// Adds a new record into datasource and refreshes the buttons
        /// </summary>
        /// <returns></returns>
        public virtual object AddNew()
        {
            
            if (dataSource == null) return null;

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
                            
                    }
                    if (this.gridControlBase != null)
                        this.gridControlBase.RefreshDataSource();

                    this.RefreshButtons();
                }
                else
                    OnError(ret, ErrorMessageType.DELETE);
            }
        }

        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.AddNewItem();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.BeforeDelete();
        }
        protected virtual void BeforeDelete()
        {
            if (this.editMode != FormEditMode.ADD)
            {
                if (!this.AllowDeleteOther && !ContextBase.CurrentUser.IsAdmin)
                {
                    if (this.CurrentItem is UserTracking)
                        if ((this.CurrentItem as UserTracking).UserCreated != ContextBase.CurrentUser.LoginName)
                        {
                            MessageBox.Show("Bạn không được xóa của người khác!", this.Text);
                            return;
                        }
                }
                this.Delete();
            }
        }
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

        private bool allowSaveAndClose = true;
        [Category("Button Behavior")]
        public bool AllowSaveAndClose
        {
            get { return this.allowSaveAndClose; }
            set { this.allowSaveAndClose = value; this.RefreshButtons(true); }
        }

        private bool allowSaveAndNew = true;
        [Category("Button Behavior")]
        public bool AllowSaveAndNew
        {
            get { return this.allowSaveAndNew; }
            set { this.allowSaveAndNew = value; this.RefreshButtons(true); }
        }

        private bool allowDelete = true;
        [Category("Button Behavior")]
        public bool AllowDelete
        {
            get { return this.allowDelete; }
            set { this.allowDelete = value; this.RefreshButtons(true); }
        }
        public bool AllowEditOther;
        public bool AllowDeleteOther;
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
            this.btnSaveNew.Visible = this.allowSaveAndNew && this.allowAddNew ;
            this.btnSaveClose.Visible = this.allowSaveAndClose && (this.allowEdit || this.allowAddNew);
            this.btnAdd.Visible = this.allowAddNew ;
            this.btnEdit.Visible = this.allowEdit ;

            this.btnSave.Enabled = (this.editMode != FormEditMode.VIEW);
            this.btnSaveClose.Enabled = (this.editMode != FormEditMode.VIEW);
            this.btnSaveNew.Enabled = (this.editMode != FormEditMode.VIEW);
            this.btnAdd.Enabled = (this.editMode == FormEditMode.VIEW);
            this.btnEdit.Enabled = (this.editMode == FormEditMode.VIEW && this.currentItem != null);
            this.btnRemove.Enabled = (this.editMode == FormEditMode.VIEW && this.currentItem != null);

            this.btnCancel.Visible = (this.editMode != FormEditMode.VIEW);
            this.btnRemove.Visible = (this.editMode == FormEditMode.VIEW) && this.allowDelete;

            if (!buttonOnly)
            {
                this.navigatorFrmEditBase.Visible = (this.dataSource is IList);
                this.navigatorFrmEditBase.Enabled = (this.editMode == FormEditMode.VIEW);
                if (this.navigatorFrmEditBase.Enabled && this.navigatorFrmEditBase.Visible)
                    this.navigatorFrmEditBase.RefreshButtons();
                if (this.gridControlBase != null)
                    this.gridControlBase.Enabled = this.editMode == FormEditMode.VIEW;
                if (this.editControl != null)
                    this.editControl.RefreshControl();
            }
            //this.panelTop.ResumeLayout();
        }
        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.CancelItem();
            
            
        }

        public virtual void CancelItem()
        {
            if (this.editMode == FormEditMode.ADD)
            {
                this.EditMode = this.defaultMode;
                this.CancelNew();
            }
            else
            {
                this.EditMode = this.defaultMode;
                if (this.editControl != null)
                    this.editControl.Cancel();
            }

                        
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.BeforeEditItem();
        }
        protected virtual void BeforeEditItem()
        {
            if (!this.AllowEditOther && !ContextBase.CurrentUser.IsAdmin)
            {
                if (this.CurrentItem is UserTracking)
                    if ((this.CurrentItem as UserTracking).UserCreated != ContextBase.CurrentUser.LoginName)
                    {
                        MessageBox.Show("Bạn không được sửa của người khác!", this.Text);
                        return;
                    }
            }
            this.EditItem();
        }
        public virtual void EditItem()
        {
            this.EditMode = FormEditMode.EDIT;                        
                        
        }

        public void SetFormPrivilege(Form f)
        {

            if (f is FormEditBase)
            {
                FormEditBase fe = f as FormEditBase;

                fe.AllowAddNew = this.allowAddNew;
                fe.AllowEdit = this.allowEdit;
                fe.AllowDelete = this.allowDelete;

                fe.AllowEditOther = this.AllowEditOther;
                fe.AllowDeleteOther = this.AllowDeleteOther;  
            }
        }


        private void btnSave_EnabledChanged(object sender, EventArgs e)
        {
            this.MenuSave.Enabled = this.btnSave.Enabled;
        }

        private void btnSave_VisibleChanged(object sender, EventArgs e)
        {
            this.MenuSave.Visible = this.btnSave.Visible;
            this.MenuSave.Enabled = this.btnSave.Enabled && this.btnSave.Visible;
        }

        private void MenuSaveAndNew_Click(object sender, EventArgs e)
        {
            if (this.Save()) this.AddNewItem();
        }

        private void MenuSaveAndClose_Click(object sender, EventArgs e)
        {
            if (this.Save()) this.Close();
        }

        private void MenuAdd_Click(object sender, EventArgs e)
        {
            this.AddNewItem();
        }

        private void MenuEdit_Click(object sender, EventArgs e)
        {
            //this.EditItem();
            this.BeforeEditItem();
        }

        private void MenuDelete_Click(object sender, EventArgs e)
        {
            if (this.editMode != FormEditMode.ADD)
            {
                //this.Delete();
                this.BeforeDelete();
            }
        }

        private void MenuCancel_Click(object sender, EventArgs e)
        {
            this.CancelItem();
        }

        private void btnSaveNew_EnabledChanged(object sender, EventArgs e)
        {
            this.MenuSaveAndNew.Enabled = this.btnSaveNew.Enabled && this.btnSaveNew.Visible;
        }

        private void btnSaveNew_VisibleChanged(object sender, EventArgs e)
        {
            this.MenuSaveAndNew.Visible = this.btnSaveNew.Visible;
            this.MenuSaveAndNew.Enabled = this.btnSaveNew.Enabled && this.btnSaveNew.Visible;
        }

        private void btnSaveClose_EnabledChanged(object sender, EventArgs e)
        {
            this.MenuSaveAndClose.Enabled = this.btnSaveClose.Enabled && this.btnSaveClose.Visible;
        }

        private void btnSaveClose_VisibleChanged(object sender, EventArgs e)
        {
            this.MenuSaveAndClose.Visible = this.btnSaveClose.Visible;
            this.MenuSaveAndClose.Enabled = this.btnSaveClose.Enabled && this.btnSaveClose.Visible;
        }

        private void btnAdd_EnabledChanged(object sender, EventArgs e)
        {
            this.MenuAdd.Enabled = this.btnAdd.Enabled && this.btnAdd.Visible;
        }

        private void btnAdd_VisibleChanged(object sender, EventArgs e)
        {
            this.MenuAdd.Visible = this.btnAdd.Visible;
            this.MenuAdd.Enabled = this.btnAdd.Enabled && this.btnAdd.Visible;
        }

        private void btnEdit_EnabledChanged(object sender, EventArgs e)
        {
            this.MenuEdit.Enabled = this.btnEdit.Enabled && this.btnEdit.Visible;
        }

        private void btnEdit_VisibleChanged(object sender, EventArgs e)
        {
            this.MenuEdit.Visible = this.btnEdit.Visible;
            this.MenuEdit.Enabled = this.btnEdit.Enabled && this.btnEdit.Visible;
        }

        private void btnRemove_EnabledChanged(object sender, EventArgs e)
        {
            this.MenuDelete.Enabled = this.btnRemove.Enabled && this.btnRemove.Visible;
        }

        private void btnRemove_VisibleChanged(object sender, EventArgs e)
        {
            this.MenuDelete.Visible = this.btnRemove.Visible;
            this.MenuDelete.Enabled = this.btnRemove.Enabled && this.btnRemove.Visible;
        }

        private void btnCancel_EnabledChanged(object sender, EventArgs e)
        {
            this.MenuCancel.Enabled = this.btnCancel.Enabled && this.btnCancel.Visible;
        }

        private void btnCancel_VisibleChanged(object sender, EventArgs e)
        {
            this.MenuCancel.Visible = this.btnCancel.Visible;
            this.MenuCancel.Enabled = this.btnCancel.Enabled && this.btnCancel.Visible;
        }

        private void MenuSave_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        private void contextMenuStrip1_ItemAdded(object sender, ToolStripItemEventArgs e)
        {
            this.MenuSave.Enabled = this.btnSave.Enabled;
            this.MenuSave.Visible = this.btnSave.Visible;
            this.MenuSaveAndNew.Enabled = this.btnSaveNew.Enabled;
            this.MenuSaveAndNew.Visible = this.btnSaveNew.Visible;
            this.MenuSaveAndClose.Enabled = this.btnSaveClose.Enabled;
            this.MenuSaveAndClose.Visible = this.btnSaveClose.Visible;
            this.MenuAdd.Enabled = this.btnAdd.Enabled;
            this.MenuAdd.Visible = this.btnAdd.Visible;
            this.MenuEdit.Enabled = this.btnEdit.Enabled;
            this.MenuEdit.Visible = this.btnEdit.Visible;
            this.MenuDelete.Enabled = this.btnRemove.Enabled;
            this.MenuDelete.Visible = this.btnRemove.Visible;
            this.MenuCancel.Enabled = this.btnCancel.Enabled;
            this.MenuCancel.Visible = this.btnCancel.Visible;
        }
        private void RefreshContextMenu()
        { }

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
        
        protected void AddUserColumn()
        {
            GridColumn gc = this.gridViewBase.Columns.Add();
            gc.Caption = "Người tạo";
            gc.Visible = false;
            gc.FieldName = "UserCreated";
            gc.OptionsColumn.AllowEdit = false;

            gc = this.gridViewBase.Columns.Add();
            gc.Caption = "Ngày tạo";
            gc.Visible = false;
            gc.FieldName = "DateCreated";
            gc.OptionsColumn.AllowEdit = false;
            gc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            gc.DisplayFormat.FormatString = "dd/MM/yy H:mm:ss";

            gc = this.gridViewBase.Columns.Add();
            gc.Caption = "Người sửa";
            gc.Visible = false;
            gc.FieldName = "UserUpdated";
            gc.OptionsColumn.AllowEdit = false;

            gc = this.gridViewBase.Columns.Add();
            gc.Caption = "Ngày sửa";
            gc.Visible = false;
            gc.FieldName = "DateUpdated";
            gc.OptionsColumn.AllowEdit = false;
            gc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            gc.DisplayFormat.FormatString = "dd/MM/yy H:mm:ss";
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