using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebFormfrSaGiang.AppCode.DAL;

namespace WebFormfrSaGiang.AppCode.BLL
{
    public class ContactBLL
    {

        DBConnection dbConn;
        DataTable dt;
        public ContactBLL()
        {
            dbConn = new DBConnection();
            dt = new DataTable();
            
        }

        //hàm lấy về tất cả các người liên hệ
        public DataTable GetAll()
        {
            string strSQL = "select * from Contact Oder by ContactID DESC";
            return dbConn.getDataTable(strSQL);
        }
        //lấy về một người liên hệ theo id
        public ContactInfo GetBy_ContactID(int ContactId)
        {
            string strSQL = "select * from Contact Where ContactID =" + ContactId + " Order by ContactID DESC";
            dt = GetAll();
            ContactInfo info = new ContactInfo();
            if (dt.Rows.Count > 0)
            {
                info.ContactID = ContactId;
                info.ContactName = dt.Rows[0]["ContactName"].ToString();
                info.ContactNotes = dt.Rows[0]["ContactNotes"].ToString();
                info.ContactPhone = dt.Rows[0]["ContactPhone"].ToString();
                info.ContactEmail = dt.Rows[0]["ContactEmail"].ToString();
                info.ContactPosition= dt.Rows[0]["ContactPosition"].ToString();
                info.ContactUserCreate = (string.IsNullOrEmpty(dt.Rows[0]["ContactUserCreate"].ToString())==true ? -1: Convert.ToInt32(dt.Rows[0]["ContactUserCreate"].ToString()));
                info.ContactUserUpdate= (string.IsNullOrEmpty(dt.Rows[0]["ContactUserUpdate"].ToString()) == true ? -1 : Convert.ToInt32(dt.Rows[0]["ContactUserUpdate"].ToString()));
                info.CustomerID= (string.IsNullOrEmpty(dt.Rows[0]["CustomerID"].ToString()) == true ? -1 : Convert.ToInt32(dt.Rows[0]["CustomerID"].ToString()));
                info.ContactAddress = dt.Rows[0]["ContactAddress"].ToString();
                info.ContactDisabled = Convert.ToBoolean(dt.Rows[0]["ContactDisable"].ToString());
                info.ContactDateCreate = dt.Rows[0]["ContactDateCreate"].ToString();
                info.ContactDateUpdate = dt.Rows[0]["ContactDateUpdate"].ToString();
            }
            return info;
        }

        //Lấy về tất cả người liên hệ theo id khách hàng
        public DataTable GetAllContacter_ByCustomer(int customerID)
        {
            string strSQL = "select * from Contact Where CustomerID=" + customerID + "Order by DESC";
            return dbConn.getDataTable(strSQL);
        }

        //

    }
}