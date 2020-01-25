Imports System.ServiceModel
Imports ERP.EntidadesWCF

<ServiceContract()>
Public Interface Il_DetalleDocumento_css

    <OperationContract()>
    Function Obtener(ByVal Item As e_DetalleDocumento_css) As e_DetalleDocumento_css

    <OperationContract()>
    Function Listar(ByVal Item As e_DetalleDocumento_css) As List(Of e_DetalleDocumento_css)

    <OperationContract()>
    Function Guardar(ByVal Item As e_DetalleDocumento_css) As e_DetalleDocumento_css

    <OperationContract()>
    Function Eliminar(ByVal Item As e_DetalleDocumento_css) As Boolean

End Interface