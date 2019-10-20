Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_CuotaDocumentoVehiculo", también debe actualizar la referencia a "Il_CuotaDocumentoVehiculo" en Web.config.
<ServiceContract()> _
Public Interface Il_CuotaDocumentoVehiculo

    <OperationContract()> _
     Function Listar(ByVal oeCuotaDocumentoVehiculo As e_CuotaDocumentoVehiculo) As List(Of e_CuotaDocumentoVehiculo)

    <OperationContract()> _
    Function ListarDts(ByVal oeCuotaDocumentoVehiculo As e_CuotaDocumentoVehiculo) As DataSet

    <OperationContract()> _
     Function Validar(ByVal oeCuotaDocumentoVehiculo As e_CuotaDocumentoVehiculo) As Boolean

    <OperationContract()> _
     Function Guardar(ByVal oeCuotaDocumentoVehiculo As e_CuotaDocumentoVehiculo) As Boolean

End Interface
