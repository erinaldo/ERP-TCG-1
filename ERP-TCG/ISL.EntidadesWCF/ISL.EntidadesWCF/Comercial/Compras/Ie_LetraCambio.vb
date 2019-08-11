Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_LetraCambio", también debe actualizar la referencia a "Ie_LetraCambio" en Web.config.
<ServiceContract()> _
Public Interface Ie_LetraCambio

    <OperationContract()> _
    Function Obtener(ByVal letraCambio As e_LetraCambio) As e_LetraCambio

End Interface
