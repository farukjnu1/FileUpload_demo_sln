<%@ Page Title="" Language="C#" MasterPageFile="~/Sales.Master" AutoEventWireup="true" CodeBehind="SalesForceCreate.aspx.cs" Inherits="FileUpload_demo.SalesForceCreate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
  
    <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
  <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
    <script>
        $(function () {
            $("#ContentPlaceHolder1_txtJoinDate").datepicker();
        });
  </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Add New Sales Force</h1>
    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Picture"></asp:Label>
    <asp:FileUpload ID="FileUpload1" runat="server" />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Join Date"></asp:Label>
    <asp:TextBox ID="txtJoinDate" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Territory"></asp:Label>
    <asp:DropDownList ID="ddlTerritory" runat="server"></asp:DropDownList>
    <br />
    <asp:Button ID="btnAdd" runat="server" Text="Add New" OnClick="btnAdd_Click" style="width: 37px"></asp:Button>
    <h4><a href="/SalesForces">Back to List</a></h4>
</asp:Content>
