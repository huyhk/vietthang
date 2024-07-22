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
            if (!this.DesignMode)
                InitDataObject(); 
            base.OnLoad(e);
            this.isLoaded = true;
            if (!this.DesignMode)
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
                (this.dataSource as ObjectBase).BeginEdit2();
            }
        }

        protected  IBusiness business;
        /// <summary>
        /// Gets or sets the BusinessLayer instance to perform database actions
        /// </summary>
        [Browsable(false), DefaultValue(null)]
        public IBusiness Business
        {
            get { return business; }
            set { business = value; }
        }


        protected object dataSource;
        /// <summary>
        /// Gets or sets control datasource
        /// </summary>
        [Browsable(false), DefaultValue(null)]
        public object DataSource
        {
            get { return dataSource; }
            set {
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
        protected virtual void InitDataObject() { }
        /// <summary>
        /// Binds the datasource to Windows Form controls, must be overriden in derived classes
        /// </summary>
        protected virtual void BindData()
        {
            //if (this.editMode == FormEditMode.ADD)
            //{
            //    if (this.firstControl != null)
            //        this.firstControl.Focus();
            //}
        }
        /// <summary>
        /// Confirm if needed before saving data
        /// </summary>
        /// <returns></returns>
        protected virtual bool ConfirmBeforeSave() { return true; }
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
            if (!ConfirmBeforeSave()) return false;
            int ret = 0;
            if (business != null && dataSource != null)
            {
                //string message = "Error while save data!";
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
                    if (dataSource is ObjectBase)
                        (dataSource as ObjectBase).EndEdit2();
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
            if (this.dataSource is ObjectBase)
                (this.dataSource as ObjectBase).CancelEdit2();
            this.BindData();
        }
        public virtual void RefreshControl()
        {
            SetBackColor(this);
            if (this.editMode == FormEditMode.ADD)
            {
                if (this.firstControl != null)
                    this.firstControl.Focus();
            }
        }
        private void SetBackColor(Control control)
        {
            foreach (Control objControl in control.Controls)
            {
                if (objControl is DevExpress.XtraEditors.TextEdit)
                {
                    DevExpress.XtraEditors.TextEdit o = (DevExpress.XtraEditors.TextEdit)objControl;
                    if (o.Properties.ReadOnly)
                        o.BackColor = Color.FromName(AppConfigs.CONFIG_READONLYCOLOR);
                    else
                    {
                        if (o.Enabled)
                            o.BackColor = Color.FromName(AppConfigs.CONFIG_ENABLEDCOLOR);
                    }
                }
                if (objControl is TextBox)
                {
                    TextBox o = (TextBox)objControl;
                    if (o.ReadOnly)
                        o.BackColor = Color.FromName(AppConfigs.CONFIG_READONLYCOLOR);
                    else
                    {
                        if (o.Enabled)
                            o.BackColor = Color.FromName(AppConfigs.CONFIG_ENABLEDCOLOR);
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

        protected bool IsDesignMode
        {
            get
            {
                return (System.Diagnostics.Process.GetCurrentProcess().ProcessName.IndexOf("devenv") != -1);

                //if (this.DesignMode)
                //    return true;
                //Control parent = this.Parent;
                //while (parent != null)
                //{
                //    if (parent.Site != null && parent.Site.DesignMode)
                //        return true;
                //    parent = parent.Parent;
                //}
                //return false;
            }
        }
        protected void SetTextCode(Control control)
        {
            if (control is DevExpress.XtraEditors.TextEdit)
            {
                DevExpress.XtraEditors.TextEdit t = control as DevExpress.XtraEditors.TextEdit;
                t.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
                t.Properties.Mask.EditMask = "[A-Z0-9.+/-]+";
            }
        }
        private Control firstControl;
        [DefaultValue(null)]
        public Control FirstControl
        {
            get { return firstControl; }
            set { firstControl = value; }
        }
    }
}
