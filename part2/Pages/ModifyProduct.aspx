<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Site1.Master" AutoEventWireup="true" CodeBehind="ModifyProduct.aspx.cs" Inherits="part2.Pages.ModifyProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="page">
        <div id="loginbox" style="height:40vh;margin-top:15vh;">
            <div id="subtitle">Modyfied Product</div>
            <div id="inputbox" style="padding-top:1vh;padding-left:1vw;height:30vh;text-align:left;color:aliceblue;width:17vw;">
                <asp:Label ID="Label11" runat="server" Text="Message"></asp:Label><br />
                <asp:Label ID="Label1" runat="server" Text="ProductID:" ></asp:Label>
                <asp:TextBox style="margin-left:2vw;width:10.5vw;" ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" AutoPostBack="True"></asp:TextBox><br />
                <asp:Label ID="Label2" runat="server" Text="Category:"></asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server" style="margin-left:2.4vw;width:10.8vw;">
                </asp:DropDownList><br />
                <asp:Label ID="Label3" runat="server" Text="Supplier:"></asp:Label>
                <asp:DropDownList style="margin-left:2.6vw;width:10.8vw;" ID="DropDownList2" runat="server">
                </asp:DropDownList><br />
                <asp:Label ID="Label4" runat="server" Text="Product:"></asp:Label>
                <asp:TextBox style="margin-left:2.8vw;width:10.5vw;" ID="TextBox2" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label5" runat="server" Text="Description:"></asp:Label>
                <asp:TextBox style="margin-left:1.65vw;width:10.5vw;" ID="TextBox3" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label6" runat="server" Text="Image:"></asp:Label>
                <asp:TextBox style="margin-left:3.25vw;width:10.5vw;" ID="TextBox4" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label7" runat="server" Text="Price:"></asp:Label>
                <asp:TextBox style="margin-left:3.6vw;width:10.5vw;" ID="TextBox5" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label8" runat="server" Text="Number in stock:"></asp:Label>
                <asp:TextBox style="margin-left:0.15vw;width:10.5vw;" ID="TextBox6" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label9" runat="server" Text="Number on order:"></asp:Label>
                <asp:TextBox style="margin-left:0vw;width:10.5vw;" ID="TextBox7" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label10" runat="server" Text="Reorder level:"></asp:Label>
                <asp:TextBox style="margin-left:1.1vw;width:10.5vw;" ID="TextBox8" runat="server"></asp:TextBox><br />
                <div style="text-align:center;margin-top:2vh;text-align:center;"><asp:Button class="button" style="color:aliceblue;" ID="Button7" runat="server" Text="Save" OnClick="Button7_Click" /></div>
            </div>
        </div>
    </div>
</asp:Content>
