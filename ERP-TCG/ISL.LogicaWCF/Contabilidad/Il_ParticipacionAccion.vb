Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ParticipacionAccion", también debe actualizar la referencia a "Il_ParticipacionAccion" en Web.config.
<ServiceContract()> _
Public Interface Il_ParticipacionAccion
    Function Guardar(ByVal oeParticipacionAccion As e_ParticipacionAccion) As Boolean
    Function Listar(ByVal oeParticipacionAccion As e_ParticipacionAccion) As List(Of e_ParticipacionAccion)

End Interface
