Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_FlujoGasto", también debe actualizar la referencia a "Il_FlujoGasto" en Web.config.
<ServiceContract()> _
Public Interface Il_FlujoGasto

    <OperationContract()> _
    Function ValidarDuplicado(ByVal ID As String, ByVal NOMBRE As String) As Boolean

    <OperationContract()> _
    Function Obtener(ByVal oeFlujoGasto As e_FlujoCaja) As e_FlujoCaja

    <OperationContract()> _
    Function Buscar(ByVal oeFlujoGasto As e_FlujoCaja) As Boolean

    <OperationContract()> _
    Function ComboGrilla(ByVal ListaFlujo As List(Of e_FlujoCaja))

    <OperationContract()> _
    Function Listar(ByVal oeFlujoGasto As e_FlujoCaja) As List(Of e_FlujoCaja)

    <OperationContract()> _
    Function Validar(ByVal oeFlujoGasto As e_FlujoCaja) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeFlujoGasto As e_FlujoCaja) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeFlujoGasto As e_FlujoCaja) As Boolean

End Interface
