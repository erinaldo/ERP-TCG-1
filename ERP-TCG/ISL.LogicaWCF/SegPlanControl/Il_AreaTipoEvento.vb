Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_AreaTipoEvento" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_AreaTipoEvento

    Function Eliminar(oeAreaTipoEvento As e_AreaTipoEvento) As Boolean

    <OperationContract()>
    Sub DoWork()

    <OperationContract()>
    Function Obtener(ByVal oeAreaTipoEvento As e_AreaTipoEvento) As e_AreaTipoEvento

    <OperationContract()>
    Function Listar(ByVal oeAreaTipoEvento As e_AreaTipoEvento) As List(Of e_AreaTipoEvento)

    <OperationContract()>
    Function Validar(ByVal oeAreaTipoEvento As e_AreaTipoEvento) As Boolean

    '<OperationContract()>
    'Function Guardar(ByVal oeAreaTipoEvento As e_AreaTipoEvento) As Boolean

    '<OperationContract()>
    'Function Eliminar(ByVal oeAreaTipoEvento As e_AreaTipoEvento) As Boolean

End Interface
