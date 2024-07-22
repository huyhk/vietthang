using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;

namespace VNS.ERP.GUI.Transports
{
    public partial class FormEditBocxepResults : FormEditBase
    {
        BocxepResultBLL obj = new BocxepResultBLL();
        private string _subjectCode="";

        public string SubjectCode
        {
            get { return _subjectCode; }
            set { ucBocxepResults1.SubjectCode = value; }
        }
        private string _StockCode="";

        public string StockCode
        {
            get { return _StockCode; }
            set { ucBocxepResults1.StockCode = value; }
        }
        public FormEditBocxepResults()
        {
            InitializeComponent();
            this.EditControl = this.ucBocxepResults1;
            this.Business = obj;
           // this.DataSource = obj.GetAll();
        }
        public FormEditBocxepResults(string textform,string subjectcode,string stockcode)
        {
            InitializeComponent();
            //this.EditControl = this.ucBocxepResults1;
            this.Business = obj;
            //this.DataSource = obj.GetAll();
            this.SubjectCode = subjectcode;
            this.StockCode = stockcode;
            this.Text = textform;
        }
        //public FormEditBocxepResults(string textform)
        //{
        //    InitializeComponent();
        //    this.EditControl = this.ucBocxepResults1;
        //    this.business = obj;
        //    this.DataSource = obj.GetAll();
            
        //}
    }
}