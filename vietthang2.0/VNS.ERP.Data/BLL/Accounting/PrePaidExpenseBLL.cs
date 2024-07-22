using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
namespace VNS.ERP.Data.Accounting
{
    public class PrePaidExpenseBLL : IBusiness
    {
        PrePaidExpenseDAL dal = new PrePaidExpenseDAL();
        public PrePaidExpenseBLL() { }
        public ListBase<PrePaidExpense> GetAll()
        {
            return dal.GetObjectAll();
        }
        public int Insert(PrePaidExpense t)
        {
            return dal.Insert(t);
        }
        public int Update(PrePaidExpense t)
        {
            return dal.Update(t);
        }
        public int Delete(PrePaidExpense t)
        {
            return dal.Delete(t);
        }
       
        #region IBusiness member
        public int Insert(object obj)
        {
            return this.Insert(obj as PrePaidExpense);
        }
        public int Update(object obj)
        {
            return this.Update(obj as PrePaidExpense);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as PrePaidExpense);
        }
        #endregion
    }
}
