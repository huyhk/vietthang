using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using VNS.Data.BLL;
using VNS.Data;
using VNS.Windows.Forms;
using VNS.Windows;
using VNS.Context;
using VNS.Common;
using DevExpress.XtraGrid.Views.Grid;

namespace VNS.Windows.Controls
{
    public partial class EditControlBase : UserControl
    {
        protected DataChangedEventArgs dataTracking;

        public EditControlBase()
        {
            InitializeComponent();
        }
        private bool isLoaded = false;
        protected override void OnLoad(EventArgs e)
        {
            InitDataObject(); 
            base.OnLoad(e);
            this.isLoaded = true;            
            if (this.dataSource != null)
                BindData();

        }
        
        #region Properties

        protected FormEditMode editMode = FormEditMode.VIEW;
        /// <summary>Determines whether control in special mode of editing.</summary>
        [Browsable(true), DefaultValue(FormEditMode.VIEW), Category("VNS - Properties")]
        [Description("Determines whether control in special mode of editing.")]
        public FormEditMode EditMode
        {
            get { return editMode; }
            set { editMode = value;
            if (value == FormEditMode.EDIT && this.dataSource is ObjectBase)
                (this.dataSource as ObjectBase).Backup();
            }
        }
        //public bool ReadOnlyStatusNormalData
        //{
        //    get {
        //        return EditMode != FormEditMode.VIEW;
        //    }
        //}
        protected  IBusiness business;
        /// <summary>
        /// Gets or sets the BusinessLayer instance to perform database actions
        /// </summary>
        [Browsable(false)]
        public IBusiness Business
        {
            get { return business; }
            set { business = value; }
        }


        protected object dataSource;
        /// <summary>
        /// Gets or sets control datasource
        /// </summary>
        [Browsable(false)]
        public object DataSource
        {
            get { return dataSource; }
            set {
                this.BindingContext[this].ResumeBinding();
                dataSource = value;                
                //dataTracking = new DataChangedEventArgs(value);

                if (dataSource != null && this.isLoaded)
                {                   
                    this.BindData();
                }
            }
        }

        #endregion

        #region Protected Method
        /// <summary>
        /// Initializes the datasources, must be overriden in derived classes
        /// </summary>
        protected virtual void InitDataObject() {
#if DEBUG
            return;
#endif

        }
        /// <summary>
        /// Binds the datasource to Windows Form controls, must be overriden in derived classes
        /// </summary>
        protected virtual void BindData() { this.BindingContext[this].ResumeBinding(); }
        /// <summary>
        /// Validates input data, must be overriden in derived classes
        /// </summary>
        protected virtual int ValidateData() { return 0; }
        /// <summary>
        /// Updates data from Windows Form controls to datasource, must be overriden in derived classes
        /// </summary>        
        protected virtual void AssignData()
        {
            if ((this.dataSource is UserTracking))
            {
                if (this.editMode == FormEditMode.ADD)
                    (this.dataSource as UserTracking).UserCreated = ContextBase.CurrentUser.LoginName;
                else
                    (this.dataSource as UserTracking).UserUpdated = ContextBase.CurrentUser.LoginName;
            }            
        }
        /// <summary>
        /// Saves changes to database
        /// </summary>
        /// <returns>0 if success, negative integer if otherwise</returns>
        public virtual bool Save()
        {
            int ret = 0;
            if (business != null && dataSource != null)
            {
                string message = "Error while save data!";
                ErrorMessageType messageType = ErrorMessageType.VALIDATE;

                ret = ValidateData();
                if (ret != 0)
                {
                    OnError(ret, messageType);                                        
                    return false;
                }
                //(dataSource as ObjectBase).BeginEdit();
                AssignData();

                if (this.editMode == FormEditMode.ADD)
                {
                    messageType = ErrorMessageType.INSERT;
                    ret = business.Insert(dataSource);
                }
                else if (this.editMode == FormEditMode.EDIT)
                {
                    messageType = ErrorMessageType.UPDATE;
                    ret = business.Update(dataSource);
                }
                if (ret != 0)
                {

                    //(dataSource as ObjectBase).CancelEdit();
                    OnError(ret, messageType);
                    return false;

                }
                else
                {
                    (dataSource as ObjectBase).EndEdit();
                    //this.dataTracking.UpdateCurrentValue(dataSource);
                    this.OnDataChanged();
                }
            }

            return true;
        }

