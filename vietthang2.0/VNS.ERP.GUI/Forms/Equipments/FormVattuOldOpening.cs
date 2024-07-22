using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data.Equipments;
using VNS.ERP.Data;
using VNS.Windows;
using VNS.Common;

namespace VNS.ERP.GUI.Equipments
{
    public partial class FormVattuOldOpening : FormEditBase
    {
        VattuOldOpeningBLL bll = new VattuOldOpeningBLL();
        string txtPeriod, PeriodCode;
        public FormVattuOldOpening()
        {
            InitializeComponent();
            this.Business = bll;
            
        }

        private void FormVattuOldOpening_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                bll.PeriodCode = new PeriodBLL().GetMin().PeriodCode;
                this.lkpStock.Properties.DataSource = new StockBLL().GetAll();
                this.lkpStock.EditValueChanged += new EventHandler(lkpStock_EditValueChanged);
                this.lkpStock.ItemIndex = 0;
               //text form
                Period obj = new PeriodBLL().GetMin();
                this.txtPeriod = obj.StartDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
               // PeriodCode = obj.PeriodCode;
                this.Text = this.Text + " " + txtPeriod;
            
            }
        }
        public override void RefreshButtons()
        {
            base.RefreshButtons();
            bool viewMode = this.editMode == FormEditMode.VIEW;
            this.lkpStock.Properties.ReadOnly = !viewMode;
          
        }

        private void lkpStock_EditValueChanged(object sender, EventArgs e)
        {
            bll.StockCode = this.lkpStock.EditValue.ToString();
            //ListBase<object> lst = new ListBase<object>();
            //lst.Add(bll.GetOpening());
            //object obj = bll.GetOpening();
            VattuOldOpeningList obj = new VattuOldOpeningList();
            obj.ListVattuOldOpening = bll.GetOpening();
            this.DataSource = obj;
            //this.navigatorFrmEditBase.Visible = false;
   
        }

  
          
        

        //private void FormVattuOpening_Load(object sender, EventArgs e)
        //{
        //    if (!this.DesignMode)
        //    {
        //        bll.PeriodCode = new PeriodBLL().GetMin().PeriodCode;
        //        this.lkpStock.Properties.DataSource = new StockBLL().GetAll();
        //        this.lkpStock.EditValueChanged += new EventHandler(lkpStock_EditValueChanged);
        //    }
        //}

        //void lkpStock_EditValueChanged(object sender, EventArgs e)
        //{
        //    bll.StockCode = this.lkpStock.EditValue.ToString();
        //    //ListBase<object> lst = new ListBase<object>();
        //    //lst.Add(bll.GetOpening());
        //    //object obj = bll.GetOpening();
        //    VattuOpeningList obj = new VattuOpeningList();
        //    obj.ListVattuOpening = bll.GetOpening();
        //    this.DataSource = obj;
        //    //this.navigatorFrmEditBase.Visible = false;
        //}
    }
}