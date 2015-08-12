<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="testConnection.aspx.cs" Inherits="TestWeb.testConnection" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
    </p>
    <p>
        <asp:HyperLink ID="HyperLink1" runat="server">Test textu</asp:HyperLink>
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Zmackni tlacitko pro ziskani stringu z webove sluzby"></asp:Label>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get Text" />
    </p>
    <p>
        <asp:Label ID="obtainedText" runat="server" Text="Label" Visible="False"></asp:Label>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
