using System;
using System.Collections.Generic;
using System.Text;

using VNS.Common;
namespace VNS.ERP.Data
{
    public class ModuleBLL
    {
        private ModuleDAL dal = new ModuleDAL();

        public Module GetObjectByID(int _moduleID)
        {
            return dal.GetObjectByID(_moduleID);
        }
        public ModuleManufacture GetModuleManufacture()
        {
            return new ModuleManufacture(dal.GetObjectByID((int)enumModuleID.Manufacture));
        }
        public ModuleGrind GetModuleGrind()
        {
            return new ModuleGrind(dal.GetObjectByID((int)enumModuleID.Grind));
        }
        public ModulePremix GetModulePremix()
        {
            return new ModulePremix(dal.GetObjectByID((int)enumModuleID.Premix));
        }

        public ModuleStock GetModuleStock()
        {
            return new ModuleStock(dal.GetObjectByID((int)enumModuleID.Stock));
        }
        public ModuleAccounting GetModuleAccounting()
        {
            return new ModuleAccounting(dal.GetObjectByID((int)enumModuleID.Accounting));
        }

        public int UpdateModuleConfig(Module _module)
        {
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            try
            {
                for (int i=0;i<_module.Configs.Length;i++)
                {
                    iError = dal.InsertUpdateConfig(_module.ModuleID, i, _module.Configs[i]);
                    if (iError != 0)
                        break;
                }
            }
            catch { }
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
        /// Returns a list of modules for a specified member
        /// Added by Huy Ho 2007-02-23
        /// </summary>
        /// <param name="memberID">The memberID to get module list</param>
        /// <returns>Module list to return</returns>
        public System.Collections.ArrayList GetByMember(string memberID)
        {
            return dal.GetByMember(memberID);
        }
    }
}
