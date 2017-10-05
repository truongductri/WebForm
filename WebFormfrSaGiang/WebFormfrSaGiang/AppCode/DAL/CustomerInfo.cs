using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormfrSaGiang.AppCode.DAL
{
    public class CustomerInfo
    {
        public CustomerInfo()
        {

        }
        private int _CustomerID;

        public int CustomerID
        {
            get { return _CustomerID; }
            set { _CustomerID = value; }
        }
        private string _CustomerNo;

        public string CustomerNo
        {
            get { return _CustomerNo; }
            set { _CustomerNo = value; }
        }
        private string _CustomerName;

        public string CustomerName
        {
            get { return _CustomerName; }
            set { _CustomerName = value; }
        }
        private string _CustomerVATNo;

        public string CustomerVATNo
        {
            get { return _CustomerVATNo; }
            set { _CustomerVATNo = value; }
        }
        private string _CustomerAddress1;

        public string CustomerAddress1
        {
            get { return _CustomerAddress1; }
            set { _CustomerAddress1 = value; }
        }
        private string _CustomerAddress2;

        public string CustomerAddress2
        {
            get { return _CustomerAddress2; }
            set { _CustomerAddress2 = value; }
        }

        private string _CustomerEmail;

        public string CustomerEmail
        {
            get { return _CustomerEmail; }
            set { _CustomerEmail = value; }
        }
        private DateTime _CustomerBirthday;

        public DateTime CustomerBirthday
        {
            get { return _CustomerBirthday; }
            set { _CustomerBirthday = value; }
        }

        private string _CustomerPhone;

        public string CustomerPhone
        {
            get { return _CustomerPhone; }
            set { _CustomerPhone = value; }
        }
        private string _CustomerFax;

        public string CustomerFax
        {
            get { return _CustomerFax; }
            set { _CustomerFax = value; }
        }
        private string _CustomerWebsite;

        public string CustomerWebsite
        {
            get { return _CustomerWebsite; }
            set { _CustomerWebsite = value; }
        }
        private string _CustomerNotes;

        public string CustomerNotes
        {
            get { return _CustomerNotes; }
            set { _CustomerNotes = value; }
        }
        private int _BranchID;

        public int BranchID
        {
            get { return _BranchID; }
            set { _BranchID = value; }
        }
        private int _CustomerStatus;

        public int CustomerStatus
        {
            get { return _CustomerStatus; }
            set { _CustomerStatus = value; }
        }

        private string _CustomerPresent;

        public string CustomerPresent
        {
            get { return _CustomerPresent; }
            set { _CustomerPresent = value; }
        }
        private string _CustomerDemo;

        public string CustomerDemo
        {
            get { return _CustomerDemo; }
            set { _CustomerDemo = value; }
        }
        private string _CustomerQuotes;

        public string CustomerQuotes
        {
            get { return _CustomerQuotes; }
            set { _CustomerQuotes = value; }
        }
        private string _CustomerContract;

        public string CustomerContract
        {
            get { return _CustomerContract; }
            set { _CustomerContract = value; }
        }
        private DateTime _CustomerDateCreate;

        public DateTime CustomerDateCreate
        {
            get { return _CustomerDateCreate; }
            set { _CustomerDateCreate = value; }
        }

        private DateTime _CustomerLastUpdate;

        public DateTime CustomerLastUpdate
        {
            get { return _CustomerLastUpdate; }
            set { _CustomerLastUpdate = value; }
        }

        private int _CustomerUserCreate;

        public int CustomerUserCreate
        {
            get { return _CustomerUserCreate; }
            set { _CustomerUserCreate = value; }
        }
        private int _CustomerUserUpdate;

        public int CustomerUserUpdate
        {
            get { return _CustomerUserUpdate; }
            set { _CustomerUserUpdate = value; }
        }
        private int _CustomerSaleDirector;

        public int CustomerSaleDirector
        {
            get { return _CustomerSaleDirector; }
            set { _CustomerSaleDirector = value; }
        }
        private int _SaleMan1;

        public int SaleMan1
        {
            get { return _SaleMan1; }
            set { _SaleMan1 = value; }
        }
        private int _SaleMan2;

        public int SaleMan2
        {
            get { return _SaleMan2; }
            set { _SaleMan2 = value; }
        }
        private int _CustomerProvider;

        public int CustomerProvider
        {
            get { return _CustomerProvider; }
            set { _CustomerProvider = value; }
        }
        private string _AttachFile;

        public string AttachFile
        {
            get { return _AttachFile; }
            set { _AttachFile = value; }
        }
    }
}