using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;

using VNS.Utils;
using VNS.Common;

namespace VNS.ERP.Data
{
    public class AdminBLL
    {
        AdminDAL dal = new AdminDAL();
        public DataSet GetJobHistory()
        { return dal.GetJobHistory(); }
    }
}
