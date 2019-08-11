Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_PreliminarInspeccion", también debe actualizar la referencia a "Ie_PreliminarInspeccion" en Web.config.
<ServiceContract()> _
Public Interface Ie_PreliminarInspeccion

    <OperationContract()> _
    Function Obtener(ByVal preliminarinspeccion As e_PreliminarInspeccion) As e_PreliminarInspeccion

End Interface
