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
        public string CustomerID, UserID;
        //dt = new DataTable();

        CustomerBLL db = new CustomerBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                Load_CustomerBranch();
                Load_CustomerStatus();
                Load_Director();
                Load_CustomerProvider();
            }
            //if (!string.IsNullOrEmpty(CusID))
            //{
            //    if (!IsPostBack)
            //    {
            //        Load_Edit(Convert.ToInt32(CusID));
            //    }
            //}

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
            custom.CustomerDemo = chkCustomerDemo.Checked.ToString();
            custom.CustomerContract = chkCustomerContract.Checked.ToString();
            custom.CustomerQuotes = chkCustomerQuotes.Checked.ToString();
            custom.CustomerSaleDirector = Convert.ToInt32(ddlSaleDirector.SelectedValue);// customerUserAccount3
            if (Convert.ToInt32(ddlDirector1.SelectedValue) != 0)
            {
                custom.SaleMan1 = Convert.ToInt32(ddlDirector1.SelectedValue);
            }
            if (Convert.ToInt32(ddlDirector2.SelectedValue) != 0)
            {
                custom.SaleMan2 = Convert.ToInt32(ddlDirector2.SelectedValue);
            }
            custom.CustomerStatus = Convert.ToInt32(ddlCustomerStatus.SelectedValue);
            custom.CustomerProvider = Convert.ToInt32(ddlCustomerProvider.SelectedValue);

            //Nếu như có biến customerID thì lấy tk IDcustom, userUpdate, LastUpdate gán cho tk custom rồi update tk custom vào một biến tạm tmp
            //Ktra nếu tồn tại tmp thì kiểm tra file post>> lấy ra đường dãn của file post, đặt path file với một định dạng.. lưu lại post file>>> respone direct về index
            //Nếu tmp không tồn tại thì alert tmp
            DateTime now = new UserAccountBLL().GetDateTimeNow();

            if (!string.IsNullOrEmpty(CustomerID))
            {
                custom.CustomerID = Convert.ToInt32(CustomerID);
                custom.CustomerUserUpdate =1 /*Convert.ToInt32(UserID)*/;//customerUserAcount1
                custom.CustomerLastUpdate = now;//customerUserAcount2
                string tmp = db.UpdateCustomer(custom);
                if (string.IsNullOrEmpty(tmp))
                {
                    if (AttachFile.PostedFile != null)
                    {
                        if (!string.IsNullOrEmpty(Path.GetFileName(AttachFile.PostedFile.FileName)))
                        {
                            string filePath = custom.CustomerNo + "_" + UserID + "_" + DateTime.Now.ToString("dd-MM-yyyy") + "_" + Path.GetFileName(AttachFile.PostedFile.FileName);
                            if (db.UpdateAttachFile(filePath, CustomerID))
                            {
                                AttachFile.PostedFile.SaveAs(Server.MapPath("~/Uploads/") + filePath);
                            }
                        }
                    }
                   // Response.Redirect("#" + CustomerID);
                }
                else
                {
                    Response.Write("<script LANGUAGE='JavaScript' >alert('" + tmp + "')</script>");
                }
            }
            else
            {
                custom.CustomerUserUpdate = 1;
                custom.CustomerUserCreate = 1;
                custom.CustomerDateCreate = now;
                custom.CustomerLastUpdate = now;
                if (AttachFile.PostedFile != null)
                {
                    if (!string.IsNullOrEmpty(Path.GetFileName(AttachFile.PostedFile.FileName)))
                    {
                        custom.AttachFile = custom.CustomerNo + "_" + UserID + "_" + DateTime.Now.ToString("dd-MM-yyyy") + "_" + Path.GetFileName(AttachFile.PostedFile.FileName);
                    }
                }
                string tmp = db.InsertCustomer(custom);
                if (!string.IsNullOrEmpty(tmp))
                {
                    if (AttachFile.PostedFile != null)
                    {
                        if (!string.IsNullOrEmpty(Path.GetFileName(AttachFile.PostedFile.FileName)))
                        {
                            AttachFile.PostedFile.SaveAs(Server.MapPath("~/Uploads/") + custom.AttachFile);
                        }
                    }
                    Response.Write("<script LANGUAGE='JavaScript' >alert('" + tmp + "')</script>");
                    txtCustomerNo.Value = "";
                }
                else
                {
                    Response.Write("<script LANGUAGE='JavaScript' >alert('Thêm thất bại.')</script>");
                }
            }

        }
    }
}