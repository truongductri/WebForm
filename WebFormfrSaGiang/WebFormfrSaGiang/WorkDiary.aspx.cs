using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormfrSaGiang.AppCode.BLL;

namespace WebFormfrSaGiang.View
{
    public partial class WorkDiary : System.Web.UI.Page
    {
        UserAccountBLL ua = new UserAccountBLL();
        CustomerBLL cb = new CustomerBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            Load_Customer();
            Load_UserAccount();
        }
        public void Load_Customer()
        {
            ddlCustomer.DataSource = cb.Get_Customer();
            ddlCustomer.DataTextField = "CustomerName";
            ddlCustomer.DataValueField = "CustomerID";
            ddlCustomer.DataBind();
        }
        public void Load_UserAccount()
        {
            ddlMemoUserCreate.DataSource = ua.Get_UserAccount();
            ddlMemoUserCreate.DataTextField = "AccountFullName";
            ddlMemoUserCreate.DataValueField = "AccountID";
            ddlMemoUserCreate.DataBind();
        }
        protected void btnSubmit_ServerClick(object sender, EventArgs e)
        {

        }
    }
}