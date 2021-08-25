<%@ Page Title="" Language="C#" MasterPageFile="~/Contable/SiteContable.Master" AutoEventWireup="true" CodeBehind="Ganancias.aspx.cs" Inherits="Sistema_de_Gestion_de_Padel.Contable.Ganancias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="container">
        <h1 class="mt-4 mb-3">Ganancias</h1>
        <form name="Ganancias" id="GananciasForm" novalidate>
        <div class="row">
        <div class="col-lg-6 mb-4">
            <asp:Label ID="LabelFecha" runat="server" Text="Ingrese la fecha" class= "mt-4 mb-3"></asp:Label>
            <asp:TextBox ID="TextBoxFecha" runat="server" class="form-control" 
                TextMode="Date"></asp:TextBox>
        </div>
        <div class="col-lg-4 mb-4">
            <asp:Button ID="Button1" class="btn btn-lg btn-primary btn-block" 
                runat="server" Text="Buscar Reservas" onclick="Button1_Click"/>
        </div>
        <p class="help-block"></p>
        </div>
        <div class="controls">

            
          
            
      <asp:Panel ID="Panel1" runat="server" Visible="False">

        <a class= "mt-4 mb-3">Reservas del día: </a>
                  <asp:Label ID="Label2" runat="server" style="font-weight: 700"></asp:Label>
                    <p class="help-block"></p>
            <div class="row">
                <div class="col-lg-6 mb-4">
                     <div class="controls">
                        <asp:Label ID="Label5" runat="server" class="control" Text="Reservas del día" Visible="True"></asp:Label>
                            <p class="help-block"></p>
            
                            <asp:GridView ID="GridView1" runat="server" class="controls" AutoGenerateColumns="False" 
                                HorizontalAlign="Center" 
                             onrowdatabound="GridView1_RowDataBound" Width="500px">
                                <Columns>
                                    <asp:BoundField DataField="FECHA DE RESERVA" HeaderText="FECHA DE RESERVA" 
                                        SortExpression="FECHA DE RESERVA" />
                                    <asp:BoundField DataField="HORA" HeaderText="HORA" SortExpression="HORA" />
                                    <asp:BoundField DataField="SOCIO" HeaderText="SOCIO" SortExpression="SOCIO" />
                                    <asp:BoundField DataField="CANCHA" HeaderText="CANCHA" 
                                        SortExpression="CANCHA" />
                                    <asp:BoundField DataField="PAGO" HeaderText="PAGO" SortExpression="PAGO" 
                                        Visible="False" />
                                </Columns>
                                <HeaderStyle BackColor="#007BFF" ForeColor="White" HorizontalAlign="Center" 
                                    VerticalAlign="Middle" />
                            </asp:GridView>
                        <p class="help-block"></p>
                     </div>
                </div>
                <div class="col-lg-6 mb-4">
                     <div class="controls">
                        <div class="controls">
                        <asp:Label ID="Label6" runat="server" class="control" Text="Reservas anteriores pagadas esa fecha" Visible="True"></asp:Label>
                            <p class="help-block"></p>
                                <asp:GridView ID="GridView2" runat="server" class="controls" AutoGenerateColumns="False" 
                                HorizontalAlign="Center" Width="500px" BackColor="#80FF00" 
                                ForeColor="Black">
                                <Columns>
                                    <asp:BoundField DataField="FECHA DE RESERVA" HeaderText="FECHA DE RESERVA" 
                                        SortExpression="FECHA DE RESERVA" />
                                    <asp:BoundField DataField="HORA" HeaderText="HORA" SortExpression="HORA" />
                                    <asp:BoundField DataField="SOCIO" HeaderText="SOCIO" SortExpression="SOCIO" />
                                    <asp:BoundField DataField="CANCHA" HeaderText="CANCHA" 
                                        SortExpression="CANCHA" />
                                </Columns>
                                <HeaderStyle BackColor="#007BFF" ForeColor="White" HorizontalAlign="Center" 
                                    VerticalAlign="Middle" />
                            </asp:GridView>
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
                            <asp:Label ID="Label1" runat="server" Text="Cantidad de Reservas en el Día:" class= "mt-4 mb-3" Visible="True"></asp:Label>
                            <asp:TextBox ID="TextBoxTotalReservas" runat="server" class="form-control" Visible="True"></asp:TextBox>
                            <p class="help-block"></p>
                        </div>
                        <div class="controls">
                            <asp:Label ID="Label3" runat="server" Text="Cantidad de Reservas del día pagadas:" class= "mt-4 mb-3" Visible="True"></asp:Label>
                            <asp:TextBox ID="TextBoxPagoHoy" runat="server" class="form-control" Visible="True"></asp:TextBox>
                            <p class="help-block"></p>
                        </div>
                        <div class="controls">
                            <asp:Label ID="LabelPagadoAnterior" runat="server" Text="Cantidad de Reservas anteriores pagadas:" class= "mt-4 mb-3" Visible="True"></asp:Label>
                            <asp:TextBox ID="TextBoxPagoAnterior" runat="server" class="form-control" Visible="True"></asp:TextBox>
                            <p class="help-block"></p>
                        </div>
                </div>
                <div class="col-lg-6 mb-4">
                    <div class="controls">
                            <asp:Label ID="Label4" runat="server" Text="Cantidad de Reservas del día no pagadas:" class= "mt-4 mb-3" Visible="True"></asp:Label>
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
