using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.KCS;
namespace VNS.ERP.GUI.KCS
{
    public partial class FormTechnicalTest : FormEditBase
    {
        public FormTechnicalTest()
        {
            InitializeComponent();
            this.Business = new TechnicalTestBLL();
            this.DataSource =new TechnicalTestBLL().GetAll();
        }

        private void FormTechnicalTest_Load(object sender, EventArgs e)
        {
            this.ucTechnicalTest1.SetDataSourceForLookUpEdit();
            this.lookUpResultType.DataSource = EnumDisplays.GetListenumResultTypeTechnicalTest();
            this.lookUpResultType.DisplayMember = "EnumText";
            this.lookUpResultType.ValueMember = "EnumName";
            
        }

    

       
    }
}