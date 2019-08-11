Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_DetallePlanillaPiloto" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_DetallePlanillaPiloto

    <OperationContract()> _
    Function Listar(ByVal oe As e_DetallePlanillaPiloto) As List(Of e_DetallePlanillaPiloto)

End Interface
