using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data.Accounting
{
    #region UyNhiemChiPrint
    /// <summary>
    /// This object represents the properties and methods of a UyNhiemChiPrint.
    /// </summary>
    public class UyNhiemChiPrint : ObjectBase
    {


        public UyNhiemChiPrint()
        {
        }



        public UyNhiemChiPrint(IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public override void FromDataReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("SubjectCode", reader)) subjectCode = reader.GetString(reader.GetOrdinal("SubjectCode"));
                if (!isNull("CoGiay", reader)) coGiay = reader.GetString(reader.GetOrdinal("CoGiay"));
                if (!isNull("InNgang", reader)) inNgang = reader.GetBoolean(reader.GetOrdinal("InNgang"));
                if (!isNull("NgayX", reader)) ngayX = reader.GetInt32(reader.GetOrdinal("NgayX"));
                if (!isNull("NgayY", reader)) ngayY = reader.GetInt32(reader.GetOrdinal("NgayY"));
                if (!isNull("NgayF", reader)) ngayF = reader.GetString(reader.GetOrdinal("NgayF"));
                if (!isNull("ThangX", reader)) thangX = reader.GetInt32(reader.GetOrdinal("ThangX"));
                if (!isNull("ThangF", reader)) thangF = reader.GetString(reader.GetOrdinal("ThangF"));
                if (!isNull("NamX", reader)) namX = reader.GetInt32(reader.GetOrdinal("NamX"));
                if (!isNull("NamF", reader)) namF = reader.GetString(reader.GetOrdinal("NamF"));
                if (!isNull("TraTenX", reader)) traTenX = reader.GetInt32(reader.GetOrdinal("TraTenX"));
                if (!isNull("TraTenY", reader)) traTenY = reader.GetInt32(reader.GetOrdinal("TraTenY"));
                if (!isNull("TraTenC", reader)) traTenC = reader.GetInt32(reader.GetOrdinal("TraTenC"));
                if (!isNull("TraTenX2", reader)) traTenX2 = reader.GetInt32(reader.GetOrdinal("TraTenX2"));
                if (!isNull("TraTenY2", reader)) traTenY2 = reader.GetInt32(reader.GetOrdinal("TraTenY2"));
                if (!isNull("TraTKX", reader)) traTKX = reader.GetInt32(reader.GetOrdinal("TraTKX"));
                if (!isNull("TraTKY", reader)) traTKY = reader.GetInt32(reader.GetOrdinal("TraTKY"));
                if (!isNull("TraNHX", reader)) traNHX = reader.GetInt32(reader.GetOrdinal("TraNHX"));
                if (!isNull("TraNHY", reader)) traNHY = reader.GetInt32(reader.GetOrdinal("TraNHY"));
                if (!isNull("TienChuX", reader)) tienChuX = reader.GetInt32(reader.GetOrdinal("TienChuX"));
                if (!isNull("TienChuY", reader)) tienChuY = reader.GetInt32(reader.GetOrdinal("TienChuY"));
                if (!isNull("TienChuC", reader)) tienChuC = reader.GetInt32(reader.GetOrdinal("TienChuC"));
                if (!isNull("TienChuX2", reader)) tienChuX2 = reader.GetInt32(reader.GetOrdinal("TienChuX2"));
                if (!isNull("TienChuY2", reader)) tienChuY2 = reader.GetInt32(reader.GetOrdinal("TienChuY2"));
                if (!isNull("TienSoX", reader)) tienSoX = reader.GetInt32(reader.GetOrdinal("TienSoX"));
                if (!isNull("TienSoY", reader)) tienSoY = reader.GetInt32(reader.GetOrdinal("TienSoY"));
                if (!isNull("NhanTenX", reader)) nhanTenX = reader.GetInt32(reader.GetOrdinal("NhanTenX"));
                if (!isNull("NhanTenY", reader)) nhanTenY = reader.GetInt32(reader.GetOrdinal("NhanTenY"));
                if (!isNull("NhanTenC", reader)) nhanTenC = reader.GetInt32(reader.GetOrdinal("NhanTenC"));
                if (!isNull("NhanTenX2", reader)) nhanTenX2 = reader.GetInt32(reader.GetOrdinal("NhanTenX2"));
                if (!isNull("NhanTenY2", reader)) nhanTenY2 = reader.GetInt32(reader.GetOrdinal("NhanTenY2"));
                if (!isNull("NhanTKX", reader)) nhanTKX = reader.GetInt32(reader.GetOrdinal("NhanTKX"));
                if (!isNull("NhanTKY", reader)) nhanTKY = reader.GetInt32(reader.GetOrdinal("NhanTKY"));
                if (!isNull("NhanNHX", reader)) nhanNHX = reader.GetInt32(reader.GetOrdinal("NhanNHX"));
                if (!isNull("NhanNHY", reader)) nhanNHY = reader.GetInt32(reader.GetOrdinal("NhanNHY"));
                if (!isNull("NoiDungX", reader)) noiDungX = reader.GetInt32(reader.GetOrdinal("NoiDungX"));
                if (!isNull("NoiDungY", reader)) noiDungY = reader.GetInt32(reader.GetOrdinal("NoiDungY"));
            }
        }

        #region Public Properties



        private string subjectCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of SubjectCode
        /// </summary>
        public string SubjectCode
        {
            get { return subjectCode; }
            set { subjectCode = value; }
        }

        private string coGiay = String.Empty;
        /// <summary>
        /// Gets or sets the value of CoGiay
        /// </summary>
        public string CoGiay
        {
            get { return coGiay; }
            set { coGiay = value; }
        }

        private bool inNgang;
        /// <summary>
        /// Gets or sets the value of InNgang
        /// </summary>
        public bool InNgang
        {
            get { return inNgang; }
            set { inNgang = value; }
        }

        private int ngayX;
        /// <summary>
        /// Gets or sets the value of NgayX
        /// </summary>
        public int NgayX
        {
            get { return ngayX; }
            set { ngayX = value; }
        }

        private int ngayY;
        /// <summary>
        /// Gets or sets the value of NgayY
        /// </summary>
        public int NgayY
        {
            get { return ngayY; }
            set { ngayY = value; }
        }

        private string ngayF = String.Empty;
        /// <summary>
        /// Gets or sets the value of NgayF
        /// </summary>
        public string NgayF
        {
            get { return ngayF; }
            set { ngayF = value; }
        }

        private int thangX;
        /// <summary>
        /// Gets or sets the value of ThangX
        /// </summary>
        public int ThangX
        {
            get { return thangX; }
            set { thangX = value; }
        }

        private string thangF = String.Empty;
        /// <summary>
        /// Gets or sets the value of ThangF
        /// </summary>
        public string ThangF
        {
            get { return thangF; }
            set { thangF = value; }
        }

        private int namX;
        /// <summary>
        /// Gets or sets the value of NamX
        /// </summary>
        public int NamX
        {
            get { return namX; }
            set { namX = value; }
        }

        private string namF = String.Empty;
        /// <summary>
        /// Gets or sets the value of NamF
        /// </summary>
        public string NamF
        {
            get { return namF; }
            set { namF = value; }
        }

        private int traTenX;
        /// <summary>
        /// Gets or sets the value of TraTenX
        /// </summary>
        public int TraTenX
        {
            get { return traTenX; }
            set { traTenX = value; }
        }

        private int traTenY;
        /// <summary>
        /// Gets or sets the value of TraTenY
        /// </summary>
        public int TraTenY
        {
            get { return traTenY; }
            set { traTenY = value; }
        }

        private int traTenC;
        /// <summary>
        /// Gets or sets the value of TraTenC
        /// </summary>
        public int TraTenC
        {
            get { return traTenC; }
            set { traTenC = value; }
        }

        private int traTenX2;
        /// <summary>
        /// Gets or sets the value of TraTenX2
        /// </summary>
        public int TraTenX2
        {
            get { return traTenX2; }
            set { traTenX2 = value; }
        }

        private int traTenY2;
        /// <summary>
        /// Gets or sets the value of TraTenY2
        /// </summary>
        public int TraTenY2
        {
            get { return traTenY2; }
            set { traTenY2 = value; }
        }

        private int traTKX;
        /// <summary>
        /// Gets or sets the value of TraTKX
        /// </summary>
        public int TraTKX
        {
            get { return traTKX; }
            set { traTKX = value; }
        }

        private int traTKY;
        /// <summary>
        /// Gets or sets the value of TraTKY
        /// </summary>
        public int TraTKY
        {
            get { return traTKY; }
            set { traTKY = value; }
        }

        private int traNHX;
        /// <summary>
        /// Gets or sets the value of TraNHX
        /// </summary>
        public int TraNHX
        {
            get { return traNHX; }
            set { traNHX = value; }
        }

        private int traNHY;
        /// <summary>
        /// Gets or sets the value of TraNHY
        /// </summary>
        public int TraNHY
        {
            get { return traNHY; }
            set { traNHY = value; }
        }

        private int tienChuX;
        /// <summary>
        /// Gets or sets the value of TienChuX
        /// </summary>
        public int TienChuX
        {
            get { return tienChuX; }
            set { tienChuX = value; }
        }

        private int tienChuY;
        /// <summary>
        /// Gets or sets the value of TienChuY
        /// </summary>
        public int TienChuY
        {
            get { return tienChuY; }
            set { tienChuY = value; }
        }

        private int tienChuC;
        /// <summary>
        /// Gets or sets the value of TienChuC
        /// </summary>
        public int TienChuC
        {
            get { return tienChuC; }
            set { tienChuC = value; }
        }

        private int tienChuX2;
        /// <summary>
        /// Gets or sets the value of TienChuX2
        /// </summary>
        public int TienChuX2
        {
            get { return tienChuX2; }
            set { tienChuX2 = value; }
        }

        private int tienChuY2;
        /// <summary>
        /// Gets or sets the value of TienChuY2
        /// </summary>
        public int TienChuY2
        {
            get { return tienChuY2; }
            set { tienChuY2 = value; }
        }

        private int tienSoX;
        /// <summary>
        /// Gets or sets the value of TienSoX
        /// </summary>
        public int TienSoX
        {
            get { return tienSoX; }
            set { tienSoX = value; }
        }

        private int tienSoY;
        /// <summary>
        /// Gets or sets the value of TienSoY
        /// </summary>
        public int TienSoY
        {
            get { return tienSoY; }
            set { tienSoY = value; }
        }

        private int nhanTenX;
        /// <summary>
        /// Gets or sets the value of NhanTenX
        /// </summary>
        public int NhanTenX
        {
            get { return nhanTenX; }
            set { nhanTenX = value; }
        }

        private int nhanTenY;
        /// <summary>
        /// Gets or sets the value of NhanTenY
        /// </summary>
        public int NhanTenY
        {
            get { return nhanTenY; }
            set { nhanTenY = value; }
        }

        private int nhanTenC;
        /// <summary>
        /// Gets or sets the value of NhanTenC
        /// </summary>
        public int NhanTenC
        {
            get { return nhanTenC; }
            set { nhanTenC = value; }
        }

        private int nhanTenX2;
        /// <summary>
        /// Gets or sets the value of NhanTenX2
        /// </summary>
        public int NhanTenX2
        {
            get { return nhanTenX2; }
            set { nhanTenX2 = value; }
        }

        private int nhanTenY2;
        /// <summary>
        /// Gets or sets the value of NhanTenY2
        /// </summary>
        public int NhanTenY2
        {
            get { return nhanTenY2; }
            set { nhanTenY2 = value; }
        }

        private int nhanTKX;
        /// <summary>
        /// Gets or sets the value of NhanTKX
        /// </summary>
        public int NhanTKX
        {
            get { return nhanTKX; }
            set { nhanTKX = value; }
        }

        private int nhanTKY;
        /// <summary>
        /// Gets or sets the value of NhanTKY
        /// </summary>
        public int NhanTKY
        {
            get { return nhanTKY; }
            set { nhanTKY = value; }
        }

        private int nhanNHX;
        /// <summary>
        /// Gets or sets the value of NhanNHX
        /// </summary>
        public int NhanNHX
        {
            get { return nhanNHX; }
            set { nhanNHX = value; }
        }

        private int nhanNHY;
        /// <summary>
        /// Gets or sets the value of NhanNHY
        /// </summary>
        public int NhanNHY
        {
            get { return nhanNHY; }
            set { nhanNHY = value; }
        }

        private int noiDungX;
        /// <summary>
        /// Gets or sets the value of NoiDungX
        /// </summary>
        public int NoiDungX
        {
            get { return noiDungX; }
            set { noiDungX = value; }
        }

        private int noiDungY;
        /// <summary>
        /// Gets or sets the value of NoiDungY
        /// </summary>
        public int NoiDungY
        {
            get { return noiDungY; }
            set { noiDungY = value; }
        }
        #endregion

        #region Lists
        #endregion


    }
    #endregion
}
