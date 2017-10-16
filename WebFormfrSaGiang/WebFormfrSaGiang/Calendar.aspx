<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Calendar.aspx.cs" Inherits="WebFormfrSaGiang.Calendar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <!-- Page Header -->
        <div class="col-sm-12">
            <div class="panel panel-default">
                <div class="panel-body">
                    <div class="row">
                        <div class="col-sm-4">
                            <h3>Lịch làm việc</h3>
                        </div>
                            <div class="col-sm-2" style="margin-top:10px;">
                            <asp:DropDownList ID="ddlYears" runat="server" CssClass="form-control">
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-2" style="margin-top:10px;">
                            <asp:DropDownList ID="ddlWeeks" runat="server" CssClass="form-control">
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-4 input-group" style="margin-top:10px;">
                            <asp:DropDownList ID="ddlEmps" runat="server" CssClass="form-control">
                            </asp:DropDownList>
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
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
