<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Turnos.aspx.cs" Inherits="Sistema_de_Gestion_de_Padel.Turnos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="container">
    <h1 class="mt-4 mb-3">Cargar Reserva</h1>
        
        <div class="controls">
            <label>Ingrese el DNI del Socio:</label>
            <asp:TextBox ID="TextBoxDNI" runat="server" class="form-control" maxlength="8" onKeypress="if (event.keyCode < 48 || event.keyCode > 57) event.returnValue = false;" required data-validation-required-message="Por favor ingrese el dni."></asp:TextBox>
            <p class="help-block"></p>
        </div>
        <div class="row">
            <div class="col-lg-4 mb-4">
                <asp:Button ID="Button1" class="btn btn-lg btn-primary btn-block" 
                    runat="server" Text="Buscar Cliente" onclick="Button1_Click"/>
            </div>
            <div class="col-lg-4 mb-4">
                <asp:Label ID="LabelError" runat="server" 
                    Text="*El DNI ingresado no corresponde a un Socio" class= "mt-4 mb-3" 
                    Visible="False" Font-Bold="True" ForeColor="Red"></asp:Label>
            </div>
            <p class="help-block"></p>
        </div>
        <div class="controls">
            <div>
                <asp:Label ID="Label4" runat="server" Text="Nombre del Socio: " 
                    class= "mt-4 mb-3 text-primary" Visible="False"></asp:Label>
                <asp:Label ID="Label2" runat="server" class= "mt-4 mb-3" Visible="False"></asp:Label>
            </div>
            <div>
                <asp:Label ID="Label5" runat="server" Text="Cod del Socio: " 
                    class= "mt-4 mb-3 text-primary" Visible="False"></asp:Label>
                <asp:Label ID="Label3" runat="server" class= "mt-4 mb-3" Visible="False"></asp:Label>
            </div>
         </div>
        
        <div class="controls">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"
              Align="Center" Font-Size="Large" HorizontalAlign="Center"  
              DataKeyNames="CÓDIGO DE CANCHA" DataSourceID="SqlDataSource1" 
              onselectedindexchanged="GridView1_SelectedIndexChanged" Visible="False">
              <Columns>
                  <asp:BoundField DataField="CÓDIGO DE CANCHA" HeaderText="CÓDIGO DE CANCHA" 
                      ReadOnly="True" SortExpression="CÓDIGO DE CANCHA" Visible="False" />
                  <asp:BoundField DataField="DESCRIPCIÓN DE LA CANCHA" 
                      HeaderText="DESCRIPCIÓN DE LA CANCHA" 
                      SortExpression="DESCRIPCIÓN DE LA CANCHA" />
                  <asp:BoundField DataField="ESTADO CANCHA" HeaderText="ESTADO CANCHA" 
                      SortExpression="ESTADO CANCHA" />
                  <asp:CommandField ShowSelectButton="True" />
              </Columns>
          </asp:GridView>
          <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
              ConnectionString="<%$ ConnectionStrings:SistemaDeGestionDePadelConnectionString %>" 
              
              
              
              SelectCommand="SELECT [CanchaId] AS [CÓDIGO DE CANCHA], [CanchaDescripcion] AS [DESCRIPCIÓN DE LA CANCHA], [EstadoCancha] AS [ESTADO CANCHA] FROM [Cancha]">
          </asp:SqlDataSource>
      </div>
      <div class="controls">
            <p class="help-block"></p>
            <asp:Label ID="Label6" runat="server" Text="Ingrese la fecha de la reserva:" class= "mt-4 mb-3" Visible="False"></asp:Label>
            &nbsp;<asp:Label ID="Label10" runat="server" 
                style="color: #FF0000; font-weight: 700"></asp:Label>
            <asp:TextBox ID="TextBoxFechaReserva" runat="server" class="form-control" ontextchanged="TextBoxFechaReserva_TextChanged" TextMode="Date" Visible="False"></asp:TextBox>
            <p class="help-block"></p>
      </div>
      
      <div class="controls">
            <asp:Label ID="Label9" runat="server" Text="Seleccione la hora de su reserva:" class= "mt-4 mb-3" Visible="False"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" class="form-control" 
                Visible="False">
                <asp:ListItem>Seleccione</asp:ListItem>
                <asp:ListItem>15</asp:ListItem>
                <asp:ListItem>16</asp:ListItem>
                <asp:ListItem>17</asp:ListItem>
                <asp:ListItem>18</asp:ListItem>
                <asp:ListItem>19</asp:ListItem>
                <asp:ListItem>20</asp:ListItem>
                <asp:ListItem>21</asp:ListItem>
                <asp:ListItem>22</asp:ListItem>
                <asp:ListItem>23</asp:ListItem>
                <asp:ListItem>24</asp:ListItem>
            </asp:DropDownList>
            <p class="help-block"></p>
      </div>

      <div class="controls">
            <asp:Label ID="LabelFijo" runat="server" Text="El turno será fijo?" class= "mt-4 mb-3" Visible="False"></asp:Label>
            <asp:DropDownList ID="DropDownList3"  runat="server" class="form-control" Visible="False">
                <asp:ListItem>Seleccione</asp:ListItem>
                <asp:ListItem Value="1">Si</asp:ListItem>
                <asp:ListItem Value="0">No</asp:ListItem>
            </asp:DropDownList>
            <p class="help-block"></p>
      </div>

      <div class="row">
            <div class="col-lg-4 mb-4">
                <asp:Button ID="Button2" class="btn btn-lg btn-primary btn-block" 
                    runat="server" Text="Buscar Reserva" onclick="Button2_Click" 
                    Visible="False"/>
            </div>
            <p class="help-block"></p>
        </div>

      <div class="controls">
        <asp:Label ID="LabelReservaError" runat="server" Text="*La fecha ya está reservada" class= "mt-4 mb-3" Visible="False" Font-Bold="True" ForeColor="Red"></asp:Label>
        <p class="help-block"></p>
      </div>

      <div class="controls">
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False"
              Align="Center" Font-Size="Large" HorizontalAlign="Center" DataSourceID="SqlDataSource2" 
              onselectedindexchanged="GridView1_SelectedIndexChanged" Visible="False">
              <Columns>
                  <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" 
                      ReadOnly="True" />
                  <asp:BoundField DataField="Hora" 
                      HeaderText="Hora" 
                      SortExpression="Hora" />
                  <asp:BoundField DataField="Socio" HeaderText="Socio" 
                      SortExpression="Socio" ReadOnly="True" />
                  <asp:BoundField DataField="Tipo de Reserva" HeaderText="Tipo de Reserva" 
                      SortExpression="Tipo de Reserva" />
              </Columns>
          </asp:GridView>
          <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
              
              ConnectionString="<%$ ConnectionStrings:SistemaDeGestionDePadelConnectionString %>" SelectCommand="SELECT CONVERT(char(10), [ReservaCanPadFecha], 103) AS Fecha, [ReservaCanPadHora] AS Hora, ([PersonasPad].[PersonasPAdApellido] + ' ' + [PersonasPad].[PersonasPadNombre]) AS Socio, [ReservaCanPadTipo] AS [Tipo de Reserva]
