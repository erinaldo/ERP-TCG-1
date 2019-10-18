Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Il_Configuracion", también debe actualizar la referencia a "Il_Configuracion" en Web.config.
<ServiceContract()> _
Public Interface Il_Configuracion

    <OperationContract()> _
    Function Sedes() As List(Of String)

    '<OperationContract()> _
    'Function RutaImagen() As String

    <OperationContract()> _
    Function RutaAyuda() As String

    <OperationContract()> _
    Function Servidor() As String

    <OperationContract()> _
    Function IPServidor() As String

    <OperationContract()> _
    Function IPServidorReportes() As String

    <OperationContract()> _
    Function Fotos() As String

    '<OperationContract()> _
    'Function PrefijoID() As String

    <OperationContract()> _
    Function DocElectronico() As String

End Interface
