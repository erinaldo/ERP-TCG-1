Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_DetalleOrdenNeumatico", también debe actualizar la referencia a "Il_DetalleOrdenNeumatico" en Web.config.
<ServiceContract()> _
Public Interface Il_DetalleOrdenNeumatico

    <OperationContract()> _
    Function Obtener(ByVal oedetalleordenneumatico As e_DetalleOrdenNeumatico) As e_DetalleOrdenNeumatico

    <OperationContract()> _
    Function Listar(ByVal oedetalleordenneumatico As e_DetalleOrdenNeumatico) As List(Of e_DetalleOrdenNeumatico)

    <OperationContract()> _
    Function Validar(ByVal oedetalleordenneumatico As e_DetalleOrdenNeumatico) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oedetalleordenneumatico As e_DetalleOrdenNeumatico) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oedetalleordenneumatico As e_DetalleOrdenNeumatico) As Boolean

End Interface
