Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_GastoOperacion", también debe actualizar la referencia a "Il_GastoOperacion" en Web.config.
<ServiceContract()> _
Public Interface Il_GastoOperacion

    Function GuardarGasto(oeGastoOperacion As e_GastoOperacion) As Boolean

    <OperationContract()> _
    Function Obtener(ByVal oeGastoOperacion As e_GastoOperacion) As e_GastoOperacion

    <OperationContract()> _
    Function Listar(ByVal oeGastoOperacion As e_GastoOperacion) As List(Of e_GastoOperacion)

    <OperationContract()> _
    Function Guardar(ByVal oeGastoOperacion As e_GastoOperacion) As Boolean

    <OperationContract()>
    Function GuardarListaMasiva(ByVal leGastoOperacion As List(Of e_GastoOperacion), lo As List(Of e_Combo), ByVal PrefijoID As String) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeGastoOperacion As e_GastoOperacion) As Boolean

End Interface
