Imports System.ServiceModel
Imports ERP.EntidadesWCF

<ServiceContract()>
Public Interface Il_CierreTurno_Detalle

    <OperationContract()>
    Function Obtener(ByVal oeCierreTurno_Detalle As e_CierreTurno_Detalle) As e_CierreTurno_Detalle

    <OperationContract()>
    Function Listar(ByVal oeCierreTurno_Detalle As e_CierreTurno_Detalle) As List(Of e_CierreTurno_Detalle)

    <OperationContract()>
    Function Guardar(ByVal oeCierreTurno_Detalle As e_CierreTurno_Detalle) As e_CierreTurno_Detalle

    <OperationContract()>
    Function Eliminar(ByVal oeCierreTurno_Detalle As e_CierreTurno_Detalle) As Boolean

End Interface
