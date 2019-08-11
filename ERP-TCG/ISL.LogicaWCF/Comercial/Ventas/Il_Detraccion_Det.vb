Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Detraccion_Det", también debe actualizar la referencia a "Il_Detraccion_Det" en Web.config.
<ServiceContract()> _
Public Interface Il_Detraccion_Det

    <OperationContract()> _
    Function Obtener(ByVal oeDetraccion_Det As e_Detraccion_Det) As e_Detraccion_Det

    <OperationContract()> _
    Function Listar(ByVal oeDetraccion_Det As e_Detraccion_Det) As List(Of e_Detraccion_Det)

    <OperationContract()> _
    Function Validar(ByVal oeDetraccion_Det As e_Detraccion_Det) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDetraccion_Det As e_Detraccion_Det) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDetraccion_Det As e_Detraccion_Det) As Boolean

    <OperationContract()> _
    Function GuardarLista(ByVal leDetraccionDet As List(Of e_Detraccion_Det)) As Boolean

    <OperationContract()> _
    Function EliminarLista(ByVal leDetraccionDet As List(Of e_Detraccion_Det)) As Boolean

End Interface
