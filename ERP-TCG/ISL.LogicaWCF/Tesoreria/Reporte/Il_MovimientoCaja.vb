Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_MovimientoCaja", también debe actualizar la referencia a "Il_MovimientoCaja" en Web.config.
<ServiceContract()> _
Public Interface Il_MovimientoCaja

    <OperationContract()> _
    Function Obtener(ByVal oeMovimientoCaja As e_MovimientoCaja) As e_MovimientoCaja

    <OperationContract()> _
    Function Listar(ByVal oeMovimientoCaja As e_MovimientoCaja) As List(Of e_MovimientoCaja)

End Interface
