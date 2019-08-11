Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Estado", también debe actualizar la referencia a "Il_Estado" en Web.config.
<ServiceContract()> _
Public Interface Il_Estado

    <OperationContract()> _
    Function Listar(ByVal oeEstado As e_Estado) As List(Of e_Estado)

    <OperationContract()> _
    Function ComboGrilla(ByVal Lista As List(Of e_Estado))
End Interface
