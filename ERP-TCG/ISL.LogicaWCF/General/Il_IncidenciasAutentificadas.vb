Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_IncidenciasAutentificadas", también debe actualizar la referencia a "Il_IncidenciasAutentificadas" en Web.config.
<ServiceContract()> _
Public Interface Il_IncidenciasAutentificadas

    '<OperationContract()> _
    'Sub DoWork()

    <OperationContract()> _
    Function Obtener(ByVal oeIncedenciasAutentificadas As e_IncidenciasAutentificadas) As e_IncidenciasAutentificadas

    <OperationContract()> _
    Function Listar(ByVal oeIncidenciasAutentificadas As e_IncidenciasAutentificadas) As List(Of e_IncidenciasAutentificadas)

    <OperationContract()> _
    Function Guardar(ByVal oeIncidenciasAutentificadas As e_IncidenciasAutentificadas) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeIncidenciasAutentificadas As e_IncidenciasAutentificadas) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeIncidenciasAutentificadas As e_IncidenciasAutentificadas) As Boolean

End Interface
