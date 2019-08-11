Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Persona", también debe actualizar la referencia a "Il_Persona" en Web.config.
<ServiceContract()> _
Public Interface Il_Persona

    <OperationContract()> _
    Function ValidarDNI(ByVal Id As String, ByVal DNI As String) As Boolean

    <OperationContract()> _
    Function ValidarFechaNacimiento(ByVal FechaNacimiento As DateTime) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oePersona As e_Persona) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oePersona As e_Persona) As String

    <OperationContract()> _
    Function Eliminar(ByVal oePersona As e_Persona) As Boolean

    <OperationContract()> _
    Function Obtener(ByVal oePersona As e_Persona) As e_Persona

    <OperationContract()> _
    Function Listar(ByVal oePersona As e_Persona) As List(Of e_Persona)

    <OperationContract()> _
    Function Foto(ByVal DNI As String) As System.Drawing.Bitmap

End Interface
