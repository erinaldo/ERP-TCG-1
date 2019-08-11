Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_DetalleAsignacion", también debe actualizar la referencia a "Il_DetalleAsignacion" en Web.config.
<ServiceContract()> _
Public Interface Il_DetalleAsignacion

    <OperationContract()> _
    Function Obtener(ByVal oeDetalleAsignacion As e_DetalleAsignacion) As e_DetalleAsignacion

    <OperationContract()> _
    Function Listar(ByVal oeDetalleAsignacion As e_DetalleAsignacion) As List(Of e_DetalleAsignacion)

End Interface
