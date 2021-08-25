<%@ Page Title="" Language="C#" MasterPageFile="~/Organizador/SiteOrganizador.Master" AutoEventWireup="true" CodeBehind="Cargar_Torneo.aspx.cs" Inherits="Sistema_de_Gestion_de_Padel.Organizador.Cargar_Torneo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="container">
    <!-- Page Heading/Breadcrumbs -->
      <h1 class="mt-4 mb-3">Cargar Torneo</h1>
      <form name="CargarTorneo" id="CanchaForm" novalidate>
        <div class="controls">
            <label>Nombre del Torneo:</label>
            <asp:TextBox ID="TextBoxNombre" runat="server" class="form-control" maxlength="40" required data-validation-required-message="Por favor ingrese el nombre."></asp:TextBox>
            <p class="help-block"></p>
        </div>
        <div class="controls">
             <label>Fecha de Inicio:</label>
             <asp:TextBox ID="TextBoxFInicio" runat="server" class="form-control" maxlength="10" onKeypress="if (event.keyCode < 48 || event.keyCode > 57) event.returnValue = false;" required data-validation-required-message="Por favor ingrese la fecha de nacimiento." TextMode="Date"></asp:TextBox>
             <p class="help-block"></p>
        </div>
        <div class="controls">
             <label>Fecha de Fin:</label>
             <asp:TextBox ID="TextBoxFFin" runat="server" class="form-control" maxlength="10" onKeypress="if (event.keyCode < 48 || event.keyCode > 57) event.returnValue = false;" required data-validation-required-message="Por favor ingrese la fecha de nacimiento." TextMode="Date"></asp:TextBox>
             <p class="help-block"></p>
        </div>

        <div class="row">
            <div class="col-lg-4 mb-4">
            </div>
            <div class="col-lg-4 mb-4">
                <asp:Button ID="ButtonRegistrar" class="btn btn-lg btn-primary btn-block" 
                    runat="server" Text="Registrar Torneo" onclick="ButtonRegistrar_Click"/>
            </div>
        </div>
      </form>
</div>
</asp:Content>
