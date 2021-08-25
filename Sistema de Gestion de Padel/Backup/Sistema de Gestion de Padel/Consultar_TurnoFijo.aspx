<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Consultar_TurnoFijo.aspx.cs" Inherits="Sistema_de_Gestion_de_Padel.Consultar_TurnoFijo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
<div class="container">
    <h1 class="mt-4 mb-3">Consultar Turnos Fijos</h1>
    <div class="controls">
    <form name="Consultar_ReservasFijas" id="ConsultaReservaFijas" novalidate>
        <div class="controls">
            <label>Seleccione la cancha</label>
            <asp:DropDownList ID="DropDownList1" runat="server" class="form-control">
                <asp:ListItem>SELECCIONE</asp:ListItem>
                <asp:ListItem Value="1">Cancha I</asp:ListItem>
                <asp:ListItem Value="2">Cancha II</asp:ListItem>
            </asp:DropDownList>
            <p class="help-block"></p>
            <div class="row">
                <div class="col-lg-4 mb-4">
                    <asp:Button ID="ButtonBuscar" class="btn btn-lg btn-primary btn-block" 
                        runat="server" Text="Buscar Reservas Fijas" onclick="ButtonBuscar_Click"/>
                </div>
            </div>
            <p class="help-block">
                <asp:GridView ID="GridView1" runat="server" 
                    onrowdatabound="GridView1_RowDataBound" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="HORARIO" HeaderText="HORARIO" 
                            SortExpression="HORARIO" />
                        <asp:BoundField DataField="LUNES" HeaderText="LUNES" SortExpression="LUNES" />
                        <asp:BoundField DataField="MARTES" HeaderText="MARTES" 
                            SortExpression="MARTES" />
                        <asp:BoundField DataField="MIERCOLES" HeaderText="MIERCOLES" 
                            SortExpression="MIERCOLES" />
                        <asp:BoundField DataField="JUEVES" HeaderText="JUEVES" 
                            SortExpression="JUEVES" />
                        <asp:BoundField DataField="VIERNES" HeaderText="VIERNES" 
                            SortExpression="VIERNES" />
                        <asp:BoundField DataField="SABADO" HeaderText="SABADO" 
                            SortExpression="SABADO" />
                    </Columns>
                </asp:GridView>
        </div>
        <asp:Panel ID="Panel1" runat="server" class="controls" Visible="False"> 
        <p class="help-block"></p>
        <h1 class="mt-4 mb-4">Cancha I</h1>
        <p class="help-block"></p>
        <div class="row">
        <div class="col-lg-4 mb-4">
            <label class= "mt-4 mb-3 text-primary" Align="Center">LUNES</label>
            <asp:GridView ID="GridViewLunesI" runat="server" Align="Center" 
                Font-Size="Large" HorizontalAlign="Center" AutoGenerateColumns="False" 
                DataSourceID="SqlDataSource1" 
                onselectedindexchanged="GridViewLunesI_SelectedIndexChanged" 
                DataKeyNames="Cod" onrowdatabound="GridViewLunesI_RowDataBound">
                <Columns>
                    <asp:BoundField DataField="Cod" HeaderText="Cod" SortExpression="Cod" 
                        ReadOnly="True" Visible="False" />
                    <asp:BoundField DataField="HORA" HeaderText="HORA" 
                        SortExpression="HORA" />
                    <asp:BoundField DataField="CLIENTE" HeaderText="CLIENTE" 
                        SortExpression="CLIENTE" ReadOnly="True" />
                    <asp:BoundField DataField="ESTADO" HeaderText="ESTADO" 
                        SortExpression="ESTADO" />
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                
                ConnectionString="<%$ ConnectionStrings:SistemaDeGestionDePadelConnectionString %>" SelectCommand="SELECT [TurnoFijoCanPadId] AS Cod, [TurnoFijoCanPadHora] AS [HORA], ([PersonasPad].[PersonasPAdApellido] + ' ' + [PersonasPad].[PersonasPadNombre]) AS [CLIENTE], [TurnoFijoCanPadEstado] AS [ESTADO]
                            FROM [TurnoFijoCanPad]
                            INNER JOIN PersonasPad ON PersonasPad.PersonasPadId = TurnoFijoCanPad.PersonasPadId
                            WHERE (([TurnoFijoCanPadDia] = 1) and ([CanchaId] = 1))">
            </asp:SqlDataSource>
            <p class="help-block"></p>
        </div>
        <div class="col-lg-4 mb-4">
            <label class= "mt-4 mb-3 text-primary" Align="Center">MARTES</label>
            <asp:GridView ID="GridViewMartesI" runat="server" Align="Center" 
                Font-Size="Large" HorizontalAlign="Center" AutoGenerateColumns="False" 
                DataSourceID="SqlDataSource2" DataKeyNames="Cod" 
                onselectedindexchanged="GridViewMartesI_SelectedIndexChanged" 
                onrowdatabound="GridViewMartesI_RowDataBound">
                <Columns>
                    <asp:BoundField DataField="Cod" HeaderText="Cod" SortExpression="Cod" 
                        ReadOnly="True" Visible="False" />
                    <asp:BoundField DataField="HORA" HeaderText="HORA" 
                        SortExpression="HORA" />
                    <asp:BoundField DataField="CLIENTE" HeaderText="CLIENTE" 
                        SortExpression="CLIENTE" ReadOnly="True" />
                    <asp:BoundField DataField="ESTADO" HeaderText="ESTADO" 
                        SortExpression="ESTADO" />
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                
                ConnectionString="<%$ ConnectionStrings:SistemaDeGestionDePadelConnectionString %>" SelectCommand="SELECT [TurnoFijoCanPadId] AS Cod, [TurnoFijoCanPadHora] AS [HORA], ([PersonasPad].[PersonasPAdApellido] + ' ' + [PersonasPad].[PersonasPadNombre]) AS [CLIENTE], [TurnoFijoCanPadEstado] AS [ESTADO]
                            FROM [TurnoFijoCanPad]
                            INNER JOIN PersonasPad ON PersonasPad.PersonasPadId = TurnoFijoCanPad.PersonasPadId
                            WHERE (([TurnoFijoCanPadDia] = 2) and ([CanchaId] = 1))">
            </asp:SqlDataSource>
        <p class="help-block"></p>
        </div>
        <div class="col-lg-4 mb-4">
            <label class= "mt-4 mb-3 text-primary" Align="Center">MIÉRCOLES</label>
            <asp:GridView ID="GridViewMiercolesI" runat="server" Align="Center" 
                Font-Size="Large" HorizontalAlign="Center" AutoGenerateColumns="False" 
                DataSourceID="SqlDataSource3" DataKeyNames="Cod" 
                onselectedindexchanged="GridViewMiercolesI_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="Cod" HeaderText="Cod" ReadOnly="True" 
                        SortExpression="Cod" Visible="False" />
                    <asp:BoundField DataField="HORA" HeaderText="HORA" SortExpression="HORA" />
                    <asp:BoundField DataField="CLIENTE" HeaderText="CLIENTE" ReadOnly="True" 
                        SortExpression="CLIENTE" />
                    <asp:BoundField DataField="ESTADO" HeaderText="ESTADO" 
                        SortExpression="ESTADO" />
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
                
                ConnectionString="<%$ ConnectionStrings:SistemaDeGestionDePadelConnectionString %>" SelectCommand="SELECT [TurnoFijoCanPadId] AS Cod, [TurnoFijoCanPadHora] AS [HORA], ([PersonasPad].[PersonasPAdApellido] + ' ' + [PersonasPad].[PersonasPadNombre]) AS [CLIENTE], [TurnoFijoCanPadEstado] AS [ESTADO]
                            FROM [TurnoFijoCanPad]
                            INNER JOIN PersonasPad ON PersonasPad.PersonasPadId = TurnoFijoCanPad.PersonasPadId
                            WHERE (([TurnoFijoCanPadDia] = 3) and ([CanchaId] = 1))">
            </asp:SqlDataSource>
        <p class="help-block"></p>
        </div>
        <div class="col-lg-4 mb-4">
            <label class= "mt-4 mb-3 text-primary" Align="Center">JUEVES</label>
            <asp:GridView ID="GridViewJueves" runat="server" Align="Center" 
                Font-Size="Large" HorizontalAlign="Center" AutoGenerateColumns="False" 
                DataSourceID="SqlDataSource4" DataKeyNames="Cod" 
                onselectedindexchanged="GridViewJueves_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="Cod" HeaderText="Cod" ReadOnly="True" 
                        SortExpression="Cod" Visible="False" />
                    <asp:BoundField DataField="HORA" HeaderText="HORA" SortExpression="HORA" />
                    <asp:BoundField DataField="CLIENTE" HeaderText="CLIENTE" ReadOnly="True" 
                        SortExpression="CLIENTE" />
                    <asp:BoundField DataField="ESTADO" HeaderText="ESTADO" 
                        SortExpression="ESTADO" />
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource4" runat="server" 
                
                ConnectionString="<%$ ConnectionStrings:SistemaDeGestionDePadelConnectionString %>" SelectCommand="SELECT [TurnoFijoCanPadId] AS Cod, [TurnoFijoCanPadHora] AS [HORA], ([PersonasPad].[PersonasPAdApellido] + ' ' + [PersonasPad].[PersonasPadNombre]) AS [CLIENTE], [TurnoFijoCanPadEstado] AS [ESTADO]
                            FROM [TurnoFijoCanPad]
                            INNER JOIN PersonasPad ON PersonasPad.PersonasPadId = TurnoFijoCanPad.PersonasPadId
                            WHERE (([TurnoFijoCanPadDia] = 4) and ([CanchaId] = 1))">
            </asp:SqlDataSource>
        <p class="help-block"></p>
        </div>
        <div class="col-lg-4 mb-4">
            <label class= "mt-4 mb-3 text-primary" Align="Center">VIERNES</label>
            <asp:GridView ID="GridViewViernesI" runat="server" Align="Center" 
                Font-Size="Large" HorizontalAlign="Center" AutoGenerateColumns="False" 
                DataSourceID="SqlDataSource5" DataKeyNames="Cod" 
                onselectedindexchanged="GridViewViernesI_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="Cod" HeaderText="Cod" ReadOnly="True" 
                        SortExpression="Cod" Visible="False" />
                    <asp:BoundField DataField="HORA" HeaderText="HORA" SortExpression="HORA" />
                    <asp:BoundField DataField="CLIENTE" HeaderText="CLIENTE" ReadOnly="True" 
                        SortExpression="CLIENTE" />
                    <asp:BoundField DataField="ESTADO" HeaderText="ESTADO" 
                        SortExpression="ESTADO" />
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource5" runat="server" 
                
                ConnectionString="<%$ ConnectionStrings:SistemaDeGestionDePadelConnectionString %>" SelectCommand="SELECT [TurnoFijoCanPadId] AS Cod, [TurnoFijoCanPadHora] AS [HORA], ([PersonasPad].[PersonasPAdApellido] + ' ' + [PersonasPad].[PersonasPadNombre]) AS [CLIENTE], [TurnoFijoCanPadEstado] AS [ESTADO]
                            FROM [TurnoFijoCanPad]
                            INNER JOIN PersonasPad ON PersonasPad.PersonasPadId = TurnoFijoCanPad.PersonasPadId
                            WHERE (([TurnoFijoCanPadDia] = 5) and ([CanchaId] = 1))">
            </asp:SqlDataSource>
        <p class="help-block"></p>
        </div>
        <div class="col-lg-4 mb-4">
            <label class= "mt-4 mb-3 text-primary" Align="Center">SABADO</label>
            <asp:GridView ID="GridViewSabadoI" runat="server" Align="Center" 
                Font-Size="Large" HorizontalAlign="Center" AutoGenerateColumns="False" 
                DataSourceID="SqlDataSource6" DataKeyNames="Cod" 
                onselectedindexchanged="GridViewSabadoI_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="Cod" HeaderText="Cod" SortExpression="Cod" 
                        ReadOnly="True" Visible="False" />
                    <asp:BoundField DataField="HORA" HeaderText="HORA" 
                        SortExpression="HORA" />
                    <asp:BoundField DataField="CLIENTE" HeaderText="CLIENTE" 
                        SortExpression="CLIENTE" ReadOnly="True" />
                    <asp:BoundField DataField="ESTADO" HeaderText="ESTADO" 
                        SortExpression="ESTADO" />
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource6" runat="server" 
                
                ConnectionString="<%$ ConnectionStrings:SistemaDeGestionDePadelConnectionString %>" SelectCommand="SELECT [TurnoFijoCanPadId] AS Cod, [TurnoFijoCanPadHora] AS [HORA], ([PersonasPad].[PersonasPAdApellido] + ' ' + [PersonasPad].[PersonasPadNombre]) AS [CLIENTE], [TurnoFijoCanPadEstado] AS [ESTADO]
                            FROM [TurnoFijoCanPad]
                            INNER JOIN PersonasPad ON PersonasPad.PersonasPadId = TurnoFijoCanPad.PersonasPadId
                            WHERE (([TurnoFijoCanPadDia] = 6) and ([CanchaId] = 1))">
            </asp:SqlDataSource>
        <p class="help-block"></p>
        </div>
        </div>
        </asp:Panel>

        <asp:Panel ID="Panel2" runat="server" class="controls" Visible="False"> 
        <p class="help-block"></p>
        <h1 class="mt-4 mb-4">Cancha II</h1>
        <p class="help-block"></p>
        <div class="row">
        <div class="col-lg-4 mb-4">
            <label class= "mt-4 mb-3 text-primary" Align="Center">LUNES</label>
            <asp:GridView ID="GridViewLunesII" runat="server" Align="Center" 
                Font-Size="Large" HorizontalAlign="Center" AutoGenerateColumns="False" 
                DataSourceID="SqlDataSource7" DataKeyNames="Cod" 
                onselectedindexchanged="GridViewLunesII_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="Cod" HeaderText="Cod" SortExpression="Cod" 
                        ReadOnly="True" Visible="False" />
                    <asp:BoundField DataField="HORA" HeaderText="HORA" 
                        SortExpression="HORA" />
                    <asp:BoundField DataField="CLIENTE" HeaderText="CLIENTE" 
                        SortExpression="CLIENTE" ReadOnly="True" />
                    <asp:BoundField DataField="ESTADO" HeaderText="ESTADO" 
                        SortExpression="ESTADO" />
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource7" runat="server" 
                
                ConnectionString="<%$ ConnectionStrings:SistemaDeGestionDePadelConnectionString %>" SelectCommand="SELECT [TurnoFijoCanPadId] AS Cod, [TurnoFijoCanPadHora] AS [HORA], ([PersonasPad].[PersonasPAdApellido] + ' ' + [PersonasPad].[PersonasPadNombre]) AS [CLIENTE], [TurnoFijoCanPadEstado] AS [ESTADO]
                            FROM [TurnoFijoCanPad]
                            INNER JOIN PersonasPad ON PersonasPad.PersonasPadId = TurnoFijoCanPad.PersonasPadId
                            WHERE (([TurnoFijoCanPadDia] = 1) and ([CanchaId] = 2))">
            </asp:SqlDataSource>
            <p class="help-block"></p>
        </div>
        <div class="col-lg-4 mb-4">
            <label class= "mt-4 mb-3 text-primary" Align="Center">MARTES</label>
            <asp:GridView ID="GridViewMartesII" runat="server" Align="Center" 
                Font-Size="Large" HorizontalAlign="Center" AutoGenerateColumns="False" 
                DataSourceID="SqlDataSource8" DataKeyNames="Cod" 
                onselectedindexchanged="GridViewMartesII_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="Cod" HeaderText="Cod" SortExpression="Cod" 
                        ReadOnly="True" Visible="False" />
                    <asp:BoundField DataField="HORA" HeaderText="HORA" 
                        SortExpression="HORA" />
                    <asp:BoundField DataField="CLIENTE" HeaderText="CLIENTE" 
                        SortExpression="CLIENTE" ReadOnly="True" />
                    <asp:BoundField DataField="ESTADO" HeaderText="ESTADO" 
                        SortExpression="ESTADO" />
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource8" runat="server" 
                
                ConnectionString="<%$ ConnectionStrings:SistemaDeGestionDePadelConnectionString %>" SelectCommand="SELECT [TurnoFijoCanPadId] AS Cod, [TurnoFijoCanPadHora] AS [HORA], ([PersonasPad].[PersonasPAdApellido] + ' ' + [PersonasPad].[PersonasPadNombre]) AS [CLIENTE], [TurnoFijoCanPadEstado] AS [ESTADO]
                            FROM [TurnoFijoCanPad]
                            INNER JOIN PersonasPad ON PersonasPad.PersonasPadId = TurnoFijoCanPad.PersonasPadId
                            WHERE (([TurnoFijoCanPadDia] = 2) and ([CanchaId] = 2))">
            </asp:SqlDataSource>
        <p class="help-block"></p>
        </div>
        <div class="col-lg-4 mb-4">
            <label class= "mt-4 mb-3 text-primary" Align="Center">MIÉRCOLES</label>
            <asp:GridView ID="GridViewMierolesII" runat="server" Align="Center" 
                Font-Size="Large" HorizontalAlign="Center" AutoGenerateColumns="False" 
                DataSourceID="SqlDataSource9" DataKeyNames="Cod" 
                onselectedindexchanged="GridViewMiercolesII_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="Cod" HeaderText="Cod" SortExpression="Cod" 
                        ReadOnly="True" Visible="False" />
                    <asp:BoundField DataField="HORA" HeaderText="HORA" 
                        SortExpression="HORA" />
                    <asp:BoundField DataField="CLIENTE" HeaderText="CLIENTE" 
                        SortExpression="CLIENTE" ReadOnly="True" />
                    <asp:BoundField DataField="ESTADO" HeaderText="ESTADO" 
                        SortExpression="ESTADO" />
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource9" runat="server" 
                
                ConnectionString="<%$ ConnectionStrings:SistemaDeGestionDePadelConnectionString %>" SelectCommand="SELECT [TurnoFijoCanPadId] AS Cod, [TurnoFijoCanPadHora] AS [HORA], ([PersonasPad].[PersonasPAdApellido] + ' ' + [PersonasPad].[PersonasPadNombre]) AS [CLIENTE], [TurnoFijoCanPadEstado] AS [ESTADO]
                            FROM [TurnoFijoCanPad]
                            INNER JOIN PersonasPad ON PersonasPad.PersonasPadId = TurnoFijoCanPad.PersonasPadId
                            WHERE (([TurnoFijoCanPadDia] = 3) and ([CanchaId] = 2))">
            </asp:SqlDataSource>
        <p class="help-block"></p>
        </div>
        <div class="col-lg-4 mb-4">
            <label class= "mt-4 mb-3 text-primary" Align="Center">JUEVES</label>
            <asp:GridView ID="GridViewJuevesII" runat="server" Align="Center" 
                Font-Size="Large" HorizontalAlign="Center" AutoGenerateColumns="False" 
                DataSourceID="SqlDataSource10" DataKeyNames="Cod" 
                onselectedindexchanged="GridViewJuevesII_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="Cod" HeaderText="Cod" SortExpression="Cod" 
                        ReadOnly="True" Visible="False" />
                    <asp:BoundField DataField="HORA" HeaderText="HORA" 
                        SortExpression="HORA" />
                    <asp:BoundField DataField="CLIENTE" HeaderText="CLIENTE" 
                        SortExpression="CLIENTE" ReadOnly="True" />
                    <asp:BoundField DataField="ESTADO" HeaderText="ESTADO" 
                        SortExpression="ESTADO" />
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource10" runat="server" 
                
                ConnectionString="<%$ ConnectionStrings:SistemaDeGestionDePadelConnectionString %>" SelectCommand="SELECT [TurnoFijoCanPadId] AS Cod, [TurnoFijoCanPadHora] AS [HORA], ([PersonasPad].[PersonasPAdApellido] + ' ' + [PersonasPad].[PersonasPadNombre]) AS [CLIENTE], [TurnoFijoCanPadEstado] AS [ESTADO]
                            FROM [TurnoFijoCanPad]
                            INNER JOIN PersonasPad ON PersonasPad.PersonasPadId = TurnoFijoCanPad.PersonasPadId
                            WHERE (([TurnoFijoCanPadDia] = 4) and ([CanchaId] = 2))">
            </asp:SqlDataSource>
        <p class="help-block"></p>
        </div>
        <div class="col-lg-4 mb-4">
            <label class= "mt-4 mb-3 text-primary" Align="Center">VIERNES</label>
            <asp:GridView ID="GridViewViernesII" runat="server" Align="Center" 
                Font-Size="Large" HorizontalAlign="Center" AutoGenerateColumns="False" 
                DataSourceID="SqlDataSource11" DataKeyNames="Cod" 
                onselectedindexchanged="GridViewViernesII_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="Cod" HeaderText="Cod" SortExpression="Cod" 
                        ReadOnly="True" Visible="False" />
                    <asp:BoundField DataField="HORA" HeaderText="HORA" 
                        SortExpression="HORA" />
                    <asp:BoundField DataField="CLIENTE" HeaderText="CLIENTE" 
                        SortExpression="CLIENTE" ReadOnly="True" />
                    <asp:BoundField DataField="ESTADO" HeaderText="ESTADO" 
                        SortExpression="ESTADO" />
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource11" runat="server" 
                
                ConnectionString="<%$ ConnectionStrings:SistemaDeGestionDePadelConnectionString %>" SelectCommand="SELECT [TurnoFijoCanPadId] AS Cod, [TurnoFijoCanPadHora] AS [HORA], ([PersonasPad].[PersonasPAdApellido] + ' ' + [PersonasPad].[PersonasPadNombre]) AS [CLIENTE], [TurnoFijoCanPadEstado] AS [ESTADO]
                            FROM [TurnoFijoCanPad]
                            INNER JOIN PersonasPad ON PersonasPad.PersonasPadId = TurnoFijoCanPad.PersonasPadId
                            WHERE (([TurnoFijoCanPadDia] = 5) and ([CanchaId] = 2))">
            </asp:SqlDataSource>
        <p class="help-block"></p>
        </div>
        <div class="col-lg-4 mb-4">
            <label class= "mt-4 mb-3 text-primary" Align="Center">SABADO</label>
            <asp:GridView ID="GridViewSabadoII" runat="server" Align="Center" 
                Font-Size="Large" HorizontalAlign="Center" AutoGenerateColumns="False" 
                DataSourceID="SqlDataSource12" DataKeyNames="Cod" 
                onselectedindexchanged="GridViewSabadoII_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="Cod" HeaderText="Cod" SortExpression="Cod" 
                        ReadOnly="True" Visible="False" />
                    <asp:BoundField DataField="HORA" HeaderText="HORA" 
                        SortExpression="HORA" />
                    <asp:BoundField DataField="CLIENTE" HeaderText="CLIENTE" 
                        SortExpression="CLIENTE" ReadOnly="True" />
                    <asp:BoundField DataField="ESTADO" HeaderText="ESTADO" 
                        SortExpression="ESTADO" />
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource12" runat="server" 
                
                ConnectionString="<%$ ConnectionStrings:SistemaDeGestionDePadelConnectionString %>" SelectCommand="SELECT [TurnoFijoCanPadId] AS Cod, [TurnoFijoCanPadHora] AS [HORA], ([PersonasPad].[PersonasPAdApellido] + ' ' + [PersonasPad].[PersonasPadNombre]) AS [CLIENTE], [TurnoFijoCanPadEstado] AS [ESTADO]
                            FROM [TurnoFijoCanPad]
                            INNER JOIN PersonasPad ON PersonasPad.PersonasPadId = TurnoFijoCanPad.PersonasPadId
                            WHERE (([TurnoFijoCanPadDia] = 6) and ([CanchaId] = 2))">
            </asp:SqlDataSource>
        <p class="help-block"></p>
        </div>
        </div>
            <asp:Label ID="LabelError" runat="server" 
                Text="*El turno seleccionado se encuentra disponible, por favor seleccione otro" 
                style="font-weight: 700; color: #FF0000" Visible="False"></asp:Label>
        </asp:Panel>

        <asp:Panel ID="Panel3" runat="server" class="controls" Visible="False">
        <h1 class="mt-4 mb-3">Cancelar Turno Fijo</h1>
            <div class="controls">
            <label>Nombre Socio:</label>
                <asp:TextBox ID="TextBoxNombreSocio" runat="server" class="form-control" maxlength="100" required data-validation-required-message="Por favor ingrese el nombre."></asp:TextBox>
                <p class="help-block"></p>
            </div>
            <div class="controls">
            <label>Cancha:</label>
                <asp:TextBox ID="TextBoxCancha" runat="server" class="form-control" maxlength="40" required data-validation-required-message="Por favor ingrese el nombre."></asp:TextBox>
                <p class="help-block"></p>
            </div>
            <div class="controls">
            <label>Día:</label>
                <asp:TextBox ID="TextBoxDia" runat="server" class="form-control" 
                    maxlength="2" required 
                    data-validation-required-message="Por favor ingrese el nombre."></asp:TextBox>
                <p class="help-block"></p>
            </div>
            <div class="controls">
            <label>Hora:</label>
                <asp:TextBox ID="TextBoxHora" runat="server" class="form-control" maxlength="40" required data-validation-required-message="Por favor ingrese el nombre."></asp:TextBox>
                <p class="help-block"></p>
            </div>
            <div class="row">
                <div class="col-lg-4 mb-4">
                    <asp:Button ID="ButtonCancelar" class="btn btn-lg btn-primary btn-block" 
                        runat="server" Text="Cancelar Turno Fijo" onclick="ButtonCancelar_Click"/>
                </div>
            </div>
    
    </asp:Panel>
    </form>
    </div>
</div>
</asp:Content>
