using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using System.ComponentModel.Design;
using System.Xml;

using VNS.Localization;

namespace VNS.Windows
{
    [Designer(typeof(LocaleControllerDesigner))]
    public class LocaleController:Component
    {
        Locale locale = null;
        public LocaleController()
        { 
            
        }

        public void CreateLocaleFile(string xmlFile)
        { }

        public void Apply(Form frm)
        {
            foreach (Control ctl in frm.Controls)
                ChangeText(ctl);
            
            
        }
        
        public void ChangeText(Control ctl)
        {
            if (locale != null)
            {
                System.Reflection.PropertyInfo prop = ctl.GetType().GetProperty("Caption");
                if (prop != null)
                    prop = ctl.GetType().GetProperty("Text");
                if (prop != null)
                    prop.SetValue(ctl, locale.GetText(ctl.Name),null);

                prop = ctl.GetType().GetProperty("ToolTipText");
                if (prop != null)
                    prop.SetValue(ctl, locale.GetToolTipText(ctl.Name),null);
                
                if (ctl.HasChildren)
                {
                    foreach (Control c in ctl.Controls)
                        ChangeText(c);
                }
            }
        }
        private Control parent;

        public Control Parent
        {
            get { return parent; }
            set { parent = value; }
        }
        public void GenXML()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter="XML documents (*.xml)|*xml";
            dlg.FileName = this.parent.GetType().Name + ".xml";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                XmlTextWriter writer = new XmlTextWriter(dlg.FileName, Encoding.Unicode);
                writer.WriteStartDocument();
                writer.WriteStartElement("layouts");
                foreach (Control ctl in this.parent.Controls)
                    WriteXML(writer, ctl);
                
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
            }   
        }

        public void WriteXML(XmlTextWriter writer, Control ctl)
        {
            
            if (ctl.Name != "")
            {
                writer.WriteString("\n");
                writer.WriteStartElement("layout");
                writer.WriteAttributeString("id", ctl.Name);
                writer.WriteAttributeString("text", ctl.Text);
                writer.WriteEndElement();
            }
            if (ctl.HasChildren)
                foreach (Control c in ctl.Controls)
                    WriteXML(writer, c);
            if (ctl is DevExpress.XtraBars.BarDockControl)
            {
                foreach (Control c in (ctl as DevExpress.XtraBars.BarDockControl).Controls)
                {
                    if (c is DevExpress.XtraBars.Controls.DockedBarControl)
                    {
                        foreach (DevExpress.XtraBars.BarItemLink item in (c as DevExpress.XtraBars.Controls.DockedBarControl).Bar.ItemLinks)
                        {
                            //WriteXML(writer, item);
                        }
                    }
                }
                
            }

            if (ctl is MenuStrip)
            {
                foreach (ToolStripItem menu in (ctl as MenuStrip).Items)
                {
                    if (menu is ToolStripMenuItem)
                        WriteXML(writer, menu);
                }
            }
            else if (ctl is ToolStrip)
            {
                foreach (ToolStripItem item in (ctl as ToolStrip).Items)
                    WriteXML(writer, item);
            }
            else if (ctl is DevExpress.XtraGrid.GridControl)
            {
                DevExpress.XtraGrid.Views.Grid.GridView view = (ctl as DevExpress.XtraGrid.GridControl).DefaultView as DevExpress.XtraGrid.Views.Grid.GridView;
                foreach (DevExpress.XtraGrid.Columns.GridColumn col in view.Columns)
                    WriteXML(writer, col);
            }
        }
        public void WriteXML(XmlTextWriter writer, ToolStripItem ctl)
        {
            if (ctl.Name != "")
            {
                writer.WriteString("\n");
                writer.WriteStartElement("layout");
                writer.WriteAttributeString("id", ctl.Name);
                writer.WriteAttributeString("text", ctl.Text);
                writer.WriteEndElement();
            }
            if (ctl is ToolStripMenuItem)
                foreach (ToolStripItem o in (ctl as ToolStripMenuItem).DropDownItems)
                    WriteXML(writer, o);
        }

        public void WriteXML(XmlTextWriter writer, DevExpress.XtraGrid.Columns.GridColumn ctl)
        {
            if (ctl.Name != "")
            {                
                writer.WriteString("\n");
                writer.WriteStartElement("layout");
                writer.WriteAttributeString("id", ctl.Name);
                writer.WriteAttributeString("text", ctl.Caption);
                writer.WriteEndElement();
            }
        }
    }
    internal class LocaleControllerDesigner : ComponentDesigner
    {
        public override void InitializeNewComponent(System.Collections.IDictionary defaultValues)
        {
           
            LocaleController rp = (LocaleController)this.Component;
            rp.Parent = (Control)Component.Site.Container.Components[0];            
        }

        private DesignerActionListCollection actionLists;

        // Use pull model to populate smart tag menu.
        public override DesignerActionListCollection ActionLists
        {
            get
            {
                if (null == actionLists)
                {
                    actionLists = new DesignerActionListCollection();
                    actionLists.Add(
                        new LocaleDesignerActionList(this.Component));
                }
                return actionLists;
            }
        }

    }
    internal class LocaleDesignerActionList : DesignerActionList
    {
        public LocaleDesignerActionList(IComponent component)
            : base(component)
        { }
        public override DesignerActionItemCollection GetSortedActionItems()
        {
            DesignerActionItemCollection items = new DesignerActionItemCollection();
            items.Add(new DesignerActionMethodItem(this,"GenXML","Generate XML file"));
            return items;
        }
        public void GenXML()
        {
            (this.Component as LocaleController).GenXML();
        }
    }
}
