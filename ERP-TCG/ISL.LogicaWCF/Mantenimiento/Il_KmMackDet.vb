Imports System.ServiceModel
Imports ISL.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_KmMackDet" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_KmMackDet

    <OperationContract()>
    Function Obtener(ByVal oeKmMackDet As e_KmMackDet) As e_KmMackDet

    <OperationContract()>
    Function Listar(ByVal oeKmMackDet As e_KmMackDet) As List(Of e_KmMackDet)

    <OperationContract()>
    Function Guardar(ByVal oeKmMackDet As e_KmMackDet) As Boolean

    <OperationContract()>
    Function Eliminar(ByVal oeKmMackDet As e_KmMackDet) As Boolean

End Interface
