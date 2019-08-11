Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_CuotaDocVeh_Movimiento", también debe actualizar la referencia a "Ie_CuotaDocVeh_Movimiento" en Web.config.
<ServiceContract()> _
Public Interface Ie_CuotaDocVeh_Movimiento

    <OperationContract()> _
      Function Obtener(ByVal cuotadocveh_movimiento As e_CuotaDocVeh_Movimiento) As e_CuotaDocVeh_Movimiento

End Interface
