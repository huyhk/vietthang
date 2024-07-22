using System;
using System.Collections.Generic;
using System.Text;
using VNS.ERP.Data.DAL;
using VNS.Data.BLL;

namespace VNS.ERP.Data
{
    public class GTGTBLL : IBusiness
    {
        private GTGTDAL dal = new GTGTDAL();
        public GTGTBLL()
		{}
        public GTGT GetObjectByMonth(DateTime startDate, DateTime endDate)
        {
            return dal.GetObjectByMonth(startDate, endDate);
        }
        public GTGT GetObjectByPeriodCode(string periodCode)
        {
            return dal.GetObjectByPeriodCode(periodCode);
        }
        public int Insert(GTGT t)
        {
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            try
            {
                iError = dal.Delete(t);
                if(iError==0)
                 iError= dal.Insert(t);
            }
            catch
            {
                iError = -1000;
            }
            finally
            {
                if (iError == 0)
                    dal.Commit();
                else
                    dal.Rollback();
                dal.Close();
            }
            return iError;
        }
        
        /// <summary>
        /// Update  the GTGT into Database.
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Update(GTGT t)
        {

            return dal.Update(t);
        }
        /// <summary>
        /// delete a  GTGT object out of database
        /// return: 0: success
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Delete(GTGT t)
        {
            return dal.Delete(t);
        }

        #region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as GTGT);
        }

        public int Update(object obj)
        {
            return this.Update(obj as GTGT);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as GTGT);
        }

        #endregion
    }
      
}
