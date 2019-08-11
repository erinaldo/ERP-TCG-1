Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_DetalleDocumentoVehiculo", también debe actualizar la referencia a "Il_DetalleDocumentoVehiculo" en Web.config.
<ServiceContract()> _
Public Interface Il_DetalleDocumentoVehiculo

    <OperationContract()> _
     Function Obtener(ByVal oeDetalleDocumentoVehiculo As e_DetalleDocumentoVehiculo) As e_DetalleDocumentoVehiculo

    <OperationContract()> _
     Function Listar(ByVal oeDetalleDocumentoVehiculo As e_DetalleDocumentoVehiculo) As List(Of e_DetalleDocumentoVehiculo)

    <OperationContract()> _
     Function Validar(ByVal oeDetalleDocumentoVehiculo As e_DetalleDocumentoVehiculo) As Boolean

    <OperationContract()> _
     Function Guardar(ByVal oeDetalleDocumentoVehiculo As e_DetalleDocumentoVehiculo) As Boolean

    <OperationContract()> _
     Function Eliminar(ByVal oeDetalleDocumentoVehiculo As e_DetalleDocumentoVehiculo) As Boolean


End Interface
