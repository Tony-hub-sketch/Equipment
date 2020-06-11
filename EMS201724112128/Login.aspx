<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EMS201724112128.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>登录界面</title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <script src="jQuery/jquery-3.5.1.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container" style="width:80%;margin-top:30px;">
            <div class="row">
                <div class="col">
                    <div class="card">
                        <div class="card-header bg-info">设备保管及查询系统</div>
                        <div class="card-body">
                            <div class="form-group">
                                <label for="UserNumTextBox">账号：</label>
                                <asp:TextBox ID="UserNumTextBox" runat="server" class="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="NumberRV" runat="server" ControlToValidate="UserNumTextBox" Display="Dynamic" ErrorMessage="请输入账号" ForeColor="Red"></asp:RequiredFieldValidator>
                                <br />
                            </div>
                            <div class="form-group">
                                <label for="PasswordTextBox">密码：</label>
                                <asp:TextBox ID="PasswordTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="PasswordRV" runat="server" ControlToValidate="PasswordTextBox" Display="Dynamic" ErrorMessage="请输入密码" ForeColor="Red"></asp:RequiredFieldValidator>
                                <br />
                            </div>
                            <div class="form-group">
                                <label for="RadioButtonList1">用户类型：</label>
                                <asp:RadioButtonList ID="TypeRadioButtonList" runat="server" RepeatDirection="Horizontal" CssClass="" BackColor="#CCCCCC" Width="100%">
                                    <asp:ListItem Value="true">管理员</asp:ListItem>
                                    <asp:ListItem Selected="True" Value="false">普通用户</asp:ListItem>
                                </asp:RadioButtonList>
                            </div><br />
                            <asp:Label ID="TestLabel" runat="server" ForeColor="Red"></asp:Label><br />
                            <asp:Button ID="Button1" runat="server" OnClick="LoginButton_Click" Text="登录" CssClass="btn bg-info container" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
