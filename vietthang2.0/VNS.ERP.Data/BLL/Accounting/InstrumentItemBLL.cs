using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
namespace VNS.ERP.Data.Accounting
{
public class InstrumentItemBLL : IBusiness
{
InstrumentItemDAL dal = new InstrumentItemDAL();
public InstrumentItemBLL(){}
public ListBase<InstrumentItem>GetAll()
{
return dal.GetObjectAll();
}
public int Insert(InstrumentItem t)
{
return dal.Insert(t);
}
public int Update(InstrumentItem t)
{
return dal.Update(t);
}
public int Delete(InstrumentItem t)
{
return dal.Delete(t);
}
#region IBusiness member
public int Insert(object obj)
{
return this.Insert(obj as InstrumentItem);
}
public int Update(object obj)
{
return this.Update(obj as InstrumentItem);
}
public int Delete(object obj)
{
return this.Delete(obj as InstrumentItem);
}
#endregion
}
}
