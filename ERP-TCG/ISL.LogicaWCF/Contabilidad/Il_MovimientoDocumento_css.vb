'=====================================================================================================
'=== CAPA : INTERFACE LOGICA =========================================================================
'=====================================================================================================

Imports System.ServiceModel
Imports ERP.EntidadesWCF

<ServiceContract()>
Public Interface Il_MovimientoDocumento_css

    <OperationContract()>
    Function Obtener(ByVal Item As e_MovimientoDocumento_css) As e_MovimientoDocumento_css

    <OperationContract()>
    Function Listar(ByVal Item As e_MovimientoDocumento_css) As List(Of e_MovimientoDocumento_css)

    <OperationContract()>
    Function Guardar(ByVal Item As e_MovimientoDocumento_css) As e_MovimientoDocumento_css

    <OperationContract()>
    Function Eliminar(ByVal Item As e_MovimientoDocumento_css) As Boolean

End Interface