<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebPaciente.aspx.cs" CodePage="65001" Inherits="CapaHtml.WebPaciente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Pacientes</title>
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
    <link rel="stylesheet" href="css/modern-shell.css" />
    <link rel="stylesheet" href="css/pacientes.css" />
</head>
<body class="form-control bg-light cesfam-shell-page">
    <main class="container example_container patients-page">
        <form id="formulario_registro" runat="server">
            <section class="patients-hero" aria-labelledby="patientsTitle">
                <div class="patients-hero-main">
                    <span class="patients-eyebrow"><i class="fas fa-users"></i> Gestión clínica</span>
                    <h1 id="patientsTitle">Pacientes</h1>
                    <p>Registra la información de contacto y mantén actualizado el directorio de pacientes del centro de salud.</p>
                </div>
                <div class="patients-summary" aria-label="Resumen de pacientes">
                    <div class="patients-summary-item">
                        <span class="patients-summary-icon"><i class="fas fa-user-friends"></i></span>
                        <div><strong id="patientCountHero">0</strong><small>Pacientes registrados</small></div>
                    </div>
                    <div class="patients-summary-item">
                        <span class="patients-summary-icon secondary"><i class="fas fa-map-marker-alt"></i></span>
                        <div><strong id="sectorCountHero">0</strong><small>Sectores representados</small></div>
                    </div>
                </div>
            </section>

            <div class="patients-layout">
                <section class="patients-card patients-form-card" aria-labelledby="patientFormTitle">
                    <div class="patients-section-heading">
                        <span class="patients-section-icon"><i class="fas fa-user-plus"></i></span>
                        <div>
                            <span class="patients-kicker">Nuevo registro</span>
                            <h2 id="patientFormTitle">Datos del paciente</h2>
                            <p>Completa todos los campos para crear una ficha básica de contacto.</p>
                        </div>
                    </div>

                    <fieldset>
                        <legend class="visually-hidden">Información personal del paciente</legend>
                        <asp:Table runat="server" Width="100%" CssClass="patients-form-table">
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="lblNombres" Text="RUT:"></asp:Label>
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
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtNombre" placeholder="Nombre y apellidos"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label2" Text="Sector:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtSector" placeholder="Sector de residencia"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label3" Text="Dirección:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtDireccion" placeholder="Calle, número y comuna"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label4" Text="Teléfono:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtTelefono" placeholder="912345678" MaxLength="10" ></asp:TextBox>

                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell ColumnSpan="2">
                                        <div class="patients-feedback" aria-live="polite">
                                            <asp:Label runat="server" CssClass="alert-danger" ID="lblError"></asp:Label>
                                            <asp:Label runat="server" CssClass="alert-success" ID="lblSucces"></asp:Label>
                                        </div>
                                    </asp:TableCell>
                                </asp:TableRow>
                        </asp:Table>
                    </fieldset>

                    <div class="patients-actions">
                        <asp:Button ID="btnAgendar1" runat="server" CssClass="btn btn-primary patients-primary-action" Text="Registrar paciente" OnClick="btnAgendar1_Click"/>
                        <asp:HyperLink ID="HyperLink1" CssClass="btn btn-dark" runat="server" NavigateUrl="~/WebPaginaPrincipal.aspx">Volver</asp:HyperLink>
                    </div>
                </section>

                <aside class="patients-side-panel" aria-label="Importancia de los datos del paciente">
                    <span class="patients-side-icon"><i class="fas fa-id-card"></i></span>
                    <span class="patients-kicker">Ficha básica</span>
                    <h2>Información clara para una mejor atención</h2>
                    <p>Los datos de identificación y contacto permiten vincular correctamente las horas, fichas clínicas y entregas de medicamentos.</p>
                    <div class="patients-data-list">
                        <div><i class="fas fa-fingerprint"></i><span><strong>Identificación</strong><small>RUT y nombre completo</small></span></div>
                        <div><i class="fas fa-map-marked-alt"></i><span><strong>Ubicación</strong><small>Sector y dirección</small></span></div>
                        <div><i class="fas fa-phone-alt"></i><span><strong>Contacto</strong><small>Teléfono actualizado</small></span></div>
                    </div>
                </aside>
            </div>

            <section class="patients-card patients-list-card" aria-labelledby="patientListTitle">
                <div class="patients-list-heading">
                    <div>
                        <span class="patients-kicker">Directorio clínico</span>
                        <h2 id="patientListTitle">Pacientes registrados</h2>
                        <p>Consulta y actualiza la información de cada paciente.</p>
                    </div>
                    <span id="patientCount" class="patients-count">Cargando pacientes…</span>
                </div>
                <div class="patients-table-wrap">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="rut" DataSourceID="SqlDataSource2" CssClass="table table-dark patients-table">
                              <Columns>
                                  <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                  <asp:BoundField DataField="rut" HeaderText="RUT" ReadOnly="True" SortExpression="rut" />
                                  <asp:BoundField DataField="nombre_paciente" HeaderText="Nombre completo" SortExpression="nombre_paciente" />
                                  <asp:BoundField DataField="sector" HeaderText="Sector" SortExpression="sector" />
                                  <asp:BoundField DataField="telefono" HeaderText="Teléfono" SortExpression="telefono" />
                                  <asp:BoundField DataField="direccion" HeaderText="Dirección" SortExpression="direccion" />
                              </Columns>
                    </asp:GridView>
                </div>
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
            </section>
        </form>
    </main>
    <script src="js/modern-shell.js"></script>
    <script>
        (function () {
            var table = document.getElementById("<%= GridView1.ClientID %>");
            var rows = table ? Array.prototype.slice.call(table.rows, 1) : [];
            var total = rows.length;
            var sectors = new Set();
            rows.forEach(function (row) {
                if (row.cells.length > 3) {
                    var sector = row.cells[3].textContent.trim().toLowerCase();
                    if (sector) sectors.add(sector);
                }
            });
            document.getElementById("patientCountHero").textContent = total;
            document.getElementById("sectorCountHero").textContent = sectors.size;
            document.getElementById("patientCount").textContent = total + (total === 1 ? " paciente" : " pacientes");
        }());
    </script>
</body>
</html>
