Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_TipoCarga", también debe actualizar la referencia a "Il_TipoCarga" en Web.config.
<ServiceContract()> _
Public Interface Il_TipoCarga

    <OperationContract()> _
    Function Obtener(ByVal oeTipoCarga As e_TipoCarga) As e_TipoCarga

    <OperationContract()> _
    Function Listar(ByVal oeTipoCarga As e_TipoCarga) As List(Of e_TipoCarga)

    <OperationContract()> _
    Function Validar(ByVal oeTipoCarga As e_TipoCarga) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeTipoCarga As e_TipoCarga) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeTipoCarga As e_TipoCarga) As Boolean

    <OperationContract()> _
    Function ComboGrilla(ByVal ListaTipoCarga As List(Of e_TipoCarga))

End Interface
