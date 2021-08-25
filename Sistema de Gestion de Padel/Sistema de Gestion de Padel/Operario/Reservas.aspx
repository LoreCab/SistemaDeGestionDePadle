<%@ Page Title="" Language="C#" MasterPageFile="~/Operario/SiteOperario.Master" AutoEventWireup="true" CodeBehind="Reservas.aspx.cs" Inherits="Sistema_de_Gestion_de_Padel.Operario.Reservas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="container">
    <h1 class="mt-4 mb-3">Cargar Reserva</h1>
    <p class="help-block"></p>
        <asp:Panel ID="Panel1" runat="server" class="controls"> <!--PANEL DONDE SELECCIONO CANCHA, DIA Y SI ES TURNO FIJO O NO-->
        <div class="row">
            <div class="col-lg-4 mb-4">
        <div class="controls">
        <asp:Label ID="Label1" runat="server" Text="Seleccione la cancha:" 
                class= "mt-4 mb-3"></asp:Label>
            <asp:DropDownList ID="DropDownList4" runat="server" class="form-control" 
                DataSourceID="SqlDataSource1" DataTextField="DESCRIPCIÓN DE LA CANCHA" 
                DataValueField="CÓDIGO DE CANCHA">
            </asp:DropDownList>
          <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
              ConnectionString="<%$ ConnectionStrings:SistemaDeGestionDePadelConnectionString %>" 
              SelectCommand="SELECT [CanchaId] AS [CÓDIGO DE CANCHA], [CanchaDescripcion] AS [DESCRIPCIÓN DE LA CANCHA], [EstadoCancha] AS [ESTADO CANCHA] FROM [Cancha]">
          </asp:SqlDataSource>
        </div>
        </div>
        <div class="col-lg-4 mb-4">
                <div class="controls">
                    <asp:Label ID="Label6" runat="server" class="mt-4 mb-3" 
                        Text="Ingrese la fecha de la reserva:"></asp:Label>
                    &nbsp;<asp:TextBox ID="TextBoxFechaReserva" runat="server" class="form-control" 
                        TextMode="Date"></asp:TextBox>
                </div>
        </div>
        <div class="col-lg-4 mb-4">
        <div class="controls">
            <asp:Label ID="LabelFijo" runat="server" Text="El turno será fijo?" 
                class= "mt-4 mb-3"></asp:Label>
            <asp:DropDownList ID="DropDownList3"  runat="server" class="form-control">
                <asp:ListItem>Seleccione</asp:ListItem>
                <asp:ListItem Value="1">Si</asp:ListItem>
                <asp:ListItem Value="0">No</asp:ListItem>
            </asp:DropDownList>
        </div>
        </div>
        <p class="help-block"></p>
        </div>
        <div class="row">
            <div class="col-lg-4 mb-4">
            </div>
            <div class="col-lg-4 mb-4">
            <asp:Button ID="Button1" runat="server" 
                class="btn btn-lg btn-primary btn-block" onclick="Button1_Click" 
                Text="Buscar Reserva" />
            </div>
            <div class="col-lg-4 mb-4">
            <asp:Label ID="Label10" runat="server" class="mt-4 mb-3" Font-Bold="True" 
                    ForeColor="Red" Text="*Fecha ingresada incorrecta" 
                    Visible="False"></asp:Label>
            </div>
        </div>
        <p class="help-block"></p>
        </asp:Panel> <!--FIN DEL PANEL DONDE SELECCIONO CANCHA, DIA Y SI ES TURNO FIJO O NO-->

        <asp:Panel ID="Panel2" runat="server" class="controls" Visible="False"> <!-- PANEL DONDE BUSCO EL CLIENTE, LAS RESERVAS Y TURNO FIJO-->
            <div class="controls">
            <asp:Label ID="Label7" runat="server" class= "mt-4 mb-3 text-primary">Reservas Diarias</asp:Label>
            <p class="help-block"></p>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False"
              Align="Center" Font-Size="Large" HorizontalAlign="Center"  
                    onrowdatabound="GridView2_RowDataBound" Width="900px">
              <Columns>
                  <asp:BoundField DataField="CODIGO" HeaderText="CODIGO" SortExpression="CODIGO" 
                      Visible="False" />
                  <asp:BoundField DataField="HORA" HeaderText="HORA" SortExpression="HORA" />
                  <asp:BoundField DataField="SOCIO" HeaderText="SOCIO" SortExpression="SOCIO" />
                  <asp:BoundField DataField="TIPO" HeaderText="TIPO" SortExpression="TIPO" 
                      Visible="False" />
              </Columns>
              <HeaderStyle BackColor="#007BFF" ForeColor="White" HorizontalAlign="Center" 
                  VerticalAlign="Middle" Width="300px" />
              <RowStyle Width="300px" Wrap="False" />
          </asp:GridView>
            <p class="help-block"></p>
            <div class="controls">
              <asp:Label ID="Label8" runat="server" class= "mt-4 mb-3 text-primary"></asp:Label>
              <p class="help-block"></p>
          </div>
          <div class="controls">
            <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
                  HorizontalAlign="Center" Font-Size="Large" 
                  onrowdatabound="GridView3_RowDataBound" Width="900px">
                <Columns>
                    <asp:BoundField DataField="CODIGO" HeaderText="CODIGO" SortExpression="CODIGO" 
                        Visible="False" />
                    <asp:BoundField DataField="HORA" HeaderText="HORA" SortExpression="HORA" />
                    <asp:BoundField DataField="CLIENTE" HeaderText="SOCIO" 
                        SortExpression="CLIENTE" />
                    <asp:BoundField DataField="ESTADO" HeaderText="ESTADO" SortExpression="ESTADO" 
                        Visible="False" />
                </Columns>
                <HeaderStyle BackColor="#1E8AFE" ForeColor="White" HorizontalAlign="Center" 
                    VerticalAlign="Middle" Width="200px" />
                <RowStyle Width="300px" />
          </asp:GridView>
          </div>
          <p class="help-block"></p>
      </div>
            <div class="controls">
            <asp:Label ID="Label9" runat="server" Text="Seleccione la hora de su reserva:" class= "mt-4 mb-3"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" class="form-control">
                <asp:ListItem>Seleccione</asp:ListItem>
            </asp:DropDownList>
            <p class="help-block"></p>
            </div>        
            <div class="controls">
                <label>Ingrese el DNI del Socio:</label>
                <asp:TextBox ID="TextBoxDNI" runat="server" class="form-control" maxlength="8" onKeypress="if (event.keyCode < 48 || event.keyCode > 57) event.returnValue = false;" required data-validation-required-message="Por favor ingrese el dni."></asp:TextBox>
                <p class="help-block"></p>
            </div>
            <div class="row">
            <div class="col-lg-4 mb-4">
                <asp:Button ID="Button2" class="btn btn-lg btn-primary btn-block" 
                    runat="server" Text="Buscar Cliente" onclick="Button2_Click"/>
            </div>
            <div class="col-lg-4 mb-4">
            </div>
            <p class="help-block">
                <asp:Label ID="LabelError" runat="server" class="mt-4 mb-3" Font-Bold="True" 
                    ForeColor="Red" Text="*El DNI ingresado no corresponde a un Socio" 
                    Visible="False"></asp:Label>
                </p>
        </div>
        </asp:Panel> <!--FIN DEL PANEL DONDE BUSCO EL CLIENTE, LAS RESERVAS Y TURNO FIJO-->
        
        <asp:Panel ID="Panel3" runat="server" class="controls" Visible="False"> <!-- PANEL DONDE MUESTRO LOS DATOS DEL CLIENTE Y RESERVO LA CANCHA-->
        <div class="controls">
            <div>
                <asp:Label ID="Label4" runat="server" Text="Nombre del Socio: " 
                    class= "mt-4 mb-3 text-primary"></asp:Label>
                <asp:Label ID="Label2" runat="server" class= "mt-4 mb-3"></asp:Label>
            </div>
            <div>
                <asp:Label ID="Label5" runat="server" Text="Cod del Socio: " 
                    class= "mt-4 mb-3 text-primary"></asp:Label>
                <asp:Label ID="Label3" runat="server" class= "mt-4 mb-3"></asp:Label>
                <br />
            </div>
            <p class="help-block"></p>
         </div>
         <div class="row">
            <div class="col-lg-4 mb-4">
                <asp:Button ID="ButtonGuardarReserva" class="btn btn-lg btn-primary btn-block" 
                    runat="server" Text="Registrar Reserva" 
                    onclick="ButtonGuardarReserva_Click"/>
            </div>
        </div>
        </asp:Panel><!--FIN DEL PANEL DONDE MUESTRO LOS DATOS DEL CLIENTE Y RESERVO LA CANCHA-->
        
        
       
      
      

      <div class="controls">
        <p class="help-block"></p>
      </div>
    
    </div> <!-- DIV CONTAINER -->
</asp:Content>
