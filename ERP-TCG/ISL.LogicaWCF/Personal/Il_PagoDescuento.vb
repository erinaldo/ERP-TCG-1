Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_PagoDescuento", también debe actualizar la referencia a "Il_PagoDescuento" en Web.config.
<ServiceContract()> _
Public Interface Il_PagoDescuento

    <OperationContract()> _
    Function Listar(ByVal oePagoDescuento As e_PagoDescuento) As List(Of e_PagoDescuento)

End Interface
