Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Perfil", también debe actualizar la referencia a "Ie_Perfil" en Web.config.
<ServiceContract()> _
Public Interface Ie_Perfil

    <OperationContract()> _
    Function Obtener(ByVal perfil As e_Perfil) As e_Perfil

End Interface
