Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Gasto_RegistroConsumoCombustible", también debe actualizar la referencia a "Ie_Gasto_RegistroConsumoCombustible" en Web.config.
<ServiceContract()> _
Public Interface Ie_Gasto_RegistroConsumoCombustible

    <OperationContract()> _
    Function Obtener(ByVal gasto_RegistroConsumoCombustible As e_Gasto_RegistroConsumoCombustible) As e_Gasto_RegistroConsumoCombustible

End Interface
