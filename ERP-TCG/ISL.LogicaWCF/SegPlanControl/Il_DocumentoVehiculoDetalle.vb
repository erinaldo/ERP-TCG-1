Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_DocumentoVehiculoDetalle" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_DocumentoVehiculoDetalle

    Function Eliminar(oeDocumentoVehiculoDetalle As EntidadesWCF.e_DocumentoVehiculoDetalle) As Boolean

    Function Guardar(Lista As List(Of EntidadesWCF.e_DocumentoVehiculoDetalle)) As Boolean

    Function Guardar(oeDocumentoVehiculoDetalle As EntidadesWCF.e_DocumentoVehiculoDetalle) As Boolean

    Function Validar(oeDocumentoVehiculoDetalle As EntidadesWCF.e_DocumentoVehiculoDetalle) As Boolean

    Function Listar(oeDocumentoVehiculoDetalle As EntidadesWCF.e_DocumentoVehiculoDetalle) As List(Of EntidadesWCF.e_DocumentoVehiculoDetalle)

    Function Obtener(oeDocumentoVehiculoDetalle As EntidadesWCF.e_DocumentoVehiculoDetalle) As EntidadesWCF.e_DocumentoVehiculoDetalle

    <OperationContract()>
    Sub DoWork()

End Interface
