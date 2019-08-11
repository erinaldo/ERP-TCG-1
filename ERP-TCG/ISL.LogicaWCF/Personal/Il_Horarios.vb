Imports System.ServiceModel
Imports ISL.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_Horarios" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_Horarios

    <OperationContract()> _
    Overloads Function Validar(ByVal oeHorarios As e_Horarios) As Boolean

    <OperationContract()> _
    Overloads Function Obtener(ByVal oeHorarios As e_Horarios) As e_Horarios

    <OperationContract()> _
    Overloads Function Listar(ByVal oeHorarios As e_Horarios) As List(Of e_Horarios)


    <OperationContract()> _
    Overloads Function Guardar(ByVal oeHorarios As e_Horarios) As Boolean

    <OperationContract()> _
    Overloads Function Eliminar(ByVal oeHorarios As e_Horarios) As Boolean

    <OperationContract()> _
    Overloads Function ValidarTipo(ByVal IdTipoHorario As String) As Boolean

End Interface
