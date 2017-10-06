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
            string strSQL = "select '0' as StatusID,N'Tất cả' as StatusName";
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

        //////////////////////////////////
        public DataTable Get_CustomerBranch() 
        {
            string strSQL = "select '0' as BranchID,N'Chưa xác định' as BranchName";
            strSQL += " union select BranchID,BranchName from Branch";
            return db.getDataTable(strSQL);

        }
        public DataTable Get_Director()
        {
            string strSQL = "select AccountID, AccountFullName  from UserAccount Where Disabled = 0";
            return db.getDataTable(strSQL);
        }
        // get for sale 1 and sale 2
        public DataTable Get_SaleDirectornone()
        {
            string strSQL = "select 0 as AccountID,N'Chưa có' as AccountFullName";
            strSQL += " union all select AccountID,AccountFullName from UserAccount where Disabled = 0  and AccountID <> 1";//GroupID in (8,9) and 
            return db.getDataTable(strSQL);
        }
        public DataTable Get_ContractProvider()
        {
            string strSQL = "select '0' as StatusID,N'Tất cả' as StatusName";
            strSQL += " union select StatusID, StatusName from Status Where StatusNotes='ContractProvider'";
            return db.getDataTable(strSQL);
        }
        //xem lại
        public bool UpdateAttachFile(string filename, string cpid)
        {
            string strSQL = "UPDATE [dbo].[CustomerProfile] ";
            strSQL += "SET [AttachFile] = N'" + filename + "'";
            strSQL += " where CPID = " + cpid;
            int x = db.excuteNonQuery_Connect(strSQL);
            if (x > 0)
            {
                return true;
            }
            return false;
        }
    }
}