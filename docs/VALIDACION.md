# Validación técnica

## Comprobaciones realizadas

- Compilación completa de `Cesfam.sln` en `Debug` con MSBuild 17.6.
- Compilación completa de `Cesfam.sln` en `Release` con MSBuild 17.6.
- Revisión de los archivos `.config` y `.csproj`: 28 documentos XML válidos.
- Las capas de conexión y los módulos renovados usan parámetros `SqlParameter`.
- Las cadenas escritas directamente en las clases de negocio fueron sustituidas
  por la configuración central `CesfamDatabase`.
- Revisión de que los archivos añadidos estén incluidos en sus proyectos.

## Alcance de la modernización

El repositorio conserva módulos académicos anteriores para agendamiento,
pacientes, recetas, ingresos y salidas. Estos continúan disponibles para mantener
compatibilidad con las pantallas y servicios existentes. La migración a consultas
parametrizadas se aplicó a farmacia, farmacéuticos, medicamentos, ciudades y
personal, que son los módulos utilizados por el panel renovado.

## Resultado

Las seis capas generan sus ensamblados correctamente:

- `CapaConexionCesfam.dll`
- `CapaDTOCesfam.dll`
- `CapaNegocioCesfam.dll`
- `CapaServicioCesfam.dll`
- `CapaHtml.dll`
- `CapaPantallaCesfam.exe`

## Validación pendiente con datos

La prueba integrada requiere restaurar el respaldo académico `DB cesfam` en una
instancia de SQL Server y ejecutar los proyectos con IIS Express. El respaldo se
mantiene fuera de GitHub para evitar publicar datos que no forman parte del código.
