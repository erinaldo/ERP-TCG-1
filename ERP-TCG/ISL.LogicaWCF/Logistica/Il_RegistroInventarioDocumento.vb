Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_RegistroInventarioDocumento", también debe actualizar la referencia a "Il_RegistroInventarioDocumento" en Web.config.
<ServiceContract()> _
Public Interface Il_RegistroInventarioDocumento

    <OperationContract()> _
    Function Afectar_RegistroInv_Documento(ByRef oeMovimientoDoc As e_MovimientoDocumento, Optional ByVal lsIdDocumento As String = "") As Boolean

    <OperationContract()> _
    Function Afectar_RegistroInv_NotaCredito(ByVal oeNotaCredito As e_MovimientoDocumento) As Boolean

    <OperationContract()> _
    Function RegenerarRegistroInv(ByVal oeNotaCredito As e_MovimientoDocumento) As Boolean

    <OperationContract()> _
    Sub CargarDocumento(ByRef oeMovimientoDocumento As e_MovimientoDocumento)

    <OperationContract()> _
    Sub CargarDetallesDocumento(ByVal oeMovimientoDocumento As e_MovimientoDocumento)

    <OperationContract()> _
    Sub CargarOrdenAsociada(ByVal oeMovimientoDocumento As e_MovimientoDocumento)

    <OperationContract()> _
    Sub CargarDocumentoAsociado(ByVal oeMovimientoDocumento As e_MovimientoDocumento)

    <OperationContract()> _
    Sub ModificaDetallesDocumento(ByRef oeMovDocAsoc As e_MovimientoDocumento, ByRef oeMovDoc As e_MovimientoDocumento)

    <OperationContract()> _
    Function f_Valida(ByVal oeOrdenMaterial As e_OrdenMaterial, ByVal oeDetalle As e_DetalleDocumento, ByVal ln_TC As Double)

    <OperationContract()> _
    Sub s_RectificaOI(ByVal oeOrden As e_Orden, ByVal oeMovimientoDoc As e_MovimientoDocumento)

    <OperationContract()> _
    Sub s_BuscaRegistroInv(ByVal ls_IdOrden As String)

    <OperationContract()> _
    Function f_LlenarOrden_Detalles(ByVal oe_Orden_Ingreso As e_Orden) As List(Of e_OrdenMaterial)

    <OperationContract()> _
    Function Guardar(ByVal lstRegistroInventarioDocumento As List(Of e_RegistroInventarioDocumento)) As Boolean

End Interface
