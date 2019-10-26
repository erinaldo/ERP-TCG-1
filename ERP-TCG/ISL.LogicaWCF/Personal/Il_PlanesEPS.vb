Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_PlanesEPS" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_PlanesEPS

    <OperationContract()>
    Function Obtener(ByVal oePlanesEPS As e_PlanesEPS) As e_PlanesEPS

    <OperationContract()>
    Function Listar(ByVal oePlanesEPS As e_PlanesEPS) As List(Of e_PlanesEPS)

    <OperationContract()>
    Function Validar(ByVal oePlanesEPS As e_PlanesEPS) As Boolean

    <OperationContract()>
    Function Guardar(ByVal oePlanesEPS As e_PlanesEPS) As Boolean

    <OperationContract()>
    Function Eliminar(ByVal oePlanesEPS As e_PlanesEPS) As Boolean


End Interface
