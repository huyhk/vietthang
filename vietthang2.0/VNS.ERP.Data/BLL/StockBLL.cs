using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.BLL;
using VNS.Common;
using System.Data;

namespace  VNS.ERP.Data
{
    public class StockBLL:IBusiness
    {
        private StockDAL DAL = new StockDAL();
        public StockBLL()
        { }
        public Stock GetByMinSoHieu()
        {
            return DAL.GetByMinSoHieu();
        }
        /// <summary>
        /// except InActive stock
        /// </summary>
        /// <returns></returns>
        public ListBase<Stock> GetAll()
        {
            return DAL.GetActive();
        }
        public ListBase<Stock> GetAllAll()
        {
            ListBase<Stock> lst = new ListBase<Stock>();
            DataSet ds = DAL.GetAll();

            DataRelation dr = ds.Relations.Add(ds.Tables[0].Columns["StockCode"], ds.Tables[1].Columns["StockCode"]);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Stock s = new Stock(row);

                foreach (DataRow rowD in row.GetChildRows(dr))
                {
                    s.ListItemStockAuto.Add(new ItemStockAuto(rowD));
                }

                lst.Add(s);
            }

            return lst;
        }
        public ListBase<Stock> GetAllForMember(string memberID)
        {
            return DAL.GetAllForMember(memberID);
        }
        public DataTable SearchAll()
        {
            return DAL.SearchAll();
        }
        public int Insert(Stock t)
        {
            DAL.Open();
            DAL.BeginTransaction();
            int iError = DAL.Insert(t);

            if (iError == 0)
            {
                foreach (ItemStockAuto i in t.ListItemStockAuto)
                {
                    iError = DAL.InsertUpdateItemStockAuto(i);
                    if (iError != 0)
                        break;
                }
            }
            if (iError == 0)
                DAL.Commit();
            else
                DAL.Rollback();
            DAL.Close();
            return iError;
        }
        public int Update(Stock t)
        {
            DAL.Open();
            DAL.BeginTransaction();
            int iError = DAL.Update(t);

            if (iError == 0)
            {
                foreach (ItemStockAuto i in t.ListItemStockAuto)
                {
                    iError = DAL.InsertUpdateItemStockAuto(i);
                    if (iError != 0)
                        break;
                }
            }
            if (iError == 0)
                DAL.Commit();
            else
                DAL.Rollback();
            DAL.Close();
            return iError;
        }
        public int Delete(string _StockCode)
        {
            return DAL.Delete(_StockCode);
        }
        public int Delete(Stock t)
        {
            return DAL.Delete(t);
        }
        #region IBusiness Members
        public int Insert(object obj)
        {
            return this.Insert(obj as Stock);
        }
        public int Update(object obj)
        {
            return this.Update(obj as Stock);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as Stock);
        }
        #endregion
    }

}
