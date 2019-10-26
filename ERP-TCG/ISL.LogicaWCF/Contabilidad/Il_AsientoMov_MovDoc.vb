Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_AsientoMov_MovDoc", también debe actualizar la referencia a "Il_AsientoMov_MovDoc" en Web.config.
<ServiceContract()> _
Public Interface Il_AsientoMov_MovDoc

    <OperationContract()> _
    Function Obtener(ByVal oeAsientoMov_MovDoc As e_AsientoMov_MovDoc) As e_AsientoMov_MovDoc

    <OperationContract()> _
    Function Listar(ByVal oeAsientoMov_MovDoc As e_AsientoMov_MovDoc) As List(Of e_AsientoMov_MovDoc)

    <OperationContract()> _
    Function Validar(ByVal oeAsientoMov_MovDoc As e_AsientoMov_MovDoc) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeAsientoMov_MovDoc As e_AsientoMov_MovDoc) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeAsientoMov_MovDoc As e_AsientoMov_MovDoc) As Boolean

    <OperationContract()> _
    Function CrearDT() As DataTable

End Interface
