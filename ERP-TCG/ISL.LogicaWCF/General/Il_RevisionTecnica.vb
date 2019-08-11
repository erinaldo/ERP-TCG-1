Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_RevisionTecnica", también debe actualizar la referencia a "Il_BonificacionVehiculo" en Web.config.
<ServiceContract()> _
Public Interface Il_RevisionTecnica

    <OperationContract()> _
     Function Listar(ByVal oeRevisionTecnica As e_RevisionTecnica) As List(Of e_RevisionTecnica)

    <OperationContract()> _
     Function Validar(ByVal oeRevisionTecnica As e_RevisionTecnica) As Boolean

    <OperationContract()> _
     Function Guardar(ByVal oeRevisionTecnica As e_RevisionTecnica) As Boolean

End Interface
