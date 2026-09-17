<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebMedico.aspx.cs" CodePage="65001" Inherits="CapaHtml.WebMedico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Médicos</title>
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
    <link rel="stylesheet" href="css/medicos.css" />
</head>
<body class="form-control bg-light cesfam-shell-page">
    <main class="container example_container doctors-page">
        <form id="formulario_registro" runat="server">
            <section class="doctors-hero" aria-labelledby="doctorsTitle">
                <div class="doctors-hero-copy">
                    <span class="doctors-eyebrow"><i class="fas fa-stethoscope"></i> Equipo de salud</span>
                    <h1 id="doctorsTitle">Gestión de médicos</h1>
                    <p>Administra los datos profesionales y de contacto del personal médico disponible en el CESFAM.</p>
                </div>
                <div class="doctors-metrics" aria-label="Resumen del equipo médico">
                    <div><strong id="doctorCountHero">0</strong><span>Médicos</span></div>
                    <i></i>
                    <div><strong id="specialtyCountHero">0</strong><span>Especialidades</span></div>
                </div>
                <div class="doctors-hero-symbol" aria-hidden="true"><i class="fas fa-user-md"></i></div>
            </section>

            <div class="doctors-layout">
                <section class="doctors-card doctors-form-card" aria-labelledby="doctorFormTitle">
                    <div class="doctors-section-heading">
                        <span class="doctors-section-icon"><i class="fas fa-user-plus"></i></span>
                        <div>
                            <span class="doctors-kicker">Nuevo integrante</span>
                            <h2 id="doctorFormTitle">Información del profesional</h2>
                            <p>Registra la identificación, especialidad y datos de contacto.</p>
                        </div>
                    </div>

                    <fieldset>
                        <legend class="visually-hidden">Datos del médico</legend>
                        <asp:Table runat="server" Width="100%" CssClass="doctors-form-table">
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
                                        <asp:Label runat="server" ID="Label2" Text="Especialidad:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtEspecialidad" placeholder="Ej. Medicina general"></asp:TextBox>
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
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtTelefono" placeholder="912345678"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label5" Text="Correo electrónico:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtEmail" placeholder="nombre@cesfam.cl"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell ColumnSpan="2">
                                        <div class="doctors-feedback" aria-live="polite">
                                            <asp:Label runat="server" CssClass="alert-danger" ID="lblError"></asp:Label>
                                            <asp:Label runat="server" CssClass="alert-success" ID="lblSucces"></asp:Label>
                                        </div>
                                    </asp:TableCell>
                                </asp:TableRow>
                        </asp:Table>
                    </fieldset>

                    <div class="doctors-actions">
                        <asp:Button ID="btnAgendar1" runat="server" CssClass="btn btn-primary doctors-primary-action" Text="Registrar médico" OnClick="btnAgendar1_Click"/>
                        <asp:HyperLink ID="HyperLink1" CssClass="btn btn-dark" runat="server" NavigateUrl="~/WebPaginaPrincipal.aspx">Volver</asp:HyperLink>
                    </div>
                </section>

                <aside class="doctors-side-panel" aria-label="Datos necesarios del equipo médico">
                    <div class="doctors-side-top">
                        <span class="doctors-side-icon"><i class="fas fa-notes-medical"></i></span>
                        <div><span class="doctors-kicker">Perfil profesional</span><h2>Directorio médico actualizado</h2></div>
                    </div>
                    <p>Mantener estos datos al día facilita la asignación de horas y la coordinación entre áreas.</p>
                    <ol>
                        <li><span>01</span><div><strong>Identificación</strong><small>RUT y nombre del profesional</small></div></li>
                        <li><span>02</span><div><strong>Área clínica</strong><small>Especialidad médica vigente</small></div></li>
                        <li><span>03</span><div><strong>Contacto</strong><small>Teléfono, correo y dirección</small></div></li>
                    </ol>
                </aside>
            </div>

            <section class="doctors-card doctors-list-card" aria-labelledby="doctorListTitle">
                <div class="doctors-list-heading">
                    <div>
                        <span class="doctors-kicker">Equipo registrado</span>
                        <h2 id="doctorListTitle">Directorio de médicos</h2>
                        <p>Consulta y actualiza los antecedentes del personal médico.</p>
                    </div>
                    <span id="doctorCount" class="doctors-count">Cargando médicos…</span>
                </div>
                <div class="doctors-table-wrap">
                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="rut_medico" DataSourceID="SqlDataSource2" CssClass="table table-dark doctors-table">
                              <Columns>
                                  <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                  <asp:BoundField DataField="rut_medico" HeaderText="RUT" ReadOnly="True" SortExpression="rut_medico" />
                                  <asp:BoundField DataField="nombre_completo" HeaderText="Nombre completo" SortExpression="nombre_completo" />
                                  <asp:BoundField DataField="especialidad" HeaderText="Especialidad" SortExpression="especialidad" />
                                  <asp:BoundField DataField="direccion" HeaderText="Dirección" SortExpression="direccion" />
                                  <asp:BoundField DataField="telefono" HeaderText="Teléfono" SortExpression="telefono" />
                                  <asp:BoundField DataField="email" HeaderText="Correo electrónico" SortExpression="email" />
                              </Columns>
                    </asp:GridView>
                </div>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:CESFAMConnectionString34 %>" DeleteCommand="DELETE FROM [medico] WHERE [rut_medico] = @original_rut_medico AND (([nombre_completo] = @original_nombre_completo) OR ([nombre_completo] IS NULL AND @original_nombre_completo IS NULL)) AND (([especialidad] = @original_especialidad) OR ([especialidad] IS NULL AND @original_especialidad IS NULL)) AND (([direccion] = @original_direccion) OR ([direccion] IS NULL AND @original_direccion IS NULL)) AND (([telefono] = @original_telefono) OR ([telefono] IS NULL AND @original_telefono IS NULL)) AND (([email] = @original_email) OR ([email] IS NULL AND @original_email IS NULL))" InsertCommand="INSERT INTO [medico] ([rut_medico], [nombre_completo], [especialidad], [direccion], [telefono], [email]) VALUES (@rut_medico, @nombre_completo, @especialidad, @direccion, @telefono, @email)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [medico]" UpdateCommand="UPDATE [medico] SET [nombre_completo] = @nombre_completo, [especialidad] = @especialidad, [direccion] = @direccion, [telefono] = @telefono, [email] = @email WHERE [rut_medico] = @original_rut_medico AND (([nombre_completo] = @original_nombre_completo) OR ([nombre_completo] IS NULL AND @original_nombre_completo IS NULL)) AND (([especialidad] = @original_especialidad) OR ([especialidad] IS NULL AND @original_especialidad IS NULL)) AND (([direccion] = @original_direccion) OR ([direccion] IS NULL AND @original_direccion IS NULL)) AND (([telefono] = @original_telefono) OR ([telefono] IS NULL AND @original_telefono IS NULL)) AND (([email] = @original_email) OR ([email] IS NULL AND @original_email IS NULL))">
                              <DeleteParameters>
                                  <asp:Parameter Name="original_rut_medico" Type="String" />
                                  <asp:Parameter Name="original_nombre_completo" Type="String" />
                                  <asp:Parameter Name="original_especialidad" Type="String" />
                                  <asp:Parameter Name="original_direccion" Type="String" />
                                  <asp:Parameter Name="original_telefono" Type="String" />
                                  <asp:Parameter Name="original_email" Type="String" />
                              </DeleteParameters>
                              <InsertParameters>
                                  <asp:Parameter Name="rut_medico" Type="String" />
                                  <asp:Parameter Name="nombre_completo" Type="String" />
                                  <asp:Parameter Name="especialidad" Type="String" />
                                  <asp:Parameter Name="direccion" Type="String" />
                                  <asp:Parameter Name="telefono" Type="String" />
                                  <asp:Parameter Name="email" Type="String" />
                              </InsertParameters>
                              <UpdateParameters>
                                  <asp:Parameter Name="nombre_completo" Type="String" />
                                  <asp:Parameter Name="especialidad" Type="String" />
                                  <asp:Parameter Name="direccion" Type="String" />
                                  <asp:Parameter Name="telefono" Type="String" />
                                  <asp:Parameter Name="email" Type="String" />
                                  <asp:Parameter Name="original_rut_medico" Type="String" />
                                  <asp:Parameter Name="original_nombre_completo" Type="String" />
                                  <asp:Parameter Name="original_especialidad" Type="String" />
                                  <asp:Parameter Name="original_direccion" Type="String" />
                                  <asp:Parameter Name="original_telefono" Type="String" />
                                  <asp:Parameter Name="original_email" Type="String" />
                              </UpdateParameters>
                </asp:SqlDataSource>
            </section>
        </form>
    </main>
    <script src="js/modern-shell.js"></script>
    <script>
        (function () {
            var table = document.getElementById("<%= GridView2.ClientID %>");
            var rows = table ? Array.prototype.slice.call(table.rows, 1) : [];
            var total = rows.length;
            var specialties = new Set();
            rows.forEach(function (row) {
                if (row.cells.length > 3) {
                    var specialty = row.cells[3].textContent.trim().toLowerCase();
                    if (specialty) specialties.add(specialty);
                }
            });
            document.getElementById("doctorCountHero").textContent = total;
            document.getElementById("specialtyCountHero").textContent = specialties.size;
            document.getElementById("doctorCount").textContent = total + (total === 1 ? " médico" : " médicos");
        }());
    </script>
</body>
</html>
