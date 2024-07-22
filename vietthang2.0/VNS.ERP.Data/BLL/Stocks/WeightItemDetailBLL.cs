using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.BLL;
using VNS.Common;

namespace VNS.ERP.Data
{
    public class WeightItemDetailBLL:IBusiness
    {
        private WeightItemDetailDAL dal = new WeightItemDetailDAL();
        public WeightItemDetailBLL()
        {
        }
        public ListBase<WeightItemDetail> GetByWeightID(Guid _WeightID)
        {
            return dal.GetByWeightID(_WeightID);
        }
        public ListBase<WeightItemDetail> GetAll()
        {
            return dal.GetObjectAll();
        }
        public int Insert(WeightItemDetail t)
        {
            return dal.Insert(t);
        }
        public int Update(WeightItemDetail t)
        {
            return dal.Update(t);
        }
        public int Delte(WeightItemDetail t)
        {
            return dal.Delete(t);
        }
        #region IBusiness Members
        public int Insert(object obj)
        {
            return this.Insert(obj as WeightItemDetail);
        }
        public int Update(object obj)
        {
            return this.Update(obj as WeightItemDetail);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as WeightItemDetail);
        }
        #endregion
    }
}
