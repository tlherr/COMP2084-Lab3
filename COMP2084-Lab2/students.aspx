<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="students.aspx.cs" Inherits="COMP2084_Lab2.students" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Students</h1>

    <a class="btn btn-success" href="/student-details.aspx" role="button">Add New</a>
    <hr />

    <asp:GridView ID="gridStudents" runat="server" CssClass="table table-striped" AutoGenerateColumns="false">
       <Columns>
           <asp:BoundField DataField="StudentID" HeaderText="ID" />
           <asp:BoundField DataField="LastName" HeaderText="Lastname" />
           <asp:BoundField DataField="FirstMidName" HeaderText="Firstname" />
           <asp:BoundField DataField="EnrollmentDate" HeaderText="Date of Enrollment" />
       </Columns>
    </asp:GridView>


</asp:Content>
