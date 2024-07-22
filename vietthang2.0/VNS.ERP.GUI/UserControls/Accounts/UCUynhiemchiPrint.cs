using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data.Accounting;

namespace VNS.ERP.GUI.UserControls
{
    public partial class UCUynhiemchiPrint : VNS.Windows.Controls.EditControlBase
    {
        public UCUynhiemchiPrint()
        {
            InitializeComponent();
        }
        protected override void BindData()
        {

            if (DataSource != null)
            {
                UyNhiemChiPrint o = this.DataSource as UyNhiemChiPrint;
                lookUpSubjectCode.EditValue = o.SubjectCode;

                txtNgayX.EditValue = o.NgayX;
                txtNgayY.EditValue = o.NgayY;
                txtNgayF.EditValue = o.NgayF;
                txtThangX.EditValue = o.ThangX;
                txtThangF.EditValue = o.ThangF;
                txtNamX.EditValue = o.NamX;
                txtNamF.EditValue = o.NamF;
                
                txtTraTenX.EditValue = o.TraTenX;
                txtTraTenY.EditValue = o.TraTenY;
                txtTraTenC.EditValue = o.TraTenC;
                txtTraTenX2.EditValue = o.TraTenX2;
                txtTraTenY2.EditValue = o.TraTenY2;
                txtTraTKX.EditValue = o.TraTKX;
                txtTraTKY.EditValue = o.TraTKY;
                txtTraNHX.EditValue = o.TraNHX;
                txtTraNHY.EditValue = o.TraNHY;
                txtTienChuX.EditValue = o.TienChuX;
                txtTienChuY.EditValue = o.TienChuY;
                txtTienChuC.EditValue = o.TienChuC;
                txtTienChuX2.EditValue = o.TienChuX2;
                txtTienChuY2.EditValue = o.TienChuY2;
                txtTienSoX.EditValue = o.TienSoX;
                txtTienSoY.EditValue = o.TienSoY;

                TxtNhanTenX.EditValue = o.NhanTenX;
                TxtNhanTenY.EditValue = o.NhanTenY;
                txtNhanTenC.EditValue = o.NhanTenC;
                txtNhanTenX2.EditValue = o.NhanTenX2;
                txtNhanTenY2.EditValue = o.NhanTenY2;
                txtNhanTKX.EditValue = o.NhanTKX;
                txtNhanTKY.EditValue = o.NhanTKY;
                txtNhanNHX.EditValue = o.NhanNHX;
                txtNhanNHY.EditValue = o.NhanNHY;
                txtNoiDungX.EditValue = o.NoiDungX;
                txtNoiDungY.EditValue = o.NoiDungY;



                if (this.EditMode == VNS.Windows.FormEditMode.ADD)
                {
                    try
                    {
                        lookUpSubjectCode.ItemIndex = 0;
                    }
                    catch
                    {
                    }

                }
            }
            base.BindData();
        }
        protected override void AssignData()
        {
            UyNhiemChiPrint o = this.DataSource as UyNhiemChiPrint;
            o.SubjectCode = lookUpSubjectCode.EditValue.ToString();

            o.NgayX = (int)txtNgayX.EditValue;
            o.NgayY = (int)txtNgayY.EditValue;
            o.NgayF = txtNgayF.EditValue.ToString();
            o.ThangX = (int)txtThangX.EditValue;
            o.ThangF = txtThangF.EditValue.ToString();
            o.NamX = (int)txtNamX.EditValue;
            o.NamF = txtNamF.EditValue.ToString();

            o.TraTenX = (int)txtTraTenX.EditValue;
            o.TraTenY = (int)txtTraTenY.EditValue;
            o.TraTenC = (int)txtTraTenC.EditValue;
            o.TraTenX2 = (int)txtTraTenX2.EditValue;
            o.TraTenY2 = (int)txtTraTenY2.EditValue;
            o.TraTKX = (int)txtTraTKX.EditValue;
            o.TraTKY = (int)txtTraTKY.EditValue;
            o.TraNHX = (int)txtTraNHX.EditValue;
            o.TraNHY = (int)txtTraNHY.EditValue;
            o.TienChuX = (int)txtTienChuX.EditValue;
            o.TienChuY = (int)txtTienChuY.EditValue;
            o.TienChuC = (int)txtTienChuC.EditValue;
            o.TienChuX2 = (int)txtTienChuX2.EditValue;
            o.TienChuY2 = (int)txtTienChuY2.EditValue;
            o.TienSoX = (int)txtTienSoX.EditValue;
            o.TienSoY = (int)txtTienSoY.EditValue;

            o.NhanTenX = (int)TxtNhanTenX.EditValue;
            o.NhanTenY = (int)TxtNhanTenY.EditValue;
            o.NhanTenC = (int)txtNhanTenC.EditValue;
            o.NhanTenX2 = (int)txtNhanTenX2.EditValue;
            o.NhanTenY2 = (int)txtNhanTenY2.EditValue;
            o.NhanTKX = (int)txtNhanTKX.EditValue;
            o.NhanTKY = (int)txtNhanTKY.EditValue;
            o.NhanNHX = (int)txtNhanNHX.EditValue;
            o.NhanNHY = (int)txtNhanNHY.EditValue;
            o.NoiDungX = (int)txtNoiDungX.EditValue;
            o.NoiDungY = (int)txtNoiDungY.EditValue;

            base.AssignData();
        }
        public override void RefreshControl()
        {
            lookUpSubjectCode.Properties.ReadOnly = this.EditMode != VNS.Windows.FormEditMode.ADD;

            txtNgayX.Properties.ReadOnly =
            txtNgayY.Properties.ReadOnly =
            txtNgayF.Properties.ReadOnly =
            txtThangX.Properties.ReadOnly =
            txtThangF.Properties.ReadOnly =
            txtNamX.Properties.ReadOnly =
            txtNamF.Properties.ReadOnly =

            txtTraTenX.Properties.ReadOnly =
            txtTraTenY.Properties.ReadOnly =
            txtTraTenC.Properties.ReadOnly =
            txtTraTenX2.Properties.ReadOnly =
            txtTraTenY2.Properties.ReadOnly =
            txtTraTKX.Properties.ReadOnly =
            txtTraTKY.Properties.ReadOnly =
            txtTraNHX.Properties.ReadOnly =
            txtTraNHY.Properties.ReadOnly =
            txtTienChuX.Properties.ReadOnly =
            txtTienChuY.Properties.ReadOnly =
            txtTienChuC.Properties.ReadOnly =
            txtTienChuX2.Properties.ReadOnly =
            txtTienChuY2.Properties.ReadOnly =
            txtTienSoX.Properties.ReadOnly =
            txtTienSoY.Properties.ReadOnly =

            TxtNhanTenX.Properties.ReadOnly =
            TxtNhanTenY.Properties.ReadOnly =
            txtNhanTenC.Properties.ReadOnly =
            txtNhanTenX2.Properties.ReadOnly =
            txtNhanTenY2.Properties.ReadOnly =
            txtNhanTKX.Properties.ReadOnly =
            txtNhanTKY.Properties.ReadOnly =
            txtNhanNHX.Properties.ReadOnly =
            txtNhanNHY.Properties.ReadOnly =
            txtNoiDungX.Properties.ReadOnly =
            txtNoiDungY.Properties.ReadOnly = this.EditMode == VNS.Windows.FormEditMode.VIEW;

            base.RefreshControl();
        }
    }
}

