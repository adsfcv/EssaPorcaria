<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="pageBD.aspx.cs" Inherits="EssaPorcaria.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:DataGrid ID="CadastrosDataGrid" 
    runat="server"
    CellPadding ="3"
    CellSpancing="0"
    Font-Names="CourierNew"
    Font-Size="10pt"
    HeaderStyle-BackColor="#aaaadd"
    AllowPaging="false"
    AllowSorting="false"
    PagSize="50"
    PagerStyle-Position="TopAndBottom"                                            
    PagerStyle-Font-Bold="true"
    PagerStyle-Font-Size="12pt"      
    PagerStyle-BackColor="#c0c0c0"/>  
    />
    


</asp:Content>
