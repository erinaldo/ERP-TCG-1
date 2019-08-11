Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_MenuGrupo", también debe actualizar la referencia a "Il_MenuGrupo" en Web.config.
<ServiceContract()> _
Public Interface Il_MenuGrupo

    <OperationContract()> _
    Function Obtener(ByVal oeMenuGrupo As e_MenuGrupo) As e_MenuGrupo

    <OperationContract()> _
    Function Listar(ByVal oeMenuGrupo As e_MenuGrupo) As List(Of e_MenuGrupo)

    <OperationContract()> _
    Function Validar(ByVal oeMenuGrupo As e_MenuGrupo) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeMenuGrupo As e_MenuGrupo) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMenuGrupo As e_MenuGrupo) As Boolean

End Interface
