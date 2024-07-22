using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VNS.ERP.GUI.Transports
{
    public partial class FormSelectSTForBXResult : VNS.Windows.Forms.FormBase
    {
        private DataSet dataSource;

        public DataSet DataSource
        {
            get { return dataSource; }
            set
            {
                dataSource = value;
                this.gridControl1.DataSource = dataSource.Tables[0];
            }
        }
        public object ServiceDataSource
        {
            set { this.lokServiceID.Properties.DataSource = value; }
        }
        public Guid SelectedService
        {
            get { return (Guid)this.lokServiceID.EditValue; }
        }
        public object WorkingTypeDataSource
        {
            set { this.lokWorkingType.Properties.DataSource = value; }
        }
        public string SelectedWorkingType
        {
            get { return this.lokWorkingType.EditValue.ToString(); }
        }
        public object ToBXDataSource
        {
            set { this.lokToBX.Properties.DataSource = value; }
        }
        public string SelectedToBX
        {
            get { return this.lokToBX.EditValue.ToString(); }
        }
        public int SelectedSonguoi
        {
            get { return (int)this.txtSonguoi.EditValue; }
        }
        public FormSelectSTForBXResult()
        {
            InitializeComponent();
        }

        private void FormSelectSTForBXResult_Load(object sender, EventArgs e)
        {
            this.lokServiceID.ItemIndex = 0;
            this.lokWorkingType.ItemIndex = 0;
            this.lokToBX.ItemIndex = 0;
            this.txtSonguoi.EditValue = 0;
        }
    }
}

