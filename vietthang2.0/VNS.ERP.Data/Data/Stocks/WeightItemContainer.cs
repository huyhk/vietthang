using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data
{
    public class WeightItemContainer : UserTracking2
    {
        public WeightItemContainer() { }
        public WeightItemContainer(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public void CopyFrom(object obj)
        {
            //base.CopyFrom(obj);

            weightContainerID = (obj as WeightItemContainer).weightContainerID;
            copyFromID = (obj as WeightItemContainer).copyFromID;
            stockCode = (obj as WeightItemContainer).stockCode;
            itemCode = (obj as WeightItemContainer).itemCode;
            weightCode = (obj as WeightItemContainer).weightCode;
            employeeID = (obj as WeightItemContainer).employeeID;
            transactionID = (obj as WeightItemContainer).transactionID;
            weightDate = (obj as WeightItemContainer).weightDate;
            isReceive = (obj as WeightItemContainer).isReceive;
            description = (obj as WeightItemContainer).description;
            quantity = (obj as WeightItemContainer).quantity;
            wrappingWeight = (obj as WeightItemContainer).wrappingWeight;
            wrappingType = (obj as WeightItemContainer).wrappingType;
            itemWeight = (obj as WeightItemContainer).itemWeight;
            pTVanChuyen = (obj as WeightItemContainer).pTVanChuyen;
            pTTrungChuyen = (obj as WeightItemContainer).pTTrungChuyen;
            dVVanChuyen = (obj as WeightItemContainer).dVVanChuyen;
            transactionTypeCode = (obj as WeightItemContainer).transactionTypeCode;
            khoGiaoNhan = (obj as WeightItemContainer).khoGiaoNhan;
            dVGiao = (obj as WeightItemContainer).dVGiao;
            dVNhan = (obj as WeightItemContainer).dVNhan;
            weight1 = (obj as WeightItemContainer).weight1;
            weightTime1 = (obj as WeightItemContainer).weightTime1;
            weight2 = (obj as WeightItemContainer).weight2;
            weightTime2 = (obj as WeightItemContainer).weightTime2;
            stockLocationCode = (obj as WeightItemContainer).stockLocationCode;
            stockLocationCode2 = (obj as WeightItemContainer).stockLocationCode2;
            isAuto = (obj as WeightItemContainer).isAuto;

            palletWeight = (obj as WeightItemContainer).palletWeight;

            luot = (obj as WeightItemContainer).luot;
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("WeightContainerID", reader)) weightContainerID = reader.GetGuid(reader.GetOrdinal("WeightContainerID"));
            if (!isNull("StockCode", reader)) stockCode = reader.GetString(reader.GetOrdinal("StockCode"));
            if (!isNull("ItemCode", reader)) itemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
            if (!isNull("WeightCode", reader)) weightCode = reader.GetString(reader.GetOrdinal("WeightCode"));
            if (!isNull("EmployeeID", reader)) employeeID = reader.GetString(reader.GetOrdinal("EmployeeID"));
            if (!isNull("TransactionID", reader)) transactionID = reader.GetGuid(reader.GetOrdinal("TransactionID"));
            if (!isNull("WeightDate", reader)) weightDate = reader.GetDateTime(reader.GetOrdinal("WeightDate"));
            if (!isNull("IsReceive", reader)) isReceive = reader.GetBoolean(reader.GetOrdinal("IsReceive"));
            if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            if (!isNull("Quantity", reader)) quantity = reader.GetDecimal(reader.GetOrdinal("Quantity"));
            if (!isNull("WrappingWeight", reader)) wrappingWeight = reader.GetDecimal(reader.GetOrdinal("WrappingWeight"));
            if (!isNull("WrappingType", reader)) wrappingType = reader.GetString(reader.GetOrdinal("WrappingType"));
            if (!isNull("ItemWeight", reader)) itemWeight = reader.GetDecimal(reader.GetOrdinal("ItemWeight"));
            if (!isNull("PTVanChuyen", reader)) pTVanChuyen = reader.GetString(reader.GetOrdinal("PTVanChuyen"));
            if (!isNull("PTTrungChuyen", reader)) pTTrungChuyen = reader.GetString(reader.GetOrdinal("PTTrungChuyen"));
            if (!isNull("DVVanChuyen", reader)) dVVanChuyen = reader.GetString(reader.GetOrdinal("DVVanChuyen"));
            if (!isNull("TransactionTypeCode", reader)) transactionTypeCode = reader.GetString(reader.GetOrdinal("TransactionTypeCode"));
            if (!isNull("KhoGiaoNhan", reader)) khoGiaoNhan = reader.GetString(reader.GetOrdinal("KhoGiaoNhan"));
            if (!isNull("DVGiao", reader)) dVGiao = reader.GetString(reader.GetOrdinal("DVGiao"));
            if (!isNull("DVNhan", reader)) dVNhan = reader.GetString(reader.GetOrdinal("DVNhan"));
            if (!isNull("Weight1", reader)) weight1 = reader.GetDecimal(reader.GetOrdinal("Weight1"));
            if (!isNull("Weight2", reader)) weight2 = reader.GetDecimal(reader.GetOrdinal("Weight2"));
            if (!isNull("WeightTime1", reader)) weightTime1 = reader.GetDateTime(reader.GetOrdinal("WeightTime1"));
            if (!isNull("WeightTime2", reader)) weightTime2 = reader.GetDateTime(reader.GetOrdinal("WeightTime2"));
            if (!isNull("StockLocationCode", reader)) stockLocationCode = reader.GetString(reader.GetOrdinal("StockLocationCode"));
            if (!isNull("StockLocationCode2", reader)) stockLocationCode2 = reader.GetString(reader.GetOrdinal("StockLocationCode2"));

            if (!isNull("CopyFromID", reader)) copyFromID = reader.GetGuid(reader.GetOrdinal("CopyFromID"));
            if (!isNull("IsAuto", reader)) isAuto = reader.GetBoolean(reader.GetOrdinal("IsAuto"));

            if (!isNull("PalletWeight", reader)) palletWeight = reader.GetDecimal(reader.GetOrdinal("PalletWeight"));
            if (!isNull("Luot", reader)) luot = reader.GetInt32(reader.GetOrdinal("Luot"));
            //CalWeight();
        }
        private Guid weightContainerID;
        public Guid WeightContainerID
        {
            get { return weightContainerID; }
            set { weightContainerID = value; }
        }
        private Guid copyFromID;
        public Guid CopyFromID
        {
            get { return copyFromID; }
            set { copyFromID = value; }
        }
        private string stockCode=string.Empty;
        public string StockCode
        {
            get { return stockCode; }
            set { stockCode = value; }
        }
        private string itemCode=string.Empty;
        public string ItemCode
        {
            get { return itemCode; }
            set { itemCode = value; }
        }
        private string weightCode=string.Empty;
        public string WeightCode
        {
            get { return weightCode; }
            set { weightCode = value; }
        }
        private string employeeID=string.Empty;
        public string EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }
        private Guid transactionID = Guid.Empty;
        public Guid TransactionID
        {
            get { return transactionID; }
            set { transactionID = value; }
        }
        public bool IsSelected
        {
            get { return transactionID != Guid.Empty; }
        }
        private DateTime weightDate = Contexts.WorkingDate;
        public DateTime WeightDate
        {
            get { return weightDate; }
            set { weightDate = value; }
        }
        private bool isReceive=true;
        public bool IsReceive
        {
            get { return isReceive; }
            set { isReceive = value; }
        }
        private string description=string.Empty;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private decimal quantity=0;
        public decimal Quantity
        {
            get { return quantity; }
            set
            {
                quantity = value;
                CalWeight();
            }
        }
        private decimal wrappingWeight = 0;
        public decimal WrappingWeight
        {
            get { return wrappingWeight; }
            set
            {
                wrappingWeight = value;
                CalWeight();

            }
        }
        public decimal TotalWrappingWeight
        {
            get { return Math.Round(this.quantity * this.wrappingWeight, 0); }

            //get { return Math.Round(401.0M * this.wrappingWeight); }
        }

        private decimal palletWeight = 0;
        public decimal PalletWeight
        {
            get { return palletWeight; }
            set
            {
                palletWeight = value;
                CalWeight();
            }
        }

        private string wrappingType = string.Empty;
        public string WrappingType
        {
            get { return wrappingType; }
            set { wrappingType = value; }
        }
        private decimal itemWeight = 0;
        public decimal ItemWeight
        {
            get { return itemWeight; }
            //set { itemWeight = value; }
        }
        private string pTVanChuyen = string.Empty;
        public string PTVanChuyen
        {
            get { return pTVanChuyen; }
            set { pTVanChuyen = value; }
        }
        private string pTTrungChuyen=string.Empty;
        public string PTTrungChuyen
        {
            get { return pTTrungChuyen; }
            set { pTTrungChuyen = value; }
        }
        private string dVVanChuyen=string.Empty;
        public string DVVanChuyen
        {
            get { return dVVanChuyen; }
            set { dVVanChuyen = value; }
        }
        private string transactionTypeCode=string.Empty;
        public string TransactionTypeCode
        {
            get { return transactionTypeCode; }
            set { transactionTypeCode = value; }
        }
        private string khoGiaoNhan=string.Empty;
        public string KhoGiaoNhan
        {
            get { return khoGiaoNhan; }
            set { khoGiaoNhan = value; }
        }
        private string dVGiao=string.Empty;
        public string DVGiao
        {
            get { return dVGiao; }
            set { dVGiao = value; }
        }
        private string dVNhan=string.Empty;
        public string DVNhan
        {
            get { return dVNhan; }
            set { dVNhan = value; }
        }
        private decimal weight1=0;
        public decimal Weight1
        {
            get { return weight1; }
            set 
            { 
                weight1 = value;
                CalWeight();
            }
        }
        public decimal KLChuabi
        { get { return Math.Abs(this.weight1 - this.weight2); } }
        private decimal weight2=0;
        public decimal Weight2
        {
            get { return weight2; }
            set 
            { 
                weight2 = value;
                CalWeight();
            }
        }
        private DateTime weightTime1 = DateTime.Now;
        public DateTime WeightTime1
        {
            get { return weightTime1; }
            set { weightTime1 = value; }
        }
        public TimeSpan WeightTime1T
        {
            get { return WeightTime1.TimeOfDay; }
        }
        private DateTime weightTime2 = DateTime.Now;
        public DateTime WeightTime2
        {
            get { return weightTime2; }
            set { weightTime2 = value; }
        }
        public TimeSpan WeightTime2T
        {
            get { return WeightTime2.TimeOfDay; }
        }
        private string stockLocationCode = string.Empty;
        public string StockLocationCode
        {
            get { return stockLocationCode; }
            set { stockLocationCode = value; }
        }
        private string stockLocationCode2 = string.Empty;
        public string StockLocationCode2
        {
            get { return stockLocationCode2; }
            set { stockLocationCode2 = value; }
        }
        private bool isAuto = false;
        public bool IsAuto
        {
            get { return isAuto; }
            set { isAuto = value; }
        }
        private int stt;
        public int Stt
        {
            get { return stt; }
            set { stt = value; }
        }
        public string Soxe
        {
            get { return pTTrungChuyen == "" ? pTVanChuyen : pTTrungChuyen; }
        }

        public string Khachhang
        {
            get 
            {
                if (dVGiao != "")
                    return dVGiao;
                else if (dVNhan != "")
                    return dVNhan;
                else
                    return khoGiaoNhan;
                return "";
            }
        }
        public void CalWeight()
        {
            this.itemWeight = Math.Abs(Math.Round(this.weight1,0) - Math.Round(this.weight2)) - this.TotalWrappingWeight - this.palletWeight;
        }

        private int luot;
        public int Luot
        {
            get { return luot; }
            set { luot = value; }
        }
    }
}
