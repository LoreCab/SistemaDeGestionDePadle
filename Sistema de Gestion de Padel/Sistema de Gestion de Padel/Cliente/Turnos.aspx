<%@ Page Title="" Language="C#" MasterPageFile="~/Cliente/SiteCliente.Master" AutoEventWireup="true" CodeBehind="Turnos.aspx.cs" Inherits="Sistema_de_Gestion_de_Padel.Cliente.Turnos" %>
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
        <div class="col-lg-6 mb-4">
            <asp:Button ID="Button1" class="btn btn-lg btn-primary btn-block" 
                runat="server" Text="Buscar Reservas" onclick="ButtonBuscar_Click"/>
        </div>
        <p class="help-block"></p>
        </div>
        <asp:Panel ID="Panel1" runat="server" Visible="False">

        <a class= "mt-4 mb-3">Reservas del día: </a>
                  <asp:Label ID="Label2" runat="server" style="font-weight: 700"></asp:Label>
                    <p class="help-block"></p>
                     <div class="controls">
            
                            <asp:GridView ID="GridView1" runat="server" class="controls" AutoGenerateColumns="False" 
                                HorizontalAlign="Center" Width="500px" 
                                onrowdatabound="GridView1_RowDataBound">
                                <Columns>
                                    <asp:BoundField DataField="PersonasPadDni" HeaderText="HORA" 
                                        SortExpression="HORA" />
                                    <asp:BoundField DataField="PersonasPAdApellido" HeaderText="SOCIO" 
                                        SortExpression="SOCIO" />
                                    <asp:BoundField DataField="PersonasPadNombre" HeaderText="CANCHA" 
                                        SortExpression="CANCHA" />
                                    <asp:BoundField DataField="PersonasPadEstado" HeaderText="TIPO" SortExpression="TIPO" 
                                        Visible="False" />
                                </Columns>
                                <HeaderStyle BackColor="#007BFF" ForeColor="White" HorizontalAlign="Center" 
                                    VerticalAlign="Middle" />
                            </asp:GridView>
                        <p class="help-block"></p>
                     </div>
      </asp:Panel>

</div>
</asp:Content>
