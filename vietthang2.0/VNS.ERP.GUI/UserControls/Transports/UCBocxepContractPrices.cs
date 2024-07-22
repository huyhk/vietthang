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
using VNS.Common;
using System.Collections;

namespace VNS.ERP.GUI.Transports
{
    public partial class UCBocxepContractPrices : EditControlBase
    {
        public UCBocxepContractPrices()
        {
            InitializeComponent();
        }
        private Guid contractID;

        public Guid ContractID
        {
            get { return contractID; }
            set { contractID = value; }
        }
        protected override void BindData()
        {
            if (DataSource != null)
            {
                this.txtDateStart.EditValue = (dataSource as BocxepContractPrice).StartDate;
                this.txtdescription.Text = (dataSource as BocxepContractPrice).Description;
                ListBase<Stock> lst = lstTypeCode.DataSource as ListBase<Stock>;
                foreach (Stock s in lst)
                {
                    BocxepContractPriceStock bxcps = (dataSource as BocxepContractPrice).DetailStock.Search("StockCode", s.StockCode);
                    if (bxcps == null) lstTypeCode.SetItemChecked(lst.IndexOf(s), false);
                    else
                    {
                        lstTypeCode.SetItemChecked(lst.IndexOf(s), true);
                    }
                }
                ListBase<Item> lstI = lstItem.DataSource as ListBase<Item>;
                foreach (Item s in lstI)
                {
                    BocxepContractPriceItem bxcps = (dataSource as BocxepContractPrice).DetailItem.Search("ItemCode", s.ItemCode);
                    if (bxcps == null) lstItem.SetItemChecked(lstI.IndexOf(s), false);
                    else
                    {
                        lstItem.SetItemChecked(lstI.IndexOf(s), true);
                    }
                }
                gridControl1.DataSource = (DataSource as BocxepContractPrice).Detail;
            }
        }
        
