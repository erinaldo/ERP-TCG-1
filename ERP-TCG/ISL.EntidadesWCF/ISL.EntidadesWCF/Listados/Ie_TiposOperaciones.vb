Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_TiposOperaciones", también debe actualizar la referencia a "Ie_TiposOperaciones" en Web.config.
<ServiceContract()> _
Public Interface Ie_TiposOperaciones

    ''' <summary>
    ''' Inicializar tipos de operación por stándares y/o por defecto
    ''' </summary>
    <OperationContract()> _
    Sub Inicializar()

    <OperationContract()> _
    Sub Agregar(ByVal tipoOperacion As e_TipoOperacion)

    <OperationContract()> _
    Sub QuitarIndice(ByVal indice As Integer)

    <OperationContract()> _
    Sub QuitarNombre(ByVal dato As String)

    <OperationContract()> _
    Sub Quitar(ByVal tipoOperacion As e_TipoOperacion)

    <OperationContract()> _
    Function Cuantos() As Integer

    <OperationContract()> _
    Function Obtener(ByVal indice As Integer) As e_TipoOperacion

    <OperationContract()> _
    Function ObtenerOperacionActual() As e_TipoOperacion

    <OperationContract()> _
    Sub Establecer(ByVal indice As Integer, ByVal tipoOperacion As e_TipoOperacion)

    <OperationContract()> _
    Sub EstablecerOperacionActual(ByVal indice As Integer)

End Interface
