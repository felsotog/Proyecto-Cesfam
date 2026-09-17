<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFarmacia.aspx.cs" CodePage="65001" Inherits="CapaHtml.WebFarmacia" %>

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
    <link rel="stylesheet" href="css/modern-shell.css" />
    <link rel="stylesheet" href="css/farmacia.css" />
</head>
<body class="form-control bg-light cesfam-shell-page">
    <main class="container example_container pharmacy-page">
        <form id="formulario_registro" runat="server">
            <section class="pharmacy-hero" aria-labelledby="pharmacyTitle">
                <div class="pharmacy-hero-copy">
                    <span class="pharmacy-eyebrow"><i class="fas fa-clinic-medical"></i> Gestión farmacéutica</span>
                    <h1 id="pharmacyTitle">Farmacia CESFAM</h1>
                    <p>Administra los establecimientos y accede rápidamente a las operaciones de medicamentos e inventario.</p>
                </div>
                <div class="pharmacy-hero-count">
                    <span class="pharmacy-hero-icon"><i class="fas fa-prescription-bottle-alt"></i></span>
                    <div><strong id="pharmacyCountHero">0</strong><small>Farmacias registradas</small></div>
                </div>
            </section>

            <section class="pharmacy-shortcuts" aria-labelledby="pharmacyShortcutsTitle">
                <div class="pharmacy-shortcuts-heading">
                    <div><span class="pharmacy-kicker">Operaciones frecuentes</span><h2 id="pharmacyShortcutsTitle">Accesos de farmacia</h2></div>
                    <span>Selecciona una tarea para continuar</span>
                </div>
                <nav class="pharmacy-shortcuts-grid" aria-label="Operaciones de farmacia">
                    <a href="WebMedicamento.aspx"><i class="fas fa-capsules"></i><span><strong>Medicamentos</strong><small>Consultar catálogo</small></span><b>›</b></a>
                    <a href="WebIngresoMedicamento.aspx"><i class="fas fa-arrow-down"></i><span><strong>Ingresos</strong><small>Registrar recepción</small></span><b>›</b></a>
                    <a href="WebSalidaMedicamento.aspx"><i class="fas fa-arrow-up"></i><span><strong>Entregas</strong><small>Controlar salidas</small></span><b>›</b></a>
                    <a href="WebReservaMedicamento.aspx"><i class="far fa-clock"></i><span><strong>Reservas</strong><small>Gestionar solicitudes</small></span><b>›</b></a>
                    <a href="WebCaducarMedicamento.aspx"><i class="fas fa-exclamation-triangle"></i><span><strong>Mermas</strong><small>Registrar caducidad</small></span><b>›</b></a>
                </nav>
            </section>

            <div class="pharmacy-layout">
                <section class="pharmacy-card pharmacy-form-card" aria-labelledby="pharmacyFormTitle">
                    <div class="pharmacy-section-heading">
                        <span class="pharmacy-section-icon"><i class="fas fa-plus"></i></span>
                        <div><span class="pharmacy-kicker">Nuevo establecimiento</span><h2 id="pharmacyFormTitle">Registrar farmacia</h2><p>Ingresa un identificador único y el nombre del establecimiento.</p></div>
                    </div>
                    <fieldset>
                        <legend class="visually-hidden">Datos de la farmacia</legend>
                        <asp:Table runat="server" Width="100%" CssClass="pharmacy-form-table">
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label1" Text="ID Farmacia:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtIdFarmacia" placeholder="Ej. FARM-001"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label2" Text="Nombre Farmacia:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtNombreFarmacia" placeholder="Nombre del establecimiento"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell ColumnSpan="2">
                                        <div class="pharmacy-feedback" aria-live="polite">
                                            <asp:Label runat="server" CssClass="alert-danger" ID="lblError"></asp:Label>
                                            <asp:Label runat="server" CssClass="alert-success" ID="lblSucces"></asp:Label>
                                        </div>
                                    </asp:TableCell>
                                </asp:TableRow>
                        </asp:Table>
                    </fieldset>
                    <div class="pharmacy-actions">
                        <asp:Button ID="btnFarmacia" runat="server" CssClass="btn btn-primary pharmacy-primary-action" Text="Registrar farmacia" OnClick="btnFarmacia_Click"/>
                        <asp:Button ID="Volver" runat="server" CssClass="btn btn-dark" Text="Volver" OnClick="Volver_Click"/>
                    </div>
                </section>

                <section class="pharmacy-card pharmacy-list-card" aria-labelledby="pharmacyListTitle">
                    <div class="pharmacy-list-heading">
                        <div><span class="pharmacy-kicker">Directorio</span><h2 id="pharmacyListTitle">Farmacias registradas</h2><p>Edita el nombre o elimina un registro.</p></div>
                        <span id="pharmacyCount" class="pharmacy-count">Cargando…</span>
                    </div>
                    <div class="pharmacy-table-wrap">
                        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="id_farmacia" DataSourceID="SqlDataSource1" CssClass="table table-dark pharmacy-table">
                              <Columns>
                                  <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                  <asp:BoundField DataField="id_farmacia" HeaderText="ID farmacia" ReadOnly="True" SortExpression="id_farmacia" />
                                  <asp:BoundField DataField="nombre_farmacia" HeaderText="Nombre" SortExpression="nombre_farmacia" />
                              </Columns>
                        </asp:GridView>
                    </div>
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
                </section>
            </div>
        </form>
    </main>
    <script src="js/modern-shell.js"></script>
    <script>
        (function () {
            var table = document.getElementById("<%= GridView1.ClientID %>");
            var total = table ? Math.max(table.rows.length - 1, 0) : 0;
            document.getElementById("pharmacyCountHero").textContent = total;
            document.getElementById("pharmacyCount").textContent = total + (total === 1 ? " farmacia" : " farmacias");
        }());
    </script>
</body>
</html>