        protected override void InitDataObject()
        {
            if (!this.DesignMode)
            {
                ListBase<BocxepType> lstbxType = new BocxepTypeBLL().GetAll();
                ListBase<BocxepType> lstbxType1 = new ListBase<BocxepType>();
                foreach(BocxepType bt in lstbxType)
                {
                    lstbxType1.Add(bt.Clone() as BocxepType);
                }
                this.repositoryItemLookUpEdit1.DataSource = lstbxType;
                this.lstTypeCode.DataSource = new StockBLL().GetAll();
                this.lstItem.DataSource = new ItemBLL().GetAll();
                this.repositoryItemLookUpEdit1.DataSource = lstbxType1;
            }
        }
        protected override int ValidateData()
        {
            if (lstTypeCode.CheckedItems.Count == 0)
                return -3;

            this.txtdescription.Text = this.txtdescription.Text.Trim();
            BocxepContractPrice t = dataSource as BocxepContractPrice;
            foreach (BocxepContractPriceDetail tdetail in t.Detail)
            {
                if (tdetail.TypeCode == string.Empty)
                {
                    return -1;
                }
            }
            return 0;
            

        }
        protected override void AssignData()
        {
            if (dataSource == null)
                dataSource = new BocxepContractPrice();
            (dataSource as BocxepContractPrice).ContractID = this.ContractID;
            (dataSource as BocxepContractPrice).StartDate = this.txtDateStart.DateTime;
            (dataSource as BocxepContractPrice).Description = this.txtdescription.Text;
            (dataSource as BocxepContractPrice).DetailStock.Clear();
            for (int i = 0; i < lstTypeCode.CheckedItems.Count; i++)
            {
                BocxepContractPriceStock bxcps = new BocxepContractPriceStock();
                bxcps.StockCode = lstTypeCode.CheckedItems[i].ToString();

                (dataSource as BocxepContractPrice).DetailStock.Add(bxcps);
            }
            (dataSource as BocxepContractPrice).DetailItem.Clear();
            for (int i = 0; i < lstItem.CheckedItems.Count; i++)
            {
                BocxepContractPriceItem bxcps = new BocxepContractPriceItem();
                bxcps.ItemCode = lstItem.CheckedItems[i].ToString();

                (dataSource as BocxepContractPrice).DetailItem.Add(bxcps);
            }
            if (this.EditMode == VNS.Windows.FormEditMode.ADD)
            {
                (dataSource as BocxepContractPrice).UserCreated = Contexts.CurrentUser.LoginName;
                (dataSource as BocxepContractPrice).DateCreated = DateTime.Now;
            }
            (dataSource as BocxepContractPrice).UserUpdated = Contexts.CurrentUser.LoginName;
            (dataSource as BocxepContractPrice).DateUpdated = DateTime.Now;

            base.AssignData();
        }
        public override void RefreshControl()
        {
            if (this.editMode == FormEditMode.ADD)
            {
                this.lstTypeCode.CheckOnClick = true;
                this.lstItem.CheckOnClick = true;
                txtDateStart.Properties.ReadOnly = false;
                txtdescription.Properties.ReadOnly = false;
                gridView1.OptionsBehavior.Editable = true;
                gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            }
            else if (this.editMode == FormEditMode.EDIT)
            {
                this.lstTypeCode.CheckOnClick = true;
                this.lstItem.CheckOnClick = true;
                txtDateStart.Properties.ReadOnly = false;
                txtdescription.Properties.ReadOnly = false;
                gridView1.OptionsBehavior.Editable = true;
                gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

            }
            if(this.editMode == FormEditMode.VIEW)
            {
                this.lstTypeCode.CheckOnClick = false;
                this.lstItem.CheckOnClick = false;
                txtDateStart.Properties.ReadOnly = true;
                txtdescription.Properties.ReadOnly = true;
                gridView1.OptionsBehavior.Editable = false;
                gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            }
            if (this.DataSource == null)
            {
                txtdescription.Text = "";
                gridControl1.DataSource = null;
            }
            base.RefreshControl();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void txtdescription_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridView1_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            //if (e.Column.FieldName != "Result")
            //    return;
            ////if (e.RowHandle >= 0)
            ////{
            //object o = gridView1.GetRow(e.RowHandle);
            //if (o == null)
            //    return;
            //string techCode = (o as MaterialTestTransactionDetail).TechCode;
            //TechnicalTest tt = (reLookUpTechCode.DataSource as ListBase<TechnicalTest>).Search("TechCode", techCode);
            //if (tt != null)
            //{
            //    if (tt.ResultType == enumResultTypeTechnicalTest.Decimal.ToString())
            //    {
            //        if (("Result").Contains(e.Column.FieldName))
            //            e.RepositoryItem = repTxtDecimal;
            //    }
            //    if (tt.ResultType == enumResultTypeTechnicalTest.Text.ToString())
            //    {
            //        if (("Result").Contains(e.Column.FieldName))
            //            e.RepositoryItem = repTxtString;
            //    }
            //    if (tt.ResultType == enumResultTypeTechnicalTest.Percent.ToString())
            //    {
            //        if (("Result").Contains(e.Column.FieldName))
            //            e.RepositoryItem = repTxtPercent;
            //    }

            //} 
            ////}
        }

        private void gridView1_GotFocus(object sender, EventArgs e)
        {
            if (gridView1.DataRowCount == 0)
                gridView1.MoveFirst();
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.gridView1.FocusedRowHandle >= 0 && this.gridView1.OptionsBehavior.Editable == true)
            {
                if (e.KeyCode == Keys.Delete)
                    this.gridView1.DeleteRow(this.gridView1.FocusedRowHandle);
            }
            if (e.KeyCode == Keys.Insert && this.gridView1.OptionsBehavior.Editable == true)
            {
                if (this.gridView1.FocusedRowHandle < 0)
                { }
                else
                {
                    System.Type type = (gridView1.DataSource as IList)[0].GetType();
                    object obj = Activator.CreateInstance(type);
                    (gridView1.DataSource as IList).Insert(this.gridView1.FocusedRowHandle, obj);
                }
            }
        }
    
       
        
    }
}
