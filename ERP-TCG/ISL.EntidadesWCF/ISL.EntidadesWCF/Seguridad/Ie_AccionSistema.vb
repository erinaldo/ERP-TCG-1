Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_AccionSistema", también debe actualizar la referencia a "Ie_AccionSistema" en Web.config.
<ServiceContract()> _
Public Interface Ie_AccionSistema

    <OperationContract()> _
     Function Obtener(ByVal accionsistema As e_AccionSistema) As e_AccionSistema

End Interface
