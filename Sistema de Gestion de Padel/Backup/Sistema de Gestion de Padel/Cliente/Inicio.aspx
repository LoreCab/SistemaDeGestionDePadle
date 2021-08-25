<%@ Page Title="" Language="C#" MasterPageFile="~/Cliente/SiteCliente.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Sistema_de_Gestion_de_Padel.Cliente.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
<header>

    <!-- Inicio Carrusel -->
      <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
        <ol class="carousel-indicators">
          <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
          <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
          <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
        </ol>
        <div class="carousel-inner" role="listbox">
          <!-- Slide One - Set the background image for this slide in the line below -->
          <div class="carousel-item active" style="background-image: url('https://barcelona4seasons.files.wordpress.com/2015/01/padel-raquette.jpg?w=1200')">
          </div>
          <!-- Slide Two - Set the background image for this slide in the line below -->
          <div class="carousel-item" style="background-image: url('https://clswebsite.azureedge.net/media/729928/padel_tennis.jpg')">
          </div>
          <!-- Slide Three - Set the background image for this slide in the line below -->
          <div class="carousel-item" style="background-image: url('http://procesacasas.com/wp-content/uploads/2017/08/4-CANCHA-DE-PADEL.jpg')">
          </div>
        </div>
        <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
          <span class="carousel-control-prev-icon" aria-hidden="true"></span>
          <span class="sr-only">Previous</span>
        </a>
        <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
          <span class="carousel-control-next-icon" aria-hidden="true"></span>
          <span class="sr-only">Next</span>
        </a>
      </div>
    </header>
    <!-- Fin Carrousel -->


    <!-- Page Content -->
    <div class="container">
      <!-- Portfolio Section -->
      <h1 class="mt-4 mb-3">Novedades</h1>

      <div class="row">
        <div class="col-lg-4 col-sm-6 portfolio-item">
          <div class="card h-100">
            <a href="#"><img class="card-img-top" width="700px" height="200px" src="https://www.padelnuestro.com/blog/wp-content/uploads/circuito-padel-nuestro-siux.png" alt=""></a>
            <div class="card-body">
              <h4 class="card-title">
                <a class="mt-4 mb-3 text-primary">Socios</a>
              </h4>
              <p class="card-text">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Amet numquam aspernatur eum quasi sapiente nesciunt? Voluptatibus sit, repellat sequi itaque deserunt, dolores in, nesciunt, illum tempora ex quae? Nihil, dolorem!</p>
            </div>
          </div>
        </div>
        <div class="col-lg-4 col-sm-6 portfolio-item">
          <div class="card h-100">
            <a href="#"><img class="card-img-top" width="700px" height="200px" src="https://padeladdict.com/wp-content/uploads/2016/03/tipos-jugadores-padel.jpg" alt=""></a>
            <div class="card-body">
              <h4 class="card-title">
                <a class="mt-4 mb-3 text-primary">Torneos</a>
              </h4>
              <p class="card-text" align="justify">¿Queres participar de nuestros torneos? Entrá y enterate de todas las fechas de nuestros torneos</p>
              <a class="btn btn-lg btn-primary btn-block" href="#">Conoce las fechas</a>
            </div>
          </div>
        </div>
        <div class="col-lg-4 col-sm-6 portfolio-item">
          <div class="card h-100">
            <a href="#"><img class="card-img-top" width="700px" height="200px" src="https://welcometoibiza.com/wp-content/uploads/2018/01/Pistas-de-Padel-en-Ibiza-07.jpg" alt=""></a>
            <div class="card-body">
              <h4 class="card-title">
                <a href="#">Reglamento</a>
              </h4>
              <p class="card-text" align="justify">Ponemos a tu disposicion el reglamento oficial de la APA - Asociación de Padel Argentina</p>
               <a class="btn btn-lg btn-primary btn-block" href="http://www.arbialsoft.com.ar/reglam/reglamento_padel.pdf">Echarle un vistazo</a>
            </div>
          </div>
        </div>
      </div>
      <!-- /.row -->

     <hr>

      <!-- Call to Action Section 
      <div class="row mb-4">
        <div class="col-md-8">
          <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Molestias, expedita, saepe, vero rerum deleniti beatae veniam harum neque nemo praesentium cum alias asperiores commodi.</p>
        </div>
        <div class="col-md-4">
          <a class="btn btn-lg btn-secondary btn-block" href="#">Call to Action</a>
        </div>
      </div>-->

    </div>
    <!-- /.container -->
</asp:Content>
