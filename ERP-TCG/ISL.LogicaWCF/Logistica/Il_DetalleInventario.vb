Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_DetalleInventario", también debe actualizar la referencia a "Il_DetalleInventario" en Web.config.
<ServiceContract()> _
Public Interface Il_DetalleInventario

    <OperationContract()> _
    Function Listar(ByVal oeDetalleInventario As e_DetalleInventario) As List(Of e_DetalleInventario)

End Interface
