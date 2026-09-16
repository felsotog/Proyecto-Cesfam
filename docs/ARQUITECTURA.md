# Arquitectura del sistema

## Responsabilidades por capa

### CapaDTOCesfam

Contiene los objetos `Ciudad`, `Farmacia`, `Farmaceutico`, `Medicamento` y
`PersonalCesfam`. Estos objetos viajan entre las interfaces, los servicios y la
capa de negocio.

### CapaConexionCesfam

Lee la conexión desde la configuración o desde la variable de entorno
`CESFAM_CONNECTION_STRING`. Expone dos operaciones:

- `EjecutarConsulta`: devuelve un `DataSet`.
- `EjecutarComando`: ejecuta inserciones, actualizaciones y eliminaciones.

Ambas reciben parámetros `SqlParameter` y liberan las conexiones al finalizar.

### CapaNegocioCesfam

Valida las entradas y define las operaciones CRUD. Los nombres públicos
originales se conservaron para mantener compatibilidad con los servicios ASMX y
los clientes existentes.

### CapaServicioCesfam

Publica un servicio ASMX por entidad. Cada servicio delega el trabajo a la capa
de negocio y ofrece operaciones de inserción, búsqueda, actualización,
eliminación y listado.

### CapaHtml

`WebAjax.aspx` ofrece un panel de consulta. Sus Page Methods llaman los servicios
y devuelven JSON al navegador; el frontend usa `fetch` para actualizar la vista
sin recargar la página.

### CapaPantallaCesfam

Cliente Windows Forms conservado para demostrar el consumo directo de la capa de
negocio en el módulo de farmacias.

## Decisiones de compatibilidad

- Se mantuvo .NET Framework 4.6.1.
- Se mantuvieron Web Forms y ASMX.
- Se mantuvieron `DataSet` y ADO.NET.
- Se conservaron las firmas públicas existentes cuando eran utilizadas por
  servicios o interfaces.
- No se incorporó Entity Framework, ASP.NET Core ni librerías nuevas.
