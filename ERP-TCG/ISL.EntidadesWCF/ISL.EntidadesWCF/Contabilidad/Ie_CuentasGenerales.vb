Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_CuentasGenerales", también debe actualizar la referencia a "Ie_CuentasGenerales" en Web.config.
<ServiceContract()> _
Public Interface Ie_CuentasGenerales

    <OperationContract()> _
    Function Obtener(ByVal cuentasGenerales As e_CuentasGenerales) As e_CuentasGenerales

End Interface
