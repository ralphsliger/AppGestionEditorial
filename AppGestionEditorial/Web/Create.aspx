<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Site1.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="App.Web.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form id="form1" runat="server" role="form" class="form-horizontal" data-toggle="validator">
    <div class="jumbotron">
        <h2>Crear Documentos</h2>

        <div class="form-group">
         <label class="control-label">Seleccionar Tipo de documento</label>
         <asp:DropDownList onChange="javascript:mostrarAtributos(this.value);" ID="type" runat="server" class="form-control" >
             <asp:ListItem Value="0">-seleccionar-</asp:ListItem>
             <asp:ListItem Value="libros">Libros</asp:ListItem>
             <asp:ListItem Value="revistas">Revistas</asp:ListItem>
             <asp:ListItem Value="cientificos">Cientificos</asp:ListItem>
             <asp:ListItem Value="otros">Otros</asp:ListItem>
         </asp:DropDownList>
         </div>

             <div class="form-group">
                <label class="control-label">Código</label>
                <asp:TextBox ID="txtCodigo" runat="server" class="form-control" required="required" ></asp:TextBox>
         </div>
             <div class="form-group">
                <label for="inputName" class="control-label">Titulo</label>
                 <asp:TextBox ID="txtTitulo" runat="server" class="form-control"  required="required"></asp:TextBox> 
          </div>       
             <div class="form-group">
                <label class="control-label" >Idiomas</label>
                <asp:TextBox ID="txtIdiomas" runat="server" class="form-control" required="required"></asp:TextBox> 
           </div>
             <div class="form-group">
                <label class="control-label" >Autores</label>
                 <asp:TextBox ID="txtAutores" runat="server" class="form-control"  required="required"></asp:TextBox>
             </div>
             <div class="form-group">
                <label class="control-label" >Numero de Paginas</label>     
                 <asp:TextBox ID="txtNpaginas" pattern="^([0-9]){1,}$" runat="server" class="form-control" required="required"  ></asp:TextBox>
                 <span class="help-block with-errors"></span>
             </div>
             <div class="form-group">
                <label class="control-label" >Editorial</label>
                 <asp:TextBox ID="txtEditorial" runat="server" class="form-control"  required="required"></asp:TextBox>
             </div>
             <div class="form-group">
                <label class="control-label" >Fecha Publicacion</label>
                 <asp:TextBox ID="txtFechaP" runat="server" class="form-control"  required="required"></asp:TextBox>
             </div>

                <div class="form-group">
                <label class="control-label" >Fecha Edición</label>
                 <asp:TextBox ID="txtFechaE" runat="server" class="form-control"  required="required"></asp:TextBox>
             </div>
            
            <div class="form-group">
                <label class="control-label" >Categoria</label>
                 <asp:TextBox ID="txtGenero" runat="server" class="form-control"  required="required"></asp:TextBox>
             </div>
            <div class="form-group">
                <label class="control-label" >Copias Disponibles</label>
                 <asp:TextBox ID="txtCantidad" runat="server" class="form-control"  ></asp:TextBox>
             </div>

        <!-- Libros -->
            <div class="form-group oculto" id="numeroCapitulos" >
                <label class="control-label" >Numero De Capitulos</label>
                 <asp:TextBox ID="txtnCapitulos"  runat="server" class="form-control" ></asp:TextBox>
                <span class="help-block with-errors"></span>
             </div>

            <div class="form-group oculto" id="numeroTomos">
                <label class="control-label" >Numero De Tomos</label>
                 <asp:TextBox ID="txtTomos"  runat="server" class="form-control" ></asp:TextBox>
                <span class="help-block with-errors"></span>
             </div>

        <div class="form-group oculto" id="nivel">
         <label class="control-label">Nivel</label>
         <asp:DropDownList ID="nivelLibro" runat="server" class="form-control" >
             <asp:ListItem Value="basico">Básico</asp:ListItem>
             <asp:ListItem Value="medio">Medio</asp:ListItem>
             <asp:ListItem Value="avanzado">Avanzado</asp:ListItem>
         </asp:DropDownList>
         </div>
            
        <!-- REVISTAS -->
            <div class="form-group oculto" id="numerovolumen">
                <label class="control-label" >Numero De volúmenes</label>
                 <asp:TextBox ID="txtVolumenes" runat="server" class="form-control" ></asp:TextBox>
                <span class="help-block with-errors"></span>
             </div>

            <div class="form-group oculto" id="numeroarticulos">
                <label class="control-label" >Numero De Articulos</label>
                 <asp:TextBox ID="txtArticulos" runat="server" class="form-control" ></asp:TextBox>
                <span class="help-block with-errors"></span>
             </div>



        <!-- DOCUMENTO CIENTIFICO -->
            <div class="form-group oculto" id="tipo">
                <label class="control-label" >Tipo</label>
                 <asp:TextBox ID="txtTipo" runat="server" class="form-control" ></asp:TextBox>
             </div>


            <div class="form-group">
             <label class="control-label">Seleccionar Formato</label>
             <asp:DropDownList onChange="javascript:mostrarPermisos(this.value);" ID="formatodoc" runat="server" class="form-control" >
                 <asp:ListItem Value="digital">Digital</asp:ListItem>
                 <asp:ListItem Value="impreso">Impreso</asp:ListItem>
                 <asp:ListItem Value="multimedia">Multimedia</asp:ListItem>
             </asp:DropDownList>
             </div>

            <div class="form-group checkbox">
            <label class="control-label" >Seleccionar Permisos</label>
         <br />
                <asp:CheckBox ID="chLeer" runat="server" Text="Leer" TextAlign="Right" /> <br />
                <asp:CheckBox ID="chGuardar" runat="server" Text="Guardar"/> <br />
                <asp:CheckBox ID="chImprimir" runat="server" Text="Imprimir" /> <br />
                <asp:CheckBox ID="chEditar" runat="server" Text="Editar" /><br />
                <asp:CheckBox ID="chEscuchar" runat="server" Text="Escuchar" /><br />
                <asp:CheckBox ID="chVisualizar" runat="server" Text="Visualizar" /><br />
            </div>

             <div class="form-group">
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" class="btn btn-group-lg btn-success" OnClick="btnGuardar_Click"/>
             </div>  
    </div>
    </form>
</asp:Content>
