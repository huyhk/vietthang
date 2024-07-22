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

namespace VNS.ERP.GUI.UserControl
{
    public partial class DetailGroupWeightItemDetail : EditControlBase
    {
        //;lstStockTransportBLLObj = new StockTransportBLL()
        private decimal savelbValue0;
        private decimal savelbValue1;
        private decimal savelbValue2;
        private bool _isReceive;
        public bool isReceive
        {
            get { return _isReceive; }
            set 
            {
                _isReceive = value;
                if (_isReceive)
                {
                    lbKhoGiao.Visible = true;
                    lookUpEditKhoGiao.Visible = true;
                    lbDVGiao.Visible = true;
                    lookUpEditDVGiao.Visible = true;

                    lbKhoNhan.Visible = false;
                    lookUpEditKhoNhan.Visible = false;
                    lbDVNhan.Visible = false;
                    lookUpEditDVNhan.Visible = false;
                }
                else
                {
                    lbKhoGiao.Visible = false;
                    lookUpEditKhoGiao.Visible = false;
                    lbDVGiao.Visible = false;
                    lookUpEditDVGiao.Visible = false;

                    lbKhoNhan.Visible = true;
                    lookUpEditKhoNhan.Visible = true;
                    lbDVNhan.Visible = true;
                    lookUpEditDVNhan.Visible = true;
                    lbKhoNhan.Left = lbKhoGiao.Left;
                    lookUpEditKhoNhan.Left = lookUpEditKhoGiao.Left;
                    lbDVNhan.Left = lbDVGiao.Left;
                    lookUpEditDVNhan.Left = lookUpEditDVGiao.Left;
                }
            }
        }
        private int DetailNotOK = 0;
        ListBase<StockLocation> lstStockLocation;
        private const int numTransportCode = 6;
        private const int numTransportCodeExists = 10;
        DetailWeighItemDetail[] detailWeighItemDetailObj = new DetailWeighItemDetail[numTransportCode];
        //string[] transportCode = new string[numTransportCode];
        string[] saveTransportCode = new string[numTransportCodeExists];
        decimal[] SavetransportWeight = new decimal[numTransportCodeExists];
        string[] saveTransportCodeDisplay = new string[numTransportCodeExists];
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lstTransport"></param>
        public void SetTransports(object lstTransport)
        {
            //int i = 0;
            int k;
            int i;
            for (k = 0; k < numTransportCode; k++)
            {
                detailWeighItemDetailObj[k].ClearAllItemInLstInvisibleStock();
            }
            i = 0;
            foreach (StockTransport st in (lstTransport as ListBase<StockTransport>))
            {
                for (k = 0; k < numTransportCode; k++)
                {
                    detailWeighItemDetailObj[k].AddItemTolstInVisibleStock("Xe " + st.StockTransportCode);
                    //detailWeighItemDetailObj[k].SetDataSourceLstInVisibleStock(new StockTransportBLL().GetAll(st.StockTransportCode), ""
                   
                }

                saveTransportCode[i] = st.StockTransportCode;
                saveTransportCodeDisplay[i] = "Xe " + st.StockTransportCode;
                SavetransportWeight[i] = st.Weight;
                i += 1;
                //if (i < numTransportCode)
                //{
                    
                //    detailWeighItemDetailObj[i].SetLbTitleText(st.StockTransportCode);
                //    detailWeighItemDetailObj[i].Enabled = true;
                //    transportCode[i] = st.StockTransportCode;
                //    transportWeight[i] = st.Weight;
                //    if (this.editMode == FormEditMode.ADD)
                //    {
                //        detailWeighItemDetailObj[i].SetAddNewOREditStatus();
                //    }
                //    i++;
                //}
                //else
                //{
                //    for (k = 0; k < numTransportCode; k++)
                //    {
                //        detailWeighItemDetailObj[k].AddItemTolstInVisibleStock("Xe " + st.StockTransportCode);
                //    }
                //    i++;
                //}
            }
            //for (int j = i; j < numTransportCode; j++)
            //{
            //    detailWeighItemDetailObj[j].ClearAllItemInLstInvisibleStock();
            //    detailWeighItemDetailObj[j].Enabled = false;
            //    detailWeighItemDetailObj[j].SetViewStatus();
            //    transportCode[j] = "";
            //    detailWeighItemDetailObj[j].SetLbTitleText("");
            //    transportWeight[j] = -1;
            //}
        }

