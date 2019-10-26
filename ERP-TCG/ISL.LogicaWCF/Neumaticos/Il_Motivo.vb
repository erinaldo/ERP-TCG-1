Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Motivo", también debe actualizar la referencia a "Il_Motivo" en Web.config.
<ServiceContract()> _
Public Interface Il_Motivo

    <OperationContract()> _
    Function Obtener(ByVal oeMotivo As e_Motivo) As e_Motivo

    <OperationContract()> _
    Function Listar(ByVal oeMotivo As e_Motivo) As List(Of e_Motivo)

    <OperationContract()> _
    Function Validar(ByVal oeMotivo As e_Motivo) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeMotivo As e_Motivo) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMotivo As e_Motivo) As Boolean

End Interface
