Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Zona", también debe actualizar la referencia a "Il_Zona" en Web.config.
<ServiceContract()> _
Public Interface Il_Zona

    <OperationContract()> _
    Function Obtener(ByVal oeZona As e_Zona) As e_Zona

    <OperationContract()> _
    Function Listar(ByVal oeZona As e_Zona) As List(Of e_Zona)

    <OperationContract()> _
    Function Validar(ByVal oeZona As e_Zona) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeZona As e_Zona) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeZona As e_Zona) As Boolean

    <OperationContract()> _
    Function ComboGrilla(ByVal oeZona As e_Zona)

    <OperationContract()> _
    Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo As String) As Boolean

End Interface
