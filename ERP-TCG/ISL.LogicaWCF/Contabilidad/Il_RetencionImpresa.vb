Imports System.ServiceModel
Imports ISL.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_RetencionImpresa" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_RetencionImpresa

    <OperationContract()> _
    Function Listar(oeEjercicio As e_RetencionImpresa) As List(Of e_RetencionImpresa)

    <OperationContract()> _
    Function Guardar(lo As List(Of e_RetencionImpresa)) As Boolean

End Interface
