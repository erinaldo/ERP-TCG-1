Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ControlPersonaES", también debe actualizar la referencia a "Il_ControlPersonaES" en Web.config.
<ServiceContract()> _
Public Interface Il_ControlPersonaES

    <OperationContract()> _
    Function Obtener(ByVal oeControlPersonaES As e_ControlPersonaES) As e_ControlPersonaES

    <OperationContract()> _
    Function Listar(ByVal oeControlPersonaES As e_ControlPersonaES) As List(Of e_ControlPersonaES)

    <OperationContract()> _
    Function Validar(ByVal oeControlPersonaES As e_ControlPersonaES) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeControlPersonaES As e_ControlPersonaES) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeControlPersonaES As e_ControlPersonaES) As Boolean

End Interface
