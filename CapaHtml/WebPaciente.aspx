<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebPaciente.aspx.cs" Inherits="CapaHtml.WebPaciente" %>

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
               <h2><i class="fas fa-user-circle"></i> Registro Paciente</h2>
            </div>
            <div class="col">
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
                                        <asp:Label runat="server" ID="lblNombres" Text="Rut:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtRut" placeholder="12365478-3"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label1" Text="Nombre Completo:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtNombre" placeholder=""></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label2" Text="Sector:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtSector" placeholder=""></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label3" Text="Dirección:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtDireccion" placeholder=""></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label4" Text="Telefono:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtTelefono" placeholder="" MaxLength="10" ></asp:TextBox>
                                        
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
                         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="rut" DataSourceID="SqlDataSource2" CssClass="table table-dark">
                              <Columns>
                                  <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                  <asp:BoundField DataField="rut" HeaderText="rut" ReadOnly="True" SortExpression="rut" />
                                  <asp:BoundField DataField="nombre_paciente" HeaderText="nombre_paciente" SortExpression="nombre_paciente" />
                                  <asp:BoundField DataField="sector" HeaderText="sector" SortExpression="sector" />
                                  <asp:BoundField DataField="telefono" HeaderText="telefono" SortExpression="telefono" />
                                  <asp:BoundField DataField="direccion" HeaderText="direccion" SortExpression="direccion" />
                              </Columns>
                          </asp:GridView>
                          <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:CESFAMConnectionString35 %>" DeleteCommand="DELETE FROM [paciente] WHERE [rut] = @original_rut AND (([nombre_paciente] = @original_nombre_paciente) OR ([nombre_paciente] IS NULL AND @original_nombre_paciente IS NULL)) AND (([sector] = @original_sector) OR ([sector] IS NULL AND @original_sector IS NULL)) AND (([telefono] = @original_telefono) OR ([telefono] IS NULL AND @original_telefono IS NULL)) AND (([direccion] = @original_direccion) OR ([direccion] IS NULL AND @original_direccion IS NULL))" InsertCommand="INSERT INTO [paciente] ([rut], [nombre_paciente], [sector], [telefono], [direccion]) VALUES (@rut, @nombre_paciente, @sector, @telefono, @direccion)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [paciente]" UpdateCommand="UPDATE [paciente] SET [nombre_paciente] = @nombre_paciente, [sector] = @sector, [telefono] = @telefono, [direccion] = @direccion WHERE [rut] = @original_rut AND (([nombre_paciente] = @original_nombre_paciente) OR ([nombre_paciente] IS NULL AND @original_nombre_paciente IS NULL)) AND (([sector] = @original_sector) OR ([sector] IS NULL AND @original_sector IS NULL)) AND (([telefono] = @original_telefono) OR ([telefono] IS NULL AND @original_telefono IS NULL)) AND (([direccion] = @original_direccion) OR ([direccion] IS NULL AND @original_direccion IS NULL))">
                              <DeleteParameters>
                                  <asp:Parameter Name="original_rut" Type="String" />
                                  <asp:Parameter Name="original_nombre_paciente" Type="String" />
                                  <asp:Parameter Name="original_sector" Type="String" />
                                  <asp:Parameter Name="original_telefono" Type="Int32" />
                                  <asp:Parameter Name="original_direccion" Type="String" />
                              </DeleteParameters>
                              <InsertParameters>
                                  <asp:Parameter Name="rut" Type="String" />
                                  <asp:Parameter Name="nombre_paciente" Type="String" />
                                  <asp:Parameter Name="sector" Type="String" />
                                  <asp:Parameter Name="telefono" Type="Int32" />
                                  <asp:Parameter Name="direccion" Type="String" />
                              </InsertParameters>
                              <UpdateParameters>
                                  <asp:Parameter Name="nombre_paciente" Type="String" />
                                  <asp:Parameter Name="sector" Type="String" />
                                  <asp:Parameter Name="telefono" Type="Int32" />
                                  <asp:Parameter Name="direccion" Type="String" />
                                  <asp:Parameter Name="original_rut" Type="String" />
                                  <asp:Parameter Name="original_nombre_paciente" Type="String" />
                                  <asp:Parameter Name="original_sector" Type="String" />
                                  <asp:Parameter Name="original_telefono" Type="Int32" />
                                  <asp:Parameter Name="original_direccion" Type="String" />
                              </UpdateParameters>
                          </asp:SqlDataSource>                   
                         
                         
                    </div>
                </form>
            </div>
        </div>
    </div>
</body>
</html>
