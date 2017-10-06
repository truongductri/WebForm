using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormfrSaGiang.AppCode.BLL;
using WebFormfrSaGiang.AppCode.DAL;

namespace WebFormfrSaGiang.View
{
    public partial class CustomerCrt : System.Web.UI.Page
    {
        public string CustomerID;
         //dt = new DataTable();
        CustomerBLL db = new CustomerBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            Load_CustomerBranch();
            Load_CustomerStatus();
            Load_Director();
            Load_CustomerProvider();


        }
        public void Load_CustomerBranch()
        {
            ddlBranch.DataSource = db.Get_CustomerBranch();
            ddlBranch.DataTextField = "BranchName";
            ddlBranch.DataValueField = "BranchID";
            ddlBranch.DataBind();
        }
        public void Load_CustomerStatus()
        {
            ddlCustomerStatus.DataSource = db.Get_CustomerStatus();
            ddlCustomerStatus.DataTextField = "StatusName";
            ddlCustomerStatus.DataValueField = "StatusID";
            ddlCustomerStatus.DataBind();
        }
        public void Load_Director()
        {
            ddlSaleDirector.DataSource = db.Get_Director();
            ddlSaleDirector.DataTextField = "AccountFullName";
            ddlSaleDirector.DataValueField = "AccountID";
            ddlSaleDirector.DataBind();

            //DataTable dt = db.Get_SaleDirectornone();
            ddlDirector1.DataSource = db.Get_SaleDirectornone();
            ddlDirector1.DataTextField = "AccountFullName";
            ddlDirector1.DataValueField = "AccountID";
            ddlDirector1.DataBind();

            ddlDirector2.DataSource = db.Get_SaleDirectornone();
            ddlDirector2.DataTextField = "AccountFullName";
            ddlDirector2.DataValueField = "AccountID";
            ddlDirector2.DataBind();
        }
        public void Load_CustomerProvider()
        {
            ddlCustomerProvider.DataSource = db.Get_ContractProvider();
            ddlCustomerProvider.DataTextField = "StatusName";
            ddlCustomerProvider.DataValueField = "StatusID";
            ddlCustomerProvider.DataBind();
           // ddlCustomerProvider.SelectedIndex = 0;
        }
        //Node delete file >>> ButtonLink
        protected void btnDeleteFile_Click(object sender, EventArgs e)
        {
            string filePath = Server.MapPath("~/Uploads/") + btnDeleteFile.Text;
            File.Delete(filePath);
            db.UpdateAttachFile("", CustomerID);
            Response.Redirect(Request.Url.AbsoluteUri);
        }

        //Node Submit
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            CustomerInfo custom = new CustomerInfo();
            custom.CustomerNo = txtCustomerNo.Value;
            custom.CustomerName = txtCustomerName.Value;
            custom.CustomerVATNo = txtCustomerVATNo.Value;
            custom.CustomerAddress1 = txtCustomerAddress1.Value;
            custom.CustomerAddress2 = txtCustomerAddress2.Value;
            if (!string.IsNullOrEmpty(txtCustomerBirthday.Value))
            {
                custom.CustomerBirthday = Convert.ToDateTime(txtCustomerBirthday.Value);
            }
            custom.CustomerEmail = txtCustomerEmail.Value;
            custom.CustomerPhone = txtCustomerPhone.Value;
            custom.CustomerFax = txtCustomerFax.Value;
            custom.CustomerWebsite = txtCustomerWebsite.Value;
            custom.CustomerNotes = txtCustomerNotes.Value;
            custom.BranchID = Convert.ToInt32(ddlBranch.SelectedValue);
            custom.CustomerPresent = chkCustomerPresent.Checked.ToString();
            custom.CustomerPresent = chkCustomerDemo.Checked.ToString();
            custom.CustomerPresent = chkCustomerQuotes.Checked.ToString();

        }
    }
}