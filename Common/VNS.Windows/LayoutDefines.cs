using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;
using System.Drawing;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.Utils;
using VNS.Windows.Forms;
using VNS.Common;
namespace VNS.Windows
{
    public static class LayoutDefines
    {
        #region constants
        public const string XML_ELE_ROOT = "root";
        public const string XML_ELE_LAYOUT = "layout";
        public const string XML_ATT_ID = "id";
        public const string XML_ATT_TEXT = "text";
        public const string XML_ATT_TOOLTIPTEXT = "tooltiptext";
        public const string XML_ATT_CAPTION = "caption";
        #endregion

        /// <summary>
        /// Change form layout based on defined in xml file
        /// </summary>
        /// <param name="frm">the form object to be changed the layout</param>
        /// <param name="xmlFile">the xml file name contains the layout defined for the form</param>
        public static void SetFormLayout(FormBase frm, string xmlFile)
        {
            try
            {                
                string parentFolder = System.IO.Path.GetDirectoryName(xmlFile);
                XmlDocument xml = new XmlDocument();
                if (File.Exists(xmlFile))
                {
                    xml.Load(xmlFile);
                    frm.Text = XMLFunctions.GetTextFromXML(xml, frm.GetType().Name, XML_ATT_TEXT, frm.Text);
                    foreach (Control oControl in frm.Controls)
                        SetLayout(oControl, xml);
                    if (frm.IsMdiContainer)
                        foreach (FormBase f in frm.MdiChildren)
                            SetFormLayout(f, parentFolder+"\\"+f.LayoutFile );
                    
                }
            }
            catch(Exception e)
            {
                Write2Log.WriteLogs("LayoutDefines", "SetFormLayout(Form frm, string xmlFile)", e.Message);
            }
        }
        /// <summary>
        /// generate the xml layout for the form
        /// </summary>
        /// <param name="frm">the form object to be read</param>
        /// <param name="xmlFile">the file name to be generated</param>
        public static void GenXMLFormLayout(Form frm, string xmlFile)
        {
            XmlTextWriter xmlGen = new XmlTextWriter(xmlFile, Encoding.UTF8);
            xmlGen.WriteStartDocument();
            xmlGen.WriteDocType("root", null, null, "<!ELEMENT root ANY><!ELEMENT layout ANY><!ATTLIST layout id ID #REQUIRED><!ATTLIST layout text CDATA #REQUIRED><!ATTLIST layout tooltiptext CDATA #IMPLIED>");
            xmlGen.WriteStartElement(XML_ELE_ROOT);
            xmlGen.WriteString("\n");
            xmlGen.WriteStartElement(XML_ELE_LAYOUT);
            xmlGen.WriteAttributeString(XML_ATT_ID, frm.GetType().Name);
            xmlGen.WriteAttributeString(XML_ATT_TEXT, frm.Text);
            xmlGen.WriteEndElement();
            foreach (Control oControl in frm.Controls)
                GenXMLLayout(oControl, xmlGen);
            xmlGen.WriteString("\n");
            xmlGen.WriteEndElement();
            xmlGen.Flush();
            xmlGen.Close();
        }
        private static void SetLayout(Control oControl, XmlDocument xml)
        {
            #region Controls which does not control
            if (oControl is DevExpress.XtraEditors.DateEdit)
            {

                DevExpress.XtraEditors.DateEdit o = (DevExpress.XtraEditors.DateEdit)oControl;
                if (o.Properties.DisplayFormat.FormatType == DevExpress.Utils.FormatType.DateTime)
                {
                    if (o.Properties.DisplayFormat.FormatString == "d")
                    {
                        o.Properties.DisplayFormat.FormatString = AppConfigs.CONFIG_DATEFORMAT;
                        o.Properties.EditFormat.FormatString = AppConfigs.CONFIG_DATEFORMAT;
                        o.Properties.EditMask = AppConfigs.CONFIG_DATEFORMAT;
                        o.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
                    }
                }
                o.Properties.ShowClear = false;
                return;
            }
            
            if ((oControl is TextBox) || (oControl is DateTimePicker))
                return;
            if (oControl is DevExpress.XtraEditors.LookUpEdit)
            {
                DevExpress.XtraEditors.LookUpEdit o = (DevExpress.XtraEditors.LookUpEdit)oControl;
                foreach (DevExpress.XtraEditors.Controls.LookUpColumnInfo col in o.Properties.Columns)
                {
                    string sText = XMLFunctions.GetTextFromXML(xml, o.Name+"-"+ col.FieldName, XML_ATT_TEXT, string.Empty);
                    if (sText != string.Empty)
                        col.Caption = sText;
                }
                
                return;
            }
            if (oControl is DevExpress.XtraEditors.TextEdit)
            {
                DevExpress.XtraEditors.TextEdit o = (DevExpress.XtraEditors.TextEdit)oControl;
                if (o.Properties.DisplayFormat.FormatType == DevExpress.Utils.FormatType.DateTime)
                {
                    if (o.Properties.DisplayFormat.FormatString == "d")
                    {
                        o.Properties.DisplayFormat.FormatString = AppConfigs.CONFIG_DATEFORMAT;
                        o.Properties.EditFormat.FormatString = AppConfigs.CONFIG_DATEFORMAT;
                        //o.Properties.EditMask = AppConfigs.CONFIG_DATEFORMAT;
                        if (oControl is DevExpress.XtraEditors.DateEdit)
                            (oControl as DevExpress.XtraEditors.DateEdit).Properties.EditMask = AppConfigs.CONFIG_DATEFORMAT;
                    }
                }
                return;
            }


            #endregion

            #region Common Controls

            if (oControl is MenuStrip)
            {
                MenuStrip oMenuStrip = (MenuStrip)oControl;
                foreach (ToolStripMenuItem oToolStripMenuItem in oMenuStrip.Items)
                {
                    
                    SetLayout(oToolStripMenuItem,xml);
                }
                return;
            }
            if (oControl is ToolStrip)
            {
                ToolStrip oToolStrip = (ToolStrip)oControl;
                SetLayout(oToolStrip,xml);
                return;
            }
            if (oControl is Label)
            {
                int iRight = 0;
                Label oLabel = (Label)oControl;
                if (oLabel.TextAlign == ContentAlignment.TopRight)
                    iRight = oLabel.Right;

                oLabel.Text = XMLFunctions.GetTextFromXML(xml, oLabel.Name, XML_ATT_TEXT, oLabel.Text);
                if (oLabel.TextAlign == ContentAlignment.TopRight)
                { oLabel.Left = iRight - (oLabel.Right - oLabel.Left); }
                return;
            }

            if (oControl.Name != "")
            {
                string sText = XMLFunctions.GetTextFromXML(xml, oControl.Name, XML_ATT_TEXT, string.Empty);
                if (sText!=string.Empty)
                    oControl.Text = sText;
            }

            if (oControl.HasChildren)
                foreach (Control ct in oControl.Controls)
                    SetLayout(ct, xml);
            

            #endregion

            #region DevExpress Controls

            //
            if (oControl is DevExpress.XtraGrid.GridControl)
            {
                foreach (DevExpress.XtraGrid.Views.Base.BaseView view in (oControl as DevExpress.XtraGrid.GridControl).ViewCollection)
                {
                    //DevExpress.XtraGrid.Views.Base.BaseView view = (oControl as DevExpress.XtraGrid.GridControl).DefaultView;
                    if (view is DevExpress.XtraGrid.Views.Base.ColumnView)
                    {
                        foreach (DevExpress.XtraGrid.Columns.GridColumn col in (view as DevExpress.XtraGrid.Views.Base.ColumnView).Columns)
                        {
                            string sText = XMLFunctions.GetTextFromXML(xml, col.Name, XML_ATT_TEXT, string.Empty);
                            if (sText != string.Empty)
                                col.Caption = sText;
                            if (col.DisplayFormat.FormatType == DevExpress.Utils.FormatType.DateTime)
                            {
                                if (col.DisplayFormat.FormatString == "d")
                                {
                                    col.DisplayFormat.FormatString = AppConfigs.CONFIG_DATEFORMAT;
                                    col.GroupFormat.FormatString = AppConfigs.CONFIG_DATEFORMAT;
                                    //o.Properties.EditFormat.FormatString = AppConfigs.CONFIG_DATEFORMAT;
                                    ////o.Properties.EditMask = AppConfigs.CONFIG_DATEFORMAT;
                                    //if (oControl is DevExpress.XtraEditors.DateEdit)
                                    //    (oControl as DevExpress.XtraEditors.DateEdit).Properties.EditMask = AppConfigs.CONFIG_DATEFORMAT;
                                }
                            }
                            if (col.ColumnEdit != null)
                            {
                                if (col.ColumnEdit is DevExpress.XtraEditors.Repository.RepositoryItemDateEdit)
                                {
                                    DevExpress.XtraEditors.Repository.RepositoryItemDateEdit o = (DevExpress.XtraEditors.Repository.RepositoryItemDateEdit)col.ColumnEdit;
                                    if (o.DisplayFormat.FormatType == DevExpress.Utils.FormatType.DateTime)
                                    {
                                        if (o.DisplayFormat.FormatString == "d")
                                        {
                                            o.DisplayFormat.FormatString = AppConfigs.CONFIG_DATEFORMAT;
                                            o.EditFormat.FormatString = AppConfigs.CONFIG_DATEFORMAT;
                                            o.EditMask = AppConfigs.CONFIG_DATEFORMAT;
                                            o.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
                                        }
                                    }
                                    o.ShowClear = false;
                                }
                                if (col.ColumnEdit is DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)
                                {
                                    DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit o = (DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)col.ColumnEdit;
                                    foreach (DevExpress.XtraEditors.Controls.LookUpColumnInfo col1 in o.Columns)
                                    {
                                        string sText1 = XMLFunctions.GetTextFromXML(xml, o.Name + "-" + col1.FieldName, XML_ATT_TEXT, string.Empty);
                                        if (sText1 != string.Empty)
                                            col1.Caption = sText1;
                                    }
                                }
                            }
                            if (col.RealColumnEdit != null)
                            {
                                if (col.RealColumnEdit is DevExpress.XtraEditors.Repository.RepositoryItemDateEdit)
                                {
                                    DevExpress.XtraEditors.Repository.RepositoryItemDateEdit o = (DevExpress.XtraEditors.Repository.RepositoryItemDateEdit)col.RealColumnEdit;
                                    if (o.DisplayFormat.FormatType == DevExpress.Utils.FormatType.DateTime)
                                    {
                                        if (o.DisplayFormat.FormatString == "d")
                                        {
                                            o.DisplayFormat.FormatString = AppConfigs.CONFIG_DATEFORMAT;
                                            o.EditFormat.FormatString = AppConfigs.CONFIG_DATEFORMAT;
                                            o.EditMask = AppConfigs.CONFIG_DATEFORMAT;
                                            o.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
                                        }
                                    }
                                    o.ShowClear = false;
                                }
                            }
                        }
                    }

                    if (view is DevExpress.XtraGrid.Views.Grid.GridView)
                    {
                        string groupText = (view as DevExpress.XtraGrid.Views.Grid.GridView).GroupPanelText;
                        (view as DevExpress.XtraGrid.Views.Grid.GridView).GroupPanelText = XMLFunctions.GetTextFromXML(xml, view.Name + "-GroupPanelText", XML_ATT_TEXT, groupText);
                    }
                }
            }

            #endregion
            
        }

