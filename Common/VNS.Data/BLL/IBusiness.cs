using System;
using System.Collections.Generic;
using System.Text;

namespace VNS.Data.BLL
{
    public interface IBusiness
    {
        int Insert(object obj);
        int Update(object obj);

        int Delete(object obj);
    }
}
