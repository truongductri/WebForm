using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormfrSaGiang.AppCode.DAL
{
    public class ContactInfo
    {
        public ContactInfo()
        {

        }
         
        private int _ContactID;

        public int ContactID
        {
            get { return _ContactID; }
            set { _ContactID = value; }
        }

        private string _ContactName;

        public string ContactName
        {
            get { return _ContactName; }
            set { _ContactName = value; }
        }
        private string _ContactPhone;

        public string ContactPhone
        {
            get { return _ContactPhone; }
            set { _ContactPhone = value; }
        }
        private string _ContactEmail;

        public string ContactEmail
        {
            get { return _ContactEmail; }
            set { _ContactEmail = value; }
        }
        private string _ContactAddress;

        public string ContactAddress
        {
            get { return _ContactAddress; }
            set { _ContactAddress = value; }
        }
        private string _ContactNotes;

        public string ContactNotes
        {
            get { return _ContactNotes; }
            set { _ContactNotes = value; }
        }
        private string _ContactPosition;

        public string ContactPosition
        {
            get { return _ContactPosition; }
            set { _ContactPosition = value; }
        }
        private int _CustomerID;

        public int CustomerID
        {
            get { return _CustomerID; }
            set { _CustomerID = value; }
        }
        private int _ContactUserCreate;

        public int ContactUserCreate
        {
            get { return _ContactUserCreate; }
            set { _ContactUserCreate = value; }
        }
        private int _ContactUserUpdate;

        public int ContactUserUpdate
        {
            get { return _ContactUserUpdate; }
            set { _ContactUserUpdate = value; }
        }
        private string _ContactDateCreate;

        public string ContactDateCreate
        {
            get { return _ContactDateCreate; }
            set { _ContactDateCreate = value; }
        }
        private string _ContactDateUpdate;

        public string ContactDateUpdate
        {
            get { return _ContactDateUpdate; }
            set { _ContactDateUpdate = value; }
        }
        private bool _ContactDisabled;

        public bool ContactDisabled
        {
            get { return _ContactDisabled; }
            set { _ContactDisabled = value; }
        }
    }

}