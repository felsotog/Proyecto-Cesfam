﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFarmacia.aspx.cs" Inherits="CapaHtml.WebFarmacia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Farmacia</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0/dist/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <link rel="stylesheet" type="text/css" href="css/style.css"/>
    <!-- Icon -->
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.8.3/font/bootstrap-icons.css" />
    <!-- Font Awesome -->
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.11.2/css/all.css" />
    <!-- MDB -->
    <link rel="stylesheet" href="css/mdb.min.css" />
    <!-- Custom styles -->
    <link rel="stylesheet" href="css/style.css" />
</head>
<body class="form-control bg-light">
      <!-- Navbar -->
      <nav class="navbar navbar-expand-lg navbar-dark d-none d-lg-block" style="z-index: 2000;">
        <div class="container-fluid">
          <!-- Navbar brand -->
          <a class="navbar-brand nav-link" target="_blank" href="WebPaginaPrincipal.aspx">
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
                <a class="nav-link" href="WebFichaPaciente.aspx">Ficha Paciente</a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="WebMedicamento.aspx">Medicamento</a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="WebMedico.aspx">Medico</a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="WebPaciente.aspx">Paciente</a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="WebFarmaceuta.aspx">Farmaceuta</a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="WebFormularioMedicamento.aspx">Receta medica</a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="WebReservaMedicamento.aspx">Reservacion Medicamento</a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="WebSalidaMedicamento.aspx">Entrega Medicamento</a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="WebCaducarMedicamento.aspx">Merma</a>
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

    <div class="container small example_container">
        <div class="row">
            <div class="title">
                <h2><i class="fas fa-clinic-medical"></i> Formulario Farmacia</h2>
            </div>
                <form id="formulario_registro" class="form-check" runat="server">
                    <div>
                        <fieldset>
                           <div class="alert alert-success d-flex align-items-center" role="alert">
                              <i class="fas fa-bell" width="34" height="34" style="padding-right: 8px;"></i>
                              <div>
                                Ingresar Datos de la farmacia
                              </div>
                            </div>
                            <asp:Table runat="server" Width="100%">
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label1" Text="ID Farmacia:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtIdFarmacia" placeholder="Farm1120"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label2" Text="Nombre Farmacia:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtNombreFarmacia" placeholder="Camelo"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell ColumnSpan="2">
                                        <asp:Label runat="server" CssClass="alert-danger" ID="lblError"></asp:Label>
                                        <asp:Label runat="server" CssClass="alert-success" ID="lblSucces"></asp:Label>
                                    </asp:TableCell>
                                </asp:TableRow>
                            </asp:Table>
                        </fieldset>
                        <br />
                        <div>
                            <asp:Button ID="btnFarmacia" runat="server" CssClass="btn btn-primary" Text="Guardar" OnClick="btnFarmacia_Click"/>
                            <asp:Button ID="Volver" runat="server" CssClass="btn btn-dark" Text="Volver" OnClick="Volver_Click"/>
                        </div>
                    </div>

                    <div class="mt-5">
                         <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="id_farmacia" DataSourceID="SqlDataSource1" CssClass="table table-dark">
                              <Columns>
                                  <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                  <asp:BoundField DataField="id_farmacia" HeaderText="id_farmacia" ReadOnly="True" SortExpression="id_farmacia" />
                                  <asp:BoundField DataField="nombre_farmacia" HeaderText="nombre_farmacia" SortExpression="nombre_farmacia" />
                              </Columns>
                          </asp:GridView>
                          <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:CESFAMConnectionString22 %>" DeleteCommand="DELETE FROM [farmacia] WHERE [id_farmacia] = @original_id_farmacia AND (([nombre_farmacia] = @original_nombre_farmacia) OR ([nombre_farmacia] IS NULL AND @original_nombre_farmacia IS NULL))" InsertCommand="INSERT INTO [farmacia] ([id_farmacia], [nombre_farmacia]) VALUES (@id_farmacia, @nombre_farmacia)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [farmacia]" UpdateCommand="UPDATE [farmacia] SET [nombre_farmacia] = @nombre_farmacia WHERE [id_farmacia] = @original_id_farmacia AND (([nombre_farmacia] = @original_nombre_farmacia) OR ([nombre_farmacia] IS NULL AND @original_nombre_farmacia IS NULL))">
                              <DeleteParameters>
                                  <asp:Parameter Name="original_id_farmacia" Type="String" />
                                  <asp:Parameter Name="original_nombre_farmacia" Type="String" />
                              </DeleteParameters>
                              <InsertParameters>
                                  <asp:Parameter Name="id_farmacia" Type="String" />
                                  <asp:Parameter Name="nombre_farmacia" Type="String" />
                              </InsertParameters>
                              <UpdateParameters>
                                  <asp:Parameter Name="nombre_farmacia" Type="String" />
                                  <asp:Parameter Name="original_id_farmacia" Type="String" />
                                  <asp:Parameter Name="original_nombre_farmacia" Type="String" />
                              </UpdateParameters>
                          </asp:SqlDataSource>
                    </div>
                </form>
        </div>
    </div>
</body>
</html>