Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_OtrosIngresos", también debe actualizar la referencia a "Ie_OtrosIngresos" en Web.config.
<ServiceContract()> _
Public Interface Ie_OtrosIngresos

    <OperationContract()> _
     Function Obtener(ByVal otrosingresos As e_PrestamosCuenta) As e_PrestamosCuenta

End Interface
