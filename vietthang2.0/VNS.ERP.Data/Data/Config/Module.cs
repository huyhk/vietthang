using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data
{
    public class Module:BaseClass
    {
        public Module()
        { }
        public Module(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("ModuleID", reader)) ModuleID = reader.GetInt32(reader.GetOrdinal("ModuleID"));
            if (!isNull("Description", reader)) _description = reader.GetString(reader.GetOrdinal("Description"));
        }
        public Module(System.Data.IDataReader reader, bool oneObjOnly)
        {
            this.FromDataReader(reader);
            if (oneObjOnly)
                if (reader.NextResult())
                {
                    while (reader.Read())
                    {
                        int i = (int)reader.GetByte(reader.GetOrdinal("ConfigID"));
                        Configs[i] = reader.GetString(reader.GetOrdinal("ConfigValue"));
                    }
                }
        }

        protected int _moduleID;

        public int ModuleID
        {
            get { return _moduleID; }
            set
            {
                _moduleID = value;
                int i = 0;
                switch (value)
                {
                    case (int)enumModuleID.Manufacture:
                        i = Enum.GetNames(typeof(enumConfigManufacture)).Length;
                        break;
                    case (int)enumModuleID.Premix:
                        i = Enum.GetNames(typeof(enumConfigPremix)).Length;
                        break;
                    case (int)enumModuleID.Grind:
                        i = Enum.GetNames(typeof(enumConfigGrind)).Length;
                        break;
                    case (int)enumModuleID.Stock:
                        i = Enum.GetNames(typeof(enumConfigStock)).Length;
                        break;
                    case (int)enumModuleID.Accounting:
                        i = Enum.GetNames(typeof(enumConfigAccounting)).Length;
                        break;
                }
                Configs = new string[i];
                
            }
        }
	
        protected string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string[] Configs;
	
    }
    public class ModuleManufacture : Module
    {
        public ModuleManufacture()
        {
            ModuleID = (int)enumModuleID.Manufacture;
        }
        public ModuleManufacture(Module md)
        {
            if (md != null)
            {
                ModuleID = (int)enumModuleID.Manufacture;
                Description = md.Description;
                Configs = md.Configs;
            }
        }

        public string StockTransType_OutMaterial
        {
            get { return Configs[(int)enumConfigManufacture.StockTransType_OutMaterial]; }
            set { Configs[(int)enumConfigManufacture.StockTransType_OutMaterial] = value; }
        }
        public string StockTransType_OutFuel
        {
            get { return Configs[(int)enumConfigManufacture.StockTransType_OutFuel]; }
            set { Configs[(int)enumConfigManufacture.StockTransType_OutFuel] = value; }
        }
        public string StockTransType_InProduct
        {
            get { return Configs[(int)enumConfigManufacture.StockTransType_InProduct]; }
            set { Configs[(int)enumConfigManufacture.StockTransType_InProduct] = value; }
        }
        public string StockTransType_InWaste
        {
            get { return Configs[(int)enumConfigManufacture.StockTransType_InWaste]; }
            set { Configs[(int)enumConfigManufacture.StockTransType_InWaste] = value; }
        }
    }
    public class ModulePremix : Module
    {
        public ModulePremix()
        {
            ModuleID = (int)enumModuleID.Premix;
        }
        public ModulePremix(Module md)
        {
            if (md != null)
            {
                ModuleID = (int)enumModuleID.Premix;
                Description = md.Description;
                Configs = md.Configs;
            }
        }

        public string StockTransType_OutMaterial
        {
            get { return Configs[(int)enumConfigPremix.StockTransType_OutMaterial]; }
            set { Configs[(int)enumConfigPremix.StockTransType_OutMaterial] = value; }
        }
        public string StockTransType_OutWrapping
        {
            get { return Configs[(int)enumConfigPremix.StockTransType_OutWrapping]; }
            set { Configs[(int)enumConfigPremix.StockTransType_OutWrapping] = value; }
        }
        public string StockTransType_InPemix
        {
            get { return Configs[(int)enumConfigPremix.StockTransType_InPemix]; }
            set { Configs[(int)enumConfigPremix.StockTransType_InPemix] = value; }
        }
       
    }

    public class ModuleGrind : Module
    {
        public ModuleGrind()
        {
            ModuleID = (int)enumModuleID.Grind;
        }
        public ModuleGrind(Module md)
        {
            if (md != null)
            {
                ModuleID = (int)enumModuleID.Grind;
                Description = md.Description;
                Configs = md.Configs;
            }
        }

        public string StockTransType_OutMaterial
        {
            get { return Configs[(int)enumConfigGrind.StockTransType_OutMaterial]; }
            set { Configs[(int)enumConfigGrind.StockTransType_OutMaterial] = value; }
        }
        public string StockTransType_OutWrapping
        {
            get { return Configs[(int)enumConfigGrind.StockTransType_OutWrapping]; }
            set { Configs[(int)enumConfigGrind.StockTransType_OutWrapping] = value; }
        }
        public string StockTransType_InMaterial
        {
            get { return Configs[(int)enumConfigGrind.StockTransType_InMaterial]; }
            set { Configs[(int)enumConfigGrind.StockTransType_InMaterial] = value; }
        }
        public string StockTransType_OutFuel
        {
            get { return Configs[(int)enumConfigGrind.StockTransType_OutFuel]; }
            set { Configs[(int)enumConfigGrind.StockTransType_OutFuel] = value; }
        }

    }

    public class ModuleStock : Module
    {
        public ModuleStock()
        {
            ModuleID = (int)enumModuleID.Stock;
        }
        public ModuleStock(Module md)
        {
            if (md != null)
            {
                ModuleID = (int)enumModuleID.Stock;
                Description = md.Description;
                Configs = md.Configs;
            }
        }

        public string CanmeDBFilePath
        {
            get { return Configs[(int)enumConfigStock.CanmeDBFilePath]; }
            set { Configs[(int)enumConfigStock.CanmeDBFilePath] = value; }
        }
        public string MTSServer
        {
            get { return Configs[(int)enumConfigStock.MTSServer]; }
            set { Configs[(int)enumConfigStock.MTSServer] = value; }
        }
        public string MTSDatabase
        {
            get { return Configs[(int)enumConfigStock.MTSDatabase]; }
            set { Configs[(int)enumConfigStock.MTSDatabase] = value; }
        }
        public string MTSUser
        {
            get { return Configs[(int)enumConfigStock.MTSUser]; }
            set { Configs[(int)enumConfigStock.MTSUser] = value; }
        }
        public string MTSPassword
        {
            get { return Configs[(int)enumConfigStock.MTSPassword]; }
            set { Configs[(int)enumConfigStock.MTSPassword] = value; }
        }
    }
    public class ModuleAccounting : Module
    {
        public ModuleAccounting()
        {
            ModuleID = (int)enumModuleID.Accounting;
        }
        public ModuleAccounting(Module md)
        {
            if (md != null)
            {
                ModuleID = (int)enumModuleID.Accounting;
                Description = md.Description;
                Configs = md.Configs;
            }
        }
        public string TenDonvi
        {
            get { return Configs[(int)enumConfigAccounting.TenDonvi]; }
            set { Configs[(int)enumConfigAccounting.TenDonvi] = value; }
        }
        public string Diachi
        {
            get { return Configs[(int)enumConfigAccounting.Diachi]; }
            set { Configs[(int)enumConfigAccounting.Diachi] = value; }
        }
    }
    public class ModuleKCS
    {
        public static string CONFIG_TECH_PERCENTFORMAT = "p1";
        public static string CONFIG_TECH_PERCENTFORMAT_STRING = "{0:" + CONFIG_TECH_PERCENTFORMAT + "}";

        public static string CONFIG_NORESULT = "*";
    }
}
