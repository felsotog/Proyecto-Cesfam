<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFichaPaciente.aspx.cs" Inherits="CapaHtml.WebFichaPaciente" %>

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
                <h2><i class="fas fa-user-injured"></i> Ficha Paciente</h2>
            </div>
                <form id="formulario_registro" class="form-check" runat="server">
                    <div>
                        <fieldset>
                           <div class="alert alert-success d-flex align-items-center" role="alert">
                              <i class="fas fa-bell" width="34" height="34" style="padding-right: 8px;"></i>
                              <div>
                                Ingresar Datos del Paciente
                              </div>
                            </div>
                            <asp:Table runat="server" Width="100%">
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label1" Text="ID Ficha:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtIdficha" placeholder="Farm1120"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="lblCalendario" Text="Fecha:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="Calendario" TextMode="Date"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label2" Text="Rut Medico:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                         <asp:DropDownList CssClass="btn btn_2" ID="DropDownListrutmedico" runat="server" DataSourceID="SqlDataSource1" DataTextField="rut_medico" DataValueField="rut_medico" Width="100%">
                                         </asp:DropDownList>
                                         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CESFAMConnectionString2 %>" SelectCommand="SELECT [rut_medico] FROM [medico]"></asp:SqlDataSource>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label3" Text="Rut Paciente:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                          <asp:DropDownList CssClass="btn btn_2" ID="DropDownList1" runat="server" DataSourceID="SqlDataSource3" DataTextField="rut" DataValueField="rut" Width="100%">
                                          </asp:DropDownList>
                                          <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:CESFAMConnectionString66 %>" SelectCommand="SELECT [rut] FROM [paciente]"></asp:SqlDataSource>
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
                            <asp:Button ID="btnGuardar" runat="server" CssClass="btn btn-primary" Text="Guardar" />
                            <asp:HyperLink ID="HyperLink1"  CssClass="btn btn-dark" runat="server" NavigateUrl="~/WebPaginaPrincipal.aspx">Volver</asp:HyperLink>
                        </div>
                    </div>
                    <div class="mt-5">
                        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="id_ficha" DataSourceID="SqlDataSource2" CssClass="table table-dark">
                             <Columns>
                                 <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                 <asp:BoundField DataField="id_ficha" HeaderText="id_ficha" ReadOnly="True" SortExpression="id_ficha" />
                                 <asp:BoundField DataField="fecha_ficha" HeaderText="fecha_ficha" SortExpression="fecha_ficha" />
                                 <asp:BoundField DataField="medico_rut_medico" HeaderText="medico_rut_medico" SortExpression="medico_rut_medico" />
                                 <asp:BoundField DataField="paciente_rut" HeaderText="paciente_rut" SortExpression="paciente_rut" />
                             </Columns>
                         </asp:GridView>
                         <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:CESFAMConnectionString65 %>" DeleteCommand="DELETE FROM [ficha_paciente] WHERE [id_ficha] = @original_id_ficha AND (([fecha_ficha] = @original_fecha_ficha) OR ([fecha_ficha] IS NULL AND @original_fecha_ficha IS NULL)) AND (([medico_rut_medico] = @original_medico_rut_medico) OR ([medico_rut_medico] IS NULL AND @original_medico_rut_medico IS NULL)) AND (([paciente_rut] = @original_paciente_rut) OR ([paciente_rut] IS NULL AND @original_paciente_rut IS NULL))" InsertCommand="INSERT INTO [ficha_paciente] ([id_ficha], [fecha_ficha], [medico_rut_medico], [paciente_rut]) VALUES (@id_ficha, @fecha_ficha, @medico_rut_medico, @paciente_rut)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [ficha_paciente]" UpdateCommand="UPDATE [ficha_paciente] SET [fecha_ficha] = @fecha_ficha, [medico_rut_medico] = @medico_rut_medico, [paciente_rut] = @paciente_rut WHERE [id_ficha] = @original_id_ficha AND (([fecha_ficha] = @original_fecha_ficha) OR ([fecha_ficha] IS NULL AND @original_fecha_ficha IS NULL)) AND (([medico_rut_medico] = @original_medico_rut_medico) OR ([medico_rut_medico] IS NULL AND @original_medico_rut_medico IS NULL)) AND (([paciente_rut] = @original_paciente_rut) OR ([paciente_rut] IS NULL AND @original_paciente_rut IS NULL))">
                             <DeleteParameters>
                                 <asp:Parameter Name="original_id_ficha" Type="String" />
                                 <asp:Parameter DbType="Date" Name="original_fecha_ficha" />
                                 <asp:Parameter Name="original_medico_rut_medico" Type="String" />
                                 <asp:Parameter Name="original_paciente_rut" Type="String" />
                             </DeleteParameters>
                             <InsertParameters>
                                 <asp:Parameter Name="id_ficha" Type="String" />
                                 <asp:Parameter DbType="Date" Name="fecha_ficha" />
                                 <asp:Parameter Name="medico_rut_medico" Type="String" />
                                 <asp:Parameter Name="paciente_rut" Type="String" />
                             </InsertParameters>
                             <UpdateParameters>
                                 <asp:Parameter DbType="Date" Name="fecha_ficha" />
                                 <asp:Parameter Name="medico_rut_medico" Type="String" />
                                 <asp:Parameter Name="paciente_rut" Type="String" />
                                 <asp:Parameter Name="original_id_ficha" Type="String" />
                                 <asp:Parameter DbType="Date" Name="original_fecha_ficha" />
                                 <asp:Parameter Name="original_medico_rut_medico" Type="String" />
                                 <asp:Parameter Name="original_paciente_rut" Type="String" />
                             </UpdateParameters>
                         </asp:SqlDataSource>
                    </div>

                    <div class="pt-5">
                        <fieldset>
                           <div class="alert alert-success d-flex align-items-center" role="alert">
                              <i class="fas fa-bell" width="34" height="34" style="padding-right: 8px;"></i>
                              <div>
                                Ingresar Datos del Detalle
                              </div>
                            </div>
                            <asp:Table runat="server" Width="100%">
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label8" Text="ID Detalle:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="TextBox4" placeholder="Camelo"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label9" Text="ID Formulario Medicamento:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                         <asp:DropDownList CssClass="btn btn_2" ID="DropDownList2" runat="server" DataSourceID="SqlDataSource4" DataTextField="id_formulario" DataValueField="id_formulario" Width="100%">
                                         </asp:DropDownList>
                                         <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:CESFAMConnectionString67 %>" SelectCommand="SELECT [id_formulario] FROM [formulario_medicamento]"></asp:SqlDataSource>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label4" Text="ID Ficha:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                          <asp:DropDownList CssClass="btn btn_2" ID="DropDownList3" runat="server" DataSourceID="SqlDataSource2" DataTextField="id_ficha" DataValueField="id_ficha" Width="100%">
                                          </asp:DropDownList>
                                          <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:CESFAMConnectionString68 %>" SelectCommand="SELECT [id_ficha] FROM [ficha_paciente]"></asp:SqlDataSource>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label5" Text="Comentarios:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <textarea class="form-control" runat="server"  id="TextAreaComentarios"  cols="20" name="S2" rows="2"></textarea>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell ColumnSpan="2">
                                        <asp:Label runat="server" CssClass="alert-danger" ID="Label10"></asp:Label>
                                        <asp:Label runat="server" CssClass="alert-success" ID="Label11"></asp:Label>
                                    </asp:TableCell>
                                </asp:TableRow>
                            </asp:Table>
                        </fieldset>
                        <br />
                        <div>
                            <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" Text="Guardar" />
                            <asp:HyperLink ID="HyperLink2"  CssClass="btn btn-dark" runat="server" NavigateUrl="~/WebPaginaPrincipal.aspx">Volver</asp:HyperLink>
                        </div>
                    </div>
                    <div class="mt-5">
                      <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id_detalle_ficha" DataSourceID="SqlDataSource6" CssClass="table table-dark">
                          <Columns>
                              <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                              <asp:BoundField DataField="id_detalle_ficha" HeaderText="id_detalle_ficha" ReadOnly="True" SortExpression="id_detalle_ficha" />
                              <asp:BoundField DataField="ficha_paciente_id_ficha" HeaderText="ficha_paciente_id_ficha" SortExpression="ficha_paciente_id_ficha" />
                              <asp:BoundField DataField="formulario_medicamento_id_formulario" HeaderText="formulario_medicamento_id_formulario" SortExpression="formulario_medicamento_id_formulario" />
                              <asp:BoundField DataField="comentarios" HeaderText="comentarios" SortExpression="comentarios" />
                          </Columns>
                      </asp:GridView>
                      <asp:SqlDataSource ID="SqlDataSource6" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:CESFAMConnectionString69 %>" DeleteCommand="DELETE FROM [detalle_ficha] WHERE [id_detalle_ficha] = @original_id_detalle_ficha AND (([ficha_paciente_id_ficha] = @original_ficha_paciente_id_ficha) OR ([ficha_paciente_id_ficha] IS NULL AND @original_ficha_paciente_id_ficha IS NULL)) AND (([formulario_medicamento_id_formulario] = @original_formulario_medicamento_id_formulario) OR ([formulario_medicamento_id_formulario] IS NULL AND @original_formulario_medicamento_id_formulario IS NULL)) AND (([comentarios] = @original_comentarios) OR ([comentarios] IS NULL AND @original_comentarios IS NULL))" InsertCommand="INSERT INTO [detalle_ficha] ([id_detalle_ficha], [ficha_paciente_id_ficha], [formulario_medicamento_id_formulario], [comentarios]) VALUES (@id_detalle_ficha, @ficha_paciente_id_ficha, @formulario_medicamento_id_formulario, @comentarios)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [detalle_ficha]" UpdateCommand="UPDATE [detalle_ficha] SET [ficha_paciente_id_ficha] = @ficha_paciente_id_ficha, [formulario_medicamento_id_formulario] = @formulario_medicamento_id_formulario, [comentarios] = @comentarios WHERE [id_detalle_ficha] = @original_id_detalle_ficha AND (([ficha_paciente_id_ficha] = @original_ficha_paciente_id_ficha) OR ([ficha_paciente_id_ficha] IS NULL AND @original_ficha_paciente_id_ficha IS NULL)) AND (([formulario_medicamento_id_formulario] = @original_formulario_medicamento_id_formulario) OR ([formulario_medicamento_id_formulario] IS NULL AND @original_formulario_medicamento_id_formulario IS NULL)) AND (([comentarios] = @original_comentarios) OR ([comentarios] IS NULL AND @original_comentarios IS NULL))">
                          <DeleteParameters>
                              <asp:Parameter Name="original_id_detalle_ficha" Type="String" />
                              <asp:Parameter Name="original_ficha_paciente_id_ficha" Type="String" />
                              <asp:Parameter Name="original_formulario_medicamento_id_formulario" Type="String" />
                              <asp:Parameter Name="original_comentarios" Type="String" />
                          </DeleteParameters>
                          <InsertParameters>
                              <asp:Parameter Name="id_detalle_ficha" Type="String" />
                              <asp:Parameter Name="ficha_paciente_id_ficha" Type="String" />
                              <asp:Parameter Name="formulario_medicamento_id_formulario" Type="String" />
                              <asp:Parameter Name="comentarios" Type="String" />
                          </InsertParameters>
                          <UpdateParameters>
                              <asp:Parameter Name="ficha_paciente_id_ficha" Type="String" />
                              <asp:Parameter Name="formulario_medicamento_id_formulario" Type="String" />
                              <asp:Parameter Name="comentarios" Type="String" />
                              <asp:Parameter Name="original_id_detalle_ficha" Type="String" />
                              <asp:Parameter Name="original_ficha_paciente_id_ficha" Type="String" />
                              <asp:Parameter Name="original_formulario_medicamento_id_formulario" Type="String" />
                              <asp:Parameter Name="original_comentarios" Type="String" />
                          </UpdateParameters>
                      </asp:SqlDataSource>
                    </div>
                </form>
        </div>
    </div>
</body>
</html>
