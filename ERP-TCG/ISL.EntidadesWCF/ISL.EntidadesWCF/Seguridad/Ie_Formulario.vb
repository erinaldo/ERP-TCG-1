Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Formulario", también debe actualizar la referencia a "Ie_Formulario" en Web.config.
<ServiceContract()> _
Public Interface Ie_Formulario

    <OperationContract()> _
    Function Obtener(ByVal formulario As e_Formulario) As e_Formulario

End Interface
