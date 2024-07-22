using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
using System.Data;
namespace VNS.ERP.Data.KCS
{
    public class MaterialTestEncryptCodeBLL : IBusiness
    {
        MaterialTestEncryptCodeDAL dal = new MaterialTestEncryptCodeDAL();
        public MaterialTestEncryptCodeBLL() { }
        public ListBase<MaterialTestEncryptCode> GetAll()
        {
            return dal.GetObjectAll();
        }
        public ListBase<MaterialTestEncryptCode> GetDynamic(string whereCondition, string orderByExp)
        {
            return dal.GetObjectDynamic(whereCondition, orderByExp);
        }
        public DataSet GetByTestTransactionDate(DateTime startDate, DateTime endDate)
        {
            return dal.GetByTestTransactionDate(startDate, endDate);
        }
        
        public int Update(MaterialTestEncryptCode t, string oldItemEncryptCode)
        {
            return dal.Update(t, oldItemEncryptCode);
        }
        public int Insert(MaterialTestEncryptCode t)
        {
            return dal.Insert(t);
        }
        public int Update(MaterialTestEncryptCode t)
        {
            return dal.Update(t);
        }
        public int Delete(MaterialTestEncryptCode t)
        {
            return dal.Delete(t);
        }
        public int Delete(string itemEncryptCode)
        {
            return dal.Delete(itemEncryptCode);
        }
        #region IBusiness member
        public int Insert(object obj)
        {
            return this.Insert(obj as MaterialTestEncryptCode);
        }
        public int Update(object obj)
        {
            return this.Update(obj as MaterialTestEncryptCode);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as MaterialTestEncryptCode);
        }
        #endregion
    }
}
