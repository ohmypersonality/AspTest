<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DataQuery.aspx.cs" Inherits="WebApplication1.DataQuery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="輸入要搜尋的項目："></asp:Label>
    <asp:TextBox ID="TextBox_item" runat="server"></asp:TextBox>
    <br>
    <asp:Label ID="Label2" runat="server" Text="輸入要搜尋的資料表："></asp:Label>
    
    <asp:TextBox ID="TextBox_table" runat="server"></asp:TextBox>
    <br>    
    <asp:Button ID="Button_query" runat="server" Text="搜尋" OnClick="Button_query_Click" />
    <br>
    <asp:Label ID="Label_results" runat="server" Text=""></asp:Label>
    </asp:Content>
