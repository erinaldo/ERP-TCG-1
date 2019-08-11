Imports System.ServiceModel
Imports ISL.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_TipoOpecon" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_TipoOpeCon

    <OperationContract()>
    Function Obtener(ByVal oeTipoOpeCon As e_TipoOpeCon) As e_TipoOpeCon

    <OperationContract()>
    Function Listar(ByVal oeTipoOpeCon As e_TipoOpeCon) As List(Of e_TipoOpeCon)

    <OperationContract()>
    Function Guardar(ByVal oeTipoOpeCon As e_TipoOpeCon) As Boolean

    <OperationContract()>
    Function Eliminar(ByVal oeTipoOpeCon As e_TipoOpeCon) As Boolean

End Interface
