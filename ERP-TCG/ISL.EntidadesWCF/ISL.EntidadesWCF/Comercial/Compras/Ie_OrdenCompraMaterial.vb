Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_OrdenCompraMaterial", también debe actualizar la referencia a "Ie_OrdenCompraMaterial" en Web.config.
<ServiceContract()> _
Public Interface Ie_OrdenCompraMaterial

    <OperationContract()> _
    Function Obtener(ByVal ordenCompraMaterial As e_OrdenCompraMaterial) As e_OrdenCompraMaterial

End Interface
