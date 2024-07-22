using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.Common;
using VNS.ERP.Data;

namespace VNS.ERP.GUI
{
    public partial class FormTransactionType : FormEditBase
    {
        //private ListBase<TransactionType> lstTransactionTypeData;
        private TransactiontypeBLL _TransactiontypeBLL = new TransactiontypeBLL();
        //private int row;
        public FormTransactionType()
        {
            InitializeComponent();
            this.usrDetailTransactionType.SetDataSourceCboStockTransaction(EnumDisplays.GetListenumStockTransaction());
        }

        private void FormTransactionTypes_Load(object sender, EventArgs e)
        {
            //this.usrDetailTransactionType.SetDataSourceCboStockTransaction(EnumDisplays.GetListenumStockTransaction());
            this.DataSource= _TransactiontypeBLL.GetAll();
            
            Business = _TransactiontypeBLL;
        }

        
    }

        
}