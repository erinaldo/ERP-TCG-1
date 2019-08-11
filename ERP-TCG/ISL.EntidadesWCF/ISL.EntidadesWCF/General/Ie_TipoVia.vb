Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_TipoVia", también debe actualizar la referencia a "Ie_TipoVia" en Web.config.
<ServiceContract()> _
Public Interface Ie_TipoVia

    <OperationContract()> _
    Function Obtener(ByVal tipoVia As e_TipoVia) As e_TipoVia

End Interface
