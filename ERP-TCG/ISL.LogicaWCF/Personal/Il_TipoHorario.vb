Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_TipoHorario" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_TipoHorario

    <OperationContract()> _
    Overloads Function Validar(ByVal oeTipoHorario As e_TipoHorario) As Boolean

    <OperationContract()> _
    Overloads Function Obtener(ByVal oeTipoHorario As e_TipoHorario) As e_TipoHorario

    <OperationContract()> _
    Overloads Function Listar(ByVal oeTipoHorario As e_TipoHorario) As List(Of e_TipoHorario)

    <OperationContract()> _
    Overloads Function ComboGrilla(ByVal loTipoHorario As List(Of e_TipoHorario)) As Object

    <OperationContract()> _
    Overloads Function Guardar(ByVal oeTipoHorario As e_TipoHorario) As Boolean

    <OperationContract()> _
    Overloads Function Eliminar(ByVal oeTipoHorario As e_TipoHorario) As Boolean

    <OperationContract()> _
    Overloads Function ValidarNombre(ByVal id As String, ByVal nombre As String) As Boolean

End Interface
