Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_MaterialAlmacen", también debe actualizar la referencia a "Ie_MaterialAlmacen" en Web.config.
<ServiceContract()> _
Public Interface Ie_MaterialAlmacen

    <OperationContract()> _
    Function Obtener(ByVal materialAlmacen As e_MaterialAlmacen) As e_MaterialAlmacen

End Interface
