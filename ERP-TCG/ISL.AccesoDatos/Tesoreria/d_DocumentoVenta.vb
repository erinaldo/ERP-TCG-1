'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_DocumentoVenta
    Private sqlhelper As New SqlHelper
    Dim oeCuentaPorCobrar As New e_CuentaPorCobrar
    Dim odCuentaPorCobrar As New d_CuentaPorCobrar
    Dim oeCorrelativo As New e_Correlativo
    Dim odCorrelativo As New d_Correlativo

    Private Function Cargar(ByVal o_fila As DataRow) As e_DocumentoVenta
        Try
            Dim oeDocumentoVenta = New e_DocumentoVenta( _
                             o_fila("Id").ToString _
                             , o_fila("IdTipoDocumento").ToString _
                             , o_fila("TipoDocumento").ToString _
                             , o_fila("IdCliente").ToString _
                             , o_fila("NombreCliente").ToString _
                             , o_fila("Concepto").ToString _
                             , o_fila("IdReferencia").ToString _
                             , o_fila("Serie").ToString _
                             , o_fila("Numero").ToString _
                             , o_fila("IdTipoPago").ToString _
                             , o_fila("TipoPago").ToString _
                             , o_fila("FechaEmision").ToString _
                             , o_fila("FechaVencimiento").ToString _
                             , o_fila("IdEstado").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("IdMoneda").ToString _
                             , o_fila("Moneda").ToString _
                             , o_fila("TotalFacturado") _
                             , o_fila("TotalEfectivo") _
                             , o_fila("TotalCredito") _
                             , o_fila("TotalDescuento") _
                             , o_fila("TotalMontoNeto").ToString _
                             , o_fila("IdCuentaCorriente").ToString _
                             , o_fila("TotalDetraccion") _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("PorcentajeDescuento") _
                             , o_fila("PorcentajeDetraccion") _
                             , o_fila("PorcentajeIgv") _
                             , o_fila("SubTotal") _
            )
            Return oeDocumentoVenta
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDocumentoVenta As e_DocumentoVenta) As e_DocumentoVenta

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_DocumentoVenta_Listar_Listar", oeDocumentoVenta.TipoOperacion, oeDocumentoVenta.Id)
            oeDocumentoVenta = New e_DocumentoVenta
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeDocumentoVenta = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeDocumentoVenta
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDocumentoVenta As e_DocumentoVenta) As List(Of e_DocumentoVenta)
        Try
            Dim ldDocumentoVenta As New List(Of e_DocumentoVenta)
            Dim ds As DataSet
            With oeDocumentoVenta
                ds = sqlhelper.ExecuteDataset("TES.Isp_DocumentoVenta_Listar", _
                          .TipoOperacion _
                        , .Id _
                        , .IdTipoDocumento _
                        , .IdCliente _
                        , .IdTipoPago _
                        , .Serie _
                        , .Numero _
                        , .FechaDesde _
                        , .FechaHasta _
                        , .Activo _
                        )
            End With
            oeDocumentoVenta = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeDocumentoVenta = Cargar(o_Fila)
                    ldDocumentoVenta.Add(oeDocumentoVenta)
                Next
                Return ldDocumentoVenta
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDocumentoVenta As e_DocumentoVenta) As Boolean
        Dim stResultado As String
        Try
            Using transScope As New TransactionScope()
                With oeDocumentoVenta
                    stResultado = sqlhelper.ExecuteScalar("TES.Isp_DocumentoVenta_IAE", .TipoOperacion, .PrefijoID, _
                            .Id _
                            , .IdTipoDocumento _
                            , .IdCliente _
                            , .Concepto _
                            , .IdReferencia _
                            , .Serie _
                            , .Numero _
                            , .IdTipoPago _
                            , .FechaEmision _
                            , .FechaVencimiento _
                            , .IdEstado _
                            , .IdMoneda _
                            , .SubTotal _
                            , .PorcentajeDescuento _
                            , .PorcentajeIgv _
                            , .PorcentajeDetraccion _
                            , .TotalDescuento _
                            , .TotalFacturado _
                            , .TotalEfectivo _
                            , .TotalCredito _
                            , .TotalMontoNeto _
                            , .IdCuentaCorriente _
                            , .TotalDetraccion _
                            , .UsuarioCreacion _
                            , .Activo _
                        )
                End With
                'Guardando Detalle Venta 
                For Each Detalle As e_DocumentoVentaDetalle In oeDocumentoVenta.loDocumentoVentaDetalle
                    Detalle.IdDocumentoVenta = stResultado
                    Detalle.PrefijoID = oeDocumentoVenta.PrefijoID '@0001
                    GuardarDetalle(Detalle)
                Next
                'Guardando numero y serie correlativo
                oeCorrelativo.TipoOperacion = "I"
                oeCorrelativo.Prefijo = oeDocumentoVenta.PrefijoID
                oeCorrelativo.Numero = CInt(oeDocumentoVenta.Numero)
                oeCorrelativo.Serie = CInt(oeDocumentoVenta.Serie)
                oeCorrelativo.IdTipoDocumento = oeDocumentoVenta.IdTipoDocumento
                oeCorrelativo.Prefijo = oeDocumentoVenta.PrefijoID '@0001
                odCorrelativo.Guardar(oeCorrelativo)
                'Inicio Cuenta por cobrar
                If oeDocumentoVenta.TotalCredito > 0 Then
                    With oeCuentaPorCobrar
                        .TipoOperacion = "I"
                        .Id = String.Empty
                        .Codigo = String.Empty
                        .Tipo = "C"
                        .Concepto = "CUENTA POR COBRAR DE " & oeDocumentoVenta.TipoDocumento & " Nº: " _
                                    & oeDocumentoVenta.Serie & "-" & oeDocumentoVenta.Numero & " TOTAL: " _
                                    & oeDocumentoVenta.Moneda & oeDocumentoVenta.TotalFacturado

                        .IdAcreedor = oeDocumentoVenta.IdCliente
                        .IdDocumentoVenta = stResultado
                        .ImporteTotal = oeDocumentoVenta.TotalCredito
                        .ImporteAbonado = 0
                        .Saldo = oeDocumentoVenta.TotalCredito
                        .Cuotas = 0
                        .IdEstado = "GENERADO"
                        .FechaEmision = Date.Today
                        .FechaVencimiento = Date.Today
                        .UsuarioCreacion = oeDocumentoVenta.UsuarioCreacion
                        .Activo = True
                    End With
                    oeCuentaPorCobrar.PrefijoID = oeDocumentoVenta.PrefijoID '@0001
                    odCuentaPorCobrar.Guardar(oeCuentaPorCobrar)
                End If
                'Fin
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarDetalle(ByVal oeDocumentoVentaDetalle As e_DocumentoVentaDetalle) As Boolean
        Try
            With oeDocumentoVentaDetalle
                sqlhelper.ExecuteNonQuery("TES.Isp_DocumentoVentaDetalle_IAE", "I", .PrefijoID,
                                          .Id,
                                          .IdDocumentoVenta,
                                          .TipoReferencia,
                                          .IdReferencia,
                                          .Descripcion,
                                          .Cantidad,
                                          .Precio,
                                          .SubTotal,
                                          .UsuarioCreacion,
                                          .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeDocumentoVenta As e_DocumentoVenta) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_DocumentoVentaDetalle_IAE", "E", _
             "", oeDocumentoVenta.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class