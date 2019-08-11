Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ModeloFuncionalVehiculo", también debe actualizar la referencia a "Ie_ModeloFuncionalVehiculo" en Web.config.
<ServiceContract()> _
Public Interface Ie_ModeloFuncionalVehiculo

    <OperationContract()> _
    Function Obtener(ByVal modeloFuncionalVehiculo As e_ModeloFuncionalVehiculo) As e_ModeloFuncionalVehiculo

End Interface
