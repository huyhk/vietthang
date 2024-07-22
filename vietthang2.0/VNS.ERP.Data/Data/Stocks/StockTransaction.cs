using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using VNS.Common;
using VNS.ERP.Data.Sales;
//using VNS.ERP.Common;

namespace VNS.ERP.Data
{
    public class StockTransaction:UserTracking2
    {
        public StockTransaction() { }
        public StockTransaction(IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public StockTransaction(DataRow row)
        {
            this.FromDataRow(row);
        }
        public bool IsLocalTransaction
        {
            get 
            {
                bool result = false;
                result = result || this.TransactionTypeCode == "N13";
                result = result || this.TransactionTypeCode == "N23";
                result = result || this.TransactionTypeCode == "N33";
                result = result || this.TransactionTypeCode == "X13";
                result = result || this.TransactionTypeCode == "X23";
                result = result || this.TransactionTypeCode == "X33";
                return result;
            }
        }
        public override void FromDataReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("TransactionID", reader)) _TransactionID = reader.GetGuid(reader.GetOrdinal("TransactionID"));
                if (!isNull("TransactionTypeCode", reader)) _TransactionTypeCode = reader.GetString(reader.GetOrdinal("TransactionTypeCode"));
                if (!isNull("InStock", reader)) _InStock = reader.GetString(reader.GetOrdinal("InStock"));
                if (!isNull("OutStock", reader)) _OutStock = reader.GetString(reader.GetOrdinal("OutStock"));
                if (!isNull("TransactionNo", reader)) _TransactionNo = reader.GetString(reader.GetOrdinal("TransactionNo"));
                if (!isNull("TransactionDate", reader)) _TransactionDate = reader.GetDateTime(reader.GetOrdinal("TransactionDate"));
                if (!isNull("Description", reader)) _Description = reader.GetString(reader.GetOrdinal("Description"));
                //if (!CheckNull("UserCreated", reader)) UserCreated = reader.GetString(reader.GetOrdinal("UserCreated"));
                //if (!CheckNull("DateCreated", reader)) DateCreated = reader.GetDateTime(reader.GetOrdinal("TransactionDate"));
                //if (!CheckNull("UserUpdated", reader)) UserUpdated = reader.GetString(reader.GetOrdinal("UserUpdated"));
                //if (!CheckNull("DateUpdated", reader)) DateUpdated = reader.GetDateTime(reader.GetOrdinal("DateUpdated"));
                if (!isNull("Shift", reader)) _Shift = reader.GetByte(reader.GetOrdinal("Shift"));
                if (!isNull("GetByWeightItems", reader)) _GetByWeightItems = reader.GetBoolean(reader.GetOrdinal("GetByWeightItems"));
                if (!isNull("GetByWeightItemContainer", reader)) getByWeightItemContainer = reader.GetBoolean(reader.GetOrdinal("GetByWeightItemContainer"));
                if (!isNull("ForDepartment", reader)) _ForDepartment = reader.GetByte(reader.GetOrdinal("ForDepartment"));
                if (!isNull("Status", reader)) _Status = reader.GetByte(reader.GetOrdinal("Status"));
                if (!isNull("DepartmentStatus", reader)) _DepartmentStatus = reader.GetByte(reader.GetOrdinal("DepartmentStatus"));
                if (!isNull("CreatedType", reader)) _CreatedType = reader.GetByte(reader.GetOrdinal("CreatedType"));
                if (!isNull("GenType", reader)) _GenType = reader.GetByte(reader.GetOrdinal("GenType"));
                if (!isNull("GenID", reader)) _GenID = reader.GetGuid(reader.GetOrdinal("GenID"));
                if (!isNull("KhoGiaoNhan", reader)) _KhoGiaoNhan = reader.GetString(reader.GetOrdinal("KhoGiaoNhan"));
                if (!isNull("DVGiao", reader)) _DVGiao = reader.GetString(reader.GetOrdinal("DVGiao"));
                if (!isNull("SoHD", reader)) _SoHD = reader.GetString(reader.GetOrdinal("SoHD"));
                if (!isNull("DVNhan", reader)) _DVNhan = reader.GetString(reader.GetOrdinal("DVNhan"));
                if (!isNull("SoDH", reader)) _SoDH = reader.GetString(reader.GetOrdinal("SoDH"));
                if (!isNull("DonviVC", reader)) _DonviVC = reader.GetString(reader.GetOrdinal("DonviVC"));
                if (!isNull("PTVC", reader)) _PTVC = reader.GetString(reader.GetOrdinal("PTVC"));
                if (!isNull("CTKemTheo", reader)) _CTKemTheo = reader.GetString(reader.GetOrdinal("CTKemTheo"));
                if (!isNull("SoHoaDon", reader)) _SoHoaDon = reader.GetString(reader.GetOrdinal("SoHoaDon"));
                if (!isNull("Nguoigiaonhan", reader)) nguoiGiaoNhan = reader.GetString(reader.GetOrdinal("Nguoigiaonhan"));
                if (!isNull("VesselCode", reader)) vesselCode = reader.GetString(reader.GetOrdinal("VesselCode"));
                if (!isNull("TransportRouteCode", reader)) transportRouteCode = reader.GetString(reader.GetOrdinal("TransportRouteCode"));
                if (!isNull("Dotnhap", reader)) dotnhap = reader.GetInt32(reader.GetOrdinal("Dotnhap"));
                if (!isNull("DonviTC", reader)) donviTC = reader.GetString(reader.GetOrdinal("DonviTC"));
                if (!isNull("PTTC", reader)) pTTC = reader.GetString(reader.GetOrdinal("PTTC"));
                if (!isNull("TCRouteCode", reader)) tCRouteCode = reader.GetString(reader.GetOrdinal("TCRouteCode"));

