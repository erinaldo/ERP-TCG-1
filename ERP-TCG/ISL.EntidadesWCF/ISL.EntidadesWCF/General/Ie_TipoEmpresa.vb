Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_TipoEmpresa", también debe actualizar la referencia a "Ie_TipoEmpresa" en Web.config.
<ServiceContract()> _
Public Interface Ie_TipoEmpresa

    <OperationContract()> _
    Function Obtener(ByVal tipoEmpresa As e_TipoEmpresa) As e_TipoEmpresa

End Interface
