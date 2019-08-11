Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_LicenciaConducir", también debe actualizar la referencia a "Ie_LicenciaConducir" en Web.config.
<ServiceContract()> _
Public Interface Ie_LicenciaConducir

    <OperationContract()> _
    Function Obtener(ByVal licenciaConducir As e_LicenciaConducir) As e_LicenciaConducir

End Interface


