using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using VNS.Utils;
using VNS.Data.DAL;

namespace VNS.Windows.Forms
{
    public partial class FormBase : DevExpress.XtraEditors.XtraForm
    {
        private XmlDocument messageDoc=new XmlDocument();

        public XmlDocument MessageDocument
        {
            get { return messageDoc; }
            set { messageDoc = value; }
        }
	
        private string m_MessagePrefix;
        [Browsable(true)]
        [Category("VNS - Properties")]
        public string MessagePrefix {
            get { return m_MessagePrefix; }
            set { m_MessagePrefix = value; }
        }
        private string m_LayoutFile;

        [Browsable(true)]
        [Category("VNS - Properties")]
        public string LayoutFile {
            get { return m_LayoutFile; }
            set { m_LayoutFile = value; }
        }
        
        public FormBase() {
            
            InitializeComponent();

            LayoutFile = this.GetType().Name + ".xml";
            MessagePrefix = this.GetType().Name + "-";
        }

        public string GetTextMessage(string id, string defaultValue) {
            if (messageDoc != null)
                return XMLFunctions.GetTextFromXML(messageDoc, id, LayoutDefines.XML_ATT_TEXT, defaultValue);
                //return XMLFunctions.GetTextFromXML(messageDoc, MessagePrefix + id, LayoutDefines.XML_ATT_TEXT, defaultValue);
            else
                return defaultValue;
        }

        private void frmBase_Load(object sender, EventArgs e) {
//#if (DEBUG)
//            LayoutDefines.GenXMLFormLayout(this, Generals.XmlFolder + "\\" + LayoutFile);
//#endif
//            if (System.IO.File.Exists(Generals.XmlFolder + "\\" + LayoutFile))
//                LayoutDefines.SetFormLayout(this,LayoutFile);
            try
            {
                if (!this.DesignMode)
                {
                    if (System.IO.File.Exists(Application.StartupPath + "\\xml\\" + LayoutFile))
                        LayoutDefines.SetFormLayout(this, Application.StartupPath + "\\xml\\" + LayoutFile);
                    //if (System.IO.File.Exists(Application.StartupPath + "\\xml\\Message.xml"))
                    //    messageDoc.Load(Application.StartupPath + "\\xml\\Message.xml");
                    if (System.IO.File.Exists(Application.StartupPath + "\\xml\\" + LayoutFile))
                        messageDoc.Load(Application.StartupPath + "\\xml\\" + LayoutFile);

                    this.Text = this.Text + " - " + DBHelper.DATABASENAME + " - " + DBHelper.SERVER;
                }
            }
            catch { }
        }

        public void SetVisible(bool b)
        {
            this.Visible = b;
            if (this.Owner != null)
            {
                if (this.Owner is FormBase)
                {
                    (this.Owner as FormBase).SetVisible(b);
                }
            }
        }
        public void ShowChildForm(Form f)
        {
            //this.AddOwnedForm(f);
            //f.ShowInTaskbar = true;
            //this.ShowInTaskbar = false;
            //f.MinimizeBox = false;
            f.Owner = this;
            f.Show();
            //f.ShowDialog(this);
            //this.ShowInTaskbar = true;
        }

       
        //private void FormBase_KeyUp(object sender, KeyEventArgs e)
        //{
            
        //}
    }
}