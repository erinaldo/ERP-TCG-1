Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Grupo_Asiento", también debe actualizar la referencia a "Il_Grupo_Asiento" en Web.config.
<ServiceContract()> _
Public Interface Il_Grupo_Asiento

    <OperationContract()> _
    Function Obtener(ByVal oeGrupo_Asiento As e_Grupo_Asiento) As e_Grupo_Asiento

    <OperationContract()> _
    Function GuardarAsiento(ByVal oeGrupo_Asiento As e_Grupo_Asiento, ByVal oeAsiento As e_Asiento) As Boolean

    <OperationContract()> _
    Function ValidarLista(ByVal leGrupo_Asiento As List(Of e_Grupo_Asiento), ByVal ldFechaOperacion As Date) As Boolean

    <OperationContract()> _
    Function GuardarLista(ByVal loGrupoAsiento As List(Of e_Grupo_Asiento), ByVal obj As Object) As String

End Interface
