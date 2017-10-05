<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="WebFormfrSaGiang.View.Customer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="row">
        <div class="col-sm-12">
            <div class="panel panel-default">
                <div class="panel-body">
                    <div class="col-sm-3">
                        <h3>Khách hàng</h3>
                    </div>
                    <div class="col-sm-3" style="margin-top: 17px">
                        <asp:DropDownList ID="ddlCustomer" runat="server" CssClass="form-control" >
                        </asp:DropDownList>
                    </div>
                    <div class="col-sm-2" style="margin-top: 17px">
                        <asp:DropDownList ID="ddlCustomerStatus" runat="server" CssClass="form-control">
                        </asp:DropDownList>
                    </div>
                    <div class="col-sm-4" style="margin-top: 17px">
                        <div class="input-group custom-search-form">
                            <input id="txtSearch" type="text" class="form-control" runat="server" placeholder="Khách hàng hoặc Mã số thuế..." />
                            <span class="input-group-btn">
                                <button id="btnSearch" class="btn btn-default" type="button" runat="server"  onserverclick="btnSearch_Click">
                                    <i class="fa fa-search"></i>
                                </button>
                                
                                <button class="btn btn-default" type="button">
                                    <i class="fa fa-plus"></i>
                                </button>
                            </span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <br />
    <br />
    <div class="row">
        <div class="col-sm-12">
            <div class="panel panel-default">
                <div class="panel-body">
                    <div class="table-bordered">
                        <asp:GridView ID="grvCustomer" runat="server" CssClass="table table-bordered table-hover" AllowPaging="True" AutoGenerateColumns="False" EnableSortingAndPagingCallbacks="True">
                            <Columns>
                                <asp:HyperLinkField DataNavigateUrlFields="CustomerID" DataNavigateUrlFormatString="Customer.aspx?CustomerID={0}" DataTextField="CustomerNo" HeaderText="Mã KH">
                                    <ControlStyle Font-Bold="True" />
                                </asp:HyperLinkField>
                                <asp:BoundField DataField="CustomerNo" HeaderText="Mã KH" />
                                <asp:BoundField DataField="CustomerName" HeaderText="Tên KH" />
                                <asp:CheckBoxField DataField="CustomerPresent" HeaderText="Hiện diện">
                                    <HeaderStyle HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:CheckBoxField>
                                <asp:CheckBoxField DataField="CustomerDemo" HeaderText="Demo">
                                    <HeaderStyle HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:CheckBoxField>
                                <asp:CheckBoxField DataField="CustomerQuotes" HeaderText="Báo giá">
                                    <HeaderStyle HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:CheckBoxField>
                                <asp:CheckBoxField DataField="CustomerContract" HeaderText="Hợp đồng">
                                    <HeaderStyle HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:CheckBoxField>
                            </Columns>
                            <PagerStyle CssClass="GridPager" />
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
