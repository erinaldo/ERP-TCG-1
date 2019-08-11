Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_RegistroConformidadOT", también debe actualizar la referencia a "Il_RegistroConformidadOT" en Web.config.
<ServiceContract()> _
Public Interface Il_RegistroConformidadOT

    <OperationContract()> _
    Function Obtener(ByVal oeRegistroConformidadOT As e_RegistroConformidadOT) As e_RegistroConformidadOT

    <OperationContract()> _
    Function Listar(ByVal oeRegistroConformidadOT As e_RegistroConformidadOT) As List(Of e_RegistroConformidadOT)

    <OperationContract()> _
    Function Validar(ByVal oeRegistroConformidadOT As e_RegistroConformidadOT) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeRegistroConformidadOT As e_RegistroConformidadOT) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeRegistroConformidadOT As e_RegistroConformidadOT) As Boolean

End Interface
