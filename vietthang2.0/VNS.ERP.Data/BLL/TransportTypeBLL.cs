using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
namespace VNS.ERP.Data
{
    public class TransportTypeBLL
    {
        TransportTypeDAL dal = new TransportTypeDAL();
        public DataTable GetAll()
        {
            return dal.GetAll();
        }
    }
}
