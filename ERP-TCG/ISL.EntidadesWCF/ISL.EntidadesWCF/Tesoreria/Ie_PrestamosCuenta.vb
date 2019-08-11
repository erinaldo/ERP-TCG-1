Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_PrestamosCuenta", también debe actualizar la referencia a "Ie_PrestamosCuenta" en Web.config.
<ServiceContract()> _
Public Interface Ie_PrestamosCuenta

    <OperationContract()> _
     Function Obtener(ByVal otrosingresos As e_PrestamosCuenta) As e_PrestamosCuenta

End Interface
