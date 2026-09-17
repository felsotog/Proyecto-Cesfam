<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebPaginaPrincipal.aspx.cs" CodePage="65001" Inherits="CapaHtml.WebPaginaPrincipal" %>

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
    <link rel="stylesheet" type="text/css" href="css/style.css"/>
    <link rel="stylesheet" href="css/modern-shell.css" />
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



      <!-- Background image -->
      <div id="intro" class="bg-image vh-100 shadow-1-strong">
        <div class="mask">
          <div class="container d-flex align-items-center justify-content-center text-center h-100">
            <div class="text-white box_mr">
              <img src="img/logo_index.png" alt="LOGO" class="img_title">
              <br><br>
              <h1 class="mb-3 title_index">CRUDs CESFAM</h1>
              <h7 class="mb-4">Lorem Ipsum es simplemente el texto de relleno de las imprentas y archivos de texto. Lorem Ipsum ha sido el texto de relleno estándar de las industrias desde el año 1500, cuando un impresor (N. del T. persona que se dedica a la imprenta) desconocido usó una galería de textos y los mezcló de tal manera que logró hacer un libro de textos especimen. </h7><br><br><br>
              <a href="WebAgendamiento.aspx"><button type="button" class="btn btn-primary btn-lg mb-3"><i class="bi bi-arrow-right-short"></i> Agendamiento</button></a>
              <a href="WebFarmacia.aspx"><button type="button" class="btn btn-primary btn-lg mb-3"><i class="bi bi-arrow-right-short"></i> Farmacia</button></a>
              <a href="WebIngresoMedicamento.aspx"><button type="button" class="btn btn-primary btn-lg mb-3"><i class="bi bi-arrow-right-short"></i> Ingreso Medicamento</button></a>
              <a href="WebFichaPaciente.aspx"><button type="button" class="btn btn-primary btn-lg mb-3"><i class="bi bi-arrow-right-short"></i> Ficha Paciente</button></a>
              <a href="WebMedicamento.aspx"><button type="button" class="btn btn-primary btn-lg mb-3"><i class="bi bi-arrow-right-short"></i> Medicamento</button></a>
              <a href="WebMedico.aspx"><button type="button" class="btn btn-primary btn-lg mb-3"><i class="bi bi-arrow-right-short"></i> Medico</button></a>
              <a href="WebPaciente.aspx"><button type="button" class="btn btn-primary btn-lg mb-3"><i class="bi bi-arrow-right-short"></i> Paciente</button></a>
              <a href="WebReservaMedicamento.aspx"><button type="button" class="btn btn-primary btn-lg mb-3"><i class="bi bi-arrow-right-short"></i> Reserva Medicamento</button></a>
              <a href="WebSalidaMedicamento.aspx"><button type="button" class="btn btn-primary btn-lg mb-3"><i class="bi bi-arrow-right-short"></i> Entrega Medicamento</button></a>
              <a href="WebCaducarMedicamento.aspx"><button type="button" class="btn btn-primary btn-lg mb-3"><i class="bi bi-arrow-right-short"></i> Merma</button></a>
              <a href="WebPacientesApi.html"><button type="button" class="btn btn-primary btn-lg mb-3"><i class="bi bi-arrow-right-short"></i> Pacientes API</button></a>
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
    <script src="js/modern-shell.js"></script>
</body>
</html>
