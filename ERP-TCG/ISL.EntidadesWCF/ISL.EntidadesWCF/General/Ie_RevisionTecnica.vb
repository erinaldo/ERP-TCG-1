Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_RevisionTecnica", también debe actualizar la referencia a "Ie_RevisionTecnica" en Web.config.
<ServiceContract()> _
Public Interface Ie_RevisionTecnica

    <OperationContract()> _
    Function Obtener(ByVal RevisionTecnica As e_RevisionTecnica) As e_RevisionTecnica

End Interface
