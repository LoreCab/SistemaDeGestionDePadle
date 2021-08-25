<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pago_Deuda.aspx.cs" Inherits="Sistema_de_Gestion_de_Padel.Pago_Deuda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
<div class="container">
<h1 class="mt-4 mb-3">Pagar Deuda</h1>
      <form name="PagoDeuda" id="PagoForm" novalidate>
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
            <asp:Panel ID="Panel1" runat="server" Visible="False">
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
                </div>
                <div>
                    <asp:Label ID="Label1" runat="server" Text="Total deuda: " 
                        class= "mt-4 mb-3 text-primary"></asp:Label>
                    <asp:Label ID="Label6" runat="server" class= "mt-4 mb-3"></asp:Label>
                </div>
                <p class="help-block"></p>
                </div>
                <div class="controls">
                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                Align="Center" Font-Size="Large" HorizontalAlign="Center" 
                                onselectedindexchanged="GridView1_SelectedIndexChanged" 
                                DataKeyNames="PersonasPadId">
                                <Columns>
                                    <asp:BoundField DataField="PersonasPadId" HeaderText="Cod de Reserva" 
                                        Visible="False" />
                                    <asp:BoundField HeaderText="Fecha" DataField="PersonasPAdApellido" />
                                    <asp:BoundField HeaderText="Hora" DataField="PersonasPadDni" />
                                    <asp:BoundField HeaderText="Cancha" DataField="PersonasPadNombre" />
                                    <asp:CommandField ShowSelectButton="True" />
                                </Columns>

                            </asp:GridView>
                            <p class="help-block"></p>
                        </div>
            </asp:Panel>
            <asp:Panel ID="Panel2" runat="server" Visible="False">
                <div class="controls">
                    <label>Fecha de la reserva:</label>
                    <asp:Label ID="Label8" runat="server" Text="" style="font-weight: 700"></asp:Label>
                    <p class="help-block"></p>
                    <label>Hora de la reserva:</label>
                    <asp:TextBox ID="TextBoxHoraR" runat="server" class="form-control" maxlength="8" onKeypress="if (event.keyCode < 48 || event.keyCode > 57) event.returnValue = false;" required data-validation-required-message="Por favor ingrese el dni."></asp:TextBox>
                    <p class="help-block"></p>
                    <label>Cancha:</label>
                    <asp:TextBox ID="TextBoxCanchaR" runat="server" class="form-control" maxlength="8" onKeypress="if (event.keyCode < 48 || event.keyCode > 57) event.returnValue = false;" required data-validation-required-message="Por favor ingrese el dni."></asp:TextBox>
                    <p class="help-block"></p>
                </div>
                <div class="controls">
                    <label>Desea pagar esta deuda?</label> 
                    <asp:Label ID="Label7" runat="server" style="font-weight: 700; color: #FF0000"></asp:Label>
                    <asp:DropDownList ID="DropDownList1" runat="server" class="form-control">
                        <asp:ListItem>SELECCIONE</asp:ListItem>
                        <asp:ListItem Value="1">SI</asp:ListItem>
                        <asp:ListItem Value="0">NO</asp:ListItem>
                    </asp:DropDownList>
                <p class="help-block"></p>
                </div>
                <div class="row">
                    <div class="col-lg-4 mb-4">
                        <asp:Button ID="ButtonPago" class="btn btn-lg btn-primary btn-block" 
                            runat="server" Text="Realizar Pago" onclick="ButtonPago_Click"/>
                    </div>
                <p class="help-block"></p>
                </div>
            </asp:Panel>
            </div>
        
        

      </form>
</div>
</asp:Content>
