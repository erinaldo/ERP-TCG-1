Imports System.ServiceModel
Imports ERP.EntidadesWCF

<ServiceContract()>
Public Interface Il_MovimientoDocumento_Impresion

    <OperationContract()>
    Function Obtener(ByVal Item As e_MovimientoDocumento_Impresion) As e_MovimientoDocumento_Impresion

    <OperationContract()>
    Function Listar(ByVal Item As e_MovimientoDocumento_Impresion) As List(Of e_MovimientoDocumento_Impresion)

    <OperationContract()>
    Function Guardar(ByVal Item As e_MovimientoDocumento_Impresion) As e_MovimientoDocumento_Impresion

    <OperationContract()>
    Function Eliminar(ByVal Item As e_MovimientoDocumento_Impresion) As Boolean

End Interface