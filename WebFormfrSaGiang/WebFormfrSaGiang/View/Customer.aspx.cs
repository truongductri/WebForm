using System;
using WebFormfrSaGiang.AppCode.BLL;

namespace WebFormfrSaGiang.View
{

    public partial class Customer : System.Web.UI.Page
    {
        public string customerNo, UserID;
        UserAccountBLL ua = new UserAccountBLL();
        CustomerBLL db = new CustomerBLL();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (txtSearch.Value == "")
            {
                customerNo = "%";
            }
            else { customerNo = txtSearch.Value; }
               
                    Load_Customer();
                    Load_CustomerStatus();
                    Load_grvCustomer(customerNo, ddlCustomerStatus.SelectedValue, ddlCustomer.SelectedValue);
                
           
        }
       
        public void Load_Customer()
        {
            ddlCustomer.DataSource = ua.Get_UserAccount();
            ddlCustomer.DataTextField = "AccountFullName";
            ddlCustomer.DataValueField = "AccountID";
            ddlCustomer.DataBind();
        }
        public void Load_CustomerStatus()
        {
            ddlCustomerStatus.DataSource = db.Get_CustomerStatus(); 
            ddlCustomerStatus.DataTextField = "StatusName";
            ddlCustomerStatus.DataValueField = "StatusID";
            ddlCustomerStatus.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Load_grvCustomer(customerNo, ddlCustomerStatus.SelectedValue, ddlCustomer.SelectedValue);
        }
        protected void ddlCustomerStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_grvCustomer(customerNo, ddlCustomerStatus.SelectedValue, ddlCustomerStatus.SelectedValue);
        }
        protected void ddlCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_grvCustomer(customerNo, ddlCustomerStatus.SelectedValue, ddlCustomer.SelectedValue);
        }

        public void Load_grvCustomer(string KeySearch, string CustomerStatus, string CustomerNo)
        {
            grvCustomer.DataSource = db.GetBy_KeySearch(KeySearch, CustomerStatus, CustomerNo);
            grvCustomer.DataBind();
        }

    }
}