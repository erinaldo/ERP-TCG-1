Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Servicio", también debe actualizar la referencia a "Il_Servicio" en Web.config.
<ServiceContract()> _
Public Interface Il_Servicio

    <OperationContract()> _
    Function Obtener(ByVal oeServicio As e_Servicio) As e_Servicio

    <OperationContract()> _
    Function Listar(ByVal oeServicio As e_Servicio) As List(Of e_Servicio)

    <OperationContract()> _
    Function Validar(ByVal oeServicio As e_Servicio) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeServicio As e_Servicio) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeServicio As e_Servicio) As Boolean

End Interface
