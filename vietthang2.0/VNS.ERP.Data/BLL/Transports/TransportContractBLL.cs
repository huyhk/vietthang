using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.BLL;
using VNS.Common;

namespace VNS.ERP.Data.Transports
{
    #region TransportContractBLL
    /// <summary>
    /// This object represents the properties and methods of a Business Layer of TransportContract.
    /// </summary>
    public class TransportContractBLL : IBusiness
    {
        private TransportContractDAL dal = new TransportContractDAL();
        public TransportContractBLL()
        {
        }
        #region Stored procedure wrappers

        /// <summary>
        /// Gets all objects 
        /// </summary>
        public ListBase<TransportContract> GetAll()
        {
            return DS2List(dal.GetAll());
        }
        public ListBase<TransportContract> GetYear(int year)
        {
            return DS2List(dal.GetYear(year));
        }
        private ListBase<TransportContract> DS2List(DataSet ds)
        {
            DataRelation drPrice = ds.Relations.Add(ds.Tables[0].Columns["ContractID"], ds.Tables[1].Columns["ContractID"]);
            DataRelation drItem = ds.Relations.Add(ds.Tables[1].Columns["PriceID"], ds.Tables[2].Columns["PriceID"]);
            DataRelation drDetail = ds.Relations.Add(ds.Tables[1].Columns["PriceID"], ds.Tables[3].Columns["PriceID"]);
            DataRelation drDetentionPrice = ds.Relations.Add(ds.Tables[0].Columns["ContractID"], ds.Tables[4].Columns["ContractID"]);
            DataRelation drDetentionPriceDetail = ds.Relations.Add(ds.Tables[4].Columns["PriceID"], ds.Tables[5].Columns["PriceID"]);
            DataRelation drTransportContractItemLossGroup = ds.Relations.Add(ds.Tables[0].Columns["ContractID"], ds.Tables[6].Columns["ContractID"]);
            DataRelation drTransportContractItemLossGroupItem = ds.Relations.Add(ds.Tables[6].Columns["GroupID"], ds.Tables[7].Columns["GroupID"]);
            DataRelation drTransportContractItemLossGroupCompenPrice = ds.Relations.Add(ds.Tables[6].Columns["GroupID"], ds.Tables[8].Columns["GroupID"]);
            //Table0 and table9,10
            DataRelation drTransportContractFee = ds.Relations.Add(ds.Tables[0].Columns["ContractID"], ds.Tables[9].Columns["ContractID"]);
            DataRelation drTransportContractFeeDetail = ds.Relations.Add(ds.Tables[9].Columns["FeeID"], ds.Tables[10].Columns["FeeID"]);

            DataRelation drResult = ds.Relations.Add(ds.Tables[0].Columns["ContractID"], ds.Tables[11].Columns["ContractID"]);

            DataRelation drBatch = ds.Relations.Add(ds.Tables[0].Columns["ContractID"], ds.Tables[12].Columns["ContractID"]);

            ListBase<TransportContract> lst = new ListBase<TransportContract>();
            foreach (DataRow rowContract in ds.Tables[0].Rows)
            {
                TransportContract oContract = new TransportContract(rowContract);
                foreach (DataRow rowPrice in rowContract.GetChildRows(drPrice))
                {
                    TransportContractPrice oPrice = new TransportContractPrice(rowPrice);
                    foreach (DataRow rowItem in rowPrice.GetChildRows(drItem))
                        oPrice.ListTransportContractPriceItem.Add(new TransportContractPriceItem(rowItem));
                    foreach (DataRow rowDetail in rowPrice.GetChildRows(drDetail))
                        oPrice.ListTransportContractPriceDetail.Add(new TransportContractPriceDetail(rowDetail));

                    oContract.ListTransportContractPrice.Add(oPrice);
                }
                foreach (DataRow rowDetentionPrice in rowContract.GetChildRows(drDetentionPrice))
                {
                    TransportContractDetentionPrice oDetentionPrice = new TransportContractDetentionPrice(rowDetentionPrice);
                    foreach (DataRow rowDetentionPriceDetail in rowDetentionPrice.GetChildRows(drDetentionPriceDetail))
                        oDetentionPrice.ListTransportContractDetentionPriceDetail.Add(new TransportContractDetentionPriceDetail(rowDetentionPriceDetail));
                    oContract.ListTransportContractDetentionPrice.Add(oDetentionPrice);
                }
                foreach (DataRow rowTransportContractItemLossGroup in rowContract.GetChildRows(drTransportContractItemLossGroup))
                {
                    TransportContractItemLossGroup oTransportContractItemLossGroup = new TransportContractItemLossGroup(rowTransportContractItemLossGroup);
                    foreach (DataRow rowTransportContractItemLossGroupItem in rowTransportContractItemLossGroup.GetChildRows(drTransportContractItemLossGroupItem))
                        oTransportContractItemLossGroup.ListTransportContractItemLossGroupItem.Add(new TransportContractItemLossGroupItem(rowTransportContractItemLossGroupItem));
                    foreach (DataRow rowTransportContractItemLossGroupCompenPrice in rowTransportContractItemLossGroup.GetChildRows(drTransportContractItemLossGroupCompenPrice))
                        oTransportContractItemLossGroup.ListTransportContractItemLossGroupCompenPrice.Add(new TransportContractItemLossGroupCompenPrice(rowTransportContractItemLossGroupCompenPrice));
                    oContract.ListTransportContractItemLossGroup.Add(oTransportContractItemLossGroup);
                }
                foreach (DataRow rowBatch in rowContract.GetChildRows(drBatch))
                    oContract.ListTransportContractBatch.Add(new TransportContractBatch(rowBatch));

                foreach (DataRow rowTransportContractFee in rowContract.GetChildRows(drTransportContractFee))
                {
                    TransportContractFee oTransportContractFee = new TransportContractFee(rowTransportContractFee);
                    foreach (DataRow rowTransportContractFeeDetail in rowTransportContractFee.GetChildRows(drTransportContractFeeDetail))
                        oTransportContractFee.ListTransportContractFeeDetail.Add(new TransportContractFeeDetail(rowTransportContractFeeDetail));
                    oContract.ListTransportContractFee.Add(oTransportContractFee);

                    if (oTransportContractFee.BatchID!=Guid.Empty)
                        if (oContract.ListTransportContractBatch.Count > 0)
                        {
                            TransportContractBatch b = oContract.ListTransportContractBatch.Search("BatchID", oTransportContractFee.BatchID);
                            if (b != null)
                                b.ListTransportContractFee.Add(oTransportContractFee);
                        }
                }

                foreach (DataRow rowResult in rowContract.GetChildRows(drResult))
                    oContract.ListTransportContractResult.Add(new TransportContractResult(rowResult));

                

                lst.Add(oContract);
            }
            return lst;
        }
        /// <summary>
        /// Gets all objects 
        /// </summary>
        public ListBase<TransportContract> GetDynamic(string whereCondition, string orderExpression)
        {
            return dal.GetObjectDynamic(whereCondition, orderExpression);
        }
        /// <summary>
        /// Inserts an object into database by calling Insert StoredProcedure
        /// </summary>
        public int Insert(TransportContract t)
        {
            return dal.Insert(t);
        }

