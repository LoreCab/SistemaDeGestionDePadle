<%@ Page Title="" Language="C#" MasterPageFile="~/Organizador/SiteOrganizador.Master" AutoEventWireup="true" CodeBehind="Cargar_Equipo.aspx.cs" Inherits="Sistema_de_Gestion_de_Padel.Organizador.Cargar_Equipo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="container">
    <!-- Page Heading/Breadcrumbs -->
        <h1 class="mt-4 mb-3">Cargar Equipos</h1>
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
                        <asp:Button ID="ButtonBuscarTorneo" class="btn btn-lg btn-primary btn-block" runat="server" Text="Confirmar Torneo" onclick="ButtonBuscarTorneo_Click"/>
                    </div>
                </div>
            <p class="help-block">
                <asp:Label ID="Label1" runat="server" style="font-weight: 700; color: #FF0000" 
                    Text="Ya se encuentran cargados los equipos para este torneo" Visible="False"></asp:Label>
                </p>
                <div class="row"><!-- SELECCIONAR GRUPO-->
                    <div class="col-lg-6 mb-4">
                        <asp:DropDownList ID="DropDownList2" runat="server" class="form-control" 
                            Visible="False">
                            <asp:ListItem Value="1">Grupo A</asp:ListItem>
                            <asp:ListItem Value="2">Grupo B</asp:ListItem>
                            <asp:ListItem Value="3">Grupo C</asp:ListItem>
                            <asp:ListItem Value="4">Grupo D</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-lg-6 mb-4">
                        <asp:Button ID="ButtonGrupo" class="btn btn-lg btn-primary btn-block" 
                            runat="server" Text="Confirmar Grupo" onclick="ButtonGrupo_Click" 
                            Visible="False"/>
                    </div>
                </div>
                &nbsp;<asp:Panel ID="Panel1" runat="server" Visible="False">
                <div class="row">
                    <div class="col-lg-4 mb-4">
                        <asp:Panel ID="PanelEquipo1" runat="server" BackColor="#80FF00">
                            <asp:Label ID="LabelEquipo1" runat="server" Text="Equipo 1" style="font-weight: 700"></asp:Label>
                            <p class="help-block"></p>
                                <label>Ingrese DNI del Primer Jugador:</label>
                                <div class="controls" align="center">
                                    <asp:TextBox ID="TextBoxDNI1E1" runat="server" class="form-control" maxlength="8" onKeypress="if (event.keyCode < 48 || event.keyCode > 57) event.returnValue = false;" required data-validation-required-message="Por favor ingrese el dni." Width="80%"></asp:TextBox>
                                </div>
                                <p class="help-block"></p>
                                <label>Ingrese DNI del Segundo Jugador:</label>
                                <div class="controls" align="center">
                                    <asp:TextBox ID="TextBoxDNI2E1" runat="server" class="form-control" maxlength="8" onKeypress="if (event.keyCode < 48 || event.keyCode > 57) event.returnValue = false;" required data-validation-required-message="Por favor ingrese el dni." Width="80%"></asp:TextBox>
                                </div>
                                <p class="help-block"></p>
                                <asp:Button ID="ButtonBuscarE1" class="btn btn-lg btn-primary btn-block" 
                                runat="server" Text="Verificar Socios" onclick="ButtonBuscarE1_Click"/>
                                <p class="help-block"></p>
                                <label>Primer Jugador: </label><asp:Label ID="LabelNombre1E1" runat="server" Text="" style="font-weight: 700"></asp:Label>
                                <p class="help-block"></p>
                                <label>Segundo Jugador: </label><asp:Label ID="LabelNombre2E1" runat="server" Text="" style="font-weight: 700"></asp:Label>
                        </asp:Panel>
                    </div>
                    <div class="col-lg-4 mb-4">
                        <asp:Panel ID="PanelEquipo2" runat="server" BackColor="#FFBF00" Visible="False">
                            <asp:Label ID="LabelEquipo2" runat="server" Text="Equipo 2" style="font-weight: 700"></asp:Label>
                            <p class="help-block"></p>
                                <label>Ingrese DNI del Primer Jugador:</label>
                                <div class="controls" align="center">
                                    <asp:TextBox ID="TextBoxDNI1E2" runat="server" class="form-control" maxlength="8" onKeypress="if (event.keyCode < 48 || event.keyCode > 57) event.returnValue = false;" required data-validation-required-message="Por favor ingrese el dni." Width="80%"></asp:TextBox>
                                </div>
                                <p class="help-block"></p>
                                <label>Ingrese DNI del Segundo Jugador:</label>
                                <div class="controls" align="center">
                                    <asp:TextBox ID="TextBoxDNI2E2" runat="server" class="form-control" maxlength="8" onKeypress="if (event.keyCode < 48 || event.keyCode > 57) event.returnValue = false;" required data-validation-required-message="Por favor ingrese el dni." Width="80%"></asp:TextBox>
                                </div>
                                <p class="help-block"></p>
                                <asp:Button ID="ButtonBuscarE2" class="btn btn-lg btn-primary btn-block" 
                                runat="server" Text="Verificar Socios" onclick="ButtonBuscarE2_Click"/>
                                <p class="help-block"></p>
                                <label>Primer Jugador: </label><asp:Label ID="LabelNombre1E2" runat="server" Text="" style="font-weight: 700"></asp:Label>
                                <p class="help-block"></p>
                                <label>Segundo Jugador: </label><asp:Label ID="LabelNombre2E2" runat="server" Text="" style="font-weight: 700"></asp:Label>
                        </asp:Panel>
                    </div>
                    <div class="col-lg-4 mb-4">
                        <asp:Panel ID="PanelEquipo3" runat="server" BackColor="#BF00FF" Visible="False">
                            <asp:Label ID="LabelEquipo3" runat="server" Text="Equipo 3" style="font-weight: 700"></asp:Label>
                            <p class="help-block"></p>
                                <label>Ingrese DNI del Primer Jugador:</label>
                                <div class="controls" align="center">
                                    <asp:TextBox ID="TextBoxDNI1E3" runat="server" class="form-control" maxlength="8" onKeypress="if (event.keyCode < 48 || event.keyCode > 57) event.returnValue = false;" required data-validation-required-message="Por favor ingrese el dni." Width="80%"></asp:TextBox>
                                </div>
                                <p class="help-block"></p>
                                <label>Ingrese DNI del Segundo Jugador:</label>
                                <div class="controls" align="center">
                                    <asp:TextBox ID="TextBoxDNI2E3" runat="server" class="form-control" maxlength="8" onKeypress="if (event.keyCode < 48 || event.keyCode > 57) event.returnValue = false;" required data-validation-required-message="Por favor ingrese el dni." Width="80%"></asp:TextBox>
                                </div>
                                <p class="help-block"></p>
                                <asp:Button ID="ButtonBuscarE3" class="btn btn-lg btn-primary btn-block" 
                                runat="server" Text="Verificar Socios" onclick="ButtonBuscarE3_Click"/>
                                <p class="help-block"></p>
                                <label>Primer Jugador: </label><asp:Label ID="LabelNombre1E3" runat="server" Text="" style="font-weight: 700"></asp:Label>
                                <p class="help-block"></p>
                                <label>Segundo Jugador: </label><asp:Label ID="LabelNombre2E3" runat="server" Text="" style="font-weight: 700"></asp:Label>
                        </asp:Panel>
                    </div>
                </div>
            </asp:Panel>
            <div class="row">
                <div class="col-lg-4 mb-4">
                </div>
                <div class="col-lg-4 mb-4">
                <asp:Button ID="ButtonRegistrarGrupo" class="btn btn-lg btn-primary btn-block" 
                        runat="server" Text="Registrar Grupo" Visible="False" 
                        onclick="ButtonRegistrarGrupo_Click"/>
                </div>
                <div class="col-lg-4 mb-4">
                </div>
            </div>
            </form>
    </div>
</asp:Content>
