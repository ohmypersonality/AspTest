<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LoadCSV.aspx.cs" Inherits="WebApplication1.LoadCSV" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="年度" HeaderText="年度" SortExpression="年度" />
            <asp:BoundField DataField="得獎類別" HeaderText="得獎類別" SortExpression="得獎類別" />
            <asp:BoundField DataField="區別" HeaderText="區別" SortExpression="區別" />
            <asp:BoundField DataField="里別" HeaderText="里別" SortExpression="里別" />
            <asp:BoundField DataField="姓名" HeaderText="姓名" SortExpression="姓名" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:OrdersConnectionString %>" SelectCommand="SELECT [年度], [得獎類別], [區別], [里別], [姓名] FROM [里長得獎名單]"></asp:SqlDataSource>
</asp:Content>
