using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using VNS.Windows;
using VNS.Common;
namespace VNS.Windows.Controls
{
    /// <summary>
    /// Summary description for Datanavigator.
    /// </summary>
    //[ToolboxBitmap(typeof(BaseEdit), "Bitmaps256.SimpleButton.bmp")]
    //[ToolboxItem(true)]
    public class DataNavigator : DevExpress.XtraEditors.XtraUserControl
    {
        private TableLayoutPanel tableLayoutPanel1;
        protected SimpleButton btnLast;
        protected TextEdit txtPosition;
        protected SimpleButton btnNext;
        protected SimpleButton btnFirst;
        protected SimpleButton btnPrev;
        private ImageList imageList;
        private IContainer components;

        public DataNavigator()
        {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();

            // TODO: Add any initialization after the InitForm call
            buttons = new SimpleButton[6];
            buttons[0] = this.btnFirst;
            buttons[1] = this.btnPrev;
            buttons[2] = this.btnNext;
            buttons[3] = this.btnLast;
            
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataNavigator));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLast = new DevExpress.XtraEditors.SimpleButton();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.txtPosition = new DevExpress.XtraEditors.TextEdit();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnFirst = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrev = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosition.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnLast, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPosition, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNext, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnFirst, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPrev, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(176, 28);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnLast
            // 
            this.btnLast.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLast.Appearance.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnLast.Appearance.Options.UseFont = true;
            this.btnLast.Appearance.Options.UseTextOptions = true;
            this.btnLast.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.btnLast.ImageList = this.imageList;
            this.btnLast.Location = new System.Drawing.Point(147, 1);
            this.btnLast.Margin = new System.Windows.Forms.Padding(1);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(28, 26);
            this.btnLast.TabIndex = 4;
            this.btnLast.Text = ":";
            this.btnLast.ToolTip = "Nhảy đến mẫu tin cuối";
            this.btnLast.Click += new System.EventHandler(this.btnPosition_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "play_first.png");
            this.imageList.Images.SetKeyName(1, "play_prev.png");
            this.imageList.Images.SetKeyName(2, "play__next.png");
            this.imageList.Images.SetKeyName(3, "play_last.png");
            this.imageList.Images.SetKeyName(4, "add.png");
            this.imageList.Images.SetKeyName(5, "delete.gif");
            // 
            // txtPosition
            // 
            this.txtPosition.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPosition.EditValue = 0;
            this.txtPosition.EnterMoveNextControl = true;
            this.txtPosition.Location = new System.Drawing.Point(63, 4);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPosition.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtPosition.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txtPosition.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtPosition.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtPosition.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtPosition.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.txtPosition.Properties.Mask.EditMask = "\\d+";
            this.txtPosition.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtPosition.Size = new System.Drawing.Size(50, 20);
            this.txtPosition.TabIndex = 2;
            this.txtPosition.Leave += new System.EventHandler(this.txtPosition_Leave);
            this.txtPosition.EditValueChanged += new System.EventHandler(this.txtPosition_EditValueChanged);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNext.Appearance.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnNext.Appearance.Options.UseFont = true;
            this.btnNext.Appearance.Options.UseTextOptions = true;
            this.btnNext.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.btnNext.ImageList = this.imageList;
            this.btnNext.Location = new System.Drawing.Point(117, 1);
            this.btnNext.Margin = new System.Windows.Forms.Padding(1);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(28, 26);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "4";
            this.btnNext.ToolTip = "Tiếp theo";
            this.btnNext.Click += new System.EventHandler(this.btnPosition_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnFirst.Appearance.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnFirst.Appearance.Options.UseFont = true;
            this.btnFirst.Appearance.Options.UseTextOptions = true;
            this.btnFirst.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.btnFirst.ImageList = this.imageList;
            this.btnFirst.Location = new System.Drawing.Point(1, 1);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(1);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(28, 26);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "9";
            this.btnFirst.ToolTip = "Nhảy đến mẫu tin đầu";
            this.btnFirst.Click += new System.EventHandler(this.btnPosition_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPrev.Appearance.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnPrev.Appearance.Options.UseFont = true;
            this.btnPrev.Appearance.Options.UseTextOptions = true;
            this.btnPrev.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.btnPrev.ImageList = this.imageList;
            this.btnPrev.Location = new System.Drawing.Point(31, 1);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(1);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(28, 26);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "3";
            this.btnPrev.ToolTip = "Trước";
            this.btnPrev.Click += new System.EventHandler(this.btnPosition_Click);
            // 
            // DataNavigator
            // 
            this.AutoSize = true;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DataNavigator";
            this.Size = new System.Drawing.Size(245, 33);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPosition.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        
        public int CurrentPosition
        {
            get { return position; }
            set { position = value; refreshNavigatorButtons();
                /* setIndexTextPosition(position); txtPosition.Text = position.ToString(); refreshNavigatorButtons();*/ 
            }
        }
	
        int position = 0;
        SimpleButton[] buttons;

        private object dataSource;
        /// <summary>
        /// Gets or sets datasource for control.
        /// </summary>
        public object DataSource
        {
            get { return dataSource; }
            set
            {
                if (value == null) return;

                dataSource = value;
                if (dataSource == null || (dataSource as IList).Count == 0)
                {
                    txtPosition.Text = "0";
                    refreshNavigatorButtons();
                }
                else
                    txtPosition.Text = "1";
            }
        }

        /// <summary>
        /// Gets the current selected item.
        /// </summary>
        public object SelectedItem
        {
            get
            {
                
                if (dataSource is IList && dataSource != null)
                    if ((dataSource as IList).Count > 0 && position >= 0 && position < (dataSource as IList).Count)
                        return (dataSource as IList)[position];

                return null;
            }
        }

        /// <summary>
        /// Gets the munber of elements containded.
        /// The value -1 will be returned if DataSource is null.
        /// </summary>
        public int Count
        {
            get
            {
                if (dataSource == null) return -1;

                if (dataSource is IList)
                    return (dataSource as IList).Count;

                return -1;
            }
        }
        
        [DefaultValue(true)]
        public bool ShowRecordText
        {
            get { return txtPosition.Visible; }
            set { txtPosition.Visible = value; }
        }

        public bool EnableButtonPosition
        {
            set
            {
                if (value)
                {
                    this.btnFirst.Enabled = true;
                    this.btnPrev.Enabled = true;
                    this.btnNext.Enabled = true;
                    this.btnLast.Enabled = true;
                }
                else
                {
                    this.btnFirst.Enabled = false;
                    this.btnPrev.Enabled = false;
                    this.btnNext.Enabled = false;
                    this.btnLast.Enabled = false;
                }
            }
        }

        public ImageList ImageList
        {
            get { return this.imageList; }
            set { this.imageList = value; }
        }
        public SimpleButton[] Buttons
        {
            get { return this.buttons; }
        }
        #region public methods

        //public object AddNew()
        //{
        //    if (dataSource == null) return null;

        //    if (dataSource is IBindingList)
        //    {
        //        object oAdded = (dataSource as IBindingList).AddNew();
        //        setIndexTextPosition((dataSource as IList).Count - 1);
        //        return oAdded;
        //    }
        //    if (dataSource is IList)
        //    {
        //        Type elementType = (dataSource as IList)[0].GetType();
        //        try
        //        {
        //            object oAdded = Activator.CreateInstance(elementType);
        //            if ((dataSource as IList).Add(oAdded) != -1)
        //            {
        //                setIndexTextPosition((dataSource as IList).Count - 1);
        //                return oAdded;
        //            }
        //            return null;
        //        }
        //        catch
        //        {
        //            return null;
        //        }
        //    }

        //    return null;
        //}

        public void RefreshButtons()
        {
            this.refreshNavigatorButtons();
        }
        #endregion
        private void setIndexTextPosition(int index)
        {
            txtPosition.Text = Convert.ToString(index+1);
        }
        private void refreshNavigatorButtons()
        {
            if (dataSource == null) return;
            
            if ((dataSource as IList).Count <= 0)
            {
                EnableButtonPosition = false;

                txtPosition.Enabled = false;
            }
            else
            {
                if (position < 0) position = 0;
                if (position > (dataSource as IList).Count - 1) position = (dataSource as IList).Count - 1;
                if (Convert.ToString(position+1) != txtPosition.EditValue.ToString())
                    setIndexTextPosition(position);
                EnableButtonPosition = true;

                txtPosition.Enabled = true;

                if (position >= (dataSource as IList).Count - 1)
                {
                    btnNext.Enabled = false;
                    btnLast.Enabled = false;
                }
                if (position <= 0)
                {
                    btnFirst.Enabled = false;
                    btnPrev.Enabled = false;
                }
            }
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            if ((SimpleButton)sender == btnFirst)
                position = 0;
            if ((SimpleButton)sender == btnNext)
                position++;
            if ((SimpleButton)sender == btnPrev)
                position--;
            if ((SimpleButton)sender == btnLast)
                position = (dataSource as IList).Count - 1;
            
            setIndexTextPosition(position);
            //refreshNavigatorButtons();
            //if (ButtonClick != null)
            //    ButtonClick(sender, new ButtonClickArgs(NavigatorButton.Position));
            if (this.PositionChanged != null)
                PositionChanged(sender, e);
        }
        private void txtPosition_EditValueChanged(object sender, EventArgs e)
        {
            
        }
        

        #region Event

        public event EventHandler PositionChanged;
        public event ButtonClick ButtonClick;

        #endregion

        private void txtPosition_Leave(object sender, EventArgs e)
        {
            if (dataSource == null || (dataSource as IList).Count == 0)
            {
                refreshNavigatorButtons();
                return;
            }

            // Unassign to an value
            if (txtPosition.EditValue.ToString() == string.Empty) return;

            // Out of range
            if (int.Parse(txtPosition.EditValue.ToString()) < 1)
            {
                setIndexTextPosition(0);
                return;
            }
            if (int.Parse(txtPosition.EditValue.ToString()) > (dataSource as IList).Count)
            {
                setIndexTextPosition((dataSource as IList).Count - 1);
                return;
            }

            position = int.Parse(txtPosition.EditValue.ToString()) - 1;
            refreshNavigatorButtons();
            if (PositionChanged != null)
                PositionChanged(this, new EventArgs());
        }
    }
}

