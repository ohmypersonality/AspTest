<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <asp:Label ID="Label1" runat="server" Text="帳號"></asp:Label>
    <asp:TextBox ID="count" runat="server"></asp:TextBox>
    <input type="text" id="user" name ="user2">    
    <br>
     <asp:Label ID="Label2" runat="server" Text="密碼"></asp:Label>
     <asp:TextBox ID="psw" runat="server"></asp:TextBox>
    <input type="text" id="password" name ="psw2">   
    
    <br>
    <asp:Label ID="Label5" runat="server" Text="暱稱"></asp:Label>
    <asp:TextBox ID="TextBox_nickname" runat="server"></asp:TextBox>
    
    <br>
    <asp:Button ID="Button1" runat="server" Text="送出" OnClick="Button1_Click"/>
    <asp:Button ID="Button2" runat="server" Text="註冊新帳號" OnClick="Button2_Click"/>
    <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
    </asp:Content>
