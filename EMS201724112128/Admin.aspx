<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="EMS201724112128.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>管理员登录界面</title>
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
                                <h2 style="color:cadetblue;text-align:center;"><br />
                                <br />欢迎使用设备保管及查询系统</h2>
                                <h3>测试回退...</h3>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
