<%@ Page Title="" Language="C#" MasterPageFile="~/Operario/SiteOperario.Master" AutoEventWireup="true" CodeBehind="Nuevo_Cliente.aspx.cs" Inherits="Sistema_de_Gestion_de_Padel.Operario.Nuevo_Cliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="container">
    <!-- Page Heading/Breadcrumbs -->
      <h1 class="mt-4 mb-3">Cargar Nuevo Socio</h1>
      <form name="CargarCliente" id="ClienteForm" novalidate>
      <label>Ingrese DNI: </label>
      <div class="row">
            <div class="col-lg-4 mb-4">
                <asp:TextBox ID="TextBoxDNI" runat="server" class="form-control" maxlength="8" onKeypress="if (event.keyCode < 48 || event.keyCode > 57) event.returnValue = false;" required data-validation-required-message="Por favor ingrese el dni."></asp:TextBox>
            </div>
            <div class="col-lg-4 mb-4">
                <asp:Button ID="ButtonBuscar" class="btn btn-lg btn-primary btn-block" 
                    runat="server" Text="Verificar Cliente" onclick="ButtonBuscar_Click"/>
            </div>
            <div class="col-lg-4 mb-4">
                <asp:Label ID="LabelError" runat="server" Text="" 
                    style="color: #FF0000; font-weight: 700"></asp:Label>
            </div>
      </div>
      <p class="help-block">
          &nbsp;<asp:Panel ID="Panel1" runat="server" class="controls" Visible="False">
      <div class="controls">
                <label>Nombre:</label>
                <asp:TextBox ID="TextBoxNombre" runat="server" class="form-control" maxlength="50" required data-validation-required-message="Por favor ingrese el nombre."></asp:TextBox>
                <p class="help-block"></p>
        </div>
        <div class="controls">
                <label>Apellido:</label>
                <asp:TextBox ID="TextBoxApellido" runat="server" class="form-control" 
                     required 
                    data-validation-required-message="Por favor ingrese el apellido." Wrap="False"></asp:TextBox>
                <p class="help-block"></p>
        </div>
        <div class="controls">
                <label>Localidad:</label>
                <asp:DropDownList ID="DropDownList1" runat="server" 
                    DataSourceID="SqlDataSource1" DataTextField="NombreLocalidadP" 
                    DataValueField="NombreLocalidadP" class="form-control">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:SistemaDeGestionDePadelConnectionString %>" 
                    SelectCommand="SELECT [LocalidadPId], [NombreLocalidadP] FROM [LocalidadP]">
                </asp:SqlDataSource>
                <p class="help-block"></p>
        </div>
        <div class="controls">
                <label>Fecha de Nacimiento:</label>
                <asp:TextBox ID="TextBoxFNac" runat="server" class="form-control" maxlength="10" onKeypress="if (event.keyCode < 48 || event.keyCode > 57) event.returnValue = false;" required data-validation-required-message="Por favor ingrese la fecha de nacimiento." TextMode="Date"></asp:TextBox>
                <p class="help-block"></p>
        </div>
        <div class="controls">
                <label>Telefono:</label>
                <asp:TextBox ID="TextBoxTelefono" runat="server" class="form-control" maxlength="10" onKeypress="if (event.keyCode < 48 || event.keyCode > 57) event.returnValue = false;" required data-validation-required-message="Por favor ingrese el telefono."></asp:TextBox>
                <p class="help-block"</p>
        </div>

        <div class="row">
            <div class="col-lg-4 mb-4">
            </div>
            <div class="col-lg-4 mb-4">
                <asp:Button ID="Button1" class="btn btn-lg btn-primary btn-block" 
                    runat="server" Text="Registrar" onclick="Button1_Click"/>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-4 mb-4">
            </div>
            <div class="col-lg-4 mb-4">
                <asp:Button ID="Button2" class="btn btn-lg btn-primary btn-block" 
                    runat="server" Text="Registrar" onclick="Button2_Click"/>
            </div>
        </div>
        <p class="help-block"></p>
      </asp:Panel>
       </form>
       </div>
</asp:Content>
