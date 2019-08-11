Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_OrdenAprobacion", también debe actualizar la referencia a "Il_OrdenAprobacion" en Web.config.
<ServiceContract()> _
Public Interface Il_OrdenAprobacion

    <OperationContract()> _
    Function Obtener(ByVal oeOrdenAprobacion As e_OrdenAprobacion) As e_OrdenAprobacion

    <OperationContract()> _
    Function Listar(ByVal oeOrdenAprobacion As e_OrdenAprobacion) As List(Of e_OrdenAprobacion)

End Interface
