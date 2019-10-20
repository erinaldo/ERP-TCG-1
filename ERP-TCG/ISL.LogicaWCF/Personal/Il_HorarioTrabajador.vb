
Imports ERP.EntidadesWCF
Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_HorarioTrabajador" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_HorarioTrabajador

    <OperationContract()> _
    Overloads Function Validar(ByVal loHorarioTrabajador As List(Of e_HorarioTrabajador)) As Boolean

    <OperationContract()> _
    Overloads Function Obtener(ByVal oeHorarioTrabajador As e_HorarioTrabajador) As e_HorarioTrabajador

    <OperationContract()> _
    Overloads Function ListarDS(ByVal oeHorarioTrabajador As e_HorarioTrabajador) As System.Data.DataSet

    <OperationContract()> _
    Overloads Function Listar(ByVal oeHorarioTrabajador As e_HorarioTrabajador) As List(Of e_HorarioTrabajador)

    <OperationContract()> _
    Overloads Function Guardar(ByVal loHorarioTrabajador As List(Of e_HorarioTrabajador)) As Boolean

    <OperationContract()> _
    Overloads Function Eliminar(ByVal oeHorarioTrabajador As e_HorarioTrabajador) As Boolean

End Interface
