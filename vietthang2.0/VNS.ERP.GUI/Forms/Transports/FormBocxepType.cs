using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.Common;

namespace VNS.ERP.GUI.Transports
{
    public partial class FormBocxepType : FormEditBase
    {
        BocxepTypeBLL obj = new BocxepTypeBLL();
        //ListBase<enums> lstBocxepType;
        public FormBocxepType()
        {
           
            //lstBocxepType = obj.GetAll();
           // this.LookUpEditAccountType.DataSource = lstBocxepType;
           // this.ItemLookUpEditClsTypeCode.DataSource = new AccountClassificationTypeBLL().GetAll();
            //loo
            InitializeComponent();
            this.EditControl = this.ucBocXepType1;
            this.Business  = obj;
            this.DataSource = obj.GetAll();
        }

        private void ucBocXepType1_Load(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void FormBocxepType_Load(object sender, EventArgs e)
        {

        }

        

       
    }
}