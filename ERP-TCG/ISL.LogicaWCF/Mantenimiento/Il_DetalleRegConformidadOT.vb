Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_DetalleRegConformidadOT", también debe actualizar la referencia a "Il_DetalleRegConformidadOT" en Web.config.
<ServiceContract()> _
Public Interface Il_DetalleRegConformidadOT

    <OperationContract()> _
    Function Obtener(ByVal oeDetalleRegConformidadOT As e_DetalleRegConformidadOT) As e_DetalleRegConformidadOT

    <OperationContract()> _
    Function Listar(ByVal oeDetalleRegConformidadOT As e_DetalleRegConformidadOT) As DataSet

    <OperationContract()> _
    Function Validar(ByVal oeDetalleRegConformidadOT As e_DetalleRegConformidadOT) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDetalleRegConformidadOT As e_DetalleRegConformidadOT) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDetalleRegConformidadOT As e_DetalleRegConformidadOT) As Boolean

End Interface
