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
    public partial class UCConfigGrindcs :EditControlBase
    {
        ModuleGrind _ModuleGrind = new ModuleGrind();
        public UCConfigGrindcs()
        {
            InitializeComponent();
        }
        
       
        private void BindingData()
        {
            _ModuleGrind = new ModuleBLL().GetModuleGrind();
            lookUpMaterial.EditValue = _ModuleGrind.StockTransType_OutMaterial;
            lookUpWrapping.EditValue = _ModuleGrind.StockTransType_OutWrapping;
            this.lookUpInMaterial .EditValue = _ModuleGrind.StockTransType_InMaterial;
        }
        public ModuleGrind GetData()
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
                _ModuleGrind.StockTransType_OutMaterial=  lookUpMaterial.EditValue.ToString();
                _ModuleGrind.StockTransType_OutWrapping=   lookUpWrapping.EditValue.ToString() ;
                _ModuleGrind.StockTransType_InMaterial = lookUpInMaterial.EditValue.ToString();
          return _ModuleGrind;
        }
        public void SetLookup()
        {
            BindingData();
            lookUpMaterial.Properties.DataSource = new TransactiontypeBLL().GetByStockTransaction(enumStockTransaction.Out);
            lookUpWrapping.Properties.DataSource = lookUpMaterial.Properties.DataSource;
            lookUpInMaterial.Properties.DataSource = new TransactiontypeBLL().GetByStockTransaction(enumStockTransaction.In);
        }
        public int ValidateInputData()
        {
            if (lookUpMaterial.EditValue == null) return -1;
            if (lookUpWrapping.EditValue == null) return -2;
            if (lookUpInMaterial.EditValue == null) return -3;
            return 0;
        }
      
    }
}
