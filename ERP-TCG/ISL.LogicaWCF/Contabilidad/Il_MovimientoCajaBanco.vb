Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_MovimientoCajaBanco", también debe actualizar la referencia a "Il_MovimientoCajaBanco" en Web.config.
<ServiceContract()> _
Public Interface Il_MovimientoCajaBanco

    <OperationContract()> _
    Function CrearDT() As Data.DataTable

    <OperationContract()> _
    Function Obtener(ByVal oeMovimientoCajaBanco As e_MovimientoCajaBanco) As e_MovimientoCajaBanco

    <OperationContract()> _
    Function Listar(ByVal oeMovimientoCajaBanco As e_MovimientoCajaBanco) As List(Of e_MovimientoCajaBanco)

    <OperationContract()> _
    Function Validar(ByVal oeMovimientoCajaBanco As e_MovimientoCajaBanco) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeMovimientoCajaBanco As e_MovimientoCajaBanco) As Boolean

    <OperationContract()> _
    Function ValidarTransferencia(ByVal oeMovimientoCajaBanco As e_MovimientoCajaBanco) As Boolean

    <OperationContract()> _
    Function GuardarTranferencia(ByRef oeMovimientoCajaBancoOrigen As e_MovimientoCajaBanco, _
                                        ByVal oeMovimientoCajaBancoDestino As e_MovimientoCajaBanco, _
                                        ByVal oeAsiento As e_Asiento, ByVal IndicaReposicion As Boolean, _
                                        Optional ByVal TipoTransf As String = "") As Boolean

    <OperationContract()> _
    Function GuardarTransBancaria(ByVal oeMovCajaBanco As e_MovimientoCajaBanco, _
                                  ByVal oeAsientoModel As e_AsientoModelo, _
                                  ByVal lePrestamo As List(Of e_Prestamo), _
                                  ByVal IndDscto As Boolean) As Boolean

    <OperationContract()> _
    Function GuardarTransBancaria2(ByVal oeMovCajaBanco As e_MovimientoCajaBanco, _
                                  ByVal oeAsientoModel As e_AsientoModelo, _
                                  ByVal leAnalisis As List(Of e_Prestamo), _
                                  ByVal leDscto As List(Of e_Prestamo), _
                                  ByVal leCuota As List(Of e_PrestamoDetalle)) As Boolean

    <OperationContract()> _
    Function GuardarConciliacion(ByVal oeMovimientoCajaBanco As e_MovimientoCajaBanco) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMovimientoCajaBanco As e_MovimientoCajaBanco) As Boolean

End Interface
