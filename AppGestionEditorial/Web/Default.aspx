<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="App.Web.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="jumbotron">
        <h1>Gestion Editorial </h1>
        <p class="lead">Cras justo odio, dapibus ac facilisis in, egestas eget quam. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus.</p>
        <p>
            <a class="btn btn-lg btn-success" href="Crear.aspx" role="button">Home</a>
            <a class="btn btn-lg btn-success" href="Listar.aspx" role="button">Articulos</a>
             <a class="btn btn-lg btn-success" href="Listar.aspx" role="button">Categorias</a>
             <a class="btn btn-lg btn-success" href="Listar.aspx" role="button">Comprar</a>

        </p>
      </div>
</asp:Content>
