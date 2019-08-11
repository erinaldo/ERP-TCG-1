Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_TipoUnidadMedida", también debe actualizar la referencia a "Ie_TipoUnidadMedida" en Web.config.
<ServiceContract()> _
Public Interface Ie_TipoUnidadMedida

    <OperationContract()> _
    Function Obtener(ByVal tipoUnidadMedida As e_TipoUnidadMedida) As e_TipoUnidadMedida

End Interface
