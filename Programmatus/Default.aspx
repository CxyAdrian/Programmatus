<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>


<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    </asp:UpdatePanel>
    
</asp:Content>

<asp:Content runat="server" ID="left" ContentPlaceHolderID="LeftContent">  
    <asp:Button ID="Button1" runat="server" BackColor="#0099FF" Text="Button" Width="112px" />
</asp:Content>

<asp:Content runat="server" ID="right" ContentPlaceHolderID="RightContent">
    <asp:Button ID="Button2" runat="server" BackColor="#0099FF" Text="Button" Width="112px" />
</asp:Content>

