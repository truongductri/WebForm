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
        public DataTable Get_Customer()
        {
            string strSQL = "select '0' as CustomerID,N'Tất cả' as CustomerName";
            strSQL += " union select CustomerID, CustomerName from Customer";
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
        public string UpdateCustomer(CustomerInfo customer)
        {
            string strSQL = "select top 1 1 from Customer where CustomerNo = N'" + customer.CustomerNo + "' and CustomerID <> " + customer.CustomerID;
            if (db.getDataTable(strSQL).Rows.Count > 0)
            {
                return "Mã khách hàng đã tồn tại";
            }
            else
            {
                strSQL = "UPDATE [dbo].[Customer]";
                strSQL += "SET [CustomerNo] = N'" + customer.CustomerNo + "'";
                strSQL += ",[CustomerName] = N'" + customer.CustomerName + "'";
                strSQL += ",[CustomerBirthday] = '" + (customer.CustomerBirthday.ToString("MM-dd-yyyy") == "01-01-0001" ? "" : customer.CustomerBirthday.ToString("MM-dd-yyyy hh:mm:ss")) + "'";
                strSQL += ",[CustomerVATNo] = N'" + customer.CustomerVATNo + "'";
                strSQL += ",[CustomerAddress1] = N'" + customer.CustomerAddress1 + "'";
                strSQL += ",[CustomerAddress2] = N'" + customer.CustomerAddress2 + "'";
                strSQL += ",[CustomerEmail] = N'" + customer.CustomerEmail + "'";
                strSQL += ",[CustomerPhone] = N'" + customer.CustomerPhone + "'";
                strSQL += ",[CustomerFax] = N'" + customer.CustomerFax + "'";
                strSQL += ",[CustomerWebsite] = N'" + customer.CustomerWebsite + "'";
                strSQL += ",[CustomerNotes] = N'" + customer.CustomerNotes + "'";
                strSQL += ",[BranchID] = " + (customer.BranchID == 0 ? "Null" : customer.BranchID.ToString());
                strSQL += ",[CustomerStatus] = " + (customer.CustomerStatus == 0 ? "Null" : customer.CustomerStatus.ToString());
                strSQL += ",[CustomerPresent] = N'" + customer.CustomerPresent + "'";
                strSQL += ",[CustomerDemo] = N'" + customer.CustomerDemo + "'";
                strSQL += ",[CustomerQuotes] = N'" + customer.CustomerQuotes + "'";
                strSQL += ",[CustomerContract] = N'" + customer.CustomerContract + "'";
                strSQL += ",[CustomerLastUpdate] = '" + (customer.CustomerLastUpdate.ToString("MM-dd-yyyy") == "01-01-0001" ? "" : customer.CustomerLastUpdate.ToString("MM-dd-yyyy hh:mm:ss")) + "'";
                strSQL += ",[CustomerUserUpdate] = " + customer.CustomerUserUpdate;
                strSQL += ",[CustomerSaleDirector] = " + customer.CustomerSaleDirector;
                strSQL += ",[SaleMan1] = " + customer.SaleMan1;
                strSQL += ",[SaleMan2] = " + customer.SaleMan2;
                strSQL += ",[CustomerProvider] = " + (customer.CustomerProvider == 0 ? "NULL" : customer.CustomerProvider.ToString());
                strSQL += " WHERE [CustomerID] = " + customer.CustomerID;
                int x = db.excuteNonQuery_Connect(strSQL);
                if (x > 0)
                {
                    return "";
                }
                return "Cập nhật thất bại";
            }
        }
            public string InsertCustomer(CustomerInfo customer)
        {
            string strSQL = "select top 1 1 from Customer where CustomerNo = N'" + customer.CustomerNo + "'";
            if (db.getDataTable(strSQL).Rows.Count > 0)
            {
                return "Mã khách hàng đã tồn tại";
            }
            else
            {
                strSQL = "Insert into Customer(CustomerNo,CustomerName,CustomerBirthday,CustomerVATNo,CustomerAddress1,CustomerAddress2,CustomerEmail,CustomerPhone,CustomerFax";
                strSQL += ",CustomerWebsite,CustomerNotes,BranchID,CustomerStatus,CustomerPresent,CustomerDemo,CustomerQuotes,CustomerContract,CustomerDateCreate,CustomerLastUpdate,CustomerUserCreate,CustomerUserUpdate,CustomerSaleDirector,SaleMan1,SaleMan2,CustomerProvider,AttachFile) Values(N'";
                strSQL += customer.CustomerNo + "',N'" + customer.CustomerName + "'";
                strSQL += "," + (customer.CustomerBirthday.ToString("MM-dd-yyyy") == "01-01-0001" ? "NULL" : "'" + customer.CustomerBirthday.ToString("MM-dd-yyyy hh:mm:ss") + "'");
                strSQL += ",N'" + customer.CustomerVATNo + "',N'" + customer.CustomerAddress1 + "',N'" + customer.CustomerAddress2 + "',N'";
                strSQL += customer.CustomerEmail + "','" + customer.CustomerPhone + "','" + customer.CustomerFax + "',N'" + customer.CustomerWebsite + "',N'" + customer.CustomerNotes + "'," + (customer.BranchID == 0 ? "Null" : customer.BranchID.ToString()) + "," + (customer.CustomerStatus == 0 ? "Null" : customer.CustomerStatus.ToString()) + ",'";
                strSQL += customer.CustomerPresent + "','" + customer.CustomerDemo + "','" + customer.CustomerQuotes + "','" + customer.CustomerContract + "',";
                strSQL += (customer.CustomerDateCreate.ToString("MM-dd-yyyy") == "01-01-0001" ? "NULL" : "'" + customer.CustomerDateCreate.ToString("MM-dd-yyyy hh:mm:ss") + "'") + ",";
                strSQL += (customer.CustomerLastUpdate.ToString("MM-dd-yyyy") == "01-01-0001" ? "NULL" : "'" + customer.CustomerLastUpdate.ToString("MM-dd-yyyy hh:mm:ss") + "'") + ",";
                strSQL += customer.CustomerUserCreate + "," + customer.CustomerUserUpdate + "," + customer.CustomerSaleDirector + "," + customer.SaleMan1 + "," + customer.SaleMan2 + "," + (customer.CustomerProvider == 0 ? "NULL" : customer.CustomerProvider.ToString()) + ",";
                strSQL += "N'" + customer.AttachFile + "')";


                int x = db.excuteNonQuery_Connect(strSQL);
                if (x > 0)
                {
                    return "Thêm thành công";
                }
                return "";
            }
        }
    }
    }
