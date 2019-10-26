Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_CodigoBarraMaterial", también debe actualizar la referencia a "Il_CodigoBarraMaterial" en Web.config.
<ServiceContract()> _
Public Interface Il_CodigoBarraMaterial

    <OperationContract()> _
    Function Obtener(ByVal oeCodigoBarraMaterial As e_CodigoBarraMaterial) As e_CodigoBarraMaterial

    <OperationContract()> _
    Function Listar(ByVal oeCodigoBarraMaterial As e_CodigoBarraMaterial) As List(Of e_CodigoBarraMaterial)

    <OperationContract()> _
    Function Guardar(ByVal oeCodigoBarraMaterial As e_CodigoBarraMaterial) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeCodigoBarraMaterial As e_CodigoBarraMaterial) As Boolean

End Interface
