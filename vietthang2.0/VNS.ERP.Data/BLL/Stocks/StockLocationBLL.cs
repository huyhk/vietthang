using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.BLL;
using VNS.Common;

namespace  VNS.ERP.Data
{
    public class StockLocationBLL:IBusiness
    {
        //public string _sCode;
        private StockLocationDAL dal = new StockLocationDAL();
        public StockLocationBLL() { }
        public ListBase<StockLocation> GetAll()
        {
            return dal.GetObjectAll();
        }
        public ListBase<StockLocation> GetByStockCode(string _sCode)
        {
            return dal.GetByStockCode(_sCode);
        }
        public int Insert(StockLocation t)
        {
            return dal.Insert(t);
        }
        public int Update(StockLocation t)
        {
            return dal.Update(t);
        }
        public int Delete(string _StockLocationCode, string _StockCode)
        {
            return dal.Delete(_StockLocationCode, _StockCode);
        }
        public int Delete(string _StockCode)
        {
            return dal.Delete(_StockCode);
        }
        public int Delete(StockLocation t)
        {
            return this.Delete(t.StockLocationCode, t.StockCode);
        }

        #region IBusiness Members
        public int Insert(object obj)
        {
            return this.Insert(obj as StockLocation);
        }
        public int Update(object obj)
        {
            return this.Update(obj as StockLocation);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as StockLocation);
        }
        #endregion
    }
}
