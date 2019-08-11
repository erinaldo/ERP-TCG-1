Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_SubAlmacen", también debe actualizar la referencia a "Ie_SubAlmacen" en Web.config.
<ServiceContract()> _
Public Interface Ie_SubAlmacen

    <OperationContract()> _
    Function Obtener(ByVal subAlmacen As e_SubAlmacen) As e_SubAlmacen

End Interface
