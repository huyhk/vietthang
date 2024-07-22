using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.BLL;
using VNS.Common;
namespace VNS.ERP.Data
{
    public class TransportRouteBLL:IBusiness
    {
        TransportRouteDAL dal = new TransportRouteDAL();
        public TransportRouteBLL() { }
        public ListBase<TransportRoute> GetAll()
        {
            return dal.GetObjectAll();
        }
        public int Insert(TransportRoute t)
        {
            return dal.Insert(t);
        }
        public int Update(TransportRoute t)
        {
            return dal.Update(t);
        }
        public int Delete(TransportRoute t)
        {
            return dal.Delete(t);
        }
        #region IBusiness member
        public int Insert(object obj)
        {
            return this.Insert(obj as TransportRoute);
        }
        public int Update(object obj)
        {
            return this.Update(obj as TransportRoute);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as TransportRoute);
        }
        #endregion

        public ListBase<TransportRoute> GetVCRoute()
        {
            ListBase<TransportRoute> lst = dal.GetObjectAll();
            for (int i = lst.Count - 1; i >= 0; i--)
            {
                if (lst[i].IsTrungchuyen)
                    lst.RemoveAt(i);
            }
            return lst;
        }
        public ListBase<TransportRoute> GetTCRoute()
        {
            ListBase<TransportRoute> lst = dal.GetObjectAll();
            for (int i = lst.Count - 1; i >= 0; i--)
            {
                if (!lst[i].IsTrungchuyen)
                    lst.RemoveAt(i);
            }
            return lst;
        }
    }
}
