(function () {
    "use strict";

    const dialog = document.querySelector("#loginDialog");
    const form = document.querySelector("#loginForm");
    const email = document.querySelector("#loginEmail");
    const password = document.querySelector("#loginPassword");
    const togglePassword = document.querySelector("#togglePassword");

    function openLogin() {
        dialog.hidden = false;
        document.body.classList.add("dialog-open");
        window.setTimeout(() => email.focus(), 50);
    }

    function closeLogin() {
        dialog.hidden = true;
        document.body.classList.remove("dialog-open");
    }

    document.querySelectorAll("[data-open-login]").forEach(button => button.addEventListener("click", openLogin));
    document.querySelectorAll("[data-close-login]").forEach(button => button.addEventListener("click", closeLogin));

    // Permite comprobar la experiencia de acceso mientras el proyecto no dispone de un proveedor de identidad.
    form.addEventListener("submit", event => {
        event.preventDefault();
        if (!form.reportValidity()) return;
        sessionStorage.setItem("cesfam-demo-user", email.value.trim());
        window.location.href = "WebAjax.aspx";
    });

    togglePassword.addEventListener("click", () => {
        const showPassword = password.type === "password";
        password.type = showPassword ? "text" : "password";
        togglePassword.textContent = showPassword ? "Ocultar" : "Ver";
        togglePassword.setAttribute("aria-label", showPassword ? "Ocultar contraseña" : "Mostrar contraseña");
    });

    document.addEventListener("keydown", event => {
        if (event.key === "Escape" && !dialog.hidden) closeLogin();
    });

}());
