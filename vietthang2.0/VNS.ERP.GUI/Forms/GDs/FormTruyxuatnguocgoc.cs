using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data.GD;

namespace VNS.ERP.GUI.Forms.GDs
{
    public partial class FormTruyxuatnguocgoc : VNS.Windows.Forms.FormBase
    {
        Nguongocsanpham Obj = null;
        public FormTruyxuatnguocgoc()
        {
            InitializeComponent();
        }

        private void btnTruyxuat_Click(object sender, EventArgs e)
        {
            Obj = new GDReportBLL().WSNguongocsanpham(this.txtSearchString.Text);
            this.txt1FoodType.Text = Obj.ObjThongtinsanxuat.ObjManufacture.FoodType;
            this.txt1Ngaysx.Text = Obj.ObjThongtinsanxuat.ManufactureDate.ToString("dd/MM/yyyy");
            this.txt1Ca.Text = Obj.ObjThongtinsanxuat.Shift.ToString();
            this.txt1Line.Text = Obj.ObjThongtinsanxuat.ObjManufacture.LinesxNo;
            this.txt1Sanpham.Text = Obj.ObjThongtinsanxuat.ObjManufacture.ItemProductCode;
            this.txt1PlanNo.Text = Obj.ObjThongtinsanxuat.ObjManufacture.PlanNo;
            this.txt1Truongca.Text = Obj.ObjThongtinsanxuat.ShiftLeaderName;
            this.txt1Phoca.Text = Obj.ObjThongtinsanxuat.ViceLeaderName;
            this.txt1Nghien.Text = Obj.ObjThongtinsanxuat.ObjManufacture.EmployeeID1Name;
            this.txt1Ep.Text = Obj.ObjThongtinsanxuat.ObjManufacture.EmployeeID2Name;
            this.txt1Lot.Text = Obj.ObjThongtinsanxuat.ObjManufacture.Lot;
            this.txt1CodeTP.Text = Obj.ObjThongtinsanxuat.ObjManufacture.CodeBaoTP;
            this.txt1FabNo.Text = Obj.ObjThongtinsanxuat.ObjManufacture.FabNo;
            this.txt1SLSXKehoach.Text = Obj.ObjThongtinsanxuat.ObjManufacture.PlanWeight.ToString();
            this.txt1SLSXThucte.Text = Obj.ObjThongtinsanxuat.ObjManufacture.ProductWeight.ToString();
            this.txt1Bontron.EditValue = Obj.ObjThongtinsanxuat.ObjManufacture.BonTron;
            this.txt1CodePremix.EditValue = Obj.ObjThongtinsanxuat.ObjManufacture.CodePremix;

            this.gridControl1Taichephe.DataSource = Obj.ObjThongtinsanxuat.ObjManufacture.ListWasteOrg;
            this.gridControl1Phera.DataSource = Obj.ObjThongtinsanxuat.ObjManufacture.LstPhepham;
            this.gridControl1Nguyenlieu.DataSource = Obj.ObjThongtinsanxuat.ObjManufacture.LstManuTranCompare;

            this.gridControl2Khachhang.DataSource = Obj.ListKhachhang;

            this.txt31Congthuc.EditValue = Obj.ObjChatluongsanpham.FormulaCode;
            this.txt31Nguoikiem.EditValue = Obj.ObjChatluongsanpham.ObjProductTestTransaction.Nguoikiem;
            this.gridControl31Ketqua.DataSource = Obj.ObjChatluongsanpham.ListProductTestTransactionResult;
            this.txt32Nguoikiem.EditValue = Obj.ObjChatluongsanpham.ObjTechnicalTestReturn.InfaUser;
            this.txt32Danhgia.EditValue = Obj.ObjChatluongsanpham.ObjTechnicalTestReturn.Description;
            this.gridControl32Ketqua.DataSource = Obj.ObjChatluongsanpham.ListTechnicalTestReturnDetail;
            this.gridControl33Ketqua.DataSource = Obj.ObjChatluongsanpham.ListTestRequestReturnDetail;

            this.gridControl4Nguyenlieu.DataSource = Obj.ListNguyenlieusudung;

            this.gridControl5CLNguyenlieu.DataSource = Obj.ListChatluongnguyenlieu;

            this.txt6Date.Text = Obj.ObjSanxuatpremix.MixDate.ToString("dd/MM/yyyy");
            this.txt6Ca.EditValue = Obj.ObjSanxuatpremix.Shift;
            this.txt6Loai.EditValue = Obj.ObjSanxuatpremix.ObjMixPremix.PremixCode;
            this.txt6Congthuc.EditValue = Obj.ObjSanxuatpremix.ObjMixPremix.FormulaCode;
            this.txt6CodePremix.EditValue = Obj.ObjSanxuatpremix.ObjMixPremix.PremixWrappingCode;
            this.txt6Nguoisoche.EditValue = Obj.ObjSanxuatpremix.ObjMixPremix.Premixer;
            this.gridControl6Nguyenlieu.DataSource = Obj.ObjSanxuatpremix.ObjMixPremix.LstMaterialIn;

            this.gridControl7Nguyenlieu.DataSource = Obj.ListNguyenlieusxpremix;

            this.gridControl8Baobi.DataSource = Obj.ListThongtinbaobi;
        }
    }
}