FROM [ReservaCanPad]
INNER JOIN PersonasPad ON PersonasPad.PersonasPadId = ReservaCanPad.PersonasPadId
WHERE ReservaCanPadEstado = 1;"></asp:SqlDataSource>
            <div class="controls">
              <asp:Label ID="Label8" runat="server" Text="Reserva Fija Cancha I" class= "mt-4 mb-3 text-primary" Visible="False"></asp:Label>
          </div>
          <div class="controls">
            <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" HorizontalAlign="Center" Visible="False"
              DataSourceID="SqlDataSource3">
              <Columns>
                  <asp:BoundField DataField="HORA" HeaderText="HORA" SortExpression="HORA" 
                      ReadOnly="True" />
                  <asp:BoundField DataField="CLIENTE" HeaderText="CLIENTE" ReadOnly="True" 
                      SortExpression="CLIENTE" />
                  <asp:BoundField DataField="ESTADO" HeaderText="ESTADO" 
                      SortExpression="ESTADO" />
              </Columns>
          </asp:GridView>
          <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
              
                  ConnectionString="<%$ ConnectionStrings:SistemaDeGestionDePadelConnectionString %>" SelectCommand="SELECT CONVERT(char(10), [TurnoFijoCanPadHora], 103) AS [HORA], ([PersonasPad].[PersonasPAdApellido] + ' ' + [PersonasPad].[PersonasPadNombre]) AS [CLIENTE], [TurnoFijoCanPadEstado] AS [ESTADO]
