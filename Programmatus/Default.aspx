<%@ Page Title="Programmatus" Language="C#" MasterPageFile="~/GameMaster.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>


<asp:Content runat="server" ID="body" ContentPlaceHolderID="GameContent">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <fieldset>
                <legend>UpdatePanel</legend>
                    <asp:Label ID="Label6" runat="server" Text="test"></asp:Label>
                </fieldset>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

<asp:Content runat="server" ID="top" ContentPlaceHolderID="TopContent">
</asp:Content>

<asp:Content runat="server" ID="left" ContentPlaceHolderID="LeftContent">
</asp:Content>

