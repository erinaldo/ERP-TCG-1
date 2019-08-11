Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_MaterialesNegociadosDet", también debe actualizar la referencia a "Ie_MaterialesNegociadosDet" en Web.config.
<ServiceContract()> _
Public Interface Ie_MaterialesNegociadosDet

    <OperationContract()> _
    Function Obtener(ByVal materialesnegociadosdet As e_MaterialesNegociadosDet) As e_MaterialesNegociadosDet

End Interface
