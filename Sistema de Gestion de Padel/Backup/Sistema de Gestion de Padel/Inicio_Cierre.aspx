<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inicio_Cierre.aspx.cs" Inherits="Sistema_de_Gestion_de_Padel.Inicio_Cierre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="container">
<h1 class="mt-4 mb-3">Inicio / Cierre del día</h1>
      <form name="Inicio/Fin" id="InicioForm" novalidate>
      <div class="row">
        <div class="col-lg-4 mb-4">
            <asp:Button ID="ButtonInicio" class="btn btn-lg btn-primary btn-block" 
                runat="server" Text="Iniciar Día" onclick="ButtonInicio_Click"/>
        </div>
        <div class="col-lg-4 mb-4">
        </div>
        <div class="col-lg-4 mb-4">
            <asp:Button ID="ButtonFinalizar" class="btn btn-lg btn-primary btn-block" 
                runat="server" Text="Finalizar Día" onclick="ButtonFinalizar_Click"/>
        </div>
      </div>
      <div class="controls">
      <p class="help-block"></p>
          <asp:Label ID="LabelError" runat="server" class="control" 
              style="color: #FF0000; font-weight: 700"></asp:Label>
      </div>
      <div class="controls">
      <asp:Panel ID="Panel1" runat="server" Visible="False">
            
                <asp:Label ID="Label1" runat="server" class="control" Text="Reservas del día" Visible="False"></asp:Label>
            <p class="help-block"></p>
            
            <asp:GridView ID="GridView1" runat="server" class="controls" AutoGenerateColumns="False" 
                HorizontalAlign="Center" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="Fecha" HeaderText="Fecha" ReadOnly="True" 
                        SortExpression="Fecha" />
                    <asp:BoundField DataField="Socio" HeaderText="Socio" ReadOnly="True" 
                        SortExpression="Socio" />
                    <asp:BoundField DataField="Cancha" 
                        HeaderText="Cancha" SortExpression="Cancha" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                
                
                
                    ConnectionString="<%$ ConnectionStrings:SistemaDeGestionDePadelConnectionString %>" 
                    SelectCommand="SELECT CONVERT(CHAR(10),[ReservaCanPadFecha], 103) AS Fecha, ([PersonasPad].[PersonasPAdApellido] + ' ' + [PersonasPad].[PersonasPadNombre]) AS Socio, [Cancha].[CanchaDescripcion] AS Cancha
                                        FROM [ReservaCanPad]
                                        INNER JOIN PersonasPad ON PersonasPad.PersonasPadId = ReservaCanPad.PersonasPadId
                                        INNER JOIN Cancha ON Cancha.CanchaId = ReservaCanPad.CanchaId
                                        WHERE CONVERT(CHAR(10),ReservaCanPadFecha,103) = CONVERT(CHAR(10),GETDATE(),103) AND ReservaCanPadEstado = 1 "></asp:SqlDataSource>
        <p class="help-block"></p>

        <div class="controls">
            <asp:Label ID="LabelTotal" runat="server" Text="Cantidad de Reservas en el Día:" class= "mt-4 mb-3" Visible="True"></asp:Label>
            <asp:TextBox ID="TextBoxTotalReservas" runat="server" class="form-control" Visible="True"></asp:TextBox>
            <p class="help-block"></p>
        </div>
        <div class="controls">
            <asp:Label ID="LabelPagado" runat="server" Text="Total de Reservas Pagadas:" class= "mt-4 mb-3" Visible="True"></asp:Label>
            <asp:TextBox ID="TextBoxPago" runat="server" class="form-control" Visible="True"></asp:TextBox>
            <p class="help-block"></p>
        </div>
        <div class="controls">
            <asp:Label ID="LabelDeuda" runat="server" Text="Total de Reservas No Pagadas:" class= "mt-4 mb-3" Visible="True"></asp:Label>
            <asp:TextBox ID="TextBoxDeuda" runat="server" class="form-control" Visible="True"></asp:TextBox>
            <p class="help-block"></p>
        </div>
      </asp:Panel>
      </div>
      </form>
</div>
</asp:Content>
