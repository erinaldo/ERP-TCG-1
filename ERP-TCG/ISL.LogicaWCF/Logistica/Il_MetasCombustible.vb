Imports System.ServiceModel
Imports ISL.EntidadesWCF

<ServiceContract()> _
Public Interface Il_MetasCombustible

    <OperationContract()> _
    Function Obtener(ByVal oeMetasCombustible As e_MetasCombustible) As e_MetasCombustible

    <OperationContract()> _
    Function Listar(ByVal oeMetasCombustible As e_MetasCombustible) As List(Of e_MetasCombustible)

    <OperationContract()> _
    Function Guardar(ByVal oeMetasCombustible As e_MetasCombustible) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMetasCombustible As e_MetasCombustible) As Boolean

End Interface
