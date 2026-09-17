<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFichaPaciente.aspx.cs" CodePage="65001" Inherits="CapaHtml.WebFichaPaciente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Fichas clínicas</title>
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
    <link rel="stylesheet" href="css/ficha-clinica.css" />
</head>
<body class="form-control bg-light cesfam-shell-page">
    <main class="container example_container records-page">
        <form id="formulario_registro" runat="server">
            <section class="records-hero" aria-labelledby="recordsTitle">
                <div class="records-hero-copy">
                    <span class="records-eyebrow"><i class="fas fa-file-medical-alt"></i> Información asistencial</span>
                    <h1 id="recordsTitle">Fichas clínicas</h1>
                    <p>Vincula cada atención con el paciente, el profesional responsable y sus indicaciones asociadas.</p>
                </div>
                <div class="records-hero-stats" aria-label="Resumen de fichas clínicas">
                    <div><i class="fas fa-folder-open"></i><span><strong id="recordCountHero">0</strong><small>Fichas</small></span></div>
                    <div><i class="fas fa-clipboard-list"></i><span><strong id="detailCountHero">0</strong><small>Detalles</small></span></div>
                </div>
            </section>

            <div class="records-layout">
                <section class="records-card records-form-card" aria-labelledby="recordFormTitle">
                    <div class="records-section-heading">
                        <span class="records-step">01</span>
                        <div>
                            <span class="records-kicker">Ficha principal</span>
                            <h2 id="recordFormTitle">Crear ficha clínica</h2>
                            <p>Asocia una fecha, un médico y un paciente al nuevo registro.</p>
                        </div>
                    </div>
                    <fieldset>
                        <legend class="visually-hidden">Datos de la ficha clínica</legend>
                        <asp:Table runat="server" Width="100%" CssClass="records-form-table">
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label1" Text="ID Ficha:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtIdficha" placeholder="Ej. FIC-001"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="lblCalendario" Text="Fecha:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtCalendario" TextMode="Date"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label2" Text="RUT médico:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                         <asp:DropDownList CssClass="form-select" ID="DropDownListrutmedico" runat="server" DataSourceID="SqlDataSource1" DataTextField="rut_medico" DataValueField="rut_medico" Width="100%">
                                         </asp:DropDownList>
                                         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CESFAMConnectionString2 %>" SelectCommand="SELECT [rut_medico] FROM [medico]"></asp:SqlDataSource>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label3" Text="RUT paciente:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                          <asp:DropDownList CssClass="form-select" ID="DropDownListRutPac" runat="server" DataSourceID="SqlDataSource3" DataTextField="rut" DataValueField="rut" Width="100%">
                                          </asp:DropDownList>
                                          <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:CESFAMConnectionString66 %>" SelectCommand="SELECT [rut] FROM [paciente]"></asp:SqlDataSource>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell ColumnSpan="2">
                                        <div class="records-feedback" aria-live="polite">
                                            <asp:Label runat="server" CssClass="alert-danger" ID="lblError"></asp:Label>
                                            <asp:Label runat="server" CssClass="alert-success" ID="lblSucces"></asp:Label>
                                        </div>
                                    </asp:TableCell>
                                </asp:TableRow>
                        </asp:Table>
                    </fieldset>
                    <div class="records-actions">
                        <asp:Button ID="btnGuardar" runat="server" CssClass="btn btn-primary records-primary-action" Text="Crear ficha" OnClick="btnGuardar_Click" />
                        <asp:HyperLink ID="HyperLink1" CssClass="btn btn-dark" runat="server" NavigateUrl="~/WebPaginaPrincipal.aspx">Volver</asp:HyperLink>
                    </div>
                </section>

                <aside class="records-guide" aria-label="Flujo de la ficha clínica">
                    <span class="records-guide-icon"><i class="fas fa-heartbeat"></i></span>
                    <span class="records-kicker">Flujo clínico</span>
                    <h2>Del registro a la indicación</h2>
                    <p>Primero crea la ficha principal. Luego agrega el detalle y vincula el formulario de medicamento correspondiente.</p>
                    <div class="records-flow">
                        <div><span>1</span><strong>Seleccionar paciente y médico</strong></div>
                        <i></i>
                        <div><span>2</span><strong>Crear la ficha clínica</strong></div>
                        <i></i>
                        <div><span>3</span><strong>Agregar indicaciones</strong></div>
                    </div>
                </aside>
            </div>

            <section class="records-card records-list-card" aria-labelledby="recordsListTitle">
                <div class="records-list-heading">
                    <div><span class="records-kicker">Registros principales</span><h2 id="recordsListTitle">Fichas creadas</h2><p>Consulta la fecha y las personas asociadas a cada ficha.</p></div>
                    <span id="recordCount" class="records-count">Cargando fichas…</span>
                </div>
                <div class="records-table-wrap">
                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="id_ficha" DataSourceID="SqlDataSource2" CssClass="table table-dark records-table">
                             <Columns>
                                 <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                 <asp:BoundField DataField="id_ficha" HeaderText="ID ficha" ReadOnly="True" SortExpression="id_ficha" />
                                 <asp:BoundField DataField="fecha_ficha" HeaderText="Fecha" SortExpression="fecha_ficha" />
                                 <asp:BoundField DataField="medico_rut_medico" HeaderText="RUT médico" SortExpression="medico_rut_medico" />
                                 <asp:BoundField DataField="paciente_rut" HeaderText="RUT paciente" SortExpression="paciente_rut" />
                             </Columns>
                    </asp:GridView>
                </div>
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
            </section>

            <section class="records-detail-section" aria-labelledby="detailFormTitle">
                <div class="records-detail-intro">
                    <span class="records-step warm">02</span>
                    <span class="records-kicker">Detalle asistencial</span>
                    <h2 id="detailFormTitle">Agregar indicaciones a una ficha</h2>
                    <p>Relaciona la ficha creada con un formulario de medicamento y registra observaciones relevantes.</p>
                    <div class="records-note"><i class="fas fa-info-circle"></i><span>La ficha y el formulario deben existir antes de crear este detalle.</span></div>
                </div>
                <div class="records-detail-form">
                    <fieldset>
                        <legend class="visually-hidden">Datos del detalle clínico</legend>
                        <asp:Table runat="server" Width="100%" CssClass="records-form-table detail-form-table">
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label8" Text="ID Detalle:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtIdDetalle" placeholder="Ej. DET-001"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label9" Text="ID Formulario Medicamento:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                         <asp:DropDownList CssClass="form-select" ID="DropDownListIdForm" runat="server" DataSourceID="SqlDataSource4" DataTextField="id_formulario" DataValueField="id_formulario" Width="100%">
                                         </asp:DropDownList>
                                         <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:CESFAMConnectionString67 %>" SelectCommand="SELECT [id_formulario] FROM [formulario_medicamento]"></asp:SqlDataSource>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label4" Text="ID Ficha:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                          <asp:DropDownList CssClass="form-select" ID="DropDownListIdFicha" runat="server" DataSourceID="SqlDataSource2" DataTextField="id_ficha" DataValueField="id_ficha" Width="100%">
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
                                        <div class="records-feedback" aria-live="polite">
                                            <asp:Label runat="server" CssClass="alert-danger" ID="Label10"></asp:Label>
                                            <asp:Label runat="server" CssClass="alert-success" ID="Label11"></asp:Label>
                                        </div>
                                    </asp:TableCell>
                                </asp:TableRow>
                        </asp:Table>
                    </fieldset>
                    <div class="records-actions">
                        <asp:Button ID="btnGuardarDetalle" runat="server" CssClass="btn btn-primary records-primary-action" Text="Guardar detalle" OnClick="btnGuardarDetalle_Click" />
                        <asp:HyperLink ID="HyperLink2" CssClass="btn btn-dark" runat="server" NavigateUrl="~/WebPaginaPrincipal.aspx">Volver</asp:HyperLink>
                    </div>
                </div>
            </section>

            <section class="records-card records-list-card" aria-labelledby="detailsListTitle">
                <div class="records-list-heading">
                    <div><span class="records-kicker warm-text">Seguimiento clínico</span><h2 id="detailsListTitle">Detalles registrados</h2><p>Revisa los formularios y comentarios vinculados a cada ficha.</p></div>
                    <span id="detailCount" class="records-count warm-count">Cargando detalles…</span>
                </div>
                <div class="records-table-wrap">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id_detalle_ficha" DataSourceID="SqlDataSource6" CssClass="table table-dark records-table details-table">
                          <Columns>
                              <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                              <asp:BoundField DataField="id_detalle_ficha" HeaderText="ID detalle" ReadOnly="True" SortExpression="id_detalle_ficha" />
                              <asp:BoundField DataField="ficha_paciente_id_ficha" HeaderText="ID ficha" SortExpression="ficha_paciente_id_ficha" />
                              <asp:BoundField DataField="formulario_medicamento_id_formulario" HeaderText="Formulario medicamento" SortExpression="formulario_medicamento_id_formulario" />
                              <asp:BoundField DataField="comentarios" HeaderText="Comentarios" SortExpression="comentarios" />
                          </Columns>
                    </asp:GridView>
                </div>
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
            </section>
        </form>
    </main>
    <script src="js/modern-shell.js"></script>
    <script>
        (function () {
            var recordsTable = document.getElementById("<%= GridView2.ClientID %>");
            var detailsTable = document.getElementById("<%= GridView1.ClientID %>");
            var records = recordsTable ? Math.max(recordsTable.rows.length - 1, 0) : 0;
            var details = detailsTable ? Math.max(detailsTable.rows.length - 1, 0) : 0;
            document.getElementById("recordCountHero").textContent = records;
            document.getElementById("detailCountHero").textContent = details;
            document.getElementById("recordCount").textContent = records + (records === 1 ? " ficha" : " fichas");
            document.getElementById("detailCount").textContent = details + (details === 1 ? " detalle" : " detalles");
        }());
    </script>
</body>
</html>
