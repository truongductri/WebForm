<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustomerCrt.aspx.cs" Inherits="WebFormfrSaGiang.View.CustomerCrt" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="page-header">
        <h2>Thông tin khách hàng
            <button id="btnBack" runat="server" class="btn btn-default" type="button" title="Quay lại" style="float: right;">
                <i class="fa fa-reply"></i>
            </button>
        </h2>
    </div>
    <div class="row">
        <div class="col-sm-2" style="margin-bottom: 5px;">
            <label>Mã khách hàng</label>
        </div>
        <div class="col-sm-6" style="margin-bottom: 5px;">
            <input type="text" id="txtCustomerNo" class="form-control" runat="server" required autofocus />
        </div>
    </div>
    <div class="row">
        <div class="col-sm-2" style="margin-bottom: 5px;">
            <label>Tên khách hàng</label>
        </div>
        <div class="col-sm-6" style="margin-bottom: 5px;">
            <input type="text" id="txtCustomerName" class="form-control" runat="server" required />
        </div>
    </div>
    <div class="row">
        <div class="col-sm-2" style="margin-bottom: 5px;">
            <label>Mã số thuế</label>
        </div>
        <div class="col-sm-6" style="margin-bottom: 5px;">
            <input type="text" id="txtCustomerVATNo" class="form-control" runat="server"/>
        </div>
    </div>
    <div class="row">
        <div class="col-sm-2" style="margin-bottom: 5px;">
            <label>Ngày sinh nhật công ty</label>
        </div>
        <div class="col-sm-6" style="margin-bottom: 5px;">
            <input type="date" id="txtCustomerBirthday" class="form-control" runat="server"/>
        </div>
    </div>
    <div class="row">
        <div class="col-sm-2" style="margin-bottom: 5px;">
            <label>Ngành nghề</label>
        </div>
        <div class="col-sm-6" style="margin-bottom: 5px;">
            <asp:DropDownList ID="ddlBranch" runat="server" CssClass="form-control chosen-select">
            </asp:DropDownList>
        </div>
    </div>
    <div class="row">
        <div class="col-sm-2" style="margin-bottom: 5px;">
            <label>Số điện thoại</label>
        </div>
        <div class="col-sm-6" style="margin-bottom: 5px;">
            <input type="text" id="txtCustomerPhone" class="form-control" runat="server" />
        </div>
    </div>
    <div class="row">
        <div class="col-sm-2" style="margin-bottom: 5px;">
            <label>Email</label>
        </div>
        <div class="col-sm-6" style="margin-bottom: 5px;">
            <input type="text" id="txtCustomerEmail" class="form-control" runat="server" />
        </div>
    </div>
    <div class="row">
        <div class="col-sm-2" style="margin-bottom: 5px;">
            <label>Số Fax</label>
        </div>
        <div class="col-sm-6" style="margin-bottom: 5px;">
            <input type="text" id="txtCustomerFax" class="form-control" runat="server" />
        </div>
    </div>
    <div class="row">
        <div class="col-sm-2" style="margin-bottom: 5px;">
            <label>Địa chỉ Công ty</label>
        </div>
        <div class="col-sm-6" style="margin-bottom: 5px;">
            <input type="text" id="txtCustomerAddress1" class="form-control" runat="server" />
        </div>
    </div>
    <div class="row">
        <div class="col-sm-2" style="margin-bottom: 5px;">
            <label>Địa chỉ gửi thư</label>
        </div>
        <div class="col-sm-6" style="margin-bottom: 5px;">
            <input type="text" id="txtCustomerAddress2" class="form-control" runat="server" />
        </div>
    </div>
    <div class="row">
        <div class="col-sm-2" style="margin-bottom: 5px;">
            <label>Website</label>
        </div>
        <div class="col-sm-6" style="margin-bottom: 5px;">
            <input type="text" id="txtCustomerWebsite" class="form-control" runat="server" />
        </div>
    </div>
    <div class="row">
        <div class="col-sm-2" style="margin-bottom: 5px;">
            <label>Trạng thái</label>
        </div>
        <div class="col-sm-6" style="margin-bottom: 5px;">
            <asp:DropDownList ID="ddlCustomerStatus" runat="server" CssClass="form-control">
            </asp:DropDownList>
        </div>
    </div>
    <div class="row">
        <div class="col-sm-2" style="margin-left: 10px;">
            <asp:CheckBox ID="chkCustomerPresent" runat="server" Text="Hiện diện" />
        </div>
        <div class="col-sm-2" style="margin-left: 10px;">
            <asp:CheckBox ID="chkCustomerDemo" runat="server" Text="Demo" />
        </div>
        <div class="col-sm-2" style="margin-left: 10px;">
            <asp:CheckBox ID="chkCustomerQuotes" runat="server" Text="Báo giá" />
        </div>
        <div class="col-sm-2" style="margin-left: 10px;">
            <asp:CheckBox ID="chkCustomerContract" runat="server" Text="Hợp đồng" />
        </div>
    </div>
    <div class="row">
        <div class="col-sm-2" style="margin-bottom: 5px;">
            <label>Nhân viên kinh doanh 1</label>
        </div>
        <div class="col-sm-6" style="margin-bottom: 5px;">
            <asp:DropDownList ID="ddlSaleDirector" runat="server" CssClass="form-control chosen-select">
            </asp:DropDownList>
        </div>
    </div>
   <div class="row">
        <div class="col-sm-2" style="margin-bottom: 5px;">
            <label>Nhân viên kinh doanh 2</label>
        </div>
        <div class="col-sm-6" style="margin-bottom: 5px;">
            <asp:DropDownList ID="ddlDirector1" runat="server" CssClass="form-control chosen-select">
            </asp:DropDownList>
        </div>
    </div>
    <div class="row">
        <div class="col-sm-2" style="margin-bottom: 5px;">
            <label>Nhân viên kinh doanh 3</label>
        </div>
        <div class="col-sm-6" style="margin-bottom: 5px;">
            <asp:DropDownList ID="ddlDirector2" runat="server" CssClass="form-control chosen-select">
            </asp:DropDownList>
        </div>
    </div>
    <div class="row">
        <div class="col-sm-2" style="margin-bottom: 5px;">
            <label>Nguồn thông tin</label>
        </div>
        <div class="col-sm-6" style="margin-bottom: 5px;">
            <asp:DropDownList ID="ddlCustomerProvider" runat="server" CssClass="form-control">
            </asp:DropDownList>
        </div>
    </div>
    <div class="row">
        <div class="col-sm-2" style="margin-bottom: 5px;">
            <label id="lbAttachFile" runat="server">File đính kèm</label>
        </div>
        <div class="col-sm-6" style="margin-bottom: 5px;">
            <asp:LinkButton ID="btnDeleteFile" runat="server" OnClick="btnDeleteFile_Click">LinkButton</asp:LinkButton>
            <asp:FileUpload ID="AttachFile" runat="server" CssClass="form-control" />
        </div>
    </div>
    <div class="row">
        <div class="col-sm-2" style="margin-bottom: 5px;">
            <label>Ghi chú</label>
        </div>
        <div class="col-sm-6" style="margin-bottom: 5px;">
            <textarea class="form-control" rows="3" id="txtCustomerNotes" runat="server"></textarea>
        </div>
    </div>
    <div class="row" style="margin-bottom: 50px;">
        <div class="col-sm-2"></div>
        <div class="col-sm-6">
            <asp:Button ID="btnSubmit" runat="server" Text="Đồng ý" CssClass="btn btn-primary" OnClick="btnSubmit_Click" />
            <button type="reset" class="btn btn-success">Nhập lại</button>
        </div>
    </div>
    <hr />


</asp:Content>
