<%@ Page Title="" Language="C#" MasterPageFile="~/Organizador/SiteOrganizador.Master" AutoEventWireup="true" CodeBehind="Consultar_Torneo.aspx.cs" Inherits="Sistema_de_Gestion_de_Padel.Organizador.Consultar_Torneo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
<div class="container">
    <h1 class="mt-4 mb-3">Consultar Torneos Finalizados</h1>
    <div class="controls">
    <form name="Consultar_ReservasFijas" id="ConsultaReservaFijas" novalidate>
        <div class="controls">
            <label>Seleccione el torneo</label>
        <div class="row">
         <div class="col-lg-6 mb-4">
                <asp:DropDownList ID="DropDownList1" runat="server" class="form-control" 
                    DataSourceID="SqlDataSource1" DataTextField="NombreTorneo" 
                    DataValueField="TorneoId">
                    <asp:ListItem>SELECCIONE</asp:ListItem>
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:SistemaDeGestionDePadelConnectionString %>" 
                
                    SelectCommand="SELECT [TorneoId], [NombreTorneo], [Estado] FROM [Torneo] WHERE Estado = 0">
                </asp:SqlDataSource>
                <p class="help-block"></p>
            </div>
            <div class="col-lg-6 mb-4">
                <asp:Button ID="ButtonBuscar" class="btn btn-lg btn-primary btn-block" 
                    runat="server" Text="Buscar Torneo" onclick="ButtonBuscar_Click"/>
            </div>
            </div>
            <p class="help-block"></p>
            <asp:Panel ID="Panel2" runat="server" Visible="False">
            <div class="row">
                <div class="col-lg-4 mb-4">
                    <div class="controls">
                        <label>Fecha de Inicio:</label>
                        <asp:TextBox ID="TextBoxFInicio" runat="server" class="form-control" maxlength="10" onKeypress="if (event.keyCode < 47 || event.keyCode > 57) event.returnValue = false;" required  data-validation-required-message="Por favor ingrese la fecha de nacimiento." TextMode="Date" Wrap="False">01/01/1900</asp:TextBox>
                        <p class="help-block"></p>
                    </div>
                </div>
                <div class="col-lg-4 mb-4">
                    <div class="controls">
                        <label>Fecha de Finalización:</label>
                        <asp:TextBox ID="TextBoxFFin" runat="server" class="form-control" maxlength="10" onKeypress="if (event.keyCode < 47 || event.keyCode > 57) event.returnValue = false;" required  data-validation-required-message="Por favor ingrese la fecha de nacimiento." TextMode="Date" Wrap="False">01/01/1900</asp:TextBox>
                        <p class="help-block"></p>
                    </div>
                </div>
                <div class="col-lg-4 mb-4">
                    <div class="controls">
                        <label>Equipo Ganador:</label>
                        <asp:TextBox ID="TextBoxGanador" runat="server" class="form-control" maxlength="50" required data-validation-required-message="Por favor ingrese el nombre."></asp:TextBox>
                        <p class="help-block"></p>
                    </div>
                </div>
            </div>
            </asp:Panel>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"
              Align="Center" Font-Size="Medium" HorizontalAlign="Center" Width="750px" 
                onrowdatabound="GridView1_RowDataBound">
                <Columns>
                    <asp:BoundField DataField="PersonasPAdApellido" HeaderText="PAREJA" 
                        SortExpression="PAREJA" />
                    <asp:BoundField DataField="PersonasPadNombre" HeaderText="GRUPO" 
                        SortExpression="GRUPO" />
                    <asp:BoundField DataField="PersonasPadEstado" HeaderText="ESTADO" 
                        SortExpression="ESTADO" Visible="False" />
                </Columns>
              <HeaderStyle BackColor="#007BFF" Font-Size="Large" ForeColor="White" 
                  HorizontalAlign="Center" VerticalAlign="Middle" />
          </asp:GridView>
          <p class="help-block"></p>
          <asp:Panel ID="Panel1" runat="server" Visible="false">
            <p class="help-block"></p>
            <table class="style4">
        <tr>
            <td class="style5" align="center">
                <asp:Label ID="Label75" runat="server" Text="4° DE FINAL" Font-Bold="True" 
                    ForeColor="#007BFF"></asp:Label>
                    <p class="help-block"></p>
            </td>
            <td class="style6" align="center">
                <asp:Label ID="Label76" runat="server" Text="SEMIFINAL" Font-Bold="True" 
                    ForeColor="#007BFF"></asp:Label>
            </td>
            <td align="center">
                <asp:Label ID="Label77" runat="server" Text="FINAL" Font-Bold="True" 
                    ForeColor="#007BFF"></asp:Label>
            </td>
           <%-- <td>
                <asp:Label ID="Label78" runat="server" Text="GANADOR"></asp:Label>
            </td>--%>
        </tr>
        <tr>
            <td class="style5">
                
            <table>
          <asp:TableHeaderRow ID="TableHeaderRow13" 
                runat="server" 
                ForeColor="Snow"
                BackColor="#007BFF"
                Font-Bold="true"
                >
                <asp:TableHeaderCell>
                    <asp:Label ID="Label79" runat="server"  Width="180px" Text="EQUIPO"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label80" runat="server" Width="50px" Text="SET 1"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label81" runat="server" Width="50px" Text="SET 2"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label82" runat="server" Width="50px" Text="SET 3"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label83" runat="server" Width="57px" Text="GANO"></asp:Label></asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow 
                ID="TableRow25" 
                runat="server" 
                BackColor="#FFFF00"
                >
                <asp:TableCell><asp:Label ID="cuarto1equipo1" runat="server" 
                    Text="EQUIPO1"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto1equipo1partido1set1" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto1equipo1partido1set2" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto1equipo1partido1set3" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto1equipo1partido1puntos" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow26" 
                runat="server" 
                BackColor="#FFFF00"
                >
                <asp:TableCell><asp:Label ID="cuarto1equipo2" runat="server"
                    Text="EQUIPO2"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto1equipo2partido1set1" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto1equipo2partido1set2" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto1equipo2partido1set3" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto1equipo2partido1puntos" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            </table>
            </td>
            <td class="style6">
                &nbsp;</td>
            <td>
                &nbsp;</td>
          <%--  <td>
                &nbsp;</td>--%>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;</td>
            <td class="style6">
                
            <table>
          <asp:TableHeaderRow ID="TableHeaderRow17" 
                runat="server" 
                ForeColor="Snow"
                BackColor="#007BFF"
                Font-Bold="true"
                >
                <asp:TableHeaderCell>
                    <asp:Label ID="Label99" runat="server"  Width="180px" Text="EQUIPO"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label100" runat="server" Width="50px" Text="SET 1"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label101" runat="server" Width="50px" Text="SET 2"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label102" runat="server" Width="50px" Text="SET 3"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label103" runat="server" Width="57px" Text="GANO"></asp:Label></asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow 
                ID="TableRow33" 
                runat="server" 
                BackColor="#FFFF00"
                >
                <asp:TableCell><asp:Label ID="semi1equipo1" runat="server" 
                    Text="EQUIPO1"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="semi1equipo1set1" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="semi1equipo1set2" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="semi1equipo1set3" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="semi1equipo1puntos" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow34" 
                runat="server" 
                BackColor="#FFFF00"
                >
                <asp:TableCell><asp:Label ID="semi1equipo2" runat="server" 
                    Text="EQUIPO2"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="semi1equipo2set1" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="semi1equipo2set2" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="semi1equipo2set3" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="semi1equipo2puntos" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            </table>
            </td>
            <td>
                &nbsp;</td>
            <%--<td>
                &nbsp;</td>--%>
        </tr>
        <tr>
            <td class="style5">
                
            <table>
          <asp:TableHeaderRow ID="TableHeaderRow14" 
                runat="server" 
                ForeColor="Snow"
                BackColor="#007BFF"
                Font-Bold="true"
                >
                <asp:TableHeaderCell>
                    <asp:Label ID="Label84" runat="server"  Width="180px" Text="EQUIPO"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label85" runat="server" Width="50px" Text="SET 1"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label86" runat="server" Width="50px" Text="SET 2"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label87" runat="server" Width="50px" Text="SET 3"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label88" runat="server" Width="57px" Text="GANO"></asp:Label></asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow 
                ID="TableRow27" 
                runat="server" 
                BackColor="#FFFF00"
                >
                <asp:TableCell><asp:Label ID="cuarto2equipo1" runat="server" 
                    Text="EQUIPO1"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto2equipo1partido1set1" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto2equipo1partido1set2" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto2equipo1partido1set3" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto2equipo1partido1puntos" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow28" 
                runat="server" 
                BackColor="#FFFF00"
                >
                <asp:TableCell><asp:Label ID="cuarto2equipo2" runat="server" 
                    Text="EQUIPO2"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto2equipo2partido1set1" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto2equipo2partido1set2" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto2equipo2partido1set3" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto2equipo2partido1puntos" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            </table>
            </td>
            <td class="style6">
                &nbsp;</td>
            <td style="text-align: center">
            </td>
            <%--<td>
                &nbsp;</td>--%>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;</td>
            <td class="style6">
                &nbsp;</td>
            <td>
                
            <table>
          <asp:TableHeaderRow ID="TableHeaderRow19" 
                runat="server" 
                ForeColor="Snow"
                BackColor="#007BFF"
                Font-Bold="true"
                >
                <asp:TableHeaderCell>
                    <asp:Label ID="Label109" runat="server"  Width="180px" Text="EQUIPO"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label110" runat="server" Width="50px" Text="SET 1"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label111" runat="server" Width="50px" Text="SET 2"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label112" runat="server" Width="50px" Text="SET 3"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label113" runat="server" Width="57px" Text="GANO"></asp:Label></asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow 
                ID="TableRow37" 
                runat="server" 
                BackColor="#FFFF00"
                >
                <asp:TableCell><asp:Label ID="finalequipo1" runat="server" 
                    Text="EQUIPO1"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="finalequipo1set1" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="finalequipo1set2" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="finalequipo1set3" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="finalequipo1puntos" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow38" 
                runat="server" 
                BackColor="#FFFF00"
                >
                <asp:TableCell><asp:Label ID="finalequipo2" runat="server" 
                    Text="EQUIPO2"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="finalequipo2set1" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="finalequipo2set2" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="finalequipo2set3" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="finalequipo2puntos" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            </table>
            </td>
           <%-- <td>
                &nbsp;</td>--%>
        </tr>
        <tr>
            <td class="style5">
                
            <table>
          <asp:TableHeaderRow ID="TableHeaderRow15" 
                runat="server" 
                ForeColor="Snow"
                BackColor="#007BFF"
                Font-Bold="true"
                >
                <asp:TableHeaderCell>
                    <asp:Label ID="Label89" runat="server"  Width="180px" Text="EQUIPO"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label90" runat="server" Width="50px" Text="SET 1"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label91" runat="server" Width="50px" Text="SET 2"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label92" runat="server" Width="50px" Text="SET 3"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label93" runat="server" Width="57px" Text="GANO"></asp:Label></asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow 
                ID="TableRow29" 
                runat="server" 
                BackColor="#FFFF00"
                >
                <asp:TableCell><asp:Label ID="cuarto3equipo1" runat="server" 
                    Text="EQUIPO1"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto3equipo1partido1set1" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto3equipo1partido1set2" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto3equipo1partido1set3" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto3equipo1partido1puntos" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow30" 
                runat="server" 
                BackColor="#FFFF00"
                >
                <asp:TableCell><asp:Label ID="cuarto3equipo2" runat="server" 
                    Text="EQUIPO2"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto3equipo2partido1set1" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto3equipo2partido1set2" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto3equipo2partido1set3" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto3equipo2partido1puntos" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            </table>
            </td>
            <td class="style6">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <%--<td>
                &nbsp;</td>--%>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;</td>
            <td class="style6">
                
            <table>
          <asp:TableHeaderRow ID="TableHeaderRow18" 
                runat="server" 
                ForeColor="Snow"
                BackColor="#007BFF"
                Font-Bold="true"
                >
                <asp:TableHeaderCell>
                    <asp:Label ID="Label104" runat="server"  Width="180px" Text="EQUIPO"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label105" runat="server" Width="50px" Text="SET 1"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label106" runat="server" Width="50px" Text="SET 2"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label107" runat="server" Width="50px" Text="SET 3"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label108" runat="server" Width="57px" Text="GANO"></asp:Label></asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow 
                ID="TableRow35" 
                runat="server" 
                BackColor="#FFFF00"
                >
                <asp:TableCell><asp:Label ID="semi2equipo1" runat="server" 
                    Text="EQUIPO1"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="semi2equipo1set1" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="semi2equipo1set2" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="semi2equipo1set3" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="semi2equipo1puntos" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow36" 
                runat="server" 
                BackColor="#FFFF00"
                >
                <asp:TableCell><asp:Label ID="semi2equipo2" runat="server" 
                    Text="EQUIPO2"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="semi2equipo2set1" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="semi2equipo2set2" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="semi2equipo2set3" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="semi2equipo2puntos" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            </table>
            </td>
            <td>
                &nbsp;</td>
           <%-- <td>
                &nbsp;</td>--%>
        </tr>
        <tr>
            <td class="style5">
                
            <table>
          <asp:TableHeaderRow ID="TableHeaderRow16" 
                runat="server" 
                ForeColor="Snow"
                BackColor="#007BFF"
                Font-Bold="true"
                >
                <asp:TableHeaderCell>
                    <asp:Label ID="Label94" runat="server"  Width="180px" Text="EQUIPO"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label95" runat="server" Width="50px" Text="SET 1"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label96" runat="server" Width="50px" Text="SET 2"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label97" runat="server" Width="50px" Text="SET 3"></asp:Label></asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label98" runat="server" Width="57px" Text="GANO"></asp:Label></asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow 
                ID="TableRow31" 
                runat="server" 
                BackColor="#FFFF00"
                >
                <asp:TableCell><asp:Label ID="cuarto4equipo1" runat="server" 
                    Text="EQUIPO1"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto4equipo1partido1set1" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto4equipo1partido1set2" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto4equipo1partido1set3" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto4equipo1partido1puntos" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow32" 
                runat="server" 
                BackColor="#FFFF00"
                >
                <asp:TableCell><asp:Label ID="cuarto4equipo2" runat="server" 
                    Text="EQUIPO2"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto4equipo2partido1set1" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto4equipo2partido1set2" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto4equipo2partido1set3" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="cuarto4equipo2partido1puntos" runat="server"  Text="0"
                    Width="30px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            </table>
            </td>
            <td class="style6">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <%--<td>
                &nbsp;</td>--%>
        </tr>
    </table>
            <p class="help-block"></p>
            </asp:Panel>
            </div>
        </div>
    </form>
</div>
</asp:Content>
