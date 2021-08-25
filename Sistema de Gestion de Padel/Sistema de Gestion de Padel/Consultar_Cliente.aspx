<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Consultar_Cliente.aspx.cs" Inherits="Sistema_de_Gestion_de_Padel.Consultar_Cliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="container">
      <h1 class="mt-4 mb-3">Socios Cargados</h1>
      <form name="ConsultarCliente" id="ClienteForm" novalidate>
        <div class="control"> 
        <asp:GridView ID="GridView1" runat="server" class="control"   
            AutoGenerateColumns="False" DataKeyNames="Cod" DataSourceID="SqlDataSource1" 
                Align="Center" Font-Size="Large" HorizontalAlign="Center" 
                onselectedindexchanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="Cod" HeaderText="Cod" ReadOnly="True" 
                    SortExpression="Cod" />
                <asp:BoundField DataField="DNI" HeaderText="DNI" SortExpression="DNI" />
                <asp:BoundField DataField="Socio" HeaderText="Socio" 
                    SortExpression="Socio" ReadOnly="True" />
                <asp:BoundField DataField="Localidad" HeaderText="Localidad" 
                    SortExpression="Localidad" />
                <asp:BoundField DataField="Telefono" HeaderText="Telefono" 
                    SortExpression="Telefono" />
                <asp:BoundField DataField="Fecha de Nacimiento" 
                    HeaderText="Fecha de Nacimiento" SortExpression="Fecha de Nacimiento" 
                    ReadOnly="True" />
                <asp:BoundField DataField="Deuda" HeaderText="Deuda" SortExpression="Deuda" />
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
          </asp:GridView>
          <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:SistemaDeGestionDePadelConnectionString %>" 
            
                SelectCommand="SELECT [PersonasPadId] AS [Cod], [PersonasPadDni] AS [DNI],
[PersonasPAdApellido] +', '+ [PersonasPadNombre] AS [Socio],
[LocalidadP].NombreLocalidadP AS [Localidad], [PersonasPadTelefono] AS [Telefono],
CONVERT(char(10), PersonasPadFecNac, 103) AS [Fecha de Nacimiento], [PersonasPadDeuda] AS [Deuda]
FROM [PersonasPad] 
INNER JOIN [LocalidadP] ON PersonasPad.LocalidadPId = LocalidadP.LocalidadPId
WHERE [PersonasPadEstado] = 1">
          </asp:SqlDataSource>
          <p class="help-block"></p>
          </div>

        <div class="controls">
                <label>Nombre:</label>
                <asp:TextBox ID="TextBoxNombre" runat="server" class="form-control" maxlength="50" required data-validation-required-message="Por favor ingrese el nombre."></asp:TextBox>
                <p class="help-block"></p>
        </div>
        <div class="controls">
                <label>Apellido:</label>
                <asp:TextBox ID="TextBoxApellido" runat="server" class="form-control" maxlength="50" required data-validation-required-message="Por favor ingrese el apellido."></asp:TextBox>
                <p class="help-block"></p>
        </div>
        <div class="controls">
                <label>DNI:</label>
                <asp:TextBox ID="TextBoxDNI" runat="server" class="form-control" maxlength="8" onKeypress="if (event.keyCode < 48 || event.keyCode > 57) event.returnValue = false;" required data-validation-required-message="Por favor ingrese el dni."></asp:TextBox>
                <p class="help-block">
                </p>
        </div>
        <div class="controls">
                <label>Localidad:</label>
                <asp:DropDownList ID="DropDownList1" runat="server" 
                    DataSourceID="SqlDataSource2" DataTextField="NombreLocalidadP" 
                    DataValueField="NombreLocalidadP" class="form-control">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:SistemaDeGestionDePadelConnectionString %>" 
                    SelectCommand="SELECT [LocalidadPId], [NombreLocalidadP] FROM [LocalidadP]">
                </asp:SqlDataSource>
                <p class="help-block"></p>
        </div>
        <div class="controls">
                <label>Fecha de Nacimiento:</label>
                <asp:TextBox ID="TextBoxFNac" runat="server" class="form-control" 
                    maxlength="10" 
                    onKeypress="if (event.keyCode < 47 || event.keyCode > 57) event.returnValue = false;" 
                    required 
                    data-validation-required-message="Por favor ingrese la fecha de nacimiento." 
                    TextMode="Date" Wrap="False">01/01/1900</asp:TextBox>
                <p class="help-block"></p>
        </div>
        <div class="controls">
                <label>Telefono:</label>
                <asp:TextBox ID="TextBoxTelefono" runat="server" class="form-control" maxlength="10" onKeypress="if (event.keyCode < 48 || event.keyCode > 57) event.returnValue = false;" required data-validation-required-message="Por favor ingrese el telefono."></asp:TextBox>
                <p class="help-block"</p>
        </div>
        <div class="row"> 
            <div class="col-lg-4 mb-4">
                <asp:Button ID="ButtonModificar" class="btn btn-lg btn-primary btn-block" 
                    runat="server"  Text="Modificar" onclick="ButtonModificar_Click" 
                    Visible="False"/>
            </div>
             <div class="col-lg-4 mb-4">
             </div>
            <div class="col-lg-4 mb-4">
                <asp:Button ID="ButtonEliminar" class="btn btn-lg btn-primary btn-block" 
                    runat="server" Text="Eliminar" onclick="ButtonEliminar_Click" 
                    Visible="False"/>
            </div>
            <p class="help-block"</p>
        </div>

      </form>
     </div>
</asp:Content>
