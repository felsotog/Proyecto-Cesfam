<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebMedicamento.aspx.cs" CodePage="65001" Inherits="CapaHtml.WebMedicamento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Medicamentos</title>
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
    <link rel="stylesheet" href="css/medicamentos.css" />
</head>
<body class="form-control bg-light cesfam-shell-page">
    <main class="container example_container medicines-page">
        <form id="formulario_registro" runat="server">
            <section class="medicines-hero" aria-labelledby="medicinesTitle">
                <div class="medicines-hero-copy">
                    <span class="medicines-eyebrow"><i class="fas fa-capsules"></i> Inventario farmacéutico</span>
                    <h1 id="medicinesTitle">Catálogo de medicamentos</h1>
                    <p>Centraliza la información del producto, sus fechas de control, existencias y farmacia asignada.</p>
                </div>
                <div class="medicines-metrics" aria-label="Resumen del inventario">
                    <div><span class="medicines-metric-icon green"><i class="fas fa-prescription-bottle-alt"></i></span><strong id="medicineCountHero">0</strong><small>Productos</small></div>
                    <div><span class="medicines-metric-icon blue"><i class="fas fa-boxes"></i></span><strong id="unitsCountHero">0</strong><small>Unidades</small></div>
                    <div><span class="medicines-metric-icon amber"><i class="fas fa-clinic-medical"></i></span><strong id="pharmaciesCountHero">0</strong><small>Farmacias</small></div>
                </div>
            </section>

            <div class="medicines-layout">
                <section class="medicines-card medicines-form-card" aria-labelledby="medicineFormTitle">
                    <div class="medicines-section-heading">
                        <span class="medicines-section-icon"><i class="fas fa-plus"></i></span>
                        <div><span class="medicines-kicker">Nuevo producto</span><h2 id="medicineFormTitle">Registrar medicamento</h2><p>Completa la identificación, trazabilidad y disponibilidad del producto.</p></div>
                    </div>
                    <fieldset>
                        <legend class="visually-hidden">Datos del medicamento</legend>
                        <asp:Table runat="server" Width="100%" CssClass="medicines-form-table">
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label1" Text="Código:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtcodigo" placeholder="Ej. MED-001"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label5" Text="Nombre:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtNombre" placeholder="Nombre comercial o genérico"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label6" Text="Tipo:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtTipo" placeholder="Ej. Analgésico"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="lblCalendario" Text="Fecha Fabricación:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtFechafabricacion" TextMode="Date"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label7" Text="Fecha Vencimiento:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtFechavencimiento" TextMode="Date"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label2" Text="Descripción:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>                                        
                                        <textarea class="form-control" runat="server"  id="TextAreaDescripcion"  cols="20" name="S2" rows="2"></textarea>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label3" Text="Cantidad:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtCantidad" placeholder="Cantidad disponible"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label4" Text="ID Farmacia:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                         <asp:DropDownList CssClass="form-select" ID="DropDownListidfarmacia" runat="server" DataSourceID="SqlDataSource1" DataTextField="id_farmacia" DataValueField="id_farmacia" Width="100%">
                                         </asp:DropDownList>
                                         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CESFAMConnectionString4 %>" SelectCommand="SELECT [id_farmacia] FROM [farmacia]"></asp:SqlDataSource>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell ColumnSpan="2">
                                        <div class="medicines-feedback" aria-live="polite">
                                            <asp:Label runat="server" CssClass="alert-danger" ID="lblError"></asp:Label>
                                            <asp:Label runat="server" CssClass="alert-success" ID="lblSucces"></asp:Label>
                                        </div>
                                    </asp:TableCell>
                                </asp:TableRow>
                        </asp:Table>
                    </fieldset>
                    <div class="medicines-actions">
                        <asp:Button ID="btnGuardar" runat="server" CssClass="btn btn-primary medicines-primary-action" Text="Registrar medicamento" OnClick="btnGuardar_Click1" />
                        <asp:HyperLink ID="HyperLink1" CssClass="btn btn-dark" runat="server" NavigateUrl="~/WebPaginaPrincipal.aspx">Volver</asp:HyperLink>
                    </div>
                </section>

                <aside class="medicines-guide" aria-label="Control del medicamento">
                    <span class="medicines-guide-icon"><i class="fas fa-shield-alt"></i></span>
                    <span class="medicines-kicker">Control de inventario</span>
                    <h2>Información para una trazabilidad completa</h2>
                    <p>Las fechas y cantidades permiten controlar la disponibilidad y anticipar productos próximos a vencer.</p>
                    <div class="medicines-checks">
                        <div><i class="fas fa-barcode"></i><span><strong>Identificación</strong><small>Código, nombre y tipo</small></span></div>
                        <div><i class="far fa-calendar-check"></i><span><strong>Vigencia</strong><small>Fabricación y vencimiento</small></span></div>
                        <div><i class="fas fa-box-open"></i><span><strong>Disponibilidad</strong><small>Cantidad y farmacia</small></span></div>
                    </div>
                </aside>
            </div>

            <section class="medicines-card medicines-list-card" aria-labelledby="medicineListTitle">
                <div class="medicines-list-heading">
                    <div><span class="medicines-kicker">Inventario actual</span><h2 id="medicineListTitle">Medicamentos registrados</h2><p>Consulta y actualiza la información de cada producto.</p></div>
                    <span id="medicineCount" class="medicines-count">Cargando productos…</span>
                </div>
                <div class="medicines-table-wrap">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="codigo" DataSourceID="SqlDataSource2" CssClass="table table-dark medicines-table">
                              <Columns>
                                  <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                  <asp:BoundField DataField="codigo" HeaderText="Código" ReadOnly="True" SortExpression="codigo" />
                                  <asp:BoundField DataField="nombre_medicamento" HeaderText="Nombre" SortExpression="nombre_medicamento" />
                                  <asp:BoundField DataField="tipo_medicamento" HeaderText="Tipo" SortExpression="tipo_medicamento" />
                                  <asp:BoundField DataField="fecha_fabricacion" HeaderText="Fabricación" SortExpression="fecha_fabricacion" />
                                  <asp:BoundField DataField="fecha_vencimiento" HeaderText="Vencimiento" SortExpression="fecha_vencimiento" />
                                  <asp:BoundField DataField="descripcion" HeaderText="Descripción" SortExpression="descripcion" />
                                  <asp:BoundField DataField="cantidad" HeaderText="Cantidad" SortExpression="cantidad" />
                                  <asp:BoundField DataField="farmacia_id_farmacia" HeaderText="ID farmacia" ReadOnly="True" SortExpression="farmacia_id_farmacia" />
                              </Columns>
                    </asp:GridView>
                </div>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:CESFAMConnectionString39 %>" DeleteCommand="DELETE FROM [medicamento] WHERE [codigo] = @original_codigo AND (([nombre_medicamento] = @original_nombre_medicamento) OR ([nombre_medicamento] IS NULL AND @original_nombre_medicamento IS NULL)) AND (([tipo_medicamento] = @original_tipo_medicamento) OR ([tipo_medicamento] IS NULL AND @original_tipo_medicamento IS NULL)) AND (([fecha_fabricacion] = @original_fecha_fabricacion) OR ([fecha_fabricacion] IS NULL AND @original_fecha_fabricacion IS NULL)) AND (([fecha_vencimiento] = @original_fecha_vencimiento) OR ([fecha_vencimiento] IS NULL AND @original_fecha_vencimiento IS NULL)) AND (([descripcion] = @original_descripcion) OR ([descripcion] IS NULL AND @original_descripcion IS NULL)) AND (([cantidad] = @original_cantidad) OR ([cantidad] IS NULL AND @original_cantidad IS NULL)) AND (([farmacia_id_farmacia] = @original_farmacia_id_farmacia) OR ([farmacia_id_farmacia] IS NULL AND @original_farmacia_id_farmacia IS NULL))" InsertCommand="INSERT INTO [medicamento] ([codigo], [nombre_medicamento], [tipo_medicamento], [fecha_fabricacion], [fecha_vencimiento], [descripcion], [cantidad], [farmacia_id_farmacia]) VALUES (@codigo, @nombre_medicamento, @tipo_medicamento, @fecha_fabricacion, @fecha_vencimiento, @descripcion, @cantidad, @farmacia_id_farmacia)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [medicamento]" UpdateCommand="UPDATE [medicamento] SET [nombre_medicamento] = @nombre_medicamento, [tipo_medicamento] = @tipo_medicamento, [fecha_fabricacion] = @fecha_fabricacion, [fecha_vencimiento] = @fecha_vencimiento, [descripcion] = @descripcion, [cantidad] = @cantidad, [farmacia_id_farmacia] = @farmacia_id_farmacia WHERE [codigo] = @original_codigo AND (([nombre_medicamento] = @original_nombre_medicamento) OR ([nombre_medicamento] IS NULL AND @original_nombre_medicamento IS NULL)) AND (([tipo_medicamento] = @original_tipo_medicamento) OR ([tipo_medicamento] IS NULL AND @original_tipo_medicamento IS NULL)) AND (([fecha_fabricacion] = @original_fecha_fabricacion) OR ([fecha_fabricacion] IS NULL AND @original_fecha_fabricacion IS NULL)) AND (([fecha_vencimiento] = @original_fecha_vencimiento) OR ([fecha_vencimiento] IS NULL AND @original_fecha_vencimiento IS NULL)) AND (([descripcion] = @original_descripcion) OR ([descripcion] IS NULL AND @original_descripcion IS NULL)) AND (([cantidad] = @original_cantidad) OR ([cantidad] IS NULL AND @original_cantidad IS NULL)) AND (([farmacia_id_farmacia] = @original_farmacia_id_farmacia) OR ([farmacia_id_farmacia] IS NULL AND @original_farmacia_id_farmacia IS NULL))">
                              <DeleteParameters>
                                  <asp:Parameter Name="original_codigo" Type="String" />
                                  <asp:Parameter Name="original_nombre_medicamento" Type="String" />
                                  <asp:Parameter Name="original_tipo_medicamento" Type="String" />
                                  <asp:Parameter DbType="Date" Name="original_fecha_fabricacion" />
                                  <asp:Parameter DbType="Date" Name="original_fecha_vencimiento" />
                                  <asp:Parameter Name="original_descripcion" Type="String" />
                                  <asp:Parameter Name="original_cantidad" Type="Int32" />
                                  <asp:Parameter Name="original_farmacia_id_farmacia" Type="String" />
                              </DeleteParameters>
                              <InsertParameters>
                                  <asp:Parameter Name="codigo" Type="String" />
                                  <asp:Parameter Name="nombre_medicamento" Type="String" />
                                  <asp:Parameter Name="tipo_medicamento" Type="String" />
                                  <asp:Parameter DbType="Date" Name="fecha_fabricacion" />
                                  <asp:Parameter DbType="Date" Name="fecha_vencimiento" />
                                  <asp:Parameter Name="descripcion" Type="String" />
                                  <asp:Parameter Name="cantidad" Type="Int32" />
                                  <asp:Parameter Name="farmacia_id_farmacia" Type="String" />
                              </InsertParameters>
                              <UpdateParameters>
                                  <asp:Parameter Name="nombre_medicamento" Type="String" />
                                  <asp:Parameter Name="tipo_medicamento" Type="String" />
                                  <asp:Parameter DbType="Date" Name="fecha_fabricacion" />
                                  <asp:Parameter DbType="Date" Name="fecha_vencimiento" />
                                  <asp:Parameter Name="descripcion" Type="String" />
                                  <asp:Parameter Name="cantidad" Type="Int32" />
                                  <asp:Parameter Name="farmacia_id_farmacia" Type="String" />
                                  <asp:Parameter Name="original_codigo" Type="String" />
                                  <asp:Parameter Name="original_nombre_medicamento" Type="String" />
                                  <asp:Parameter Name="original_tipo_medicamento" Type="String" />
                                  <asp:Parameter DbType="Date" Name="original_fecha_fabricacion" />
                                  <asp:Parameter DbType="Date" Name="original_fecha_vencimiento" />
                                  <asp:Parameter Name="original_descripcion" Type="String" />
                                  <asp:Parameter Name="original_cantidad" Type="Int32" />
                                  <asp:Parameter Name="original_farmacia_id_farmacia" Type="String" />
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
            var units = 0;
            var pharmacies = new Set();
            rows.forEach(function (row) {
                if (row.cells.length > 8) {
                    units += parseInt(row.cells[7].textContent.trim(), 10) || 0;
                    var pharmacy = row.cells[8].textContent.trim();
                    if (pharmacy) pharmacies.add(pharmacy);
                }
            });
            document.getElementById("medicineCountHero").textContent = rows.length;
            document.getElementById("unitsCountHero").textContent = units;
            document.getElementById("pharmaciesCountHero").textContent = pharmacies.size;
            document.getElementById("medicineCount").textContent = rows.length + (rows.length === 1 ? " producto" : " productos");
        }());
    </script>
</body>
</html>
