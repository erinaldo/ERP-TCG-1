Imports System.ServiceModel
Imports ISL.EntidadesWCF



' NOTA: si cambia aquí el nombre de clase "Ie_Departamento", también debe actualizar la referencia a "Ie_Departamento" en Web.config.
<ServiceContract()> _
Public Interface Ie_Departamento

    <OperationContract()> _
    Function Obtener(ByVal departamento As e_Departamento) As e_Departamento

End Interface


