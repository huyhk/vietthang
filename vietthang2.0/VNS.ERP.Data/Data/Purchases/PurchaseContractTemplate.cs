
/************************************************************************
**	ClassName	: 	PurchaseContractTemplate
**	Author		:	Ai Tang
**	Company		:	VNS
**	Date		:	13-08-2009 02:00 PM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data
{
	#region PurchaseContractTemplate
	/// <summary>
	/// This object represents the properties and methods of a PurchaseContractTemplate.
	/// </summary>
	public class PurchaseContractTemplate : UserTracking 
	{
			
		
		public PurchaseContractTemplate()
		{
		}
		
		public PurchaseContractTemplate(IDataReader reader)
		{
			this.FromDataReader(reader);
		}
		
		public PurchaseContractTemplate(DataRow row)
		{
			this.FromDataRow(row);
		}
		
	
		public override void FromDataReader(IDataReader reader)
		{
			base.FromDataReader(reader);
			if (reader != null && !reader.IsClosed)
			{						
				if (!isNull("TemplateCode",reader)) templateCode = reader.GetString(reader.GetOrdinal("TemplateCode"));
				if (!isNull("TemplateName",reader)) templateName = reader.GetString(reader.GetOrdinal("TemplateName"));
				if (!isNull("TemplateType",reader)) templateType = reader.GetInt32(reader.GetOrdinal("TemplateType"));
				if (!isNull("ItemCode",reader)) itemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
				if (!isNull("TemplateContent",reader)) templateContent = reader.GetString(reader.GetOrdinal("TemplateContent"));
			}
		}
		
		public override void FromDataRow(DataRow row)
		{
			base.FromDataRow(row);
			
			if (!row.IsNull("TemplateCode")) templateCode = (string)row["TemplateCode"];
			if (!row.IsNull("TemplateName")) templateName = (string)row["TemplateName"];
			if (!row.IsNull("TemplateType")) templateType = (int)row["TemplateType"];
			if (!row.IsNull("ItemCode")) itemCode = (string)row["ItemCode"];
			if (!row.IsNull("TemplateContent")) templateContent = (string)row["TemplateContent"];
		}
		
		#region Public Properties

		
		
		private string templateCode = String.Empty;
		/// <summary>
		/// Gets or sets the value of TemplateCode
		/// </summary>
		public string TemplateCode
		{
			get {return templateCode;}
			set {templateCode = value;}
		}

		private string templateName = String.Empty;
		/// <summary>
		/// Gets or sets the value of TemplateName
		/// </summary>
		public string TemplateName
		{
			get {return templateName;}
			set {templateName = value;}
		}

		private int templateType = 1;
		/// <summary>
		/// Gets or sets the value of TemplateType
		/// </summary>
		public int TemplateType
		{
			get {return templateType;}
			set {templateType = value;}
		}

		private string itemCode = String.Empty;
		/// <summary>
		/// Gets or sets the value of ItemCode
		/// </summary>
		public string ItemCode
		{
			get {return itemCode;}
			set {itemCode = value;}
		}

		private string templateContent = String.Empty;
		/// <summary>
		/// Gets or sets the value of TemplateContent
		/// </summary>
		public string TemplateContent
		{
			get {return templateContent;}
			set {templateContent = value;}
		}

		#endregion
		
		#region Lists
		#endregion
		

	}
	#endregion
}	