        private void RefeshGroupLists()
        {
            WeightItem crentItem = (dataSource as WeightItem);
            //crentItem.WrappingWeight = Convert.ToDecimal(txtWrappingWeight.Text);
            ListBase<GroupWeightItemDetailForTransportCode> lstgwidftc = new ListBase<GroupWeightItemDetailForTransportCode>();
            ListBase<WeightItemResult> lstwir = new ListBase<WeightItemResult>();
            GroupWeightItemDetailForTransportCode gwidftc;
            WeightItemResult wir;
            if (lstStockLocation != null)
            {
                if (this.EditMode == FormEditMode.VIEW)
                {
                    lstwir = new WeightItemBLL().GetWeightItemResult(crentItem.WeightID);
                }
                else
                {
                    foreach (StockLocation sl in lstStockLocation)
                    {
                        wir = new WeightItemResult();
                        // wir.WeightID=crentItem.WeightID;
                        wir.StockLocationCode = sl.StockLocationCode;
                        wir.Weight = 0;
                        lstwir.Add(wir);
                    }
                }
            }
            decimal d = 0;
            int TotalWrapping = 0;
            decimal TotalSkinTransport = 0;
            int SaveDetailNotOK;
            DetailNotOK = 0;
            for (int i = 0; i < numTransportCode; i++)
            {
                if (detailWeighItemDetailObj[i].TransportCode != "" && detailWeighItemDetailObj[i].TransportCode != null)
                {
                    gwidftc = new GroupWeightItemDetailForTransportCode();
                    gwidftc.StockTransportCode = detailWeighItemDetailObj[i].TransportCode;
                    gwidftc.SkinTransport = detailWeighItemDetailObj[i].TransportWeight;
                    gwidftc.Count = crentItem.lstWeightItemDetail[i].Count;
                    if (gwidftc.Count > 0)
                    {
                        foreach (WeightItemDetail wid in crentItem.lstWeightItemDetail[i])
                        {
                            if (wid.Quantity + wid.Weight == 0) gwidftc.Count -= 1;
                        }
                    }
                    gwidftc.TotalWeight = gwidftc.Count * gwidftc.SkinTransport;
                    TotalSkinTransport += gwidftc.TotalWeight;
                    lstgwidftc.Add(gwidftc);
                    foreach (WeightItemDetail wid in crentItem.lstWeightItemDetail[i])
                    {
                        SaveDetailNotOK = DetailNotOK;

                        if (wid.Weight <= 0 && DetailNotOK == 0) DetailNotOK = -1;
                        //if (wid.Quantity <= 0 && DetailNotOK == 0) DetailNotOK = -2;
                        if ((wid.Quantity * Convert.ToDecimal(txtWrappingWeight.EditValue) + detailWeighItemDetailObj[i].TransportWeight >= wid.Weight) && (DetailNotOK == 0)) DetailNotOK = -3;
                        if (wid.StockLocationCode == null) DetailNotOK = -4;
                        if (wid.Quantity == 0 && wid.Weight == 0) DetailNotOK = SaveDetailNotOK;

                        TotalWrapping += wid.Quantity;
                        if (lstwir.Count > 0)
                        {
                            wir = lstwir.Search("StockLocationCode", wid.StockLocationCode);
                        }
                        else wir = null;
                        //gwidfsl.BeginEdit();
                        d += wid.Weight;
                        if (wir != null && this.EditMode != FormEditMode.VIEW)
                        {
                            if (wid.Quantity + wid.Weight != 0)
                            {
                                //wir.BeginEdit();
                                wir.Weight += (wid.Weight - detailWeighItemDetailObj[i].TransportWeight - Convert.ToDecimal(txtWrappingWeight.EditValue) * wid.Quantity);
                                //wir.EndEdit();
                            }
                            //CurrencyManager
                        }
                        //gwidfsl.EndEdit();
                    }

                }
                else break;
            }
            int countlstwir = lstwir.Count;
            int inti;
            decimal TotalWeightInLstwir = 0;
            for (inti = 0; inti < countlstwir; inti++)
            {
                lstwir.ResetItem(inti);
                lstwir[inti].Weight = Math.Round(lstwir[inti].Weight, 0);
                TotalWeightInLstwir += lstwir[inti].Weight;
                if (lstwir[inti].Weight == 0)
                {
                    lstwir.RemoveAt(inti);
                    inti -= 1;
                    countlstwir -= 1;
                }
            }
            lbValue0.Text = TotalWrapping.ToString();
            this.savelbValue0 = TotalWrapping;
            lbValue1.Text = Convert.ToDecimal(txtWrappingWeight.EditValue).ToString() + "kg";
            this.savelbValue1 = Convert.ToDecimal(txtWrappingWeight.EditValue);
            lbValue2.Text = Convert.ToString(Math.Round(TotalWrapping * Convert.ToDecimal(txtWrappingWeight.EditValue), 0)) + "kg";
            this.savelbValue2 = Math.Round(TotalWrapping * Convert.ToDecimal(txtWrappingWeight.EditValue), 0);
            
            if (this.EditMode == FormEditMode.VIEW)
            {
                txtWeight2.Text = Convert.ToString(crentItem.ItemWeight);
                txtWeight1.Text = Convert.ToString(crentItem.ItemWeight + Math.Round(TotalWrapping * Convert.ToDecimal(txtWrappingWeight.EditValue)));
            }
            else
            {
                txtWeight2.Text = Convert.ToString(d - TotalSkinTransport - Math.Round(TotalWrapping * Convert.ToDecimal(txtWrappingWeight.EditValue), 0));
                txtWeight1.Text = Convert.ToString(d - TotalSkinTransport);
                crentItem.ItemWeight = d - TotalSkinTransport - Math.Round(TotalWrapping * Convert.ToDecimal(txtWrappingWeight.EditValue));
            }
            //crentItem.BeginEdit();
            crentItem.Quantity = TotalWrapping;
            
            countlstwir = lstwir.Count;
            if (countlstwir > 0)
            {
                lstwir[countlstwir - 1].Weight += Convert.ToDecimal(txtWeight2.EditValue) - TotalWeightInLstwir;
            }
            crentItem.lstWeightItemResult = lstwir;
            //crentItem.EndEdit();
            gridControl1.DataSource = lstgwidftc;
            gridControl2.DataSource = lstwir;
        }
        //override cancel
        public override void Cancel()
        {
            //this.EditMode = FormEditMode.VIEW;
            base.Cancel();
           // this.RefeshGroupLists();
        }
        public DetailGroupWeightItemDetail()
        {
            InitializeComponent();
            detailWeighItemDetailObj[0]=this.usrDetailWeighItemDetail1;
            detailWeighItemDetailObj[1]=this.usrDetailWeighItemDetail2;
            detailWeighItemDetailObj[2]=this.usrDetailWeighItemDetail3;
            detailWeighItemDetailObj[3]=this.usrDetailWeighItemDetail4;
            detailWeighItemDetailObj[4]=this.usrDetailWeighItemDetail5;
            detailWeighItemDetailObj[5]=this.usrDetailWeighItemDetail6;
            for (int i = 0; i < numTransportCode; i++)
            {
                detailWeighItemDetailObj[i].OnStockCodeChanged += new DetailWeighItemDetail.StockCodeChanged(DetailGroupWeightItemDetail_OnStockCodeChanged);
            }
           
        }