FROM [TurnoFijoCanPad]
INNER JOIN PersonasPad ON PersonasPad.PersonasPadId = TurnoFijoCanPad.PersonasPadId
WHERE (([TurnoFijoCanPadDia] = (DATEPART(dw,GETDATE())) -1) and ([CanchaId] = 1))">
          </asp:SqlDataSource>
          </div>

          <div class="controls">
              <asp:Label ID="Label7" runat="server" Text="Reserva Fija Cancha II" class= "mt-4 mb-3 text-primary" Visible="False"></asp:Label>
          </div>
          <div class="controls">
          <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" HorizontalAlign="Center" Visible="False"
              DataSourceID="SqlDataSource4">
              <Columns>
                  <asp:BoundField DataField="HORA" HeaderText="HORA" SortExpression="HORA" 
                      ReadOnly="True" />
                  <asp:BoundField DataField="CLIENTE" HeaderText="CLIENTE" ReadOnly="True" 
                      SortExpression="CLIENTE" />
                  <asp:BoundField DataField="ESTADO" HeaderText="ESTADO" 
                      SortExpression="ESTADO" />
              </Columns>
          </asp:GridView>
          <asp:SqlDataSource ID="SqlDataSource4" runat="server" 
              
              
                  ConnectionString="<%$ ConnectionStrings:SistemaDeGestionDePadelConnectionString %>" SelectCommand="SELECT CONVERT(char(10), [TurnoFijoCanPadHora], 103) AS [HORA], ([PersonasPad].[PersonasPAdApellido] + ' ' + [PersonasPad].[PersonasPadNombre]) AS [CLIENTE], [TurnoFijoCanPadEstado] AS [ESTADO]
FROM [TurnoFijoCanPad]
INNER JOIN PersonasPad ON PersonasPad.PersonasPadId = TurnoFijoCanPad.PersonasPadId
WHERE (([TurnoFijoCanPadDia] = (DATEPART(dw,GETDATE())) -1) and ([CanchaId] = 2))">
          </asp:SqlDataSource>
      </div>
      </div>
      <asp:Panel ID="Panel1" runat="server" class="controls" Visible="False">
      <div class="controls">
            <asp:Label ID="LabelPago" runat="server" Text="Paga la reserva:" 
                class= "mt-4 mb-3"></asp:Label>
            <asp:DropDownList ID="DropDownList2"  runat="server" class="form-control">
                <asp:ListItem>Seleccione</asp:ListItem>
                <asp:ListItem Value="1">Si</asp:ListItem>
                <asp:ListItem Value="0">No</asp:ListItem>
            </asp:DropDownList>
            <p class="help-block"></p>
      </div>

      <div class="row">
            <div class="col-lg-4 mb-4">
                <asp:Button ID="ButtonGuardarReserva" class="btn btn-lg btn-primary btn-block" 
                    runat="server" Text="Registrar Reserva" Visible="False" 
                    onclick="ButtonGuardarReserva_Click"/>
            </div>
            <p class="help-block"></p>
        </div>
    </asp:Panel>
    </div> <!-- DIV CONTAINER -->
</asp:Content>
