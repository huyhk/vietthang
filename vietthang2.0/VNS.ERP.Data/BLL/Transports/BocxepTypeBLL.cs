using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
namespace VNS.ERP.Data
{
    public class BocxepTypeBLL : IBusiness
    {
        BocxepTypeDAL dal = new BocxepTypeDAL();
        public BocxepTypeBLL() { }
        public ListBase<BocxepType> GetAll()
        {
            return dal.GetObjectAll();
        }
        public int Insert(BocxepType t)
        {
            return dal.Insert(t);
        }
        public int Update(BocxepType t)
        {
            return dal.Update(t);
        }
        public int Delete(BocxepType t)
        {
            return dal.Delete(t);
        }
        #region IBusiness member
        public int Insert(object obj)
        {
            return this.Insert(obj as BocxepType);
        }
        public int Update(object obj)
        {
            return this.Update(obj as BocxepType);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as BocxepType);
        }
        #endregion
    }
}
