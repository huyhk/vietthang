using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using VNS.Windows.Controls;
using VNS.ERP.Data;
using VNS.Windows;
using VNS.Windows.Forms;

namespace VNS.ERP.GUI.UserControl
{
    public partial class UCConfigManufacture : EditControlBase
    {
        ModuleManufacture moduleManufacture = new ModuleManufacture();

        public UCConfigManufacture()
        {
            InitializeComponent();
            
            //BindingData();
        }
        private void BindingData()
        {
            moduleManufacture = new ModuleBLL().GetModuleManufacture();
            this.lookUpMaterial.EditValue = moduleManufacture.StockTransType_OutMaterial;
            this.lookUpFuel.EditValue = moduleManufacture.StockTransType_OutFuel;
            this.lookUpProduct.EditValue = moduleManufacture.StockTransType_InProduct;
            this.lookUpWaste.EditValue = moduleManufacture.StockTransType_InWaste;
        }
        public ModuleManufacture GetData()
        {
            //string message = "Error while save data!";
            ErrorMessageType messageType = ErrorMessageType.VALIDATE;
            int ret;
            ret = ValidateInputData();
            if (ret != 0)
            {
                OnError(ret, messageType);
                return null;
            }
               moduleManufacture.StockTransType_OutMaterial = this.lookUpMaterial.EditValue.ToString();
               moduleManufacture.StockTransType_OutFuel = this.lookUpFuel.EditValue.ToString();
               moduleManufacture.StockTransType_InProduct = this.lookUpProduct.EditValue.ToString();
               moduleManufacture.StockTransType_InWaste = this.lookUpWaste.EditValue.ToString();
            return moduleManufacture;
        }
        public void SetLoookup()
        {
            BindingData();
            lookUpMaterial.Properties.DataSource = new TransactiontypeBLL().GetByStockTransaction(enumStockTransaction.Out);
            lookUpFuel.Properties.DataSource = lookUpMaterial.Properties.DataSource;
            lookUpProduct.Properties.DataSource = new TransactiontypeBLL().GetByStockTransaction(enumStockTransaction.In);
            lookUpWaste.Properties.DataSource = lookUpProduct.Properties.DataSource;
        }
        private int ValidateInputData()
        {
            if (this.lookUpMaterial.EditValue == null) return -4;
            if (this.lookUpFuel.EditValue == null) return -5;
            if (this.lookUpProduct.EditValue == null) return -6;
            if (this.lookUpWaste.EditValue == null) return -7;
            return 0;
        }
        
    }
}
