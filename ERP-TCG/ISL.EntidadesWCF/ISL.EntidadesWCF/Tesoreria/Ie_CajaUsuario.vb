Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_CajaUsuario", también debe actualizar la referencia a "Ie_CajaUsuario" en Web.config.
<ServiceContract()> _
Public Interface Ie_CajaUsuario

    <OperationContract()> _
    Function Obtener(ByVal cajaUsuario As e_CajaUsuario) As e_CajaUsuario

End Interface
