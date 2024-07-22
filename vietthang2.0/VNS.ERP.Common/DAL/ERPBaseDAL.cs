using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using VNS.Utils;
using VNS.Common;
using System.Data.Common;

namespace VNS.ERP.Common
{
     public class ERPBaseDAL<T>:BaseDAL<T> where T:ObjectBase,new ()
    {
        public ERPBaseDAL() { }
         public ERPBaseDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            base.SetValues();
        }
        public override int Insert(T t)
        {
            return base.Insert(t);
        }
        public override int Delete(T t)
        {
            return base.Delete(t);
        }
        public override int Update(T t)
        {
           return base.Update(t);
        }
        protected override T DataReader2Object(System.Data.Common.DbDataReader oDR)
        {
            return  base.DataReader2Object(oDR);
        }
    }
}
