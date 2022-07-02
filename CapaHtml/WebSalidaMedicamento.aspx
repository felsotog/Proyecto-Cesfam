<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebSalidaMedicamento.aspx.cs" Inherits="CapaHtml.WebSalidaMedicamento" %>

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
                <h2><i class="fas fa-hand-holding-heart"></i> Entrega Medicamento</h2>
            </div>
                <form id="formulario_registro" class="form-check" runat="server">
                    <div>
                        <fieldset>
                            <div class="alert alert-success d-flex align-items-center" role="alert">
                              <i class="fas fa-bell" width="34" height="34" style="padding-right: 8px;"></i>
                              <div>
                                Ingresar Datos del Medicamento
                              </div>
                            </div>
                            <asp:Table runat="server" Width="100%">
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label1" Text="ID Entrega:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtIdsalida" placeholder=""></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="lblCalendario" Text="Fecha:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtFechasalida" TextMode="Date"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label2" Text="Rut Farmaceuta:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:DropDownList CssClass="btn btn_2" ID="DropDownListRutFarm" runat="server" DataSourceID="SqlDataSource1" DataTextField="id_farmaceuta" DataValueField="id_farmaceuta" Width="100%">
                                        </asp:DropDownList>
                                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CESFAMConnectionString15 %>" SelectCommand="SELECT [id_farmaceuta] FROM [farmaceutico]"></asp:SqlDataSource>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label5" Text="Rut Paciente:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                         <asp:DropDownList CssClass="btn btn_2" ID="DropDownListRutP" runat="server" DataSourceID="SqlDataSource3" DataTextField="rut" DataValueField="rut" Width="100%">
                                         </asp:DropDownList>
                                         <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:CESFAMConnectionString74 %>" SelectCommand="SELECT [rut] FROM [paciente]"></asp:SqlDataSource>
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
                            <asp:Button ID="btnGuardar" runat="server" CssClass="btn btn-primary" Text="Guardar" OnClick="btnGuardar_Click1"/>
                            <asp:HyperLink ID="HyperLink1"  CssClass="btn btn-dark" runat="server" NavigateUrl="~/WebPaginaPrincipal.aspx">Volver</asp:HyperLink>
                        </div>
                    </div>
                    <div class="mt-5">
                     <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id_salida" DataSourceID="SqlDataSource2" CssClass="table table-dark">
                          <Columns>
                              <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                              <asp:BoundField DataField="id_salida" HeaderText="id_salida" ReadOnly="True" SortExpression="id_salida" />
                              <asp:BoundField DataField="fecha_salida" HeaderText="fecha_salida" SortExpression="fecha_salida" />
                              <asp:BoundField DataField="farmaceutico_id_farmaceuta" HeaderText="farmaceutico_id_farmaceuta" ReadOnly="True" SortExpression="farmaceutico_id_farmaceuta" />
                              <asp:BoundField DataField="paciente_rut" HeaderText="paciente_rut" ReadOnly="True" SortExpression="paciente_rut" />
                          </Columns>
                      </asp:GridView>
                      <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:CESFAMConnectionString43 %>" DeleteCommand="DELETE FROM [salida_medicamento] WHERE [id_salida] = @original_id_salida AND (([fecha_salida] = @original_fecha_salida) OR ([fecha_salida] IS NULL AND @original_fecha_salida IS NULL)) AND (([farmaceutico_id_farmaceuta] = @original_farmaceutico_id_farmaceuta) OR ([farmaceutico_id_farmaceuta] IS NULL AND @original_farmaceutico_id_farmaceuta IS NULL)) AND (([paciente_rut] = @original_paciente_rut) OR ([paciente_rut] IS NULL AND @original_paciente_rut IS NULL))" InsertCommand="INSERT INTO [salida_medicamento] ([id_salida], [fecha_salida], [farmaceutico_id_farmaceuta], [paciente_rut]) VALUES (@id_salida, @fecha_salida, @farmaceutico_id_farmaceuta, @paciente_rut)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [salida_medicamento]" UpdateCommand="UPDATE [salida_medicamento] SET [fecha_salida] = @fecha_salida, [farmaceutico_id_farmaceuta] = @farmaceutico_id_farmaceuta, [paciente_rut] = @paciente_rut WHERE [id_salida] = @original_id_salida AND (([fecha_salida] = @original_fecha_salida) OR ([fecha_salida] IS NULL AND @original_fecha_salida IS NULL)) AND (([farmaceutico_id_farmaceuta] = @original_farmaceutico_id_farmaceuta) OR ([farmaceutico_id_farmaceuta] IS NULL AND @original_farmaceutico_id_farmaceuta IS NULL)) AND (([paciente_rut] = @original_paciente_rut) OR ([paciente_rut] IS NULL AND @original_paciente_rut IS NULL))">
                          <DeleteParameters>
                              <asp:Parameter Name="original_id_salida" Type="String" />
                              <asp:Parameter DbType="Date" Name="original_fecha_salida" />
                              <asp:Parameter Name="original_farmaceutico_id_farmaceuta" Type="String" />
                              <asp:Parameter Name="original_paciente_rut" Type="String" />
                          </DeleteParameters>
                          <InsertParameters>
                              <asp:Parameter Name="id_salida" Type="String" />
                              <asp:Parameter DbType="Date" Name="fecha_salida" />
                              <asp:Parameter Name="farmaceutico_id_farmaceuta" Type="String" />
                              <asp:Parameter Name="paciente_rut" Type="String" />
                          </InsertParameters>
                          <UpdateParameters>
                              <asp:Parameter DbType="Date" Name="fecha_salida" />
                              <asp:Parameter Name="farmaceutico_id_farmaceuta" Type="String" />
                              <asp:Parameter Name="paciente_rut" Type="String" />
                              <asp:Parameter Name="original_id_salida" Type="String" />
                              <asp:Parameter DbType="Date" Name="original_fecha_salida" />
                              <asp:Parameter Name="original_farmaceutico_id_farmaceuta" Type="String" />
                              <asp:Parameter Name="original_paciente_rut" Type="String" />
                          </UpdateParameters>
                      </asp:SqlDataSource>
                    </div>

                    <div class="mt-5">
                        <fieldset>
                            <div class="alert alert-success d-flex align-items-center" role="alert">
                              <i class="fas fa-bell" width="34" height="34" style="padding-right: 8px;"></i>
                              <div>
                                Ingresar Datos del Detalle Medicamento
                              </div>
                            </div>
                            <asp:Table runat="server" Width="100%">
                               <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label4" Text="ID Detalle:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtIdDetalle" placeholder=""></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                               <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label3" Text="Cantidad:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtCantidad" placeholder=""></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label6" Text="Codigo Medicamento:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:DropDownList CssClass="btn btn_2" ID="DropDownListCodigoM" runat="server" DataSourceID="SqlDataSource4" DataTextField="codigo" DataValueField="codigo" Width="100%">
                                        </asp:DropDownList>
                                        <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:CESFAMConnectionString75 %>" SelectCommand="SELECT [codigo] FROM [medicamento]"></asp:SqlDataSource>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label7" Text="ID Salida:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                         <asp:DropDownList CssClass="btn btn_2" ID="DropDownListIdSalida" runat="server" DataSourceID="SqlDataSource5" DataTextField="id_salida" DataValueField="id_salida" Width="100%">
                                         </asp:DropDownList>
                                         <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:CESFAMConnectionString76 %>" SelectCommand="SELECT [id_salida] FROM [salida_medicamento]"></asp:SqlDataSource>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell ColumnSpan="2">
                                        <asp:Label runat="server" CssClass="alert-danger" ID="Label14"></asp:Label>
                                        <asp:Label runat="server" CssClass="alert-success" ID="Label15"></asp:Label>
                                    </asp:TableCell>
                                </asp:TableRow>
                            </asp:Table>
                        </fieldset>
                        <br />
                        <div>
                            <asp:Button ID="btnGuardarDetalle" runat="server" CssClass="btn btn-primary" Text="Guardar" EnableTheming="True" OnClick="btnGuardarDetalle_Click"/>
                            <asp:HyperLink ID="HyperLink2"  CssClass="btn btn-dark" runat="server" NavigateUrl="~/WebPaginaPrincipal.aspx">Volver</asp:HyperLink>
                        </div>
                    </div>
                    <div class="mt-5">
                         <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="id_detalleSalida" DataSourceID="SqlDataSource6" CssClass="table table-dark">
                              <Columns>
                                  <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                  <asp:BoundField DataField="id_detalleSalida" HeaderText="id_detalleSalida" ReadOnly="True" SortExpression="id_detalleSalida" />
                                  <asp:BoundField DataField="cantidad" HeaderText="cantidad" SortExpression="cantidad" />
                                  <asp:BoundField DataField="medicamento_codigo" HeaderText="medicamento_codigo" SortExpression="medicamento_codigo" />
                                  <asp:BoundField DataField="salida_medicamento_id_salida" HeaderText="salida_medicamento_id_salida" SortExpression="salida_medicamento_id_salida" />
                              </Columns>
                          </asp:GridView>
                          <asp:SqlDataSource ID="SqlDataSource6" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:CESFAMConnectionString77 %>" DeleteCommand="DELETE FROM [detalle_salida] WHERE [id_detalleSalida] = @original_id_detalleSalida AND (([cantidad] = @original_cantidad) OR ([cantidad] IS NULL AND @original_cantidad IS NULL)) AND (([medicamento_codigo] = @original_medicamento_codigo) OR ([medicamento_codigo] IS NULL AND @original_medicamento_codigo IS NULL)) AND (([salida_medicamento_id_salida] = @original_salida_medicamento_id_salida) OR ([salida_medicamento_id_salida] IS NULL AND @original_salida_medicamento_id_salida IS NULL))" InsertCommand="INSERT INTO [detalle_salida] ([id_detalleSalida], [cantidad], [medicamento_codigo], [salida_medicamento_id_salida]) VALUES (@id_detalleSalida, @cantidad, @medicamento_codigo, @salida_medicamento_id_salida)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [detalle_salida]" UpdateCommand="UPDATE [detalle_salida] SET [cantidad] = @cantidad, [medicamento_codigo] = @medicamento_codigo, [salida_medicamento_id_salida] = @salida_medicamento_id_salida WHERE [id_detalleSalida] = @original_id_detalleSalida AND (([cantidad] = @original_cantidad) OR ([cantidad] IS NULL AND @original_cantidad IS NULL)) AND (([medicamento_codigo] = @original_medicamento_codigo) OR ([medicamento_codigo] IS NULL AND @original_medicamento_codigo IS NULL)) AND (([salida_medicamento_id_salida] = @original_salida_medicamento_id_salida) OR ([salida_medicamento_id_salida] IS NULL AND @original_salida_medicamento_id_salida IS NULL))">
                              <DeleteParameters>
                                  <asp:Parameter Name="original_id_detalleSalida" Type="String" />
                                  <asp:Parameter Name="original_cantidad" Type="Int32" />
                                  <asp:Parameter Name="original_medicamento_codigo" Type="String" />
                                  <asp:Parameter Name="original_salida_medicamento_id_salida" Type="String" />
                              </DeleteParameters>
                              <InsertParameters>
                                  <asp:Parameter Name="id_detalleSalida" Type="String" />
                                  <asp:Parameter Name="cantidad" Type="Int32" />
                                  <asp:Parameter Name="medicamento_codigo" Type="String" />
                                  <asp:Parameter Name="salida_medicamento_id_salida" Type="String" />
                              </InsertParameters>
                              <UpdateParameters>
                                  <asp:Parameter Name="cantidad" Type="Int32" />
                                  <asp:Parameter Name="medicamento_codigo" Type="String" />
                                  <asp:Parameter Name="salida_medicamento_id_salida" Type="String" />
                                  <asp:Parameter Name="original_id_detalleSalida" Type="String" />
                                  <asp:Parameter Name="original_cantidad" Type="Int32" />
                                  <asp:Parameter Name="original_medicamento_codigo" Type="String" />
                                  <asp:Parameter Name="original_salida_medicamento_id_salida" Type="String" />
                              </UpdateParameters>
                          </asp:SqlDataSource>
                    </div>
                </form>
        </div>
    </div>
</body>
</html>
