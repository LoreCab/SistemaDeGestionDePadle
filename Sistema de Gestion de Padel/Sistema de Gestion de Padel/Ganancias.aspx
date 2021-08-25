<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ganancias.aspx.cs" Inherits="Sistema_de_Gestion_de_Padel.Ganancias" %>
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
            
            <asp:GridView ID="GridView1" runat="server" class="controls" AutoGenerateColumns="False" 
                HorizontalAlign="Center">
                <Columns>
                    <asp:BoundField DataField="LocalidadPId" HeaderText="Hora" />
                    <asp:BoundField DataField="PersonasPadNombre" 
                        HeaderText="Socio" />
                    <asp:BoundField DataField="PersonasPadTelefono" HeaderText="Cancha" />
                    <asp:BoundField DataField="PersonasPAdApellido" HeaderText="Pagado" />
                </Columns>
            </asp:GridView>
        <p class="help-block">&nbsp;</p>

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
