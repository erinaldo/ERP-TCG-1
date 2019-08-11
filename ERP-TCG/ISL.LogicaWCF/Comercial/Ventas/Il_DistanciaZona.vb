Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_DistanciaZona" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_DistanciaZona

    '<OperationContract()>
    'Sub DoWork()

    <OperationContract()> _
    Function Obtener(oeDistanciaZona As e_DistanciaZona) As e_DistanciaZona

    <OperationContract()> _
    Function Listar(oeDistanciaZona As e_DistanciaZona) As List(Of e_DistanciaZona)

    <OperationContract()> _
    Function Guardar(oeDistanciaZona As e_DistanciaZona) As Boolean

    <OperationContract()> _
    Function Eliminar(oeDistanciaZona As e_DistanciaZona) As Boolean

End Interface
