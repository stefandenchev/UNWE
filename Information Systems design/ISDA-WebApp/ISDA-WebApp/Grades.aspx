<%@ Page Title="Grades" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Grades.aspx.cs" Inherits="ISDA_WebApp.Grades" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Grades</h1>
    <asp:GridView ID="GridViewContent" runat="server"
        OnRowCommand="GridViewContent_RowCommand" AutoGenerateColumns="False" Width="646px">
        <Columns>
            <asp:ButtonField ButtonType="Link"
                CommandName="Select"
                HeaderText=""
                Text="Select" />

            <asp:BoundField HeaderText="FNumber" DataField="FNumber"></asp:BoundField>
            <asp:BoundField HeaderText="FName" DataField="FName"></asp:BoundField>
            <asp:BoundField HeaderText="MName" DataField="MName"></asp:BoundField>
            <asp:BoundField HeaderText="LName" DataField="LName"></asp:BoundField>
            <asp:BoundField HeaderText="SubjectId" DataField="SubjectId"></asp:BoundField>
            <asp:BoundField HeaderText="SubjectName" DataField="SubjectName"></asp:BoundField>
            <asp:BoundField HeaderText="FinalGrade" DataField="FinalGrade"></asp:BoundField>

        </Columns>
    </asp:GridView>

</asp:Content>
