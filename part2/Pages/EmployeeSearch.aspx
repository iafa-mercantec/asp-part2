<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Site1.Master" AutoEventWireup="true" CodeBehind="EmployeeSearch.aspx.cs" Inherits="part2.Pages.EmployeeSearch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="page">
        <div id="loginbox" style="height:25vh;">
            <div id="subtitle">Employee Search</div>
            <div id="inputbox" style="padding-top:1vh;height:18vh;color:antiquewhite">
                <asp:Label ID="Label1" runat="server" Text="Search by name: "></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:Button class="button" style="color:aliceblue;margin-top:1vh;width:16vw;" ID="Button7" runat="server" Text="Search" OnClick="Button7_Click" /> <br />
                <asp:Table ID="Table1" runat="server" style="width:16vw;margin-left:1vw;">
                <asp:TableRow>
                <asp:TableCell style="border-bottom:0.1vh solid antiquewhite;">Name</asp:TableCell>
                <asp:TableCell style="border-bottom:0.1vh solid antiquewhite;">Email</asp:TableCell>
                <asp:TableCell style="border-bottom:0.1vh solid antiquewhite;">PhoneNumber</asp:TableCell>
                </asp:TableRow>
                </asp:Table>
            </div>
        </div>
    </div>
</asp:Content>
