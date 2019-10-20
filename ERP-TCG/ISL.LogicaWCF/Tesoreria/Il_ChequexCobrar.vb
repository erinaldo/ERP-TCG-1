Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ChequexCobrar", también debe actualizar la referencia a "Il_ChequexCobrar" en Web.config.
<ServiceContract()> _
Public Interface Il_ChequexCobrar

    <OperationContract()> _
    Function Obtener(ByVal oeChequexCobrar As e_ChequexCobrar) As e_ChequexCobrar

    <OperationContract()> _
    Function Listar(ByVal oeChequexCobrar As e_ChequexCobrar) As List(Of e_ChequexCobrar)

    <OperationContract()> _
    Function Validar(ByVal oeChequexCobrar As e_ChequexCobrar) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeChequexCobrar As e_ChequexCobrar) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeChequexCobrar As e_ChequexCobrar) As Boolean

End Interface
