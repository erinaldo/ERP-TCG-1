Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_TipoFeriado" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_TipoFeriado

    <OperationContract()> _
    Function Obtener(ByVal oeTipoFeriado As e_TipoFeriado) As e_TipoFeriado

    <OperationContract()> _
    Function Listar(ByVal oeTipoFeriado As e_TipoFeriado) As List(Of e_TipoFeriado)

    <OperationContract()> _
    Function Guardar(ByVal oeTipoFeriado As e_TipoFeriado) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeTipoFeriado As e_TipoFeriado) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeTipoFeriado As e_TipoFeriado) As Boolean

End Interface
