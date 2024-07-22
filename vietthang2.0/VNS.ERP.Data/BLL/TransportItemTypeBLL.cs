using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
namespace VNS.ERP.Data
{
    public class TransportItemTypeBLL
    {
        TransportItemTypeDAL dal = new TransportItemTypeDAL();
        public DataTable GetAll()
        {
            return dal.GetAll();
        }
    }
}