        void DetailGroupWeightItemDetail_OnStockCodeChanged(object sender, string _NewStockCodeDisplay, string _OldStockCodeDisplay)
        {
            int i;
            int PosSender=0;
            //string oldStockCodeDisplay = (sender as DetailWeighItemDetail).GetTitleText();
            for (i = 0; i < numTransportCode; i++)
            {
                if (detailWeighItemDetailObj[i] == (sender as DetailWeighItemDetail)) 
                {
                    if ((DataSource as WeightItem).lstWeightItemDetail[i] == null)
                    { 
                        (DataSource as WeightItem).lstWeightItemDetail[i] = new ListBase<WeightItemDetail>();
                    }
                    detailWeighItemDetailObj[i].SetEnableStatus(_NewStockCodeDisplay != string.Empty || _NewStockCodeDisplay!="");
                    PosSender = i; break;
                }
            }
            //Note: reuse int i
            detailWeighItemDetailObj[PosSender].SetDataSource((DataSource as WeightItem).lstWeightItemDetail[PosSender]);
            for (i = 0; i < numTransportCodeExists; i++)
            {
                if (saveTransportCodeDisplay[i] == _NewStockCodeDisplay)
                {
                    (sender as DetailWeighItemDetail).TransportCode = saveTransportCode[i];
                    (sender as DetailWeighItemDetail).TransportWeight = SavetransportWeight[i];
                    break;
                }
            }
            //for (i = 0; i < numTransportCode; i++)
            //{
            //    detailWeighItemDetailObj[i].RemoveItemInLstInvisibleStock(_NewStockCodeDisplay);
            //    if (_OldStockCodeDisplay != "")
            //    {
            //        detailWeighItemDetailObj[i].AddItemTolstInVisibleStock(_OldStockCodeDisplay);
            //    }
            //}
        }

      




        protected override void AssignData()
        {
            if (dataSource == null) dataSource = new WeightItem();
            if (this.isReceive)
            {
                if (lookUpEditDVGiao.EditValue != null)
                {
                    (dataSource as WeightItem).DVGiao = lookUpEditDVGiao.EditValue.ToString();
                }
                else
                {
                    (dataSource as WeightItem).DVGiao = "";
                }
                if (lookUpEditKhoGiao.EditValue != null)
                {
                    (dataSource as WeightItem).KhoGiaoNhan = lookUpEditKhoGiao.EditValue.ToString();
                }
                else
                {
                    (dataSource as WeightItem).KhoGiaoNhan = "";
                }
            }
            else
            {
                if (lookUpEditDVNhan.EditValue != null)
                {
                    (dataSource as WeightItem).DVNhan = lookUpEditDVNhan.EditValue.ToString();
                }
                else
                {
                    (dataSource as WeightItem).DVNhan = "";
                }
                if (lookUpEditKhoNhan.EditValue != null)
                {
                    (dataSource as WeightItem).KhoGiaoNhan = lookUpEditKhoNhan.EditValue.ToString();
                }
                else
                {
                    (dataSource as WeightItem).KhoGiaoNhan = "";
                }
            }
            
            (dataSource as WeightItem).PTVanChuyen = txtPTVanChuyen.Text;
            if (lookUpEditDVVanChuyen.EditValue != null)
            {
                (dataSource as WeightItem).DVVanChuyen = lookUpEditDVVanChuyen.EditValue.ToString();
            }

            (dataSource as WeightItem).PTTayBoa = txtPTTayBoa.Text;
            if (lookupTransactionTypeCode.EditValue != null)
            {
                (dataSource as WeightItem).TransactionTypeCode = lookupTransactionTypeCode.EditValue.ToString();
            }
            if (lookUpStockCode.EditValue != null)
            {
                (dataSource as WeightItem).StockCode = lookUpStockCode.EditValue.ToString();
            }
            if (lookUpItem.EditValue != null)
            {
                (dataSource as WeightItem).ItemCode = lookUpItem.EditValue.ToString();
            }
            (dataSource as WeightItem).WeightCode = txtWeightCode.Text;
            if (lookUpEmp.EditValue != null)
            {
                (dataSource as WeightItem).EmployeeID = lookUpEmp.EditValue.ToString();
            }
            (dataSource as WeightItem).WeightDate = dEdit.DateTime;
            if (this.EditMode == FormEditMode.ADD)
            {
                (dataSource as WeightItem).UserCreated = Contexts.CurrentUser.LoginName;
                (dataSource as WeightItem).DateCreated = DateTime.Now;
            }
            (dataSource as WeightItem).UserUpdated = Contexts.CurrentUser.LoginName;
            (dataSource as WeightItem).DateUpdated = DateTime.Now;
            (dataSource as WeightItem).IsReceive = isReceive;
            (dataSource as WeightItem).Description = txtDescription.Text;
            (dataSource as WeightItem).WrappingWeight = Convert.ToDecimal(txtWrappingWeight.EditValue);
            base.AssignData();
        }

