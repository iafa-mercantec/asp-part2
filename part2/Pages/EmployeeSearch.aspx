<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Site1.Master" AutoEventWireup="true" CodeBehind="EmployeeSearch.aspx.cs" Inherits="part2.Pages.EmployeeSearch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Employee Search <br />
    <asp:Label ID="Label1" runat="server" Text="Search by name: "></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button7" runat="server" Text="Search" OnClick="Button7_Click" /> <br />
    <asp:Table ID="Table1" runat="server">
            <asp:TableRow>
        <asp:TableCell>Name</asp:TableCell>
        <asp:TableCell>Email</asp:TableCell>
        <asp:TableCell>PhoneNumber</asp:TableCell>
    </asp:TableRow>
    </asp:Table>
</asp:Content>
