Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_MedidaNeumatico", también debe actualizar la referencia a "Ie_MedidaNeumatico" en Web.config.
<ServiceContract()> _
Public Interface Ie_MedidaNeumatico

    <OperationContract()> _
    Function Obtener(ByVal medidaNeumatico As e_MedidaNeumatico) As e_MedidaNeumatico

End Interface
