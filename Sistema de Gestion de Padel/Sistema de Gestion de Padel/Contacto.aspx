<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contacto.aspx.cs" Inherits="Sistema_de_Gestion_de_Padel.Contacto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
<div class="container">
        <h1 class="mt-4 mb-3">Contacto</h1>
        <!-- Content Row -->
      <div class="row">
        <!-- Map Column -->
        <div class="col-lg-8 mb-4">
          <!-- Embedded Google Map -->

          <iframe width="100%" height="400px" frameborder="0" scrolling="no" marginheight="0" marginwidth="0" src="https://goo.gl/maps/mp9F5qgqnVU6ui5E6" width="600" height="450" frameborder="0" style="border:0" allowfullscreen>"></iframe>                                                                                                          
        </div>
        <!-- Contact Details Column -->
        <div class="col-lg-4 mb-4">
          <h3>Detalles de Contacto</h3>
          <p>
            La Afata 2864 
            <br>San Salvador de Jujuy, CP 4600
            <br>
          </p>
          <p>
            <abbr title="Telefono">T</abbr>: 3885084692
          </p>
          <p>
            <abbr title="E-mail">E</abbr>:
            <a href="andreacaballero86@gmail.com">lospinospadel@gmail.com
            </a>
          </p>
          <p>
            <abbr title="Horarios">H</abbr>: Lunes - Sabado: 9:00 AM a 5:00 PM
          </p>
        </div>
      </div>

      <!-- Contact Form -->
      <!-- In order to set the email address and subject line for the contact form go to the bin/contact_me.php file. -->
      <div class="row">
        <div class="col-lg-8 mb-4">
          <h3>Envíanos un mensaje</h3>
          <form name="sentMessage" id="contactForm" novalidate>
            <div class="control-group form-group">
              <div class="controls">
                <label>Nombre Completo:</label>
                <input type="text" class="form-control" id="name" required data-validation-required-message="Por favor ingrese su nombre.">
                <p class="help-block"></p>
              </div>
            </div>
            <div class="control-group form-group">
              <div class="controls">
                <label>Número de Telefono:</label>
                <input type="tel" class="form-control" id="phone" required data-validation-required-message="Por favor ingrese su número de telefono.">
              </div>
            </div>
            <div class="control-group form-group">
              <div class="controls">
                <label>Dirección de Email:</label>
                <input type="email" class="form-control" id="email" required data-validation-required-message="Por favor ingrese su e-mail.">
              </div>
            </div>
            <div class="control-group form-group">
              <div class="controls">
                <label>Mensaje:</label>
                <textarea rows="10" cols="100" class="form-control" id="message" required data-validation-required-message="Please enter your message" maxlength="999" style="resize:none"></textarea>
              </div>
            </div>
            <div id="success"></div>
            <!-- For success/fail messages -->
            <button type="submit" class="btn btn-primary" id="sendMessageButton">Enviar</button>
          </form>
        </div>

      </div>
      <!-- /.row -->
    </div>
</asp:Content>
