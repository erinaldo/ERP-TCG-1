Imports System.ServiceModel
Imports ERP.EntidadesWCF

<ServiceContract()>
Public Interface Il_CierreTurno

    <OperationContract()>
    Function Obtener(ByVal oeCierreTurno As e_CierreTurno) As e_CierreTurno

    <OperationContract()>
    Function Listar(ByVal oeCierreTurno As e_CierreTurno) As List(Of e_CierreTurno)

    <OperationContract()>
    Function Guardar(ByVal oeCierreTurno As e_CierreTurno) As e_CierreTurno

    <OperationContract()>
    Function Eliminar(ByVal oeCierreTurno As e_CierreTurno) As Boolean

End Interface
