(function () {
    "use strict";

    // Configuración centralizada del menú compartido por las vistas Web Forms.
    // El cuarto valor inicia un nuevo grupo visual dentro de la navegación.
    const links = [
        ["WebAjax.aspx", "▦", "Resumen", "Principal"],
        ["WebAgendamiento.aspx", "□", "Agendamiento"],
        ["WebPaciente.aspx", "○", "Pacientes"],
        ["WebMedico.aspx", "◇", "Médicos"],
        ["WebFichaPaciente.aspx", "▤", "Fichas clínicas"],
        ["WebFarmacia.aspx", "✚", "Farmacia", "Farmacia"],
        ["WebMedicamento.aspx", "◫", "Medicamentos"],
        ["WebIngresoMedicamento.aspx", "↓", "Ingresos"],
        ["WebSalidaMedicamento.aspx", "↑", "Entregas"],
        ["WebReservaMedicamento.aspx", "◷", "Reservas"],
        ["WebCaducarMedicamento.aspx", "×", "Mermas"]
    ];

    function buildNavigation(currentPage) {
        let html = "";
        links.forEach(([href, icon, label, group]) => {
            if (group) html += `<p class="modern-nav-label${group === "Farmacia" ? " spaced" : ""}">${group}</p>`;
            // Se compara la URL actual para resaltar la sección que está visitando el usuario.
            html += `<a class="modern-nav-item${currentPage === href.toLowerCase() ? " active" : ""}" href="${href}"><span>${icon}</span>${label}</a>`;
        });
        return html;
    }

    function initialiseShell() {
        // La clase del body permite modernizar páginas antiguas sin alterar sus controles ASP.NET.
        document.body.classList.add("cesfam-modern-shell");
        const currentPage = (location.pathname.split("/").pop() || "WebAjax.aspx").toLowerCase();
        const pageTitle = document.title || "Gestión CESFAM";

        const sidebar = document.createElement("aside");
        sidebar.className = "modern-sidebar";
        sidebar.id = "modernSidebar";
        sidebar.setAttribute("aria-label", "Navegación principal");
        sidebar.innerHTML = `
            <a class="modern-brand" href="WebAjax.aspx"><span class="modern-brand-mark">+</span><span><strong>CESFAM</strong><small>Gestión de farmacia</small></span></a>
            <nav class="modern-nav">${buildNavigation(currentPage)}</nav>
            <div class="modern-sidebar-footer"><i></i><span><strong>Sistema local</strong><small>ASP.NET · SQL Server</small></span></div>`;

        const backdrop = document.createElement("button");
        backdrop.type = "button";
        backdrop.className = "modern-shell-backdrop";
        backdrop.setAttribute("aria-label", "Cerrar menú");

        const topbar = document.createElement("header");
        topbar.className = "modern-topbar";
        topbar.innerHTML = `
            <div class="modern-topbar-start"><button class="modern-menu-button" type="button" aria-label="Abrir menú">☰</button><div class="modern-page-title"><span>Panel administrativo</span><strong>${pageTitle}</strong></div></div>
            <button class="modern-topbar-user" type="button" aria-expanded="false"><span class="modern-avatar">MZ</span><span class="modern-user-copy"><strong>Michael Zamorano</strong><small>Administrador</small></span></button>
            <div class="modern-user-menu" hidden><strong>Sesión activa</strong><span>Administrador CESFAM</span><a href="WebAjax.aspx">Volver al resumen</a></div>`;

        // Los componentes se agregan fuera de los formularios para no interferir con los postbacks.
        document.body.prepend(topbar);
        document.body.prepend(backdrop);
        document.body.prepend(sidebar);

        const menuButton = topbar.querySelector(".modern-menu-button");
        const userButton = topbar.querySelector(".modern-topbar-user");
        const userMenu = topbar.querySelector(".modern-user-menu");
        // El menú usa un fondo interactivo en pantallas pequeñas y admite cierre con Escape.
        const closeMenu = () => { sidebar.classList.remove("is-open"); backdrop.classList.remove("is-visible"); };
        menuButton.addEventListener("click", () => { sidebar.classList.add("is-open"); backdrop.classList.add("is-visible"); });
        backdrop.addEventListener("click", closeMenu);
        userButton.addEventListener("click", () => { const open = userMenu.hidden; userMenu.hidden = !open; userButton.setAttribute("aria-expanded", String(open)); });
        document.addEventListener("keydown", event => { if (event.key === "Escape") { closeMenu(); userMenu.hidden = true; } });
    }

    // Espera que Web Forms termine de crear el DOM antes de insertar la estructura compartida.
    if (document.readyState === "loading") document.addEventListener("DOMContentLoaded", initialiseShell);
    else initialiseShell();
}());