        /// <summary>
        /// Discards changes
        /// </summary>
        public virtual void Cancel()
        {
            this.BindingContext[this].ResumeBinding();
            if (this.dataSource is ObjectBase)
                (this.dataSource as ObjectBase).Restore();
            this.BindData();
        }
        public virtual void RefreshControl()
        {
            SetBackColor(this);
        }
        private void SetBackColor(Control control)
        {
            
            foreach (Control objControl in control.Controls)
            {
                if (objControl.Tag != null && objControl.Tag.ToString() != string.Empty)
                {
                    bool readOnlyStatus = false;
                    bool setStatus = true;
                    if (objControl.Tag.ToString() == enumControlStatus.NormalData.ToString())
                    { readOnlyStatus = (this.EditMode == FormEditMode.VIEW); }
                    else
                    {
                        if (objControl.Tag.ToString() == enumControlStatus.IDData.ToString())
                            readOnlyStatus = (this.EditMode != FormEditMode.ADD);
                        else if (objControl.Tag.ToString() == enumControlStatus.FixedData.ToString())
                            readOnlyStatus = true;
                        else
                            setStatus = false;

                    }

                    if (setStatus)
                    {
                        if (objControl is DevExpress.XtraEditors.TextEdit)
                        {
                            ((DevExpress.XtraEditors.TextEdit)objControl).Properties.ReadOnly = readOnlyStatus;
                        }
                        if (objControl is DevExpress.XtraGrid.GridControl)
                        {
                            foreach (DevExpress.XtraGrid.Views.Grid.GridView view in ((DevExpress.XtraGrid.GridControl)objControl).Views)
                            {
                                ((DevExpress.XtraGrid.Views.Grid.GridView)view).OptionsBehavior.Editable = !readOnlyStatus;
                                if (!readOnlyStatus)
                                    ((DevExpress.XtraGrid.Views.Grid.GridView)view).OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                                else
                                    ((DevExpress.XtraGrid.Views.Grid.GridView)view).OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                            }
                        }
                        if (objControl is DevExpress.XtraEditors.CheckEdit)
                        {
                            ((DevExpress.XtraEditors.CheckEdit)objControl).Properties.ReadOnly = readOnlyStatus;
                        }
                        if (objControl is DevExpress.XtraEditors.LookUpEdit)
                        {
                            ((DevExpress.XtraEditors.LookUpEdit)objControl).Properties.ReadOnly = readOnlyStatus;
                        }
                        if (objControl is TextBox)
                        { ((TextBox)objControl).ReadOnly = readOnlyStatus; }
                       
                    }
                }


                if (objControl is DevExpress.XtraEditors.TextEdit)
                {
                    DevExpress.XtraEditors.TextEdit o = (DevExpress.XtraEditors.TextEdit)objControl;
                    if (o.Properties.ReadOnly)
                        o.BackColor = Color.FromName(AppConfigBase.CONFIG_READONLYCOLOR);
                    else
                    {
                        if (o.Enabled)
                            o.BackColor = Color.FromName(AppConfigBase.CONFIG_ENABLEDCOLOR);
                    }
                }

                if (objControl is DevExpress.XtraEditors.LookUpEdit)
                {
                    DevExpress.XtraEditors.LookUpEdit o = (DevExpress.XtraEditors.LookUpEdit)objControl;
                    if (o.Properties.ReadOnly)
                        o.BackColor = Color.FromName(AppConfigBase.CONFIG_READONLYCOLOR);
                    else
                    {
                        if (o.Enabled)
                            o.BackColor = Color.FromName(AppConfigBase.CONFIG_ENABLEDCOLOR);
                    }
                }

                if (objControl is DevExpress.XtraEditors.DateEdit)
                {
                    DevExpress.XtraEditors.DateEdit o = (DevExpress.XtraEditors.DateEdit)objControl;
                    if (o.Properties.ReadOnly)
                        o.BackColor = Color.FromName(AppConfigBase.CONFIG_READONLYCOLOR);
                    else
                    {
                        if (o.Enabled)
                            o.BackColor = Color.FromName(AppConfigBase.CONFIG_ENABLEDCOLOR);
                    }
                }

                if (objControl is TextBox)
                {
                    TextBox o = (TextBox)objControl;
                    if (o.ReadOnly)
                        o.BackColor = Color.FromName(AppConfigBase.CONFIG_READONLYCOLOR);
                    else
                    {
                        if (o.Enabled)
                            o.BackColor = Color.FromName(AppConfigBase.CONFIG_ENABLEDCOLOR);
                    }
                }
                if (objControl is CheckBox)
                {
                    CheckBox o = (CheckBox)objControl;
                    if (o.Enabled)
                        o.BackColor = Color.FromName(AppConfigBase.CONFIG_READONLYCOLOR);
                    else
                    {
                        if (o.Enabled)
                            o.BackColor = Color.FromName(AppConfigBase.CONFIG_ENABLEDCOLOR);
                    }
                }

                if (objControl is ComboBox)
                {
                    ComboBox o = (ComboBox)objControl;
                    if (o.Enabled)
                        o.BackColor = Color.FromName(AppConfigBase.CONFIG_READONLYCOLOR);
                    else
                    {
                        if (o.Enabled)
                            o.BackColor = Color.FromName(AppConfigBase.CONFIG_ENABLEDCOLOR);
                    }
                }
                if (objControl.HasChildren)
                    SetBackColor(objControl);
            }
        }
        #endregion

