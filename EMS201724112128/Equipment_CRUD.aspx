﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Equipment_CRUD.aspx.cs" Inherits="EMS201724112128.Equipment_CRUD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>设备管理</title>
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
                            <asp:Menu ID="Menu1" runat="server" DataSourceID="SiteMapDataSource1" Orientation="Horizontal" StaticDisplayLevels="2" StaticSubMenuIndent="16px" CssClass="form-control">
                            </asp:Menu>
                            <br />
                            <div class="col-form-label">设备编号：<asp:TextBox ID="EquNum_Tb" runat="server" CssClass=""></asp:TextBox></div>
                            <div class="col-form-label">设备名称：<asp:TextBox ID="EquNam_TB" runat="server" CssClass=""></asp:TextBox></div>
                            <div class="col-form-label">设备规格：<asp:TextBox ID="EquSiz_TB" runat="server" CssClass=""></asp:TextBox></div>
                            <div class="col-form-label">设备价格：<asp:TextBox ID="EquPri_TB" runat="server" CssClass=""></asp:TextBox></div>
                            <div class="col-form-label">购买日期：<asp:TextBox ID="BuyDat_TB" runat="server" CssClass=""></asp:TextBox></div>
                            <div class="col-form-label">存放位置：<asp:TextBox ID="EquSto_TB" runat="server" CssClass=""></asp:TextBox></div>
                            <div class="col-form-label">设备管理员：<asp:TextBox ID="EquMan_TB" runat="server" CssClass=""></asp:TextBox></div>
                          
                            <asp:Button ID="Button1" runat="server" Text="插入" CssClass="btn btn-info" OnClick="Button1_Click"/>
                            &nbsp;<asp:Button ID="Button2" runat="server" Text="删除"  CssClass="btn btn-info" OnClick="Button2_Click"/>
                            &nbsp;<asp:Button ID="Button3" runat="server" Text="修改"  CssClass="btn btn-info" OnClick="Button3_Click"/>
                            <br />
                            <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
                            <br />
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
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
