Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Denominacion", también debe actualizar la referencia a "Il_Denominacion" en Web.config.
<ServiceContract()> _
Public Interface Il_Denominacion

    <OperationContract()> _
    Function Obtener(ByVal oeDenominacion As e_Denominacion) As e_Denominacion

    <OperationContract()> _
    Function Listar(ByVal oeDenominacion As e_Denominacion) As List(Of e_Denominacion)

    <OperationContract()> _
    Function Validar(ByVal oeDenominacion As e_Denominacion) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDenominacion As e_Denominacion) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDenominacion As e_Denominacion) As Boolean

End Interface
