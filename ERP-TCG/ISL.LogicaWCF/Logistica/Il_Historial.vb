Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Historial", también debe actualizar la referencia a "Il_Historial" en Web.config.
<ServiceContract()> _
Public Interface Il_Historial

    <OperationContract()> _
    Function Obtener(ByVal oeHistorial As e_Historial) As e_Historial

    <OperationContract()> _
    Function Listar(ByVal oeHistorial As e_Historial) As List(Of e_Historial)

    <OperationContract()> _
    Function GuardarMasivo(ByVal oeHistorial As e_Historial) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeHistorial As e_Historial) As Boolean

    <OperationContract()> _
    Function CrearDT() As Data.DataTable

End Interface
