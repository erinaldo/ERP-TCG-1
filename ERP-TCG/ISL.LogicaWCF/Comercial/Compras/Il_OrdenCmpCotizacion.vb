Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_OrdenCmpCotizacion" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_OrdenCmpCotizacion

    <OperationContract()> _
    Function Guardar(ByVal oeOrdenCmpCotizacion As e_OrdenCmpCotizacion) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeOrdenCmpCotizacion As e_OrdenCmpCotizacion) As Boolean

    <OperationContract()> _
    Function Obtener(ByVal oeOrdenCmpCotizacion As e_OrdenCmpCotizacion) As e_OrdenCmpCotizacion

End Interface
