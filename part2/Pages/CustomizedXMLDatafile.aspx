<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Site1.Master" AutoEventWireup="true" CodeBehind="CustomizedXMLDatafile.aspx.cs" Inherits="part2.Pages.CustomizedXMLDatafile" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Customized XML Data file <br />
<asp:Chart ID="Chart1" runat="server" BackColor="0, 0, 64" BackGradientStyle="LeftRight"  
        BorderlineWidth="0" Height="360px" Palette="None" PaletteCustomColors="Maroon"  
        Width="380px" BorderlineColor="64, 0, 64">  
        <Titles>  
            <asp:Title ShadowOffset="10" Name="Items" />  
        </Titles>  
        <Legends>  
            <asp:Legend Alignment="Center" Docking="Bottom" IsTextAutoFit="False" Name="Default"  
                LegendStyle="Row" />  
        </Legends>  
        <Series>  
            <asp:Series Name="Default" />  
        </Series>  
        <ChartAreas>  
            <asp:ChartArea Name="ChartArea1" BorderWidth="0" />  
        </ChartAreas>  
    </asp:Chart> <br />
    <asp:Button runat="server" Text="Button" />
</asp:Content>
