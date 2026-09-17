<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebPaginaPrincipal.aspx.cs" CodePage="65001" Inherits="CapaHtml.WebPaginaPrincipal" %>

<!doctype html>
<html lang="es">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="Sistema de gestión clínica y farmacéutica para Centro de Salud Familiar." />
    <title>Centro de Salud Familiar CESFAM</title>
    <link rel="stylesheet" href="css/landing.css" />
</head>
<body>
    <header class="landing-header">
        <a class="landing-brand" href="WebPaginaPrincipal.aspx" aria-label="Inicio CESFAM">
            <span class="landing-brand-mark" aria-hidden="true">+</span>
            <span><strong>CESFAM</strong><small>Centro de Salud Familiar</small></span>
        </a>
        <nav class="landing-nav" aria-label="Navegación de la página principal">
            <a href="#inicio">Inicio</a>
            <a href="#funcionalidades">Funcionalidades</a>
            <a href="#modulos">Módulos</a>
        </nav>
        <button class="login-trigger" type="button" data-open-login>
            <svg viewBox="0 0 24 24" aria-hidden="true"><path d="M10 17v-2h4V9h-4V7h6v10h-6zm-1-4H2v-2h7L6 8l1.4-1.4L12.8 12l-5.4 5.4L6 16l3-3zm9-11H8a2 2 0 0 0-2 2v2h2V4h10v16H8v-2H6v2a2 2 0 0 0 2 2h10a2 2 0 0 0 2-2V4a2 2 0 0 0-2-2z"/></svg>
            Iniciar sesión
        </button>
    </header>

    <main>
        <section class="hero" id="inicio">
            <div class="hero-copy">
                <p class="eyebrow"><span></span> Gestión de salud conectada</p>
                <h1>Información clínica y farmacéutica en un solo lugar.</h1>
                <p class="hero-description">Administra pacientes, agendas e inventario de medicamentos mediante una plataforma clara para el trabajo diario del CESFAM.</p>
                <div class="hero-actions">
                    <button class="primary-action" type="button" data-open-login>Ingresar al sistema</button>
                    <a class="secondary-action" href="#funcionalidades">Conocer la plataforma <span>→</span></a>
                </div>
                <div class="hero-trust">
                    <div><strong>11</strong><span>Módulos integrados</span></div>
                    <div><strong>1</strong><span>Fuente de información</span></div>
                    <div><strong>24/7</strong><span>Acceso local</span></div>
                </div>
            </div>

            <div class="hero-visual" aria-label="Vista resumida del sistema CESFAM">
                <div class="visual-glow"></div>
                <article class="dashboard-preview">
                    <div class="preview-header">
                        <div class="preview-brand"><span>+</span><strong>CESFAM</strong></div>
                        <span class="preview-avatar">MZ</span>
                    </div>
                    <div class="preview-welcome"><span>Resumen de farmacia</span><strong>Panel administrativo</strong><small>Información centralizada para decisiones rápidas.</small></div>
                    <div class="preview-stats">
                        <div><span class="stat-icon">+</span><p><strong>128</strong><small>Medicamentos</small></p></div>
                        <div><span class="stat-icon">○</span><p><strong>84</strong><small>Pacientes</small></p></div>
                        <div><span class="stat-icon">□</span><p><strong>12</strong><small>Agendas hoy</small></p></div>
                    </div>
                    <div class="preview-table">
                        <div class="preview-table-head"><span>Medicamento</span><span>Estado</span></div>
                        <div><span><i class="medicine-dot"></i>Paracetamol</span><b>Disponible</b></div>
                        <div><span><i class="medicine-dot blue"></i>Ibuprofeno</span><b>Disponible</b></div>
                        <div><span><i class="medicine-dot amber"></i>Amoxicilina</span><b class="warning">Stock bajo</b></div>
                    </div>
                </article>
                <div class="floating-card floating-security"><span>✓</span><p><strong>Datos centralizados</strong><small>Información consistente</small></p></div>
                <div class="floating-card floating-status"><i></i><p><strong>Sistema activo</strong><small>Servicios disponibles</small></p></div>
            </div>
        </section>

        <section class="features-section" id="funcionalidades">
            <div class="section-intro">
                <p class="eyebrow"><span></span> Funcionalidades</p>
                <h2>Herramientas para una gestión más clara</h2>
                <p>El sistema reúne las tareas clínicas y de farmacia que el equipo utiliza durante la atención.</p>
            </div>
            <div class="features-grid">
                <article><span class="feature-icon">○</span><h3>Gestión de pacientes</h3><p>Registro de pacientes, fichas clínicas y datos necesarios para el seguimiento.</p></article>
                <article><span class="feature-icon">□</span><h3>Agenda médica</h3><p>Organización de horas para relacionar profesionales, pacientes y fechas de atención.</p></article>
                <article><span class="feature-icon">+</span><h3>Control de farmacia</h3><p>Ingresos, reservas, entregas y control de medicamentos próximos a caducar.</p></article>
            </div>
        </section>

        <section class="modules-section" id="modulos">
            <div class="modules-copy">
                <p class="eyebrow"><span></span> Plataforma integrada</p>
                <h2>Accede a cada área desde un mismo panel</h2>
                <p>Una navegación consistente permite cambiar de tarea sin perder el contexto de trabajo.</p>
                <button class="primary-action" type="button" data-open-login>Comenzar ahora</button>
            </div>
            <div class="module-list">
                <a href="WebPaciente.aspx"><span>01</span><div><strong>Pacientes y fichas</strong><small>Información clínica centralizada</small></div><b>→</b></a>
                <a href="WebAgendamiento.aspx"><span>02</span><div><strong>Agendamiento</strong><small>Coordinación de horas médicas</small></div><b>→</b></a>
                <a href="WebMedicamento.aspx"><span>03</span><div><strong>Medicamentos</strong><small>Inventario y disponibilidad</small></div><b>→</b></a>
                <a href="WebSalidaMedicamento.aspx"><span>04</span><div><strong>Entregas y reservas</strong><small>Trazabilidad farmacéutica</small></div><b>→</b></a>
            </div>
        </section>
    </main>

    <footer class="landing-footer">
        <a class="landing-brand footer-brand" href="#inicio"><span class="landing-brand-mark">+</span><span><strong>CESFAM</strong><small>Gestión clínica y farmacéutica</small></span></a>
        <p>Proyecto académico de integración de plataformas.</p>
        <button type="button" data-open-login>Acceso al sistema</button>
    </footer>

    <div class="login-dialog" id="loginDialog" role="dialog" aria-modal="true" aria-labelledby="loginTitle" hidden>
        <button class="login-backdrop" type="button" data-close-login aria-label="Cerrar inicio de sesión"></button>
        <section class="login-card">
            <button class="login-close" type="button" data-close-login aria-label="Cerrar">×</button>
            <span class="login-symbol" aria-hidden="true">+</span>
            <p class="eyebrow"><span></span> Acceso institucional</p>
            <h2 id="loginTitle">Iniciar sesión</h2>
            <p class="login-description">Ingresa tus datos para acceder al panel administrativo.</p>
            <form id="loginForm">
                <label for="loginEmail">Correo institucional</label>
                <input id="loginEmail" type="email" placeholder="nombre@cesfam.cl" autocomplete="username" required />
                <label for="loginPassword">Contraseña</label>
                <div class="password-control">
                    <input id="loginPassword" type="password" placeholder="Ingresa tu contraseña" autocomplete="current-password" minlength="4" required />
                    <button id="togglePassword" type="button" aria-label="Mostrar contraseña">Ver</button>
                </div>
                <div class="login-options"><label><input type="checkbox" /> Recordar sesión</label><a href="#">¿Olvidaste tu contraseña?</a></div>
                <button class="login-submit" type="submit">Ingresar al panel</button>
                <p class="login-note" id="loginNote" aria-live="polite">Acceso de demostración para revisión del proyecto.</p>
            </form>
        </section>
    </div>

    <script src="js/landing.js"></script>
</body>
</html>
