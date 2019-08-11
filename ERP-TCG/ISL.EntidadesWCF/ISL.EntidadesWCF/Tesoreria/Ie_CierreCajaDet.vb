Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_CierreCajaDet", también debe actualizar la referencia a "Ie_CierreCajaDet" en Web.config.
<ServiceContract()> _
Public Interface Ie_CierreCajaDet

    <OperationContract()> _
    Function Obtener(ByVal cierrecajadet As e_CierreCajaDet) As e_CierreCajaDet

End Interface
