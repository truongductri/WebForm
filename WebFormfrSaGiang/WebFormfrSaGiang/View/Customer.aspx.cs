using System;
using WebFormfrSaGiang.AppCode.BLL;

namespace WebFormfrSaGiang.View
{

    public partial class Customer : System.Web.UI.Page
    {
        public string customerNo, UserID;
        CustomerBLL db = new CustomerBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            Load_Customer();
            Load_CustomerStatus();
            Load_grvCustomer(customerNo, ddlCustomerStatus.SelectedValue, ddlCustomer.SelectedValue);
            
        }
       
        public void Load_Customer()
        {
            ddlCustomer.DataSource = db.Get_Customer();
            ddlCustomer.DataTextField = "CustomerNo";
            ddlCustomer.DataValueField = "CustomerID";
            ddlCustomer.DataBind();
        }
        public void Load_CustomerStatus()
        {
            ddlCustomerStatus.DataSource = db.Get_CustomerStatus(); 
            ddlCustomerStatus.DataTextField = "StatusName";
            ddlCustomerStatus.DataValueField = "StatusID";
            ddlCustomerStatus.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        public void Load_grvCustomer(string KeySearch, string CustomerStatus, string CustomerNo)
        {
            grvCustomer.DataSource = db.GetBy_KeySearch(KeySearch, CustomerStatus, CustomerNo);
            grvCustomer.DataBind();
        }

    }
}