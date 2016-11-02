<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="students.aspx.cs" Inherits="COMP2084_Lab2.students" %>
<%@ Import Namespace="Microsoft.AspNet.FriendlyUrls" %>
<asp:Content ID="StudentsPage" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Students</h1>

    <a class="btn btn-success" href="/student-details.aspx" role="button">Add New</a>
    <hr />

    <asp:GridView ID="gridStudents" runat="server" CssClass="table table-striped" AutoGenerateColumns="false" OnRowDeleting="gridStudents_RowDeleting">
       <Columns>
           <asp:BoundField DataField="StudentID" HeaderText="ID" />
           <asp:BoundField DataField="LastName" HeaderText="Lastname" />
           <asp:BoundField DataField="FirstMidName" HeaderText="Firstname" />
           <asp:BoundField DataField="EnrollmentDate" HeaderText="Date of Enrollment" />

           <asp:HyperLinkField HeaderText="Edit" Text="Edit" NavigateUrl="~/student-details.aspx"
                 DataNavigateUrlFields="StudentID" 
                DataNavigateUrlFormatString="~/student-details.aspx?StudentID={0}" ControlStyle-CssClass="btn btn-warning" />

           <asp:CommandField HeaderText="Delete" ShowDeleteButton="true" ControlStyle-CssClass="btn btn-danger has-confirmation" />
       </Columns>
    </asp:GridView>


</asp:Content>

<asp:Content ID="StudentsScripts" ContentPlaceHolderID="Scripts" runat="server">
        <script src="/js/confirm.js"></script>
</asp:Content>
