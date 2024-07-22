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
    public partial class UCConfigPremix : EditControlBase
    {
        ModulePremix _ModulePremix = new ModulePremix();
        public UCConfigPremix()
        {
            InitializeComponent();
        }
        private void BindingData()
        {
            _ModulePremix = new ModuleBLL().GetModulePremix();
            lookUpMaterial.EditValue = _ModulePremix.StockTransType_OutMaterial;
            lookUpWrapping.EditValue = _ModulePremix.StockTransType_OutWrapping;
            lookUpPemix.EditValue = _ModulePremix.StockTransType_InPemix;
        }
        public ModulePremix GetData()
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
                _ModulePremix.StockTransType_OutMaterial=  lookUpMaterial.EditValue.ToString();
                _ModulePremix.StockTransType_OutWrapping=   lookUpWrapping.EditValue.ToString() ;
                _ModulePremix.StockTransType_InPemix= lookUpPemix.EditValue.ToString();
          return _ModulePremix;
        }
        public void SetLookup()
        {
            BindingData();
            lookUpMaterial.Properties.DataSource = new TransactiontypeBLL().GetByStockTransaction(enumStockTransaction.Out);
            lookUpWrapping.Properties.DataSource = lookUpMaterial.Properties.DataSource;
            lookUpPemix.Properties.DataSource = new TransactiontypeBLL().GetByStockTransaction(enumStockTransaction.In);
        }
        private int ValidateInputData()
        {
            if (this.lookUpMaterial.EditValue == null) return -8;
            if (this.lookUpWrapping.EditValue == null) return -9;
            if (this.lookUpPemix.EditValue == null) return -10;
            return 0;
        }

       
    }
}
