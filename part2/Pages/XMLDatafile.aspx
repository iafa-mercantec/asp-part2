<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Site1.Master" AutoEventWireup="true" CodeBehind="XMLDatafile.aspx.cs" Inherits="part2.Pages.XMLDatafile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <div id="page">
        <div id="loginbox" style="height:25vh;width:40vw;margin-left:15vw;">
            <div id="subtitle" style="width:38vw;">Product View</div>
            <div id="inputbox" style="padding-top:1vh;height:18vh;width:38vw;color:aliceblue;">
    
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>   
                <asp:Button class="button" ID="Button1" runat="server" Text="Show XML File" OnClick="Button1_Click" style="margin-top:1vh;"/>
            </div>
        </div>
    </div>
</asp:Content>
