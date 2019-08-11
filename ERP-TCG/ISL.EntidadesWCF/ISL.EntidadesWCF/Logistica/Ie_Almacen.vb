Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Almacen", también debe actualizar la referencia a "Ie_Almacen" en Web.config.
<ServiceContract()> _
Public Interface Ie_Almacen

    <OperationContract()> _
    Function Obtener(ByVal almacen As e_Almacen) As e_Almacen

End Interface
