Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Direccion_EmpresaPersona", también debe actualizar la referencia a "Ie_Direccion_EmpresaPersona" en Web.config.
<ServiceContract()> _
Public Interface Ie_Direccion_EmpresaPersona

    <OperationContract()> _
    Function Obtener(ByVal direccion_EmpresaPersona As e_Direccion_EmpresaPersona) As e_Direccion_EmpresaPersona

End Interface
