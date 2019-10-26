Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_GastoViatico", también debe actualizar la referencia a "Il_GastoViatico" en Web.config.
<ServiceContract()> _
Public Interface Il_GastoViatico

    <OperationContract()> _
    Function Obtener(ByVal oeGastoViatico As e_GastoViatico) As e_GastoViatico

    <OperationContract()> _
    Function Listar(ByVal oeGastoViatico As e_GastoViatico) As List(Of e_GastoViatico)

    <OperationContract()> _
    Function Validar(ByVal oeGastoViatico As e_GastoViatico) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeGastoViatico As e_GastoViatico) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeGastoViatico As e_GastoViatico) As Boolean

End Interface
