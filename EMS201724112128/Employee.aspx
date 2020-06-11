<%@ Page Title="" Language="C#" MasterPageFile="~/EmployeeSite.Master" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="EMS201724112128.Employee1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card-body">
        <div class="card-group">
            <div class="container">
                <br />
        <h3 style="color:cadetblue;text-align:center;">设备信息总表</h3><hr />
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>" SelectCommand="SELECT Department.DepartmentName, Employee.EmployeeName, Equipment.EquipmentId, Equipment.EquipmentName, Equipment.DatePurchase, Equipment.StorageLocation FROM Department INNER JOIN Employee ON Department.DepartmentManager = Employee.EmployeeId AND Department.DepartmentId = Employee.EmployeeBelongDep INNER JOIN Equipment ON Employee.EmployeeId = Equipment.EquipmentManager"></asp:SqlDataSource>
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="EquipmentId" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" AllowPaging="True" AllowSorting="True" Width="100%">
    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
    <Columns>
        <asp:BoundField DataField="DepartmentName" HeaderText="DepartmentName" SortExpression="DepartmentName" />
        <asp:BoundField DataField="EmployeeName" HeaderText="EmployeeName" SortExpression="EmployeeName" />
        <asp:BoundField DataField="EquipmentId" HeaderText="EquipmentId" ReadOnly="True" SortExpression="EquipmentId" />
        <asp:BoundField DataField="EquipmentName" HeaderText="EquipmentName" SortExpression="EquipmentName" />
        <asp:BoundField DataField="DatePurchase" HeaderText="DatePurchase" SortExpression="DatePurchase" />
        <asp:BoundField DataField="StorageLocation" HeaderText="StorageLocation" SortExpression="StorageLocation" />
    </Columns>
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
    </div>
        </div>
    </div>
</asp:Content>
