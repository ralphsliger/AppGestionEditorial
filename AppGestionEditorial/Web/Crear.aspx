<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Site1.Master" AutoEventWireup="true" CodeBehind="Crear.aspx.cs" Inherits="App.Web.Crear" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server" role="form" class="form-horizontal">
    <div class="jumbotron">
        <h2>Compra</h2>
             <div class="form-group">
                 Codigo
                <asp:TextBox ID="txtId" runat="server" class="form-control" ></asp:TextBox>
         </div>
             <div class="form-group">
                <label class="control-label">Nombres</label>
                 <asp:TextBox ID="txtNombres" runat="server" class="form-control" ></asp:TextBox>
          </div>
             <div class="form-group">
                <label class="control-label" >Apellidos</label>
                <asp:TextBox ID="txtApellidos" runat="server" class="form-control" ></asp:TextBox> 
           </div>
             <div class="form-group">
                <label class="control-label" >Email </label>
&nbsp;<asp:TextBox ID="txtEmailP" runat="server" class="form-control"  ></asp:TextBox>
             </div>
             <div class="form-group">
                 Titulo
                 <asp:TextBox ID="txtEmailW" runat="server" class="form-control"  ></asp:TextBox>
             </div>
             <div class="form-group">
                 Fecha
                 <asp:TextBox ID="txtTelefonoP" runat="server" class="form-control"  ></asp:TextBox>
             </div>
             <div class="form-group">
                <label class="control-label" >Telefono </label>
&nbsp;<asp:TextBox ID="txtTelefonoW" runat="server" class="form-control"  ></asp:TextBox>
             </div>
             <div class="form-group">
                <asp:Button ID="btnGuardar" runat="server" Text="Enviar" class="btn btn-group-lg btn-success" OnClick="btnGuardar_Click"/>
             </div>  
    </div>
    </form>
</asp:Content>
