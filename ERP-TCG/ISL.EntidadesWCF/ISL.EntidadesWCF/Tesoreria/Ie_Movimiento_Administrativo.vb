Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Movimiento_Administrativo", también debe actualizar la referencia a "Ie_Movimiento_Administrativo" en Web.config.
<ServiceContract()> _
Public Interface Ie_Movimiento_Administrativo

    <OperationContract()> _
    Function Obtener(ByVal movimiento_Administrativo As e_Movimiento_Administrativo) As e_Movimiento_Administrativo

End Interface
