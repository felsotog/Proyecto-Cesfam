<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebIngresoMedicamento.aspx.cs" CodePage="65001" Inherits="CapaHtml.WebIngresoMedicamento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Ingresos de medicamentos</title>
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
    <link rel="stylesheet" href="css/ingresos.css" />
</head>
<body class="form-control bg-light cesfam-shell-page">


    <main class="container example_container admissions-page">
        <div class="admissions-content">
            <div class="admissions-hero">
                <div class="admissions-hero-copy">
                    <span class="admissions-eyebrow"><i class="fas fa-truck-loading"></i> Recepción de inventario</span>
                    <h1>Ingresos de medicamentos</h1>
                    <p>Registra la recepción y documenta los lotes que se incorporan al inventario de farmacia.</p>
                </div>
                <div class="admissions-metrics" aria-label="Resumen de ingresos">
                    <div><strong id="admissionCountHero">0</strong><small>Recepciones</small></div>
                    <div><strong id="batchCountHero">0</strong><small>Lotes</small></div>
                    <div><strong id="receivedUnitsHero">0</strong><small>Unidades</small></div>
                </div>
            </div>
                <form id="formulario_registro" class="form-check" runat="server">
                    <section class="admissions-card admission-form-card" aria-labelledby="admissionFormTitle">
                        <fieldset>
                           <div class="admissions-section-heading">
                              <span class="admissions-step">01</span>
                              <div><span class="admissions-kicker">Recepción principal</span><h2 id="admissionFormTitle">Registrar un ingreso</h2><p>Identifica la recepción, su fecha y el responsable farmacéutico.</p></div>
                            </div>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CESFAMConnectionString %>" SelectCommand="SELECT [id_farmaceuta] FROM [farmaceutico]"></asp:SqlDataSource>
                            <asp:Table runat="server" Width="100%" CssClass="admissions-form-table admission-main-table">
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label2" Text="ID Ingreso:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtIdIngreso" placeholder="Ej. ING-001"></asp:TextBox>
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
                                        <asp:Label runat="server" ID="Label1" Text="ID farmacéutico:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:DropDownList CssClass="form-select" ID="DropDownListidfarmaceuta" runat="server" DataSourceID="SqlDataSource1" DataTextField="id_farmaceuta" DataValueField="id_farmaceuta" Width="100%">
                                        </asp:DropDownList>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell ColumnSpan="2">
                                        <div class="admissions-feedback" aria-live="polite"><asp:Label runat="server" CssClass="alert-danger" ID="lblError"></asp:Label><asp:Label runat="server" CssClass="alert-success" ID="lblSucces"></asp:Label></div>
                                    </asp:TableCell>
                                </asp:TableRow>
                            </asp:Table>
                        </fieldset>
                        <div class="admissions-actions">
                            <asp:Button ID="btnGuardarIngreso" runat="server" CssClass="btn btn-primary admissions-primary-action" Text="Registrar ingreso" OnClick="btnGuardarIngreso_Click" />
                            <asp:Button ID="Volver" runat="server" CssClass="btn btn-dark" Text="Volver" OnClick="Volver_Click" />
                        </div>
                    </section>

                    <section class="admissions-card admissions-list-card" aria-labelledby="admissionsListTitle">
                        <div class="admissions-list-heading"><div><span class="admissions-kicker">Recepciones registradas</span><h2 id="admissionsListTitle">Historial de ingresos</h2><p>Consulta la fecha y el responsable de cada recepción.</p></div><span id="admissionCount" class="admissions-count">Cargando…</span></div>
                        <div class="admissions-table-wrap">
                          <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id_ingreso" DataSourceID="SqlDataSource2" CssClass="table table-dark admissions-table">
                              <Columns>
                                  <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                  <asp:BoundField DataField="id_ingreso" HeaderText="ID ingreso" ReadOnly="True" SortExpression="id_ingreso" />
                                  <asp:BoundField DataField="fecha_ingreso" HeaderText="Fecha de ingreso" SortExpression="fecha_ingreso" />
                                  <asp:BoundField DataField="farmaceutico_id_farmaceuta" HeaderText="ID farmacéutico" ReadOnly="True" SortExpression="farmaceutico_id_farmaceuta" />
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
                    </section>

                    <section class="admissions-card admission-detail-card" aria-labelledby="admissionDetailTitle">
                            <fieldset>
                               <div class="admissions-section-heading">
                                  <span class="admissions-step blue">02</span>
                                  <div><span class="admissions-kicker blue-text">Detalle del lote</span><h2 id="admissionDetailTitle">Agregar medicamentos recibidos</h2><p>Vincula el producto y documenta su cantidad y fechas de control.</p></div>
                                </div>
                                <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:CESFAMConnectionString %>" SelectCommand="SELECT [id_farmaceuta] FROM [farmaceutico]"></asp:SqlDataSource>
                                <asp:Table runat="server" Width="100%" CssClass="admissions-form-table admission-detail-table">
                                    <asp:TableRow>
                                        <asp:TableCell>
                                            <asp:Label runat="server" ID="Label3" Text="ID Detalle:"></asp:Label>
                                        </asp:TableCell>
                                        <asp:TableCell>
                                            <asp:TextBox CssClass="form-control" runat="server" ID="txtIddetalle" placeholder="Ej. DET-001"></asp:TextBox>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell>
                                            <asp:Label runat="server" ID="Label8" Text="Cantidad:"></asp:Label>
                                        </asp:TableCell>
                                        <asp:TableCell>
                                            <asp:TextBox CssClass="form-control" runat="server" ID="txtCantidad" placeholder="Cantidad recibida"></asp:TextBox>
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
                                            <asp:Label runat="server" ID="Label5" Text="Código medicamento:"></asp:Label>
                                        </asp:TableCell>
                                        <asp:TableCell>
                                            <asp:DropDownList CssClass="form-select" ID="DropDownListCodigomedicamento" runat="server" DataSourceID="SqlDataSource5" DataTextField="codigo" DataValueField="codigo" Width="100%">
                                            </asp:DropDownList>
                                            <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:CESFAMConnectionString56 %>" SelectCommand="SELECT [codigo] FROM [medicamento]"></asp:SqlDataSource>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell>
                                            <asp:Label runat="server" ID="Label10" Text="ID Ingreso:"></asp:Label>
                                        </asp:TableCell>
                                        <asp:TableCell>
                                            <asp:DropDownList CssClass="form-select" ID="DropDownListIngresoid" runat="server" DataSourceID="SqlDataSource6" DataTextField="id_ingreso" DataValueField="id_ingreso" Width="100%"></asp:DropDownList>
                                            <asp:SqlDataSource ID="SqlDataSource6" runat="server" ConnectionString="<%$ ConnectionStrings:CESFAMConnectionString59 %>" SelectCommand="SELECT [id_ingreso] FROM [ingreso_medicamento]"></asp:SqlDataSource>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell ColumnSpan="2">
                                            <div class="admissions-feedback" aria-live="polite"><asp:Label runat="server" CssClass="alert-danger" ID="Label6"></asp:Label><asp:Label runat="server" CssClass="alert-success" ID="Label7"></asp:Label></div>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                </asp:Table>
                            </fieldset>
                        <div class="admissions-actions">
                            <asp:Button ID="btnGuardarDetalle" runat="server" CssClass="btn btn-primary admissions-primary-action" Text="Guardar lote" OnClick="btnGuardarDetalle_Click" />
                            <asp:Button ID="Button2" runat="server" CssClass="btn btn-dark" Text="Volver" OnClick="Volver_Click" />
                        </div>
                    </section>

                    <section class="admissions-card admissions-list-card batch-list-card" aria-labelledby="batchListTitle">
                        <div class="admissions-list-heading"><div><span class="admissions-kicker blue-text">Detalle de inventario</span><h2 id="batchListTitle">Lotes recibidos</h2><p>Revisa cantidades, fechas y productos asociados a cada ingreso.</p></div><span id="batchCount" class="admissions-count blue-count">Cargando…</span></div>
                        <div class="admissions-table-wrap">
                         <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="id_detalleIngr" DataSourceID="SqlDataSource3" CssClass="table table-dark admissions-table batch-table">
                              <Columns>
                                  <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                  <asp:BoundField DataField="id_detalleIngr" HeaderText="ID detalle" ReadOnly="True" SortExpression="id_detalleIngr" />
                                  <asp:BoundField DataField="cantidad" HeaderText="Cantidad" SortExpression="cantidad" />
                                  <asp:BoundField DataField="fecha_elaboracion" HeaderText="Elaboración" SortExpression="fecha_elaboracion" />
                                  <asp:BoundField DataField="fecha_vencimiento" HeaderText="Vencimiento" SortExpression="fecha_vencimiento" />
                                  <asp:BoundField DataField="medicamento_codigo" HeaderText="Código medicamento" ReadOnly="True" SortExpression="medicamento_codigo" />
                                  <asp:BoundField DataField="ingreso_medicamento_id_ingreso" HeaderText="ID ingreso" ReadOnly="True" SortExpression="ingreso_medicamento_id_ingreso" />
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
                    </section>
                </form>
        </div>
    </main>
    <script src="js/modern-shell.js"></script>
    <script>
        (function () {
            var admissionsTable = document.getElementById("<%= GridView1.ClientID %>");
            var batchesTable = document.getElementById("<%= GridView2.ClientID %>");
            var admissions = admissionsTable ? Math.max(admissionsTable.rows.length - 1, 0) : 0;
            var batchRows = batchesTable ? Array.prototype.slice.call(batchesTable.rows, 1) : [];
            var units = 0;
            batchRows.forEach(function (row) {
                if (row.cells.length > 2) units += parseInt(row.cells[2].textContent.trim(), 10) || 0;
            });
            document.getElementById("admissionCountHero").textContent = admissions;
            document.getElementById("batchCountHero").textContent = batchRows.length;
            document.getElementById("receivedUnitsHero").textContent = units;
            document.getElementById("admissionCount").textContent = admissions + (admissions === 1 ? " ingreso" : " ingresos");
            document.getElementById("batchCount").textContent = batchRows.length + (batchRows.length === 1 ? " lote" : " lotes");
        }());
    </script>
</body>
</html>
