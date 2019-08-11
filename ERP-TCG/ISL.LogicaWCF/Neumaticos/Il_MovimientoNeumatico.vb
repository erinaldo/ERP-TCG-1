Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_MovimientoNeumatico", también debe actualizar la referencia a "Il_MovimientoNeumatico" en Web.config.
<ServiceContract()> _
Public Interface Il_MovimientoNeumatico

    <OperationContract()> _
    Function Obtener(ByVal oeVidaNeumatico_Motivo As e_MovimientoNeumatico) As e_MovimientoNeumatico

    <OperationContract()> _
    Function Listar(ByVal oeMovimientoNeumatico As e_MovimientoNeumatico) As List(Of e_MovimientoNeumatico)

    <OperationContract()> _
    Function Validar(ByVal oeMovimientoNeumatico As e_MovimientoNeumatico) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeMovimientoNeumatico As e_MovimientoNeumatico) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMovimientoNeumatico As e_MovimientoNeumatico) As Boolean

End Interface
