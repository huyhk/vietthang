using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.ERP.Data;
using VNS.ERP.Data.Sales;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class RpSaleRequestForItemMaster : XtraReport
    {
       private ListBase<SaleRequestDetails> lstDetail=new ListBase<SaleRequestDetails>();
        SaleRequests sale;
        ArrayList array;
        //ListBase<Item> lstItems;
        private DevExpress.XtraReports.UI.XRPageBreak xrPageBreak1 = new XRPageBreak();
        public RpSaleRequestForItemMaster()
        {
            InitializeComponent();
            
            this.PageHeader.Controls.Add(this.xrPageBreak1);
            this.xrPageBreak1.Location = new System.Drawing.Point(0, 108);
            this.xrPageBreak1.Name = "xrPageBreak1";
        }
        public RpSaleRequestForItemMaster(SaleRequests saleDetai,ArrayList arrayList,bool twoPage)
        {
            InitializeComponent();

            if (twoPage)
            {
                this.PageHeader.Controls.Add(this.xrPageBreak1);
                this.xrPageBreak1.Location = new System.Drawing.Point(0, 110);
                this.xrPageBreak1.Name = "xrPageBreak1";
            }


            sale = saleDetai.Clone() as SaleRequests;
            lstDetail = sale.Details;
            for (int i = 0; i < 6; i++)
            {
                if (lstDetail.Count < 6)
                {
                    lstDetail.AddNew();
                }
                else
                    break;
            }
            array = arrayList;
        }
        public void BindDataDetail()
        {
        
            array.Add("Liên 1:");
            array.Add("Lưu hồ sơ");
            this.subreport1.ReportSource.DataSource = lstDetail;
         
            (this.subreport1.ReportSource as RpSaleRequestForItemSub).BindDataDetail();
            (this.subreport1.ReportSource as RpSaleRequestForItemSub).BindDataMaster(sale,array);
            array.Insert(4, "Liên 2:");
            array.Insert(5, "Giao thủ kho");
            this.subreport2.ReportSource.DataSource = lstDetail;
           
            (this.subreport2.ReportSource as RpSaleRequestForItemSub).BindDataDetail();
            (this.subreport2.ReportSource as RpSaleRequestForItemSub).BindDataMaster(sale,array);
        }
    }
}
