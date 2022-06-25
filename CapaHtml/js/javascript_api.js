//https://randomuser.me/

//Consumo API randomuser.me/
function generarTabla() {
    //Obtener la referencia del lugar donde dejaremos la tabla
    var tabla_usuarios = document.getElementById("tabla_random_user");

    //Crear los elementos <table>, <thead> y <tbody>
    var tabla = document.createElement("table");
    var thead = document.createElement("thead");
    var tbody = document.createElement("tbody");

    //Crear los encabezados
    var encabezados = ["Código", "Nombre", "Email", "País", "Edad", "Género"];
    var filaHead = document.createElement("tr");
    for (var i = 0; i < encabezados.length; i++) {
        //Crear una celda
        var celdaHead = document.createElement("th");
        var textoCelda = document.createTextNode(encabezados[i]);
        celdaHead.appendChild(textoCelda);
        filaHead.appendChild(celdaHead);
    }
    thead.appendChild(filaHead);

    //Cargar los datos de la API y armar el contenido de la tabla
    var xmlHttp = new XMLHttpRequest();
    xmlHttp.open('GET', 'https://randomuser.me/api/?results=25', true)
    xmlHttp.send();

    xmlHttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            var data = JSON.parse(this.responseText);

            //Crear la estructura de cada fila/registro que obtuvimos...
            for (var i = 0; i < data.results.length; i++) {
                //crear una fila
                var filaBody = document.createElement("tr");

                //crear celda para cada dato que vamos a mostrar

                //Código
                var celdaCodigo = document.createElement("td");
                var textCodigo = document.createTextNode(i + 1);
                celdaCodigo.appendChild(textCodigo);
                filaBody.appendChild(celdaCodigo);
                tbody.appendChild(filaBody);

                //Nombre
                var celdaNombre = document.createElement("td");
                var textNombre = document.createTextNode(data.results[i].name.first + " " + data.results[i].name.last);
                celdaNombre.appendChild(textNombre);
                filaBody.appendChild(celdaNombre);
                tbody.appendChild(filaBody);

                //Email
                var celdaEmail = document.createElement("td");
                var textEmail = document.createTextNode(data.results[i].email);
                celdaEmail.appendChild(textEmail);
                filaBody.appendChild(celdaEmail);
                tbody.appendChild(filaBody);

                //Pais
                var celdaPais = document.createElement("td");
                var textPais = document.createTextNode(data.results[i].location.country);
                celdaPais.appendChild(textPais);
                filaBody.appendChild(celdaPais);
                tbody.appendChild(filaBody);

                //Edad
                var celdaEdad = document.createElement("td");
                var textEdad = document.createTextNode(data.results[i].dob.age);
                celdaEdad.appendChild(textEdad);
                filaBody.appendChild(celdaEdad);
                tbody.appendChild(filaBody);

                //Genero
                var celdaGenero = document.createElement("td");
                genero = data.results[i].gender;
                var textGenero = (genero == 'male') ? document.createTextNode("Masculino") : document.createTextNode("Femenino");
                celdaGenero.appendChild(textGenero);
                filaBody.appendChild(celdaGenero);
                tbody.appendChild(filaBody);
            }

        }
    };

    //agregar la fila de encabezados a la tabla
    tabla.appendChild(thead);

    tabla.appendChild(tbody);

    //mostrar tabla
    tabla_usuarios.appendChild(tabla);

    //Aplicar clases Bosstrap
    tabla.setAttribute("class", "table table-borderer");
    thead.setAttribute("class", "table table-dark")
    tbody.setAttribute("id", "datos_tabla")

}

//filtrado automático de tabla
$(document).ready(function () {
    $("#texto_buscado").on("keyup", function () {
        var texto = $(this).val().toLowerCase();
        $("#datos_tabla tr").filter(function () {
            $(this).toggle($(this).text().toLowerCase().indexOf(texto) > -1)
        });
    });
});