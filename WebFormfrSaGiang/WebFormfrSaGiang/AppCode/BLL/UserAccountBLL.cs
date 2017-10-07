using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebFormfrSaGiang.AppCode.DAL;

namespace WebFormfrSaGiang.AppCode.BLL
{
    public class UserAccountBLL
    {
        DBConnection db;
        public UserAccountBLL()
        {
            db = new DBConnection();
        }

        //Lấy time theo server ...>>Dtaime.Now
        public DateTime GetDateTimeNow()
        {
            string strSQL = "select GETDATE()";
            return Convert.ToDateTime(db.getDataTable(strSQL).Rows[0][0].ToString());
        }

        public DataTable Get_UserAccount()
        {
            string strSQL = "select '0' as AccountID,N'Tất cả' as AccountFullName";
            strSQL += " union select AccountID, AccountFullName  from UserAccount Where AccountID <> 1 and Disabled = 0";
            return db.getDataTable(strSQL);

        }
    }
}