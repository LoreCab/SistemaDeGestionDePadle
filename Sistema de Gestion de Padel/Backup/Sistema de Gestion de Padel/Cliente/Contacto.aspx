<%@ Page Title="" Language="C#" MasterPageFile="~/Cliente/SiteCliente.Master" AutoEventWireup="true" CodeBehind="Contacto.aspx.cs" Inherits="Sistema_de_Gestion_de_Padel.Cliente.Contacto" %>
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
          <iframe width="100%" height="400px" frameborder="0" scrolling="no" marginheight="0" marginwidth="0" src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d4586.097110703748!2d-65.32513696798497!3d-24.172162769470447!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0x77e53e79a007e84a!2sMilisenda+Tennis!5e0!3m2!1ses!2sar!4v1535071044796" width="600" height="450" frameborder="0" style="border:0" allowfullscreen>"></iframe>                                                                                                          
        </div>
        <!-- Contact Details Column -->
        <div class="col-lg-4 mb-4">
          <h3>Detalles de Contacto</h3>
          <p>
            El Ceibo 350 
            <br>San Salvador de Jujuy, CP 4600
            <br>
          </p>
          <p>
            <abbr title="Telefono">T</abbr>: (0388) 429-1587
          </p>
          <p>
            <abbr title="E-mail">E</abbr>:
            <a href="gonza_vallejos_91@hotmail.com">milisenda.tenis@gmail.com
            </a>
          </p>
          <p>
            <abbr title="Horarios">H</abbr>: Lunes - Sabado: 9:00 AM a 5:00 PM
          </p>
        </div>
      </div>
      <!-- /.row -->

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
