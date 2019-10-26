Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Asiento_MovDoc", también debe actualizar la referencia a "Il_Asiento_MovDoc" en Web.config.
<ServiceContract()> _
Public Interface Il_Asiento_MovDoc

    <OperationContract()> _
    Function Obtener(ByVal oeAsiento_MovDoc As e_Asiento_MovDoc) As e_Asiento_MovDoc

    <OperationContract()> _
    Function Listar(ByVal oeAsiento_MovDoc As e_Asiento_MovDoc) As List(Of e_Asiento_MovDoc)

    <OperationContract()> _
    Function Guardar(ByVal oeAsiento_MovDoc As e_Asiento_MovDoc) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeAsiento_MovDoc As e_Asiento_MovDoc) As Boolean

    <OperationContract()> _
    Function CrearDT() As Data.DataTable

End Interface
