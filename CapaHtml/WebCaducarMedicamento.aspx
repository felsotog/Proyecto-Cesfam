<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebCaducarMedicamento.aspx.cs" Inherits="CapaHtml.WebCaducarMedicamento" %>

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
              <li class="nav-item">
                <a class="nav-link" href="WebCaducarMedicamento.aspx">Merma</a>
              </li>
            </ul>
          </div>
        </div>
      </nav>
      <!-- Navbar -->

    <div class="container small example_container">
        <div class="row">
            <div class="title">
               <h2><i class="fas fa-times-circle"></i> Registrar Merma</h2>
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
                                        <asp:Label runat="server" ID="lblNombres" Text="ID Merma:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtIdmerma" placeholder=""></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="lblCalendario" Text="Fecha:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtFechacaducidad" TextMode="Date"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label1" Text="ID Detalle:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtIddetalle" placeholder="1-8"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label2" Text="Cantidad:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtCantidadcaducada" placeholder="1-9"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label3" Text="Motivo:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <textarea class="form-control" id="TextAreamotivo" cols="20" name="S1" rows="2"></textarea>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label4" Text="Codigo Medicamento:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                         <asp:DropDownList CssClass="btn btn_2"  ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="codigo" DataValueField="codigo"  Width="100%">
                                         </asp:DropDownList>
                                         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CESFAMConnectionString18 %>" SelectCommand="SELECT [codigo] FROM [medicamento]"></asp:SqlDataSource>
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
                            <asp:Button ID="btnAgendar1" runat="server" CssClass="btn btn-primary" Text="Agendar" OnClick="btnAgendar1_Click"/>
                            <asp:HyperLink ID="HyperLink1"  CssClass="btn btn-dark" runat="server" NavigateUrl="~/WebPaginaPrincipal.aspx">Volver</asp:HyperLink>
                        </div>
                    </div>

                        <div class="mt-5">
                              <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id_detalle" DataSourceID="SqlDataSource2" CssClass="table table-dark">
                                  <Columns>
                                      <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                      <asp:BoundField DataField="id_detalle" HeaderText="id_detalle" ReadOnly="True" SortExpression="id_detalle" />
                                      <asp:BoundField DataField="cantidad_caducada" HeaderText="cantidad_caducada" SortExpression="cantidad_caducada" />
                                      <asp:BoundField DataField="motivo" HeaderText="motivo" SortExpression="motivo" />
                                      <asp:BoundField DataField="medicamento_codigo" HeaderText="medicamento_codigo" ReadOnly="True" SortExpression="medicamento_codigo" />
                                      <asp:BoundField DataField="caducar_medicamento_id_caducidad" HeaderText="caducar_medicamento_id_caducidad" ReadOnly="True" SortExpression="caducar_medicamento_id_caducidad" />
                                  </Columns>
                              </asp:GridView>
                              <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:CESFAMConnectionString47 %>" DeleteCommand="DELETE FROM [detalle_caducidad] WHERE [id_detalle] = @original_id_detalle AND (([cantidad_caducada] = @original_cantidad_caducada) OR ([cantidad_caducada] IS NULL AND @original_cantidad_caducada IS NULL)) AND (([motivo] = @original_motivo) OR ([motivo] IS NULL AND @original_motivo IS NULL)) AND (([medicamento_codigo] = @original_medicamento_codigo) OR ([medicamento_codigo] IS NULL AND @original_medicamento_codigo IS NULL)) AND (([caducar_medicamento_id_caducidad] = @original_caducar_medicamento_id_caducidad) OR ([caducar_medicamento_id_caducidad] IS NULL AND @original_caducar_medicamento_id_caducidad IS NULL))" InsertCommand="INSERT INTO [detalle_caducidad] ([id_detalle], [cantidad_caducada], [motivo], [medicamento_codigo], [caducar_medicamento_id_caducidad]) VALUES (@id_detalle, @cantidad_caducada, @motivo, @medicamento_codigo, @caducar_medicamento_id_caducidad)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [detalle_caducidad]" UpdateCommand="UPDATE [detalle_caducidad] SET [cantidad_caducada] = @cantidad_caducada, [motivo] = @motivo, [medicamento_codigo] = @medicamento_codigo, [caducar_medicamento_id_caducidad] = @caducar_medicamento_id_caducidad WHERE [id_detalle] = @original_id_detalle AND (([cantidad_caducada] = @original_cantidad_caducada) OR ([cantidad_caducada] IS NULL AND @original_cantidad_caducada IS NULL)) AND (([motivo] = @original_motivo) OR ([motivo] IS NULL AND @original_motivo IS NULL)) AND (([medicamento_codigo] = @original_medicamento_codigo) OR ([medicamento_codigo] IS NULL AND @original_medicamento_codigo IS NULL)) AND (([caducar_medicamento_id_caducidad] = @original_caducar_medicamento_id_caducidad) OR ([caducar_medicamento_id_caducidad] IS NULL AND @original_caducar_medicamento_id_caducidad IS NULL))">
                                  <DeleteParameters>
                                      <asp:Parameter Name="original_id_detalle" Type="String" />
                                      <asp:Parameter Name="original_cantidad_caducada" Type="Int32" />
                                      <asp:Parameter Name="original_motivo" Type="String" />
                                      <asp:Parameter Name="original_medicamento_codigo" Type="String" />
                                      <asp:Parameter Name="original_caducar_medicamento_id_caducidad" Type="String" />
                                  </DeleteParameters>
                                  <InsertParameters>
                                      <asp:Parameter Name="id_detalle" Type="String" />
                                      <asp:Parameter Name="cantidad_caducada" Type="Int32" />
                                      <asp:Parameter Name="motivo" Type="String" />
                                      <asp:Parameter Name="medicamento_codigo" Type="String" />
                                      <asp:Parameter Name="caducar_medicamento_id_caducidad" Type="String" />
                                  </InsertParameters>
                                  <UpdateParameters>
                                      <asp:Parameter Name="cantidad_caducada" Type="Int32" />
                                      <asp:Parameter Name="motivo" Type="String" />
                                      <asp:Parameter Name="medicamento_codigo" Type="String" />
                                      <asp:Parameter Name="caducar_medicamento_id_caducidad" Type="String" />
                                      <asp:Parameter Name="original_id_detalle" Type="String" />
                                      <asp:Parameter Name="original_cantidad_caducada" Type="Int32" />
                                      <asp:Parameter Name="original_motivo" Type="String" />
                                      <asp:Parameter Name="original_medicamento_codigo" Type="String" />
                                      <asp:Parameter Name="original_caducar_medicamento_id_caducidad" Type="String" />
                                  </UpdateParameters>
                              </asp:SqlDataSource>
                        </div>
                </form>
            </div>
        </div>
    </div>
</body>
</html>