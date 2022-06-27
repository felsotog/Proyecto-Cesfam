<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebIngresoMedicamento.aspx.cs" Inherits="CapaHtml.WebIngresoMedicamento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Ingreso Medicamento</title>
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
                <h2><i class="fas fa-pills"></i> Formulario Ingreso Medicamento</h2>
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
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CESFAMConnectionString %>" SelectCommand="SELECT [id_farmaceuta] FROM [farmaceutico]"></asp:SqlDataSource>
                            <asp:Table runat="server" Width="100%">
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label2" Text="ID Ingreso:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtIdIngreso" placeholder="AA1111"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="lblCalendario" Text="Fecha Ingreso:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="FechaIngreso" TextMode="Date"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label1" Text="Id Farmaceuta:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:DropDownList CssClass="btn btn_2" ID="DropDownListidfarmaceuta" runat="server" DataSourceID="SqlDataSource1" DataTextField="id_farmaceuta" DataValueField="id_farmaceuta" Width="100%">
                                        </asp:DropDownList>
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
                            <asp:Button ID="btnGuardarIngreso" runat="server" CssClass="btn btn-primary" Text="Guardar" OnClick="btnGuardarIngreso_Click" />
                            <asp:Button ID="Volver" runat="server" CssClass="btn btn-dark" Text="Volver" OnClick="Volver_Click" />
                        </div>

                        
                        <div class="mt-5">
                          <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id_ingreso" DataSourceID="SqlDataSource2" CssClass="table table-dark">
                              <Columns>
                                  <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                  <asp:BoundField DataField="id_ingreso" HeaderText="id_ingreso" ReadOnly="True" SortExpression="id_ingreso" />
                                  <asp:BoundField DataField="fecha_ingreso" HeaderText="fecha_ingreso" SortExpression="fecha_ingreso" />
                                  <asp:BoundField DataField="farmaceutico_id_farmaceuta" HeaderText="farmaceutico_id_farmaceuta" ReadOnly="True" SortExpression="farmaceutico_id_farmaceuta" />
                              </Columns>
                          </asp:GridView>
                          <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:CESFAMConnectionString50 %>" DeleteCommand="DELETE FROM [ingreso_medicamento] WHERE [id_ingreso] = @original_id_ingreso AND (([fecha_ingreso] = @original_fecha_ingreso) OR ([fecha_ingreso] IS NULL AND @original_fecha_ingreso IS NULL)) AND (([farmaceutico_id_farmaceuta] = @original_farmaceutico_id_farmaceuta) OR ([farmaceutico_id_farmaceuta] IS NULL AND @original_farmaceutico_id_farmaceuta IS NULL))" InsertCommand="INSERT INTO [ingreso_medicamento] ([id_ingreso], [fecha_ingreso], [farmaceutico_id_farmaceuta]) VALUES (@id_ingreso, @fecha_ingreso, @farmaceutico_id_farmaceuta)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [ingreso_medicamento]" UpdateCommand="UPDATE [ingreso_medicamento] SET [fecha_ingreso] = @fecha_ingreso, [farmaceutico_id_farmaceuta] = @farmaceutico_id_farmaceuta WHERE [id_ingreso] = @original_id_ingreso AND (([fecha_ingreso] = @original_fecha_ingreso) OR ([fecha_ingreso] IS NULL AND @original_fecha_ingreso IS NULL)) AND (([farmaceutico_id_farmaceuta] = @original_farmaceutico_id_farmaceuta) OR ([farmaceutico_id_farmaceuta] IS NULL AND @original_farmaceutico_id_farmaceuta IS NULL))">
                              <DeleteParameters>
                                  <asp:Parameter Name="original_id_ingreso" Type="String" />
                                  <asp:Parameter DbType="Date" Name="original_fecha_ingreso" />
                                  <asp:Parameter Name="original_farmaceutico_id_farmaceuta" Type="String" />
                              </DeleteParameters>
                              <InsertParameters>
                                  <asp:Parameter Name="id_ingreso" Type="String" />
                                  <asp:Parameter DbType="Date" Name="fecha_ingreso" />
                                  <asp:Parameter Name="farmaceutico_id_farmaceuta" Type="String" />
                              </InsertParameters>
                              <UpdateParameters>
                                  <asp:Parameter DbType="Date" Name="fecha_ingreso" />
                                  <asp:Parameter Name="farmaceutico_id_farmaceuta" Type="String" />
                                  <asp:Parameter Name="original_id_ingreso" Type="String" />
                                  <asp:Parameter DbType="Date" Name="original_fecha_ingreso" />
                                  <asp:Parameter Name="original_farmaceutico_id_farmaceuta" Type="String" />
                              </UpdateParameters>
                          </asp:SqlDataSource>
                        </div>


                        <div class="mt-5">
                            <fieldset>
                               <div class="alert alert-primary d-flex align-items-center" role="alert">
                                  <i class="fas fa-bell" width="34" height="34" style="padding-right: 8px;"></i>
                                  <div>
                                    Ingreso de Detalles
                                  </div>
                                </div>
                                <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:CESFAMConnectionString %>" SelectCommand="SELECT [id_farmaceuta] FROM [farmaceutico]"></asp:SqlDataSource>
                                <asp:Table runat="server" Width="100%">
                                    <asp:TableRow>
                                        <asp:TableCell>
                                            <asp:Label runat="server" ID="Label3" Text="ID Detalle:"></asp:Label>
                                        </asp:TableCell>
                                        <asp:TableCell>
                                            <asp:TextBox CssClass="form-control" runat="server" ID="txtIddetalle" placeholder=""></asp:TextBox>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell>
                                            <asp:Label runat="server" ID="Label8" Text="Cantidad:"></asp:Label>
                                        </asp:TableCell>
                                        <asp:TableCell>
                                            <asp:TextBox CssClass="form-control" runat="server" ID="txtCantidad" placeholder=""></asp:TextBox>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell>
                                            <asp:Label runat="server" ID="Label4" Text="Fecha Elaboración:"></asp:Label>
                                        </asp:TableCell>
                                        <asp:TableCell>
                                            <asp:TextBox CssClass="form-control" runat="server" ID="txtFechaelaboracion" TextMode="Date"></asp:TextBox>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell>
                                            <asp:Label runat="server" ID="Label9" Text="Fecha Vencimiento:"></asp:Label>
                                        </asp:TableCell>
                                        <asp:TableCell>
                                            <asp:TextBox CssClass="form-control" runat="server" ID="txtFechavencimiento" TextMode="Date"></asp:TextBox>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell>
                                            <asp:Label runat="server" ID="Label5" Text="Codigo Medicamento:"></asp:Label>
                                        </asp:TableCell>
                                        <asp:TableCell>
                                            <asp:DropDownList CssClass="btn btn_2" ID="DropDownListCodigomedicamento" runat="server" DataSourceID="SqlDataSource5" DataTextField="codigo" DataValueField="codigo" Width="100%">
                                            </asp:DropDownList>
                                            <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:CESFAMConnectionString56 %>" SelectCommand="SELECT [codigo] FROM [medicamento]"></asp:SqlDataSource>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell>
                                            <asp:Label runat="server" ID="Label10" Text="ID Ingreso:"></asp:Label>
                                        </asp:TableCell>
                                        <asp:TableCell>
                                            <asp:DropDownList CssClass="btn btn_2" ID="DropDownListIngresoid" runat="server" DataSourceID="SqlDataSource6" DataTextField="id_ingreso" DataValueField="id_ingreso" Width="100%"></asp:DropDownList>
                                            <asp:SqlDataSource ID="SqlDataSource6" runat="server" ConnectionString="<%$ ConnectionStrings:CESFAMConnectionString59 %>" SelectCommand="SELECT [id_ingreso] FROM [ingreso_medicamento]"></asp:SqlDataSource>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell ColumnSpan="2">
                                            <asp:Label runat="server" CssClass="alert-danger" ID="Label6"></asp:Label>
                                            <asp:Label runat="server" CssClass="alert-success" ID="Label7"></asp:Label>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                </asp:Table>
                            </fieldset>
                            <br />
                        <div>
                            <asp:Button ID="btnGuardarDetalle" runat="server" CssClass="btn btn-primary" Text="Guardar" OnClick="btnGuardarDetalle_Click" />
                            <asp:Button ID="Button2" runat="server" CssClass="btn btn-dark" Text="Volver" OnClick="Volver_Click" />
                        </div>
                        </div>
                    </div>

                    <div class="mt-5">
                         <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="id_detalleIngr" DataSourceID="SqlDataSource3" CssClass="table table-dark">
                              <Columns>
                                  <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                  <asp:BoundField DataField="id_detalleIngr" HeaderText="id_detalleIngr" ReadOnly="True" SortExpression="id_detalleIngr" />
                                  <asp:BoundField DataField="cantidad" HeaderText="cantidad" SortExpression="cantidad" />
                                  <asp:BoundField DataField="fecha_elaboracion" HeaderText="fecha_elaboracion" SortExpression="fecha_elaboracion" />
                                  <asp:BoundField DataField="fecha_vencimiento" HeaderText="fecha_vencimiento" SortExpression="fecha_vencimiento" />
                                  <asp:BoundField DataField="medicamento_codigo" HeaderText="medicamento_codigo" ReadOnly="True" SortExpression="medicamento_codigo" />
                                  <asp:BoundField DataField="ingreso_medicamento_id_ingreso" HeaderText="ingreso_medicamento_id_ingreso" ReadOnly="True" SortExpression="ingreso_medicamento_id_ingreso" />
                              </Columns>
                          </asp:GridView>
                          <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:CESFAMConnectionString51 %>" DeleteCommand="DELETE FROM [detalle_ingreso] WHERE [id_detalleIngr] = @original_id_detalleIngr AND (([cantidad] = @original_cantidad) OR ([cantidad] IS NULL AND @original_cantidad IS NULL)) AND (([fecha_elaboracion] = @original_fecha_elaboracion) OR ([fecha_elaboracion] IS NULL AND @original_fecha_elaboracion IS NULL)) AND (([fecha_vencimiento] = @original_fecha_vencimiento) OR ([fecha_vencimiento] IS NULL AND @original_fecha_vencimiento IS NULL)) AND (([medicamento_codigo] = @original_medicamento_codigo) OR ([medicamento_codigo] IS NULL AND @original_medicamento_codigo IS NULL)) AND (([ingreso_medicamento_id_ingreso] = @original_ingreso_medicamento_id_ingreso) OR ([ingreso_medicamento_id_ingreso] IS NULL AND @original_ingreso_medicamento_id_ingreso IS NULL))" InsertCommand="INSERT INTO [detalle_ingreso] ([id_detalleIngr], [cantidad], [fecha_elaboracion], [fecha_vencimiento], [medicamento_codigo], [ingreso_medicamento_id_ingreso]) VALUES (@id_detalleIngr, @cantidad, @fecha_elaboracion, @fecha_vencimiento, @medicamento_codigo, @ingreso_medicamento_id_ingreso)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [detalle_ingreso]" UpdateCommand="UPDATE [detalle_ingreso] SET [cantidad] = @cantidad, [fecha_elaboracion] = @fecha_elaboracion, [fecha_vencimiento] = @fecha_vencimiento, [medicamento_codigo] = @medicamento_codigo, [ingreso_medicamento_id_ingreso] = @ingreso_medicamento_id_ingreso WHERE [id_detalleIngr] = @original_id_detalleIngr AND (([cantidad] = @original_cantidad) OR ([cantidad] IS NULL AND @original_cantidad IS NULL)) AND (([fecha_elaboracion] = @original_fecha_elaboracion) OR ([fecha_elaboracion] IS NULL AND @original_fecha_elaboracion IS NULL)) AND (([fecha_vencimiento] = @original_fecha_vencimiento) OR ([fecha_vencimiento] IS NULL AND @original_fecha_vencimiento IS NULL)) AND (([medicamento_codigo] = @original_medicamento_codigo) OR ([medicamento_codigo] IS NULL AND @original_medicamento_codigo IS NULL)) AND (([ingreso_medicamento_id_ingreso] = @original_ingreso_medicamento_id_ingreso) OR ([ingreso_medicamento_id_ingreso] IS NULL AND @original_ingreso_medicamento_id_ingreso IS NULL))">
                              <DeleteParameters>
                                  <asp:Parameter Name="original_id_detalleIngr" Type="String" />
                                  <asp:Parameter Name="original_cantidad" Type="Int32" />
                                  <asp:Parameter DbType="Date" Name="original_fecha_elaboracion" />
                                  <asp:Parameter DbType="Date" Name="original_fecha_vencimiento" />
                                  <asp:Parameter Name="original_medicamento_codigo" Type="String" />
                                  <asp:Parameter Name="original_ingreso_medicamento_id_ingreso" Type="String" />
                              </DeleteParameters>
                              <InsertParameters>
                                  <asp:Parameter Name="id_detalleIngr" Type="String" />
                                  <asp:Parameter Name="cantidad" Type="Int32" />
                                  <asp:Parameter DbType="Date" Name="fecha_elaboracion" />
                                  <asp:Parameter DbType="Date" Name="fecha_vencimiento" />
                                  <asp:Parameter Name="medicamento_codigo" Type="String" />
                                  <asp:Parameter Name="ingreso_medicamento_id_ingreso" Type="String" />
                              </InsertParameters>
                              <UpdateParameters>
                                  <asp:Parameter Name="cantidad" Type="Int32" />
                                  <asp:Parameter DbType="Date" Name="fecha_elaboracion" />
                                  <asp:Parameter DbType="Date" Name="fecha_vencimiento" />
                                  <asp:Parameter Name="medicamento_codigo" Type="String" />
                                  <asp:Parameter Name="ingreso_medicamento_id_ingreso" Type="String" />
                                  <asp:Parameter Name="original_id_detalleIngr" Type="String" />
                                  <asp:Parameter Name="original_cantidad" Type="Int32" />
                                  <asp:Parameter DbType="Date" Name="original_fecha_elaboracion" />
                                  <asp:Parameter DbType="Date" Name="original_fecha_vencimiento" />
                                  <asp:Parameter Name="original_medicamento_codigo" Type="String" />
                                  <asp:Parameter Name="original_ingreso_medicamento_id_ingreso" Type="String" />
                              </UpdateParameters>
                          </asp:SqlDataSource>
                    </div>

                </form>
        </div>
    </div>
</body>
</html>