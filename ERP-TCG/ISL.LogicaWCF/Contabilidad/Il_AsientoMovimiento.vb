Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_AsientoMovimiento", también debe actualizar la referencia a "Il_AsientoMovimiento" en Web.config.
<ServiceContract()> _
Public Interface Il_AsientoMovimiento

    <OperationContract()> _
    Function Obtener(ByVal oeAsientoMovimiento As e_AsientoMovimiento) As e_AsientoMovimiento

    <OperationContract()> _
    Function Obtener2(ByVal oeAsientoMovimiento As e_AsientoMovimiento) As e_AsientoMovimiento

    <OperationContract()> _
    Function Listar(ByVal oeAsientoMovimiento As e_AsientoMovimiento) As List(Of e_AsientoMovimiento)

    <OperationContract()> _
    Function Validar(ByVal oeAsientoMovimiento As e_AsientoMovimiento) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeAsientoMovimiento As e_AsientoMovimiento) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeAsientoMovimiento As e_AsientoMovimiento) As Boolean

    <OperationContract()> _
  Function CrearDT() As System.Data.DataTable

End Interface
