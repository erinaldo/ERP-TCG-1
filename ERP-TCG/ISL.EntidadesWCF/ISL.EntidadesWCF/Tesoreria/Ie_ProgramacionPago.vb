Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ProgramacionPago", también debe actualizar la referencia a "e_ProgramacionPago" en Web.config.
<ServiceContract()> _
Public Interface Ie_ProgramacionPago

    <OperationContract()> _
    Function Obtener(ByVal programacionpago As e_ProgramacionPago) As e_ProgramacionPago

End Interface