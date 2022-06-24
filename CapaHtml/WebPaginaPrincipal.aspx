<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebPaginaPrincipal.aspx.cs" Inherits="CapaHtml.WebPaginaPrincipal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Centro de Salud Familiar CESFAM</title>
    <!-- Font Awesome -->
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.11.2/css/all.css" />
    <!-- Google Fonts Roboto -->
    <link rel="stylesheet" href="https://fonts.googleapis.com/css2?family=Roboto:wght@300;400;500;700&display=swap" />
    <!-- MDB -->
    <link rel="stylesheet" href="css/mdb.min.css" />
    <!-- Custom styles -->
    <link rel="stylesheet" href="css/style.css" />
    <!-- Icon -->
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.8.3/font/bootstrap-icons.css" />
</head>
<body>
        <!--Main Navigation-->
    <header>
      <style>
        /* Height for devices larger than 576px */
        @media (min-width: 992px) {
          #intro {
            margin-top: -58.59px;
          }
        }

        .navbar .nav-link {
          color: #fff !important;
        }
      </style>

      <!-- Navbar -->
      <nav class="navbar navbar-expand-lg navbar-dark d-none d-lg-block" style="z-index: 2000;">
        <div class="container-fluid">
          <!-- Navbar brand -->
          <a class="navbar-brand nav-link" target="_blank" href="Index.html">
            <strong>CESFAM</strong>
          </a>
          <button class="navbar-toggler" type="button" data-mdb-toggle="collapse" data-mdb-target="#navbarExample01"
            aria-controls="navbarExample01" aria-expanded="false" aria-label="Toggle navigation">
            <i class="fas fa-bars"></i>
          </button>
          <div class="collapse navbar-collapse" id="navbarExample01">
            <ul class="navbar-nav me-auto mb-2 mb-lg-0">
              <li class="nav-item">
                <a class="nav-link" href="WebAgendamiento.aspx" rel="nofollow">Agendamiento</a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="WebFarmacia.aspx">Farmacia</a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="WebIngresoMedicamento.aspx">Ingreso Medicamento</a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="Crud_4.html">CRUD_4</a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="Crud_5.html">CRUD_4</a>
              </li>
            </ul>

            <ul class="navbar-nav d-flex flex-row">
              <!-- Icons -->
              <li class="nav-item me-3 me-lg-0">
                <a class="nav-link" href="https://www.youtube.com/channel/UC5CF7mLQZhvx8O5GODZAhdA" rel="nofollow"
                  target="_blank">
                  <i class="fab fa-youtube"></i>
                </a>
              </li>
              <li class="nav-item me-3 me-lg-0">
                <a class="nav-link" href="https://www.facebook.com/mdbootstrap" rel="nofollow" target="_blank">
                  <i class="fab fa-facebook-f"></i>
                </a>
              </li>
              <li class="nav-item me-3 me-lg-0">
                <a class="nav-link" href="https://twitter.com/MDBootstrap" rel="nofollow" target="_blank">
                  <i class="fab fa-twitter"></i>
                </a>
              </li>
              <li class="nav-item me-3 me-lg-0">
                <a class="nav-link" href="https://github.com/mdbootstrap/mdb-ui-kit" rel="nofollow" target="_blank">
                  <i class="fab fa-github"></i>
                </a>
              </li>
            </ul>
          </div>
        </div>
      </nav>
      <!-- Navbar -->

      <!-- Background image -->
      <div id="intro" class="bg-image vh-100 shadow-1-strong">
        <div class="mask">
          <div class="container d-flex align-items-center justify-content-center text-center h-100">
            <div class="text-white">
              <img src="img/logo_index.png" alt="LOGO" class="img_title">
              <br><br>
              <h1 class="mb-3 title_index">CRUDs CESFAM</h1>
              <h7 class="mb-4">Lorem Ipsum es simplemente el texto de relleno de las imprentas y archivos de texto. Lorem Ipsum ha sido el texto de relleno estándar de las industrias desde el año 1500, cuando un impresor (N. del T. persona que se dedica a la imprenta) desconocido usó una galería de textos y los mezcló de tal manera que logró hacer un libro de textos especimen. </h7><br><br><br>
              <a href="WebAgendamiento.aspx"><button type="button" class="btn btn-primary btn-lg"><i class="bi bi-arrow-right-short"></i> Agendamiento</button></a>
              <a href="WebFarmacia.aspx"><button type="button" class="btn btn-primary btn-lg"><i class="bi bi-arrow-right-short"></i> Farmacia</button></a>
              <a href="WebIngresoMedicamento.aspx"><button type="button" class="btn btn-primary btn-lg"><i class="bi bi-arrow-right-short"></i> Ingreso Medicamento</button></a>
              <a href="Crud_4.html"><button type="button" class="btn btn-primary btn-lg"><i class="bi bi-arrow-right-short"></i> Crud 4</button></a>
              <a href="Crud_5.html"><button type="button" class="btn btn-primary btn-lg"><i class="bi bi-arrow-right-short"></i> Crud 5</button></a>
              <a href="Crud_1.html"><button type="button" class="btn btn-primary btn-lg"><i class="bi bi-arrow-right-short"></i> Crud 1</button></a>
              <a href="Crud_2.html"><button type="button" class="btn btn-primary btn-lg"><i class="bi bi-arrow-right-short"></i> Crud 2</button></a>
              <a href="Crud_3.html"><button type="button" class="btn btn-primary btn-lg"><i class="bi bi-arrow-right-short"></i> Crud 3</button></a>
              <a href="Crud_4.html"><button type="button" class="btn btn-primary btn-lg"><i class="bi bi-arrow-right-short"></i> Crud 4</button></a>
              <a href="Crud_5.html"><button type="button" class="btn btn-primary btn-lg"><i class="bi bi-arrow-right-short"></i> Crud 5</button></a>
            </div>
          </div>
        </div>
      </div>
      <!-- Background image -->
    </header>
    <!--Main Navigation-->

      <!-- Copyright -->
      <div class="text-center p-3" style="background-color: rgba(0, 0, 0, 0.2);">
        © 2020 Copyright:
        <a class="text-dark" href="#">CrudCESFAM.cl</a>
      </div>
      <!-- Copyright -->
    <footer>
    <!--Footer-->
    <!-- MDB -->
    <script type="text/javascript" src="js/mdb.min.js"></script>
    <!-- Custom scripts -->
    <script type="text/javascript" src="js/script.js"></script>
    </footer>
</body>
</html>
