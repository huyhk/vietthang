using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace VNS.Windows.Forms
{
    public partial class FormProgressBar : FormBase
    {
        public FormProgressBar()
        {
            InitializeComponent();
            
        }
        /// <summary>
        /// Set Position +1
        /// </summary>
        public void IncreProgressBarValue()
        {
            this.progressBarControl1.Position++;
            this.Update();
        }

        /// <summary>
        /// Set Position + incre parameters
        /// </summary>
        public void IncreProgressBarValue(int incre)
        {
            this.progressBarControl1.Position += incre;
            this.Update();
        }
        /// <summary>
        /// Set Position by position parameters
        /// </summary>
        /// <param name="position"></param>
        public void SetProgressBarValue(int position)
        {
            this.progressBarControl1.Position = position;
            this.Update();
        }
        /// <summary>
        /// Set Maximum of ProgressBar is maximum parameters
        /// </summary>
        /// <param name="maximum"></param>
        public void SetProgressBarMaximum(int maximum)
        {
            this.progressBarControl1.Position = 0;
            this.progressBarControl1.Properties.Maximum = maximum;
        }
        /// <summary>
        /// Set Text Display when increment
        /// </summary>
        /// <param name="text"></param>
        public void SetProgressText(string text)
        {
            this.txtLoadText.Text = text;
        }
    }
}