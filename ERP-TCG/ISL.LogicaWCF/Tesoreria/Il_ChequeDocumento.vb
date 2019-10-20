Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_ChequeDocumento" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_ChequeDocumento

    <OperationContract()> _
    Function Listar(ByVal oe As e_ChequeDocumento) As List(Of e_ChequeDocumento)

    <OperationContract()> _
    Function Guardar(ByVal oe As e_ChequeDocumento) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oe As e_ChequeDocumento) As Boolean

End Interface