        public void SetTransportCodeToDetails()
        {
            for(int i =0; i< numTransportCode;i++)
            {
                if (detailWeighItemDetailObj[i].TransportCode != "")
                {
                    ListBase<WeightItemDetail> lstwid = (dataSource as WeightItem).lstWeightItemDetail[i];
                    foreach (WeightItemDetail wid in lstwid)
                    {
                        //wid.BeginEdit();
                        wid.StockTransportCode = detailWeighItemDetailObj[i].TransportCode;
                        //wid.EndEdit();
                    }
                }
                
            }
        }
        //public string[] GetLstStockCode()
        //{
        //    return this.transportCode;
        //}
        public void SetDataSourceLookupTransTypeCode(object obj)
        {
            lookupTransactionTypeCode.Properties.DataSource = obj;
        }
        public void SetDataSourceLookupEditDVVanChuyen(object obj)
        {
            lookUpEditDVVanChuyen.Properties.DataSource = obj;
        }
        public void SetDataSourceLookupEditKhoGiao(object obj)
        {
            lookUpEditKhoGiao.Properties.DataSource = obj;
        }
        public void SetDataSourceLookupEditKhoNhan(object obj)
        {
            lookUpEditKhoNhan.Properties.DataSource = obj;
        }
        public void SetDataSourceLookupEditDVGiao(object obj)
        {
            lookUpEditDVGiao.Properties.DataSource = obj;
        }
        public void SetDataSourceLookupEditDVNhan(object obj)
        {
            lookUpEditDVNhan.Properties.DataSource = obj;
        }
        public void SetDataSourceLookupItem(object obj)
        {
            lookUpItem.Properties.DataSource = obj;
        }
        public void SetDataSourceLookupEmp(object obj)
        {
            lookUpEmp.Properties.DataSource = obj;
        }
        public void SetDataSourceLookupStockCode(object obj)
        {
            lookUpStockCode.Properties.DataSource = obj;
        }
        public void SetStockCode(string stockCode)
        {
            lookUpStockCode.EditValue = stockCode;
        }

