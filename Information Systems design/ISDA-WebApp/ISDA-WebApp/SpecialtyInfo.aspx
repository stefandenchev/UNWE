<%@ Page Title="Specialty Info" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SpecialtyInfo.aspx.cs" Inherits="ISDA_WebApp.SpecialtyInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    ID
 <br />
    <asp:TextBox ID="TextBoxSpecialtyID" runat="server" Enabled="false" />
    <br />
    Name
 <br />
    <asp:TextBox ID="TextBoxSpecialtyName" runat="server" />
    <br />
    <br />
    <asp:Button ID="ButtonSave" runat="server" Text="Save" OnClick="ButtonSave_Click" />

</asp:Content>
