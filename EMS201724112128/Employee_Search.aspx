<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee_Search.aspx.cs" Inherits="EMS201724112128.Employee_Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>员工查询</title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <script src="jQuery/jquery-3.5.1.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div class="container">
            <div class="card">
                <div class="card-header bg-info">
                    <p style="color:white;font-size:x-large;letter-spacing:10px;">设备信息管理系统</p>
                    <div style="text-align:right; color:white;">欢迎您，<%=Session["Name"]%></div>
                </div>
                <div class="card-body">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
                            <asp:Menu ID="Menu1" runat="server" DataSourceID="SiteMapDataSource1" Orientation="Horizontal" StaticDisplayLevels="2" StaticSubMenuIndent="16px" CssClass="popover-header form-control">
                            </asp:Menu>
                            <br />
                            <div class="card-group">
                                请选择查询选项：<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" CssClass="form-control" DataTextField="DepartmentName" DataValueField="DepartmentName">
                                    <asp:ListItem>员工编号</asp:ListItem>
                                    <asp:ListItem>员工姓名</asp:ListItem>
                                    <asp:ListItem>联系电话</asp:ListItem>
                                    <asp:ListItem>是否为管理员(Y/N)</asp:ListItem>
                                    <asp:ListItem>所属部门</asp:ListItem>
                                </asp:DropDownList>
                                <br />
                                请输入查询信息：<asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
                                <br />
                                <asp:Button ID="Button1" runat="server" Text="搜索" CssClass="btn btn-info" OnClick="Button1_Click"/>
                                <br />
                            </div>
                            <div class="card-group">
                                <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                    <EditRowStyle BackColor="#999999" />
                                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                                </asp:GridView>
                                <asp:LinqDataSource ID="LinqDataSource1" runat="server" EntityTypeName="">
                                </asp:LinqDataSource>
                                <br />
                            </div>
                            <div class="card-group">
                                <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
