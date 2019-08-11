Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_TablaContable", también debe actualizar la referencia a "Ie_TablaContable" en Web.config.
<ServiceContract()> _
Public Interface Ie_TablaContable

    <OperationContract()> _
    Function Obtener(ByVal tablaContable As e_TablaContable) As e_TablaContable

End Interface
