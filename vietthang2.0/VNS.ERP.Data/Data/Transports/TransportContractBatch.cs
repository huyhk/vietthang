using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
using VNS.ERP.Data.Transports;
namespace VNS.ERP.Data
{
    #region TransportContractBatch
    /// <summary>
    /// This object represents the properties and methods of a TransportContractBatch.
    /// </summary>
    public class TransportContractBatch : UserTracking2
    {


        public TransportContractBatch()
        {
        }

        public TransportContractBatch(IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public TransportContractBatch(DataRow row)
        {
            this.FromDataRow(row);
        }

        //public override void CopyFrom(object obj)
        //{
        //    base.CopyFrom(obj);

        //    contractID = (obj as TransportContractBatch).contractID;
        //    batchID = (obj as TransportContractBatch).batchID;
        //    billNo = (obj as TransportContractBatch).billNo;
        //    itemCode = (obj as TransportContractBatch).itemCode;
        //    contQuantity = (obj as TransportContractBatch).contQuantity;
        //    contDes = (obj as TransportContractBatch).contDes;
        //    donViGN = (obj as TransportContractBatch).donViGN;
        //    tokhaiHQNo = (obj as TransportContractBatch).tokhaiHQNo;
        //    portName = (obj as TransportContractBatch).portName;
        //    vendorCode = (obj as TransportContractBatch).vendorCode;
        //    hangtau = (obj as TransportContractBatch).hangtau;
        //    noigiaohang = (obj as TransportContractBatch).noigiaohang;
        //    thongbaotauden = (obj as TransportContractBatch).thongbaotauden;
        //    nhanBCTtuBank = (obj as TransportContractBatch).nhanBCTtuBank;
        //    giaoBCTchoDV = (obj as TransportContractBatch).giaoBCTchoDV;
        //    motokhaiHQ = (obj as TransportContractBatch).motokhaiHQ;
        //    batdaunhanCont = (obj as TransportContractBatch).batdaunhanCont;
        //    ketthucnhanCont = (obj as TransportContractBatch).ketthucnhanCont;
        //    hethanluuConttaibai = (obj as TransportContractBatch).hethanluuConttaibai;
        //    hethanluubai = (obj as TransportContractBatch).hethanluubai;
        //    hethanluukhorieng = (obj as TransportContractBatch).hethanluukhorieng;
        //    ngaydangtainhamay = (obj as TransportContractBatch).ngaydangtainhamay;
        //    ngaynhapxong = (obj as TransportContractBatch).ngaynhapxong;
        //    ngaytrarong = (obj as TransportContractBatch).ngaytrarong;
        //    sobao = (obj as TransportContractBatch).sobao;
        //    soluongBLNet = (obj as TransportContractBatch).soluongBLNet;
        //    giakhaiHQ = (obj as TransportContractBatch).giakhaiHQ;
        //    tygiaNH = (obj as TransportContractBatch).tygiaNH;

        //}

        public override void FromDataReader(IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("ContractID", reader)) contractID = reader.GetGuid(reader.GetOrdinal("ContractID"));
                if (!isNull("BatchID", reader)) batchID = reader.GetGuid(reader.GetOrdinal("BatchID"));
                if (!isNull("BillNo", reader)) billNo = reader.GetString(reader.GetOrdinal("BillNo"));
                if (!isNull("ItemCode", reader)) itemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
                if (!isNull("ContQuantity", reader)) contQuantity = reader.GetInt32(reader.GetOrdinal("ContQuantity"));
                if (!isNull("ContDes", reader)) contDes = reader.GetString(reader.GetOrdinal("ContDes"));
                if (!isNull("DonViGN", reader)) donViGN = reader.GetString(reader.GetOrdinal("DonViGN"));
                if (!isNull("TokhaiHQNo", reader)) tokhaiHQNo = reader.GetString(reader.GetOrdinal("TokhaiHQNo"));
                if (!isNull("PortName", reader)) portName = reader.GetString(reader.GetOrdinal("PortName"));
                if (!isNull("VendorCode", reader)) vendorCode = reader.GetString(reader.GetOrdinal("VendorCode"));
                if (!isNull("Hangtau", reader)) hangtau = reader.GetString(reader.GetOrdinal("Hangtau"));
                if (!isNull("Noigiaohang", reader)) noigiaohang = reader.GetString(reader.GetOrdinal("Noigiaohang"));
                if (!isNull("Thongbaotauden", reader)) thongbaotauden = reader.GetDateTime(reader.GetOrdinal("Thongbaotauden"));
                if (!isNull("NhanBCTtuBank", reader)) nhanBCTtuBank = reader.GetDateTime(reader.GetOrdinal("NhanBCTtuBank"));
                if (!isNull("BCTvetoiBank", reader)) bCTvetoiBank = reader.GetDateTime(reader.GetOrdinal("BCTvetoiBank"));
                if (!isNull("BankgiaoBCT", reader)) bankgiaoBCT = reader.GetDateTime(reader.GetOrdinal("BankgiaoBCT"));
                if (!isNull("GiaoBCTchoDV", reader)) giaoBCTchoDV = reader.GetDateTime(reader.GetOrdinal("GiaoBCTchoDV"));
                if (!isNull("MotokhaiHQ", reader)) motokhaiHQ = reader.GetDateTime(reader.GetOrdinal("MotokhaiHQ"));
                if (!isNull("BatdaunhanCont", reader)) batdaunhanCont = reader.GetDateTime(reader.GetOrdinal("BatdaunhanCont"));
                if (!isNull("KetthucnhanCont", reader)) ketthucnhanCont = reader.GetDateTime(reader.GetOrdinal("KetthucnhanCont"));
                if (!isNull("HethanluuConttaibai", reader)) hethanluuConttaibai = reader.GetDateTime(reader.GetOrdinal("HethanluuConttaibai"));
                if (!isNull("Hethanluubai", reader)) hethanluubai = reader.GetDateTime(reader.GetOrdinal("Hethanluubai"));
                if (!isNull("Hethanluukhorieng", reader)) hethanluukhorieng = reader.GetDateTime(reader.GetOrdinal("Hethanluukhorieng"));
                if (!isNull("Ngaydangtainhamay", reader)) ngaydangtainhamay = reader.GetDateTime(reader.GetOrdinal("Ngaydangtainhamay"));
                if (!isNull("Ngaynhapxong", reader)) ngaynhapxong = reader.GetDateTime(reader.GetOrdinal("Ngaynhapxong"));
                if (!isNull("Ngaytrarong", reader)) ngaytrarong = reader.GetDateTime(reader.GetOrdinal("Ngaytrarong"));
                if (!isNull("Sobao", reader)) sobao = reader.GetInt32(reader.GetOrdinal("Sobao"));
                if (!isNull("SoluongBLNet", reader)) soluongBLNet = reader.GetDecimal(reader.GetOrdinal("SoluongBLNet"));
                if (!isNull("GiakhaiHQ", reader)) giakhaiHQ = reader.GetDecimal(reader.GetOrdinal("GiakhaiHQ"));
                if (!isNull("TygiaNH", reader)) tygiaNH = reader.GetDecimal(reader.GetOrdinal("TygiaNH"));
                if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
                if (!isNull("PriceVC", reader)) priceVC = reader.GetDecimal(reader.GetOrdinal("PriceVC"));
                if (!isNull("PriceKQ", reader)) priceKQ = reader.GetDecimal(reader.GetOrdinal("PriceKQ"));
                if (!isNull("IsRutruot", reader)) isRutruot = reader.GetBoolean(reader.GetOrdinal("IsRutruot"));
            }
        }

        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("ContractID")) contractID = (Guid)row["ContractID"];
            if (!row.IsNull("BatchID")) batchID = (Guid)row["BatchID"];
            if (!row.IsNull("BillNo")) billNo = (string)row["BillNo"];
            if (!row.IsNull("ItemCode")) itemCode = (string)row["ItemCode"];
            if (!row.IsNull("ContQuantity")) contQuantity = (int)row["ContQuantity"];
            if (!row.IsNull("ContDes")) contDes = (string)row["ContDes"];
            if (!row.IsNull("DonViGN")) donViGN = (string)row["DonViGN"];
            if (!row.IsNull("TokhaiHQNo")) tokhaiHQNo = (string)row["TokhaiHQNo"];
            if (!row.IsNull("PortName")) portName = (string)row["PortName"];
            if (!row.IsNull("VendorCode")) vendorCode = (string)row["VendorCode"];
            if (!row.IsNull("Hangtau")) hangtau = (string)row["Hangtau"];
            if (!row.IsNull("Noigiaohang")) noigiaohang = (string)row["Noigiaohang"];
            if (!row.IsNull("Thongbaotauden")) thongbaotauden = (DateTime)row["Thongbaotauden"];
            if (!row.IsNull("NhanBCTtuBank")) nhanBCTtuBank = (DateTime)row["NhanBCTtuBank"];
            if (!row.IsNull("BCTvetoiBank")) bCTvetoiBank = (DateTime)row["BCTvetoiBank"];
            if (!row.IsNull("BankgiaoBCT")) bankgiaoBCT = (DateTime)row["BankgiaoBCT"];
            if (!row.IsNull("GiaoBCTchoDV")) giaoBCTchoDV = (DateTime)row["GiaoBCTchoDV"];
            if (!row.IsNull("MotokhaiHQ")) motokhaiHQ = (DateTime)row["MotokhaiHQ"];
            if (!row.IsNull("BatdaunhanCont")) batdaunhanCont = (DateTime)row["BatdaunhanCont"];
            if (!row.IsNull("KetthucnhanCont")) ketthucnhanCont = (DateTime)row["KetthucnhanCont"];
            if (!row.IsNull("HethanluuConttaibai")) hethanluuConttaibai = (DateTime)row["HethanluuConttaibai"];
            if (!row.IsNull("Hethanluubai")) hethanluubai = (DateTime)row["Hethanluubai"];
            if (!row.IsNull("Hethanluukhorieng")) hethanluukhorieng = (DateTime)row["Hethanluukhorieng"];
            if (!row.IsNull("Ngaydangtainhamay")) ngaydangtainhamay = (DateTime)row["Ngaydangtainhamay"];
            if (!row.IsNull("Ngaynhapxong")) ngaynhapxong = (DateTime)row["Ngaynhapxong"];
            if (!row.IsNull("Ngaytrarong")) ngaytrarong = (DateTime)row["Ngaytrarong"];
            if (!row.IsNull("Sobao")) sobao = (int)row["Sobao"];
            if (!row.IsNull("SoluongBLNet")) soluongBLNet = (decimal)row["SoluongBLNet"];
            if (!row.IsNull("GiakhaiHQ")) giakhaiHQ = (decimal)row["GiakhaiHQ"];
            if (!row.IsNull("TygiaNH")) tygiaNH = (decimal)row["TygiaNH"];
            if (!row.IsNull("Description")) description = (string)row["Description"];
            if (!row.IsNull("PriceVC")) priceVC = (decimal)row["PriceVC"];
            if (!row.IsNull("PriceKQ")) priceKQ = (decimal)row["PriceKQ"];
            if (!row.IsNull("IsRutruot")) isRutruot = (Boolean)row["IsRutruot"];
        }

        #region Public Properties



        private Guid contractID = Guid.Empty;
        /// <summary>
        /// Gets or sets the value of ContractID
        /// </summary>
        public Guid ContractID
        {
            get { return contractID; }
            set
            {
                contractID = value;
                //OnPropertyChanged("ContractID", value);
            }
        }

        private Guid batchID = Guid.NewGuid();
        /// <summary>
        /// Gets or sets the value of BatchID
        /// </summary>
        public Guid BatchID
        {
            get { return batchID; }
            set
            {
                batchID = value;
                //OnPropertyChanged("BatchID", value);
            }
        }

        private string billNo = String.Empty;
        /// <summary>
        /// Gets or sets the value of BillNo
        /// </summary>
        public string BillNo
        {
            get { return billNo; }
            set
            {
                billNo = value;
                //OnPropertyChanged("BillNo", value);
            }
        }

        private string itemCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of ItemCode
        /// </summary>
        public string ItemCode
        {
            get { return itemCode; }
            set
            {
                itemCode = value;
                //OnPropertyChanged("ItemCode", value);
            }
        }

        private int contQuantity;
        /// <summary>
        /// Gets or sets the value of ContQuantity
        /// </summary>
        public int ContQuantity
        {
            get { return contQuantity; }
            set
            {
                contQuantity = value;
                //OnPropertyChanged("ContQuantity", value);
            }
        }

        private string contDes = String.Empty;
        /// <summary>
        /// Gets or sets the value of ContDes
        /// </summary>
        public string ContDes
        {
            get { return contDes; }
            set
            {
                contDes = value;
                //OnPropertyChanged("ContDes", value);
            }
        }

        private string donViGN = String.Empty;
        /// <summary>
        /// Gets or sets the value of DonViGN
        /// </summary>
        public string DonViGN
        {
            get { return donViGN; }
            set
            {
                donViGN = value;
                //OnPropertyChanged("DonViGN", value);
            }
        }

        private string tokhaiHQNo = String.Empty;
        /// <summary>
        /// Gets or sets the value of TokhaiHQNo
        /// </summary>
        public string TokhaiHQNo
        {
            get { return tokhaiHQNo; }
            set
            {
                tokhaiHQNo = value;
                //OnPropertyChanged("TokhaiHQNo", value);
            }
        }

        private string portName = String.Empty;
        /// <summary>
        /// Gets or sets the value of PortName
        /// </summary>
        public string PortName
        {
            get { return portName; }
            set
            {
                portName = value;
                //OnPropertyChanged("PortName", value);
            }
        }

        private string vendorCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of VendorCode
        /// </summary>
        public string VendorCode
        {
            get { return vendorCode; }
            set
            {
                vendorCode = value;
                //OnPropertyChanged("VendorCode", value);
            }
        }

        private string hangtau = String.Empty;
        /// <summary>
        /// Gets or sets the value of Hangtau
        /// </summary>
        public string Hangtau
        {
            get { return hangtau; }
            set
            {
                hangtau = value;
                //OnPropertyChanged("Hangtau", value);
            }
        }

        private string noigiaohang = String.Empty;
        /// <summary>
        /// Gets or sets the value of Noigiaohang
        /// </summary>
        public string Noigiaohang
        {
            get { return noigiaohang; }
            set
            {
                noigiaohang = value;
                //OnPropertyChanged("Noigiaohang", value);
            }
        }

        public string BillGH
        {
            get { return billNo + " " + noigiaohang; }
        }
        private DateTime thongbaotauden = DateTime.Today;
        /// <summary>
        /// Gets or sets the value of Thongbaotauden
        /// </summary>
        public DateTime Thongbaotauden
        {
            get { return thongbaotauden; }
            set
            {
                thongbaotauden = value;
                //OnPropertyChanged("Thongbaotauden", value);
            }
        }

        private DateTime nhanBCTtuBank = DateTime.Today;
        /// <summary>
        /// Gets or sets the value of NhanBCTtuBank
        /// </summary>
        public DateTime NhanBCTtuBank
        {
            get { return nhanBCTtuBank; }
            set
            {
                nhanBCTtuBank = value;
                //OnPropertyChanged("NhanBCTtuBank", value);
            }
        }

        private DateTime bCTvetoiBank;// = DateTime.Today;
        /// <summary>
        /// Gets or sets the value of BCTvetoiBank
        /// </summary>
        public DateTime BCTvetoiBank
        {
            get { return bCTvetoiBank; }
            set
            {
                bCTvetoiBank = value;
                //OnPropertyChanged("NhanBCTtuBank", value);
            }
        }
        private DateTime bankgiaoBCT;// = DateTime.Today;
        /// <summary>
        /// Gets or sets the value of BankgiaoBCT
        /// </summary>
        public DateTime BankgiaoBCT
        {
            get { return bankgiaoBCT; }
            set
            {
                bankgiaoBCT = value;
                //OnPropertyChanged("NhanBCTtuBank", value);
            }
        }

        private DateTime giaoBCTchoDV = DateTime.Today;
        /// <summary>
        /// Gets or sets the value of GiaoBCTchoDV
        /// </summary>
        public DateTime GiaoBCTchoDV
        {
            get { return giaoBCTchoDV; }
            set
            {
                giaoBCTchoDV = value;
                //OnPropertyChanged("GiaoBCTchoDV", value);
            }
        }

        private DateTime motokhaiHQ = DateTime.Today;
        /// <summary>
        /// Gets or sets the value of MotokhaiHQ
        /// </summary>
        public DateTime MotokhaiHQ
        {
            get { return motokhaiHQ; }
            set
            {
                motokhaiHQ = value;
                //OnPropertyChanged("MotokhaiHQ", value);
            }
        }

        private DateTime batdaunhanCont = DateTime.Today;
        /// <summary>
        /// Gets or sets the value of BatdaunhanCont
        /// </summary>
        public DateTime BatdaunhanCont
        {
            get { return batdaunhanCont; }
            set
            {
                batdaunhanCont = value;
                //OnPropertyChanged("BatdaunhanCont", value);
            }
        }

        private DateTime ketthucnhanCont = DateTime.Today;
        /// <summary>
        /// Gets or sets the value of KetthucnhanCont
        /// </summary>
        public DateTime KetthucnhanCont
        {
            get { return ketthucnhanCont; }
            set
            {
                ketthucnhanCont = value;
                //OnPropertyChanged("KetthucnhanCont", value);
            }
        }

        private DateTime hethanluuConttaibai = DateTime.Today;
        /// <summary>
        /// Gets or sets the value of HethanluuConttaibai
        /// </summary>
        public DateTime HethanluuConttaibai
        {
            get { return hethanluuConttaibai; }
            set
            {
                hethanluuConttaibai = value;
                //OnPropertyChanged("HethanluuConttaibai", value);
            }
        }

        private DateTime hethanluubai = DateTime.Today;
        /// <summary>
        /// Gets or sets the value of Hethanluubai
        /// </summary>
        public DateTime Hethanluubai
        {
            get { return hethanluubai; }
            set
            {
                hethanluubai = value;
                //OnPropertyChanged("Hethanluubai", value);
            }
        }

        private DateTime hethanluukhorieng = DateTime.Today;
        /// <summary>
        /// Gets or sets the value of Hethanluukhorieng
        /// </summary>
        public DateTime Hethanluukhorieng
        {
            get { return hethanluukhorieng; }
            set
            {
                hethanluukhorieng = value;
                //OnPropertyChanged("Hethanluukhorieng", value);
            }
        }

        private DateTime ngaydangtainhamay = DateTime.Today;
        /// <summary>
        /// Gets or sets the value of Ngaydangtainhamay
        /// </summary>
        public DateTime Ngaydangtainhamay
        {
            get { return ngaydangtainhamay; }
            set
            {
                ngaydangtainhamay = value;
                //OnPropertyChanged("Ngaydangtainhamay", value);
            }
        }

        private DateTime ngaynhapxong = DateTime.Today;
        /// <summary>
        /// Gets or sets the value of Ngaynhapxong
        /// </summary>
        public DateTime Ngaynhapxong
        {
            get { return ngaynhapxong; }
            set
            {
                ngaynhapxong = value;
                //OnPropertyChanged("Ngaynhapxong", value);
            }
        }

        private DateTime ngaytrarong = DateTime.Today;
        /// <summary>
        /// Gets or sets the value of Ngaytrarong
        /// </summary>
        public DateTime Ngaytrarong
        {
            get { return ngaytrarong; }
            set
            {
                ngaytrarong = value;
                //OnPropertyChanged("Ngaytrarong", value);
            }
        }

        private int sobao;
        /// <summary>
        /// Gets or sets the value of Sobao
        /// </summary>
        public int Sobao
        {
            get { return sobao; }
            set
            {
                sobao = value;
                //OnPropertyChanged("Sobao", value);
            }
        }

        private decimal soluongBLNet;
        /// <summary>
        /// Gets or sets the value of SoluongBLNet
        /// </summary>
        public decimal SoluongBLNet
        {
            get { return soluongBLNet; }
            set
            {
                soluongBLNet = value;
                //OnPropertyChanged("SoluongBLNet", value);
            }
        }

        private decimal giakhaiHQ;
        /// <summary>
        /// Gets or sets the value of GiakhaiHQ
        /// </summary>
        public decimal GiakhaiHQ
        {
            get { return giakhaiHQ; }
            set
            {
                giakhaiHQ = value;
                //OnPropertyChanged("GiakhaiHQ", value);
            }
        }

        private decimal tygiaNH;
        /// <summary>
        /// Gets or sets the value of TygiaNH
        /// </summary>
        public decimal TygiaNH
        {
            get { return tygiaNH; }
            set
            {
                tygiaNH = value;
                //OnPropertyChanged("TygiaNH", value);
            }
        }

        private string description = String.Empty;
        /// <summary>
        /// Gets or sets the value of Description
        /// </summary>
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                //OnPropertyChanged("Description", value);
            }
        }

        private decimal priceVC;
        /// <summary>
        /// Gets or sets the value of PriceVC
        /// </summary>
        public decimal PriceVC
        {
            get { return priceVC; }
            set
            {
                priceVC = value;
                //OnPropertyChanged("TygiaNH", value);
            }
        }
        private decimal priceKQ;
        /// <summary>
        /// Gets or sets the value of PriceKQ
        /// </summary>
        public decimal PriceKQ
        {
            get { return priceKQ; }
            set
            {
                priceKQ = value;
                //OnPropertyChanged("TygiaNH", value);
            }
        }

        private Boolean isRutruot;

        public Boolean IsRutruot
        {
            get { return isRutruot; }
            set { isRutruot = value; }
        }
	
        #endregion

        #region Lists
        private ListBase<TransportContractFee> listTransportContractFee = new ListBase<TransportContractFee>();

        public ListBase<TransportContractFee> ListTransportContractFee
        {
            get { return listTransportContractFee; }
            set { listTransportContractFee = value; }
        }
        #endregion

        //private DataSet dSTransportResult;
        //public DataSet DSTransportResult
        //{
        //    get { return dSTransportResult; }
        //    set
        //    {
        //        dSTransportResult = value;
        //        DataRow row = dSTransportResult.Tables[5].Rows[0];
        //        if (!row.IsNull("VCAmount"))
        //        {
        //            ResultVCAmount = (decimal)row["VCAmount"];
        //            ResultDetentionAmount = (decimal)row["DetentionAmount"];
        //            ResultCompenAmount = (decimal)row["CompenAmount"];
        //            ResultOverdueAmount = (decimal)row["OverdueAmount"];
        //        }
        //        else
        //            ResultVCAmount = ResultDetentionAmount = ResultCompenAmount = 0;
        //    }
        //}
        public decimal ResultVCAmount = 0;
        //public decimal ResultVCTaxAmount
        //{
        //    get { return decimal.Round(ResultVCAmount * TaxRate, 0); }
        //}
        //public decimal ResultDetentionAmountBeforeTax
        //{
        //    get { return decimal.Round(ResultDetentionAmount / (1 + TaxRate), 0); }
        //}
        public decimal ResultDetentionAmount = 0;
        //public decimal ResultVCAndDetentionAmount
        //{
        //    get { return ResultVCAmount + ResultDetentionAmountBeforeTax; }
        //}
        //public decimal ResultVCAndDetentionAndOtherFeeAmount
        //{
        //    get { return ResultVCAndDetentionAmount + ResultOtherFeeNoTax; }
        //}
        //public decimal ResultVCAndDetentionTaxAmount
        //{
        //    get { return decimal.Round(ResultVCAndDetentionAmount * TaxRate, 0); }
        //}
        //public decimal ResultVCAndDetentionAndOtherFeeTaxAmount
        //{
        //    get { return ResultVCAndDetentionTaxAmount + ResultOtherFeeTax; }
        //}
        public decimal ResultCompenAmount = 0;
        public decimal ResultOverdueAmount = 0;
        //public decimal ResultOtherFee
        //{
        //    get
        //    {
        //        decimal fee = 0;
        //        foreach (TransportContractFee f in this.ListTransportContractFee)
        //            fee += f.TotalAmount;
        //        return fee;
        //    }
        //}
        //public decimal ResultOtherFeeNoTax
        //{
        //    get
        //    {
        //        decimal fee = 0;
        //        foreach (TransportContractFee f in this.ListTransportContractFee)
        //            if (this.ResultAll || (f.EndDate >= this.ResultFromDate && f.EndDate <= this.ResultToDate))
        //                foreach (TransportContractFeeDetail d in f.ListTransportContractFeeDetail)
        //                    fee += d.Amount;
        //        return fee;
        //    }
        //}
        //public decimal ResultOtherFeeTax
        //{
        //    get
        //    {
        //        decimal fee = 0;
        //        foreach (TransportContractFee f in this.ListTransportContractFee)
        //            if (this.ResultAll || (f.EndDate >= this.ResultFromDate && f.EndDate <= this.ResultToDate))
        //                foreach (TransportContractFeeDetail d in f.ListTransportContractFeeDetail)
        //                    fee += d.TaxAmount;
        //        return fee;
        //    }
        //}

        //public decimal ResultTotalAmount
        //{
        //    get
        //    {
        //        //return ResultVCAmount + ResultVCTaxAmount + ResultDetentionAmount - ResultCompenAmount - ResultOverdueAmount; 
        //        return ResultVCAndDetentionAndOtherFeeAmount + ResultVCAndDetentionAndOtherFeeTaxAmount - ResultCompenAmount - ResultOverdueAmount;
        //    }
        //}
    }
    #endregion
}