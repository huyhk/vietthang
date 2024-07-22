using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.BLL;
using VNS.Common;

namespace VNS.ERP.Data.Sales
{
    #region CustomerSpecialPriceBLL
    /// <summary>
    /// This object represents the properties and methods of a Business Layer of CustomerSpecialPrice.
    /// </summary>
    public class CustomerSpecialPriceBLL : IBusiness
    {
        private CustomerSpecialPriceDAL dal = new CustomerSpecialPriceDAL();
        public CustomerSpecialPriceBLL()
        {
        }
        #region Stored procedure wrappers

        /// <summary>
        /// Gets all objects 
        /// </summary>
        public ListBase<CustomerSpecialPrice> GetAll()
        {
            DataSet ds = dal.GetAll();
            DataRelation dr = ds.Relations.Add(ds.Tables[0].Columns["PriceID"], ds.Tables[1].Columns["PriceID"]);
            ListBase<CustomerSpecialPrice> lst = new ListBase<CustomerSpecialPrice>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                CustomerSpecialPrice o = new CustomerSpecialPrice(row);
                foreach (DataRow rowD in row.GetChildRows(dr))
                {
                    o.ListCustomerSpecialPriceDetail.Add(new CustomerSpecialPriceDetail(rowD));
                }
                lst.Add(o);
            }
            return lst;
        }
        /// <summary>
        /// Gets all objects 
        /// </summary>
        public ListBase<CustomerSpecialPrice> GetDynamic(string whereCondition, string orderExpression)
        {
            return dal.GetObjectDynamic(whereCondition, orderExpression);
        }
        /// <summary>
        /// Inserts an object into database by calling Insert StoredProcedure
        /// </summary>
        public int Insert(CustomerSpecialPrice t)
        {
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            iError = dal.Insert(t);
            if (iError == 0)
            {
                foreach (CustomerSpecialPriceDetail dt in t.ListCustomerSpecialPriceDetail)
                {
                    dt.PriceID = t.PriceID;
                    iError = dal.InsertDetail(dt);
                    if (iError != 0)
                        break;
                }
            }
            if (iError == 0)
                dal.Commit();
            else
                dal.Rollback();
            dal.Close();
            return iError;
        }


        /// <summary>
        /// Updates an existing object in database 
        /// </summary>
        public int Update(CustomerSpecialPrice t)
        {
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            iError = dal.Update(t);
            if (iError == 0)
            {
                iError = dal.DeleteDetail(t.PriceID);
            }
            if (iError == 0)
            {
                foreach (CustomerSpecialPriceDetail dt in t.ListCustomerSpecialPriceDetail)
                {
                    dt.PriceID = t.PriceID;
                    iError = dal.InsertDetail(dt);
                    if (iError != 0)
                        break;
                }
            }
            if (iError == 0)
                dal.Commit();
            else
                dal.Rollback();
            dal.Close();
            return iError;
        }

        /// <summary>
        /// Deletes an object from database by Id
        /// </summary>		
        public int Delete(Guid priceID)
        {

            return dal.Delete(priceID);
        }

        /// <summary>
        /// Deletes an object from database 
        /// </summary>		
        public int Delete(CustomerSpecialPrice t)
        {

            return dal.Delete(t.PriceID);
        }


        #endregion


        #region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as CustomerSpecialPrice);
        }

        public int Update(object obj)
        {
            return this.Update(obj as CustomerSpecialPrice);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as CustomerSpecialPrice);
        }

        #endregion

    }
    #endregion
}