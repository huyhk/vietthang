using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace VNS.Windows.Controls
{
    public partial class UCNotify : UserControl
    {
        public UCNotify()
        {
            InitializeComponent();
        }
        public int RowCount
        {
            get { return this.tblLayoutPanel.RowCount; }
            set { this.tblLayoutPanel.RowCount = value; }
        }
        public int ColumnCount
        {
            get { return this.tblLayoutPanel.ColumnCount; }
            set { this.tblLayoutPanel.ColumnCount = value; }
        }
        public void AddControl(Control o, int col, int row)
        {
            this.tblLayoutPanel.Controls.Add(o, col, row);
            o.Dock = DockStyle.Fill;
            o.Visible = true;
            o.BringToFront();
        }
    }
}
