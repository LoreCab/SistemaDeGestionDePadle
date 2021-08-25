<%@ Page Title="" Language="C#" MasterPageFile="~/Operario/SiteOperario.Master" AutoEventWireup="true" CodeBehind="Consultar_TurnoFijo.aspx.cs" Inherits="Sistema_de_Gestion_de_Padel.Operario.Consultar_TurnoFijo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="container">
    <h1 class="mt-4 mb-3">Consultar Turnos Fijos</h1>
    <div class="controls">
    <form name="Consultar_ReservasFijas" id="ConsultaReservaFijas" novalidate>
        <div class="controls">
            <label>Seleccione la cancha</label>
            <asp:DropDownList ID="DropDownList1" runat="server" class="form-control" 
                DataSourceID="SqlDataSource1" DataTextField="DESCRIPCIÓN DE LA CANCHA" 
                DataValueField="CÓDIGO DE CANCHA">
                <asp:ListItem>SELECCIONE</asp:ListItem>
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:SistemaDeGestionDePadelConnectionString %>" 
                SelectCommand="SELECT [CanchaId] AS [CÓDIGO DE CANCHA], [CanchaDescripcion] AS [DESCRIPCIÓN DE LA CANCHA], [EstadoCancha] AS [ESTADO CANCHA] FROM [Cancha]">
            </asp:SqlDataSource>
            <p class="help-block"></p>
            <div class="row">
                <div class="col-lg-4 mb-4">
                    <asp:Button ID="ButtonBuscar" class="btn btn-lg btn-primary btn-block" 
                        runat="server" Text="Buscar Reservas Fijas" onclick="ButtonBuscar_Click"/>
                </div>
            </div>
            <p class="help-block">
                &nbsp;</div>
        <asp:Panel ID="Panel1" runat="server" class="controls" Visible="False"> 
        <p class="help-block"></p>
        <asp:Label ID="LabelCancha" runat="server" Text="" 
                style="font-size: xx-large; color: #007BFF"></asp:Label>
        &nbsp;<asp:Label ID="LabelError" runat="server" 
                Text="*El turno seleccionado se encuentra disponible, por favor seleccione otro" 
                style="font-weight: 700; color: #FF0000" Visible="False"></asp:Label>
            <p class="help-block">
            </p>
            <div class="row">
                <div class="col-lg-4 mb-4">
                    <label Align="Center" class="mt-4 mb-3 text-primary">
                    LUNES</label>
                    <asp:GridView ID="GridViewLunes" runat="server" Align="Center" 
                        AutoGenerateColumns="False" DataKeyNames="Cod" Font-Size="Medium" 
                        HorizontalAlign="Center" onrowdatabound="GridViewLunes_RowDataBound" 
                        onselectedindexchanged="GridViewLunes_SelectedIndexChanged" Width="300px">
                        <Columns>
                            <asp:BoundField DataField="Cod" HeaderText="Cod" SortExpression="Cod" 
                                Visible="False" />
                            <asp:BoundField DataField="HORA" HeaderText="HORA" SortExpression="HORA" />
                            <asp:BoundField DataField="CLIENTE" HeaderText="SOCIO" SortExpression="SOCIO" />
                            <asp:BoundField DataField="ESTADO" HeaderText="ESTADO" SortExpression="ESTADO" 
                                Visible="False" />
                            <asp:CommandField ShowSelectButton="True" />
                        </Columns>
                        <HeaderStyle BackColor="#007BFF" Font-Size="Large" ForeColor="White" 
                            HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                    </asp:GridView>
                    <p class="help-block">
                    </p>
                </div>
                <div class="col-lg-4 mb-4">
                    <label Align="Center" class="mt-4 mb-3 text-primary">
                    MARTES</label>
                    <asp:GridView ID="GridViewMartes" runat="server" Align="Center" 
                        AutoGenerateColumns="False" DataKeyNames="Cod" Font-Size="Medium" 
                        HorizontalAlign="Center" onrowdatabound="GridViewMartes_RowDataBound" 
                        onselectedindexchanged="GridViewMartes_SelectedIndexChanged" Width="300px">
                        <Columns>
                            <asp:BoundField DataField="Cod" HeaderText="Cod" SortExpression="Cod" 
                                Visible="False" />
                            <asp:BoundField DataField="HORA" HeaderText="HORA" SortExpression="HORA" />
                            <asp:BoundField DataField="CLIENTE" HeaderText="SOCIO" SortExpression="SOCIO" />
                            <asp:BoundField DataField="ESTADO" HeaderText="ESTADO" SortExpression="ESTADO" 
                                Visible="False" />
                            <asp:CommandField ShowSelectButton="True" />
                        </Columns>
                        <HeaderStyle BackColor="#007BFF" Font-Size="Large" ForeColor="White" 
                            HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                    </asp:GridView>
                    <p class="help-block">
                    </p>
                </div>
                <div class="col-lg-4 mb-4">
                    <label Align="Center" class="mt-4 mb-3 text-primary">
                    MIÉRCOLES</label>
                    <asp:GridView ID="GridViewMiercoles" runat="server" Align="Center" 
                        AutoGenerateColumns="False" DataKeyNames="Cod" Font-Size="Medium" 
                        HorizontalAlign="Center" onrowdatabound="GridViewMiercoles_RowDataBound" 
                        onselectedindexchanged="GridViewMiercoles_SelectedIndexChanged" Width="300px">
                        <Columns>
                            <asp:BoundField DataField="Cod" HeaderText="Cod" SortExpression="Cod" 
                                Visible="False" />
                            <asp:BoundField DataField="HORA" HeaderText="HORA" SortExpression="HORA" />
                            <asp:BoundField DataField="CLIENTE" HeaderText="SOCIO" SortExpression="SOCIO" />
                            <asp:BoundField DataField="ESTADO" HeaderText="ESTADO" SortExpression="ESTADO" 
                                Visible="False" />
                            <asp:CommandField ShowSelectButton="True" />
                        </Columns>
                        <HeaderStyle BackColor="#007BFF" Font-Size="Large" ForeColor="White" 
                            HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                    </asp:GridView>
                    <p class="help-block">
                    </p>
                </div>
                <div class="col-lg-4 mb-4">
                    <label Align="Center" class="mt-4 mb-3 text-primary">
                    JUEVES</label>
                    <asp:GridView ID="GridViewJueves" runat="server" Align="Center" 
                        AutoGenerateColumns="False" DataKeyNames="Cod" Font-Size="Medium" 
                        HorizontalAlign="Center" onrowdatabound="GridViewJueves_RowDataBound" 
                        onselectedindexchanged="GridViewJueves_SelectedIndexChanged" Width="300px">
                        <Columns>
                            <asp:BoundField DataField="Cod" HeaderText="Cod" SortExpression="Cod" 
                                Visible="False" />
                            <asp:BoundField DataField="HORA" HeaderText="HORA" SortExpression="HORA" />
                            <asp:BoundField DataField="CLIENTE" HeaderText="SOCIO" SortExpression="SOCIO" />
                            <asp:BoundField DataField="ESTADO" HeaderText="ESTADO" SortExpression="ESTADO" 
                                Visible="False" />
                            <asp:CommandField ShowSelectButton="True" />
                        </Columns>
                        <HeaderStyle BackColor="#007BFF" Font-Size="Large" ForeColor="White" 
                            HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                    </asp:GridView>
                    <p class="help-block">
                    </p>
                </div>
                <div class="col-lg-4 mb-4">
                    <label Align="Center" class="mt-4 mb-3 text-primary">
                    VIERNES</label>
                    <asp:GridView ID="GridViewViernes" runat="server" Align="Center" 
                        AutoGenerateColumns="False" DataKeyNames="Cod" Font-Size="Medium" 
                        HorizontalAlign="Center" onrowdatabound="GridViewViernes_RowDataBound" 
                        onselectedindexchanged="GridViewViernes_SelectedIndexChanged" Width="300px">
                        <Columns>
                            <asp:BoundField DataField="Cod" HeaderText="Cod" SortExpression="Cod" 
                                Visible="False" />
                            <asp:BoundField DataField="HORA" HeaderText="HORA" SortExpression="HORA" />
                            <asp:BoundField DataField="CLIENTE" HeaderText="SOCIO" SortExpression="SOCIO" />
                            <asp:BoundField DataField="ESTADO" HeaderText="ESTADO" SortExpression="ESTADO" 
                                Visible="False" />
                            <asp:CommandField ShowSelectButton="True" />
                        </Columns>
                        <HeaderStyle BackColor="#007BFF" Font-Size="Large" ForeColor="White" 
                            HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                    </asp:GridView>
                    <p class="help-block">
                    </p>
                </div>
                <div class="col-lg-4 mb-4">
                    <label Align="Center" class="mt-4 mb-3 text-primary">
                    SABADO</label>
                    <asp:GridView ID="GridViewSabado" runat="server" Align="Center" 
                        AutoGenerateColumns="False" DataKeyNames="Cod" Font-Size="Medium" 
                        HorizontalAlign="Center" onrowdatabound="GridViewSabado_RowDataBound" 
                        onselectedindexchanged="GridViewSabado_SelectedIndexChanged" Width="300px">
                        <Columns>
                            <asp:BoundField DataField="Cod" HeaderText="Cod" SortExpression="Cod" 
                                Visible="False" />
                            <asp:BoundField DataField="HORA" HeaderText="HORA" SortExpression="HORA" />
                            <asp:BoundField DataField="CLIENTE" HeaderText="SOCIO" SortExpression="SOCIO" />
                            <asp:BoundField DataField="ESTADO" HeaderText="ESTADO" SortExpression="ESTADO" 
                                Visible="False" />
                            <asp:CommandField ShowSelectButton="True" />
                        </Columns>
                        <HeaderStyle BackColor="#007BFF" Font-Size="Large" ForeColor="White" 
                            HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                    </asp:GridView>
                    <p class="help-block">
                    </p>
                </div>
            </div>
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
