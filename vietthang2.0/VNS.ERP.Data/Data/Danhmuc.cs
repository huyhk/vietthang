using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;

namespace VNS.ERP.Data
{
    public class Danhmuc
    {
        static ListBase<Item> itemAll;
        public static ListBase<Item> ItemAll
        {
            get 
            {
                if (itemAll==null)
                    itemAll = new ItemBLL().GetAll();
                return itemAll;
            }
        }

        static ListBase<Stock> stockAll;
        public static ListBase<Stock> StockAll
        {
            get
            {
                if (stockAll == null)
                    stockAll = new StockBLL().GetAll();
                return stockAll;
            }
        }
        static ListBase<Stock> stockMember;
        public static ListBase<Stock> StockMember
        {
            get
            {
                if (stockMember == null)
                    stockMember = new StockBLL().GetAllForMember(Contexts.CurrentUser.MemberID);
                return stockMember;
            }
        }
        static ListBase<Stock> stockAllBlank;
        public static ListBase<Stock> StockAllBlank
        {
            get
            {
                if (stockAllBlank == null)
                {
                    stockAllBlank = new StockBLL().GetAll();
                    stockAllBlank.Insert(0, new Stock());
                }
                return stockAllBlank;
            }
        }

        static ListBase<Employee> employeeScale;
        public static ListBase<Employee> EmployeeScale
        {
            get
            {
                if (employeeScale == null)
                    employeeScale = new EmployeeBLL().GetListObjectByEmployeeGroupCode(enumEmployeeGroup.EmployeeWeight.ToString());
                return employeeScale;
            }
        }

        static ListBase<Vendor> vendorTransport;
        public static ListBase<Vendor> VendorTransport
        {
            get
            {
                if (vendorTransport == null)
                    vendorTransport = new VendorBLL().GetForVanchuyen();
                return vendorTransport;
            }
        }
        static ListBase<Vendor> vendorTransportBlank;
        public static ListBase<Vendor> VendorTransportBlank
        {
            get
            {
                if (vendorTransportBlank == null)
                {
                    vendorTransportBlank = new VendorBLL().GetForVanchuyen();
                    vendorTransportBlank.Insert(0, new Vendor());
                }
                return vendorTransportBlank;
            }
        }
        static ListBase<Vendor> vendorAllBlank;
        public static ListBase<Vendor> VendorAllBlank
        {
            get
            {
                if (vendorAllBlank == null)
                {
                    vendorAllBlank = new VendorBLL().GetAll();
                    vendorAllBlank.Insert(0, new Vendor());
                }
                return vendorAllBlank;
            }
        }

        static ListBase<Customer> customerAllBlank;
        public static ListBase<Customer> CustomerAllBlank
        {
            get
            {
                if (customerAllBlank == null)
                {
                    customerAllBlank = new CustomerBLL().GetAll();
                    customerAllBlank.Insert(0, new Customer());
                }
                return customerAllBlank;
            }
        }
        static ListBase<Subject> subjectAll;
        public static ListBase<Subject> SubjectAll
        {
            get
            {
                if (subjectAll == null)
                {
                    subjectAll = new SubjectBLL().GetAll();
                    //subjectAll.Insert(0, new Subject());
                }
                return subjectAll;
            }
        }

        static ListBase<TransactionType> transactionTypeAll;
        public static ListBase<TransactionType> TransactionTypeAll
        {
            get
            {
                if (transactionTypeAll == null)
                    transactionTypeAll = new TransactiontypeBLL().GetAll();
                return transactionTypeAll;
            }
        }
        static ListBase<TransactionType> transactionTypeScaleIn;
        public static ListBase<TransactionType> TransactionTypeScaleIn
        {
            get
            {
                if (transactionTypeScaleIn == null)
                    transactionTypeScaleIn = new TransactiontypeBLL().GetByStockTransactionContScale(enumStockTransaction.In);
                return transactionTypeScaleIn;
            }
        }
        static ListBase<TransactionType> transactionTypeScaleOut;
        public static ListBase<TransactionType> TransactionTypeScaleOut
        {
            get
            {
                if (transactionTypeScaleOut == null)
                    transactionTypeScaleOut = new TransactiontypeBLL().GetByStockTransactionContScale(enumStockTransaction.Out);
                return transactionTypeScaleOut;
            }
        }

        static ListBase<Vattu> vattuAll;
        public static ListBase<Vattu> VattuAll
        {
            get
            {
                if (vattuAll == null)
                    vattuAll = new VattuBLL().GetAll();
                return vattuAll;
            }
        }
    }
}
