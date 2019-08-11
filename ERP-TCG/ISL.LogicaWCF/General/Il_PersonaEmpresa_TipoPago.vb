Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_PersonaEmpresa_TipoPago", también debe actualizar la referencia a "Il_PersonaEmpresa_TipoPago" en Web.config.
<ServiceContract()> _
Public Interface Il_PersonaEmpresa_TipoPago

    <OperationContract()> _
    Function Obtener(ByVal oePersonaEmpresa_TipoPago As e_PersonaEmpresa_TipoPago) As e_PersonaEmpresa_TipoPago

    <OperationContract()> _
    Function Listar(ByVal oePersonaEmpresa_TipoPago As e_PersonaEmpresa_TipoPago) As List(Of e_PersonaEmpresa_TipoPago)

    <OperationContract()> _
    Function Validar(ByVal oePersonaEmpresa_TipoPago As e_PersonaEmpresa_TipoPago) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oePersonaEmpresa_TipoPago As e_PersonaEmpresa_TipoPago) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oePersonaEmpresa_TipoPago As e_PersonaEmpresa_TipoPago) As Boolean

End Interface
