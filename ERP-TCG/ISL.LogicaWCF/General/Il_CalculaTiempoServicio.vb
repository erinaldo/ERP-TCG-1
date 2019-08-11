Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_CalculaTiempoServicio" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_CalculaTiempoServicio

    <OperationContract()> _
    Function Obtener(ByVal oeCalculaTiempoServicio As e_CalculaTiempoServicio) As e_CalculaTiempoServicio

End Interface
