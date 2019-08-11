Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_TipoZona", también debe actualizar la referencia a "Ie_TipoZona" en Web.config.
<ServiceContract()> _
Public Interface Ie_TipoZona

    <OperationContract()> _
    Function Obtener(ByVal tipoZona As e_TipoZona) As e_TipoZona

End Interface
