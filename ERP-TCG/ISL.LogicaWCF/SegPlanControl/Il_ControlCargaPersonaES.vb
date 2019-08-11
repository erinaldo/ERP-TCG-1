Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ControlCargaPersonaES", también debe actualizar la referencia a "Il_ControlCargaPersonaES" en Web.config.
<ServiceContract()> _
Public Interface Il_ControlCargaPersonaES

    <OperationContract()> _
    Function Obtener(ByVal oeControlCargaPersonaES As e_ControlCargaPersonaES) As e_ControlCargaPersonaES

    <OperationContract()> _
    Function Listar(ByVal oeControlCargaPersonaES As e_ControlCargaPersonaES) As List(Of e_ControlCargaPersonaES)

    <OperationContract()> _
    Function Validar(ByVal oeControlCargaPersonaES As e_ControlCargaPersonaES) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeControlCargaPersonaES As e_ControlCargaPersonaES) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeControlCargaPersonaES As e_ControlCargaPersonaES) As Boolean

End Interface