        protected override void BindData()
        {
            if (dataSource != null)
            {
                (dataSource as WeightItem).IsReceive = isReceive;
                //lookUpStockCode.EditValue=(dataSource as WeightItem).StockCode;
                
                //if(lookUpStockCode.EditValue==null)
                //{
                //    try
                //    {
                //        lookUpStockCode.EditValue = (lookUpStockCode.Properties.DataSource as ListBase<Stock>)[0].StockCode;
                //    }
                //    catch (Exception excp)
                //    {
                    
                //    }
                //}
                if (this.isReceive)
                {
                    lookUpEditKhoGiao.EditValue = (dataSource as WeightItem).KhoGiaoNhan;
                }
                else
                {
                    lookUpEditKhoNhan.EditValue = (dataSource as WeightItem).KhoGiaoNhan;
                }
                lookUpEditDVGiao.EditValue = (dataSource as WeightItem).DVGiao;
                lookUpEditDVNhan.EditValue = (dataSource as WeightItem).DVNhan;
                lookupTransactionTypeCode.EditValue = (dataSource as WeightItem).TransactionTypeCode;
                if (lookupTransactionTypeCode.EditValue == null)
                {
                    try
                    {
                        lookupTransactionTypeCode.EditValue = (lookupTransactionTypeCode.Properties.DataSource as ListBase<TransactionType>)[0].TransactionTypeCode;
                    }
                    catch
                    {
                    }
                }
                lookUpItem.EditValue=(dataSource as WeightItem).ItemCode;
                if (lookUpItem.EditValue== null)
                {
                    try
                    {
                        lookUpItem.EditValue = (lookUpItem.Properties.DataSource as ListBase<Item>)[0].ItemCode;
                    }
                    catch 
                    {

                    }
                }
                txtPTVanChuyen.Text = (dataSource as WeightItem).PTVanChuyen;
                lookUpEditDVVanChuyen.EditValue = (DataSource as WeightItem).DVVanChuyen;
                txtPTTayBoa.Text = (DataSource as WeightItem).PTTayBoa;
               
                txtWeightCode.Text=(dataSource as WeightItem).WeightCode;
                lookUpEmp.EditValue=(dataSource as WeightItem).EmployeeID;
                if (lookUpEmp.EditValue==null)
                {
                    try
                    {
                        lookUpEmp.EditValue=(lookUpEmp.Properties.DataSource as ListBase<Employee>)[0].EmployeeID;
                    }
                    catch 
                    {
                    }
                }
               
           
                dEdit.EditValue=(dataSource as WeightItem).WeightDate;
                txtDescription.Text=(dataSource as WeightItem).Description;
                txtWrappingWeight.Text=(dataSource as WeightItem).WrappingWeight.ToString();
            }
            for (int k = 0; k < numTransportCode; k++)
            {
                //detailWeighItemDetailObj[k].TransportCode = "";
                detailWeighItemDetailObj[k].SetLbTitleText("");
                detailWeighItemDetailObj[k].SetEnableStatus(false);
                detailWeighItemDetailObj[k].InvisibleLstStockCode();
            }
            object[] lstwidobj = (dataSource as WeightItem).lstWeightItemDetail;
            if (lstwidobj[0] == null && lstwidobj[1] == null && lstwidobj[2] == null && lstwidobj[3] == null && lstwidobj[4] == null && lstwidobj[5] == null)
            {
                int i;
                int j;
                //for (i = 0; i < numTransportCode; i++)
                //{
                //    if (transportCode[i] != "")
                //    {
                //        (dataSource as WeightItem).lstWeightItemDetail[i] = new ListBase<WeightItemDetail>();
                //    }
                //}
                if (this.editMode != FormEditMode.ADD)
                {
                    
                    j = 0;
                    ListBase<WeightItemDetail> lstwid = new WeightItemDetailBLL().GetByWeightID((DataSource as WeightItem).WeightID);
                    foreach (WeightItemDetail wid in lstwid)
                    {
                        bool StockNotFound = true;
                        for (i = 0; i < numTransportCode; i++)
                        {
                            if(wid.StockTransportCode==detailWeighItemDetailObj[i].TransportCode)
                            {
                                StockNotFound = false;
                                (dataSource as WeightItem).lstWeightItemDetail[i].Add(wid);
                                
                            }
                            if (i + 1 < numTransportCode)
                            {
                                if (detailWeighItemDetailObj[i + 1].TransportCode == "") i = numTransportCode;
                            }
                        }
                        if (StockNotFound)
                        {
                            detailWeighItemDetailObj[j].TransportCode = wid.StockTransportCode;
                            for (int k = 0; k < numTransportCodeExists; k++)
                            {
                                if (wid.StockTransportCode == saveTransportCode[k])
                                {
                                    detailWeighItemDetailObj[j].TransportWeight = SavetransportWeight[k];
                                    break;
                                }
                            }
                            detailWeighItemDetailObj[j].SetLbTitleText(detailWeighItemDetailObj[j].TransportCode);
                            detailWeighItemDetailObj[j].SetEnableStatus(true);
                            (dataSource as WeightItem).lstWeightItemDetail[j] = new ListBase<WeightItemDetail>();
                            (dataSource as WeightItem).lstWeightItemDetail[j].Add(wid);
                            //for(i=0;i<numTransportCode;i++)
                            //{
                            //    detailWeighItemDetailObj[j].RemoveItemInLstInvisibleStock("Xe "+ wid.StockTransportCode);
                            //}
                            j += 1;
                        }
                    }
                }  
            }
            else
            {
                for (int i = 0; i < numTransportCode; i++)
                {
                    if ((dataSource as WeightItem).lstWeightItemDetail[i] != null)
                    {
                        if ((dataSource as WeightItem).lstWeightItemDetail[i].Count > 0)
                        {
                            detailWeighItemDetailObj[i].TransportCode = (dataSource as WeightItem).lstWeightItemDetail[i][0].StockTransportCode;
                            for (int k = 0; k < numTransportCodeExists; k++)
                            {
                                if (saveTransportCode[k] == detailWeighItemDetailObj[i].TransportCode)
                                {
                                    detailWeighItemDetailObj[i].TransportWeight = SavetransportWeight[k];
                                    break;
                                }
                            }
                            detailWeighItemDetailObj[i].SetLbTitleText((dataSource as WeightItem).lstWeightItemDetail[i][0].StockTransportCode);
                            detailWeighItemDetailObj[i].SetEnableStatus(true);
                            //for (int k = 0; k < numTransportCode; k++)
                            //{
                            //    detailWeighItemDetailObj[k].RemoveItemInLstInvisibleStock("Xe " + (dataSource as WeightItem).lstWeightItemDetail[i][0].StockTransportCode);
                            //}
                        }
                    }
                }
            }
            for (int i = 0; i < numTransportCode; i++)
            {
                detailWeighItemDetailObj[i].SetDataSource((dataSource as WeightItem).lstWeightItemDetail[i]);
            }
            //this.EditMode = FormEditMode.VIEW;
           
            base.BindData();
            this.RefeshGroupLists();
        }
        public void RefeshDataSourceDetails()
        {
            if (this.editMode == FormEditMode.ADD) return;
            for (int i = 0; i < numTransportCode; i++)
            {
                detailWeighItemDetailObj[i].SetDataSource((dataSource as WeightItem).lstWeightItemDetail[i]);
            }
        }
        public override void RefreshControl()
        {
            for (int i = 0; i < numTransportCode; i++)
            {
                detailWeighItemDetailObj[i].InvisibleLstStockCode();
            }
            //lookUpStockCode.Properties.ReadOnly = (this.editMode == FormEditMode.VIEW || this.editMode == FormEditMode.EDIT);
            txtWeightCode.Properties.ReadOnly = (this.editMode == FormEditMode.VIEW);
            lookUpItem.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;
            lookUpEmp.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;
            lookupTransactionTypeCode.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;
            dEdit.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;
            txtDescription.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;
            txtWrappingWeight.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;
            txtPTVanChuyen.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;
            lookUpEditDVVanChuyen.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;
            txtPTTayBoa.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;
            lookUpEditKhoGiao.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW;
            lookUpEditKhoNhan.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW;
            lookUpEditDVGiao.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW;
            lookUpEditDVNhan.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW;
            button1.Enabled = this.EditMode == FormEditMode.VIEW;
            
            if (this.editMode == FormEditMode.ADD)
            {
                //this.lookUpStockCode.BackColor = txtBackGround.BackColor;
                this.lookUpItem.BackColor = txtBackGround.BackColor;
                this.lookupTransactionTypeCode.BackColor = txtBackGround.BackColor;
                this.txtWeightCode.BackColor = txtBackGround.BackColor;
                this.txtPTVanChuyen.BackColor = txtBackGround.BackColor;
                this.lookUpEditDVVanChuyen.BackColor = txtBackGround.BackColor;
                this.txtPTTayBoa.BackColor = txtBackGround.BackColor;
                this.lookUpEmp.BackColor = txtBackGround.BackColor;
                this.dEdit.BackColor = txtBackGround.BackColor;
                this.txtDescription.BackColor = txtBackGround.BackColor;
                this.txtWrappingWeight.BackColor = txtBackGround.BackColor;
                lookUpEditKhoGiao.BackColor = txtBackGround.BackColor;
                lookUpEditKhoNhan.BackColor = txtBackGround.BackColor;
                lookUpEditDVGiao.BackColor = txtBackGround.BackColor;
                lookUpEditDVNhan.BackColor = txtBackGround.BackColor;
                for (int i = 0; i < numTransportCode; i++)
                {
                    detailWeighItemDetailObj[i].SetAddNewOREditStatus();
                }
                txtWeightCode.Focus();
            }
            if (this.editMode == FormEditMode.EDIT)
            {
                //this.lookUpStockCode.BackColor = lbStockCode.BackColor;
                this.lookUpItem.BackColor = txtBackGround.BackColor;
                this.txtWeightCode.BackColor = txtBackGround.BackColor;
                this.txtPTVanChuyen.BackColor = txtBackGround.BackColor;
                this.lookUpEditDVVanChuyen.BackColor = txtBackGround.BackColor;
                this.txtPTTayBoa.BackColor = txtBackGround.BackColor;
                this.lookupTransactionTypeCode.BackColor = txtBackGround.BackColor;
                this.lookUpEmp.BackColor = txtBackGround.BackColor;
                this.dEdit.BackColor = txtBackGround.BackColor;
                this.txtDescription.BackColor = txtBackGround.BackColor;
                this.txtWrappingWeight.BackColor = txtBackGround.BackColor;
                lookUpEditKhoGiao.BackColor = txtBackGround.BackColor;
                lookUpEditKhoNhan.BackColor = txtBackGround.BackColor;
                lookUpEditDVGiao.BackColor = txtBackGround.BackColor;
                lookUpEditDVNhan.BackColor = txtBackGround.BackColor;
                for (int i = 0; i < numTransportCode; i++)
                {
                    detailWeighItemDetailObj[i].SetAddNewOREditStatus();
                }
                txtWeightCode.Focus();
            }
            if (this.editMode == FormEditMode.VIEW)
            {
                this.txtPTVanChuyen.BackColor = lbStockCode.BackColor;
                this.lookUpEditDVVanChuyen.BackColor = lbStockCode.BackColor;
                this.txtPTTayBoa.BackColor = lbStockCode.BackColor;
                this.lookupTransactionTypeCode.BackColor = lbStockCode.BackColor;
                this.lookUpStockCode.BackColor = lbStockCode.BackColor;
                this.lookUpItem.BackColor = lbStockCode.BackColor;
                this.txtWeightCode.BackColor = lbStockCode.BackColor;
                this.lookUpEmp.BackColor = lbStockCode.BackColor;
                this.dEdit.BackColor = lbStockCode.BackColor;
                this.txtDescription.BackColor = lbStockCode.BackColor;
                this.txtWrappingWeight.BackColor = lbStockCode.BackColor;
                lookUpEditKhoGiao.BackColor = lbStockCode.BackColor;
                lookUpEditKhoNhan.BackColor = lbStockCode.BackColor;
                lookUpEditDVGiao.BackColor = lbStockCode.BackColor;
                lookUpEditDVNhan.BackColor = lbStockCode.BackColor;
                for (int i = 0; i < numTransportCode; i++)
                {
                    detailWeighItemDetailObj[i].SetViewStatus();
                }
            }
            //this.RefeshGroupLists();
            if (this.DataSource == null)
            {
               // (dataSource as WeightItem).IsReceive = isReceive;

                txtWeightCode.Text = "";
                txtDescription.Text = "";
                txtWrappingWeight.Text = "0.00";

                for (int k = 0; k < numTransportCode; k++)
                {
                    //detailWeighItemDetailObj[k].TransportCode = "";
                    detailWeighItemDetailObj[k].SetLbTitleText("");
                    detailWeighItemDetailObj[k].SetEnableStatus(false);
                    detailWeighItemDetailObj[k].InvisibleLstStockCode();
                }
                for (int i = 0; i < numTransportCode; i++)
                {
                    detailWeighItemDetailObj[i].SetDataSource(null);
                }
                lbValue0.Text = "0.00";
                lbValue1.Text = "0.00" + "kg";
                lbValue2.Text = "0.00" + "kg";
                txtWeight1.Text = "0.00";
                txtWeight2.Text = "0.00";
             
                gridControl1.DataSource = null;
                gridControl2.DataSource = null;
            }
            base.RefreshControl();
        }
        //public override bool Save()
        //{
        //    this.RefeshGroupLists();
        //    return base.Save();
        //}
        private void DetailGroupWeightItemDetail_Resize(object sender, EventArgs e)
        {
            detailWeighItemDetailObj[0].Width = this.Width / numTransportCode - 2 * detailWeighItemDetailObj[0].Left;
            for (int i = 0; i <= numTransportCode - 1; i++)
            {
                detailWeighItemDetailObj[i].Width = detailWeighItemDetailObj[0].Width;
                detailWeighItemDetailObj[i].Left = i * detailWeighItemDetailObj[i].Width-i*5;
                //if (i > 0)
                //{
                //    detailWeighItemDetailObj[i].Left -= 3;
                //}
                //detailWeighItemDetailObj[i].Height = this.Height - detailWeighItemDetailObj[i].Top;
            }
        }

