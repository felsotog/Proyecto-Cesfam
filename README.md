# Sistema de gestión de farmacia CESFAM

Proyecto académico en capas para administrar ciudades, farmacias, medicamentos,
farmacéuticos y personal de un CESFAM. Conserva la tecnología original y corrige
los problemas que impedían ejecutar el sistema en otro equipo.

## Tecnologías

- C# y .NET Framework 4.6.1.
- ASP.NET Web Forms.
- Servicios web ASMX.
- SQL Server / SQL Server Express.
- HTML, CSS, Bootstrap y JavaScript con AJAX.
- Windows Forms para el cliente de escritorio incluido en la solución.

## Mejoras aplicadas

- Consultas SQL parametrizadas en los módulos de farmacia, farmacéuticos,
  medicamentos, ciudades y personal.
- Cadena de conexión configurable, sin depender del nombre del equipo original.
- Conexiones, comandos y adaptadores liberados correctamente mediante `using`.
- Validación de campos obligatorios, cantidades y fechas de medicamentos.
- Corrección de operaciones `UPDATE` que generaban SQL inválido.
- Corrección del servicio de farmacéuticos, que antes eliminaba y actualizaba farmacias.
- Corrección de la búsqueda de personal, que antes intentaba leer columnas de ciudad.
- Nuevos endpoints para listar los registros utilizados por el panel.
- Panel Web Forms funcional que obtiene resumen e inventario mediante AJAX.
- Buscador de inventario y alertas visuales para medicamentos vencidos o próximos a vencer.
- Archivos generados de Visual Studio excluidos mediante `.gitignore`.

## Arquitectura

```text
CapaHtml              Interfaz web y solicitudes AJAX
CapaPantallaCesfam    Cliente Windows Forms
CapaServicioCesfam    Servicios web ASMX
CapaNegocioCesfam     Validaciones y reglas de acceso a datos
CapaConexionCesfam    Conexión y ejecución segura en SQL Server
CapaDTOCesfam         Entidades de transferencia
```

El flujo principal es:

```text
Interfaz -> Servicio ASMX -> Capa de negocio -> Capa de conexión -> SQL Server
```

## Requisitos

- Windows.
- Visual Studio 2022 con la carga de trabajo **Desarrollo de ASP.NET y web**.
- .NET Framework 4.6.1 Developer Pack.
- SQL Server Express o una instancia compatible.

## Preparar la base de datos

1. Abre SQL Server Management Studio.
2. Restaura el respaldo académico `DB cesfam`, distribuido por separado para no
   publicar datos en el repositorio.
3. Confirma que la base restaurada se llame `CESFAM`.
4. Revisa la cadena `CesfamDatabase` en los archivos `Web.config` y `App.config`.

La configuración incluida utiliza SQL Server Express:

```xml
<add name="CesfamDatabase"
     connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=CESFAM;Integrated Security=True;TrustServerCertificate=True"
     providerName="System.Data.SqlClient" />
```

También puedes definir la variable de entorno `CESFAM_CONNECTION_STRING`. Esta
opción tiene prioridad y permite mantener credenciales fuera del repositorio.

## Ejecutar el proyecto

1. Abre `Cesfam.sln` en Visual Studio.
2. Restaura los paquetes NuGet.
3. Compila la solución.
4. Configura `CapaHtml` como proyecto de inicio para abrir el panel web.
5. Si necesitas probar los servicios directamente, inicia `CapaServicioCesfam`
   y abre cualquiera de sus archivos `.asmx`.

El panel web carga por AJAX:

- Totales de ciudades, farmacias, medicamentos, farmacéuticos y personal.
- Inventario de medicamentos con código, tipo, vencimiento y cantidad.
- Búsqueda por código, nombre, tipo o estado.
- Clasificación automática: vigente, por vencer durante los próximos 30 días o vencido.

## Material heredado

Las carpetas `CapaGUICesfam`, `CapaGUIWebCesfam`, `GUIWeb` y `WindowsFormsApp2`
corresponden a prototipos que no forman parte de `Cesfam.sln`. La aplicación de
escritorio mantenida es `CapaPantallaCesfam`; los prototipos se conservan como
referencia del trabajo académico original.

## Configuración alternativa

Si tu instancia no se llama `SQLEXPRESS`, reemplaza únicamente `Data Source`.
Ejemplos:

```text
Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CESFAM;Integrated Security=True
Data Source=SERVIDOR\INSTANCIA;Initial Catalog=CESFAM;Integrated Security=True
```

## Estado

La solución compila en configuraciones `Debug` y `Release` con MSBuild de Visual Studio 2022.
Para validar el funcionamiento completo se requiere restaurar la base de datos y
ejecutar los proyectos web mediante IIS Express.

El detalle de las comprobaciones realizadas está disponible en
[`docs/VALIDACION.md`](docs/VALIDACION.md).
