<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Site1.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="part2.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="page">
        <div id="loginbox">
            <div id="subtitle">Login</div>
            <div id="inputbox" style="padding-top:1vh;">
                <div style="font-size:1.5vh;">Username:<asp:TextBox class="loginfield" ID="TextBox1" runat="server"></asp:TextBox></div>
                <div style="font-size:1.5vh;">Password :<asp:TextBox class="loginfield" ID="TextBox2" runat="server"></asp:TextBox></div>
            </div>
            <div id="submit"><asp:Button class="button" style="color:aliceblue;" ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" /></div>
        </div>
    </div>
    
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RegiConnectionString %>" SelectCommand="SELECT * FROM [Customer]"></asp:SqlDataSource>
    
</asp:Content>