        private void lookUpStockCode_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpStockCode.EditValue != null && lookUpStockCode.Properties.DataSource !=null)
            {
                try
                {
                    Stock t = (lookUpStockCode.Properties.DataSource as ListBase<Stock>).Search("StockCode", lookUpStockCode.EditValue.ToString());
                    txtStockName.Text = t.StockName;
                }
                catch 
                {

                    //throw;
                }
                //txtStockName.Text = lookUpStockCode.Text;
                lstStockLocation = new StockLocationBLL().GetAll();
                int count = lstStockLocation.Count;
                for (int i = 0; i < count; i++)
                {
                    if (lstStockLocation[i].StockCode != lookUpStockCode.EditValue.ToString())
                    {
                        lstStockLocation.RemoveAt(i);
                        lstStockLocation.ResetItem(i);
                        i -= 1;
                        count -= 1;
                    }
                }
                for (int i = 0; i < numTransportCode; i++)
                {
                    detailWeighItemDetailObj[i].SetDataSourceLookupLocationCode(lstStockLocation);
                }

                this.SetTransports(new StockTransportBLL().GetAll(lookUpStockCode.EditValue.ToString()));
                //RefeshGroupLists();
            }
            else txtStockName.Text = "";
        }

        protected override int ValidateData()
        {
            this.RefeshGroupLists();
            this.SetTransportCodeToDetails();
            txtWeightCode.Text = txtWeightCode.Text.Trim();
            txtDescription.Text = txtDescription.Text.Trim();
            txtPTTayBoa.Text = txtPTTayBoa.Text.Trim();
            txtPTVanChuyen.Text = txtPTVanChuyen.Text.Trim();
          // txtDVVanChuyen.Text = txtDVVanChuyen.Text.Trim();
            if (lookUpStockCode.EditValue == null)
            {
                lookUpStockCode.Focus();
                return -1;
            }
            if (txtWeightCode.Text == "")
            {
                txtWeightCode.Focus();
                return -2;
            }
            if (Convert.ToDecimal(txtWrappingWeight.EditValue) < 0)
            {
                txtWrappingWeight.Focus();
                return -3;
            }
            if (lookUpItem.EditValue == null)
            {
                lookUpItem.Focus();
                return -4;
            }
            if (lookUpEmp.EditValue == null)
            {
                lookUpEmp.Focus();
                return -5;
            }
            if (DetailNotOK != 0) return -5 + DetailNotOK;//-6: Weight<=0; -7: Quantity<=0; -8:Quantity*WrappingWeight+TransportWeight<Weight; -9: StockLocationCode=null
           
            return base.ValidateData();
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            this.RefeshGroupLists();
        }

        private void lookUpItem_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpItem.EditValue != null && lookUpItem.Properties.DataSource != null)
            {
                try
                {
                    Item i = (lookUpItem.Properties.DataSource as ListBase<Item>).Search("ItemCode", lookUpItem.EditValue.ToString());
                    txtItemName.Text = i.ItemName;
                }
                catch 
                {

                    //throw;
                }

            }
        }

        private void lookUpEmp_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpEmp.EditValue != null && lookUpEmp.Properties.DataSource!=null)
            {
                Employee e1 = (lookUpEmp.Properties.DataSource as ListBase<Employee>).Search("EmployeeID", lookUpEmp.EditValue.ToString());
                if (e1 != null)
                {
                    txtEmployeeName.Text = e1.EmployeeName;
                }
                else
                {
                    txtEmployeeName.Text = "";
                }
            }
        }

        private void lookUpStockCode_MouseMove(object sender, MouseEventArgs e)
        {
            this.SetStatuslookUpStockCode();
        }

        private void lookUpStockCode_Enter(object sender, EventArgs e)
        {
            this.SetStatuslookUpStockCode();
        }
        private void SetStatuslookUpStockCode()
        {
            if (dataSource != null)
            {
                if (!lookUpStockCode.Properties.ReadOnly)
                {
                    WeightItem crentItem = (dataSource as WeightItem);
                    for (int i = 0; i < numTransportCode; i++)
                    {
                        if (crentItem.lstWeightItemDetail[i] != null)
                        {
                            if (crentItem.lstWeightItemDetail[i].Count > 0) lookUpStockCode.Properties.ReadOnly = true;
                        }
                    }
                }
            }
        }

        private void lookupTransactionTypeCode_EditValueChanged(object sender, EventArgs e)
        {
            if (lookupTransactionTypeCode.EditValue != null && lookupTransactionTypeCode.Properties.DataSource != null)
            {
                try
                {
                    TransactionType tt = (lookupTransactionTypeCode.Properties.DataSource as ListBase<TransactionType>).Search("TransactionTypeCode", lookupTransactionTypeCode.EditValue.ToString());
                    txtTransactionTypeCode.Text = tt.Description;
                }
                catch 
                {
                    txtTransactionTypeCode.Text = "";
                }

            }
            else
            {
                txtTransactionTypeCode.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WeightItem wi = this.DataSource as WeightItem;
            if (wi != null)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add(new DataColumn("SL1", Type.GetType("System.String")));
                dt.Columns.Add(new DataColumn("TL1", Type.GetType("System.Decimal")));
                dt.Columns.Add(new DataColumn("SB1", Type.GetType("System.Int32")));
                dt.Columns.Add(new DataColumn("SL2", Type.GetType("System.String")));
                dt.Columns.Add(new DataColumn("TL2", Type.GetType("System.Decimal")));
                dt.Columns.Add(new DataColumn("SB2", Type.GetType("System.Int32")));
                dt.Columns.Add(new DataColumn("SL3", Type.GetType("System.String")));
                dt.Columns.Add(new DataColumn("TL3", Type.GetType("System.Decimal")));
                dt.Columns.Add(new DataColumn("SB3", Type.GetType("System.Int32")));
                dt.Columns.Add(new DataColumn("SL4", Type.GetType("System.String")));
                dt.Columns.Add(new DataColumn("TL4", Type.GetType("System.Decimal")));
                dt.Columns.Add(new DataColumn("SB4", Type.GetType("System.Int32")));
                dt.Columns.Add(new DataColumn("SL5", Type.GetType("System.String")));
                dt.Columns.Add(new DataColumn("TL5", Type.GetType("System.Decimal")));
                dt.Columns.Add(new DataColumn("SB5", Type.GetType("System.Int32")));
                dt.Columns.Add(new DataColumn("SL6", Type.GetType("System.String")));
                dt.Columns.Add(new DataColumn("TL6", Type.GetType("System.Decimal")));
                dt.Columns.Add(new DataColumn("SB6", Type.GetType("System.Int32")));
                int j = 0;
                bool stopWhile = false;
                string[] transportCaption = new string[6];
                for (int i = 0; i < numTransportCode; i++)
                {
                    string transportCode = this.detailWeighItemDetailObj[i].TransportCode.Trim();
                    if (transportCode != string.Empty)
                    {
                        transportCaption[i] = "XE SỐ " + transportCode;
                    }
                    else
                    {
                        transportCaption[i] = string.Empty;
                    }
                }
                while (!stopWhile)
                {
                    stopWhile = true;
                    bool addRow = false;
                    DataRow dr = dt.NewRow();
                   
                    for (int i = 0; i < numTransportCode; i++)
                    {
                        if (wi.lstWeightItemDetail[i] != null)
                        {
                            if (wi.lstWeightItemDetail[i].Count > j)
                            {
                                dr[i * 3] = wi.lstWeightItemDetail[i][j].StockLocationCode;
                                dr[i * 3 + 1] = wi.lstWeightItemDetail[i][j].Weight;
                                dr[i * 3 + 2] = wi.lstWeightItemDetail[i][j].Quantity;
                                if (wi.lstWeightItemDetail[i].Count > j + 1) stopWhile = false;
                                addRow = true;
                            }
                        }
                    }
                    if (addRow) dt.Rows.Add(dr);
                    j++;
                }
                RpWeightItem rp = new RpWeightItem();
                RpWeightItem.Params pr = new RpWeightItem.Params();
                pr.weightItemObj = wi;
                pr.weight1 = Convert.ToDecimal(txtWeight1.Text);
                pr.soBao = this.savelbValue0;
                pr.biBao = this.savelbValue1;
                pr.tongBiBao = this.savelbValue2;
                ListBase<GroupWeightItemDetailForTransportCode> lstgwidftc = new ListBase<GroupWeightItemDetailForTransportCode>();
                ListBase<GroupWeightItemDetailForTransportCode> lstgwidftc1 = gridControl1.DataSource as ListBase<GroupWeightItemDetailForTransportCode>;
                foreach (GroupWeightItemDetailForTransportCode gwidftc1 in lstgwidftc1)
                {
                    GroupWeightItemDetailForTransportCode gwidftc = gwidftc1.Clone() as GroupWeightItemDetailForTransportCode;
                    lstgwidftc.Add(gwidftc);
                }
                while (lstgwidftc.Count < 6)
                {
                    GroupWeightItemDetailForTransportCode gwidftc = new GroupWeightItemDetailForTransportCode();
                    gwidftc.StockTransportCode = string.Empty;
                    lstgwidftc.Add(gwidftc);
                }
                pr.lstgwidftc = lstgwidftc;
                ListBase<WeightItemResult> lstwir = new ListBase<WeightItemResult>();
                ListBase<WeightItemResult> lstwir1 = gridControl2.DataSource as ListBase<WeightItemResult>;
                foreach (WeightItemResult wir1 in lstwir1)
                {
                    WeightItemResult wir = wir1.Clone() as WeightItemResult;
                    wir.StockLocationCode = "Cây hàng " + wir1.StockLocationCode + ":";
                    lstwir.Add(wir);
                }
                pr.lstwir = lstwir;
                pr.stockName = txtStockName.Text;
                pr.itemName = txtItemName.Text;
                pr.nVCan = txtEmployeeName.Text;
                pr.description = txtTransactionTypeCode.Text;
                //pr.customer = lookUpEditDVGiao.GetColumnValue("SubjectName").ToString();
                pr.transportCaption = transportCaption;
                if (lookUpEditDVGiao.Visible) pr.customer = lookUpEditDVGiao.GetColumnValue("SubjectName").ToString();
                else pr.customer = lookUpEditDVNhan.GetColumnValue("SubjectName").ToString();
                pr.donviVanChuyen = lookUpEditDVVanChuyen.GetColumnValue("SubjectName").ToString();

                pr.data = dt;

                rp.RpParams = pr;
                //rp.DataSource = dt;
                rp.BindData();
                rp.ShowPreviewDialog();
            }
        }
    }
}
