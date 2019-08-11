Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_TablaContableDet", también debe actualizar la referencia a "Ie_TablaContableDet" en Web.config.
<ServiceContract()> _
Public Interface Ie_TablaContableDet

    <OperationContract()> _
    Function Obtener(ByVal tablaContableDet As e_TablaContableDet) As e_TablaContableDet

End Interface
