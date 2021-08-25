<%@ Page Title="" Language="C#" MasterPageFile="~/Operario/SiteOperario.Master" AutoEventWireup="true" CodeBehind="Canchas.aspx.cs" Inherits="Sistema_de_Gestion_de_Padel.Operario.Canchas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="container">
    <!-- Page Heading/Breadcrumbs -->
      <h1 class="mt-4 mb-3">Canchas</h1>
      <form name="CargarCancha" id="CanchaForm" novalidate>
      <div class="controls">
      
          <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"
              Align="Center" Font-Size="Medium" HorizontalAlign="Center"  
              DataKeyNames="CÓDIGO DE CANCHA" DataSourceID="SqlDataSource1" 
              onselectedindexchanged="GridView1_SelectedIndexChanged" Width="750px">
              <Columns>
                  <asp:BoundField DataField="CÓDIGO DE CANCHA" HeaderText="CÓDIGO DE CANCHA" 
                      ReadOnly="True" SortExpression="CÓDIGO DE CANCHA" Visible="False" />
                  <asp:BoundField DataField="DESCRIPCIÓN DE LA CANCHA" 
                      HeaderText="DESCRIPCIÓN DE LA CANCHA" 
                      SortExpression="DESCRIPCIÓN DE LA CANCHA" />
                  <asp:BoundField DataField="ESTADO CANCHA" HeaderText="ESTADO CANCHA" 
                      SortExpression="ESTADO CANCHA" Visible="False" />
                  <asp:BoundField DataField="ESTADO" HeaderText="ESTADO" ReadOnly="True" 
                      SortExpression="ESTADO" />
                  <asp:CommandField ShowSelectButton="True" />
              </Columns>
              <HeaderStyle BackColor="#007BFF" Font-Size="Large" ForeColor="White" 
                  HorizontalAlign="Center" VerticalAlign="Middle" />
          </asp:GridView>
          <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
              ConnectionString="<%$ ConnectionStrings:SistemaDeGestionDePadelConnectionString %>" 
              
              
              
              SelectCommand="SELECT [CanchaId] AS [CÓDIGO DE CANCHA], [CanchaDescripcion] AS [DESCRIPCIÓN DE LA CANCHA], [EstadoCancha] AS [ESTADO CANCHA],
MAX(CASE WHEN [EstadoCancha] = 1 THEN 'EN USO' ELSE 'EN REFACCION' END) AS [ESTADO]
FROM [Cancha]
GROUP BY EstadoCancha, [CanchaId], [CanchaDescripcion]">
          </asp:SqlDataSource>
      
      </div>
        <div class="controls">
                <label>Nombre:</label>
                <asp:TextBox ID="TextBoxNombre" runat="server" class="form-control" maxlength="40" required data-validation-required-message="Por favor ingrese el nombre."></asp:TextBox>
                <p class="help-block"></p>
        </div>
        <div class="controls">
                <label>Estado:</label>
                <asp:DropDownList ID="DropDownList1" runat="server" class="form-control">
                    <asp:ListItem>SELECCIONE</asp:ListItem>
                    <asp:ListItem Value="1">EN USO</asp:ListItem>
                    <asp:ListItem Value="0">EN REFACCION</asp:ListItem>
                </asp:DropDownList>
                <p class="help-block"></p>
        </div>

        <div>
        <p class="help-block"></p>
        </div>
        
      </form>
      <div class="row">
        <div class="col-lg-4 mb-4">
            <asp:Button ID="ButtonRegistrar" class="btn btn-lg btn-primary btn-block" 
                runat="server" Text="Registrar" onclick="ButtonRegistrar_Click"/>
        </div>
        <div class="col-lg-4 mb-4">
        </div>
        <div class="col-lg-4 mb-4">
            <asp:Button ID="ButtonModificar" class="btn btn-lg btn-primary btn-block" 
                runat="server" Text="Modificar" Visible="False" 
                onclick="ButtonModificar_Click"/>
        </div>
      </div>
</div>
</asp:Content>
