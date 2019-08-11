Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_TipoEquipo", también debe actualizar la referencia a "Ie_TipoEquipo" en Web.config.
<ServiceContract()> _
Public Interface Ie_TipoEquipo

    <OperationContract()> _
    Function Obtener(ByVal tipoEquipo As e_TipoEquipo) As e_TipoEquipo

End Interface
