Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_MotivoCese" en el código y en el archivo de configuración a la vez.

<ServiceContract()>
Public Interface Il_MotivoCese

    <OperationContract()> _
    Function Obtener(ByVal oeMotivoCese As e_MotivoCese) As e_MotivoCese

    <OperationContract()> _
    Function Listar(ByVal oeMotivoCese As e_MotivoCese) As List(Of e_MotivoCese)

    <OperationContract()> _
    Function Validar(ByVal oeMotivoCese As e_MotivoCese) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeMotivoCese As e_MotivoCese) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMotivoCese As e_MotivoCese) As Boolean

End Interface
