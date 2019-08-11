Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Venta", también debe actualizar la referencia a "Il_Venta" en Web.config.
<ServiceContract()> _
Public Interface Il_Venta

    <OperationContract()> _
    Function Obtener(ByVal oeVenta As e_Venta) As e_Venta

    <OperationContract()> _
    Function Listar(ByVal oeVenta As e_Venta) As List(Of e_Venta)

    <OperationContract()> _
    Function Validar(ByVal oeVenta As e_Venta) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeVenta As e_Venta) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeVenta As e_Venta) As Boolean

End Interface
