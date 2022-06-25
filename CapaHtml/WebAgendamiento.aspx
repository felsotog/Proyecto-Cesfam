<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebAgendamiento.aspx.cs" Inherits="CapaHtml.WebAgendamiento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Agendamiento</title>
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
               <h2><i class="fas fa-calendar-check"></i> Formulario Agendamiento</h2>
            </div>
            <div class="col">
                <form id="formulario_registro" class="form-check" runat="server">
                    <div>
                        <fieldset>
                          <div class="alert alert-success d-flex align-items-center" role="alert">
                              <i class="fas fa-bell" width="34" height="34" style="padding-right: 8px;"></i>
                              <div>
                                Ingresar Datos de Agendamiento de Hora
                              </div>
                            </div>
                            <asp:Table runat="server" Width="100%">
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="lblNombres" Text="ID Agendamiento:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtIdAgendamiento" placeholder="AA1111"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="lblCalendario" Text="Horario:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="Calendario" TextMode="Date"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label1" Text="Rut Medico:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtRutMedico" placeholder="1-8"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label2" Text="Rut Paciente:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtRutPaciente" placeholder="1-9"></asp:TextBox>
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
                            <asp:Button ID="btnAgendar1" runat="server" CssClass="btn btn-primary" Text="Agendar" OnClick="btnAgendar_Click"/>
                            <asp:Button ID="Volver" runat="server" CssClass="btn btn-dark" Text="Volver" OnClick="Volver_Click" />
                        </div>
                    </div>

                    <div class="mt-5">
                         <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="id_agendamiento" DataSourceID="SqlDataSource1" CssClass="table table-dark">
                              <Columns>
                                  <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                  <asp:BoundField DataField="id_agendamiento" HeaderText="ID Agendamiento" ReadOnly="True" SortExpression="id_agendamiento" />
                                  <asp:BoundField DataField="horario" HeaderText="Horario" SortExpression="horario" />
                                  <asp:BoundField DataField="paciente_rut" HeaderText="Rut Paciente" ReadOnly="True" SortExpression="paciente_rut" />
                                  <asp:BoundField DataField="medico_rut_medico" HeaderText="Rut Medico" ReadOnly="True" SortExpression="medico_rut_medico" />
                              </Columns>
                          </asp:GridView>
                          <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:CESFAMConnectionString19 %>" DeleteCommand="DELETE FROM [agendamiento] WHERE [id_agendamiento] = @original_id_agendamiento AND (([horario] = @original_horario) OR ([horario] IS NULL AND @original_horario IS NULL)) AND (([paciente_rut] = @original_paciente_rut) OR ([paciente_rut] IS NULL AND @original_paciente_rut IS NULL)) AND (([medico_rut_medico] = @original_medico_rut_medico) OR ([medico_rut_medico] IS NULL AND @original_medico_rut_medico IS NULL))" InsertCommand="INSERT INTO [agendamiento] ([id_agendamiento], [horario], [paciente_rut], [medico_rut_medico]) VALUES (@id_agendamiento, @horario, @paciente_rut, @medico_rut_medico)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [agendamiento]" UpdateCommand="UPDATE [agendamiento] SET [horario] = @horario, [paciente_rut] = @paciente_rut, [medico_rut_medico] = @medico_rut_medico WHERE [id_agendamiento] = @original_id_agendamiento AND (([horario] = @original_horario) OR ([horario] IS NULL AND @original_horario IS NULL)) AND (([paciente_rut] = @original_paciente_rut) OR ([paciente_rut] IS NULL AND @original_paciente_rut IS NULL)) AND (([medico_rut_medico] = @original_medico_rut_medico) OR ([medico_rut_medico] IS NULL AND @original_medico_rut_medico IS NULL))">
                              <DeleteParameters>
                                  <asp:Parameter Name="original_id_agendamiento" Type="String" />
                                  <asp:Parameter DbType="Date" Name="original_horario" />
                                  <asp:Parameter Name="original_paciente_rut" Type="String" />
                                  <asp:Parameter Name="original_medico_rut_medico" Type="String" />
                              </DeleteParameters>
                              <InsertParameters>
                                  <asp:Parameter Name="id_agendamiento" Type="String" />
                                  <asp:Parameter DbType="Date" Name="horario" />
                                  <asp:Parameter Name="paciente_rut" Type="String" />
                                  <asp:Parameter Name="medico_rut_medico" Type="String" />
                              </InsertParameters>
                              <UpdateParameters>
                                  <asp:Parameter DbType="Date" Name="horario" />
                                  <asp:Parameter Name="paciente_rut" Type="String" />
                                  <asp:Parameter Name="medico_rut_medico" Type="String" />
                                  <asp:Parameter Name="original_id_agendamiento" Type="String" />
                                  <asp:Parameter DbType="Date" Name="original_horario" />
                                  <asp:Parameter Name="original_paciente_rut" Type="String" />
                                  <asp:Parameter Name="original_medico_rut_medico" Type="String" />
                              </UpdateParameters>
                          </asp:SqlDataSource>
                    </div>
                </form>
            </div>
        </div>
    </div>
</body>
</html>