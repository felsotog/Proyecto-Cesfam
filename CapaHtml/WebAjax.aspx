<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebAjax.aspx.cs" Inherits="CapaHtml.WebAjax" %>

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
        <header class="app-header">
            <div class="container d-flex flex-wrap align-items-center justify-content-between gap-3">
                <div>
                    <p class="app-kicker mb-1">Sistema de gestión</p>
                    <h1 class="h3 mb-0">Farmacia CESFAM</h1>
                </div>
                <button id="refreshButton" class="btn btn-primary" type="button">Actualizar información</button>
            </div>
        </header>

        <main class="container py-5">
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
                errorMessage.textContent = "No fue posible cargar la información. Revisa la conexión a SQL Server y vuelve a intentarlo.";
                errorMessage.classList.remove("d-none");
            } finally {
                refreshButton.disabled = false;
            }
        }

        refreshButton.addEventListener("click", loadDashboard);
        medicineSearch.addEventListener("input", filterMedicines);
        loadDashboard();
    </script>
</body>
</html>
