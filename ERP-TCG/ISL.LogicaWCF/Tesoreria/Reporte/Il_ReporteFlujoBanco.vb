Imports System.ServiceModel
Imports ISL.EntidadesWCF


' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_ReporteFlujoBanco" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_ReporteFlujoBanco

    <OperationContract()> _
    Function Listar(ByVal oe As e_ReporteFlujoBanco) As List(Of e_ReporteFlujoBanco)

    <OperationContract()>
    Function Guardar(ByVal oe As List(Of e_ReporteFlujoBanco), id As String, ByVal PrefijoID As String) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oe As String) As Boolean

End Interface
