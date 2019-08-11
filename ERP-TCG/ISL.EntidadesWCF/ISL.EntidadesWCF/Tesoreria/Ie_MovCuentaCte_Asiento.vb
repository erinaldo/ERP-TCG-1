Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_MovCuentaCte_Asiento", también debe actualizar la referencia a "Ie_MovCuentaCte_Asiento" en Web.config.
<ServiceContract()> _
Public Interface Ie_MovCuentaCte_Asiento

    <OperationContract()> _
    Function Obtener(ByVal movcuentacte_asiento As e_MovCuentaCte_Asiento) As e_MovCuentaCte_Asiento

End Interface
