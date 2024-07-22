using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using VNS.Data.BLL;
using VNS.Common;
using System.Reflection;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using VNS.Windows.Forms;
using System.Collections;
using System.Xml;
using VNS.Utils;

namespace VNS.Windows.Controls
{
    public partial class UCListBase : UserControl
    {
        private bool showOpenFormDialog = false;
        /// <summary>
        /// 
        /// </summary>
        [Browsable(true)]
        public bool ShowOpenFormDialog
        {
            get { return showOpenFormDialog; }
            set { showOpenFormDialog = value; }
        }

        private string m_LayoutFile;

        [Browsable(true)]
        [Category("VNS - Properties")]
        public string LayoutFile
        {
            get { return m_LayoutFile; }
            set { m_LayoutFile = value; }
        }
        public string LayoutSuffix = string.Empty;

        [Browsable(true)]
        public override string Text
        {
            get
            {
                return this.pannelHeader.Properties.Buttons[0].Caption;
            }
            set
            {
                this.pannelHeader.Properties.Buttons[0].Caption = " " + (value as string).Trim();
            }
        }
        private IBusiness business;
        protected IBusiness Business
        {
            get { return business; }
            set { business = value; }
        }
        private bool allowViewItem = true;
        [Browsable(true)]
        public bool AllowViewItem
        {
            get { return allowViewItem; }
            set 
            { 
                allowViewItem = value;
                this.mnuViewItem.Visible = value;
            }
        }
        private bool allowEditItem = true;
        [Browsable(true)]
        public bool AllowEditItem
        {
            get { return allowEditItem; }
            set 
            { 
                allowEditItem = value;
                this.mnuEditItem.Visible = value;
                this.pannelHeader.Properties.Buttons[2].Visible = value;
            }
        }
        private bool allowNewItem = true;
        [Browsable(true)]
        public bool AllowNewItem
        {
            get { return allowNewItem; }
            set 
            { 
                allowNewItem = value;
                this.mnuNewItem.Visible = value;
                this.pannelHeader.Properties.Buttons[1].Visible = value;
            }
        }
        private bool allowDeleteItem = true;
        [Browsable(true)]
        public bool AllowDeleteItem
        {
            get { return allowDeleteItem; }
            set 
            { 
                allowDeleteItem = value;
                this.mnuDeleteItem.Visible = value;
                this.pannelHeader.Properties.Buttons[3].Visible = value;
            }
        }
        public static UCListBase Current;
        private Type formOpenType = null;
        [Browsable(false)]
        public Type FormOpenType
        {
            get { return formOpenType; }
            set { formOpenType = value; }
        }
      
