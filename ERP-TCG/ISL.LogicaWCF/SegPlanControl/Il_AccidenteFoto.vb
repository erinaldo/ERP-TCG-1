Imports ERP.EntidadesWCF
Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_AccidenteFoto" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_AccidenteFoto

    <OperationContract()> _
    Function Obtener(ByVal oe As e_AccidenteFoto) As e_AccidenteFoto

    <OperationContract()> _
    Function Listar(ByVal oe As e_AccidenteFoto) As List(Of e_AccidenteFoto)

    <OperationContract()> _
    Function Guardar(ByVal oe As e_AccidenteFoto) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oe As e_AccidenteFoto) As Boolean

End Interface
