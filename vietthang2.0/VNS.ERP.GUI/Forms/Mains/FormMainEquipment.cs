using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.GUI.Equipments;
using VNS.ERP.Data;

namespace VNS.ERP.GUI
{
    public partial class FormMainEquipment : VNS.ERP.GUI.FormMainBase
    {
        public FormMainEquipment()
        {
            InitializeComponent();
        }

        private void MenuVattu_Click(object sender, EventArgs e)
        {
            FormVattu f = new FormVattu();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuVattuOpening_Click(object sender, EventArgs e)
        {
            FormVattuOpening f = new FormVattuOpening();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuLinesx_Click(object sender, EventArgs e)
        {
            FormLinesx f = new FormLinesx();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

       
        private void testFormVattuOldTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVattuOldType f = new FormVattuOldType();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);

        }

        private void MenuEquipmentsx_Click(object sender, EventArgs e)
        {
            FormEquipmentsxs f = new FormEquipmentsxs();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);

        }

        private void MenuEquipment_Click(object sender, EventArgs e)
        {
            FormEquipments f = new FormEquipments();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);

        }

        private void MenuEquipmentGroup_Click(object sender, EventArgs e)
        {
            FormEquipmentGroups f = new FormEquipmentGroups();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);

        }

        private void MenuEquipmentLog_Click(object sender, EventArgs e)
        {
            FormEquipmentLogs f = new FormEquipmentLogs();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);

        }

        private void MenuVattuOldType_Click(object sender, EventArgs e)
        {
            FormVattuOldType f = new FormVattuOldType();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);

        }

        private void MenuVattuOldOpening_Click(object sender, EventArgs e)
        {
            FormVattuOldOpening f = new FormVattuOldOpening();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);

        }

        private void MenuExpense_Click(object sender, EventArgs e)
        {
            FormListEquipmentExpense f = new FormListEquipmentExpense();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuVattuTransactionNHAP_Click(object sender, EventArgs e)
        {
            FormListVattuTransactions f = new FormListVattuTransactions(enumStockTransaction.In);
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuVattuTransactionXUAT_Click(object sender, EventArgs e)
        {
            FormListVattuTransactions f = new FormListVattuTransactions(enumStockTransaction.Out);
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuVattuTransactionCHUYEN_Click(object sender, EventArgs e)
        {
            FormListVattuTransactions f = new FormListVattuTransactions(enumStockTransaction.Move);
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuRPInventories_Click(object sender, EventArgs e)
        {
            FormReportVattuInventories f = new FormReportVattuInventories(((ToolStripMenuItem)sender).Text, true);
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuRPInventoriesOld_Click(object sender, EventArgs e)
        {
            FormReportVattuInventories f = new FormReportVattuInventories(((ToolStripMenuItem)sender).Text, false);
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuRPVattuExpense_Click(object sender, EventArgs e)
        {
            FormReportEquipmentSxCodeAmount f = new FormReportEquipmentSxCodeAmount(((ToolStripMenuItem)sender).Text, true);
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuRPVattuExpenseOther_Click(object sender, EventArgs e)
        {
            FormReportEquipmentSxCodeAmount f = new FormReportEquipmentSxCodeAmount(((ToolStripMenuItem)sender).Text, false);
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuTBCalOutPrice_Click(object sender, EventArgs e)
        {
            FormCalVattuOutPrice f = new FormCalVattuOutPrice();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuRPCTXN_Click(object sender, EventArgs e)
        {
            FormReport_ChitietNXVattu f = new FormReport_ChitietNXVattu();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuTBImportVattu_Click(object sender, EventArgs e)
        {
            FormImportVattu f = new FormImportVattu();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }
    }
}

