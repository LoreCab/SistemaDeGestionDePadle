<%@ Page Title="" Language="C#" MasterPageFile="~/Organizador/SiteOrganizador.Master" AutoEventWireup="true" CodeBehind="Cargar_Partidos.aspx.cs" Inherits="Sistema_de_Gestion_de_Padel.Organizador.Cargar_Partidos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
<div class="container">
    <!-- Page Heading/Breadcrumbs -->
        <h1 class="mt-4 mb-3">Cargar Partidos</h1>
            <form name="CargarEquipos" id="CanchaForm" novalidate>
                <div class="row"><!-- BUSCAR TORNEO-->
                    <div class="col-lg-6 mb-4">
                        <asp:DropDownList ID="DropDownList1" runat="server" class="form-control" 
                            DataSourceID="SqlDataSource1" DataTextField="NombreTorneo" 
                            DataValueField="TorneoId">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:SistemaDeGestionDePadelConnectionString %>" 
                            SelectCommand="SELECT [TorneoId], [NombreTorneo] FROM [Torneo]">
                        </asp:SqlDataSource>
                    </div>
                    <div class="col-lg-6 mb-4">
                        <asp:Button ID="ButtonBuscarTorneo" class="btn btn-lg btn-primary btn-block" 
                            runat="server" Text="Confirmar Torneo" onclick="ButtonBuscarTorneo_Click"/>
                    </div>
                </div>
            <p class="help-block"></p>
            <asp:Panel ID="Panel1" runat="server" Visible="false">
            <div class="row">
          <div class="col-lg-6 mb-6" style="background-color:#FFFF00" >
              <p class="help-block"></p>  
                <asp:Label ID="Label1" runat="server" Text="GRUPO A" style="font-weight: 700"></asp:Label>
                <p class="help-block"></p>
           <table>
          <asp:TableHeaderRow ID="TableHeaderRow10" 
                runat="server" 
                ForeColor="Snow"
                BackColor="#007BFF"
                Font-Bold="true"
                >
                <asp:TableHeaderCell>
                    <asp:Label ID="Label56" runat="server"  Width="280px" Text="PARTIDO 1"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label57" runat="server" Width="60px" Text="SET 1"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label58" runat="server" Width="60px" Text="SET 2"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label59" runat="server" Width="60px" Text="SET 3"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label60" runat="server" Width="67px" Text="GANO"></asp:Label></asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow 
                ID="TableRow19" 
                runat="server" 
                BackColor="OrangeRed"
                >
                <asp:TableCell><asp:Label ID="grupoAequipo1partido1" runat="server" Text="EQUIPO1"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoAequipo1partido1set1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoAequipo1partido1set2" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoAequipo1partido1set3" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoAequipo1partido1puntos1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow20" 
                runat="server" 
                BackColor="OrangeRed"
                >
                <asp:TableCell><asp:Label ID="grupoAequipo2partido1" runat="server" Text="EQUIPO2"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoAequipo2partido1set1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoAequipo2partido1set2" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoAequipo2partido1set3" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoAequipo2partido1puntos1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            </table>
               <p class="help-block"></p>
             
              <%-- partido2 tabla--%>
         <table>
          <asp:TableHeaderRow ID="TableHeaderRow11" 
                runat="server" 
                ForeColor="Snow"
                BackColor="#007BFF"
                Font-Bold="true"
                >
                <asp:TableHeaderCell>
                    <asp:Label ID="Label63" runat="server"  Width="280px" Text="PARTIDO 2"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label64" runat="server" Width="60px" Text="SET 1"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label65" runat="server" Width="60px" Text="SET 2"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label66" runat="server" Width="60px" Text="SET 3"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label67" runat="server" Width="67px" Text="GANO"></asp:Label></asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow 
                ID="TableRow21" 
                runat="server" 
                BackColor="OrangeRed"
                >
                <asp:TableCell><asp:Label ID="grupoAequipo1partido2" runat="server" Text="EQUIPO1"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoAequipo1partido2set1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoAequipo1partido2set2" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoAequipo1partido2set3" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoAequipo1partido2puntos1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow22" 
                runat="server" 
                BackColor="OrangeRed"
                >
                <asp:TableCell><asp:Label ID="grupoAequipo3partido2" runat="server" Text="EQUIPO3"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoAequipo3partido2set1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoAequipo3partido2set2" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoAequipo3partido2set3" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoAequipo3partido2puntos1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            </table>
             <p class="help-block"></p>
            <%--partido 3 tabla--%>
            <table>
          <asp:TableHeaderRow ID="TableHeaderRow12" 
                runat="server" 
                ForeColor="Snow"
                BackColor="#007BFF"
                Font-Bold="true"
                >
                <asp:TableHeaderCell>
                    <asp:Label ID="Label70" runat="server"  Width="280px" Text="PARTIDO 3"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label71" runat="server" Width="60px" Text="SET 1"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label72" runat="server" Width="60px" Text="SET 2"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label73" runat="server" Width="60px" Text="SET 3"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label74" runat="server" Width="67px" Text="GANO"></asp:Label></asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow 
                ID="TableRow23" 
                runat="server" 
                BackColor="OrangeRed"
                >
                <asp:TableCell><asp:Label ID="grupoAequipo2partido3" runat="server" Text="EQUIPO2"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoAequipo2partido3set1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoAequipo2partido3set2" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoAequipo2partido3set3" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoAequipo2partido3puntos1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow24" 
                runat="server" 
                BackColor="OrangeRed"
                >
                <asp:TableCell><asp:Label ID="grupoAequipo3partido3" runat="server" Text="EQUIPO3"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoAequipo3partido3set1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoAequipo3partido3set2" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoAequipo3partido3set3" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoAequipo3partido3puntos1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            </table>

             <p class="help-block"></p>
              <asp:Button ID="ButtonGrupoA" class="btn btn-lg btn-primary btn-block" 
                  runat="server" Text="Guardar Puntajes" onclick="ButtonGrupoA_Click"/>
              <p class="help-block"></p>
          </div>
          <div class="col-lg-6 mb-6" style="background-color:#80FF00" >
          <p class="help-block"></p>  
          <asp:Label ID="Label3" runat="server" Text="GRUPO B" style="font-weight: 700"></asp:Label>
          <p class="help-block"></p>
                   <table>
          <asp:TableHeaderRow ID="TableHeaderRow7" 
                runat="server" 
                ForeColor="Snow"
                BackColor="#007BFF"
                Font-Bold="true"
                >
                <asp:TableHeaderCell>
                    <asp:Label ID="Label25" runat="server"  Width="280px" Text="PARTIDO 1"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label26" runat="server" Width="60px" Text="SET 1"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label32" runat="server" Width="60px" Text="SET 2"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label33" runat="server" Width="60px" Text="SET 3"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label39" runat="server" Width="67px" Text="GANO"></asp:Label></asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow 
                ID="TableRow13" 
                runat="server" 
                BackColor="OrangeRed"
                >
                <asp:TableCell><asp:Label ID="grupoBequipo1partido1" runat="server" Text="EQUIPO1"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoBequipo1partido1set1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoBequipo1partido1set2" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoBequipo1partido1set3" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoBequipo1partido1puntos1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow14" 
                runat="server" 
                BackColor="OrangeRed"
                >
                <asp:TableCell><asp:Label ID="grupoBequipo2partido1" runat="server" Text="EQUIPO2"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoBequipo2partido1set1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoBequipo2partido1set2" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoBequipo2partido1set3" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoBequipo2partido1puntos1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            </table>
               <p class="help-block"></p>
             
              <%-- partido2 tabla--%>
         <table>
          <asp:TableHeaderRow ID="TableHeaderRow8" 
                runat="server" 
                ForeColor="Snow"
                BackColor="#007BFF"
                Font-Bold="true"
                >
                <asp:TableHeaderCell>
                    <asp:Label ID="Label42" runat="server"  Width="280px" Text="PARTIDO 2"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label43" runat="server" Width="60px" Text="SET 1"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label44" runat="server" Width="60px" Text="SET 2"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label45" runat="server" Width="60px" Text="SET 3"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label46" runat="server" Width="67px" Text="GANO"></asp:Label></asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow 
                ID="TableRow15" 
                runat="server" 
                BackColor="OrangeRed"
                >
                <asp:TableCell><asp:Label ID="grupoBequipo1partido2" runat="server" Text="EQUIPO1"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoBequipo1partido2set1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoBequipo1partido2set2" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoBequipo1partido2set3" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoBequipo1partido2puntos1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow16" 
                runat="server" 
                BackColor="OrangeRed"
                >
                <asp:TableCell><asp:Label ID="grupoBequipo3partido2" runat="server" Text="EQUIPO3"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoBequipo3partido2set1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoBequipo3partido2set2" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoBequipo3partido2set3" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoBequipo3partido2puntos1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            </table>
             <p class="help-block"></p>
            <%--partido 3 tabla--%>
            <table>
          <asp:TableHeaderRow ID="TableHeaderRow9" 
                runat="server" 
                ForeColor="Snow"
                BackColor="#007BFF"
                Font-Bold="true"
                >
                <asp:TableHeaderCell>
                    <asp:Label ID="Label49" runat="server"  Width="280px" Text="PARTIDO 3"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label50" runat="server" Width="60px" Text="SET 1"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label51" runat="server" Width="60px" Text="SET 2"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label52" runat="server" Width="60px" Text="SET 3"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label53" runat="server" Width="67px" Text="GANO"></asp:Label></asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow 
                ID="TableRow17" 
                runat="server" 
                BackColor="OrangeRed"
                >
                <asp:TableCell><asp:Label ID="grupoBequipo2partido3" runat="server" Text="EQUIPO2"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoBequipo2partido3set1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoBequipo2partido3set2" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoBequipo2partido3set3" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoBequipo2partido3puntos1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow18" 
                runat="server" 
                BackColor="OrangeRed"
                >
                <asp:TableCell><asp:Label ID="grupoBequipo3partido3" runat="server" Text="EQUIPO3"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoBequipo3partido3set1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoBequipo3partido3set2" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoBequipo3partido3set3" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoBequipo3partido3puntos1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            </table>
            <p class="help-block"></p>
            <asp:Button ID="ButtonGrupoB" class="btn btn-lg btn-primary btn-block" 
                  runat="server" Text="Guardar Puntajes" onclick="ButtonGrupoB_Click"/>
            <p class="help-block"></p>
          </div>
          
          
    </div>
    <div class="row">
          
          <div class="col-lg-6 mb-6" style="background-color:#fb0180" >
          <p class="help-block"></p>  
          <asp:Label ID="Label4" runat="server" Text="GRUPO C" style="font-weight: 700"></asp:Label>
          <p class="help-block"></p>
         <table>
          <asp:TableHeaderRow ID="TableHeaderRow4" 
                runat="server" 
                ForeColor="Snow"
                BackColor="#007BFF"
                Font-Bold="true"
                >
                <asp:TableHeaderCell>
                    <asp:Label ID="Label20" runat="server"  Width="280px" Text="PARTIDO 1"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label21" runat="server" Width="60px" Text="SET 1"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label22" runat="server" Width="60px" Text="SET 2"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label23" runat="server" Width="60px" Text="SET 3"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label24" runat="server" Width="67px" Text="GANO"></asp:Label></asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow 
                ID="TableRow6" 
                runat="server" 
                BackColor="OrangeRed"
                >
                <asp:TableCell><asp:Label ID="grupoCequipo1partido1" runat="server" Text="EQUIPO1"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoCequipo1partido1set1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoCequipo1partido1set2" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoCequipo1partido1set3" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoCequipo1partido1puntos1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow7" 
                runat="server" 
                BackColor="OrangeRed"
                >
                <asp:TableCell><asp:Label ID="grupoCequipo2partido1" runat="server" Text="EQUIPO2"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoCequipo2partido1set1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoCequipo2partido1set2" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoCequipo2partido1set3" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoCequipo2partido1puntos1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            </table>
               <p class="help-block"></p>
             
              <%-- partido2 tabla--%>
         <table>
          <asp:TableHeaderRow ID="TableHeaderRow5" 
                runat="server" 
                ForeColor="Snow"
                BackColor="#007BFF"
                Font-Bold="true"
                >
                <asp:TableHeaderCell>
                    <asp:Label ID="Label27" runat="server"  Width="280px" Text="PARTIDO 2"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label28" runat="server" Width="60px" Text="SET 1"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label29" runat="server" Width="60px" Text="SET 2"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label30" runat="server" Width="60px" Text="SET 3"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label31" runat="server" Width="67px" Text="GANO"></asp:Label></asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow 
                ID="TableRow8" 
                runat="server" 
                BackColor="OrangeRed"
                >
                <asp:TableCell><asp:Label ID="grupoCequipo1partido2" runat="server" Text="EQUIPO1"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoCequipo1partido2set1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoCequipo1partido2set2" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoCequipo1partido2set3" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoCequipo1partido2puntos1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow10" 
                runat="server" 
                BackColor="OrangeRed"
                >
                <asp:TableCell><asp:Label ID="grupoCequipo3partido2" runat="server" Text="EQUIPO3"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoCequipo3partido2set1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoCequipo3partido2set2" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoCequipo3partido2set3" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoCequipo3partido2puntos1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            </table>
             <p class="help-block"></p>
            <%--partido 3 tabla--%>
            <table>
          <asp:TableHeaderRow ID="TableHeaderRow6" 
                runat="server" 
                ForeColor="Snow"
                BackColor="#007BFF"
                Font-Bold="true"
                >
                <asp:TableHeaderCell>
                    <asp:Label ID="Label34" runat="server"  Width="280px" Text="PARTIDO 3"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label35" runat="server" Width="60px" Text="SET 1"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label36" runat="server" Width="60px" Text="SET 2"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label37" runat="server" Width="60px" Text="SET 3"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label38" runat="server" Width="67px" Text="GANO"></asp:Label></asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow 
                ID="TableRow11" 
                runat="server" 
                BackColor="OrangeRed"
                >
                <asp:TableCell><asp:Label ID="grupoCequipo2partido3" runat="server" Text="EQUIPO2"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoCequipo2partido3set1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoCequipo2partido3set2" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoCequipo2partido3set3" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoCequipo2partido3puntos1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow12" 
                runat="server" 
                BackColor="OrangeRed"
                >
                <asp:TableCell><asp:Label ID="grupoCequipo3partido3" runat="server" Text="EQUIPO3"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoCequipo3partido3set1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoCequipo3partido3set2" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoCequipo3partido3set3" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoCequipo3partido3puntos1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            </table>
            <p class="help-block"></p>
              <asp:Button ID="ButtonGrupoC" class="btn btn-lg btn-primary btn-block" 
                  runat="server" Text="Guardar Puntajes" onclick="ButtonGrupoC_Click"/>
              <p class="help-block"></p>
          </div>
          <%--GRUPO D--%>
          <div class="col-lg-6 mb-6" style="background-color:#BF00FF" >
          <p class="help-block"></p>  
          <asp:Label ID="Label5" runat="server" Text="GRUPO D" style="font-weight: 700"></asp:Label>
          <p class="help-block"></p>
         <table>
          <asp:TableHeaderRow ID="TableHeaderRow1" 
                runat="server" 
                ForeColor="Snow"
                BackColor="#007BFF"
                Font-Bold="true"
                >
                <asp:TableHeaderCell>
                    <asp:Label ID="Label9" runat="server"  Width="280px" Text="PARTIDO 1"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label16" runat="server" Width="60px" Text="SET 1"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label17" runat="server" Width="60px" Text="SET 2"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label18" runat="server" Width="60px" Text="SET 3"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label19" runat="server" Width="67px" Text="GANO"></asp:Label></asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow 
                ID="TableRow5" 
                runat="server" 
                BackColor="OrangeRed"
                >
                <asp:TableCell><asp:Label ID="grupoDequipo1partido1" runat="server" Text="EQUIPO1"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoDequipo1partido1set1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoDequipo1partido1set2" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoDequipo1partido1set3" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoDequipo1partido1puntos1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow9" 
                runat="server" 
                BackColor="OrangeRed"
                >
                <asp:TableCell><asp:Label ID="grupoDequipo2partido1" runat="server" Text="EQUIPO2"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoDequipo2partido1set1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoDequipo2partido1set2" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoDequipo2partido1set3" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoDequipo2partido1puntos1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            </table>
               <p class="help-block"></p>
             
              <%-- partido2 tabla--%>
         <table>
          <asp:TableHeaderRow ID="TableHeaderRow2" 
                runat="server" 
                ForeColor="Snow"
                BackColor="#007BFF"
                Font-Bold="true"
                >
                <asp:TableHeaderCell>
                    <asp:Label ID="Label2" runat="server"  Width="280px" Text="PARTIDO 2"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label6" runat="server" Width="60px" Text="SET 1"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label7" runat="server" Width="60px" Text="SET 2"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label8" runat="server" Width="60px" Text="SET 3"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label10" runat="server" Width="67px" Text="GANO"></asp:Label></asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow 
                ID="TableRow1" 
                runat="server" 
                BackColor="OrangeRed"
                >
                <asp:TableCell><asp:Label ID="grupoDequipo1partido2" runat="server" Text="EQUIPO1"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoDequipo1partido2set1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoDequipo1partido2set2" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoDequipo1partido2set3" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoDequipo1partido2puntos1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow2" 
                runat="server" 
                BackColor="OrangeRed"
                >
                <asp:TableCell><asp:Label ID="grupoDequipo3partido2" runat="server" Text="EQUIPO3"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoDequipo3partido2set1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoDequipo3partido2set2" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoDequipo3partido2set3" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoDequipo3partido2puntos1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            </table>
             <p class="help-block"></p>
            <%--partido 3 tabla--%>
            <table>
          <asp:TableHeaderRow ID="TableHeaderRow3" 
                runat="server" 
                ForeColor="Snow"
                BackColor="#007BFF"
                Font-Bold="true"
                >
                <asp:TableHeaderCell>
                    <asp:Label ID="Label11" runat="server"  Width="280px" Text="PARTIDO 3"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label12" runat="server" Width="60px" Text="SET 1"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label13" runat="server" Width="60px" Text="SET 2"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label14" runat="server" Width="60px" Text="SET 3"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label15" runat="server" Width="67px" Text="GANO"></asp:Label></asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow 
                ID="TableRow3" 
                runat="server" 
                BackColor="OrangeRed"
                >
                <asp:TableCell><asp:Label ID="grupoDequipo2partido3" runat="server" Text="EQUIPO2"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoDequipo2partido3set1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoDequipo2partido3set2" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoDequipo2partido3set3" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoDequipo2partido3puntos1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow4" 
                runat="server" 
                BackColor="OrangeRed"
                >
                <asp:TableCell><asp:Label ID="grupoDequipo3partido3" runat="server" Text="EQUIPO3"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoDequipo3partido3set1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoDequipo3partido3set2" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoDequipo3partido3set3" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="grupoDequipo3partido3puntos1" runat="server"  Width="30px" Text="0"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            </table>
            <p class="help-block"></p>
              <asp:Button ID="ButtonGrupoD" class="btn btn-lg btn-primary btn-block" 
                  runat="server" Text="Guardar Puntajes" onclick="ButtonGrupoD_Click"/>
              <p class="help-block"></p>
              
          </div>
              
     </div>
            </asp:Panel>
            <asp:Panel ID="Panel2" runat="server" Visible="false">
            <p class="help-block"></p>
            <table class="style4">
        <tr>
            <td class="style5" align="center">
                <asp:Label ID="Label75" runat="server" Text="4° DE FINAL" Font-Bold="True" 
                    ForeColor="#007BFF"></asp:Label>
                    <p class="help-block"></p>
            </td>
            <td class="style6" align="center">
                <asp:Label ID="Label76" runat="server" Text="SEMIFINAL" Font-Bold="True" 
                    ForeColor="#007BFF"></asp:Label>
            </td>
            <td align="center">
                <asp:Label ID="Label77" runat="server" Text="FINAL" Font-Bold="True" 
                    ForeColor="#007BFF"></asp:Label>
            </td>
           <%-- <td>
                <asp:Label ID="Label78" runat="server" Text="GANADOR"></asp:Label>
            </td>--%>
        </tr>
        <tr>
            <td class="style5">
                
            <table>
          <asp:TableHeaderRow ID="TableHeaderRow13" 
                runat="server" 
                ForeColor="Snow"
                BackColor="#007BFF"
                Font-Bold="true"
                >
                <asp:TableHeaderCell>
                    <asp:Label ID="Label79" runat="server"  Width="180px" Text="EQUIPO"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label80" runat="server" Width="50px" Text="SET 1"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label81" runat="server" Width="50px" Text="SET 2"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label82" runat="server" Width="50px" Text="SET 3"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label83" runat="server" Width="57px" Text="GANO"></asp:Label></asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow 
                ID="TableRow25" 
                runat="server" 
                BackColor="#FFFF00"
                >
                <asp:TableCell><asp:Label ID="cuarto1equipo1" runat="server" 
                    Text="EQUIPO1"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto1equipo1partido1set1" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto1equipo1partido1set2" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto1equipo1partido1set3" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto1equipo1partido1puntos" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow26" 
                runat="server" 
                BackColor="#FFFF00"
                >
                <asp:TableCell><asp:Label ID="cuarto1equipo2" runat="server"
                    Text="EQUIPO2"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto1equipo2partido1set1" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto1equipo2partido1set2" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto1equipo2partido1set3" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto1equipo2partido1puntos" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            </table>
            </td>
            <td class="style6">
                &nbsp;</td>
            <td>
                &nbsp;</td>
          <%--  <td>
                &nbsp;</td>--%>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;</td>
            <td class="style6">
                
            <table>
          <asp:TableHeaderRow ID="TableHeaderRow17" 
                runat="server" 
                ForeColor="Snow"
                BackColor="#007BFF"
                Font-Bold="true"
                >
                <asp:TableHeaderCell>
                    <asp:Label ID="Label99" runat="server"  Width="180px" Text="EQUIPO"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label100" runat="server" Width="50px" Text="SET 1"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label101" runat="server" Width="50px" Text="SET 2"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label102" runat="server" Width="50px" Text="SET 3"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label103" runat="server" Width="57px" Text="GANO"></asp:Label></asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow 
                ID="TableRow33" 
                runat="server" 
                BackColor="#FFFF00"
                >
                <asp:TableCell><asp:Label ID="semi1equipo1" runat="server" 
                    Text="EQUIPO1"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="semi1equipo1set1" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="semi1equipo1set2" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="semi1equipo1set3" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="semi1equipo1puntos" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow34" 
                runat="server" 
                BackColor="#FFFF00"
                >
                <asp:TableCell><asp:Label ID="semi1equipo2" runat="server" 
                    Text="EQUIPO2"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="semi1equipo2set1" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="semi1equipo2set2" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="semi1equipo2set3" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="semi1equipo2puntos" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            </table>
            </td>
            <td>
                &nbsp;</td>
            <%--<td>
                &nbsp;</td>--%>
        </tr>
        <tr>
            <td class="style5">
                
            <table>
          <asp:TableHeaderRow ID="TableHeaderRow14" 
                runat="server" 
                ForeColor="Snow"
                BackColor="#007BFF"
                Font-Bold="true"
                >
                <asp:TableHeaderCell>
                    <asp:Label ID="Label84" runat="server"  Width="180px" Text="EQUIPO"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label85" runat="server" Width="50px" Text="SET 1"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label86" runat="server" Width="50px" Text="SET 2"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label87" runat="server" Width="50px" Text="SET 3"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label88" runat="server" Width="57px" Text="GANO"></asp:Label></asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow 
                ID="TableRow27" 
                runat="server" 
                BackColor="#FFFF00"
                >
                <asp:TableCell><asp:Label ID="cuarto2equipo1" runat="server" 
                    Text="EQUIPO1"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto2equipo1partido1set1" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto2equipo1partido1set2" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto2equipo1partido1set3" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto2equipo1partido1puntos" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow28" 
                runat="server" 
                BackColor="#FFFF00"
                >
                <asp:TableCell><asp:Label ID="cuarto2equipo2" runat="server" 
                    Text="EQUIPO2"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto2equipo2partido1set1" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto2equipo2partido1set2" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto2equipo2partido1set3" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto2equipo2partido1puntos" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            </table>
            </td>
            <td class="style6">
                &nbsp;</td>
            <td style="text-align: center">
                <asp:Label ID="LabelGanador" runat="server" 
                    style="font-weight: 700; text-align: center" Visible="False"></asp:Label>
            </td>
            <%--<td>
                &nbsp;</td>--%>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;</td>
            <td class="style6">
                &nbsp;</td>
            <td>
                
            <table>
          <asp:TableHeaderRow ID="TableHeaderRow19" 
                runat="server" 
                ForeColor="Snow"
                BackColor="#007BFF"
                Font-Bold="true"
                >
                <asp:TableHeaderCell>
                    <asp:Label ID="Label109" runat="server"  Width="180px" Text="EQUIPO"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label110" runat="server" Width="50px" Text="SET 1"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label111" runat="server" Width="50px" Text="SET 2"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label112" runat="server" Width="50px" Text="SET 3"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label113" runat="server" Width="57px" Text="GANO"></asp:Label></asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow 
                ID="TableRow37" 
                runat="server" 
                BackColor="#FFFF00"
                >
                <asp:TableCell><asp:Label ID="finalequipo1" runat="server" 
                    Text="EQUIPO1"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="finalequipo1set1" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="finalequipo1set2" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="finalequipo1set3" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="finalequipo1puntos" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow38" 
                runat="server" 
                BackColor="#FFFF00"
                >
                <asp:TableCell><asp:Label ID="finalequipo2" runat="server" 
                    Text="EQUIPO2"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="finalequipo2set1" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="finalequipo2set2" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="finalequipo2set3" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="finalequipo2puntos" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            </table>
            </td>
           <%-- <td>
                &nbsp;</td>--%>
        </tr>
        <tr>
            <td class="style5">
                
            <table>
          <asp:TableHeaderRow ID="TableHeaderRow15" 
                runat="server" 
                ForeColor="Snow"
                BackColor="#007BFF"
                Font-Bold="true"
                >
                <asp:TableHeaderCell>
                    <asp:Label ID="Label89" runat="server"  Width="180px" Text="EQUIPO"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label90" runat="server" Width="50px" Text="SET 1"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label91" runat="server" Width="50px" Text="SET 2"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label92" runat="server" Width="50px" Text="SET 3"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label93" runat="server" Width="57px" Text="GANO"></asp:Label></asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow 
                ID="TableRow29" 
                runat="server" 
                BackColor="#FFFF00"
                >
                <asp:TableCell><asp:Label ID="cuarto3equipo1" runat="server" 
                    Text="EQUIPO1"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto3equipo1partido1set1" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto3equipo1partido1set2" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto3equipo1partido1set3" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto3equipo1partido1puntos" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow30" 
                runat="server" 
                BackColor="#FFFF00"
                >
                <asp:TableCell><asp:Label ID="cuarto3equipo2" runat="server" 
                    Text="EQUIPO2"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto3equipo2partido1set1" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto3equipo2partido1set2" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto3equipo2partido1set3" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto3equipo2partido1puntos" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            </table>
            </td>
            <td class="style6">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <%--<td>
                &nbsp;</td>--%>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;</td>
            <td class="style6">
                
            <table>
          <asp:TableHeaderRow ID="TableHeaderRow18" 
                runat="server" 
                ForeColor="Snow"
                BackColor="#007BFF"
                Font-Bold="true"
                >
                <asp:TableHeaderCell>
                    <asp:Label ID="Label104" runat="server"  Width="180px" Text="EQUIPO"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label105" runat="server" Width="50px" Text="SET 1"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label106" runat="server" Width="50px" Text="SET 2"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label107" runat="server" Width="50px" Text="SET 3"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label108" runat="server" Width="57px" Text="GANO"></asp:Label></asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow 
                ID="TableRow35" 
                runat="server" 
                BackColor="#FFFF00"
                >
                <asp:TableCell><asp:Label ID="semi2equipo1" runat="server" 
                    Text="EQUIPO1"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="semi2equipo1set1" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="semi2equipo1set2" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="semi2equipo1set3" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="semi2equipo1puntos" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow36" 
                runat="server" 
                BackColor="#FFFF00"
                >
                <asp:TableCell><asp:Label ID="semi2equipo2" runat="server" 
                    Text="EQUIPO2"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="semi2equipo2set1" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="semi2equipo2set2" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="semi2equipo2set3" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="semi2equipo2puntos" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            </table>
            </td>
            <td>
                &nbsp;</td>
           <%-- <td>
                &nbsp;</td>--%>
        </tr>
        <tr>
            <td class="style5">
                
            <table>
          <asp:TableHeaderRow ID="TableHeaderRow16" 
                runat="server" 
                ForeColor="Snow"
                BackColor="#007BFF"
                Font-Bold="true"
                >
                <asp:TableHeaderCell>
                    <asp:Label ID="Label94" runat="server"  Width="180px" Text="EQUIPO"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label95" runat="server" Width="50px" Text="SET 1"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label96" runat="server" Width="50px" Text="SET 2"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label97" runat="server" Width="50px" Text="SET 3"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label98" runat="server" Width="57px" Text="GANO"></asp:Label></asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow 
                ID="TableRow31" 
                runat="server" 
                BackColor="#FFFF00"
                >
                <asp:TableCell><asp:Label ID="cuarto4equipo1" runat="server" 
                    Text="EQUIPO1"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto4equipo1partido1set1" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto4equipo1partido1set2" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto4equipo1partido1set3" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto4equipo1partido1puntos" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow32" 
                runat="server" 
                BackColor="#FFFF00"
                >
                <asp:TableCell><asp:Label ID="cuarto4equipo2" runat="server" 
                    Text="EQUIPO2"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto4equipo2partido1set1" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto4equipo2partido1set2" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto4equipo2partido1set3" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto4equipo2partido1puntos" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            </table>
            </td>
            <td class="style6">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <%--<td>
                &nbsp;</td>--%>
        </tr>
        <tr>
        <td class="style6">
        <p class="help-block"></p>  
                <asp:Button ID="ButtonGenerarCuartos" class="btn btn-lg btn-primary btn-block" runat="server" Text="Generar Cuartos" onclick="ButtonGenerarCuartos_Click"/>
                            <p class="help-block"></p>  
            </td>
            <td>
            <p class="help-block"></p>  
                <asp:Button ID="ButtonGenerarSemifinal" 
                    class="btn btn-lg btn-primary btn-block" runat="server" 
                    Text="Generar Semifinal" onclick="ButtonGenerarSemifinal_Click"/>
                            <p class="help-block"></p>  
            </td>
            <td>
            <p class="help-block"></p>  
                <asp:Button ID="ButtonGenerarGanador" class="btn btn-lg btn-primary btn-block" 
                    runat="server" Text="Generar Ganador" onclick="ButtonGenerarGanador_Click"/>
                            <p class="help-block"></p>  
            </td>
        </tr>
    </table>
            </asp:Panel>
            </form>
</div>
</asp:Content>
