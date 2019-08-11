Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Perfil", también debe actualizar la referencia a "Il_Perfil" en Web.config.
<ServiceContract()> _
Public Interface Il_Perfil

    <OperationContract()> _
    Function Obtener(ByVal oePerfil As e_Perfil) As e_Perfil

    <OperationContract()> _
    Function Listar(ByVal oePerfil As e_Perfil) As List(Of e_Perfil)

    <OperationContract()> _
    Function Validar(ByVal oePerfil As e_Perfil) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oePerfil As e_Perfil) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oePerfil As e_Perfil) As Boolean

End Interface
