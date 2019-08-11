Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_DetalleDoc_OperacionDet", también debe actualizar la referencia a "Ie_DetalleDoc_OperacionDet" en Web.config.
<ServiceContract()> _
Public Interface Ie_DetalleDoc_OperacionDet

    <OperationContract()> _
    Function Obtener(ByVal detalleDoc_OperacionDet As e_DetalleDoc_OperacionDet) As e_DetalleDoc_OperacionDet

End Interface
