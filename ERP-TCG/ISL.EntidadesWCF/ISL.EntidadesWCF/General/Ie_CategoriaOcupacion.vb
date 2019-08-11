Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_CategoriaOcupacion", también debe actualizar la referencia a "Ie_CategoriaOcupacion" en Web.config.
<ServiceContract()> _
Public Interface Ie_CategoriaOcupacion

    <OperationContract()> _
    Function Obtener(ByVal categoriaOcupacion As e_CategoriaOcupacion) As e_CategoriaOcupacion

End Interface
