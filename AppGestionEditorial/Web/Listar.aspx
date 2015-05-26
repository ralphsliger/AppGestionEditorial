<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Site1.Master" AutoEventWireup="true" CodeBehind="Listar.aspx.cs" Inherits="App.Web.Listar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <div class="jumbotron">
        <h2>Lista de Compras</h2>
        <div class ="table-responsive">
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1"
                CssClass ="table table-bordered table-condensed table-responsive" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="Codigo" HeaderText="Id" SortExpression="Codigo" />
                    <asp:BoundField DataField="Fecha" HeaderText="Nombres" SortExpression="Fecha" />
                    <asp:BoundField DataField="Titulo" HeaderText="Apellidos" SortExpression="Titulo" />
                    <asp:BoundField DataField="Email" HeaderText="EmailP" SortExpression="Email" />
                    <asp:BoundField DataField="Nombre" HeaderText="EmailW" SortExpression="Nombre" />
                    <asp:BoundField DataField="Apellido" HeaderText="TelefonoP" SortExpression="Apellido" />
                    <asp:BoundField DataField="Telefono" HeaderText="TelefonoW" SortExpression="Telefono" />
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="getPersonas" TypeName="App.Datos.PersonasRepositories"></asp:ObjectDataSource>
    </div>

    </div>

</form>

</asp:Content>
