<%@ Page Title="" Language="C#" MasterPageFile="~/Sales.Master" AutoEventWireup="true" CodeBehind="SalesForceList.aspx.cs" Inherits="FileUpload_demo.SalesForceList" enableEventValidation="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Sales Force List</h1>
    <h4><a href="/SalesForce">New Sales Force</a></h4>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" OnRowCommand="GridView1_RowCommand" CellPadding="10">
        <Columns>
            <asp:BoundField DataField="SalesForceId" HeaderText="ID" />
            <asp:BoundField DataField="SalesForceName" HeaderText="Name" />
            <asp:BoundField DataField="JoinDate" HeaderText="Join Date" />
            <asp:BoundField DataField="SalesterritoryName" HeaderText="Territory" />
            <asp:ImageField DataImageUrlField="Pic" HeaderText="Picture"></asp:ImageField>
            <asp:ButtonField HeaderText="#" CommandName="Edit" Text="Edit"></asp:ButtonField>
            <asp:ButtonField HeaderText="#" CommandName="Remove" Text="Delete"></asp:ButtonField>
        </Columns>
    </asp:GridView>
</asp:Content>