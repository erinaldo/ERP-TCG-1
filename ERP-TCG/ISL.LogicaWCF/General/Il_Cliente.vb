Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Cliente", también debe actualizar la referencia a "Il_Cliente" en Web.config.
<ServiceContract()> _
Public Interface Il_Cliente

    <OperationContract()> _
    Function Obtener(ByVal oeCliente As e_Cliente) As e_Cliente

    <OperationContract()> _
    Function ObtenerId(ByVal id As String) As e_Cliente

    <OperationContract()> _
    Function Listar(ByVal oeCliente As e_Cliente) As List(Of e_Cliente)

    <OperationContract()> _
    Function ComboGrilla(ByVal ListaCliente As List(Of e_Cliente))

    <OperationContract()> _
    Function Validar(ByVal oeCliente As e_Cliente) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeCliente As e_Cliente) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeCliente As e_Cliente) As Boolean

    '<OperationContract()> _
    'Function Foto(ByVal DNI As String) As System.Drawing.Bitmap

End Interface
