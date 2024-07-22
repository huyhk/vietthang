using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;

namespace VNS.ERP.GUI
{
    public partial class FormStockLocation : FormEditBase
    {
        #region Properties
        object lstDataSourceStockLocation;
        StockLocationBLL obj= new StockLocationBLL();
        #endregion
        public FormStockLocation()
        {
            InitializeComponent();
        }
        public FormStockLocation(string _sCode)
        {
            InitializeComponent();
            this.Business = obj;
            //obj._sCode = _sCode;
            lstDataSourceStockLocation = obj.GetByStockCode(_sCode);
            this.DataSource = lstDataSourceStockLocation;
        }
    }
}