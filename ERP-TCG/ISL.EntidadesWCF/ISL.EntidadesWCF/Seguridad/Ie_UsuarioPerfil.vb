Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_UsuarioPerfil", también debe actualizar la referencia a "Ie_UsuarioPerfil" en Web.config.
<ServiceContract()> _
Public Interface Ie_UsuarioPerfil

    <OperationContract()> _
    Function Obtener(ByVal usuarioPerfil As e_UsuarioPerfil) As e_UsuarioPerfil

End Interface
