using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using VNS.ERP.Data;
using VNS.ERP.GUI.GDs;
using VNS.ERP.GUI.Stocks;
using VNS.ERP.GUI.Sales;
using VNS.ERP.GUI.Manufactures;
using VNS.ERP.GUI.Equipments;
using VNS.ERP.GUI.KCS;
using VNS.ERP.GUI.Transports;
using VNS.ERP.GUI.Forms.GDs;

namespace VNS.ERP.GUI
{
    public partial class FormMainGD : VNS.ERP.GUI.FormMainBase
    {
        public FormMainGD()
        {
            InitializeComponent();
        }

        private void menuGDThongkeNLSX_Click(object sender, EventArgs e)
        {
            FormReportGD_ThongkeNLSX f = new FormReportGD_ThongkeNLSX(false);
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuGDThongkeNLSXThuoc_Click(object sender, EventArgs e)
        {
            FormReportGD_ThongkeNLSX f = new FormReportGD_ThongkeNLSX(true);
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuReportInventory_Click(object sender, EventArgs e)
        {
            FormReportStockInventory f = new FormReportStockInventory((byte)enumModuleID.Stock);
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuReportInOutProduct_Click(object sender, EventArgs e)
        {
            FormReportInOutProduct f = new FormReportInOutProduct();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuReportInOutMaterial_Click(object sender, EventArgs e)
        {
            FormReportInOutMaterial f = new FormReportInOutMaterial();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuReportLoaiNX_Click(object sender, EventArgs e)
        {
            FormReportStockTransactionForTransactionType f = new FormReportStockTransactionForTransactionType();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuRPTinhhinhtontru2_Click(object sender, EventArgs e)
        {
            FormReport_Tinhhinhtontru2 f = new FormReport_Tinhhinhtontru2();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuReportDoichieuChuyenNB_Click(object sender, EventArgs e)
        {
            FormReportDoiChieuChuyenKhoNoiBo f = new FormReportDoiChieuChuyenKhoNoiBo();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuRPBangkexuathang_Click(object sender, EventArgs e)
        {
            FormReportBangkeXuathang f = new FormReportBangkeXuathang();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuRPBaocaotonkhocayhang_Click(object sender, EventArgs e)
        {
            FormReportBaocaoTonkhoTheoCayhang f = new FormReportBaocaoTonkhoTheoCayhang();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuReportSaleProduct_Click(object sender, EventArgs e)
        {
            FormRpSaleRequestsItemSale f = new FormRpSaleRequestsItemSale("");
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuReportSaleQuantity_Click(object sender, EventArgs e)
        {
            FormReportSaleProductQuantity f = new FormReportSaleProductQuantity("");
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuReportCustomerPayment_Click(object sender, EventArgs e)
        {
            FormRpCustomerPayments f = new FormRpCustomerPayments("");
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuReportDetailDebt_Click(object sender, EventArgs e)
        {
            FormRpCustomerDeptOpening f = new FormRpCustomerDeptOpening("");
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuReportSaleDept_Click(object sender, EventArgs e)
        {
            FormReportCustomerDept f = new FormReportCustomerDept("");
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuReportSaleSlTPThang_Click(object sender, EventArgs e)
        {
            FormRpSoluongThanhphamthang f = new FormRpSoluongThanhphamthang("");
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuReportSaleCTXuatTPThang_Click(object sender, EventArgs e)
        {
            FormRpCTXuatTPThang f = new FormRpCTXuatTPThang("");
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuReportTHCNKHThang_Click(object sender, EventArgs e)
        {
            FormRpTHCongnoKH f = new FormRpTHCongnoKH(FormRpTHCongnoKH.enumLoaiBC.THANG, "");
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuReportTHCNKHNam_Click(object sender, EventArgs e)
        {
            FormRpTHCongnoKH f = new FormRpTHCongnoKH(FormRpTHCongnoKH.enumLoaiBC.NAM, "");
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuRPAccountVendorDebt_Click(object sender, EventArgs e)
        {
            VNS.ERP.GUI.Accounting.FormReportAccountTransactionSubject f = new VNS.ERP.GUI.Accounting.FormReportAccountTransactionSubject("331");
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuRPPurchaseTheodoiHopdong_Click(object sender, EventArgs e)
        {
            Form_ReportTheodoihopdong f = new Form_ReportTheodoihopdong();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuRPPurchaseBCMuahang_Click(object sender, EventArgs e)
        {
            Form_ReportBaocaomuahang f = new Form_ReportBaocaomuahang();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuRPPurchaseChitietmuahang_Click(object sender, EventArgs e)
        {
            Form_ReportChitietmuahang f = new Form_ReportChitietmuahang();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuRPPurchaseTonghopMHNam_Click(object sender, EventArgs e)
        {
            Form_ReportTonghopMuahangNam f = new Form_ReportTonghopMuahangNam();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuRPPurchasePhantichmuahang_Click(object sender, EventArgs e)
        {
            Form_ReportPhantichmuahang f = new Form_ReportPhantichmuahang();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuReportManufactureBCSX_Click(object sender, EventArgs e)
        {
            FormManufactureReportByTime_Month f = new FormManufactureReportByTime_Month(MenuReportManufactureBCSX.Text, FormManufactureReportByTime_Month.enumReportType.ChitietSX);
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuReportManufactureInventory_Click(object sender, EventArgs e)
        {
            FormReportInventory f = new FormReportInventory((byte)enumModuleID.Manufacture);
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuReportManufactureInventoryShift_Click(object sender, EventArgs e)
        {
            FormRpManufacture_ShiftDetail f = new FormRpManufacture_ShiftDetail();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuRPTonghopthangNM_Click(object sender, EventArgs e)
        {
            FormRPTHThangNM f = new FormRPTHThangNM();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuReportManufactureTHNam_Click(object sender, EventArgs e)
        {
            FormRpManufactureTHNam f = new FormRpManufactureTHNam();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuReportManufactureForEmployee_Click(object sender, EventArgs e)
        {
            FormRpManufactureForEmployees f = new FormRpManufactureForEmployees();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuReportManufactureForLine_Click(object sender, EventArgs e)
        {
            FormRpManufactureForLine f = new FormRpManufactureForLine();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuMixPremixInventory_Click(object sender, EventArgs e)
        {
            FormReportInventory f = new FormReportInventory((byte)enumModuleID.Premix);
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuMixPremixInventoryShift_Click(object sender, EventArgs e)
        {
            FormRpManufacture_ShiftDetail f = new FormRpManufacture_ShiftDetail(FormRpManufacture_ShiftDetail.enumDepartmentReport.Premix);
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuRPPremixDetail_Click(object sender, EventArgs e)
        {
            FormPremixsReportByTime_Month f = new FormPremixsReportByTime_Month();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuGrindInventory_Click(object sender, EventArgs e)
        {
            FormReportInventory f = new FormReportInventory((byte)enumModuleID.Grind);
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuGrindInventoryShift_Click(object sender, EventArgs e)
        {
            FormRpManufacture_ShiftDetail f = new FormRpManufacture_ShiftDetail(FormRpManufacture_ShiftDetail.enumDepartmentReport.Grind);
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuManuRPTonkhophe_Click(object sender, EventArgs e)
        {
            FormRPTonkhophe f = new FormRPTonkhophe();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuManuRPChitiettaiche_Click(object sender, EventArgs e)
        {
            FormManufactureReportByTime_Month f = new FormManufactureReportByTime_Month(menuManuRPChitiettaiche.Text, FormManufactureReportByTime_Month.enumReportType.ChitietTaiche);
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuManuRPChitietphe_Click(object sender, EventArgs e)
        {
            FormManufactureReportByTime_Month f = new FormManufactureReportByTime_Month(menuManuRPChitietphe.Text, FormManufactureReportByTime_Month.enumReportType.ChitietPhe);
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuManuTonkhoBaobi_Click(object sender, EventArgs e)
        {
            FormReport_XuatnhapkhoSanxuat f = new FormReport_XuatnhapkhoSanxuat(false);
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuManuTonkhoPremix_Click(object sender, EventArgs e)
        {
            FormReport_XuatnhapkhoSanxuat f = new FormReport_XuatnhapkhoSanxuat(true);
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

        private void menuRPCTXN_Click(object sender, EventArgs e)
        {
            FormReport_ChitietNXVattu f = new FormReport_ChitietNXVattu();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuRPQLCLMaterialTestRequestNotReturn_Click(object sender, EventArgs e)
        {
            FormReportMaterialTestRequestNotReturn f = new FormReportMaterialTestRequestNotReturn();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuRPQLCLProductTestRequestNotReturn_Click(object sender, EventArgs e)
        {
            FormReport_ProductTestRequest_Outside_Not_Return f = new FormReport_ProductTestRequest_Outside_Not_Return();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuRPQLCLProductTestRequestLocalNotReturn_Click(object sender, EventArgs e)
        {
            Form_Report_ProductTestRequest_Local_Not_Return f = new Form_Report_ProductTestRequest_Local_Not_Return();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuRPQLCLProductTestResult_Click(object sender, EventArgs e)
        {
            Form_Report_ProductTest_OutSide_Result_For_QLCL f = new Form_Report_ProductTest_OutSide_Result_For_QLCL();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuRPQLCLProductTestFrequency_Click(object sender, EventArgs e)
        {
            FormReport_TestProductFrequency f = new FormReport_TestProductFrequency();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuRPQLCLMaterialTestFrequency_Click(object sender, EventArgs e)
        {
            FormReport_TestMaterialFrequency f = new FormReport_TestMaterialFrequency();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuRPQLCLMaterialTestFrequencyByLo_Click(object sender, EventArgs e)
        {
            FormReport_TestMaterialFrequency_ByLo f = new FormReport_TestMaterialFrequency_ByLo();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuRPProductResultLocal_Click(object sender, EventArgs e)
        {
            FormReportProductResultLocal f = new FormReportProductResultLocal(((ToolStripMenuItem)sender).Text, false);
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuRPMaterialResultLocal_Click(object sender, EventArgs e)
        {
            FormReportProductResultLocal f = new FormReportProductResultLocal(((ToolStripMenuItem)sender).Text, true);
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuKCSRPTestRequest_Click(object sender, EventArgs e)
        {
            FormReport_TestRequest f = new FormReport_TestRequest();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuKCSTHKQKiemTP_Click(object sender, EventArgs e)
        {
            FormReport_BCTHQLCL f = new FormReport_BCTHQLCL();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuRPPTNTestRequestNotReturn_Click(object sender, EventArgs e)
        {
            FormReportTestRequestOutsideNotReturn f = new FormReportTestRequestOutsideNotReturn();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuRPPTNMaterialTestResult_Click(object sender, EventArgs e)
        {
            Form_Report_MaterialTest_OutSide_Result f = new Form_Report_MaterialTest_OutSide_Result();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuRPPTNProductTestResult_Click(object sender, EventArgs e)
        {
            Form_Report_ProductTest_OutSide_Result f = new Form_Report_ProductTest_OutSide_Result();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuRPPTNTestExpense_Click(object sender, EventArgs e)
        {
            FormReport_TestExpense f = new FormReport_TestExpense();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void MenuRPPPTResultOutside_Click(object sender, EventArgs e)
        {
            FormReportResultOutside f = new FormReportResultOutside();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuKCSRPTHPTTP_Click(object sender, EventArgs e)
        {
            Form_KCS_Report_THPTTP f = new Form_KCS_Report_THPTTP(((ToolStripMenuItem)sender).Text, false);
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuKCSRPTHPTNL_Click(object sender, EventArgs e)
        {
            Form_KCS_Report_THPTTP f = new Form_KCS_Report_THPTTP(((ToolStripMenuItem)sender).Text, true);
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuRPTongketBocxep_Click(object sender, EventArgs e)
        {
            FormReport_BocxepResults f = new FormReport_BocxepResults();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuRPBocxepGeneral_Click(object sender, EventArgs e)
        {
            FormReportBocXepResultGeneral f = new FormReportBocXepResultGeneral();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuRPTransportResult_Click(object sender, EventArgs e)
        {
            FormRPTransportResult f = new FormRPTransportResult();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }

        private void menuTruyxuat_Click(object sender, EventArgs e)
        {
            FormTruyxuatnguocgoc f = new FormTruyxuatnguocgoc();
            this.ShowForm(f, ((ToolStripMenuItem)sender).Tag);
        }
    }
}

