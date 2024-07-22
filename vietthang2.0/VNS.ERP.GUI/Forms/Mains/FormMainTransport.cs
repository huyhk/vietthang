using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.GUI.Transports;

namespace VNS.ERP.GUI
{
    public partial class FormMainTransport : VNS.ERP.GUI.FormMainBase
    {
        public FormMainTransport()
        {
            InitializeComponent();
        }

        private void MenuBocxepItem_Click(object sender, EventArgs e)
        {
            FormBocxepType f = new FormBocxepType();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuBocxepContract_Click(object sender, EventArgs e)
        {
            FormListBocxepContracts f = new FormListBocxepContracts();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuBocxepResult_Click(object sender, EventArgs e)
        {
            FormListBocxepResults f = new FormListBocxepResults();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuVesselExchangeContract_Click(object sender, EventArgs e)
        {
            FormListVesselExchangeContract f = new FormListVesselExchangeContract();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuVesselInsuranceContract_Click(object sender, EventArgs e)
        {
            FormListVesselInsuranceContract f = new FormListVesselInsuranceContract();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuExchangeResult_Click(object sender, EventArgs e)
        {
            FormListExchangeResult f = new FormListExchangeResult();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuTransportRoutes_Click(object sender, EventArgs e)
        {
            FormTransportRoute f = new FormTransportRoute();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuTobocxep_Click(object sender, EventArgs e)
        {
            FormToBocxeps f = new FormToBocxeps();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuRPTongketBocxep_Click(object sender, EventArgs e)
        {
            FormReport_BocxepResults f = new FormReport_BocxepResults();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuTransportContract_Click(object sender, EventArgs e)
        {
            FormListTransportContract f = new FormListTransportContract();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuTransportCompenPrice_Click(object sender, EventArgs e)
        {
            FormListTransportCompensationPrice f = new FormListTransportCompensationPrice();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuTransportResult_Click(object sender, EventArgs e)
        {
            FormListTransportResult f = new FormListTransportResult();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuVessel_Click(object sender, EventArgs e)
        {
            FormVessel f = new FormVessel();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuRPTransportResult_Click(object sender, EventArgs e)
        {
            FormRPTransportResult f = new FormRPTransportResult();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuUpdateBocxepPrice_Click(object sender, EventArgs e)
        {
            FormToolUpdateBocxepPrice f = new FormToolUpdateBocxepPrice();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuRPBocxepGeneral_Click(object sender, EventArgs e)
        {
            FormReportBocXepResultGeneral f = new FormReportBocXepResultGeneral();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuTransportLossAllow_Click(object sender, EventArgs e)
        {
            FormListTransportLossAllow f = new FormListTransportLossAllow();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuTransportFee_Click(object sender, EventArgs e)
        {
            FormTransportFee f = new FormTransportFee();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuTCContract_Click(object sender, EventArgs e)
        {
            FormListTCContract f = new FormListTCContract();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuRPTCResult_Click(object sender, EventArgs e)
        {
            FormRPTCResult f = new FormRPTCResult();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuListVesselTransaction_Click(object sender, EventArgs e)
        {
            FormListVesselTransactions f = new FormListVesselTransactions();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuTransportFeeType_Click(object sender, EventArgs e)
        {
            FormTransportFeeType f = new FormTransportFeeType();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuRPTransportResultCont_Click(object sender, EventArgs e)
        {
            FormRPTransportResultBatch f = new FormRPTransportResultBatch();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuRPVCTonghop_Click(object sender, EventArgs e)
        {
            FormRPTonghopVC f = new FormRPTonghopVC();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuRPChiphikhovan_Click(object sender, EventArgs e)
        {
            FormRPChiphikhovan f = new FormRPChiphikhovan();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }
    }
}

