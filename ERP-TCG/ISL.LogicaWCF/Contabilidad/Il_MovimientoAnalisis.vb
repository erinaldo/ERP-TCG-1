Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_MovimientoAnalisis", también debe actualizar la referencia a "Il_MovimientoAnalisis" en Web.config.
<ServiceContract()> _
Public Interface Il_MovimientoAnalisis

    <OperationContract()> _
    Function Obtener(ByVal oeMovimientoAnalisis As e_MovimientoAnalisis) As e_MovimientoAnalisis

    <OperationContract()> _
    Function Listar(ByVal oeMovimientoAnalisis As e_MovimientoAnalisis) As List(Of e_MovimientoAnalisis)

    <OperationContract()> _
    Function Validar(ByVal oeMovimientoAnalisis As e_MovimientoAnalisis) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeMovimientoAnalisis As e_MovimientoAnalisis) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMovimientoAnalisis As e_MovimientoAnalisis) As Boolean

    <OperationContract()> _
    Function CrearDT() As Data.DataTable

    <OperationContract()> _
    Function Prorraretar(ByVal leMovAnalisis As List(Of e_MovimientoAnalisis)) As Boolean

    <OperationContract()> _
    Function GuardarLista(ByVal leMovAnalisis As List(Of e_MovimientoAnalisis)) As Boolean

End Interface
