using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebFormfrSaGiang.AppCode.DAL;

namespace WebFormfrSaGiang.AppCode.BLL
{
    public class CustomerBLL
    {
        DBConnection db; 
        public CustomerBLL()
        {
            db = new DBConnection();
        }
        public DataTable Get_Customer()
        {
            string strSQL = "select '0' as CustomerID,N'Tất cả' as CustomerNo";
            strSQL += " union select CustomerID,CustomerNo from Customer";
            return db.getDataTable(strSQL);
           
        }
        public DataTable Get_CustomerStatus()
        {
            string strSQL = "select '0' as StatusID,N'Tất cả' as statusName";
            strSQL += " union select StatusID,StatusName from Status Where StatusNotes = 'Customer'";
            return db.getDataTable(strSQL);

        }
        public DataTable GetBy_KeySearch(string KeySearch, string CustomerStatus, string Customer)
        {
            string strSQL = "select * from Customer where  (CustomerNo like N'%" + KeySearch + "%' or  CustomerName like N'%" + KeySearch + "%' or CustomerVATNo like N'%" + KeySearch + "%') ";
            if (CustomerStatus != "0")
            {
                strSQL += " and CustomerStatus = " + CustomerStatus;
            }
            if (Customer != "0")
            {
                strSQL += " and CustomerSaleDirector = " + Customer;
            }
            strSQL += " order by CustomerNo";
            return db.getDataTable(strSQL);
        }
    }
}