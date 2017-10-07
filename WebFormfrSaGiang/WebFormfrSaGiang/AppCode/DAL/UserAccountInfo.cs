using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormfrSaGiang.AppCode.DAL
{
    public class UserAccountInfo
    {
        
            public UserAccountInfo()
            {
                //
                // TODO: Add constructor logic here
                //
            }
            private int _AccountID;

            public int AccountID
            {
                get { return _AccountID; }
                set { _AccountID = value; }
            }
            private string _AccountName;

            public string AccountName
            {
                get { return _AccountName; }
                set { _AccountName = value; }
            }
            private string _AccountPassword;

            public string AccountPassword
            {
                get { return _AccountPassword; }
                set { _AccountPassword = value; }
            }
            private string _AccountFullName;

            public string AccountFullName
            {
                get { return _AccountFullName; }
                set { _AccountFullName = value; }
            }
            private string _AccountEmail;

            public string AccountEmail
            {
                get { return _AccountEmail; }
                set { _AccountEmail = value; }
            }
            private DateTime _AccountDateCreate;

            public DateTime AccountDateCreate
            {
                get { return _AccountDateCreate; }
                set { _AccountDateCreate = value; }
            }
            private DateTime _AccountLastUpdate;

            public DateTime AccountLastUpdate
            {
                get { return _AccountLastUpdate; }
                set { _AccountLastUpdate = value; }
            }
            private int _GroupID;

            public int GroupID
            {
                get { return _GroupID; }
                set { _GroupID = value; }
            }
            private int _DepartmentID;

            public int DepartmentID
            {
                get { return _DepartmentID; }
                set { _DepartmentID = value; }
            }
            private bool _Disabled;

            public bool Disabled
            {
                get { return _Disabled; }
                set { _Disabled = value; }
            }
        }
}