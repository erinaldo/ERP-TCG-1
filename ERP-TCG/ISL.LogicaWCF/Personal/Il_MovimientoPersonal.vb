Imports System.ServiceModel
Imports ERP.EntidadesWCF

<ServiceContract()> _
Public Interface Il_MovimientoPersonal

    <OperationContract()> _
    Function Obtener(ByVal oeMovimientoPersonal As e_MovimientoPersonal) As e_MovimientoPersonal

    <OperationContract()> _
    Function Listar(ByVal oeMovimientoPersonal As e_MovimientoPersonal) As List(Of e_MovimientoPersonal)

    <OperationContract()> _
    Function Guardar(ByVal oeMovimientoPersonal As e_MovimientoPersonal) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMovimientoPersonal As e_MovimientoPersonal) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeMovimientoPersonal As e_MovimientoPersonal) As Boolean

End Interface
