
/************************************************************************
**	ClassName	: 	BuyNoInvoice
**	Author		:	Le Phan
**	Company		:	VNS
**	Date		:	20-06-2007 08:37 AM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;

namespace VNS.ERP.Data
{

	/// <summary>
	/// This object represents the properties and methods of a BuyNoInvoice.
	/// </summary>
	public class BuyNoInvoice : BaseClass 
	{
		public BuyNoInvoice()
		{
		}
		
		public BuyNoInvoice(IDataReader reader)
		{
			this.FromDataReader(reader);
		}
		
		public override void FromDataReader(IDataReader reader)
		{
			if (reader != null && !reader.IsClosed)
			{						
				if (!isNull("AccountTransactionID",reader)) accountTransactionID = reader.GetGuid(reader.GetOrdinal("AccountTransactionID"));
				if (!isNull("Ngaymua",reader)) ngaymua = reader.GetDateTime(reader.GetOrdinal("Ngaymua"));
				if (!isNull("TenNguoiban",reader)) tenNguoiban = reader.GetString(reader.GetOrdinal("TenNguoiban"));
				if (!isNull("Diachi",reader)) diachi = reader.GetString(reader.GetOrdinal("Diachi"));
				if (!isNull("TenMathang",reader)) tenMathang = reader.GetString(reader.GetOrdinal("TenMathang"));
				if (!isNull("Soluong",reader)) soluong = reader.GetDecimal(reader.GetOrdinal("Soluong"));
				if (!isNull("Dongia",reader)) dongia = reader.GetDecimal(reader.GetOrdinal("Dongia"));
				if (!isNull("TienThanhtoan",reader)) tienThanhtoan = reader.GetDecimal(reader.GetOrdinal("TienThanhtoan"));
				if (!isNull("Ghichu",reader)) ghichu = reader.GetString(reader.GetOrdinal("Ghichu"));
                if (!isNull("BranchCode", reader)) branchCode = reader.GetString(reader.GetOrdinal("BranchCode"));
                
			}
		}
        public override void LoadFromDataRow(DataRow row)
        {
            base.LoadFromDataRow(row);
            if (!row.IsNull("AccountTransactionID")) accountTransactionID = (Guid)row["AccountTransactionID"];
            if (!row.IsNull("Ngaymua")) ngaymua = (DateTime)row["Ngaymua"];
            if (!row.IsNull("TenNguoiban")) tenNguoiban = (string)row["TenNguoiban"];
            if (!row.IsNull("Diachi")) diachi = (string)row["Diachi"];
            if (!row.IsNull("TenMathang")) tenMathang = (string)row["TenMathang"];
            if (!row.IsNull("Soluong")) soluong = (decimal)row["Soluong"];
            if (!row.IsNull("Dongia")) dongia = (decimal)row["Dongia"];
            if (!row.IsNull("TienThanhtoan")) tienThanhtoan = (decimal)row["TienThanhtoan"];
            if (!row.IsNull("Ghichu")) ghichu = (string)row["Ghichu"];
            if (!row.IsNull("BranchCode")) branchCode = (string)row["BranchCode"];
        }
		
		#region Public Properties
		
		private Guid accountTransactionID = Guid.Empty;
		/// <summary>
		/// Gets or sets the value of AccountTransactionID
		/// </summary>
		public Guid AccountTransactionID
		{
			get {return accountTransactionID;}
			set {accountTransactionID = value;}
		}

        private DateTime ngaymua = Contexts.WorkingDate;
		/// <summary>
		/// Gets or sets the value of Ngaymua
		/// </summary>
		public DateTime Ngaymua
		{
			get {return ngaymua;}
			set {ngaymua = value;}
		}

		private string tenNguoiban = String.Empty;
		/// <summary>
		/// Gets or sets the value of TenNguoiban
		/// </summary>
		public string TenNguoiban
		{
			get {return tenNguoiban;}
			set {tenNguoiban = value;}
		}

		private string diachi = String.Empty;
		/// <summary>
		/// Gets or sets the value of Diachi
		/// </summary>
		public string Diachi
		{
			get {return diachi;}
			set {diachi = value;}
		}

		private string tenMathang = String.Empty;
		/// <summary>
		/// Gets or sets the value of TenMathang
		/// </summary>
		public string TenMathang
		{
			get {return tenMathang;}
			set {tenMathang = value;}
		}

		private decimal soluong;
		/// <summary>
		/// Gets or sets the value of Soluong
		/// </summary>
		public decimal Soluong
		{
			get {return soluong;}
			set {
                soluong = value;
                if (Dongia != 0)
                    TienThanhtoan = Dongia * soluong;
            }
		}

		private decimal dongia;
		/// <summary>
		/// Gets or sets the value of Dongia
		/// </summary>
		public decimal Dongia
		{
			get {return dongia;}
			set {
                dongia = value;
                if (Soluong != 0)
                    TienThanhtoan = dongia * Soluong;
            }

		}

		private decimal tienThanhtoan;
		/// <summary>
		/// Gets or sets the value of TienThanhtoan
		/// </summary>
		public decimal TienThanhtoan
		{
			get {return tienThanhtoan;}
			set {tienThanhtoan = value;}
		}

		private string ghichu = String.Empty;
		/// <summary>
		/// Gets or sets the value of Ghichu
		/// </summary>
		public string Ghichu
		{
			get {return ghichu;}
			set {ghichu = value;}
		}

        private string branchCode = String.Empty;
		/// <summary>
		/// Gets or sets the value of Ghichu
		/// </summary>
        public string BranchCode
		{
            get { return branchCode; }
            set { branchCode = value; }
		}

        
		#endregion
		
		

	}

}	
