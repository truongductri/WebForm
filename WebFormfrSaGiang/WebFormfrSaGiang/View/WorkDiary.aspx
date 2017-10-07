<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WorkDiary.aspx.cs" Inherits="WebFormfrSaGiang.View.WorkDiary" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="row">
        <!-- Page Header -->
        <div class="col-sm-12">
            <div class="panel panel-default">
                <div class="panel-body">
                    <div class="row">
                        <div class="col-sm-12">
                            <h3>Nhật ký công việc</h3>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-2" style="margin-top: 5px;">
                            <label>Từ ngày</label>
                        </div>
                        <div class="col-sm-4" style="margin-top: 5px;">
                            <input type="date" id="txtMPFromDate" class="form-control" runat="server" />
                        </div>
                        <div class="col-sm-2" style="margin-top: 5px;">
                            <label>Đến ngày</label>
                        </div>
                        <div class="col-sm-4" style="margin-top: 5px;">
                            <input type="date" id="txtMPToDate" class="form-control" runat="server" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-2" style="margin-top: 5px;">
                            <label>Người liên hệ</label>
                        </div>
                        <div class="col-sm-4" style="margin-top: 5px;">
                            <asp:DropDownList ID="ddlMemoUserCreate" runat="server" CssClass="form-control" AutoPostBack="false">
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-2" style="margin-top: 5px;">
                            <label>Khách hàng</label>
                        </div>
                        <div class="col-sm-4" style="margin-top: 5px;">
                            <asp:DropDownList ID="ddlCustomer" runat="server" CssClass="form-control chosen-select" AutoPostBack="false">
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-2" style="margin-top: 5px;">
                            <label>Sắp xếp theo</label>
                        </div>
                        <div class="col-sm-2" style="margin-top: 5px;">
                            <label>
                                <input type="radio" runat="server" id="rdTimeASC" name="optradio" checked />Thời gian (tăng)
                            </label>
                        </div>
                        <div class="col-sm-2" style="margin-top: 5px;">
                            <label>
                                <input type="radio" runat="server" id="rdTimeDESC" name="optradio" />Thời gian (giảm)
                            </label>
                        </div>
                        <div class="col-sm-2" style="margin-top: 5px;">
                            <label>
                                <input type="radio" runat="server" id="rdCustomerASC" name="optradio" />Khách hàng (tăng)
                            </label>
                        </div>
                        <div class="col-sm-2" style="margin-top: 5px;">
                            <label>
                                <input type="radio" runat="server" id="rdCustomerDESC" name="optradio" />Khách hàng (giảm)
                            </label>
                        </div>
                    </div>
                    <div class="row" style="float: right; margin-top: 5px;">
                        <div class="col-sm-12">
                            <button id="btnSubmit" class="btn btn-primary" type="button" runat="server" onserverclick="btnSubmit_ServerClick">
                                Đồng ý</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!--End Page Header -->
    </div>

    <div class="row">
        <div class="col-sm-12">
            <div class="panel panel-default">
                <div class="panel-body">
                    <div class="table-responsive">
                        <asp:GridView ID="grvMemo" runat="server" CssClass="table table-bordered table-hover" AllowPaging="True" AutoGenerateColumns="False" EnableSortingAndPagingCallbacks="True">
                            <Columns>
                                <asp:HyperLinkField DataNavigateUrlFields="CustomerID" DataNavigateUrlFormatString="WF1021.aspx?CustomerID={0}" DataTextField="CustomerNo" HeaderText="Khách hàng">
                                    <ItemStyle Width="18%" />
                                </asp:HyperLinkField>
                                <asp:BoundField DataField="AccountFullName" HeaderText="Người liên hệ">
                                    <ItemStyle Width="18%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="MemoContent" HeaderText="Nội dung" />
                            </Columns>
                            <PagerStyle CssClass="GridPager" />
                        </asp:GridView>
                    </div>
                    <button id="btnExportExcel" class="btn btn-primary" type="button" runat="server" onserverclick="btnExportExcel_Click">
                        Xuất Excel
                    </button>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
