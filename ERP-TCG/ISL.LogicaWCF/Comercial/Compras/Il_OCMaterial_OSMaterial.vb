Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_OCMaterial_OSMaterial", también debe actualizar la referencia a "Il_OCMaterial_OSMaterial" en Web.config.
<ServiceContract()> _
Public Interface Il_OCMaterial_OSMaterial

    <OperationContract()> _
    Function Obtener(ByVal OeOCMaterial_OSMaterial As e_OCMaterial_OSMaterial) As e_OCMaterial_OSMaterial

    <OperationContract()> _
    Function Listar(ByVal OeOCMaterial_OSMaterial As e_OCMaterial_OSMaterial) As List(Of e_OCMaterial_OSMaterial)

    <OperationContract()> _
    Function Guardar(ByVal OeOCMaterial_OSMaterial As e_OCMaterial_OSMaterial) As Boolean

End Interface
