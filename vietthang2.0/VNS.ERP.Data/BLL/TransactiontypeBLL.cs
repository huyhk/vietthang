using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Data;

using VNS.Common;
using VNS.Utils;
using VNS.Data.BLL;

namespace  VNS.ERP.Data
{
    public class TransactiontypeBLL : IBusiness
    {
        private TransactionTypesDAL dal = new TransactionTypesDAL();
        public TransactiontypeBLL() { }
        public ListBase<TransactionType> GetByStockTransaction(enumStockTransaction _StockTransaction)
        {
            return dal.GetByStockTransaction(_StockTransaction);
        }
        public ListBase<TransactionType> GetByStockTransactionContScale(enumStockTransaction _StockTransaction)
        {
            return dal.GetByStockTransactionContScale(_StockTransaction);
        }
        public ListBase<TransactionType> GetAll()
        {
            return dal.GetObjectAll();
        }
        public ListBase<TransactionType> GetBySTAndForManufacture(enumStockTransaction _StockTransaction, bool _ForManufacture)
        {
            return dal.GetBySTAndForManufacture(_StockTransaction, _ForManufacture);
        }
        public int Insert(TransactionType t)
        {
            int iError = 0;
            t.UserCreated = Contexts.CurrentUser.LoginName;
            iError = dal.Insert(t);
            
               return iError;
            
        }
        public int Update(TransactionType t)
        {
            return dal.Update(t);
        }
        public int Delete(TransactionType t)
        {
            return dal.Delete(t);
        }
        public int Insert(object obj)
        { return Insert(obj as TransactionType);}
        public int Delete(object obj)
        { return Delete(obj as TransactionType); }
        public int Update(object obj)
        { return Update(obj as TransactionType); }
    }
}
