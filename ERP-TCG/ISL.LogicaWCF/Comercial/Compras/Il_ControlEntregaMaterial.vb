Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ControlEntregaMaterial", también debe actualizar la referencia a "Il_ControlEntregaMaterial" en Web.config.
<ServiceContract()> _
Public Interface Il_ControlEntregaMaterial

    <OperationContract()> _
     Function Obtener(ByVal oeControlEntregaMaterial As e_ControlEntregaMaterial) As e_ControlEntregaMaterial

    <OperationContract()> _
    Function Listar(ByVal oeControlEntregaMaterial As e_ControlEntregaMaterial) As List(Of e_ControlEntregaMaterial)

    <OperationContract()> _
    Function Validar(ByVal oeControlEntregaMaterial As e_ControlEntregaMaterial) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeControlEntregaMaterial As e_ControlEntregaMaterial) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeControlEntregaMaterial As e_ControlEntregaMaterial) As Boolean

End Interface
