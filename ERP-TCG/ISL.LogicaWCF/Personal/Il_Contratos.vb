Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_Contratos" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_Contratos

    <OperationContract()> _
    Overloads Function Validar(ByVal oeContratos As e_Contratos) As Boolean

    <OperationContract()> _
    Overloads Function Obtener(ByVal oeContratos As e_Contratos) As e_Contratos

    <OperationContract()> _
    Overloads Function Listar(ByVal oeContratos As e_Contratos) As List(Of e_Contratos)

    <OperationContract()> _
    Overloads Function Guardar(ByVal oeContratos As e_Contratos) As Boolean

    <OperationContract()> _
    Overloads Function Eliminar(ByVal oeContratos As e_Contratos) As Boolean

    <OperationContract()> _
    Overloads Function Clonar(ByVal oeContrato1 As e_Contratos, ByVal oeContrato2 As e_Contratos) As Boolean

End Interface
