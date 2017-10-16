<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contacter.aspx.cs" Inherits="WebFormfrSaGiang.Contacter" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-sm-12">
            <div class="panel panel-default">
                <div class="panel-body">
                    <div class="row">
                        <div class="col-sm-6">
                        <h3>Người liên hệ</h3>
                        </div>
                         <div class="col-sm-6 input-group" style="margin-top:10px;">
                            <input id="txtSearch" class="form-control" placeholder="Họ tên - Số ĐT - Email - Địa chỉ.."/>
                            <span class="input-group-btn">
                                <button runat="server" id="btnAddNew" onclick="ShowPopup()" class="btn btn-default" type="button">
                                    <i class="fa fa-plus"></i>
                                </button>
                                <button id="btnSearch" class="btn btn-default" type="button" runat="server">
                                    <i class="fa fa-search"></i>
                                </button>
                            </span>
                        </div>
                </div>
                    
                    
                </div>
            </div>
        </div>
    </div>

     <div class="row">
        <div class="col-sm-12">
            <div class="panel panel-default">
                <div class="panel-body">
                    <div class="table-responsive">
                        
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                            <Columns>
                                <asp:HyperLinkField DataNavigateUrlFields="ContactID" DataNavigateUrlFormatString="ContactInfo.aspx?ContactID={0}" DataTextField="ContactName" HeaderText="Họ tên" />
                                <asp:BoundField DataField="ContactPosition" HeaderText="Chức vụ" />
                                <asp:BoundField DataField="ContactPhone" HeaderText="Số điện thoại" />
                                <asp:BoundField DataField="ContactEmail" DataFormatString="&lt;a href=mailto:{0}&gt;{0}&lt;/a&gt;" HeaderText="Email" HtmlEncodeFormatString="False" />
                                <asp:HyperLinkField DataNavigateUrlFields="CustomerID" DataNavigateUrlFormatString="Customer.aspx?CustomerID={0}" DataTextField="CustomerID" HeaderText="Mã KH" />
                            </Columns>
                             <PagerStyle CssClass="GridPager" />
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
