Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_PerfilActividadNegocio", también debe actualizar la referencia a "Ie_PerfilActividadNegocio" en Web.config.
<ServiceContract()> _
Public Interface Ie_PerfilActividadNegocio

    <OperationContract()> _
    Function Obtener(ByVal perfilActividadNegocio As e_PerfilActividadNegocio) As e_PerfilActividadNegocio

End Interface
