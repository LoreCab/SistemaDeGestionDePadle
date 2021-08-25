<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Consultar_Reservas.aspx.cs" Inherits="Sistema_de_Gestion_de_Padel.Consultar_Reservas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="container">
    <div class="controls">
    <form name="Consultar_Reservas" id="ConsultaReserva" novalidate>
    <h1 class="mt-4 mb-3">Consultar Reservas Diarias</h1>
        <asp:GridView ID="GridView1" runat="server" Align="Center" Font-Size="Large" 
            HorizontalAlign="Center" AutoGenerateColumns="False" 
            DataSourceID="SqlDataSource1" 
            onselectedindexchanged="GridView1_SelectedIndexChanged" 
            DataKeyNames="Cod de Reserva" onrowdatabound="GridView1_RowDataBound" 
            Width="1000px">
            <Columns>
                <asp:BoundField DataField="Cod de Reserva" HeaderText="Cod de Reserva" ReadOnly="True" 
                    SortExpression="Cod de Reserva" Visible="False" />
                <asp:BoundField DataField="Fecha" HeaderText="FECHA" ReadOnly="True" 
                    SortExpression="Fecha" />
                <asp:BoundField DataField="Hora" HeaderText="HORA" 
                    SortExpression="Hora" />
                <asp:BoundField DataField="Socio" HeaderText="SOCIO" 
                    SortExpression="Socio" ReadOnly="True" />
                <asp:BoundField DataField="Cancha" HeaderText="CANCHA" 
                    SortExpression="Cancha" />
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="TIPO" HeaderText="TIPO" SortExpression="TIPO" 
                    Visible="False" />
            </Columns>
            <HeaderStyle BackColor="#007BFF" ForeColor="White" HorizontalAlign="Center" 
                VerticalAlign="Middle" Width="250px" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            
            
            ConnectionString="<%$ ConnectionStrings:SistemaDeGestionDePadelConnectionString %>" 
            
            SelectCommand="SELECT ReservaCanPadID AS [Cod de Reserva], CONVERT(CHAR(10),[ReservaCanPadFecha], 103) AS Fecha, ReservaCanPadHora AS Hora, ([PersonasPad].[PersonasPAdApellido] + ' ' + [PersonasPad].[PersonasPadNombre]) AS Socio, [Cancha].[CanchaDescripcion] AS Cancha, ReservaCanPadTipo AS TIPO
FROM [ReservaCanPad]
INNER JOIN PersonasPad ON PersonasPad.PersonasPadId = ReservaCanPad.PersonasPadId
INNER JOIN Cancha ON Cancha.CanchaId = ReservaCanPad.CanchaId
WHERE CONVERT(CHAR(10),ReservaCanPadFecha,103) &gt;= CONVERT(CHAR(10),GETDATE(),103) AND ReservaCanPadEstado = 1 ">
        </asp:SqlDataSource>
        <p class="help-block"></p>
    </div>
    <div class="controls">
    <asp:Panel ID="Panel1" runat="server" class="controls" Visible="False">
        <h1 class="mt-4 mb-3">Cancelar Reserva</h1>
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
            <label>Fecha:</label>
                <asp:TextBox ID="TextBoxFecha" runat="server" class="form-control" 
                    maxlength="40" required 
                    data-validation-required-message="Por favor ingrese el nombre." TextMode="Date"></asp:TextBox>
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
                        runat="server" Text="Cancelar Reserva" onclick="ButtonCancelar_Click"/>
                </div>
            </div>
    
    </asp:Panel>
    </div>
    <p class="help-block"></p>
    </form>
</div>
</asp:Content>
