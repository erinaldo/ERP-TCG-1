Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_RegimenPensionario", también debe actualizar la referencia a "Ie_RegimenPensionario" en Web.config.
<ServiceContract()> _
Public Interface Ie_RegimenPensionario

    <OperationContract()> _
    Function obtener(ByVal oeRegimenPensionario As e_RegimenPensionario) As e_RegimenPensionario

End Interface