                if (!isNull("VCType", reader)) vCType = reader.GetString(reader.GetOrdinal("VCType"));
                if (!isNull("TCType", reader)) tCType = reader.GetString(reader.GetOrdinal("TCType"));
                if (!isNull("VCItemType", reader)) vCItemType = reader.GetString(reader.GetOrdinal("VCItemType"));

                if (!isNull("DepartmentDescription", reader)) departmentDescription = reader.GetString(reader.GetOrdinal("DepartmentDescription"));
                try
                {
                    if (!isNull("AccountTransactionID", reader)) accountTrasactionID = reader.GetGuid(reader.GetOrdinal("AccountTransactionID"));
                }
                catch
                { }

                //if (!isNull("GetByCanme", reader)) getByCanme = reader.GetBoolean(reader.GetOrdinal("GetByCanme"));
                //if (!isNull("CanmeStartDate", reader)) canmeStartDate = reader.GetDateTime(reader.GetOrdinal("CanmeStartDate"));
                //if (!isNull("CanmeEndDate", reader)) canmeEndDate = reader.GetDateTime(reader.GetOrdinal("CanmeEndDate"));
                if (!isNull("CanmeNo", reader)) canmeNo = reader.GetString(reader.GetOrdinal("CanmeNo"));
            }
            base.FromDataReader(reader);
        }
        public void ExtendFromDataReader(IDataReader reader)
        {
            if (!isNull("ItemName", reader)) itemName = reader.GetString(reader.GetOrdinal("ItemName"));
            if (!isNull("SumQuantity", reader)) sumQuantity = reader.GetDecimal(reader.GetOrdinal("SumQuantity"));
        }
        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("TransactionID")) _TransactionID = (Guid)row["TransactionID"];
            if (!row.IsNull("TransactionTypeCode")) _TransactionTypeCode = (string)row["TransactionTypeCode"];
            if (!row.IsNull("InStock")) _InStock = (string)row["InStock"];
            if (!row.IsNull("OutStock")) _OutStock = (string)row["OutStock"];
            if (!row.IsNull("TransactionNo")) _TransactionNo = (string)row["TransactionNo"];
            if (!row.IsNull("TransactionDate")) _TransactionDate = (DateTime)row["TransactionDate"];
            if (!row.IsNull("Description")) _Description = (string)row["Description"];
            if (!row.IsNull("Shift")) _Shift = (byte)row["Shift"];
            if (!row.IsNull("GetByWeightItems")) _GetByWeightItems = (bool)row["GetByWeightItems"];
            if (!row.IsNull("ForDepartment")) _ForDepartment = (byte)row["ForDepartment"];
            if (!row.IsNull("Status")) _Status = (byte)row["Status"];
            if (!row.IsNull("DepartmentStatus")) _DepartmentStatus = (byte)row["DepartmentStatus"];
            if (!row.IsNull("CreatedType")) _CreatedType = (byte)row["CreatedType"];
            if (!row.IsNull("GenType")) _GenType = (byte)row["GenType"];
            if (!row.IsNull("GenID")) _GenID = (Guid)row["GenID"];
            if (!row.IsNull("KhoGiaoNhan")) _KhoGiaoNhan = (string)row["KhoGiaoNhan"];
            if (!row.IsNull("DVGiao")) _DVGiao = (string)row["DVGiao"];
            if (!row.IsNull("SoHD")) _SoHD = (string)row["SoHD"];
            if (!row.IsNull("DVNhan")) _DVNhan = (string)row["DVNhan"];
            if (!row.IsNull("SoDH")) _SoDH = (string)row["SoDH"];
            if (!row.IsNull("DonviVC")) _DonviVC = (string)row["DonviVC"];
            if (!row.IsNull("PTVC")) _PTVC = (string)row["PTVC"];
            if (!row.IsNull("CTKemtheo")) _CTKemTheo = (string)row["CTKemtheo"];
            if (!row.IsNull("SoHoaDon")) _SoHoaDon = (string)row["SoHoaDon"];
            if (!row.IsNull("Nguoigiaonhan")) nguoiGiaoNhan = (string)row["Nguoigiaonhan"];
            if (!row.IsNull("GetByWeightItemContainer")) getByWeightItemContainer = (bool)row["GetByWeightItemContainer"];
            if (!row.IsNull("VesselCode")) vesselCode = (string)row["VesselCode"];
            if (!row.IsNull("TransportRouteCode")) transportRouteCode = (string)row["TransportRouteCode"];
            if (!row.IsNull("Dotnhap")) dotnhap = (int)row["Dotnhap"];
            if (!row.IsNull("DonviTC")) donviTC = (string)row["DonviTC"];
            if (!row.IsNull("PTTC")) pTTC = (string)row["PTTC"];
            if (!row.IsNull("TCRouteCode")) tCRouteCode = (string)row["TCRouteCode"];

            if (!row.IsNull("DepartmentDescription")) departmentDescription = (string)row["DepartmentDescription"];
            if (row.Table.Columns.Contains("AccountTransactionID"))
                if (!row.IsNull("AccountTransactionID")) accountTrasactionID = (Guid)row["AccountTransactionID"];

            if (!row.IsNull("VCType")) vCType = (string)row["VCType"];
            if (!row.IsNull("TCType")) tCType = (string)row["TCType"];
            if (!row.IsNull("VCItemType")) vCItemType = (string)row["VCItemType"];

            //if (!row.IsNull("GetByCanme")) getByCanme = (bool)row["GetByCanme"];
            //if (!row.IsNull("CanmeStartDate")) canmeStartDate = (DateTime)row["CanmeStartDate"];
            //if (!row.IsNull("CanmeEndDate")) canmeEndDate = (DateTime)row["CanmeEndDate"];
            if (!row.IsNull("CanmeNo")) canmeNo = (string)row["CanmeNo"];
        }
        private ListBase<WeightItemContainer> lstWICCheck = null;
        public ListBase<WeightItemContainer> LstWICCheck
        {
            get { return lstWICCheck; }
            set { lstWICCheck = value; }
        }
        #region Public Properties
        private Guid accountTrasactionID;
        public Guid AccountTransactionID
        {
            get { return accountTrasactionID; }
            set 
            { 
                accountTrasactionID = value;
               // this.IsAccounted= this.accountTrasactionID != null && this.accountTrasactionID != Guid.Empty;
            }
        }
        protected Guid _TransactionID;
        public Guid TransactionID
        {
            get { return _TransactionID;}
            set { _TransactionID = value; }
        }
        protected string _TransactionTypeCode;
        public string TransactionTypeCode
        {
            get { return _TransactionTypeCode; }
            set { _TransactionTypeCode = value; }
        }
        protected string _InStock=string.Empty;
        public string InStock
        {
            get { return _InStock; }
            set { _InStock = value; }
        }
        protected string _OutStock=string.Empty;
        public string OutStock
        {
            get { return _OutStock; }
            set { _OutStock = value; }
        }
        protected string _TransactionNo;
        public string TransactionNo
        {
            get { return _TransactionNo; }
            set { _TransactionNo = value;}
        }
        protected DateTime _TransactionDate = Contexts.WorkingDate;
        public DateTime TransactionDate
        {
            get { return _TransactionDate; }
            set { _TransactionDate = value; }
        }
        protected string _Description;
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        protected byte _Shift=1;
        public byte Shift
        {
            get { return _Shift; }
            set { _Shift = value; }
        }
      
        protected bool _GetByWeightItems=false;
        public bool GetByWeightItems
        {
            get { return _GetByWeightItems; }
            set { _GetByWeightItems = value; }
        }
        private bool getByWeightItemContainer = false;
        public bool GetByWeightItemContainer
        {
            get { return getByWeightItemContainer; }
            set { getByWeightItemContainer = value; }
        }

        protected string canmeNo = string.Empty;
        public string CanmeNo
        {
            get { return canmeNo; }
            set { canmeNo = value; }
        }
        public bool GetByCanme
        {
            get { return canmeNo != string.Empty; }
            //set { getByCanme = value; }
        }

        
        protected byte _ForDepartment = (byte)enumStockTransactionForDepartment.DefaultValue;
        public byte ForDepartment
        {
            get { return _ForDepartment; }
            set { _ForDepartment = value; }
        }
        protected byte _GenType = (byte)enumStockTransactionGenType.DefaultValue;
        public byte GenType
        {
            get { return _GenType; }
            set { _GenType = value; }
        }

        protected byte _Status = (byte)enumStockTransactionStatus.Confirm;
        public byte Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        protected byte _DepartmentStatus=(byte)enumStockTransactionDepartmentStatus.WaittingConfirm;
        public byte DepartmentStatus
        {
            get { return _DepartmentStatus; }
            set { _DepartmentStatus = value; }
        }
        protected byte _CreatedType;
        public byte CreatedType
        {
            get { return _CreatedType; }
            set { _CreatedType = value; }
        }
        public bool IsAuto
        {
            get { return (_CreatedType != 0); }
        }
        protected Guid _GenID;
        public Guid GenID
        {
            get { return _GenID; }
            set { _GenID = value; }
        }
        protected string _KhoGiaoNhan = string.Empty;
        public string KhoGiaoNhan
        {
            get { return _KhoGiaoNhan; }
            set 
            { 
                _KhoGiaoNhan = value;
                if (value == null) _KhoGiaoNhan = string.Empty;
            }
        }
        protected string _DVGiao = string.Empty;
        /// <summary>
        /// Đơn vị giao
        /// </summary>
        public string DVGiao
        {
            get { return _DVGiao; }
            set 
            { 
                _DVGiao = value;
                if (value == null) _DVGiao = string.Empty;
            }
        }
        protected string _SoHD=string.Empty;
        /// <summary>
        /// Số hợp đồng
        /// </summary>
        public string SoHD
        {
            get { return _SoHD; }
            set { _SoHD = value; }
        }
        protected string _DVNhan = string.Empty;
        /// <summary>
        /// Đơn vị nhận
        /// </summary>
        public string DVNhan
        {
            get { return _DVNhan; }
            set
            { 
                _DVNhan = value;
                if (value == null) _DVNhan = string.Empty;
            }
        }
        protected string _SoDH=string.Empty;
        /// <summary>
        /// Số đơn hàng
        /// </summary>
        public string SoDH
        {
            get { return _SoDH; }
            set { _SoDH = value; }
        }
        protected string _DonviVC = string.Empty;
        /// <summary>
        /// Đơn vị vận chuyển
        /// </summary>
        public string DonviVC
        {
            get { return _DonviVC; }
            set 
            { 
                _DonviVC = value;
                if (value == null) _DonviVC = string.Empty;
            }
        }
        protected string _PTVC = string.Empty;
        /// <summary>
        /// Phương tiện vận chuyển
        /// </summary>
        public string PTVC
        {
            get { return _PTVC; }
            set { _PTVC = value; }
        }
        protected string _CTKemTheo = string.Empty;
        /// <summary>
        /// Chứng từ kèm theo
        /// </summary>
        public string CTKemTheo
        {
            get { return _CTKemTheo; }
            set { _CTKemTheo = value; }
        }
        protected string _SoHoaDon = string.Empty;
        public string SoHoaDon
        {
            get { return _SoHoaDon; }
            set { _SoHoaDon = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        private string nguoiGiaoNhan=string.Empty;
        public string NguoiGiaoNhan
        {
            get { return nguoiGiaoNhan; }
            set { nguoiGiaoNhan = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        private string vesselCode = string.Empty;
        public string VesselCode
        {
            get { return vesselCode; }
            set { vesselCode = value; }
        }

        private string transportRouteCode = string.Empty;
        public string TransportRouteCode
        {
            get { return transportRouteCode; }
            set { transportRouteCode = value; }
        }

        private int dotnhap = 1;
        public int Dotnhap
        {
            get { return dotnhap; }
            set { dotnhap = value; }
        }

        protected string donviTC = string.Empty;
        /// <summary>
        /// Đơn vị trung chuyển
        /// </summary>
        public string DonviTC
        {
            get { return donviTC; }
            set
            {
                donviTC = value;
                if (value == null) donviTC = string.Empty;
            }
        }
        protected string pTTC = string.Empty;
        /// <summary>
        /// Phương tiện trung chuyển
        /// </summary>
        public string PTTC
        {
            get { return pTTC; }
            set { pTTC = value; }
        }

        private string tCRouteCode = string.Empty;
        public string TCRouteCode
        {
            get { return tCRouteCode; }
            set { tCRouteCode = value; }
        }

        private string departmentDescription = string.Empty;
        public string DepartmentDescription
        {
            get { return departmentDescription; }
            set { departmentDescription = value; }
        }

        private ListBase<StockTransactionSumDetail> details;
        public ListBase<StockTransactionSumDetail> Details
        {
            get { return details; }
            set { details = value; }
        }
        private SaleRequests saleRequestObj;
        /// <summary>
        /// 
        /// </summary>
        public SaleRequests SaleRequestObj
        {
            get { return saleRequestObj; }
            set { saleRequestObj = value; }
        }
        //private bool isAccounted;
        /// <summary>
        /// 
        /// </summary>
        public bool IsAccounted 
        {
            get 
            { return this.accountTrasactionID != null && this.accountTrasactionID != Guid.Empty; }
        }

        //private ListBase<StockTransactionPurchaseDetail> listPurchaseDetail;
        //public ListBase<StockTransactionPurchaseDetail> ListPurchaseDetail
        //{
        //    get { return listPurchaseDetail; }
        //    set { listPurchaseDetail = value; }
        //}
        #endregion

        public decimal GetSumQuantity()
        {
            decimal sum = 0;
            if (this.details!=null)
                foreach (StockTransactionSumDetail d in this.details)
                    sum += d.Quantity;
            return sum;
        }
        private decimal sumQuantity;

        public decimal SumQuantity
        {
            get
            {
                if (sumQuantity == 0)
                    sumQuantity = this.GetSumQuantity();
                return sumQuantity;
            }
            set { sumQuantity = value; }
        }

        private string itemName = string.Empty;

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }

        private string vCType = string.Empty;

        public string VCType
        {
            get { return vCType; }
            set { vCType = value; }
        }
        private string tCType = string.Empty;

        public string TCType
        {
            get { return tCType; }
            set { tCType = value; }
        }
        private string vCItemType = string.Empty;

        public string VCItemType
        {
            get { return vCItemType; }
            set { vCItemType = value; }
        }

        #region WS
        private Customer objCustomer;

        public Customer ObjCustomer
        {
            get { return objCustomer; }
            set { objCustomer = value; }
        }

        private Vendor objTransport;

        public Vendor ObjTransport
        {
            get { return objTransport; }
            set { objTransport = value; }
        }

        private decimal quantity;

        public decimal Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public decimal SLBao
        {
            get { return details[0].WrappingCounter; }
        }
        public ListBase<StockTransactionDetail> ListDetail
        {
            get { return details[0].lstStockTransactionDetail; }
        }

        private Vendor objVendor;

        public Vendor ObjVendor
        {
            get { return objVendor; }
            set { objVendor = value; }
        }

        private string tobocdo = string.Empty;

        public string Tobocdo
        {
            get { return tobocdo; }
            set { tobocdo = value; }
        }

        private string cobao = "50kg";

        public string Cobao
        {
            get { return cobao; }
            set { cobao = value; }
        }

        private string silochua = string.Empty;

        public string Silochua
        {
            get { return silochua; }
            set { silochua = value; }
        }

        public string CustomerName
        {
            get { return objCustomer.SubjectName; }
        }
        public string CustomerAddress
        {
            get { return objCustomer.Address; }
        }
        public string CustomerPhone
        {
            get { return objCustomer.Phone; }
        }
        public string CustomerBAPNo
        {
            get { return objCustomer.BAPNo; }
        }

        public string TransportName
        {
            get { return objTransport.SubjectName; }
        }
        public string TransportAddress
        {
            get { return objTransport.Address; }
        }
        public string TransportPhone
        {
            get { return objTransport.Phone; }
        }
        public string VendorName
        {
            get { return objVendor.SubjectName; }
        }
        public string VendorAddress
        {
            get { return objVendor.Address; }
        }
        public string VendorPhone
        {
            get { return objVendor.Phone; }
        }
        #endregion
    }
    //public enum enumManufactureGenType {NullValue=0, OutMaterial, OutFuel, InProduct, InWaste }
//    public enum enumStatus{ WaitingConfirm = 0, Confirm, WaitingReConfirm}
    #region StockTransactionPurchaseDetail
    /// <summary>
    /// This object represents the properties and methods of a StockTransactionPurchaseDetail.
    /// </summary>
    public class StockTransactionPurchaseDetail : BaseClass
    {


        public StockTransactionPurchaseDetail()
        {
        }

        public StockTransactionPurchaseDetail(IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public StockTransactionPurchaseDetail(DataRow row)
        {
            this.FromDataRow(row);
        }

        //public override void CopyFrom(object obj)
        //{
        //    base.CopyFrom(obj);

        //    transactionID = (obj as StockTransactionPurchaseDetail).transactionID;
        //    itemCode = (obj as StockTransactionPurchaseDetail).itemCode;
        //    quantity = (obj as StockTransactionPurchaseDetail).quantity;
        //    price = (obj as StockTransactionPurchaseDetail).price;
        //    amount = (obj as StockTransactionPurchaseDetail).amount;
        //    pONo = (obj as StockTransactionPurchaseDetail).pONo;

        //}

        public override void FromDataReader(IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("TransactionID", reader)) transactionID = reader.GetGuid(reader.GetOrdinal("TransactionID"));
                if (!isNull("ItemCode", reader)) itemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
                if (!isNull("Quantity", reader)) quantity = reader.GetDecimal(reader.GetOrdinal("Quantity"));
                if (!isNull("Price", reader)) price = reader.GetDecimal(reader.GetOrdinal("Price"));
                if (!isNull("Amount", reader)) amount = reader.GetDecimal(reader.GetOrdinal("Amount"));
                if (!isNull("PONo", reader)) pONo = reader.GetString(reader.GetOrdinal("PONo"));
                if (!isNull("WrappingCounter", reader)) wrappingCounter = reader.GetInt32(reader.GetOrdinal("WrappingCounter"));
            }
        }

        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("TransactionID")) transactionID = (Guid)row["TransactionID"];
            if (!row.IsNull("ItemCode")) itemCode = (string)row["ItemCode"];
            if (!row.IsNull("Quantity")) quantity = (decimal)row["Quantity"];
            if (!row.IsNull("Price")) price = (decimal)row["Price"];
            if (!row.IsNull("Amount")) amount = (decimal)row["Amount"];
            if (!row.IsNull("PONo")) pONo = (string)row["PONo"];
            if (!row.IsNull("WrappingCounter")) wrappingCounter = (int)row["WrappingCounter"];
        }

        #region Public Properties



        private Guid transactionID = Guid.Empty;
        /// <summary>
        /// Gets or sets the value of TransactionID
        /// </summary>
        public Guid TransactionID
        {
            get { return transactionID; }
            set { transactionID = value; }
        }

        private string itemCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of ItemCode
        /// </summary>
        public string ItemCode
        {
            get { return itemCode; }
            set { itemCode = value; }
        }

        private decimal quantity;
        /// <summary>
        /// Gets or sets the value of Quantity
        /// </summary>
        public decimal Quantity
        {
            get { return quantity; }
            set
            {
                quantity = value;
                amount = price * quantity;
            }
        }

        private decimal price;
        /// <summary>
        /// Gets or sets the value of Price
        /// </summary>
        public decimal Price
        {
            get { return price; }
            set
            {
                price = value;
                amount = price * quantity;
            }
        }

        private decimal amount;
        /// <summary>
        /// Gets or sets the value of Amount
        /// </summary>
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        private string pONo = String.Empty;
        /// <summary>
        /// Gets or sets the value of PONo
        /// </summary>
        public string PONo
        {
            get { return pONo; }
            set { pONo = value; }
        }

        private int wrappingCounter;
        public int WrappingCounter
        {
            get { return wrappingCounter; }
            set { wrappingCounter = value; }
        }
        #endregion

        #region Lists
        #endregion


    }
    #endregion
}

