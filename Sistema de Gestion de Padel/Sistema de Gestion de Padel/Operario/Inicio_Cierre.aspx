<%@ Page Title="" Language="C#" MasterPageFile="~/Operario/SiteOperario.Master" AutoEventWireup="true" CodeBehind="Inicio_Cierre.aspx.cs" Inherits="Sistema_de_Gestion_de_Padel.Operario.Inicio_Cierre" %>
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
      </div>
      <div class="controls">
      <asp:Panel ID="Panel1" runat="server" Visible="False">
            <div class="row">
                <div class="col-lg-6 mb-4">
                     <div class="controls">
                        <asp:Label ID="Label1" runat="server" class="control" Text="Reservas del día" Visible="True"></asp:Label>
                            <p class="help-block"></p>
            
                            <asp:GridView ID="GridView1" runat="server" class="controls" AutoGenerateColumns="False" 
                                HorizontalAlign="Center" DataSourceID="SqlDataSource1" 
                             onrowdatabound="GridView1_RowDataBound" Width="500px">
                                <Columns>
                                    <asp:BoundField DataField="FECHA DE RESERVA" HeaderText="FECHA DE RESERVA" ReadOnly="True" 
                                        SortExpression="FECHA DE RESERVA" />
                                    <asp:BoundField DataField="HORA" HeaderText="HORA" 
                                        SortExpression="HORA" />
                                    <asp:BoundField DataField="SOCIO" 
                                        HeaderText="SOCIO" SortExpression="SOCIO" ReadOnly="True" />
                                    <asp:BoundField DataField="CANCHA" HeaderText="CANCHA" 
                                        SortExpression="CANCHA" />
                                    <asp:BoundField DataField="PAGO" HeaderText="PAGO" SortExpression="PAGO" 
                                        Visible="False" />
                                </Columns>
                                <HeaderStyle BackColor="#007BFF" ForeColor="White" HorizontalAlign="Center" 
                                    VerticalAlign="Middle" />
                            </asp:GridView>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                
                
                
                                    ConnectionString="<%$ ConnectionStrings:SistemaDeGestionDePadelConnectionString %>" 
                                    
                             SelectCommand="SELECT CONVERT(varchar(10),ReservaCanPadFecha,103) AS [FECHA DE RESERVA], ReservaCanPadHora AS HORA, (PersonasPad.PersonasPAdApellido + ' ' + PersonasPad.PersonasPadNombre) AS SOCIO, Cancha.CanchaDescripcion AS CANCHA, ReservaCanPadPago AS PAGO
FROM ReservaCanPad
INNER JOIN PersonasPad ON PersonasPad.PersonasPadId = ReservaCanPad.PersonasPadId
INNER JOIN Cancha ON Cancha.CanchaId = ReservaCanPad.CanchaId
WHERE (CONVERT(varchar(10),ReservaCanPadFecha,103) = CONVERT(varchar(10),GETDATE(),103)) and ReservaCanPadEstado = 1"></asp:SqlDataSource>
                        <p class="help-block"></p>
                     </div>
                </div>
                <div class="col-lg-6 mb-4">
                     <div class="controls">
                        <div class="controls">
                        <asp:Label ID="Label2" runat="server" class="control" Text="Reservas anteriores pagadas hoy" Visible="True"></asp:Label>
                            <p class="help-block"></p>
            
                            <asp:GridView ID="GridView2" runat="server" class="controls" AutoGenerateColumns="False" 
                                HorizontalAlign="Center" DataSourceID="SqlDataSource2" Width="500px" 
                                BackColor="#80FF00" ForeColor="Black">
                                <Columns>
                                    <asp:BoundField DataField="FECHA DE RESERVA" HeaderText="FECHA DE RESERVA" ReadOnly="True" 
                                        SortExpression="FECHA DE RESERVA" />
                                    <asp:BoundField DataField="HORA" HeaderText="HORA" 
                                        SortExpression="HORA" />
                                    <asp:BoundField DataField="SOCIO" 
                                        HeaderText="SOCIO" SortExpression="SOCIO" ReadOnly="True" />
                                    <asp:BoundField DataField="CANCHA" HeaderText="CANCHA" 
                                        SortExpression="CANCHA" />
                                </Columns>
                                <EditRowStyle BackColor="#80FF00" ForeColor="White" />
                                <HeaderStyle BackColor="#007BFF" ForeColor="White" HorizontalAlign="Center" 
                                    VerticalAlign="Middle" />
                            </asp:GridView>
                            <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                
                
                
                                    ConnectionString="<%$ ConnectionStrings:SistemaDeGestionDePadelConnectionString %>" 
                                    
                                SelectCommand="SELECT CONVERT(varchar(10),ReservaCanPadFecha,103) AS [FECHA DE RESERVA], ReservaCanPadHora AS HORA, (PersonasPad.PersonasPAdApellido + ' ' + PersonasPad.PersonasPadNombre) AS SOCIO, Cancha.CanchaDescripcion AS CANCHA
