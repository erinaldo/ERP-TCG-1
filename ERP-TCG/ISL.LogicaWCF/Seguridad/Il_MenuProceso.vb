Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_MenuProceso", también debe actualizar la referencia a "Il_MenuProceso" en Web.config.
<ServiceContract()> _
Public Interface Il_MenuProceso

    <OperationContract()> _
    Function Obtener(ByVal oeProceso As e_MenuProceso) As e_MenuProceso

    <OperationContract()> _
    Function Listar(ByVal oeProceso As e_MenuProceso) As List(Of e_MenuProceso)

    <OperationContract()> _
    Function ListarMenu(ByVal idUsuario As String) As List(Of e_MenuProceso)

    <OperationContract()> _
    Function Validar(ByVal oeProceso As e_MenuProceso) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeProceso As e_MenuProceso) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeProceso As e_MenuProceso) As Boolean

End Interface
