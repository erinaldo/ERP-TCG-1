Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_OCMaterial_OSMaterial", también debe actualizar la referencia a "Ie_OCMaterial_OSMaterial" en Web.config.
<ServiceContract()> _
Public Interface Ie_OCMaterial_OSMaterial

    <OperationContract()> _
    Function Obtener(ByVal OCMaterial_OSMaterial As e_OCMaterial_OSMaterial) As e_OCMaterial_OSMaterial

End Interface
