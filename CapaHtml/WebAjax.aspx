<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebAjax.aspx.cs" Inherits="CapaHtml.WebAjax" CodePage="65001" %>

<!doctype html>
<html lang="es">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Panel de gestión CESFAM</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <aside class="sidebar" id="sidebar" aria-label="Navegación principal">
            <a class="brand" href="WebAjax.aspx">
                <span class="brand-mark">+</span>
                <span><strong>CESFAM</strong><small>Gestión de farmacia</small></span>
            </a>
            <nav class="main-nav">
                <p class="nav-label">Principal</p>
                <a class="nav-item active" href="WebAjax.aspx"><span>▦</span> Resumen</a>
                <a class="nav-item" href="WebAgendamiento.aspx"><span>□</span> Agendamiento</a>
                <a class="nav-item" href="WebPaciente.aspx"><span>○</span> Pacientes</a>
                <p class="nav-label nav-label-spaced">Farmacia</p>
                <a class="nav-item" href="WebFarmacia.aspx"><span>✚</span> Farmacia</a>
                <a class="nav-item" href="WebMedicamento.aspx"><span>◫</span> Medicamentos</a>
                <a class="nav-item" href="WebIngresoMedicamento.aspx"><span>↓</span> Ingresos</a>
                <a class="nav-item" href="WebSalidaMedicamento.aspx"><span>↑</span> Entregas</a>
                <a class="nav-item" href="WebCaducarMedicamento.aspx"><span>×</span> Mermas</a>
            </nav>
            <div class="sidebar-footer"><i></i><span><strong>Sistema local</strong><small>ASP.NET · SQL Server</small></span></div>
        </aside>
        <button class="sidebar-backdrop" id="sidebarBackdrop" type="button" aria-label="Cerrar menú"></button>

        <header class="app-header">
            <div class="container d-flex flex-wrap align-items-center justify-content-between gap-3">
                <div class="header-title">
                    <button class="menu-button" id="menuButton" type="button" aria-label="Abrir menú">☰</button>
                    <div><p class="app-kicker mb-1">Panel administrativo</p><h1 class="h5 mb-0">Gestión de farmacia</h1></div>
                </div>
                <div class="header-actions">
                    <button id="refreshButton" class="refresh-button" type="button">↻ <span>Actualizar</span></button>
                    <button class="account-button" id="accountButton" type="button" aria-expanded="false">
                        <span class="account-avatar">MZ</span><span class="account-copy"><strong>Michael Zamorano</strong><small>Administrador</small></span>
                    </button>
                    <div class="account-menu" id="accountMenu" hidden>
                        <p><strong>Sesión activa</strong><span>Administrador CESFAM</span></p>
                        <a href="WebPaginaPrincipal.aspx">Ir a la página principal</a>
                    </div>
                </div>
            </div>
        </header>

        <main class="container py-5">
            <section class="welcome-panel">
                <div><p class="welcome-kicker">Centro de Salud Familiar</p><h2>Hola, Michael</h2><p>Revisa el inventario y accede a las operaciones principales de farmacia.</p></div>
                <span class="welcome-cross" aria-hidden="true">+</span>
            </section>
            <section aria-labelledby="summaryTitle">
                <div class="d-flex flex-wrap justify-content-between align-items-end gap-3 mb-4">
                    <div>
                        <p class="text-primary fw-semibold mb-1">Resumen</p>
                        <h2 id="summaryTitle" class="h4 mb-0">Estado general del sistema</h2>
                    </div>
                    <p id="lastUpdate" class="text-body-secondary small mb-0" aria-live="polite"></p>
                </div>

                <div id="summaryCards" class="row g-3" aria-live="polite">
                    <div class="col-12"><div class="alert alert-info">Cargando información...</div></div>
                </div>
            </section>

            <section class="mt-5" aria-labelledby="medicinesTitle">
                <div class="d-flex flex-wrap justify-content-between align-items-end gap-3 mb-3">
                    <div>
                        <p class="text-primary fw-semibold mb-1">Inventario</p>
                        <h2 id="medicinesTitle" class="h4 mb-0">Medicamentos registrados</h2>
                    </div>
                    <div class="inventory-search">
                        <label for="medicineSearch" class="form-label small fw-semibold mb-1">Buscar medicamento</label>
                        <input id="medicineSearch" class="form-control" type="search" placeholder="Nombre, código o tipo" autocomplete="off" />
                    </div>
                </div>

                <div class="table-responsive inventory-table">
                    <table class="table table-hover align-middle mb-0">
                        <thead>
                            <tr>
                                <th scope="col">Código</th>
                                <th scope="col">Medicamento</th>
                                <th scope="col">Tipo</th>
                                <th scope="col">Vencimiento</th>
                                <th scope="col">Estado</th>
                                <th scope="col" class="text-end">Cantidad</th>
                            </tr>
                        </thead>
                        <tbody id="medicinesBody">
                            <tr><td colspan="6" class="text-center py-4">Cargando inventario...</td></tr>
                        </tbody>
                    </table>
                </div>
            </section>

            <div id="errorMessage" class="alert alert-danger mt-4 d-none" role="alert"></div>
        </main>
    </form>

    <script>
        const summaryCards = document.querySelector("#summaryCards");
        const medicinesBody = document.querySelector("#medicinesBody");
        const errorMessage = document.querySelector("#errorMessage");
        const lastUpdate = document.querySelector("#lastUpdate");
        const refreshButton = document.querySelector("#refreshButton");
        const medicineSearch = document.querySelector("#medicineSearch");
        const sidebar = document.querySelector("#sidebar");
        const sidebarBackdrop = document.querySelector("#sidebarBackdrop");
        const menuButton = document.querySelector("#menuButton");
        const accountButton = document.querySelector("#accountButton");
        const accountMenu = document.querySelector("#accountMenu");
        let currentMedicines = [];

        async function callPageMethod(method) {
            // Los Page Methods de Web Forms esperan siempre una solicitud POST con contenido JSON.
            const response = await fetch(`WebAjax.aspx/${method}`, {
                method: "POST",
                headers: { "Content-Type": "application/json; charset=utf-8" },
                body: "{}"
            });

            if (!response.ok) {
                throw new Error(`El servidor respondió con estado ${response.status}.`);
            }

            const payload = await response.json();
            return payload.d;
        }

        function renderSummary(summary) {
            const items = [
                ["Ciudades", summary.Ciudades],
                ["Farmacias", summary.Farmacias],
                ["Medicamentos", summary.Medicamentos],
                ["Farmacéuticos", summary.Farmaceuticos],
                ["Personal", summary.Personal]
            ];

            summaryCards.innerHTML = items.map(([label, value]) => `
                <div class="col-6 col-lg">
                    <article class="summary-card h-100">
                        <strong>${value}</strong>
                        <span>${label}</span>
                    </article>
                </div>`).join("");
        }

        function renderMedicines(medicines) {
            if (!medicines.length) {
                medicinesBody.innerHTML = '<tr><td colspan="6" class="text-center py-4">No se encontraron medicamentos.</td></tr>';
                return;
            }

            medicinesBody.innerHTML = medicines.map(medicine => `
                <tr>
                    <td>${escapeHtml(medicine.Id)}</td>
                    <td>${escapeHtml(medicine.Nombre)}</td>
                    <td>${escapeHtml(medicine.Tipo)}</td>
                    <td>${escapeHtml(medicine.Vencimiento)}</td>
                    <td><span class="status-badge status-${statusClass(medicine.Estado)}">${escapeHtml(medicine.Estado)}</span></td>
                    <td class="text-end fw-semibold">${medicine.Cantidad}</td>
                </tr>`).join("");
        }

        function statusClass(status) {
            if (status === "Vencido") return "danger";
            if (status === "Por vencer") return "warning";
            return "success";
        }

        function filterMedicines() {
            const query = medicineSearch.value.trim().toLocaleLowerCase("es-CL");
            if (!query) {
                renderMedicines(currentMedicines);
                return;
            }

            renderMedicines(currentMedicines.filter(medicine =>
                [medicine.Id, medicine.Nombre, medicine.Tipo, medicine.Estado]
                    .some(value => String(value || "").toLocaleLowerCase("es-CL").includes(query))
            ));
        }

        function escapeHtml(value) {
            // textContent neutraliza etiquetas recibidas desde la base antes de insertarlas en la tabla.
            const element = document.createElement("span");
            element.textContent = value == null ? "" : String(value);
            return element.innerHTML;
        }

        async function loadDashboard() {
            refreshButton.disabled = true;
            errorMessage.classList.add("d-none");

            try {
                const [summary, medicines] = await Promise.all([
                    callPageMethod("CargarResumen"),
                    callPageMethod("ListarMedicamentos")
                ]);

                renderSummary(summary);
                currentMedicines = medicines;
                filterMedicines();
                lastUpdate.textContent = `Actualizado: ${new Date().toLocaleString("es-CL")}`;
            } catch (error) {
                summaryCards.innerHTML = '<div class="col-12"><div class="empty-state"><strong>Datos no disponibles</strong><span>Conecta la base CESFAM para ver los indicadores.</span></div></div>';
                medicinesBody.innerHTML = '<tr><td colspan="6" class="text-center py-4">El inventario estará disponible al conectar SQL Server.</td></tr>';
                errorMessage.textContent = "No fue posible cargar la información. Revisa la conexión a SQL Server y vuelve a intentarlo.";
                errorMessage.classList.remove("d-none");
            } finally {
                refreshButton.disabled = false;
            }
        }

        refreshButton.addEventListener("click", loadDashboard);
        medicineSearch.addEventListener("input", filterMedicines);
        menuButton.addEventListener("click", () => { sidebar.classList.add("is-open"); sidebarBackdrop.classList.add("is-visible"); });
        sidebarBackdrop.addEventListener("click", () => { sidebar.classList.remove("is-open"); sidebarBackdrop.classList.remove("is-visible"); });
        accountButton.addEventListener("click", () => { const open = accountMenu.hidden; accountMenu.hidden = !open; accountButton.setAttribute("aria-expanded", String(open)); });
        loadDashboard();
    </script>
</body>
</html>
