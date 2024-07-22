using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace VNS.Windows.Controls
{
    public partial class DateEditor : DevExpress.XtraEditors.DateEdit
    {
        public DateEditor()
        {
            InitializeComponent();
            
        }
        
        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{RIGHT}");
                
                return;
            }
            else
                base.OnKeyUp(e);
        }

    }
}
