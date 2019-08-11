Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_HistorialInventario", también debe actualizar la referencia a "Il_HistorialInventario" en Web.config.
<ServiceContract()> _
Public Interface Il_HistorialInventario

    <OperationContract()> _
    Function Obtener(ByVal oeHistorialInventario As e_HistorialInventario) As e_HistorialInventario

    <OperationContract()> _
    Function Listar(ByVal oeHistorialInventario As e_HistorialInventario) As List(Of e_HistorialInventario)

    <OperationContract()> _
    Function Listar_Inventario(ByVal oeInventario As e_Inventario) As List(Of e_HistorialInventario)

    <OperationContract()> _
    Function Validar(ByVal oeHistorialInventario As e_HistorialInventario) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeHistorialInventario As e_HistorialInventario) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeHistorialInventario As e_HistorialInventario) As Boolean

    <OperationContract()> _
    Function CrearDT() As Data.DataTable

End Interface
