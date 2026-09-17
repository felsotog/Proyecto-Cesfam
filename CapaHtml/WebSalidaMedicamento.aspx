<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebSalidaMedicamento.aspx.cs" CodePage="65001" Inherits="CapaHtml.WebSalidaMedicamento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Entregas de medicamentos</title>
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
    <link rel="stylesheet" href="css/entregas.css" />
</head>
<body class="form-control bg-light cesfam-shell-page">


    <main class="container example_container deliveries-page">
        <div class="deliveries-content">
            <div class="deliveries-hero">
                <div class="deliveries-hero-copy">
                    <span class="deliveries-eyebrow"><i class="fas fa-hand-holding-medical"></i> Dispensación farmacéutica</span>
                    <h1>Entregas de medicamentos</h1>
                    <p>Registra cada entrega al paciente y detalla los productos descontados del inventario.</p>
                </div>
                <div class="deliveries-metrics" aria-label="Resumen de entregas">
                    <div><strong id="deliveryCountHero">0</strong><small>Entregas</small></div>
                    <div><strong id="deliveryDetailCountHero">0</strong><small>Detalles</small></div>
                    <div><strong id="deliveredUnitsHero">0</strong><small>Unidades</small></div>
                </div>
            </div>
                <form id="formulario_registro" class="form-check" runat="server">
                    <section class="deliveries-card delivery-form-card" aria-labelledby="deliveryFormTitle">
                        <fieldset>
                            <div class="deliveries-section-heading">
                              <span class="deliveries-step">01</span>
                              <div><span class="deliveries-kicker">Entrega principal</span><h2 id="deliveryFormTitle">Registrar una entrega</h2><p>Identifica la fecha, el responsable y el paciente que recibe los medicamentos.</p></div>
                            </div>
                            <asp:Table runat="server" Width="100%" CssClass="deliveries-form-table delivery-main-table">
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label1" Text="ID Entrega:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtIdsalida" placeholder="Ej. ENT-001"></asp:TextBox>
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
                                        <asp:Label runat="server" ID="Label2" Text="RUT farmacéutico:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:DropDownList CssClass="form-select" ID="DropDownListRutFarm" runat="server" DataSourceID="SqlDataSource1" DataTextField="id_farmaceuta" DataValueField="id_farmaceuta" Width="100%">
                                        </asp:DropDownList>
                                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CESFAMConnectionString15 %>" SelectCommand="SELECT [id_farmaceuta] FROM [farmaceutico]"></asp:SqlDataSource>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label5" Text="RUT paciente:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                         <asp:DropDownList CssClass="form-select" ID="DropDownListRutP" runat="server" DataSourceID="SqlDataSource3" DataTextField="rut" DataValueField="rut" Width="100%">
                                         </asp:DropDownList>
                                         <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:CESFAMConnectionString74 %>" SelectCommand="SELECT [rut] FROM [paciente]"></asp:SqlDataSource>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell ColumnSpan="2">
                                        <div class="deliveries-feedback" aria-live="polite"><asp:Label runat="server" CssClass="alert-danger" ID="lblError"></asp:Label><asp:Label runat="server" CssClass="alert-success" ID="lblSucces"></asp:Label></div>
                                    </asp:TableCell>
                                </asp:TableRow>
                            </asp:Table>
                        </fieldset>
                        <div class="deliveries-actions">
                            <asp:Button ID="btnGuardar" runat="server" CssClass="btn btn-primary deliveries-primary-action" Text="Registrar entrega" OnClick="btnGuardar_Click1"/>
                            <asp:HyperLink ID="HyperLink1"  CssClass="btn btn-dark" runat="server" NavigateUrl="~/WebPaginaPrincipal.aspx">Volver</asp:HyperLink>
                        </div>
                    </section>
                    <section class="deliveries-card deliveries-list-card" aria-labelledby="deliveriesListTitle">
                     <div class="deliveries-list-heading"><div><span class="deliveries-kicker">Entregas registradas</span><h2 id="deliveriesListTitle">Historial de entregas</h2><p>Consulta la fecha, el profesional y el paciente asociado.</p></div><span id="deliveryCount" class="deliveries-count">Cargando…</span></div>
                     <div class="deliveries-table-wrap"><asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id_salida" DataSourceID="SqlDataSource2" CssClass="table table-dark deliveries-table">
                          <Columns>
                              <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                              <asp:BoundField DataField="id_salida" HeaderText="ID entrega" ReadOnly="True" SortExpression="id_salida" />
                              <asp:BoundField DataField="fecha_salida" HeaderText="Fecha" SortExpression="fecha_salida" />
                              <asp:BoundField DataField="farmaceutico_id_farmaceuta" HeaderText="RUT farmacéutico" ReadOnly="True" SortExpression="farmaceutico_id_farmaceuta" />
                              <asp:BoundField DataField="paciente_rut" HeaderText="RUT paciente" ReadOnly="True" SortExpression="paciente_rut" />
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
                    </div></section>

                    <section class="deliveries-card delivery-detail-card" aria-labelledby="deliveryDetailTitle">
                        <fieldset>
                            <div class="deliveries-section-heading">
                              <span class="deliveries-step amber">02</span>
                              <div><span class="deliveries-kicker amber-text">Detalle del despacho</span><h2 id="deliveryDetailTitle">Agregar medicamentos entregados</h2><p>Indica el producto y la cantidad asociada a una entrega existente.</p></div>
                            </div>
                            <asp:Table runat="server" Width="100%" CssClass="deliveries-form-table delivery-detail-table">
                               <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label4" Text="ID Detalle:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtIdDetalle" placeholder="Ej. DET-001"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                               <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label3" Text="Cantidad:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtCantidad" placeholder="Cantidad entregada"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label6" Text="Código medicamento:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:DropDownList CssClass="form-select" ID="DropDownListCodigoM" runat="server" DataSourceID="SqlDataSource4" DataTextField="codigo" DataValueField="codigo" Width="100%">
                                        </asp:DropDownList>
                                        <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:CESFAMConnectionString75 %>" SelectCommand="SELECT [codigo] FROM [medicamento]"></asp:SqlDataSource>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label7" Text="ID Salida:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                         <asp:DropDownList CssClass="form-select" ID="DropDownListIdSalida" runat="server" DataSourceID="SqlDataSource5" DataTextField="id_salida" DataValueField="id_salida" Width="100%">
                                         </asp:DropDownList>
                                         <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:CESFAMConnectionString76 %>" SelectCommand="SELECT [id_salida] FROM [salida_medicamento]"></asp:SqlDataSource>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell ColumnSpan="2">
                                        <div class="deliveries-feedback" aria-live="polite"><asp:Label runat="server" CssClass="alert-danger" ID="Label14"></asp:Label><asp:Label runat="server" CssClass="alert-success" ID="Label15"></asp:Label></div>
                                    </asp:TableCell>
                                </asp:TableRow>
                            </asp:Table>
                        </fieldset>
                        <div class="deliveries-actions">
                            <asp:Button ID="btnGuardarDetalle" runat="server" CssClass="btn btn-primary deliveries-primary-action" Text="Guardar detalle" EnableTheming="True" OnClick="btnGuardarDetalle_Click"/>
                            <asp:HyperLink ID="HyperLink2"  CssClass="btn btn-dark" runat="server" NavigateUrl="~/WebPaginaPrincipal.aspx">Volver</asp:HyperLink>
                        </div>
                    </section>
                    <section class="deliveries-card deliveries-list-card detail-list-card" aria-labelledby="deliveryDetailsListTitle">
                         <div class="deliveries-list-heading"><div><span class="deliveries-kicker amber-text">Productos dispensados</span><h2 id="deliveryDetailsListTitle">Detalle de entregas</h2><p>Revisa los medicamentos y cantidades descontadas del inventario.</p></div><span id="deliveryDetailCount" class="deliveries-count amber-count">Cargando…</span></div>
                         <div class="deliveries-table-wrap"><asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="id_detalleSalida" DataSourceID="SqlDataSource6" CssClass="table table-dark deliveries-table">
                              <Columns>
                                  <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                  <asp:BoundField DataField="id_detalleSalida" HeaderText="ID detalle" ReadOnly="True" SortExpression="id_detalleSalida" />
                                  <asp:BoundField DataField="cantidad" HeaderText="Cantidad" SortExpression="cantidad" />
                                  <asp:BoundField DataField="medicamento_codigo" HeaderText="Código medicamento" SortExpression="medicamento_codigo" />
                                  <asp:BoundField DataField="salida_medicamento_id_salida" HeaderText="ID entrega" SortExpression="salida_medicamento_id_salida" />
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
                    </div></section>
                </form>
        </div>
    </main>
    <script src="js/modern-shell.js"></script>
    <script>
        (function () {
            var deliveriesTable = document.getElementById("<%= GridView1.ClientID %>");
            var detailsTable = document.getElementById("<%= GridView2.ClientID %>");
            var deliveries = deliveriesTable ? Math.max(deliveriesTable.rows.length - 1, 0) : 0;
            var detailRows = detailsTable ? Array.prototype.slice.call(detailsTable.rows, 1) : [];
            var units = 0;
            detailRows.forEach(function (row) {
                if (row.cells.length > 2) units += parseInt(row.cells[2].textContent.trim(), 10) || 0;
            });
            document.getElementById("deliveryCountHero").textContent = deliveries;
            document.getElementById("deliveryDetailCountHero").textContent = detailRows.length;
            document.getElementById("deliveredUnitsHero").textContent = units;
            document.getElementById("deliveryCount").textContent = deliveries + (deliveries === 1 ? " entrega" : " entregas");
            document.getElementById("deliveryDetailCount").textContent = detailRows.length + (detailRows.length === 1 ? " detalle" : " detalles");
        }());
    </script>
</body>
</html>
