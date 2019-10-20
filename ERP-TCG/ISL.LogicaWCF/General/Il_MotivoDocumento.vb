Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_MotivoDocumento", también debe actualizar la referencia a "Il_MotivoDocumento" en Web.config.
<ServiceContract()> _
Public Interface Il_MotivoDocumento

    <OperationContract()> _
    Function Obtener(ByVal oeMotivoDocumento As e_MotivoDocumento) As e_MotivoDocumento

    <OperationContract()> _
    Function Listar(ByVal oeMotivoDocumento As e_MotivoDocumento) As List(Of e_MotivoDocumento)

    <OperationContract()> _
    Function Validar(ByVal oeMotivoDocumento As e_MotivoDocumento) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeMotivoDocumento As e_MotivoDocumento) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMotivoDocumento As e_MotivoDocumento) As Boolean

    <OperationContract()> _
    Function ComboGrilla(ByVal ListaMotivoDocumento As List(Of e_MotivoDocumento))

End Interface