        private Type[] paramTypeConstructorFormOpenType = Type.EmptyTypes;
        [Browsable(false)]
        protected Type[] ParamTypeConstructorFormOpenType
        {
            get { return paramTypeConstructorFormOpenType; }
            set { paramTypeConstructorFormOpenType = value; }
        }
        private Object[] paramConstructorFormOpenType = null;
        [Browsable(false)]
        protected Object[] ParamConstructorFormOpenType
        {
            get { return paramConstructorFormOpenType; }
            set { paramConstructorFormOpenType = value; }
        }
        private Object[] fixedParamConstructorFormOpenType = null;
        [Browsable(false)]
        public Object[] FixedParamConstructorFormOpenType
        {
            get { return fixedParamConstructorFormOpenType; }
            set { fixedParamConstructorFormOpenType = value; }
        }
        private Object dataSource;
        public Object DataSource
        {
            get { return dataSource; }
            set 
            { 
                dataSource = value;
                gridControlBase.DataSource = value;
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
                currentItem = value;
                if (value != null)
                {
                    if (this.currentItem != gridViewBase.GetRow(gridViewBase.FocusedRowHandle))
                    {
                        gridViewBase.UnselectRow(gridViewBase.FocusedRowHandle);
                        this.BindingContext[this.gridControlBase.DataSource].Position = (this.dataSource as IList).IndexOf(value);
                        gridViewBase.SelectRow(gridViewBase.FocusedRowHandle);
                    }
                }
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
                    //gridControlBase.ContextMenu = contextMenuStrip1;
                    this.gridViewBase = (this.gridControlBase.MainView as DevExpress.XtraGrid.Views.Grid.GridView);
                    this.gridViewBase.KeyDown += new KeyEventHandler(gridViewBase_KeyDown);
                    this.gridViewBase.DoubleClick += new System.EventHandler(this.gridViewBase_DoubleClick);
                    this.gridViewBase.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewBase_FocusedRowChanged);
                    this.gridViewBase.ColumnFilterChanged += new EventHandler(gridViewBase_ColumnFilterChanged);
                    this.gridViewBase.DataSourceChanged += new EventHandler(gridViewBase_DataSourceChanged);
                }
            }
        }

        protected virtual void RefreshButton()
        {
            CurrencyManager cr = null;
            bool buttonEnable = false;
            if (this.gridControlBase.DataSource != null && this.gridViewBase.FocusedRowHandle >= 0)
            {
                cr = this.BindingContext[this.gridControlBase.DataSource] as CurrencyManager;
                if (cr.Count > 0)
                {
                    buttonEnable = true;
                }
            }
            pannelHeader.Properties.Buttons[3].Enabled = buttonEnable;
            pannelHeader.Properties.Buttons[2].Enabled = buttonEnable;
            mnuDeleteItem.Enabled = buttonEnable;
            mnuEditItem.Enabled = buttonEnable;
            mnuViewItem.Enabled = buttonEnable;
        }

        void gridViewBase_DataSourceChanged(object sender, EventArgs e)
        {
            this.RefreshButton();
        }

        void gridViewBase_ColumnFilterChanged(object sender, EventArgs e)
        {
            this.FocusedRowChanged();
            this.RefreshButton();
        }

        void gridViewBase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                this.DeleteSelection();
            }
        }

        private void DeleteSelection()
        {
            if (this.Business != null)
            {
                if (this.gridViewBase.RowCount > 0 && this.AllowDeleteItem)
                {
                    if (MessageBox.Show("Are you sure you want to delete all selected items", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int[] selectedIndexs = this.gridViewBase.GetSelectedRows();
                        int len = selectedIndexs.Length;
                        int iError = 0;
                        int[] deleted = new int[len];
                        int i = 0;
                        int j = 0;
                        for (j = 0; j < len; j++)
                        {
                            deleted[j] = -1;
                        }
                        j = 0;
                        for (i = 0; i < len; i++)
                        {
                            if (iError == 0)
                            {
                                Object o = this.gridViewBase.GetRow(selectedIndexs[i]);
                                iError = this.Business.Delete(o);
                            }
                            if (iError == 0)
                            {
                                deleted[j] = selectedIndexs[i];
                                j++;
                            }
                            if (iError != 0) break;
                        }
                        for (i = j - 1; i >= 0; i--)
                        {
                            this.gridViewBase.DeleteRow(deleted[i]);
                        }
                        //CurrencyManager cr = this.BindingContext[this.gridControlBase.DataSource] as CurrencyManager;
                        //Object o = cr.Current as Object;
                        //int iError = this.Business.Delete(o);
                        if (iError != 0)
                        {
                            MessageBox.Show("Delete error");
                        }
                        else
                        {
                            this.RefreshButton();
                        }
                    }
                }
            }
        }

        public UCListBase()
        {
            InitializeComponent();
            UCListBase.Current = this;
            LayoutFile = this.GetType().Name + ".xml";
    //this.OnResize+= 
        }


        private void gridViewBase_DoubleClick(object sender, EventArgs e)
        {
            if (this.AllowViewItem)
            {
                if (this.gridViewBase.FocusedRowHandle >= 0)
                    this.ViewItem();
            }
        }
        protected virtual void ViewItem()
        {
            if (this.formOpenType != null)
            {
                ConstructorInfo ci = this.formOpenType.GetConstructor(this.paramTypeConstructorFormOpenType);
                if (ci != null)
                {
                    Form f = (Form)ci.Invoke(this.paramConstructorFormOpenType);
                    if (f != null)
                    {
                        (f as FormEditBase).DataSource = this.DataSource;
                        (f as FormEditBase).CurrentItem = this.CurrentItem;
                        f.Disposed += new EventHandler(f_Disposed);
                        f.Owner = this.FindForm();
                        f.ShowInTaskbar = false;
                        if (this.showOpenFormDialog)
                        {
                            f.ShowDialog();
                        }
                        else
                        {
                            f.Show();
                        }
                    }
                }
                //this.gridControlBase.RefreshDataSource();
            }
        }
        protected virtual void EditItem()
        {
            if (this.formOpenType != null)
            {
                ConstructorInfo ci = this.formOpenType.GetConstructor(this.paramTypeConstructorFormOpenType);
                if (ci != null)
                {
                    Form f = (Form)ci.Invoke(this.paramConstructorFormOpenType);
                    if (f != null)
                    {
                        if (f is FormEditBase)
                        {
                            (f as FormEditBase).DataSource = this.DataSource;
                            (f as FormEditBase).CurrentItem = this.CurrentItem;
                            (f as FormEditBase).EditItem();
                        }
                        f.Disposed += new EventHandler(f_Disposed);
                        f.Owner = this.FindForm();
                        f.ShowInTaskbar = false;
                        if (this.showOpenFormDialog)
                        {
                            f.ShowDialog();
                        }
                        else
                        {
                            f.Show();
                        }
                    }
                }
                //this.gridControlBase.RefreshDataSource();
                //this.RefreshButton();
            }
        }

        private void gridViewBase_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            FocusedRowChanged();
        }
        protected virtual void FocusedRowChanged()
        {
            CurrencyManager cr = null;
            if (this.gridControlBase.DataSource != null && this.gridViewBase.FocusedRowHandle >= 0)
            {
                cr = this.BindingContext[this.gridControlBase.DataSource] as CurrencyManager;
                if (cr.Count > 0)
                {
                    this.currentItem = cr.Current;
                }
            }
        }
        
        public virtual void AddNewItem()
        {
            if (this.formOpenType != null)
            {
                ConstructorInfo ci = this.formOpenType.GetConstructor(this.paramTypeConstructorFormOpenType);
                if (ci != null)
                {
                    Form f = (Form)ci.Invoke(this.paramConstructorFormOpenType);
                    if (f != null)
                    {
                        if (f is FormEditBase)
                        {
                            (f as FormEditBase).DataSource = this.DataSource;
                            if ((f as FormEditBase).AllowAddNew)
                            {
                                (f as FormEditBase).AddNewItem();
                            }
                            //else
                            //{
                            //    //if ((f as FormEditBase).AllowEdit)
                            //    //{
                            //    //    (f as FormEditBase).EditItem();
                            //    //}
                            //}
                        }
                        f.Disposed += new EventHandler(f_Disposed);
                        f.Owner = this.FindForm();
                        f.ShowInTaskbar = false;
                        if (this.showOpenFormDialog)
                        {
                            f.ShowDialog();
                        }
                        else
                        {
                            f.Show();
                        }
                        
                    }
                }
                //this.gridControlBase.RefreshDataSource();
                //this.RefreshButton();
            }
        }

        void f_Disposed(object sender, EventArgs e)
        {
            if (UCListBase.Current != null && UCListBase.Current.formOpenType == sender.GetType())
            {
                this.CurrentItem = (sender as FormEditBase).CurrentItem;
                this.gridControlBase.RefreshDataSource();
                this.RefreshButton();
            }
        }

        private void UCListBase_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                if (System.IO.File.Exists(Application.StartupPath + "\\xml\\" + LayoutFile))
                    LayoutDefines.SetUserControlLayout(this, Application.StartupPath + "\\xml\\" + LayoutFile);
            }
        }

        private void mnuViewItem_Click(object sender, EventArgs e)
        {
            this.ViewItem();
        }

        private void mnuEditItem_Click(object sender, EventArgs e)
        {
            this.EditItem();
        }

        private void mnuNewItem_Click(object sender, EventArgs e)
        {
            this.AddNewItem();
        }

        private void mnuDeleteItem_Click(object sender, EventArgs e)
        {
            this.DeleteSelection();
        }

        private void pannelHeader_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            string tag = "";
            if (e.Button.Tag != null)
            {
                tag = e.Button.Tag.ToString().Trim();
            }
            if (tag == "1")
            {
                this.AddNewItem();
            }
            if (tag == "2")
            {
                this.EditItem();
            }
            if (tag == "3")
            {
                this.DeleteSelection();
            }
        }

    }
}
