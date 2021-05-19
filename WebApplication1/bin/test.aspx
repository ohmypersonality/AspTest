<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="WebApplication1.test" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <asp:Label ID="Label1" runat="server" Text="帳號"></asp:Label>
    <asp:TextBox ID="count" runat="server"></asp:TextBox>
    <input type="text" id="user" name ="user2">
    <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
    <br>
     <asp:Label ID="Label2" runat="server" Text="密碼"></asp:Label>
     <asp:TextBox ID="psw" runat="server"></asp:TextBox>
    <input type="text" id="password" name ="psw2">
    <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
    
    <br>
    <asp:Label ID="Label5" runat="server" Text="暱稱"></asp:Label>
    <asp:TextBox ID="TextBox_nickname" runat="server"></asp:TextBox>
    
    <br>
    <asp:Button ID="Button1" runat="server" Text="送出" OnClick="Button1_Click"/>



<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </asp:Content>