        /// <summary>
        /// Updates an existing object in database 
        /// </summary>
        public int Update(TransportContract t)
        {
            return dal.Update(t);
        }

        /// <summary>
        /// Deletes an object from database by Id
        /// </summary>		
        public int Delete(Guid contractID)
        {

            return dal.Delete(contractID);
        }

        /// <summary>
        /// Deletes an object from database 
        /// </summary>		
        public int Delete(TransportContract t)
        {

            return dal.Delete(t.ContractID);
        }


        #endregion


        #region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as TransportContract);
        }

        public int Update(object obj)
        {
            return this.Update(obj as TransportContract);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as TransportContract);
        }

        #endregion

        public ListBase<TransportContract> GetBySubjectCodeAndDate(string subjectCode, DateTime fromDate)
        {
            return dal.GetBySubjectCodeAndDate(subjectCode, fromDate);
        }

        //public int InsertResult(TransportContract t)
        //{
        //    int iError = 0;
        //    TransportContractResult r = new TransportContractResult();
        //    r.ContractID = t.ContractID;
        //    r.ContractNo = t.ContractNo;
        //    r.SubjectCode = t.SubjectCode;
        //    r.FromDate = t.ResultFromDate;
        //    r.ToDate = t.ResultToDate;
        //    r.CompenAmount = t.ResultCompenAmount;
        //    r.DetentionAmount = t.ResultDetentionAmount;
        //    r.OverdueAmount = t.ResultOverdueAmount;
        //    r.TotalAmount = t.ResultTotalAmount;
        //    r.VCAmount = t.ResultVCAmount;
        //    r.VCTaxAmount = t.ResultVCTaxAmount;
        //    iError = dal.InsertResult(r);
        //    if (iError == 0)
        //    {
        //        r.DSTransportResult = t.DSTransportResult;
        //        t.ListTransportContractResult.Add(r);
        //    }
        //    return iError;
        //}

        //public int DeleteResult(Guid resultID)
        //{ 
        //    int iError = dal.DeleteResult(resultID);
        //    return iError;
        //}
    }
    #endregion
}