        private static void GenXMLLayout(DevExpress.XtraBars.BarItem item,XmlTextWriter xmlGen)
        {
            xmlGen.WriteString("\n");
            xmlGen.WriteStartElement(XML_ELE_LAYOUT);
            xmlGen.WriteAttributeString(XML_ATT_ID, item.Name);
            xmlGen.WriteAttributeString(XML_ATT_CAPTION, item.Caption);
            xmlGen.WriteEndElement();
            if (item is DevExpress.XtraBars.BarCustomContainerItem)
                foreach (DevExpress.XtraBars.BarItem cItem in (item as DevExpress.XtraBars.BarCustomContainerItem).ItemLinks)
                {
                    GenXMLLayout(cItem, xmlGen);
                }
        
        }
        private static void GenXMLLayout(Control oControl, XmlTextWriter xmlGen)
        {
            if ((oControl is TextBox) || (oControl is DateTimePicker) )
                return;

            //if (oControl.GetType() == DevExpress.XtraBars.BarItem)
            //{
            //    DevExpress.XtraBars.BarItem item = (oControl as DevExpress.XtraBars.BarItem);                    
            
               
            //}


            if (oControl is MenuStrip)
            {
                MenuStrip oMenuStrip = (MenuStrip)oControl;
                foreach (ToolStripItem oToolStripMenuItem in oMenuStrip.Items)
                {
                    if (oToolStripMenuItem is ToolStripMenuItem)
                        GenXMLLayout(oToolStripMenuItem as ToolStripMenuItem, xmlGen);
                }
                return;
            }
            if (oControl is ToolStrip)
            {
                ToolStrip oToolStrip = (ToolStrip)oControl;
                GenXMLLayout(oToolStrip, xmlGen);
                return;
            }
                        
            #region DevExpress Controls
            if (oControl is DevExpress.XtraGrid.GridControl)
            {
                DevExpress.XtraGrid.Views.Base.BaseView view = (oControl as DevExpress.XtraGrid.GridControl).DefaultView;
                if (view is DevExpress.XtraGrid.Views.Base.ColumnView)
                {
                    foreach (DevExpress.XtraGrid.Columns.GridColumn col in (view as DevExpress.XtraGrid.Views.Base.ColumnView).Columns)
                    {
                        xmlGen.WriteString("\n");
                        xmlGen.WriteStartElement(XML_ELE_LAYOUT);
                        xmlGen.WriteAttributeString(XML_ATT_ID, col.Name);
                        xmlGen.WriteAttributeString(XML_ATT_TEXT, col.Caption);
                        xmlGen.WriteEndElement();
                    }
                }
                if (view is DevExpress.XtraGrid.Views.Grid.GridView)
                {
                    string groupText = (view as DevExpress.XtraGrid.Views.Grid.GridView).GroupPanelText;
                    xmlGen.WriteString("\n");
                    xmlGen.WriteStartElement(XML_ELE_LAYOUT);
                    xmlGen.WriteAttributeString(XML_ATT_ID, view.Name+"-GroupPanelText");
                    xmlGen.WriteAttributeString(XML_ATT_TEXT, groupText);
                    xmlGen.WriteEndElement();
                 
                }


            }
            
            #endregion
            if (oControl.Name != "")
            {
                xmlGen.WriteString("\n");
                xmlGen.WriteStartElement(XML_ELE_LAYOUT);
                xmlGen.WriteAttributeString(XML_ATT_ID, oControl.Name);
                xmlGen.WriteAttributeString(XML_ATT_TEXT, oControl.Text);
                xmlGen.WriteEndElement();
            }
            if (oControl.HasChildren)
                foreach (Control ct in oControl.Controls)
                    GenXMLLayout(ct, xmlGen);
            
        }
        private static void SetLayout(ToolStripMenuItem oToolStripMenuItem, XmlDocument xml)
        {
            oToolStripMenuItem.Text = XMLFunctions.GetTextFromXML(xml, oToolStripMenuItem.Name, XML_ATT_TEXT, oToolStripMenuItem.Text);
            oToolStripMenuItem.ToolTipText = XMLFunctions.GetTextFromXML(xml, oToolStripMenuItem.Name, XML_ATT_TOOLTIPTEXT, oToolStripMenuItem.ToolTipText);
            if (oToolStripMenuItem.DropDownItems.Count > 0)
                foreach (ToolStripItem o in oToolStripMenuItem.DropDownItems)
                {
                    if (o is ToolStripMenuItem)
                        SetLayout(o as ToolStripMenuItem, xml);
                }
        }
        private static void GenXMLLayout(ToolStripMenuItem oToolStripMenuItem, XmlTextWriter xmlGen)
        {
            xmlGen.WriteString("\n");
            xmlGen.WriteStartElement(XML_ELE_LAYOUT);
            xmlGen.WriteAttributeString(XML_ATT_ID, oToolStripMenuItem.Name);
            xmlGen.WriteAttributeString(XML_ATT_TEXT, oToolStripMenuItem.Text);
            xmlGen.WriteAttributeString(XML_ATT_TOOLTIPTEXT, oToolStripMenuItem.ToolTipText);
            xmlGen.WriteEndElement();
            
            if (oToolStripMenuItem.DropDownItems.Count > 0)
                foreach (ToolStripItem o in oToolStripMenuItem.DropDownItems)
                {
                    if (o is ToolStripMenuItem)
                        GenXMLLayout(o as ToolStripMenuItem, xmlGen);
                }
        }
        private static void SetLayout(ToolStrip oToolStrip, XmlDocument xml)
        {
            oToolStrip.Text = XMLFunctions.GetTextFromXML(xml, oToolStrip.Name, XML_ATT_TEXT, oToolStrip.Text);
            if (oToolStrip.Items.Count > 0)
                foreach (ToolStripItem o in oToolStrip.Items)
                {
                    SetLayout(o, xml);
                }
        }
        private static void SetLayout(ToolStripItem oToolStripItem, XmlDocument xml)
        {
            string sName = oToolStripItem.Name;
            if (sName == "")
                if (oToolStripItem.AccessibleName != null)
                    sName = oToolStripItem.AccessibleName.Replace(" ", "");
                else
                    return;
            oToolStripItem.Text = XMLFunctions.GetTextFromXML(xml, sName, XML_ATT_TEXT, oToolStripItem.Text);
            oToolStripItem.ToolTipText = XMLFunctions.GetTextFromXML(xml, sName, XML_ATT_TOOLTIPTEXT, oToolStripItem.ToolTipText);
            if (oToolStripItem is ToolStripDropDownButton)
            {
                ToolStripDropDownButton d = (ToolStripDropDownButton)oToolStripItem;
                foreach (ToolStripItem o in d.DropDownItems)
                    SetLayout(o, xml);
            }
        }
        private static void GenXMLLayout(ToolStrip oToolStrip, XmlTextWriter xmlGen)
        {
            xmlGen.WriteString("\n");
            xmlGen.WriteStartElement(XML_ELE_LAYOUT);
            xmlGen.WriteAttributeString(XML_ATT_ID, oToolStrip.Name);
            xmlGen.WriteAttributeString(XML_ATT_TEXT, oToolStrip.Text);
            xmlGen.WriteEndElement();
            if (oToolStrip.Items.Count > 0)
                foreach (ToolStripItem o in oToolStrip.Items)
                {
                    GenXMLLayout(o, xmlGen);
                }
        }
        private static void GenXMLLayout(ToolStripItem oToolStripItem, XmlTextWriter xmlGen)
        {
            xmlGen.WriteString("\n");
            xmlGen.WriteStartElement(XML_ELE_LAYOUT);
            string sName = oToolStripItem.Name;
            if (sName == "")
                if (oToolStripItem.AccessibleName != null)
                    sName = oToolStripItem.AccessibleName.Replace(" ", "");
                else
                    return;
            xmlGen.WriteAttributeString(XML_ATT_ID, sName);
            xmlGen.WriteAttributeString(XML_ATT_TEXT, oToolStripItem.Text);
            xmlGen.WriteAttributeString(XML_ATT_TOOLTIPTEXT, oToolStripItem.ToolTipText);
            xmlGen.WriteEndElement();
            if (oToolStripItem is ToolStripDropDownButton)
            {
                ToolStripDropDownButton d = (ToolStripDropDownButton)oToolStripItem;
                foreach (ToolStripItem o in d.DropDownItems)
                    GenXMLLayout(o, xmlGen);
            }
        }
        
        
    }
}
