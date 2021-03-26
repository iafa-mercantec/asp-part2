<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Site1.Master" AutoEventWireup="true" CodeBehind="ModifyProduct.aspx.cs" Inherits="part2.Pages.ModifyProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Modyfied Product<br />
    <asp:Label ID="Label11" runat="server" Text="Message"></asp:Label><br />
    <asp:Label ID="Label1" runat="server" Text="ProductID"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" AutoPostBack="True"></asp:TextBox><br />
    <asp:Label ID="Label2" runat="server" Text="Category"></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList><br />
    <asp:Label ID="Label3" runat="server" Text="Supplier"></asp:Label>
    <asp:DropDownList ID="DropDownList2" runat="server">
    </asp:DropDownList><br />
    <asp:Label ID="Label4" runat="server" Text="Product"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label5" runat="server" Text="Description"></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label6" runat="server" Text="Image"></asp:Label>
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label7" runat="server" Text="Price"></asp:Label>
    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label8" runat="server" Text="Number in stock"></asp:Label>
    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label9" runat="server" Text="Number on order"></asp:Label>
    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label10" runat="server" Text="Reorder level"></asp:Label>
    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox><br />
    <asp:Button ID="Button7" runat="server" Text="Save" OnClick="Button7_Click" />
</asp:Content>
