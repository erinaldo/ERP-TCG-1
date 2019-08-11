Imports System.ServiceModel
Imports ISL.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_PeajeTarifa" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_PeajeTarifa

    <OperationContract()> _
    Function Guardar(oePeajeTarifa As e_PeajeTarifa) As Boolean

    <OperationContract()> _
    Function Obtener(oePeajeTarifa As e_PeajeTarifa) As e_PeajeTarifa

    <OperationContract()> _
    Function Listar(oePeajeTarifa As e_PeajeTarifa) As List(Of e_PeajeTarifa)

    <OperationContract()> _
    Function Eliminar(oePeajeTarifa As e_PeajeTarifa) As Boolean

End Interface
