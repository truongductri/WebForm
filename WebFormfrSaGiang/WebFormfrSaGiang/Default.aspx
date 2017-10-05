<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormfrSaGiang._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>SAGIANG.CRM</h1>
        <p>Hệ Thống Quản Lý Nội Bộ.</p>
    </div>
    <div class="row">
        <div class="col-sm-6">
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <h3 class="panel-title">Thông tin đăng nhập</h3>
                </div>
                <div class="panel-body">
                    <p>
                        <label>Tài khoản : </label>
                        <asp:Label ID="lblUserAccount" runat="server" Font-Names="Times New Roman" ForeColor="#3333CC" Font-Bold="True"></asp:Label>
                    </p>
                    <p>
                        <label>Nhóm người dùng : </label>
                        <asp:Label ID="lblGroupNotes" runat="server" Font-Names="Times New Roman" ForeColor="#3333CC" Font-Bold="True"></asp:Label>
                    </p>
                    <p>
                        <label>Người sử dụng : </label>
                        <asp:Label ID="lblAccountFullName" runat="server" Font-Names="Times New Roman" ForeColor="#3333CC" Font-Bold="True"></asp:Label>
                    </p>
                    <p>
                        <label>Email : </label>
                        <asp:Label ID="lblEmail" runat="server" Font-Names="Times New Roman" ForeColor="#3333CC" Font-Bold="True"></asp:Label>
                    </p>
                    <br />
                    <p>
                        <button class="btn btn-primary" type="button" title="Đổi mật khẩu" onclick="ShowPopup()">Đổi mật khẩu</button>
                    </p>
                </div>
            </div>
        </div>
        <div class="col-sm-6">
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <h3 class="panel-title">Liên hệ lại khách hàng</h3>
                </div>
                <div class="panel-body" style="height: 232px">
                    <div class="table-responsive">
                        <asp:GridView ID="grvCPContact" runat="server" CssClass="table table-bordered table-hover" AllowPaging="True" AutoGenerateColumns="False" EnableSortingAndPagingCallbacks="True" PageSize="3">
                            <Columns>
                                <asp:HyperLinkField DataNavigateUrlFields="CPID" DataNavigateUrlFormatString="WF3021.aspx?CPID={0}" DataTextField="CPNo" HeaderText="Mã hồ sơ">
                                    <ControlStyle Font-Bold="True" />
                                </asp:HyperLinkField>
                                <asp:BoundField DataField="MPDateCreate" HeaderText="Ngày hỗ trợ" DataFormatString="{0:dd/MM/yyyy}">
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:HyperLinkField DataNavigateUrlFields="MPID" DataNavigateUrlFormatString="WF3041.aspx?MPID={0}" DataTextField="StatusName" HeaderText="Tình trạng" />
                            </Columns>
                            <PagerStyle CssClass="GridPager" />
                        </asp:GridView>
                    </div>
                    <div class="table-responsive">
                        <asp:GridView ID="grvMemo" runat="server" CssClass="table table-bordered table-hover" AllowPaging="True" AutoGenerateColumns="False" EnableSortingAndPagingCallbacks="True" PageSize="3">
                            <Columns>
                                <asp:HyperLinkField DataNavigateUrlFields="CustomerID" DataNavigateUrlFormatString="WF1021.aspx?CustomerID={0}" DataTextField="CustomerNo" HeaderText="Mã hồ sơ">
                                    <ControlStyle Font-Bold="True" />
                                </asp:HyperLinkField>
                                <asp:BoundField DataField="MemoDateExp" HeaderText="Ngày LH" DataFormatString="{0:dd/MM/yyyy}">
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="MemoNotes" HeaderText="Nội dung LH" />
                            </Columns>
                            <PagerStyle CssClass="GridPager" />
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <hr />
   <%-- <script type="text/javascript">
        function ShowPopup() {
            $("#btnShowModal").click();
        }
    </script>
    <!-- Trigger the modal with a button -->
    <button id="btnShowModal" type="button" class="btn btn-info btn-lg" data-toggle="modal" data-target="#myModal" style="display: none;">Open Modal</button>
    <!-- Modal -->
    <div id="myModal" class="modal fade" role="dialog">
        <div class="modal-dialog">
            <!-- Modal content-->
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 class="modal-title">Thêm Nhóm người dùng</h4>
                </div>
                <div class="modal-body">
                    <div class="row" style="margin-bottom: 5px;">
                        <div class="col-sm-4">
                            <label>Mật khẩu cũ</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="password" class="form-control" runat="server" id="txtOldPwd" required="required" autofocus="autofocus" autocomplete="off" />
                        </div>
                    </div>
                    <div class="row" style="margin-bottom: 5px;">
                        <div class="col-sm-4">
                            <label>Mật khẩu mới</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="password" class="form-control" runat="server" id="txtNewPwd" required="required" />
                        </div>
                    </div>
                    <div class="row" style="margin-bottom: 5px;">
                        <div class="col-sm-4">
                            <label>Xác nhận lại</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="password" class="form-control" runat="server" id="txtConfirmPwd" required="required" />
                        </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <input type="submit" class="btn btn-primary" runat="server" id="Submit1" onserverclick="btnSubmit_ServerClick" onclick="javascript: if (!myFunction()) return false;" value="Lưu" />
                    <%--<button type="button" class="btn btn-primary" runat="server" id="btnSubmit" onserverclick="btnSubmit_ServerClick" data-dismiss="modal">Lưu</button>--%>
                    <button type="button" class="btn btn-default" runat="server" data-dismiss="modal">Đóng</button>
                </div>
            </div>

        </div>
    </div> --%>
    <%--<script type="text/javascript">
        function myFunction() {
            debugger;
            var pass1 = document.getElementById("<%=txtNewPwd.ClientID%>").value;
            var pass2 = document.getElementById("<%=txtConfirmPwd.ClientID%>").value;
            if (pass1 != pass2) {
                document.getElementById("<%=txtNewPwd.ClientID%>").style.borderColor = "#E34234";
                document.getElementById("<%=txtConfirmPwd.ClientID%>").style.borderColor = "#E34234";
                return false;
            }
            else {
                return true;
            }
        }
    </script>--%>
</asp:Content>
