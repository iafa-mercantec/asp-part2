<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Site1.Master" AutoEventWireup="true" CodeBehind="ProductView.aspx.cs" Inherits="part2.Pages.ProductView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div id="page">
        <div id="loginbox" style="height:25vh;">
            <div id="subtitle">Product View</div>
            <div id="inputbox" style="padding-top:1vh;height:18vh;">
                <div style="font-size:1.5vh;text-align:left;padding-left:1vw;color:aliceblue;">Catagory:</div>
                <asp:DropDownList ID="DropDownList1" Style="width:16vw;" runat="server">
                </asp:DropDownList>
                <div style="font-size:1.5vh;text-align:left;padding-left:1vw;color:aliceblue;margin-top:1vh;">Product:</div>
                <asp:ListBox ID="ListBox1" runat="server" Style="width:16vw;height:10vh;">
                    <asp:ListItem>a</asp:ListItem>
                    <asp:ListItem>b</asp:ListItem>
                    <asp:ListItem>c</asp:ListItem>
                    <asp:ListItem>d</asp:ListItem>
                    <asp:ListItem>e</asp:ListItem>
                </asp:ListBox>
            </div>
        </div>
    </div>
</asp:Content>
