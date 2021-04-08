<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GradeInfo.aspx.cs" Inherits="ISDA_WebApp.GradeInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Grade</h1>
    FNumber
    <br />
    <asp:DropDownList ID="DropDownListStudent" runat="server" Enabled ="false" />
    <br />
    Subject
    <br />
    <asp:DropDownList ID="DropDownListSubject" runat="server" Enabled ="false"/>
    <br />
    FinalGrade
    <br />
    <asp:TextBox ID="TextBoxFinalGrade" runat="server" />
    <br />
    <br />
    <asp:Button ID="ButtonSave" runat="server" Text="Save" OnClick="ButtonSave_Click" />

</asp:Content>
