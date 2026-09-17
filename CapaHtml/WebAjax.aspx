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
                <div><p class="welcome-kicker">Centro de Salud Familiar</p><h2>Hola, Michael</h2><p>Revisa el inventario, las alertas y la actividad de farmacia desde un solo lugar.</p></div>
                <div class="welcome-meta"><span class="live-indicator"><i></i> Sistema operativo</span><strong id="currentDate"></strong></div>
                <span class="welcome-cross" aria-hidden="true">+</span>
            </section>
            <section aria-labelledby="summaryTitle">
                <div class="d-flex flex-wrap justify-content-between align-items-end gap-3 mb-4">
                    <div>
                        <p class="text-primary fw-semibold mb-1">Resumen</p>
                        <h2 id="summaryTitle" class="h4 mb-0">Estado general del sistema</h2>
                    </div>
                    <div class="summary-meta"><span id="dataModeBadge" class="data-mode-badge">Datos del sistema</span><p id="lastUpdate" class="text-body-secondary small mb-0" aria-live="polite"></p></div>
                </div>

                <div id="summaryCards" class="summary-grid" aria-live="polite">
                    <div class="loading-card">Cargando información...</div>
                </div>
            </section>

            <section class="analytics-grid" aria-label="Análisis del inventario">
                <article class="dashboard-card distribution-card">
                    <div class="card-heading"><div><p class="app-kicker">Inventario</p><h2>Distribución por estado</h2></div><span class="card-period">Actual</span></div>
                    <div class="distribution-content">
                        <div class="donut-chart" id="statusDonut" role="img" aria-label="Distribución del estado del inventario"><div><strong id="donutTotal">0</strong><span>registros</span></div></div>
                        <div class="chart-legend" id="statusLegend"></div>
                    </div>
                </article>

                <article class="dashboard-card stock-card">
                    <div class="card-heading"><div><p class="app-kicker">Existencias</p><h2>Stock por categoría</h2></div><span class="card-period">Unidades</span></div>
                    <div class="bar-chart" id="stockChart"></div>
                </article>

                <article class="dashboard-card alerts-card">
                    <div class="card-heading"><div><p class="app-kicker">Atención</p><h2>Alertas de inventario</h2></div><a href="WebCaducarMedicamento.aspx">Ver mermas</a></div>
                    <div class="alerts-list" id="inventoryAlerts"></div>
                </article>
            </section>

            <section class="quick-actions" aria-labelledby="actionsTitle">
                <div><p class="app-kicker">Operaciones</p><h2 id="actionsTitle">Accesos rápidos</h2></div>
                <div class="quick-actions-list">
                    <a href="WebIngresoMedicamento.aspx"><span>↓</span><div><strong>Registrar ingreso</strong><small>Agregar existencias</small></div><b>→</b></a>
                    <a href="WebSalidaMedicamento.aspx"><span>↑</span><div><strong>Registrar entrega</strong><small>Salida a paciente</small></div><b>→</b></a>
                    <a href="WebReservaMedicamento.aspx"><span>◷</span><div><strong>Nueva reserva</strong><small>Separar medicamento</small></div><b>→</b></a>
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
        const dataModeBadge = document.querySelector("#dataModeBadge");
        const statusDonut = document.querySelector("#statusDonut");
        const statusLegend = document.querySelector("#statusLegend");
        const donutTotal = document.querySelector("#donutTotal");
        const stockChart = document.querySelector("#stockChart");
        const inventoryAlerts = document.querySelector("#inventoryAlerts");
        let currentMedicines = [];

        // Estos datos permiten revisar la interfaz cuando la base local aún no está restaurada.
        const demoSummary = { Ciudades: 4, Farmacias: 3, Medicamentos: 128, Farmaceuticos: 8, Personal: 26 };
        const demoMedicines = [
            { Id: "MED-101", Nombre: "Paracetamol 500 mg", Tipo: "Analgésicos", Vencimiento: "18-12-2027", Estado: "Disponible", Cantidad: 186 },
            { Id: "MED-118", Nombre: "Ibuprofeno 400 mg", Tipo: "Antiinflamatorios", Vencimiento: "04-08-2027", Estado: "Disponible", Cantidad: 142 },
            { Id: "MED-132", Nombre: "Amoxicilina 500 mg", Tipo: "Antibióticos", Vencimiento: "21-11-2026", Estado: "Por vencer", Cantidad: 18 },
            { Id: "MED-144", Nombre: "Loratadina 10 mg", Tipo: "Antialérgicos", Vencimiento: "15-03-2027", Estado: "Disponible", Cantidad: 76 },
            { Id: "MED-157", Nombre: "Metformina 850 mg", Tipo: "Crónicos", Vencimiento: "09-10-2027", Estado: "Disponible", Cantidad: 121 },
            { Id: "MED-163", Nombre: "Omeprazol 20 mg", Tipo: "Gastrointestinal", Vencimiento: "28-09-2026", Estado: "Por vencer", Cantidad: 12 },
            { Id: "MED-171", Nombre: "Salbutamol inhalador", Tipo: "Respiratorios", Vencimiento: "30-06-2026", Estado: "Vencido", Cantidad: 7 }
        ];

        async function callPageMethod(method) {
            // Los Page Methods de Web Forms esperan siempre una solicitud POST con contenido JSON.
            const controller = new AbortController();
            const timeout = window.setTimeout(() => controller.abort(), 8000);
            try {
                const response = await fetch(`WebAjax.aspx/${method}`, {
                    method: "POST",
                    headers: { "Content-Type": "application/json; charset=utf-8" },
                    body: "{}",
                    signal: controller.signal
                });

                if (!response.ok) throw new Error(`El servidor respondió con estado ${response.status}.`);
                const payload = await response.json();
                return payload.d;
            } finally {
                window.clearTimeout(timeout);
            }
        }

        function renderSummary(summary) {
            const items = [
                ["Medicamentos", summary.Medicamentos, "◫", "Inventario total"],
                ["Farmacias", summary.Farmacias, "+", "Centros registrados"],
                ["Farmacéuticos", summary.Farmaceuticos, "◇", "Equipo de farmacia"],
                ["Personal", summary.Personal, "○", "Usuarios del sistema"],
                ["Ciudades", summary.Ciudades, "⌖", "Cobertura disponible"]
            ];

            summaryCards.innerHTML = items.map(([label, value, icon, detail], index) => `
                <article class="summary-card ${index === 0 ? "summary-card-primary" : ""}">
                    <span class="summary-card-icon">${icon}</span>
                    <div><span>${label}</span><strong>${value}</strong><small>${detail}</small></div>
                </article>`).join("");
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

        function renderAnalytics(medicines) {
            const counts = medicines.reduce((result, medicine) => {
                const key = statusClass(medicine.Estado);
                result[key] += 1;
                return result;
            }, { success: 0, warning: 0, danger: 0 });
            const total = Math.max(medicines.length, 1);
            const availableEnd = (counts.success / total) * 100;
            const warningEnd = availableEnd + (counts.warning / total) * 100;

            statusDonut.style.background = `conic-gradient(#0d9870 0 ${availableEnd}%, #e7ad35 ${availableEnd}% ${warningEnd}%, #df5c5c ${warningEnd}% 100%)`;
            donutTotal.textContent = medicines.length;
            statusLegend.innerHTML = [
                ["Disponibles", counts.success, "#0d9870"],
                ["Por vencer", counts.warning, "#e7ad35"],
                ["Vencidos", counts.danger, "#df5c5c"]
            ].map(([label, value, color]) => `<div><span><i style="background:${color}"></i>${label}</span><strong>${value}</strong></div>`).join("");

            const categoryTotals = medicines.reduce((result, medicine) => {
                const category = medicine.Tipo || "Sin categoría";
                result[category] = (result[category] || 0) + Number(medicine.Cantidad || 0);
                return result;
            }, {});
            const categories = Object.entries(categoryTotals).sort((a, b) => b[1] - a[1]).slice(0, 5);
            const highestStock = Math.max(...categories.map(([, value]) => value), 1);
            stockChart.innerHTML = categories.map(([label, value]) => `
                <div class="bar-row"><div><span>${escapeHtml(label)}</span><strong>${value}</strong></div><div class="bar-track"><i style="width:${Math.max((value / highestStock) * 100, 4)}%"></i></div></div>`).join("");

            const alerts = medicines.filter(medicine => statusClass(medicine.Estado) !== "success" || Number(medicine.Cantidad) < 20).slice(0, 4);
            inventoryAlerts.innerHTML = alerts.length ? alerts.map(medicine => `
                <div class="alert-item"><span class="alert-icon alert-level-${statusClass(medicine.Estado)}">${statusClass(medicine.Estado) === "danger" ? "!" : "↓"}</span>
                <div><strong>${escapeHtml(medicine.Nombre)}</strong><small>${escapeHtml(medicine.Estado)} · ${medicine.Cantidad} unidades</small></div><a href="WebMedicamento.aspx">Revisar</a></div>`).join("")
                : '<div class="all-clear"><span>✓</span><strong>Inventario sin alertas</strong><small>No hay existencias que requieran atención.</small></div>';
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
                renderAnalytics(medicines);
                filterMedicines();
                dataModeBadge.textContent = "Datos del sistema";
                dataModeBadge.classList.remove("demo");
                lastUpdate.textContent = `Actualizado: ${new Date().toLocaleString("es-CL")}`;
            } catch (error) {
                renderSummary(demoSummary);
                currentMedicines = demoMedicines;
                renderAnalytics(demoMedicines);
                filterMedicines();
                dataModeBadge.textContent = "Vista demostrativa";
                dataModeBadge.classList.add("demo");
                lastUpdate.textContent = `Actualizado: ${new Date().toLocaleString("es-CL")}`;
                errorMessage.textContent = "La base CESFAM no está conectada. El panel muestra datos de demostración para revisar la interfaz.";
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
        document.querySelector("#currentDate").textContent = new Intl.DateTimeFormat("es-CL", { weekday: "long", day: "numeric", month: "long" }).format(new Date());
        loadDashboard();
    </script>
</body>
</html>
