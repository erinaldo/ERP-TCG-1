Imports System.ServiceModel
Imports ERP.EntidadesWCF

<ServiceContract()> _
Public Interface Il_OcupacionTrabajador

    <OperationContract()> _
    Function Obtener(ByVal oeOcupacionTrabajador As e_OcupacionTrabajador) As e_OcupacionTrabajador

    <OperationContract()> _
    Sub ObtenerJefeArea(ByVal oeOcupacionTrabajador As e_OcupacionTrabajador)

    <OperationContract()> _
    Function Listar(ByVal oeOcupacionTrabajador As e_OcupacionTrabajador) As List(Of e_OcupacionTrabajador)

    <OperationContract()> _
    Function Validar(ByVal oeOcupacionTrabajador As e_OcupacionTrabajador) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeOcupacionTrabajador As e_OcupacionTrabajador) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeOcupacionTrabajador As e_OcupacionTrabajador) As Boolean

End Interface
