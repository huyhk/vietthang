using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing;
using System.Collections;
namespace VNS.Windows
{
    public class mPictureBox:PictureBox
    {
        private System.Drawing.Drawing2D.GraphicsPath _pathData;
        private int _activeIndex = -1;
        private ArrayList _pathsArray;
        private ArrayList _ToolTipsArray;
        private ArrayList _IconsArray;
        
        private Graphics _graphics;
        private ToolTip toolTipControl;

        private bool showToolTip = true;
        [System.ComponentModel.Browsable(true)]
        public bool ShowToolTip
        {
            get { return showToolTip; }
            set { showToolTip = value; }
        }
	
        public mPictureBox()
        {            

            // TODO: Add any initialization after the InitForm call
            this._pathsArray = new ArrayList();
            this._pathData = new System.Drawing.Drawing2D.GraphicsPath();
            this._pathData.FillMode = System.Drawing.Drawing2D.FillMode.Winding;
            this._ToolTipsArray = new ArrayList();
            this._IconsArray = new ArrayList();

            this._graphics = Graphics.FromHwnd(this.Handle);
            hover.SizeMode = PictureBoxSizeMode.StretchImage;
            hover.Visible = true;
            this.toolTipControl = new ToolTip();

        }

        private ImageList imagelist;

        public ImageList ImageList
        {
            get { return imagelist; }
            set { imagelist = value; }
        }
	

        private ArrayList rectangles;

        public ArrayList Rectangles
        {
            get { return rectangles; }
            set { rectangles = value; }
        }
	
        private PictureBox hover = new PictureBox();

        float _hscale = 0.0F;
        float _vscale = 0.0F;
        int _oWidth = 0; int _oHeight = 0;
        protected override void OnResize(EventArgs e)
        {            
            base.OnResize(e);
            if (this.Width > 0 && this.Height > 0)
            {
                _hscale = (float)this.Width / _oWidth;
                _oWidth = this.Width;
                _vscale = (float)this.Height / _oHeight;
                _oHeight = this.Height;
                resizePathData(_vscale, _hscale);
            }
        }

        protected override void OnClick(EventArgs e)
        {
            if (this._activeIndex > -1)
                this.OnIconClicked(this._activeIndex, this._pathsArray[this._activeIndex].ToString());
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            
            base.OnMouseMove(e);
            RectangleF rf;
            int newIndex = this.getActiveIndexAtPoint(new Point(e.X, e.Y), out rf);
            
            //if (newIndex >-1)
            //{
            //    this.Cursor = Cursors.Hand;
            //    hover.Top = (int)rf.Top;
            //    hover.Left = (int)rf.Left;
            //    hover.Width = (int)rf.Width;
            //    hover.Height = (int)rf.Height;
            //    hover.Image = imagelist.Images[newIndex];
            //    if (this.toolTipControl != null && showToolTip && newIndex != this._activeIndex)
            //    {
            //        this.toolTipControl.SetToolTip(this,this._ToolTipsArray[newIndex].ToString());
            //    }
            //}
            //else
            //{
            //    this.Cursor = Cursors.Default;                
            //}
            if (this._activeIndex == newIndex && newIndex !=-1 )
                this.OnIconMouseOver(newIndex,this._pathsArray[newIndex].ToString());
            else if (this._activeIndex != -1)
                this.OnIconMouseOut(this._activeIndex,this._pathsArray[this._activeIndex].ToString());

            this._activeIndex = newIndex;
            

        }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            _oHeight = this.Height;
            _oWidth = this.Width;
        }

        #region AddRectangle overloads
        public int AddRectangle(string key, int x1, int y1, int x2, int y2)
        {
            return this.AddRectangle(key, new Rectangle(x1, y1, (x2 - x1), (y2 - y1)),-1);
        }
        
        public int AddRectangle(string key, int x1, int y1, int x2, int y2, string toolTip)
        {
            return this.AddRectangle(key, new Rectangle(x1, y1, (x2 - x1), (y2 - y1)), -1,toolTip);
        }

        public int AddRectangle(string key, int x1, int y1, int x2, int y2, int imageIndex)
        {
            return this.AddRectangle(key, new Rectangle(x1, y1, (x2 - x1), (y2 - y1)),imageIndex);
        }

        public int AddRectangle(string key, Rectangle rectangle, int imageIndex)
        {
            return this.AddRectangle(key, rectangle, imageIndex, "");
        }

        public int AddRectangle(string key, Rectangle rectangle, int imageIndex,string toolTip)
        {
            if (this._pathsArray.Count > 0)
                this._pathData.SetMarkers();
            this._pathData.AddRectangle(rectangle);
            this._pathsArray.Add(key);
            this._ToolTipsArray.Add(toolTip);
            this._IconsArray.Add(imageIndex);
            return 1;
        }
        #endregion

        public void ClearRectangles()
        {
            this._pathData.ClearMarkers();
            this._pathsArray.Clear();
            this._ToolTipsArray.Clear();
            this._IconsArray.Clear();
        }

        private int getActiveIndexAtPoint(Point point,out RectangleF r )
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Drawing2D.GraphicsPathIterator iterator = new System.Drawing.Drawing2D.GraphicsPathIterator(_pathData);
            iterator.Rewind();
            for (int current = 0; current < iterator.SubpathCount; current++)
            {
                iterator.NextMarker(path);
                if (path.IsVisible(point, this._graphics))
                {
                    r = new RectangleF(path.PathPoints[0], new SizeF(path.PathPoints[2].X - path.PathPoints[0].X, path.PathPoints[2].Y - path.PathPoints[0].Y));
                    return current;
                }
                
            }
            r = new RectangleF();
            return -1;
        }

        private void resizePathData(float _vscale, float _hscale)
        {
            if (_vscale != 0 && _hscale != 0)
            {
                Matrix m = new Matrix();
                m.Scale(_hscale, _vscale);
                _pathData.Transform(m);
            }
        }
        public event IconMouseHandler IconMouseOver;
        public event IconMouseHandler IconMouseOut;
        public virtual void OnIconMouseOver(int iconIndex, string key)
        {
            if (this.IconMouseOver != null)
                this.IconMouseOver(iconIndex,key);
        }
        public virtual void OnIconMouseOut(int iconIndex, string key)
        {
            if (this.IconMouseOut != null)
                this.IconMouseOut(iconIndex,key);
        }
                
        public event IconClickedHandler IconClicked;
        public virtual void OnIconClicked(int iconIndex, string key)
        {
            if (this.IconClicked != null)
                this.IconClicked(iconIndex,key);
        }
        
    }
    public delegate void IconClickedHandler(int iconIndex,string key);
    public delegate void IconMouseHandler(int iconIndex, string key);
}