        #region Public Event

        public event DataChanged DataChanged;
        protected virtual void OnDataChanged()
        {
            if (this.DataChanged !=null)
                this.DataChanged(this, dataTracking);
        }

        public event Error Error;
        protected virtual void OnError(int errNumber, ErrorMessageType messageType)
        {
            if (this.Error != null)
                this.Error(this, errNumber, messageType);
            else
            {
                if (this.ParentForm is FormBase)
                    MessageBox.Show((this.ParentForm as FormBase).GetTextMessage(messageType.ToString() + errNumber.ToString(), "Error while saving data"),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
            
        }
        #endregion

        public enum enumControlStatus { NormalData, IDData, FixedData, Other }
        public void SetControlStatus(Control control, enumControlStatus en)
        {
            control.Tag = en.ToString();
        }
        public void SetControlDataBind(Control control, string fieldName)
        {
            fieldName = "dataSource." + fieldName;

            if (control is TextBox)
            {
                (control as TextBox).DataBindings.Add("Text", this, fieldName, false, DataSourceUpdateMode.OnPropertyChanged);
            }
            if (control is DevExpress.XtraEditors.TextEdit)
            {
                (control as DevExpress.XtraEditors.TextEdit).DataBindings.Add("EditValue", this, fieldName, false, DataSourceUpdateMode.OnPropertyChanged);
            }


            if (control is DevExpress.XtraGrid.GridControl)
            {
                (control as DevExpress.XtraGrid.GridControl).DataBindings.Add("DataSource", this, fieldName);
            }

            if (control is DevExpress.XtraEditors.CheckEdit)
            {
                (control as DevExpress.XtraEditors.CheckEdit).DataBindings.Add("EditValue", this, fieldName, false, DataSourceUpdateMode.OnPropertyChanged);
            }

            if (control is CheckBox)
            {
                (control as CheckBox).DataBindings.Add("Checked", this, fieldName, false, DataSourceUpdateMode.OnPropertyChanged);
            }

            if (control is ComboBox)
            {
                (control as ComboBox).DataBindings.Add("Text", this, fieldName, false, DataSourceUpdateMode.OnPropertyChanged);
            }


            //if (control is DevExpress.XtraEditors.XtraUserControl)
            //{
            //    (control as DevExpress.XtraEditors.XtraUserControl).DataBindings.Add("DataSource", this, fieldName, false, DataSourceUpdateMode.OnPropertyChanged);
            //}
        }
        public virtual void ControlSettings()
        {}
        
    }
}
