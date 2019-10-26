Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Formulario", también debe actualizar la referencia a "Il_Formulario" en Web.config.
<ServiceContract()> _
Public Interface Il_Formulario

    <OperationContract()> _
    Function Obtener(ByVal oeFormulario As e_Formulario) As e_Formulario

    <OperationContract()> _
    Function Listar(ByVal oeFormulario As e_Formulario) As List(Of e_Formulario)

    <OperationContract()> _
    Function ListarPadre(ByVal oeFormulario As e_Formulario) As List(Of e_Formulario)

    <OperationContract()> _
    Function ValidarNombre(ByVal Id As String, ByVal Nombre As String) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeFormulario As e_Formulario) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeFormulario As e_Formulario) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeFormulario As e_Formulario) As Boolean

End Interface
