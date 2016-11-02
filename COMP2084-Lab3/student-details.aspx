<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="student-details.aspx.cs" Inherits="COMP2084_Lab2.student_details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Create New Students</h1>

    <div class="form-group">
        <label for="txtFirstName" class="col-sm-2 control-label">First Name: </label>
        <asp:TextBox ID="txtFirstName" runat="server" required></asp:TextBox>
    </div>

    <div class="form-group">
        <label for="txtLastName" class="col-sm-2 control-label">Last Name: </label>
        <asp:TextBox ID="txtLastName" runat="server" required></asp:TextBox>
    </div>

    <div class="form-group">
        <label for="txtEnrollmentDate" class="col-sm-2 control-label">Enrollment Date: </label>
        <asp:TextBox ID="txtEnrollmentDate" runat="server" required TextMode="Date"></asp:TextBox>
    </div>
    <asp:Button CssClass="btn btn-success col-sm-offset-2" ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />

</asp:Content>
