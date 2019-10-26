Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_Feriados" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_Feriados

    <OperationContract()> _
    Function Obtener(ByVal oeFeriados As e_Feriados) As e_Feriados

    <OperationContract()> _
    Function Listar(ByVal oeFeriados As e_Feriados) As List(Of e_Feriados)

    <OperationContract()> _
    Function Validar(ByVal oeFeriados As e_Feriados) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeFeriados As e_Feriados) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeFeriados As e_Feriados) As Boolean

End Interface
