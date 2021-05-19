<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RockPaperScissors.aspx.cs" Inherits="WebApplication1.RockPaperScissors" %>
    <asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="Label_login_number" runat="server"></asp:Label>

        <asp:UpdatePanel ID="UpdatePanel_count" runat="server">
        <ContentTemplate>
            <asp:Label ID="Label_count" runat="server" Text=""></asp:Label>
        </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="countTimer" EventName="Tick" />
            </Triggers>
    </asp:UpdatePanel>

    <asp:Label ID="Label_user_name" runat="server"></asp:Label>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="LogOut" />
    <br>
    <br>
    <asp:Label ID="Label8" runat="server" Text="Chat Room"></asp:Label>
    <br>
    <asp:Label ID="Label9" runat="server" Text="Chat："></asp:Label>
    <asp:TextBox ID="TextBox_message" runat="server"></asp:TextBox>
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Send" />

    <br>
    <br>
     <asp:UpdatePanel ID="UpdatePanel_chat_room" runat="server">
        <ContentTemplate>
            <asp:Label ID="Label_chat_room" runat="server" Text="Label"></asp:Label>
        </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="countTimer" EventName="Tick" />
            </Triggers>
    </asp:UpdatePanel>
    <br>
    <asp:Label ID="Label3" runat="server" Text="剪刀石頭布，請選擇要出的拳！"></asp:Label>

    <br>

    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/pic/Scissors.png" OnClick="Button_Click" /> <!--OnClick="ImageButton1_Click" Height="180px" Width="180px" />-->
    <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/pic/Rock.png" OnClick="Button_Click" />  <!--OnClick="ImageButton2_Click" Height="180px" Width="180px" />-->
    <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/pic/Paper.png" OnClick="Button_Click" /> <!--OnClick="ImageButton3_Click" Height="180px" Width="180px" />-->
        
    
        
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:OrdersConnectionString %>" SelectCommand="SELECT * FROM [Customers]"></asp:SqlDataSource>
        
    
        
    <br>

    <asp:Label ID="Label_user_RockPaperScissors" runat="server" Width="150px"></asp:Label>
    &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp 
    <asp:Label ID="Label_computer_RockPaperScissors" runat="server"></asp:Label>

    <br>

    <p>
        <asp:Image ID="Image2" runat="server" ImageUrl="~/pic/Paper.png" Height="180px" Width="180px" />
        <asp:Image ID="Image1" runat="server" ImageUrl="~/pic/Paper.png" Height="180px" Width="180px" />
        
        
        
        
        
        
        
    </p>
   
        <br>
   <asp:Label ID="Label_result_RockPaperScissors" runat="server"></asp:Label>
        <br>
   <asp:Label ID="Label_record_RockPaperScissors" runat="server"></asp:Label>









<asp:Timer ID="countTimer" runat="server" OnTick="countTimer_Tick"></asp:Timer>
</asp:Content>
