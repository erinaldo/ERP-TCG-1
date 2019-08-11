Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_CategoriaServicio", también debe actualizar la referencia a "Ie_CategoriaServicio" en Web.config.
<ServiceContract()> _
Public Interface Ie_CategoriaServicio

    <OperationContract()> _
    Function Obtener(ByVal categoriaServicio As e_CategoriaServicio) As e_CategoriaServicio

End Interface
