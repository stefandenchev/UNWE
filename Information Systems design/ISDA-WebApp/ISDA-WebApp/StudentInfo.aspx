<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StudentInfo.aspx.cs" Inherits="ISDA_WebApp.StudentInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Student</h1>
    FNumber
    <br />
    <asp:TextBox ID="TextBoxStudentFNumber" runat="server" Enabled ="false" />
    <br />
    Specialty
    <br />
    <asp:DropDownList ID="DropDownListSpecialty" runat="server" />
    <br />
    FName
    <br />
    <asp:TextBox ID="TextBoxStudentFName" runat="server" />
    <br />
    MName
    <br />
    <asp:TextBox ID="TextBoxStudentMName" runat="server" />
    <br />
    LName
    <br />
    <asp:TextBox ID="TextBoxStudentLName" runat="server" />
    <br />
    Address
    <br />
    <asp:TextBox ID="TextBoxStudentAddress" runat="server" />
    <br />
    Phone
    <br />
    <asp:TextBox ID="TextBoxStudentPhone" runat="server" />
    <br />
    EMail
    <br />
    <asp:TextBox ID="TextBoxStudentEMail" runat="server" />
    <br />
    <br />
    <asp:Button ID="ButtonSave" runat="server" Text="Save" OnClick="ButtonSave_Click" />

</asp:Content>
