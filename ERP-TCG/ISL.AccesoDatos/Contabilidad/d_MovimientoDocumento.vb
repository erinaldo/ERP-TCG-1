'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Text

Public Class d_MovimientoDocumento

    Private sqlhelper As New SqlHelper

    Dim odDetDocComb As New d_DetalleDocumentoCombustible
    Dim odDetDoc As New d_DetalleDocumento
    Dim odDetDocGT As New d_DetalleDoc_GuiaTrans
    Dim odGuiaTransportista As New d_GuiaTransportista
    Dim odOperacionDet As New d_Operacion
    Dim odOrdDoc As New d_Orden_Documento
    Dim odCompra As New d_Compra
    Dim odVenta As New d_Venta
    Dim odDocAso As New d_DocumentoAsociado
    Dim odAsiento As New d_Asiento

    Dim oeAuditoria As New e_Auditoria
    Dim odAuditoria As New d_Auditoria
    Public connectionString As String = d_Conexion.CadenaConexionSGI()

    Public Function EstadoCuenta(ByVal IdClienteProveedor As String, ByVal cliente As Integer) As DataTable
        Try
            Dim ldMovimientoDocumento As New List(Of e_MovimientoDocumento)
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_EstadoCuenta", IdClienteProveedor, cliente)
            Return ds.Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function RegistroVenta(ByVal IdPeriodo As String) As DataTable
        Try
            Dim ldMovimientoDocumento As New List(Of e_MovimientoDocumento)
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_RegistroVentas_Listar", IdPeriodo)
            Return ds.Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function RegistroCompra(ByVal IdPeriodo As String) As DataTable
        Try
            Dim ldMovimientoDocumento As New List(Of e_MovimientoDocumento)
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_RegistroCompra_Listar", IdPeriodo)
            Return ds.Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarCtasXCobrar(ByVal IdClienteProveedor As String, ByVal FechaHasta As Date) As DataTable
        Try
            Dim ldMovimientoDocumento As New List(Of e_MovimientoDocumento)
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.ISP_ReporteCuentasXCobrar", IdClienteProveedor, FechaHasta)
            Return ds.Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Function ListarCtasXPagar(ByVal IdClienteProveedor As String, ByVal IndBancos As Boolean, IdEstado As String, IndDeuda As Boolean, IdMoneda As String) As DataTable
        Try
            Dim ldMovimientoDocumento As New List(Of e_MovimientoDocumento)
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.ISP_ReporteCuentasXPagar", IdClienteProveedor, IndBancos, IdEstado, IndDeuda, IdMoneda)
            Return ds.Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Cargar(ByVal o_fila As DataRow) As e_MovimientoDocumento
        Try
            Dim oeMovimientoDocumento = New e_MovimientoDocumento( _
                         o_fila("Id").ToString, o_fila("IdTipoDocumento").ToString _
                        , o_fila("NombreDocumento").ToString, o_fila("Serie").ToString _
                        , o_fila("Numero").ToString, o_fila("FechaEmision").ToString _
                        , o_fila("FechaVencimiento").ToString, o_fila("IGV") _
                        , o_fila("SubTotal"), o_fila("Total") _
                        , o_fila("Saldo"), o_fila("IdClienteProveedor").ToString _
                        , o_fila("NombreClienteProveedor").ToString, o_fila("IdMoneda").ToString _
                        , o_fila("AbreviaturaMoneda").ToString, o_fila("IdPeriodo").ToString _
                        , o_fila("IndCompraVenta").ToString, o_fila("TipoCambio") _
                        , o_fila("Activo").ToString, o_fila("UsuarioCreacion").ToString _
                        , o_fila("FechaCreacion"), o_fila("SaldoDetraccion") _
                        , o_fila("IdCuentaContable").ToString, o_fila("Moneda").ToString _
                        , o_fila("IdEstadoDocumento").ToString, o_fila("EstadoDocumento").ToString _
                        , o_fila("IdTipoPago").ToString, o_fila("TipoPago").ToString _
                        , o_fila("ClienteProveedor").ToString, o_fila("IdCompra").ToString _
                        , o_fila("AbrevTipoDoc").ToString, o_fila("IndServicioMaterial").ToString _
                        , o_fila("PercepcionPorc"), o_fila("Percepcion") _
                        , o_fila("DetraccionPorc"), o_fila("Detraccion") _
                        , o_fila("Glosa").ToString, o_fila("ImpRenta"), _
                        o_fila("Operador"), o_fila("Mes"), o_fila("CobraCajaChica"), o_fila("IdMotivoDocumento"), _
                        o_fila("IndDetraccion"))

            oeMovimientoDocumento.IndElectronico = o_fila("IndElectronico").ToString
            oeMovimientoDocumento.IdTipoBien = IIf(o_fila("IdTipoBien").ToString.Trim = "", "0", o_fila("IdTipoBien").ToString.Trim)
            oeMovimientoDocumento.OrdenCompra = o_fila("OrdenCompra").ToString
            oeMovimientoDocumento.IndAnexo = o_fila("IndAnexo").ToString
            oeMovimientoDocumento.EstadoSunat = o_fila("EstadoElectronico").ToString
            oeMovimientoDocumento.IndDetalleGlosa = o_fila("IndAfectoIVA").ToString
            oeMovimientoDocumento.Retencion_Letra = o_fila("Retencion_Letra").ToString
            oeMovimientoDocumento.Retencion_Saldo = o_fila("Retencion_Saldo").ToString
            oeMovimientoDocumento.IndAnticipo = o_fila("IndAnticipo").ToString
            oeMovimientoDocumento.IndAfectaAnticipo = o_fila("IndAfectaAnticipo").ToString
            oeMovimientoDocumento.Monto_Anticipo = o_fila("Monto_Anticipo").ToString
            'oeMovimientoDocumento.CodMotivo = o_fila("CodMotivo").ToString

            Return oeMovimientoDocumento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    '    Public Function Cargar2(ByVal o_fila As DataRow) As e_MovimientoDocumento
    '        Try
    '            Dim oeMovimientoDocumento = New e_MovimientoDocumento( _
    'o_fila("Id").ToString, o_fila("IdTipoDocumento").ToString, o_fila("NombreDocumento").ToString, o_fila("Serie").ToString _
    ', o_fila("Numero").ToString, o_fila("FechaEmision").ToString, o_fila("FechaVencimiento").ToString, o_fila("IGV") _
    ', o_fila("SubTotal"), o_fila("Total"), o_fila("Saldo"), o_fila("IdClienteProveedor").ToString _
    ', o_fila("NombreClienteProveedor").ToString, o_fila("IdMoneda").ToString, o_fila("AbreviaturaMoneda").ToString, o_fila("IdPeriodo").ToString _
    ', o_fila("IndCompraVenta").ToString, o_fila("TipoCambio"), o_fila("Activo").ToString, o_fila("UsuarioCreacion").ToString _
    ', o_fila("FechaCreacion"), o_fila("SaldoDetraccion").ToString, o_fila("IdCuentaContable").ToString, o_fila("Moneda").ToString _
    ', o_fila("IdEstadoDocumento").ToString, o_fila("EstadoDocumento").ToString, o_fila("IdTipoPago").ToString, o_fila("TipoPago").ToString _
    ', o_fila("ClienteProveedor").ToString, o_fila("IdCompra").ToString, o_fila("AbrevTipoDoc").ToString, o_fila("IndServicioMaterial").ToString _
    ', o_fila("PercepcionPorc").ToString, o_fila("Percepcion").ToString, o_fila("DetraccionPorc").ToString, o_fila("Detraccion").ToString _
    ', o_fila("Glosa").ToString, o_fila("ImpRenta").ToString, o_fila("Operador").ToString)
    '            Return oeMovimientoDocumento
    '        Catch ex As Exception
    '            Throw ex
    '        End Try
    '    End Function

    Public Function Obtener(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As e_MovimientoDocumento
        Try
            With oeMovimientoDocumento
                Dim ds As DataSet, ado_DatosImpresionas As New d_MovimientoDocumento_Impresion
                ds = sqlhelper.ExecuteDataset("CON.Isp_MovimientoDocumento_Listar", "", .Id)
                If ds.Tables(0).Rows.Count > 0 Then
                    oeMovimientoDocumento = Cargar(ds.Tables(0).Rows(0))
                    oeMovimientoDocumento.DatosImpresion = ado_DatosImpresionas.Obtener(New e_MovimientoDocumento_Impresion With {.TipoOperacion = "SEL", .IdMovimientoDocumento = oeMovimientoDocumento.Id})
                End If
                Return oeMovimientoDocumento
            End With
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function dt_DocumentoCtble_Impresion(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As DataTable
        Try
            Dim DT As New DataTable, DS As New DataSet
            With oeMovimientoDocumento
                DS = sqlhelper.ExecuteDataset("CON.ISP_DocumentoCtble_Imprimir", .TipoOperacion, .Id)
                If DS.Tables(0).Rows.Count > 0 Then
                    DT = DS.Tables(0)
                End If
            End With
            Return DT
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener2(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As e_MovimientoDocumento
        Try
            With oeMovimientoDocumento
                Dim ds As DataSet
                ds = sqlhelper.ExecuteDataset("CON.Isp_MovimientoDocumento_Listar", .TipoOperacion, .Id)
                oeMovimientoDocumento = New e_MovimientoDocumento
                If ds.Tables(0).Rows.Count > 0 Then
                    oeMovimientoDocumento = Cargar(ds.Tables(0).Rows(0))
                End If
                Return oeMovimientoDocumento
            End With
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ObtenerDocumentosPorCompras(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As e_MovimientoDocumento

        Try
            With oeMovimientoDocumento
                Dim ds As DataSet
                ds = sqlhelper.ExecuteDataset("CON.Isp_MovimientoDocumento_Listar", .TipoOperacion, .Id, _
                                              .IdTipoDocumento, .Serie, .Numero, "01/01/1901", "01/01/1901", 0, 0, .IdClienteProveedor, 1)
                If ds.Tables(0).Rows.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                    oeMovimientoDocumento = Cargar(ds.Tables(0).Rows(0))
                End If
                Return oeMovimientoDocumento
            End With
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ObtenerVenta(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As e_MovimientoDocumento
        Try
            Dim ds As DataSet
            Dim IndFull As Boolean = oeMovimientoDocumento.CargarCompleto
            With oeMovimientoDocumento
                ds = sqlhelper.ExecuteDataset("CON.Isp_MovimientoDocumento_Listar", "" _
                            , .Id _
                            , .IdTipoDocumento _
                            , .Serie _
                            , .Numero _
                            , #1/1/1901# _
                            , #1/1/1901# _
                            , 0 _
                            , 0 _
                            , "" _
                            , 1 _
                            , .IndCompraVenta)
            End With

            If ds.Tables(0).Rows.Count > 0 Then
                oeMovimientoDocumento = Cargar(ds.Tables(0).Rows(0))
                With oeMovimientoDocumento
                    Dim oeVenta As New e_Venta
                    Dim odVenta As New d_Venta
                    oeVenta.IdMovimientoDocumento = .Id
                    .Venta = odVenta.ObtenerConIdDocumento(oeVenta)
                    If .Venta.Id = "" Then
                        Throw New Exception("NO EXISTE VENTA!")
                    End If
                    If .IndServicioMaterial = "M" Then
                        Dim oeDetalleDoc As New e_DetalleDoc_OperacionDet
                        Dim odDetalleDoc As New d_Operacion
                        oeDetalleDoc.TipoOperacion = "1"
                        oeDetalleDoc.IdMovimientoDocumento = .Id
                        .leDetalleDocOperDet = odDetalleDoc.ListarOperacionDetalleDS(oeDetalleDoc)
                        If IndFull Then
                            Dim oeGRT As New e_GuiaTransportista
                            Dim odGRT As New d_GuiaTransportista
                            oeGRT.TipoOperacion = "T"
                            oeGRT.IdOperacion = ""
                            oeGRT.IdMovimientoDoc = .Id
                            .leGRT = odGRT.ListarDS(oeGRT)

                            Dim oeGRr As New e_GuiaRemitente
                            Dim odGRr As New d_GuiaRemitente
                            oeGRr.TipoOperacion = "R"
                            oeGRr.IdOperacion = ""
                            oeGRr.IdMovimientoDoc = .Id
                            .leGRR = odGRr.ListarDS(oeGRr)
                        End If
                    End If
                    Dim oeDet As New e_DetalleDocumento
                    oeDet.IdMovimientoDocumento = oeMovimientoDocumento.Id
                    oeDet.TipoOperacion = "VEN"
                    oeDet.IndServicioMaterial = IIf(.IndServicioMaterial = "M", "I", .IndServicioMaterial)
                    .lstDetalleDocumento = odDetDoc.Listar(oeDet)
                End With
            End If
            Return oeMovimientoDocumento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerAJusteTipoCambio(ByVal TipoOperacion As String, ByVal IdMovimientoDocumento As String, _
                                            ByVal IdPeriodo As String, ByVal lnEjercicio As Integer) As DataSet
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_AjusteTipoCambio_Listar", TipoOperacion, IdMovimientoDocumento, IdPeriodo, lnEjercicio)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarVerificacionAsiento(ByVal oeMovDoc As e_MovimientoDocumento) As DataSet
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_MovimientoDocumento_Listar", oeMovDoc.TipoOperacion, oeMovDoc.Id)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerCompra(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As e_MovimientoDocumento

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_MovimientoDocumento_Listar", "", oeMovimientoDocumento.Id)

            If ds.Tables(0).Rows.Count > 0 Then
                oeMovimientoDocumento = Cargar(ds.Tables(0).Rows(0))
                Dim oeCompra As New e_Compra
                Dim odCompra As New d_Compra
                oeCompra.IdMovimientoDocumento = oeMovimientoDocumento.Id
                oeMovimientoDocumento.Compra = odCompra.Obtener(oeCompra)
                If oeMovimientoDocumento.Compra.Id = "" Then
                    Throw New Exception("NO EXISTE COMPRA!")
                End If
                '---------traigo relacion asiento_movimiento--------------------
                Dim oeAsMov_MovDoc As New e_AsientoMov_MovDoc
                Dim odAsMov_MovDoc As New d_AsientoMov_MovDoc
                Dim leAsMov_MovDoc As New List(Of e_AsientoMov_MovDoc)

                oeAsMov_MovDoc.IdMovimientoDocumento = oeMovimientoDocumento.Id
                leAsMov_MovDoc.AddRange(odAsMov_MovDoc.Listar(oeAsMov_MovDoc))
                '---------------------------------------------------------------
                '-------------traigo Asiento Movimiento-------------------------
                Dim oeAsientoMov As New e_AsientoMovimiento
                Dim odAsientoMov As New d_AsientoMovimiento
                oeAsientoMov.Id = leAsMov_MovDoc(0).IdAsientoMovimiento
                oeAsientoMov = odAsientoMov.ObtenerAsientoCompra(oeAsientoMov)
                '---------------------------------------------------------------
                '--------------------asigno movimiento--------------------------
                Dim odMovAnalisis As New d_MovimientoAnalisis
                oeMovimientoDocumento.MovimientoAnalisis = New List(Of e_MovimientoAnalisis)
                oeMovimientoDocumento.MovimientoAnalisis.AddRange(odMovAnalisis.ListarAnalisisCompra(oeAsientoMov.IdAsiento))
                '----------------------------------------------------------------
            End If
            Return oeMovimientoDocumento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerCantDoc(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As e_MovimientoDocumento
        Try
            With oeMovimientoDocumento
                Dim ds As DataSet
                ds = sqlhelper.ExecuteDataset("CON.Isp_MovimientoDocumento_Listar", _
                                              .TipoOperacion, _
                                              .Id, _
                                              .IdTipoDocumento, _
                                              .Serie, _
                                              .Numero, _
                                              .FechaEmision, _
                                              .FechaVencimiento, _
                                              .Total, _
                                              .Saldo, _
                                              .IdClienteProveedor)

                If ds.Tables(0).Rows.Count > 0 Then
                    oeMovimientoDocumento = Cargar(ds.Tables(0).Rows(0))
                End If

                Return oeMovimientoDocumento
            End With
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As List(Of e_MovimientoDocumento)
        Try
            Dim ldMovimientoDocumento As New List(Of e_MovimientoDocumento)
            Dim ds As DataSet
            With oeMovimientoDocumento
                ds = sqlhelper.ExecuteDataset("CON.Isp_MovimientoDocumento_Listar", _
                                              .TipoOperacion _
                                                , .Id _
                                                , .IdTipoDocumento _
                                                , .Serie _
                                                , .Numero _
                                                , .FechaEmision _
                                                , .FechaVencimiento _
                                                , .Total _
                                                , .Saldo _
                                                , .IdClienteProveedor _
                                                , .Activo _
                                                , .IndCompraVenta _
                                                , .IdPeriodo _
                                                , .IdMoneda _
                                                , .TipoCambio _
                                                , .IdUsuarioCrea _
                                                , .Ejercicio _
                                                , .IndServicioMaterial _
                                                , .FechaInicio _
                                                , .FechaFinal _
                                                , .IdEstadoDocumento _
                                                , ._Operador _
                                                , .NombreDocumento _
                                                , .Documentos)
                oeMovimientoDocumento = Nothing
                If ds.Tables.Count > 0 Then
                    For Each o_Fila As DataRow In ds.Tables(0).Rows
                        oeMovimientoDocumento = Cargar(o_Fila)
                        ldMovimientoDocumento.Add(oeMovimientoDocumento)
                    Next
                End If
            End With
            Return ldMovimientoDocumento
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarDetallesPorDocumentos(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As List(Of e_Material)
        Try
            Dim lstMateriales As New List(Of e_Material)
            Dim ds As DataSet
            With oeMovimientoDocumento
                ds = sqlhelper.ExecuteDataset("[CON].[Isp_DetalleDocumento_Listar]", .TipoOperacion, "", .Id)
                If ds.Tables.Count > 0 Then
                    For Each o_Fila As DataRow In ds.Tables(0).Rows
                        Dim oeMaterial As New e_Material, odMaterial As New d_Material
                        oeMaterial = odMaterial.Cargar_Detalle(o_Fila)
                        lstMateriales.Add(oeMaterial)
                    Next
                End If
            End With
            Return lstMateriales
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarDocumentosPorCompras(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As List(Of e_MovimientoDocumento)
        Try
            Dim ldMovimientoDocumento As New List(Of e_MovimientoDocumento)
            Dim ds As DataSet
            With oeMovimientoDocumento
                ds = sqlhelper.ExecuteDataset("CON.Isp_MovimientoDocumento_Listar", .TipoOperacion _
                        , .Id _
                        , .IdTipoDocumento _
                        , .Serie _
                        , .Numero _
                        , .FechaEmision _
                        , .FechaVencimiento _
                        , .Total _
                        , .Saldo _
                        , .IdClienteProveedor _
                        , .Activo _
                        , .IndCompraVenta _
                        , .IdPeriodo _
                        , .IdMoneda _
                        , .TipoCambio _
                        , .IdUsuarioCrea _
                        , .Ejercicio _
                        , .IndServicioMaterial _
                        , .FechaInicio _
                        , .FechaFinal _
                        , .IdEstadoDocumento
                        )
                If ds.Tables.Count > 0 Then
                    For Each o_Fila As DataRow In ds.Tables(0).Rows
                        oeMovimientoDocumento = Cargar(o_Fila)
                        ldMovimientoDocumento.Add(oeMovimientoDocumento)
                    Next
                End If
            End With
            Return ldMovimientoDocumento
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarFlujoCajaIsl(ByVal fechaInic As Date, ByVal FechaFin As Date) As DataTable
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("FIN.Isp_ReporteFlujoCajaISL", fechaInic, FechaFin)
            Return ds.Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ObtienerNumDoc(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As e_MovimientoDocumento
        Try
            With oeMovimientoDocumento
                Dim ds As DataSet
                ds = sqlhelper.ExecuteDataset("CON.Isp_MovimientoDocumento_Listar", .TipoOperacion, .Id, .IdTipoDocumento, .Serie)
                If ds.Tables(0).Rows.Count > 0 Then
                    oeMovimientoDocumento = Cargar(ds.Tables(0).Rows(0))
                End If
                Return oeMovimientoDocumento
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeMovimientoDocumento As e_MovimientoDocumento, Optional oeAnticipo As e_MovimientoDocumento = Nothing, Optional ByVal UsaTransaccion As Boolean = True) As e_MovimientoDocumento
        Try
            If oeAnticipo IsNot Nothing Then
                oeAnticipo.PrefijoID = oeMovimientoDocumento.PrefijoID '@0001
            End If
            If UsaTransaccion Then
                Using transScope As New TransactionScope
                    oeMovimientoDocumento = GuardarDocumento(oeMovimientoDocumento, oeAnticipo)
                    transScope.Complete()
                End Using
            Else
                oeMovimientoDocumento = GuardarDocumento(oeMovimientoDocumento, oeAnticipo)
            End If
            Return oeMovimientoDocumento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Public Function Guardar_MovimientoDocumento(Documento As e_MovimientoDocumento) As e_MovimientoDocumento

    'End Function

    Public Function CambiaPeriodoVerifica(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean
        Try
            With oeMovimientoDocumento
                sqlhelper.ExecuteNonQuery("CON.Isp_MovimientoDocumento_IAE", .TipoOperacion, _
                        .PrefijoID, _
                        .Id _
                        , .IdTipoDocumento _
                        , .Serie _
                        , .Numero _
                        , .FechaEmision _
                        , .FechaVencimiento _
                        , .SubTotal _
                        , .IGV _
                        , .Total _
                        , Math.Abs(.Saldo) _
                        , .IdClienteProveedor _
                        , .Activo _
                        , .IndCompraVenta _
                        , .IdPeriodo _
                        , .IdMoneda _
                        , .TipoCambio _
                        , .IdUsuarioCrea _
                        , .IdCuentaContable _
                        , .IdEstadoDocumento _
                        , ._Operador _
                        , .Mac_PC_Local _
                        , .EstadoDocumento _
                        , .IndServicioMaterial _
                        ).ToString.Split("_")
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Private Function GuardarDocumento(ByVal oeMovimientoDocumento As e_MovimientoDocumento, Optional oeAnticipo As e_MovimientoDocumento = Nothing) As e_MovimientoDocumento
        Try
            Dim stResultado() As String
            Dim stResultado_Ant() As String
            With oeMovimientoDocumento
                stResultado = sqlhelper.ExecuteScalar("CON.Isp_MovimientoDocumento_IAE", .TipoOperacion,
                        .PrefijoID,
                        .Id _
                        , .IdTipoDocumento _
                        , .Serie _
                        , .Numero _
                        , .FechaEmision _
                        , .FechaVencimiento _
                        , .SubTotal _
                        , .IGV _
                        , .Total _
                        , Math.Abs(.Saldo) _
                        , .IdClienteProveedor _
                        , .Activo _
                        , .IndCompraVenta _
                        , .IdPeriodo _
                        , .IdMoneda _
                        , .TipoCambio _
                        , .IdUsuarioCrea _
                        , .IdCuentaContable _
                        , .IdEstadoDocumento _
                        , ._Operador _
                        , .Mac_PC_Local _
                        , .EstadoDocumento _
                        , .IndServicioMaterial _
                        , .Glosa _
                        , .IdLiquidacion _
                        , .IndElectronico _
                        , .IdTipoBien _
                        , .OrdenCompra _
                        , IIf(.IndAnexo, 1, 0) _
                        , .CodMotivo _
                        , IIf(.IndDetalleGlosa, 1, 0) _
                        , .Retencion _
                        , .IndAnticipo _
                        , .IndAfectaAnticipo _
                        , .Monto_Anticipo).ToString.Split("_")
                .Id = stResultado(0)
                If .leCuotaDocVehMovimiento.Count > 0 Then
                    Dim odCuotaMovimiento As New d_CuotaDocVeh_Movimiento
                    For Each obj In .leCuotaDocVehMovimiento
                        obj.IdMovimientoDocumento = .Id
                        obj.PrefijoID = oeMovimientoDocumento.PrefijoID '@0001
                        odCuotaMovimiento.GuardarCancelacion(obj)
                    Next
                End If
                '' =========================================================================== 
                '' Datos de Impresion
                If .TipoOperacion = "I" Then
                    Dim ado_DatosImpresion As New d_MovimientoDocumento_Impresion
                    .DatosImpresion.TipoOperacion = "I"
                    .DatosImpresion.IdMovimientoDocumento = stResultado(0)
                    .DatosImpresion.IdEmpresaSistema = oeMovimientoDocumento.IdEmpresaSistema
                    .DatosImpresion.PrefijoID = oeMovimientoDocumento.PrefijoID '@0001
                    ado_DatosImpresion.Guardar(.DatosImpresion)
                End If
                '' =========================================================================== 
                '' Asiento Movimiento 
                If .IdAsientoMovimiento <> "" And .TipoOperacion = "I" Then 'CUANDO INSERTO ANTICIPOS
                    Dim oeAsMovMovDoc As New e_AsientoMov_MovDoc, odAsMovMovDoc As New d_AsientoMov_MovDoc
                    oeAsMovMovDoc.IdAsientoMovimiento = .IdAsientoMovimiento
                    oeAsMovMovDoc.IdMovimientoDocumento = stResultado(0)
                    oeAsMovMovDoc.Activo = True
                    oeAsMovMovDoc.TipoOperacion = "I"
                    oeAsMovMovDoc.PrefijoID = oeMovimientoDocumento.PrefijoID '@0001
                    odAsMovMovDoc.Guardar(oeAsMovMovDoc)
                End If
                '' =========================================================================== 
                '' Cuenta por Cobrar y Pagar
                If .Id <> "" And (.TipoOperacion = "A" Or .TipoOperacion = "S") Then
                    Dim odCuentaxCyP As New d_CuentaxCyP
                    .CuentaxCyP.PrefijoID = oeMovimientoDocumento.PrefijoID '@0001
                    If Not .CuentaxCyP Is Nothing Then
                        If .CuentaxCyP.TipoOperacion = "I" Then
                            .CuentaxCyP.IdMovimientoCajaBanco = ._idMovimientoCajaBanco
                            .CuentaxCyP._IdAsientoMovimiento = .IdAsientoMovimiento
                            odCuentaxCyP.Guardar(.CuentaxCyP)
                        ElseIf .CuentaxCyP.TipoOperacion = "E" Then
                            odCuentaxCyP.Eliminar(.CuentaxCyP)
                        End If
                    End If
                End If
                '' =========================================================================== 
                '' Detalle Documento
                For Each Detalle As e_DetalleDocumento In .lstDetalleDocumento
                    Detalle.TipoOperacion = IIf(Detalle.Id <> "" And Detalle.TipoOperacion Is Nothing And .TipoOperacion = "A", "A", Detalle.TipoOperacion)
                    Detalle.PrefijoID = oeMovimientoDocumento.PrefijoID '@0001
                    If Detalle.TipoOperacion = "I" Or Detalle.TipoOperacion = "A" Then
                        Detalle.IdMovimientoDocumento = stResultado(0)
                        Detalle.UsuarioCreacion = .IdUsuarioCrea
                        odDetDoc.Guardar(Detalle)
                    ElseIf Detalle.TipoOperacion = "E" Then
                        odDetDoc.Eliminar(Detalle)
                    End If
                Next
                '' =========================================================================== 
                '' Compra y Venta
                .Compra.PrefijoID = oeMovimientoDocumento.PrefijoID '@0001
                .Venta.PrefijoID = oeMovimientoDocumento.PrefijoID '@0001
                If .IndCompraVenta = 1 Then 'Si es una factura por compras
                    .Compra.IdMovimientoDocumento = stResultado(0)
                    odCompra.Guardar(.Compra)
                ElseIf .IndCompraVenta = 2 Then 'Si es por ventas
                    .Venta.TipoOperacion = .TipoOperacion
                    .Venta.IdMovimientoDocumento = stResultado(0)
                    odVenta.Guardar(.Venta)
                End If
                '' =========================================================================== 
                '' Orden Documento
                For Each oeOD As e_Orden In .LstOrden
                    Dim oeOrden_Documento As New e_Orden_Documento, odOrden_Documento As New d_Orden_Documento
                    oeOrden_Documento.TipoOperacion = "I"
                    oeOrden_Documento.Id = ""
                    oeOrden_Documento.IdOrden = oeOD.Id
                    oeOrden_Documento.IdTipoOrden = oeOD.IdTipoOrden
                    oeOrden_Documento.IdDocumento = stResultado(0)
                    oeOrden_Documento.Activo = .Activo
                    oeOrden_Documento.UsuarioCreacion = .IdUsuarioCrea
                    oeOrden_Documento.IdTipoDocumento = .IdTipoDocumento
                    oeOrden_Documento.PrefijoID = oeMovimientoDocumento.PrefijoID '@0001
                    odOrden_Documento.Guardar(oeOrden_Documento)
                Next
                '' =========================================================================== 
                '' Orden Documento
                For Each orden_doc In .lo_OrdenDocumento
                    Dim odOrden_Documento As New d_Orden_Documento
                    orden_doc.IdDocumento = stResultado(0)
                    odOrden_Documento.Guardar(orden_doc)
                Next
                '' =========================================================================== 
                '' Documento sin Asociacion
                If Not .DocSinAsoc Is Nothing AndAlso Not .DocSinAsoc.Id Is Nothing Then
                    Dim oeDocSinAsoc As New e_DocumentoSinAsociacion, odDocSinAsoc As New d_DocumentoSinAsociacion
                    oeDocSinAsoc = .DocSinAsoc
                    oeDocSinAsoc.IdDocumento = stResultado(0)
                    oeDocSinAsoc.PrefijoID = oeMovimientoDocumento.PrefijoID '@0001
                    odDocSinAsoc.Guardar(oeDocSinAsoc)
                End If
                '' =========================================================================== 
                '' MovimientoDocumento (Anticipo)
                If Not oeAnticipo Is Nothing Then
                    oeAnticipo.PrefijoID = oeMovimientoDocumento.PrefijoID '@0001
                    If oeAnticipo.TipoOperacion = "I" Then
                        With oeAnticipo
                            stResultado_Ant = sqlhelper.ExecuteScalar("CON.Isp_MovimientoDocumento_IAE", .TipoOperacion,
                                    .PrefijoID,
                                    .Id _
                                    , .IdTipoDocumento _
                                    , .Serie _
                                    , .Numero _
                                    , .FechaEmision _
                                    , .FechaVencimiento _
                                    , .SubTotal _
                                    , .IGV _
                                    , .Total _
                                    , Math.Abs(.Saldo) _
                                    , .IdClienteProveedor _
                                    , .Activo _
                                    , .IndCompraVenta _
                                    , .IdPeriodo _
                                    , .IdMoneda _
                                    , .TipoCambio _
                                    , .IdUsuarioCrea _
                                    , .IdCuentaContable _
                                    , .IdEstadoDocumento _
                                    , ._Operador _
                                    , .Mac_PC_Local _
                                    , .EstadoDocumento _
                                    , .IndServicioMaterial _
                                    , .Glosa _
                                    , .IdLiquidacion _
                                    , .IndElectronico _
                                    , .IdTipoBien _
                                    , .OrdenCompra _
                                    , IIf(.IndAnexo, 1, 0) _
                                    , .CodMotivo _
                                    , IIf(.IndDetalleGlosa, 1, 0) _
                                    , 0.0 _
                                    , .IndAnticipo _
                                    , .IndAfectaAnticipo _
                                    , .Monto_Anticipo
                                    ).ToString.Split("_")
                            .Id = stResultado_Ant(0)
                        End With
                        Dim oeDocAsoc As New e_DocumentoAsociado
                        oeDocAsoc.TipoOperacion = oeAnticipo.TipoOperacion
                        oeDocAsoc.IdMovimientoDocumento = oeAnticipo.Id
                        oeDocAsoc.IdMovimientoDocumentoAsoc = .Id
                        oeDocAsoc.PrefijoID = oeMovimientoDocumento.PrefijoID '@001
                        odDocAso.Guardar(oeDocAsoc)
                    End If
                End If
                '' =========================================================================== 
                '' DocumentoAsociado
                If .DocAsoc.Count > 0 Then
                    For Each oeDocAso As e_DocumentoAsociado In .DocAsoc
                        oeDocAso.IdMovimientoDocumento = stResultado(0)
                        oeDocAso.PrefijoID = oeMovimientoDocumento.PrefijoID '@0001
                        odDocAso.Guardar(oeDocAso)
                    Next
                End If


            End With


            Return oeMovimientoDocumento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarFacturaMasiva(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean
        Try
            Using transScope As New TransactionScope()
                Dim id() As String
                With oeMovimientoDocumento
                    id = sqlhelper.ExecuteScalar("CON.Isp_MovimientoDocumento_IAE", .TipoOperacion, .PrefijoID, _
                            .Id _
                            , .IdTipoDocumento _
                            , .Serie _
                            , .Numero _
                            , .FechaEmision _
                            , .FechaVencimiento _
                            , .SubTotal _
                            , .IGV _
                            , .Total _
                            , Math.Abs(.Saldo) _
                            , .IdClienteProveedor _
                            , .Activo _
                            , .IndCompraVenta _
                            , .IdPeriodo _
                            , .IdMoneda _
                            , .TipoCambio _
                            , .IdUsuarioCrea _
                            , .IdCuentaContable _
                            , .IdEstadoDocumento _
                            , ._Operador _
                            , .Mac_PC_Local _
                            , .EstadoDocumento _
                            , .IndServicioMaterial _
                            , .Glosa _
                            , .IdLiquidacion _
                            , .IndElectronico _
                            , .IdTipoBien _
                            , .OrdenCompra _
                            , IIf(.IndAnexo, 1, 0) _
                            , .CodMotivo _
                            , IIf(.IndDetalleGlosa, 1, 0) _
                            , .Retencion _
                            , .IndAnticipo _
                            , .IndAfectaAnticipo _
                            , .Monto_Anticipo).ToString.Split("_")

                    If id(0) <> "" Then
                        oeMovimientoDocumento.Venta.PrefijoID = oeMovimientoDocumento.PrefijoID '@0001
                        oeMovimientoDocumento.Venta.IdMovimientoDocumento = id(0)
                        odVenta.Guardar(oeMovimientoDocumento.Venta)

                        'Llena Auditoria
                        'oeAuditoria = New e_Auditoria
                        'oeAuditoria.TipoOperacion = "I"
                        'oeAuditoria.IdActividadNegocio = "1PY000000005"
                        'oeAuditoria.
                        '--------------

                        'Guarda Detalle Documento
                        If .dtDetalleDoc.Rows.Count > 0 Then
                            For Each row As DataRow In .dtDetalleDoc.Rows
                                row("IdMovimientoDocumento") = id(0)
                            Next
                            odDetDoc.GuardarMasivo(.dtDetalleDoc)
                        End If
                        '' =========================================================================== @0001
                        '' Datos de Impresion
                        If .TipoOperacion = "I" Then
                            Dim ado_DatosImpresion As New d_MovimientoDocumento_Impresion
                            .DatosImpresion.TipoOperacion = "I"
                            .DatosImpresion.IdMovimientoDocumento = id(0)
                            .DatosImpresion.IdEmpresaSistema = oeMovimientoDocumento.IdEmpresaSistema
                            .DatosImpresion.PrefijoID = oeMovimientoDocumento.PrefijoID '@0001
                            ado_DatosImpresion.Guardar(.DatosImpresion)
                        End If
                        '' =========================================================================== @0001

                        'Guarda Detalle Documento Guia Transportista
                        If .dtDetalleDocGT.Rows.Count > 0 Then
                            odDetDocGT.GuardarMasivo(.dtDetalleDocGT)
                        End If

                        'Actualiza Operacion Detalle Indicador Facturado
                        If .CadIdOperacionDet <> "" Then
                            Dim oeOperaDet As New e_OperacionDetalle
                            oeOperaDet.TipoOperacion = "F"
                            oeOperaDet.Id = .CadIdOperacionDet
                            oeOperaDet.PrefijoID = oeMovimientoDocumento.PrefijoID '@0001
                            odOperacionDet.FacturaOperacionDetalle(oeOperaDet)
                        End If

                        'Actualiza Guia Transportista 
                        If .CadIdGuiasTrans.Trim <> "" Then
                            Dim oeGuiaTrans As New e_GuiaTransportista
                            oeGuiaTrans.TipoOperacion = "F"
                            oeGuiaTrans.Incidencia = .CadIdGuiasTrans
                            oeGuiaTrans.PrefijoID = oeMovimientoDocumento.PrefijoID '@0001
                            odGuiaTransportista.Guardar(oeGuiaTrans)
                        End If

                        If .IndAfectaAnticipo Then
                            If Not .DocAsoc Is Nothing Then
                                Dim odDocAsoc As New d_DocumentoAsociado
                                For Each obj As e_DocumentoAsociado In .DocAsoc
                                    obj.PrefijoID = oeMovimientoDocumento.PrefijoID '@0001
                                    If obj.TipoOperacion = "E" Then
                                        odDocAsoc.Eliminar(obj)
                                    ElseIf obj.TipoOperacion = "I" Then
                                        obj.IdMovimientoDocumento = id(0)
                                        odDocAsoc.Guardar(obj)
                                    End If
                                Next
                                odDocAsoc = Nothing
                            End If
                        Else
                            'Guarda Documento Asociado
                            If .DocAsoc.Count > 0 Then
                                For Each oeDocAso As e_DocumentoAsociado In .DocAsoc
                                    oeDocAso.IdMovimientoDocumento = id(0)
                                    oeDocAso.PrefijoID = oeMovimientoDocumento.PrefijoID '@0001
                                    odDocAso.Guardar(oeDocAso)
                                Next
                            End If
                        End If

                    End If

                End With
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarVenta(ByVal oeMovimientoDocumento As e_MovimientoDocumento, ByVal oeAsiento As e_Asiento) As Boolean
        Try
            Dim stResultado() As String
            Using transScope As New TransactionScope()
                With oeMovimientoDocumento
                    stResultado = sqlhelper.ExecuteScalar("CON.Isp_MovimientoDocumento_IAE", .TipoOperacion, .PrefijoID, _
                            .Id _
                            , .IdTipoDocumento _
                            , .Serie _
                            , .Numero _
                            , .FechaEmision _
                            , .FechaVencimiento _
                            , .SubTotal _
                            , .IGV _
                            , .Total _
                            , Math.Abs(.Saldo) _
                            , .IdClienteProveedor _
                            , .Activo _
                            , .IndCompraVenta _
                            , .IdPeriodo _
                            , .IdMoneda _
                            , .TipoCambio _
                            , .IdUsuarioCrea _
                            , .IdCuentaContable _
                             , .IdEstadoDocumento _
                            , ._Operador _
                            , .Mac_PC_Local _
                            , .EstadoDocumento _
                            , .IndServicioMaterial _
                        ).ToString.Split("_")

                    For Each obj As e_AsientoMovimiento In oeAsiento.AsientoMovimiento
                        If Not obj.AsMov_MovDoc Is Nothing Then
                            If obj.AsMov_MovDoc.TipoOperacion <> "" Then
                                obj.AsMov_MovDoc.IdMovimientoDocumento = stResultado(0)
                            End If
                        End If
                    Next

                    If .Venta.IdTipoVenta <> "" Then
                        .Venta.IdMovimientoDocumento = stResultado(0)
                        Dim odVenta As New d_Venta
                        odVenta.Guardar(.Venta)
                        Dim odAsiento As New d_Asiento
                        If .TipoOperacion = "I" Or .interfazContable Then
                            oeAsiento.Asiento_MovDoc.IdMovimientoDocumento = stResultado(0)
                            oeAsiento.Asiento_MovDoc.TipoOperacion = "I"
                            oeAsiento.Asiento_MovDoc.Activo = True
                        End If
                        odAsiento.GuardarComprobante(oeAsiento)
                        odVenta = Nothing
                    End If

                    If Not .DocAsoc Is Nothing Then
                        Dim odDocAsoc As New d_DocumentoAsociado
                        For Each obj As e_DocumentoAsociado In .DocAsoc
                            If obj.TipoOperacion = "E" Then
                                odDocAsoc.Eliminar(obj)
                            ElseIf obj.TipoOperacion = "I" Then
                                obj.IdMovimientoDocumento = stResultado(0)
                                odDocAsoc.Guardar(obj)
                            End If
                        Next
                        odDocAsoc = Nothing
                    End If

                End With
                transScope.Complete()
            End Using

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarCompra(ByRef oeMovimientoDocumento As e_MovimientoDocumento, ByVal oeAsiento As e_Asiento, _
                                  Optional ByVal UsaTransaccion As Boolean = True) As Boolean
        Try
            If UsaTransaccion Then
                Using transScope As New TransactionScope
                    GuardarCompra2(oeMovimientoDocumento, oeAsiento)
                    transScope.Complete()
                End Using
            Else
                GuardarCompra2(oeMovimientoDocumento, oeAsiento)
            End If
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Function GuardarCompra2(ByRef oeMovimientoDocumento As e_MovimientoDocumento, ByVal oeAsiento As e_Asiento) As Boolean
        Try
            Dim stResultado() As String

            With oeMovimientoDocumento
                stResultado = sqlhelper.ExecuteScalar("CON.Isp_MovimientoDocumento_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .IdTipoDocumento _
                        , .Serie _
                        , .Numero _
                        , .FechaEmision _
                        , .FechaVencimiento _
                        , .SubTotal _
                        , .IGV _
                        , .Total _
                        , Math.Abs(.Saldo) _
                        , .IdClienteProveedor _
                        , .Activo _
                        , .IndCompraVenta _
                        , .IdPeriodo _
                        , .IdMoneda _
                        , .TipoCambio _
                        , .IdUsuarioCrea _
                        , .IdCuentaContable _
                        , .IdEstadoDocumento _
                        , ._Operador _
                        , .Mac_PC_Local _
                        , .EstadoDocumento _
                        , .IndServicioMaterial _
                    ).ToString.Split("_")
                oeMovimientoDocumento.Id = stResultado(0)

                If .leCuotaDocVehMovimiento.Count > 0 Then
                    Dim odCuotaMovimiento As New d_CuotaDocVeh_Movimiento
                    For Each obj In .leCuotaDocVehMovimiento
                        obj.IdMovimientoDocumento = .Id
                        obj.PrefijoID = oeMovimientoDocumento.PrefijoID '@0001
                        odCuotaMovimiento.GuardarCancelacion(obj)
                    Next
                End If

                'actualizo para insertar despues cuando recorra de la AsientoMovimiento la tabla relacion asiento_movimiento
                If Not oeAsiento Is Nothing Then
                    For Each obj As e_AsientoMovimiento In oeAsiento.AsientoMovimiento
                        If Not obj.AsMov_MovDoc Is Nothing Then
                            If obj.AsMov_MovDoc.TipoOperacion = "I" Then
                                obj.AsMov_MovDoc.IdMovimientoDocumento = stResultado(0)
                            End If
                        End If
                        'If Not obj.ObligacionFinanciera Is Nothing Then
                        '    If obj.ObligacionFinanciera.TipoOperacion = "S" Then 'para pago de leasing con documento de compra
                        '        If obj.ObligacionFinanciera.leObligacionDocumento.Count > 0 Then
                        '            obj.ObligacionFinanciera.leObligacionDocumento.Item(0).IdMovimientoDocumento = stResultado(0)
                        '        End If
                        '    End If
                        'End If
                        If Not obj.ObligacionFin Is Nothing Then
                            If obj.ObligacionFin.TipoOperacion = "S" Then 'para pago de leasing con documento de compra
                                If obj.ObligacionFin.leOblFinDoc.Count > 0 Then
                                    obj.ObligacionFin.leOblFinDoc.Item(0).IdMovimientoDocumento = stResultado(0)
                                End If
                            End If
                        End If
                    Next
                End If
                Dim asi As String = .Compra.IdTipoCompra
                If .Compra.IdTipoCompra <> "" Then
                    .Compra.IdMovimientoDocumento = stResultado(0)
                    Dim odCompra As New d_Compra
                    'guardo en la tabla compra
                    .Compra.PrefijoID = oeMovimientoDocumento.PrefijoID '@0001
                    odCompra.Guardar(.Compra)
                    If Not .IndAsientoGuia Then
                        Dim odAsiento As New d_Asiento
                        If .TipoOperacion = "I" Or .interfazContable Then
                            oeAsiento.Asiento_MovDoc.IdMovimientoDocumento = stResultado(0)
                            oeAsiento.Asiento_MovDoc.TipoOperacion = "I"
                            oeAsiento.Asiento_MovDoc.Activo = True
                        End If
                        'guardo en asiento
                        odAsiento.GuardarComprobante(oeAsiento)
                        odCompra = Nothing
                    End If

                End If

                If Not .lstDetalleDocumento Is Nothing Then
                    For Each Detalle As e_DetalleDocumento In .lstDetalleDocumento
                        Detalle.IdMovimientoDocumento = stResultado(0)
                        Detalle.UsuarioCreacion = .IdUsuarioCrea
                        Detalle.TipoOperacion = .TipoOperacion
                        Detalle.PrefijoID = oeMovimientoDocumento.PrefijoID '@0001
                        odDetDoc.Guardar(Detalle)
                    Next
                End If

                If Not .DocAsoc Is Nothing Then 'para el caso de ND y NC
                    Dim odDocAsoc As New d_DocumentoAsociado
                    For Each obj As e_DocumentoAsociado In .DocAsoc
                        obj.PrefijoID = oeMovimientoDocumento.PrefijoID '@0001
                        If obj.TipoOperacion = "E" Then
                            odDocAsoc.Eliminar(obj)
                        ElseIf obj.TipoOperacion = "I" Then
                            obj.IdMovimientoDocumento = stResultado(0)
                            odDocAsoc.Guardar(obj)
                        End If
                    Next
                    odDocAsoc = Nothing
                End If

                If Not .PagoAutomatico Is Nothing Then
                    .PagoAutomatico.IdMovimientoDocumento = stResultado(0)
                    .PagoAutomatico.PrefijoID = oeMovimientoDocumento.PrefijoID '@0001
                    GuardarPagoCompra(.PagoAutomatico)
                End If

            End With

            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function EnviarCompra(ByRef oeMovimientoDocumento As e_MovimientoDocumento, ByVal oeAsiento As e_Asiento) As Boolean
        Try
            Using transScope As New TransactionScope()
                Dim stResultado() As String
                With oeMovimientoDocumento
                    stResultado = sqlhelper.ExecuteScalar("CON.Isp_MovimientoDocumento_IAE", .TipoOperacion, .PrefijoID, _
                            .Id _
                            , .IdTipoDocumento _
                            , .Serie _
                            , .Numero _
                            , .FechaEmision _
                            , .FechaVencimiento _
                            , .SubTotal _
                            , .IGV _
                            , .Total _
                            , Math.Abs(.Saldo) _
                            , .IdClienteProveedor _
                            , .Activo _
                            , .IndCompraVenta _
                            , .IdPeriodo _
                            , .IdMoneda _
                            , .TipoCambio _
                            , .IdUsuarioCrea _
                            , .IdCuentaContable _
                            , .IdEstadoDocumento _
                            , ._Operador _
                            , .Mac_PC_Local _
                            , .EstadoDocumento _
                            , .IndServicioMaterial _
                        ).ToString.Split("_")
                    oeMovimientoDocumento.Id = stResultado(0)
                    .Compra.PrefijoID = oeMovimientoDocumento.PrefijoID '@001
                    odCompra.Guardar(.Compra)
                End With

                odAsiento.GuardarAsientoContable(oeAsiento)

                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function


    Public Function GuardarGastoOperacion(ByRef oeMovimientoDocumento As e_MovimientoDocumento) As Boolean
        Try
            Dim stResultado() As String
            With oeMovimientoDocumento
                stResultado = sqlhelper.ExecuteScalar("CON.Isp_MovimientoDocumento_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .IdTipoDocumento _
                        , .Serie _
                        , .Numero _
                        , .FechaEmision _
                        , .FechaVencimiento _
                        , .SubTotal _
                        , .IGV _
                        , .Total _
                        , Math.Abs(.Saldo) _
                        , .IdClienteProveedor _
                        , .Activo _
                        , .IndCompraVenta _
                        , .IdPeriodo _
                        , .IdMoneda _
                        , .TipoCambio _
                        , .IdUsuarioCrea _
                        , .IdCuentaContable _
                        , "1CH00009" _
                        , ._Operador _
                        , .Mac_PC_Local _
                        , "" _
                        , .IndServicioMaterial _
                        , "" _
                        , "").ToString.Split("_")
                oeMovimientoDocumento.Id = stResultado(0)
                If Not .lstDetalleDocumento Is Nothing Then
                    For Each Detalle As e_DetalleDocumento In .lstDetalleDocumento
                        Detalle.IdMovimientoDocumento = stResultado(0)
                        Detalle.UsuarioCreacion = .IdUsuarioCrea
                        Detalle.TipoOperacion = .TipoOperacion
                        Detalle.PrefijoID = oeMovimientoDocumento.PrefijoID '@0001
                        odDetDoc.Guardar(Detalle)
                    Next
                End If
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function GuardarPagoCompra(ByVal oePagoAutomatico As e_PagoAutomatico) As Boolean
        Try
            With oePagoAutomatico
                sqlhelper.ExecuteNonQuery("CON.Isp_MovimientoDocumentoPago_I", .IdMovimientoDocumento, .IdPeriodo, _
                .PrefijoID, _
                .Glosa _
                , .GlosaGrupo _
                , .IdMoneda _
                , .TipoCambio _
                , .Total _
                , .UsuarioCreacion _
                , .Cuenta42 _
                , .Cuenta10 _
                , .IdFLujo _
                , .MacPCLocalCreacion _
                , .Fecha _
                     )
            End With

            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Emitir(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean
        Try
            With oeMovimientoDocumento
                sqlhelper.ExecuteNonQuery("CON.Isp_MovimientoDocumento_IAE", .TipoOperacion, "", _
                            .Id _
                            , .IdTipoDocumento _
                            , .Serie _
                            , .Numero _
                            , .FechaEmision _
                            , .FechaVencimiento _
                            , .SubTotal _
                            , .IGV _
                            , .Total _
                            , Math.Abs(.Saldo) _
                            , .IdClienteProveedor _
                            , .Activo _
                            , .IndCompraVenta _
                            , .IdPeriodo _
                            , .IdMoneda _
                            , .TipoCambio _
                            , .IdUsuarioCrea _
                            , .IdCuentaContable _
                            , .IdEstadoDocumento _
                            , ._Operador _
                            , .Mac_PC_Local _
                            , .EstadoDocumento _
                        )
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function Anular(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean
        Try
            With oeMovimientoDocumento
                sqlhelper.ExecuteNonQuery("CON.Isp_MovimientoDocumento_IAE", .TipoOperacion, "", _
                            .Id _
                            , .IdTipoDocumento _
                            , .Serie _
                            , .Numero _
                            , .FechaEmision _
                            , .FechaVencimiento _
                            , .SubTotal _
                            , .IGV _
                            , .Total _
                            , Math.Abs(.Saldo) _
                            , .IdClienteProveedor _
                            , .Activo _
                            , .IndCompraVenta _
                            , .IdPeriodo _
                            , .IdMoneda _
                            , .TipoCambio _
                            , .IdUsuarioCrea _
                            , .IdCuentaContable _
                            , .IdEstadoDocumento _
                            , ._Operador _
                            , .Mac_PC_Local _
                            , .EstadoDocumento _
                            , .IndServicioMaterial _
                        )
                If .TipoOperacion = "ACT" Then
                    sqlhelper.ExecuteNonQuery("CON.Isp_Compra_IAE", "D", .PrefijoID, _
                           "", 0, 0, 0, 0, 0, 0, 0, 0, 0, .Id, True, "", 0, "", 0, 0, 0, 0, 0, 0, "" _
                        , 0, "", 0, "", .IndDetraccion)
                End If
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean
        Try
            Using transScope As New TransactionScope()
                With oeMovimientoDocumento
                    sqlhelper.ExecuteNonQuery("CON.Isp_MovimientoDocumento_IAE", "E", _
                            "", oeMovimientoDocumento.Id)
                    If .IdAsientoMovimiento <> "" Then
                        '-----------tabla relacion-------------
                        Dim oeAsMovMovDoc As New e_AsientoMov_MovDoc
                        Dim odAsMovMovDoc As New d_AsientoMov_MovDoc
                        oeAsMovMovDoc.IdAsientoMovimiento = .IdAsientoMovimiento
                        oeAsMovMovDoc.IdMovimientoDocumento = oeMovimientoDocumento.Id
                        oeAsMovMovDoc.Activo = True
                        oeAsMovMovDoc = odAsMovMovDoc.Obtener(oeAsMovMovDoc)
                        odAsMovMovDoc.Eliminar(oeAsMovMovDoc) 'elimino tabla relacion
                        '--------------------------------------
                    End If

                    If Not .CuentaxCyP Is Nothing Then
                        Dim odCuentaxCyP As New d_CuentaxCyP
                        odCuentaxCyP.Eliminar(.CuentaxCyP)
                    End If

                    ' ''----------------------Facturacion por compras-----------------
                    If Not IsDBNull(.Id) And .Id <> "" Then
                        Dim Detalle As New e_DetalleDocumento
                        Detalle.IdMovimientoDocumento = .Id
                        Detalle.TipoOperacion = .TipoOperacion
                        odDetDoc.Eliminar(Detalle)
                    End If
                    ''--------------------------------------------------------------
                    If (Not IsDBNull(.Compra.Id) And .Compra.Id <> "") AndAlso _
                      .IndCompraVenta = 1 Then 'Si es una factura por compras
                        Dim oeCompra As New e_Compra
                        oeCompra.Id = .Compra.Id
                        oeCompra.TipoOperacion = .TipoOperacion
                        odCompra.Eliminar(oeCompra)
                    End If
                    '--------------------------------------------------------------

                    ''------------------------------ACTUALIZAR ESTADO ORDEN DE COMPRA
                    If Not IsDBNull(.Id) And .Id <> "" Then
                        Dim oeOrdDoc As New e_Orden_Documento
                        oeOrdDoc.IdDocumento = .Id
                        oeOrdDoc.TipoOperacion = "X"
                        oeOrdDoc.IdTipoOrden = "1CH000000006"
                        odOrdDoc.Guardar(oeOrdDoc)
                    End If
                End With
                transScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Elimina Comprobante de compra o venta EMITIDAS (que tiene tablas relacionadas diferentes)
    ''' </summary>
    ''' <param name="oeMovimientoDocumento"></param>
    ''' <param name="oeAs"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function EliminarComprobante(ByVal oeMovimientoDocumento As e_MovimientoDocumento, _
                                        Optional ByVal oeAs As e_Asiento = Nothing) As Boolean
        Try
            Dim odAsDocumento As New d_Asiento_MovDoc
            Dim odAsMovMovDoc As New d_AsientoMov_MovDoc
            Dim odAsiento As New d_Asiento
            Dim oeAsiento As New e_Asiento

            Using transScope As New TransactionScope()

                sqlhelper.ExecuteNonQuery("CON.Isp_MovimientoDocumento_IAE", "E", _
                        "", oeMovimientoDocumento.Id)

                If Not oeAs Is Nothing Then
                    odAsiento.Eliminar(oeAs)
                End If
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function EliminarAnticipo(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.Isp_MovimientoDocumento_IAE", "ANT", "", oeMovimientoDocumento.Id)
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Eliminar documento de venta "GENERADO" de viajes
    ''' </summary>
    ''' <param name="oeMovimientoDocumento"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function EliminarDocumentoVenta(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.Isp_MovimientoDocumento_IAE", "X", _
                       "", oeMovimientoDocumento.Id)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function EliminarDocumento(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.Isp_MovimientoDocumento_IAE", oeMovimientoDocumento.TipoOperacion,
                       "", oeMovimientoDocumento.Id)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function


    ''' <summary>
    ''' Para el caso de Gastos de caja o de viaje
    ''' </summary>
    ''' <param name="oeMovimientoDocumento"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function EliminarDocumentoyPago(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.Isp_MovimientoDocumento_IAE", "G", _
                       "", oeMovimientoDocumento.Id)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function CambiarGlosa(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.Isp_MovimientoDocumento_IAE", "GLO", _
            "", oeMovimientoDocumento.Id, _
            "", "", "", Date.Parse("01/01/1901"), Date.Parse("01/01/1901"), 0 _
            , 0, 0, 0, "", 1, 1, "" _
            , "", 0, "", "", "", 1, "", "", 0, oeMovimientoDocumento.Glosa)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function CuentasxPagarxPeriodo(ByVal Ejercicio As Integer, ByVal Mes As Integer, ByVal Ind As String, ByVal IdMoneda As String) As DataTable
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_ReporteCuentasXPagar", Ejercicio, Mes, Ind, IdMoneda)
            Return ds.Tables(0)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CuentasxCobrarxPeriodo(ByVal Ejercicio As Integer, ByVal Mes As Integer, ByVal Ind As String, ByVal IdMoneda As String) As DataTable
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_ReporteCuentasXCobrar", Ejercicio, Mes, Ind, IdMoneda)
            Return ds.Tables(0)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ActualizarSaldoDoc(ByVal leMovDoc As List(Of e_MovimientoDocumento)) As Boolean
        Try
            For Each oeMovDoc In leMovDoc
                With oeMovDoc
                    sqlhelper.ExecuteNonQuery("CON.Isp_MovimientoDocumento_IAE", _
                               "SAL" _
                               , "" _
                               , .Id _
                               , .IdTipoDocumento _
                               , .Serie _
                               , .Numero _
                               , .FechaEmision _
                               , .FechaVencimiento _
                               , .SubTotal _
                               , .IGV _
                               , .Total _
                               , IIf((Math.Round(Math.Abs(.Saldo), 2)) - (Math.Round(Math.Abs(.MontoOperar), 2)) < 0.1, 0.0, (Math.Round(Math.Abs(.Saldo), 2)) - (Math.Round(Math.Abs(.MontoOperar), 2))) _
                               , .IdClienteProveedor _
                               , .Activo _
                               , .IndCompraVenta _
                               , .IdPeriodo _
                               , .IdMoneda _
                               , .TipoCambio _
                               , .IdUsuarioCrea _
                               , .IdCuentaContable _
                               , .IdEstadoDocumento _
                               , ._Operador _
                               , .Mac_PC_Local _
                               , .EstadoDocumento _
                               , .IndServicioMaterial _
                               , "" _
                               , "" _
                               , 0 _
                               , "" _
                               , "" _
                               , "" _
                               , "" _
                               , "" _
                               , Math.Round(.Retencion, 2) _
                               )
                End With
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#Region "Ventas"

    Public Function GuardarVenta2(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As e_MovimientoDocumento
        Try
            Dim stResultado() As String
            Using transScope As New TransactionScope()
                With oeMovimientoDocumento
                    stResultado = sqlhelper.ExecuteScalar("CON.Isp_MovimientoDocumento_IAE", .TipoOperacion, .PrefijoID,
                            .Id _
                            , .IdTipoDocumento _
                            , .Serie _
                            , .Numero _
                            , .FechaEmision _
                            , .FechaVencimiento _
                            , .SubTotal _
                            , .IGV _
                            , .Total _
                            , Math.Abs(.Saldo) _
                            , .IdClienteProveedor _
                            , .Activo _
                            , .IndCompraVenta _
                            , .IdPeriodo _
                            , .IdMoneda _
                            , .TipoCambio _
                            , .IdUsuarioCrea _
                            , .IdCuentaContable _
                             , .IdEstadoDocumento _
                            , ._Operador _
                            , .Mac_PC_Local _
                            , .EstadoDocumento _
                            , .IndServicioMaterial _
                            , .Glosa _
                            , .IdLiquidacion _
                            , .IndElectronico _
                            , .IdTipoBien _
                            , .OrdenCompra _
                            , IIf(.IndAnexo, 1, 0) _
                            , .CodMotivo _
                            , IIf(.IndDetalleGlosa, 1, 0) _
                            , .Retencion _
                            , .IndAnticipo _
                            , .IndAfectaAnticipo _
                            , .Monto_Anticipo).ToString.Split("_")

                    .Id = stResultado(0)
                    'Guardar Venta
                    If .Venta.IdTipoVenta <> "" Then
                        .Venta.IdMovimientoDocumento = stResultado(0)
                        Dim odVenta As New d_Venta
                        .Venta.PrefijoID = oeMovimientoDocumento.PrefijoID '@0001
                        odVenta.Guardar(.Venta)
                    End If
                    'Guardar Documento Asociado
                    If Not .DocAsoc Is Nothing Then
                        Dim odDocAsoc As New d_DocumentoAsociado
                        For Each obj As e_DocumentoAsociado In .DocAsoc
                            obj.PrefijoID = oeMovimientoDocumento.PrefijoID '@0001
                            If obj.TipoOperacion = "E" Then
                                odDocAsoc.Eliminar(obj)
                            ElseIf obj.TipoOperacion = "I" Then
                                obj.IdMovimientoDocumento = stResultado(0)
                                odDocAsoc.Guardar(obj)
                            End If
                        Next
                        odDocAsoc = Nothing
                    End If
                End With
                transScope.Complete()
                Return oeMovimientoDocumento
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

    Public Function UltimoIdInserta(ByVal PrefijoID As String) As String
        Try
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "CON.MovimientoDocumento", PrefijoID)
            Return IIf(stResultado Is Nothing, PrefijoID & "000000000001", stResultado)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function UltimoId(ByVal PrefijoID As String) As String
        Try
            Dim stResultado As String
            Dim Prefijo As String = PrefijoID
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "CON.MovimientoDocumento", Prefijo)
            Return IIf(stResultado Is Nothing, Prefijo & "000000000001", stResultado)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function AperturaDetalle(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As DataTable
        Try
            Dim dsDet As DataSet
            With oeMovimientoDocumento
                dsDet = sqlhelper.ExecuteDataset("CON.Isp_AperturaDetalle_Listar", .TipoOperacion, .Ejercicio, .Mes, .Id, .IdCuentaContable)
            End With
            If dsDet.Tables.Count = 0 Then Throw New Exception("¡No se encontraron Datos!")
            Return dsDet.Tables(0)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardaMasivo(oeMovDoc As e_MovimientoDocumento, DTAsiento As DataTable, DTAsiMov As DataTable, DTMovCajBan As DataTable, DTAsiMovMovDoc As DataTable, DTCtaCyP As DataTable) As Boolean
        Try
            oeMovDoc = Guardar(oeMovDoc)
            If oeMovDoc.Id = "" Then Return False
            If DTAsiento.Rows.Count > 0 Then sqlhelper.InsertarMasivo("CON.Asiento", DTAsiento, False)
            If DTAsiMov.Rows.Count > 0 Then sqlhelper.InsertarMasivo("CON.AsientoMovimiento", DTAsiMov, False)
            If DTMovCajBan.Rows.Count > 0 Then sqlhelper.InsertarMasivo("CON.MovimientoCajaBanco", DTMovCajBan, False)
            If DTCtaCyP.Rows.Count > 0 Then sqlhelper.InsertarMasivo("TES.CuentaxCyP", DTCtaCyP, False)
            If DTAsiMovMovDoc.Rows.Count > 0 Then sqlhelper.InsertarMasivo("CON.AsientoMov_MovDoc", DTAsiMovMovDoc, False)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Function DatosImpresionElectronico(oeMovimientoDocumento As e_MovimientoDocumento) As DataSet
        Try
            Dim dsDet As DataSet
            With oeMovimientoDocumento
                dsDet = sqlhelper.ExecuteDataset("CON.Isp_MovimientoDocumento_Listar", .TipoOperacion, .Id)
            End With
            If dsDet.Tables.Count = 0 Then Throw New Exception("¡No se encontraron Datos!")
            Return dsDet
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Function FacturacionPendiente() As DataTable
        Try
            Dim query As String = "select * from CON.MovimientoDocumento where IndElectronico = 1 and IndEnviado=0 and Activo = 1"
            'Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("ISL").ConnectionString) '@0001
            Dim connection As SqlConnection = New SqlConnection(connectionString) '@0001
            Dim command As SqlDataAdapter = New SqlDataAdapter(query, connection)
            command.SelectCommand.CommandType = CommandType.Text

            Dim dt As DataTable = New DataTable()
            command.Fill(dt)

            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Function SincronizarFacturado() As Boolean
        Try
            'Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("ISL").ConnectionString) '@0001
            Dim connection As SqlConnection = New SqlConnection(connectionString) '@0001
            Dim connectionFE As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SEEFBISL").ConnectionString)
            Dim commandFE As SqlCommand
            Dim commandIAE As SqlCommand
            Dim query As New StringBuilder

            query.Append(" SELECT DOC.Id, DOC.IdTipoDocumento FROM CON.MovimientoDocumento DOC ")
            query.Append(" INNER JOIN STD.Ift_ClienteProveedor() CP on DOC.IdClienteProveedor = CP.Id ")
            query.Append(" INNER JOIN STD.Centro CE  on SUBSTRING(DOC.Id, 1, 3)  = SUBSTRING(CE.Abreviatura,1,3) ")
            query.Append(" INNER JOIN STD.TipoDocumento TD ON TD.Id = DOC.IdTipoDocumento ")
            query.Append(" INNER JOIN CON.Venta VE ON VE.IdMovimientoDocumento = DOC.Id ")
            query.Append(" INNER JOIN STD.Ift_Direccion() DIR ON DIR.Id = VE.IdDireccion ")
            query.Append(" inner join CMP.TipoPago F_PAG ON F_PAG.Id = VE.IdTipoPago ")
            query.Append(" inner join STD.Moneda TM ON TM.Id = DOC.IdMoneda ")
            query.Append(" WHERE DOC.IdTipoDocumento IN ('1CH000000026','1CH000000002','1CH000000030','1CH000000033') ")
            query.Append(" AND DOC.Activo = 1 AND DOC.IndCompraVenta = 2 ")
            query.Append(" AND ISNULL(DOC.IndEnviado, 0) = 0 ")
            query.Append(" AND ISNULL(DOC.IndElectronico, 0) = 1 ")
            query.Append(" AND DOC.IdEstadoDocumento in ('1CH00008','1CH00009','1CH00014') ") ''quitar 1CH00014 que es estado generado

            Dim command As SqlDataAdapter = New SqlDataAdapter(query.ToString, connection)
            command.SelectCommand.CommandType = CommandType.Text
            Dim dtDoc As DataTable = New DataTable()
            Dim dsDocumento As DataSet = New DataSet()
            command.Fill(dtDoc)

            Dim oeMovimientoDocumento As New e_MovimientoDocumento
            oeMovimientoDocumento.TipoOperacion = "MIG"
            For Each i In dtDoc.Rows
                oeMovimientoDocumento.Id = i("Id").ToString
                dsDocumento = DatosImpresionElectronico(oeMovimientoDocumento)
                With dsDocumento.Tables(0)
                    commandFE = New SqlCommand("Isp_Documento_IAE", connectionFE)
                    commandFE.CommandType = CommandType.StoredProcedure
                    commandFE.Parameters.AddWithValue("@id_documento", .Rows(0)("IdDocumento").ToString)
                    commandFE.Parameters.AddWithValue("@val_batnbr_ar", "")
                    commandFE.Parameters.AddWithValue("@val_refnbr_ar", "")
                    commandFE.Parameters.AddWithValue("@id_cliente", .Rows(0)("IdCliente").ToString)
                    commandFE.Parameters.AddWithValue("@num_doc_venta", .Rows(0)("SerieNumero").ToString)
                    commandFE.Parameters.AddWithValue("@serie_comprobante", .Rows(0)("Serie").ToString)
                    commandFE.Parameters.AddWithValue("@nro_comprobante", .Rows(0)("Numero").ToString)
                    commandFE.Parameters.AddWithValue("@cod_ref_zona", .Rows(0)("IdSucursal").ToString)
                    commandFE.Parameters.AddWithValue("@id_tipo_doc", .Rows(0)("IdTipoDocumento").ToString)
                    commandFE.Parameters.AddWithValue("@fec_venta", .Rows(0)("FechaEmision"))
                    commandFE.Parameters.AddWithValue("@fec_venci_pago", .Rows(0)("FechaVencimiento"))
                    commandFE.Parameters.AddWithValue("@forma_pago", .Rows(0)("IdFormaPago").ToString)
                    commandFE.Parameters.AddWithValue("@moneda", .Rows(0)("Moneda").ToString)
                    commandFE.Parameters.AddWithValue("@valor_tipo_cambio", .Rows(0)("ValorTipoCambio"))
                    commandFE.Parameters.AddWithValue("@valor_igv_Orig", .Rows(0)("IGV").ToString)
                    commandFE.Parameters.AddWithValue("@valor_igv_Soles", .Rows(0)("Valor_IGV_Soles").ToString)
                    commandFE.Parameters.AddWithValue("@m_total_venta_Orig", .Rows(0)("Total").ToString)
                    commandFE.Parameters.AddWithValue("@m_total_venta_Soles", .Rows(0)("TotalSoles").ToString)
                    commandFE.Parameters.AddWithValue("@estado", .Rows(0)("Estado").ToString)
                    commandFE.Parameters.AddWithValue("@num_doc_elect", "")
                    commandFE.Parameters.AddWithValue("@estransgratuita", 0)
                    commandFE.Parameters.AddWithValue("@descom", 0)
                    commandFE.Parameters.AddWithValue("@es_anulado", 0)
                    commandFE.Parameters.AddWithValue("@enviado_email", 0)
                    commandFE.Parameters.AddWithValue("@enviado_externo", 0)
                    commandFE.Parameters.AddWithValue("@nro_guia", "")
                    commandFE.Parameters.AddWithValue("@nro_oc", .Rows(0)("OrdenCompra").ToString)
                    commandFE.Parameters.AddWithValue("@ind_afecto_ivap", 0)
                    commandFE.Parameters.AddWithValue("@cod_sello_impresion", "")
                    commandFE.Parameters.AddWithValue("@txt_sello_impresion", "")
                    commandFE.Parameters.AddWithValue("@txt_info_adicional", "")
                    commandFE.Parameters.AddWithValue("@TipoBien", .Rows(0)("TipoBien").ToString)
                    commandFE.Parameters.AddWithValue("@Detraccion", .Rows(0)("Detraccion").ToString)
                    commandFE.Connection.Open()
                    Try
                        commandFE.ExecuteNonQuery().ToString()
                    Catch ex As Exception
                        Return False
                    Finally
                        commandFE.Connection.Close()
                    End Try

                    If .Rows(0)("IdTipoDocumento").ToString = "07" Or .Rows(0)("IdTipoDocumento").ToString = "08" Then
                        commandFE = New SqlCommand("Isp_PLCMInvcnbr_IAE", connectionFE)
                        commandFE.CommandType = CommandType.StoredProcedure
                        commandFE.Parameters.AddWithValue("@CpnyID", 1)
                        commandFE.Parameters.AddWithValue("@Custid", .Rows(0)("IdCliente").ToString)
                        commandFE.Parameters.AddWithValue("@DocType", IIf(.Rows(0)("IdTipoDocumento").ToString = "07", "CM", IIf(.Rows(0)("IdTipoDocumento").ToString = "08", "DM", "")))
                        commandFE.Parameters.AddWithValue("@InvcNbr", .Rows(0)("DOC_ASOC_FACT").ToString)
                        commandFE.Parameters.AddWithValue("@LineNbr", 1)
                        commandFE.Parameters.AddWithValue("@RefNbr", .Rows(0)("SerieNumero").ToString)
                        commandFE.Parameters.AddWithValue("@ShipperID", "AA")
                        commandFE.Parameters.AddWithValue("@User1", "")
                        commandFE.Parameters.AddWithValue("@User2", "")
                        commandFE.Parameters.AddWithValue("@User3", 0)
                        commandFE.Parameters.AddWithValue("@User4", 0)
                        commandFE.Parameters.AddWithValue("@User5", .Rows(0)("IdTipoDocumento").ToString)
                        commandFE.Parameters.AddWithValue("@User6", .Rows(0)("IdTipoDocumentoAsoc").ToString)
                        commandFE.Parameters.AddWithValue("@User7", "")
                        commandFE.Parameters.AddWithValue("@User8", .Rows(0)("DOC_FEC_ASOC"))
                        commandFE.Connection.Open()
                        Try
                            commandFE.ExecuteNonQuery().ToString()
                        Catch ex As Exception
                            Return False
                        Finally
                            commandFE.Connection.Close()
                        End Try
                    End If
                End With

                With dsDocumento.Tables(1)
                    commandFE = New SqlCommand("Isp_DetalleDocumento_IAE", connectionFE)
                    commandFE.CommandType = CommandType.StoredProcedure
                    commandFE.Parameters.AddWithValue("@id_documento", .Rows(0)("IdDocumento").ToString)
                    commandFE.Parameters.AddWithValue("@LineId", .Rows(0)("LineId").ToString)
                    commandFE.Parameters.AddWithValue("@producto", .Rows(0)("PRODUCTO").ToString)
                    commandFE.Parameters.AddWithValue("@und_prod", .Rows(0)("UNID_MED").ToString)
                    commandFE.Parameters.AddWithValue("@cantidad", .Rows(0)("Cantidad"))
                    commandFE.Parameters.AddWithValue("@precio_unit", .Rows(0)("PrecioUnitario"))
                    commandFE.Parameters.AddWithValue("@CatId", .Rows(0)("CatId").ToString)
                    commandFE.Parameters.AddWithValue("@TaxId", .Rows(0)("TaxId").ToString)
                    commandFE.Parameters.AddWithValue("@id_tipoVenta", .Rows(0)("id_TipoVenta").ToString)
                    commandFE.Parameters.AddWithValue("@val_venta_Orig", .Rows(0)("val_venta_Orig"))
                    commandFE.Parameters.AddWithValue("@val_venta_Sol", .Rows(0)("val_venta_Sol"))
                    commandFE.Parameters.AddWithValue("@val_igv_Orig", .Rows(0)("val_igv_Orig"))
                    commandFE.Parameters.AddWithValue("@val_igv_Sol", .Rows(0)("val_igv_Sol"))
                    commandFE.Parameters.AddWithValue("@val_SubTotal_Orig", .Rows(0)("val_SubTotal_Orig"))
                    commandFE.Parameters.AddWithValue("@val_SubTotal_Sol", .Rows(0)("val_SubTotal_Sol"))
                    commandFE.Parameters.AddWithValue("@Precio_Orig", .Rows(0)("Precio_Orig"))
                    commandFE.Parameters.AddWithValue("@CV", .Rows(0)("CV").ToString)
                    commandFE.Parameters.AddWithValue("@FactorRefUni", .Rows(0)("FactorReferencialU"))
                    commandFE.Connection.Open()
                    Try
                        commandFE.ExecuteNonQuery().ToString()
                    Catch ex As Exception
                        Return False
                    Finally
                        commandFE.Connection.Close()
                    End Try
                End With

                'Clientes
                query = New StringBuilder
                query.AppendFormat("SELECT * from STD.Ift_ClienteProveedor() where dni = '{0}'", dsDocumento.Tables(0).Rows(0)("IdCliente").ToString)
                command = New SqlDataAdapter(query.ToString, connection)
                command.SelectCommand.CommandType = CommandType.Text
                Dim dtCliente As DataTable = New DataTable()
                command.Fill(dtCliente)

                'Direccion
                query = New StringBuilder
                query.AppendFormat("select * from STD.Ift_Direccion() where id = '{0}'", dsDocumento.Tables(0).Rows(0)("IdDireccion").ToString)
                command = New SqlDataAdapter(query.ToString, connection)
                command.SelectCommand.CommandType = CommandType.Text
                Dim dtDireccion As DataTable = New DataTable()
                command.Fill(dtDireccion)

                'Insertar/Actualizar SEE
                commandFE = New SqlCommand("Isp_Cliente_IAE", connectionFE)
                commandFE.CommandType = CommandType.StoredProcedure
                commandFE.Parameters.AddWithValue("@id_cliente", dtCliente.Rows(0)("dni").ToString)
                commandFE.Parameters.AddWithValue("@nombre", dtCliente.Rows(0)("Nombre").ToString)
                commandFE.Parameters.AddWithValue("@direccion1", dtDireccion.Rows(0)("Direccion").ToString + " " + dtDireccion.Rows(0)("Ubigeo").ToString)
                commandFE.Parameters.AddWithValue("@direccion2", "")
                commandFE.Parameters.AddWithValue("@identidadPH", dtCliente.Rows(0)("Id"))
                commandFE.Parameters.AddWithValue("@Crtd_User", "ADMIN_O")
                commandFE.Parameters.AddWithValue("@Crtd_DateTime", Now)
                commandFE.Parameters.AddWithValue("@TipoDoc", IIf(Len(dtCliente.Rows(0)("dni").ToString.Trim) = 11, 6, IIf(Len(dtCliente.Rows(0)("dni").ToString.Trim) = 8, 1, 0)))
                commandFE.Parameters.AddWithValue("@TipoPer", IIf(dtCliente.Rows(0)("dni").ToString.Trim.Substring(0, 2) = "20", "02", "01"))
                commandFE.Parameters.AddWithValue("@email", "")
                commandFE.Connection.Open()
                Try
                    commandFE.ExecuteNonQuery().ToString()
                Catch ex As Exception
                    Return False
                Finally
                    commandFE.Connection.Close()
                End Try

                'Actualizar Documento Enviado
                query = New StringBuilder
                query.AppendFormat("UPDATE CON.MovimientoDocumento set IndEnviado = 1 where id = '{0}'", dsDocumento.Tables(0).Rows(0)("IdDocumento").ToString)
                commandIAE = New SqlCommand(query.ToString, connection)
                commandIAE.CommandType = CommandType.Text
                commandIAE.Connection.Open()
                Try
                    commandIAE.ExecuteNonQuery().ToString()
                Catch ex As Exception
                    Return False
                Finally
                    commandIAE.Connection.Close()
                End Try

            Next

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Function ListarFacturacionElectronica(oeMovDocumento As e_MovimientoDocumento) As DataSet
        Try
            Dim dsDet As DataSet
            With oeMovDocumento
                'If .TipoOperacion = "6" Then
                dsDet = sqlhelper.ExecuteDataset("CON.Isp_FacturacionElectronica_Listar", _
                                                 .TipoOperacion, .Id, .IdTipoDocumento, .Serie, "", .FechaEmision, #1/1/1901#, _
                                                 0, 0, "", 1, 2, "", "", 0, "", 2014, "", .FechaInicio, .FechaFinal, "", ._Operador, "", "", .Item, .IndAnulado, .Abrev_Empresa)
                'Else
                '    dsDet = sqlhelper.ExecuteDataset("CON.Isp_FacturacionElectronica_Listar", .TipoOperacion, .Id)
                'End If
            End With
            If dsDet.Tables.Count = 0 Then Throw New Exception("¡No se encontraron Datos!")
            Return dsDet
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ActualizarDocFE(oeMovDoc As e_MovimientoDocumento) As Boolean
        Try
            With oeMovDoc
                sqlhelper.ExecuteNonQuery("CON.Isp_MovimientoDocumento_IAE", _
                           .TipoOperacion _
                           , "" _
                           , .Id _
                           , .IdTipoDocumento _
                           , .Serie _
                           , .Numero _
                           , .FechaEmision _
                           , .FechaVencimiento _
                           , .SubTotal _
                           , .IGV _
                           , .Total _
                           , 0 _
                           , .IdClienteProveedor _
                           , .Activo _
                           , .IndCompraVenta _
                           , .IdPeriodo _
                           , .IdMoneda _
                           , .TipoCambio _
                           , .IdUsuarioCrea _
                           , .IdCuentaContable _
                           , .IdEstadoDocumento _
                           , ._Operador _
                           , .Mac_PC_Local _
                           , .EstadoDocumento _
                           , .IndServicioMaterial _
                           , "" _
                           , "" _
                           )
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ActualizarCabeceraComprobante(IdDocumento As String, Estado As String, SerieNumeroDoc As String, IndActualizaNC As Boolean) As Boolean
        Try
            Dim _ban As Boolean = False
            Dim oeDocumento As New e_MovimientoDocumento
            oeDocumento.TipoOperacion = ""
            oeDocumento.Id = IdDocumento
            oeDocumento = Obtener(oeDocumento)
            oeDocumento.TipoOperacion = "AFE"
            oeDocumento.IndServicioMaterial = Estado
            _ban = ActualizarDocFE(oeDocumento)
            Return _ban
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ActualizarEstadoPago(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean
        Try
            Using transScope As New TransactionScope
                Dim stResultado() As String
                With oeMovimientoDocumento
                    stResultado = sqlhelper.ExecuteScalar("CON.Isp_MovimientoDocumento_IAE", .TipoOperacion, _
                            .PrefijoID, _
                            .Id _
                            , .IdTipoDocumento _
                            , .Serie _
                            , .Numero _
                            , .FechaEmision _
                            , .FechaVencimiento _
                            , .SubTotal _
                            , .IGV _
                            , .Total _
                            , Math.Abs(.Saldo) _
                            , .IdClienteProveedor _
                            , .Activo _
                            , .IndCompraVenta _
                            , .IdPeriodo _
                            , .IdMoneda _
                            , .TipoCambio _
                            , .IdUsuarioCrea _
                            , .IdCuentaContable _
                            , .IdEstadoDocumento _
                            , ._Operador _
                            , .Mac_PC_Local _
                            , .EstadoDocumento _
                            , .IndServicioMaterial _
                            , .Glosa _
                            , .IdLiquidacion _
                            , .IndElectronico _
                            , .IdTipoBien _
                            , .OrdenCompra _
                            , IIf(.IndAnexo, 1, 0) _
                            , .CodMotivo _
                            , IIf(.IndDetalleGlosa, 1, 0)).ToString.Split("_")
                    .Id = stResultado(0)
                End With
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    'FACTURAS POR ANTICIPOS

    Public Function Listar_Anticipos(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As DataTable
        Try
            Dim dt As New DataTable
            Dim ldMovimientoDocumento As New List(Of e_MovimientoDocumento)
            Dim ds As DataSet
            With oeMovimientoDocumento
                ds = sqlhelper.ExecuteDataset("CON.Isp_MovimientoDocumento_Listar", _
                                              .TipoOperacion _
                                                , .Id _
                                                , .IdTipoDocumento _
                                                , .Serie _
                                                , .Numero _
                                                , .FechaEmision _
                                                , .FechaVencimiento _
                                                , .Total _
                                                , .Saldo _
                                                , .IdClienteProveedor _
                                                , .Activo _
                                                , .IndCompraVenta _
                                                , .IdPeriodo _
                                                , .IdMoneda _
                                                , .TipoCambio _
                                                , .IdUsuarioCrea _
                                                , .Ejercicio _
                                                , .IndServicioMaterial _
                                                , .FechaInicio _
                                                , .FechaFinal _
                                                , .IdEstadoDocumento _
                                                , ._Operador _
                                                , .NombreDocumento _
                                                , .Documentos)
                oeMovimientoDocumento = Nothing
                If ds.Tables.Count > 0 Then
                    dt = ds.Tables(0)
                End If
            End With
            Return dt
        Catch ex As Exception
            Throw
        End Try
    End Function


End Class
