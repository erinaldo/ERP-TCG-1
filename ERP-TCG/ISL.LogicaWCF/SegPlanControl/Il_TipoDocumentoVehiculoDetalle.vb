Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_TipoDocumentoVehiculoDetalle" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_TipoDocumentoVehiculoDetalle

    Function Guardar(Lista As List(Of EntidadesWCF.e_TipoDocumentoVehiculoDetalle)) As Boolean

    Function Guardar(oeTipoDocumentoVehiculoDetalle As EntidadesWCF.e_TipoDocumentoVehiculoDetalle) As Boolean

    Function Validar(oeTipoDocumentoVehiculoDetalle As EntidadesWCF.e_TipoDocumentoVehiculoDetalle) As Boolean

    Function Eliminar(oeTipoDocumentoVehiculoDetalle As EntidadesWCF.e_TipoDocumentoVehiculoDetalle) As Boolean

    Function Listar(oeTipoDocumentoVehiculoDetalle As EntidadesWCF.e_TipoDocumentoVehiculoDetalle) As List(Of EntidadesWCF.e_TipoDocumentoVehiculoDetalle)

    Function Obtener(oeTipoDocumentoVehiculoDetalle As EntidadesWCF.e_TipoDocumentoVehiculoDetalle) As EntidadesWCF.e_TipoDocumentoVehiculoDetalle

    <OperationContract()>
    Sub DoWork()

End Interface