FROM ReservaCanPad
INNER JOIN PersonasPad ON PersonasPad.PersonasPadId = ReservaCanPad.PersonasPadId
INNER JOIN Cancha ON Cancha.CanchaId = ReservaCanPad.CanchaId
WHERE ((CONVERT(varchar(10),ReservaCanPadFechaPago,103) = CONVERT(varchar(10),GETDATE(),103)) and (CONVERT(varchar(10),ReservaCanPadFecha,103) &lt;&gt; CONVERT(varchar(10),GETDATE(),103)) and (ReservaCanPadEstado = 1))"></asp:SqlDataSource>
                        <p class="help-block"></p>
                     </div>
                     </div>
                </div>
            </div>
      </asp:Panel>
          <asp:Panel ID="Panel2" runat="server" Visible="False">
            <div class="row">
                <div class="col-lg-6 mb-4">
                    <div class="controls">
                            <asp:Label ID="LabelTotal" runat="server" Text="Cantidad de Reservas en el Día:" class= "mt-4 mb-3" Visible="True"></asp:Label>
                            <asp:TextBox ID="TextBoxTotalReservas" runat="server" class="form-control" Visible="True"></asp:TextBox>
                            <p class="help-block"></p>
                        </div>
                        <div class="controls">
                            <asp:Label ID="LabelPagado" runat="server" Text="Total de Reservas del día pagadas:" class= "mt-4 mb-3" Visible="True"></asp:Label>
                            <asp:TextBox ID="TextBoxPagoHoy" runat="server" class="form-control" Visible="True"></asp:TextBox>
                            <p class="help-block"></p>
                        </div>
                        <div class="controls">
                            <asp:Label ID="LabelPagadoAnterior" runat="server" Text="Total de Reservas anteriores pagadas:" class= "mt-4 mb-3" Visible="True"></asp:Label>
                            <asp:TextBox ID="TextBoxPagoAnterior" runat="server" class="form-control" Visible="True"></asp:TextBox>
                            <p class="help-block"></p>
                        </div>
                </div>
                <div class="col-lg-6 mb-4">
                    <div class="controls">
                            <asp:Label ID="LabelDeuda" runat="server" Text="Cantidad de Reservas del día no pagadas:" class= "mt-4 mb-3" Visible="True"></asp:Label>
                            <asp:TextBox ID="TextBoxNoPagas" runat="server" class="form-control" Visible="True"></asp:TextBox>
                            <p class="help-block"></p>
                        </div>
                        <div class="controls">
                            <asp:Label ID="LabelRecaudadoHoy" runat="server" Text="Total recaudado reservas del día:" class= "mt-4 mb-3" Visible="True"></asp:Label>
                            <asp:TextBox ID="TextBoxPagadoHoy" runat="server" class="form-control" Visible="True"></asp:TextBox>
                            <p class="help-block"></p>
                        </div>
                        <div class="controls">
                            <asp:Label ID="LabelRecaudadoDeuda" runat="server" Text="Total recaudado reservas anteriores:" class= "mt-4 mb-3" Visible="True"></asp:Label>
                            <asp:TextBox ID="TextBoxPagadoExtra" runat="server" class="form-control" Visible="True"></asp:TextBox>
                            <p class="help-block"></p>
                        </div>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-4 mb-4">
                </div>
                <div class="col-lg-4 mb-4">
                    <div class="controls">
                            <asp:Label ID="LabelTotalFinal" runat="server" Text="Total recaudado:" class= "mt-4 mb-3" Visible="True"></asp:Label>
                            <asp:TextBox ID="TextBoxTotalFial" runat="server" class="form-control" Visible="True"></asp:TextBox>
                            <p class="help-block"></p>
                    </div>
                </div>
                <div class="col-lg-4 mb-4">
                </div>
            </div>
          </asp:Panel>
      </div>
      </form>
</div>
</asp:Content>
