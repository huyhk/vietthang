
/************************************************************************
**	ClassName	: 	Invoice
**	Author		:	Le Phan
**	Company		:	VNS
**	Date		:	31-05-2007 01:57 PM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;


namespace VNS.ERP.Data
{
	
	/// <summary>
	/// This object represents the properties and methods of a Invoice.
	/// </summary>
	public class Invoice : BaseClass 
	{
			
		
		public Invoice()
		{
		}
		
		
		
		public Invoice(IDataReader reader)
		{
			this.FromDataReader(reader);
		}
		
		public override void FromDataReader(IDataReader reader)
		{
			if (reader != null && !reader.IsClosed)
			{
				if (!isNull("AccountTransactionID",reader)) accountTransactionID = reader.GetGuid(reader.GetOrdinal("AccountTransactionID"));
				if (!isNull("Dauvao",reader)) dauvao = reader.GetBoolean(reader.GetOrdinal("Dauvao"));
				if (!isNull("MauHoadon",reader)) mauHoadon = reader.GetString(reader.GetOrdinal("MauHoadon"));
				if (!isNull("SoSeri",reader)) soSeri = reader.GetString(reader.GetOrdinal("SoSeri"));
				if (!isNull("SoHoadon",reader)) soHoadon = reader.GetString(reader.GetOrdinal("SoHoadon"));
				if (!isNull("NgayHoadon",reader)) ngayHoadon = reader.GetDateTime(reader.GetOrdinal("NgayHoadon"));
				if (!isNull("TenDonvi",reader)) tenDonvi = reader.GetString(reader.GetOrdinal("TenDonvi"));
				if (!isNull("Masothue",reader)) masothue = reader.GetString(reader.GetOrdinal("Masothue"));
				if (!isNull("Thuexuat",reader)) thuexuat = reader.GetDecimal(reader.GetOrdinal("Thuexuat"));
				if (!isNull("Tienthue",reader)) tienthue = reader.GetDecimal(reader.GetOrdinal("Tienthue"));
				if (!isNull("Doanhso",reader)) doanhso = reader.GetDecimal(reader.GetOrdinal("Doanhso"));
				if (!isNull("TenMathang",reader)) tenMathang = reader.GetString(reader.GetOrdinal("TenMathang"));
				if (!isNull("Description",reader)) description = reader.GetString(reader.GetOrdinal("Description"));
				if (!isNull("Khongchiuthue",reader)) khongchiuthue = reader.GetBoolean(reader.GetOrdinal("Khongchiuthue"));
                if (!isNull("Nhapkhau", reader)) nhapkhau = reader.GetBoolean(reader.GetOrdinal("Nhapkhau"));
                if (!isNull("BranchCode", reader)) branchCode = reader.GetString(reader.GetOrdinal("BranchCode"));
                
			}
		}
        public override void LoadFromDataRow(DataRow row)
        {
            base.LoadFromDataRow(row);
            if (!row.IsNull("AccountTransactionID")) accountTransactionID = (Guid)row["AccountTransactionID"];
            if (!row.IsNull("Dauvao")) dauvao = (bool)row["Dauvao"];
            if (!row.IsNull("MauHoadon")) mauHoadon = (string)row["MauHoadon"];
            if (!row.IsNull("SoSeri")) soSeri = (string)row["SoSeri"];
            if (!row.IsNull("SoHoadon")) soHoadon = (string)row["SoHoadon"];
            if (!row.IsNull("NgayHoadon")) ngayHoadon = (DateTime)row["NgayHoadon"];
            if (!row.IsNull("TenDonvi")) tenDonvi = (string)row["TenDonvi"];
            if (!row.IsNull("Masothue")) masothue = (string)row["Masothue"];
            if (!row.IsNull("Thuexuat")) thuexuat = (decimal)row["Thuexuat"];
            if (!row.IsNull("Tienthue")) tienthue = (decimal)row["Tienthue"];
            if (!row.IsNull("Doanhso")) doanhso = (decimal)row["Doanhso"];
            if (!row.IsNull("TenMathang")) tenMathang = (string)row["TenMathang"];
            if (!row.IsNull("Description")) description = (string)row["Description"];
            if (!row.IsNull("Khongchiuthue")) khongchiuthue = (bool)row["Khongchiuthue"];
            if (!row.IsNull("Nhapkhau")) nhapkhau = (bool)row["Nhapkhau"];
            if (!row.IsNull("BranchCode")) branchCode = (string)row["BranchCode"];
        }
		
		#region Public Properties

		
		
		protected Guid accountTransactionID = Guid.Empty;
		/// <summary>
		/// Gets or sets the value of AccountTransactionID
		/// </summary>
		public Guid AccountTransactionID
		{
			get {return accountTransactionID;}
			set {accountTransactionID = value;}
		}

		protected bool dauvao=false;
		/// <summary>
		/// Gets or sets the value of Dauvao
		/// </summary>
		public bool Dauvao
		{
			get {return dauvao;}
			set {dauvao = value;}
		}

		protected string mauHoadon = String.Empty;
		/// <summary>
		/// Gets or sets the value of MauHoadon
		/// </summary>
		public string MauHoadon
		{
			get {return mauHoadon;}
			set {mauHoadon = value;}
		}

		protected string soSeri = String.Empty;
		/// <summary>
		/// Gets or sets the value of SoSeri
		/// </summary>
		public string SoSeri
		{
			get {return soSeri;}
			set {soSeri = value;}
		}

		protected string soHoadon = String.Empty;
		/// <summary>
		/// Gets or sets the value of SoHoadon
		/// </summary>
		public string SoHoadon
		{
			get {return soHoadon;}
			set {soHoadon = value;}
		}

		protected DateTime ngayHoadon=DateTime.Today;
		/// <summary>
		/// Gets or sets the value of NgayHoadon
		/// </summary>
		public DateTime NgayHoadon
		{
			get {return ngayHoadon;}
			set {ngayHoadon = value;}
		}

		protected string tenDonvi = String.Empty;
		/// <summary>
		/// Gets or sets the value of TenDonvi
		/// </summary>
		public string TenDonvi
		{
			get {return tenDonvi;}
			set {tenDonvi = value;}
		}
        protected string maDonvi = String.Empty;
        /// <summary>
        /// Gets or sets the value of TenDonvi
        /// </summary>
        public string MaDonvi
        {
            get { return maDonvi; }
            set { maDonvi = value; }
        }

		protected string masothue = String.Empty;
		/// <summary>
		/// Gets or sets the value of Masothue
		/// </summary>
		public string Masothue
		{
			get {return masothue;}
			set {masothue = value;}
		}
        protected decimal doanhso;
        /// <summary>
        /// Gets or sets the value of Doanhso
        /// </summary>
        public decimal Doanhso
        {
            get { return doanhso; }
            set
            {
                doanhso = value;
                if (Thuexuat != 0)
                {
                    Tienthue = decimal.Round((doanhso * Thuexuat),0);
                }
            }
        }
		protected decimal thuexuat;
		/// <summary>
		/// Gets or sets the value of Thuexuat
		/// </summary>
		public decimal Thuexuat
		{
			get {return thuexuat;}
			set {
                thuexuat = value;
                if (doanhso != 0)
                {
                    Tienthue = decimal.Round((doanhso * Thuexuat), 0);
                }
            }
		}

		protected decimal tienthue;
		/// <summary>
		/// Gets or sets the value of Tienthue
		/// </summary>
		public decimal Tienthue
		{
			get {return tienthue;}
			set {
                tienthue = value;
            }
		}

		

		protected string tenMathang = String.Empty;
		/// <summary>
		/// Gets or sets the value of TenMathang
		/// </summary>
		public string TenMathang
		{
			get {return tenMathang;}
			set {tenMathang = value;}
		}

		protected string description = String.Empty;
		/// <summary>
		/// Gets or sets the value of Description
		/// </summary>
		public string Description
		{
			get {return description;}
			set {description = value;}
		}

        protected string branchCode = String.Empty;
		/// <summary>
		/// Gets or sets the value of Description
		/// </summary>
        public string BranchCode
		{
            get { return branchCode; }
            set { branchCode = value; }
		}
        
        protected bool khongchiuthue = false;
		/// <summary>
		/// Gets or sets the value of Khongchiuthue
		/// </summary>
		public bool Khongchiuthue
		{
			get {return khongchiuthue;}
			set {khongchiuthue = value;}
		}
        protected bool nhapkhau = false;
        /// <summary>
        /// Gets or sets the value of Khongchiuthue
        /// </summary>
        public bool Nhapkhau
        {
            get { return nhapkhau; }
            set { nhapkhau = value; }
        }
		#endregion
		

	}

}	
