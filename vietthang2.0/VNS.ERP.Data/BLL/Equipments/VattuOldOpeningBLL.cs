
/************************************************************************
**	ClassName	: 	VattuOldOpeningBLL
**	Author		:	Cohim2000
**	Company		:	VNS
**	Date		:	10-07-2008 02:43 PM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.BLL;
using VNS.Common;

namespace VNS.ERP.Data.Equipments
{
	#region VattuOldOpeningBLL
	/// <summary>
	/// This object represents the properties and methods of a Business Layer of VattuOldOpening.
	/// </summary>
	public class VattuOldOpeningBLL : IBusiness
	{
        public string StockCode = string.Empty;
        public string PeriodCode = string.Empty;
        private VattuOldOpeningDAL dal = new VattuOldOpeningDAL();		
		public VattuOldOpeningBLL()
		{
		}
		
	
        public ListBase<VattuOldOpening> GetOpening()
        {
            return GetByPeriodAndStock(PeriodCode, StockCode);
        }
        public ListBase<VattuOldOpening> GetByPeriodAndStock(string periodCode, string stockCode)
        {
            return dal.GetByPeriodAndStock(periodCode, stockCode);
        }
        public int UpdateByPeriodAndStock(ListBase<VattuOldOpening> lst, string periodCode, string stockCode)
        {
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            iError = dal.DeleteByPeriodAndStock(periodCode, stockCode);
            if (iError == 0)
            {
                foreach (VattuOldOpening t in lst)
                {
                    t.PeriodCode = periodCode;
                    t.StockCode = stockCode;
                    iError = dal.Insert(t);
                    if (iError != 0) break;
                }
            }
            if (iError == 0)
                dal.Commit();
            else
                dal.Rollback();
            dal.Close();
            return iError;
        }

        public ListBase< VattuOldOpening >  GetAll()
		{
			return dal.GetObjectAll();
		}		
		
		
		public int Insert(object obj)
		{
			            throw new Exception("The method or operation is not implemented.");
		}
	
	
	
		public int Update(object  obj)
		{
            return UpdateByPeriodAndStock((obj as VattuOldOpeningList).ListVattuOldOpening, PeriodCode, StockCode);
		}
		
		
		
		public int Delete(object obj)
		{

            throw new Exception("The method or operation is not implemented.");
		}
		
		
		#endregion
		
				
		#region IBusiness Members

        //public int Insert(object obj)
        //{
        //    return this.Insert(obj as VattuOldOpening);
        //}

       
        //public int Delete(object obj)
        //{
        //    return this.Delete(obj as VattuOldOpening);
        //}

        #endregion
		
	}

}

