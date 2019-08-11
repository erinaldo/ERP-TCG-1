Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "IEntidades", también debe actualizar la referencia a "IEntidades" en Web.config.
<ServiceContract()> _
Public Interface IEntidades

    <OperationContract()> _
    Function Departamento() As e_Departamento

    <OperationContract()> _
    Function Departamentos() As List(Of e_Departamento)

End Interface
