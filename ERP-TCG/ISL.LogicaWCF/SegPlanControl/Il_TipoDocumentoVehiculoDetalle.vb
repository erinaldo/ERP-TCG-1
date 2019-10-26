Imports System.ServiceModel
Imports ERP.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_TipoDocumentoVehiculoDetalle" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_TipoDocumentoVehiculoDetalle

    Function Guardar(Lista As List(Of e_TipoDocumentoVehiculoDetalle)) As Boolean

    Function Guardar(oeTipoDocumentoVehiculoDetalle As e_TipoDocumentoVehiculoDetalle) As Boolean

    Function Validar(oeTipoDocumentoVehiculoDetalle As e_TipoDocumentoVehiculoDetalle) As Boolean

    Function Eliminar(oeTipoDocumentoVehiculoDetalle As e_TipoDocumentoVehiculoDetalle) As Boolean

    Function Listar(oeTipoDocumentoVehiculoDetalle As e_TipoDocumentoVehiculoDetalle) As List(Of e_TipoDocumentoVehiculoDetalle)

    Function Obtener(oeTipoDocumentoVehiculoDetalle As e_TipoDocumentoVehiculoDetalle) As e_TipoDocumentoVehiculoDetalle

    <OperationContract()>
    Sub DoWork()

End Interface
