<%@ Page Title="" Language="C#" MasterPageFile="~/EmployeeSite.Master" AutoEventWireup="true" CodeBehind="Search_StoSit.aspx.cs" Inherits="EMS201724112128.Search_StoSit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col">
            <div class =" container">
                <div class="card">
                    <div class="card-body">
                        <div class="card-group">
                            <label for="TextBox1">请输入设备存放位置：</label>
                            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:Button ID="Button1" runat="server" Text="搜索" CssClass="btn btn-info" OnClick="Button1_Click"/>
                        </div>
                        <br /><p>查询结果如下：</p>
                        <div class="card-group">
                            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                                <FooterStyle BackColor="White" ForeColor="#000066" />
                                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                                <RowStyle ForeColor="#000066" />
                                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#00547E" />
                            </asp:GridView>
                            <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
                            <br />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
