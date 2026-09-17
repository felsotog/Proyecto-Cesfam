<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebAgendamiento.aspx.cs" CodePage="65001" Inherits="CapaHtml.WebAgendamiento" %>

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
    <link rel="stylesheet" href="css/modern-shell.css" />
    <link rel="stylesheet" href="css/agendamiento.css" />
</head>
<body class="form-control bg-light cesfam-shell-page">
    <main class="container example_container appointment-page">
        <form id="formulario_registro" runat="server">
            <section class="appointment-hero" aria-labelledby="appointmentTitle">
                <div class="appointment-hero-copy">
                    <span class="appointment-eyebrow"><i class="far fa-calendar-alt"></i> Agenda clínica</span>
                    <h1 id="appointmentTitle">Gestión de agendamientos</h1>
                    <p>Registra nuevas horas médicas y administra las citas existentes desde un solo lugar.</p>
                </div>
                <div class="appointment-hero-icon" aria-hidden="true">
                    <i class="fas fa-calendar-check"></i>
                </div>
            </section>

            <div class="appointment-layout">
                <section class="appointment-card appointment-form-card" aria-labelledby="newAppointmentTitle">
                    <div class="appointment-section-heading">
                        <span class="appointment-section-icon"><i class="fas fa-plus"></i></span>
                        <div>
                            <span class="appointment-section-kicker">Nueva atención</span>
                            <h2 id="newAppointmentTitle">Agendar una hora</h2>
                            <p>Completa los datos de la cita y confirma el registro.</p>
                        </div>
                    </div>

                    <fieldset>
                        <legend class="visually-hidden">Datos de agendamiento</legend>
                        <asp:Table runat="server" Width="100%" CssClass="appointment-form-table">
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="lblNombres" Text="ID Agendamiento:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtIdAgendamiento" placeholder="AA1111"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="lblCalendario" Text="Horario:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="Calendario" TextMode="Date"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label1" Text="Rut Medico:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtRutMedico" placeholder="1-8"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label runat="server" ID="Label2" Text="Rut Paciente:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtRutPaciente" placeholder="1-9"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell ColumnSpan="2">
                                        <div class="appointment-feedback" aria-live="polite">
                                            <asp:Label runat="server" CssClass="alert-danger" ID="lblError"></asp:Label>
                                            <asp:Label runat="server" CssClass="alert-success" ID="lblSucces"></asp:Label>
                                        </div>
                                    </asp:TableCell>
                                </asp:TableRow>
                        </asp:Table>
                    </fieldset>

                    <div class="appointment-actions">
                        <asp:Button ID="btnAgendar1" runat="server" CssClass="btn btn-primary appointment-primary-action" Text="Agendar hora" OnClick="btnAgendar_Click"/>
                        <asp:Button ID="Volver" runat="server" CssClass="btn btn-dark" Text="Volver" OnClick="Volver_Click" />
                    </div>
                </section>

                <aside class="appointment-guide" aria-label="Información para agendar">
                    <div class="appointment-guide-icon"><i class="far fa-clock"></i></div>
                    <span class="appointment-section-kicker">Antes de agendar</span>
                    <h2>Verifica los datos de la atención</h2>
                    <p>Confirma que el médico y el paciente estén registrados antes de crear la cita.</p>
                    <ul>
                        <li><i class="fas fa-check"></i><span>Usa el identificador asignado al agendamiento.</span></li>
                        <li><i class="fas fa-check"></i><span>Selecciona la fecha acordada con el paciente.</span></li>
                        <li><i class="fas fa-check"></i><span>Revisa ambos RUT antes de guardar.</span></li>
                    </ul>
                </aside>
            </div>

            <section class="appointment-card appointment-list-card" aria-labelledby="appointmentsListTitle">
                <div class="appointment-list-heading">
                    <div>
                        <span class="appointment-section-kicker">Agenda registrada</span>
                        <h2 id="appointmentsListTitle">Horas programadas</h2>
                        <p>Consulta, modifica o elimina las atenciones registradas.</p>
                    </div>
                    <span id="appointmentCount" class="appointment-count">Cargando horas…</span>
                </div>
                <div class="appointment-table-wrap">
                    <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="id_agendamiento" DataSourceID="SqlDataSource1" CssClass="table table-dark appointment-table">
                              <Columns>
                                  <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                  <asp:BoundField DataField="id_agendamiento" HeaderText="ID Agendamiento" ReadOnly="True" SortExpression="id_agendamiento" />
                                  <asp:BoundField DataField="horario" HeaderText="Horario" SortExpression="horario" />
                                  <asp:BoundField DataField="paciente_rut" HeaderText="Rut Paciente" ReadOnly="True" SortExpression="paciente_rut" />
                                  <asp:BoundField DataField="medico_rut_medico" HeaderText="Rut Medico" ReadOnly="True" SortExpression="medico_rut_medico" />
                              </Columns>
                    </asp:GridView>
                </div>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:CESFAMConnectionString19 %>" DeleteCommand="DELETE FROM [agendamiento] WHERE [id_agendamiento] = @original_id_agendamiento AND (([horario] = @original_horario) OR ([horario] IS NULL AND @original_horario IS NULL)) AND (([paciente_rut] = @original_paciente_rut) OR ([paciente_rut] IS NULL AND @original_paciente_rut IS NULL)) AND (([medico_rut_medico] = @original_medico_rut_medico) OR ([medico_rut_medico] IS NULL AND @original_medico_rut_medico IS NULL))" InsertCommand="INSERT INTO [agendamiento] ([id_agendamiento], [horario], [paciente_rut], [medico_rut_medico]) VALUES (@id_agendamiento, @horario, @paciente_rut, @medico_rut_medico)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [agendamiento]" UpdateCommand="UPDATE [agendamiento] SET [horario] = @horario, [paciente_rut] = @paciente_rut, [medico_rut_medico] = @medico_rut_medico WHERE [id_agendamiento] = @original_id_agendamiento AND (([horario] = @original_horario) OR ([horario] IS NULL AND @original_horario IS NULL)) AND (([paciente_rut] = @original_paciente_rut) OR ([paciente_rut] IS NULL AND @original_paciente_rut IS NULL)) AND (([medico_rut_medico] = @original_medico_rut_medico) OR ([medico_rut_medico] IS NULL AND @original_medico_rut_medico IS NULL))">
                              <DeleteParameters>
                                  <asp:Parameter Name="original_id_agendamiento" Type="String" />
                                  <asp:Parameter DbType="Date" Name="original_horario" />
                                  <asp:Parameter Name="original_paciente_rut" Type="String" />
                                  <asp:Parameter Name="original_medico_rut_medico" Type="String" />
                              </DeleteParameters>
                              <InsertParameters>
                                  <asp:Parameter Name="id_agendamiento" Type="String" />
                                  <asp:Parameter DbType="Date" Name="horario" />
                                  <asp:Parameter Name="paciente_rut" Type="String" />
                                  <asp:Parameter Name="medico_rut_medico" Type="String" />
                              </InsertParameters>
                              <UpdateParameters>
                                  <asp:Parameter DbType="Date" Name="horario" />
                                  <asp:Parameter Name="paciente_rut" Type="String" />
                                  <asp:Parameter Name="medico_rut_medico" Type="String" />
                                  <asp:Parameter Name="original_id_agendamiento" Type="String" />
                                  <asp:Parameter DbType="Date" Name="original_horario" />
                                  <asp:Parameter Name="original_paciente_rut" Type="String" />
                                  <asp:Parameter Name="original_medico_rut_medico" Type="String" />
                              </UpdateParameters>
                </asp:SqlDataSource>
            </section>
        </form>
    </main>
    <script src="js/modern-shell.js"></script>
    <script>
        (function () {
            var table = document.getElementById("<%= GridView1.ClientID %>");
            var counter = document.getElementById("appointmentCount");
            if (!counter) return;
            var total = table ? Math.max(table.rows.length - 1, 0) : 0;
            counter.textContent = total + (total === 1 ? " hora registrada" : " horas registradas");
        }());
    </script>
</body>
</html>
