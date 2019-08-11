Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_ImagenesDocumentosVehiculos" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_ImagenesDocumentos

    Function Sincronizar(oeImagenesDocumentosVehiculos As e_ImagenesDocumentos) As e_ImagenesDocumentos

    <OperationContract()> _
    Function Obtener(ByVal oeImagenesDocumentosVehiculos As e_ImagenesDocumentos) As e_ImagenesDocumentos

    <OperationContract()> _
    Function Listar(ByVal oeImagenesDocumentosVehiculos As e_ImagenesDocumentos) As List(Of e_ImagenesDocumentos)

    <OperationContract()> _
    Function Validar(ByVal oeImagenesDocumentosVehiculos As e_ImagenesDocumentos) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeImagenesDocumentosVehiculos As e_ImagenesDocumentos) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeImagenesDocumentosVehiculos As e_ImagenesDocumentos) As Boolean

End Interface
