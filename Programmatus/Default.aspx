<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/GameMaster.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>


<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="GameContent">

    <asp:UpdatePanel ID="GameContentUpdatePanel" runat="server">
    </asp:UpdatePanel>

</asp:Content>

<asp:Content runat="server" ID="top" ContentPlaceHolderID="TopContent">

    <asp:UpdatePanel ID="EnergyUpdatePanel" runat="server">
        <ContentTemplate>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT [Username], [Level], [Energy], [Gold], [Experience] FROM [Player]"></asp:SqlDataSource>
        </ContentTemplate>
    </asp:UpdatePanel>
    <asp:Button ID="Button3" runat="server" Text="Button" />

</asp:Content>

<asp:Content runat="server" ID="left" ContentPlaceHolderID="LeftContent">
    <asp:Button ID="Button1" runat="server" BackColor="#0099FF" Text="Overview" Width="112px" />
</asp:Content>

<asp:Content runat="server" ID="right" ContentPlaceHolderID="RightContent">
    <asp:Button ID="Button2" runat="server" BackColor="#0099FF" Text="Button" Width="112px" />
</asp:Content>

