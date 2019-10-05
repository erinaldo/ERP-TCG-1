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

Public Class d_MovCuentaCte

    Private sqlhelper As New SqlHelper

    Dim oeCuentaCte As New e_CuentaCorriente
    Dim odCuentaCte As New d_CuentaCorriente
    Dim oeSaldoCte As New e_SaldoCtaCorriente
    Dim odSaldoCte As New d_SaldoCtaCorriente
    Dim odMovCtaCte_Asiento As New d_MovCuentaCte_Asiento
    Dim oeMovCtaCteAsiento As New e_MovCuentaCte_Asiento
    Dim oeMovDocumento As New e_MovimientoDocumento
    Dim odMovDocumento As New d_MovimientoDocumento
    Dim oeTransferencia As New e_Transferencia
    Dim odTransferencia As New d_Transferencia


    Private Function Cargar(ByVal o_fila As DataRow) As e_MovCuentaCte
        Try
            Dim oeMovCuentaCte = New e_MovCuentaCte( _
                             o_fila("Id").ToString _
                             , o_fila("IdCuentaCorriente").ToString _
                             , o_fila("IdReferencia").ToString _
                             , o_fila("TipoReferencia").ToString _
                             , o_fila("IngresoEgreso").ToString _
                             , o_fila("Fecha") _
                             , o_fila("Referencia").ToString _
                             , o_fila("Proveedor").ToString _
                             , o_fila("Numero").ToString _
                             , o_fila("IdMoneda").ToString _
                             , o_fila("Importe") _
                             , o_fila("TipoCambio") _
                             , o_fila("Glosa").ToString _
                             , o_fila("Liquidado") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaCreacion") _
                             , o_fila("Activo") _
                             , o_fila("FechaLiquida") _
                             , o_fila("UsuarioLiquida").ToString _
            )
            Return oeMovCuentaCte
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMovCuentaCte As e_MovCuentaCte) As e_MovCuentaCte

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_MovCuentaCte_Listar", "", oeMovCuentaCte.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeMovCuentaCte = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeMovCuentaCte
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMovCuentaCte As e_MovCuentaCte) As List(Of e_MovCuentaCte)
        Try
            Dim ldMovCuentaCte As New List(Of e_MovCuentaCte)
            Dim ds As DataSet
            With oeMovCuentaCte
                ds = sqlhelper.ExecuteDataset("TES.Isp_MovCuentaCte_Listar", "" _
                        , .Id _
                        , .IdCuentaCorriente _
                        , .IdReferencia _
                        , .TipoReferencia _
                        , .IngresoEgreso _
                        , .Liquidado _
                        , .UsuarioCreacion _
                        , .FechaCreacion _
                        , .Activo _
                        , .FechaLiquida _
                        , .UsuarioLiquida _
                        )
            End With
            oeMovCuentaCte = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeMovCuentaCte = Cargar(o_Fila)
                ldMovCuentaCte.Add(oeMovCuentaCte)
            Next
            Return ldMovCuentaCte
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMovCuentaCte As e_MovCuentaCte, Optional ByVal UsaTransaccion As Boolean = True) As Boolean
        Try
            If UsaTransaccion Then
                Using transScope As New TransactionScope
                    GuardarMovCtaCte(oeMovCuentaCte)
                    transScope.Complete()
                End Using
            Else
                GuardarMovCtaCte(oeMovCuentaCte)
            End If
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMovCuentaCte As e_MovCuentaCte) As Boolean
        Try
            Dim stResultado() As String
            With oeMovCuentaCte
                stResultado = sqlhelper.ExecuteScalar("TES.Isp_MovCuentaCte_IAE", .TipoOperacion, .PrefijoID,
                      .Id _
                      , .IdCuentaCorriente _
                      , .Fecha _
                      , .Importe _
                      , .IdTipoDocumento _
                      , .Glosa _
                      , .IdReferencia _
                      , .TipoReferencia _
                      , .IngresoEgreso _
                      , .Liquidado _
                      , .UsuarioCreacion _
                      , .Activo _
                      , .FechaLiquida _
                      , .UsuarioLiquida
                  ).ToString.Split("_")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarMovCtaCte(ByVal oeMovCuentaCte As e_MovCuentaCte) As Boolean
        Try
            Dim odTransferencia As New d_Transferencia
            Dim odMovimientoDoc As New d_MovimientoDocumento
            Dim stResultado() As String
            With oeMovCuentaCte

                If oeMovCuentaCte.TipoOperacion = "I" Then
                    .oeTransferencia.PrefijoID = oeMovCuentaCte.PrefijoID '@0001
                    If oeMovCuentaCte.TipoReferencia = "0" Then
                        odTransferencia.Guardar(.oeTransferencia)
                        .IdReferencia = .oeTransferencia.Id
                    Else
                        .oeMovimientoDoc.PrefijoID = oeMovCuentaCte.PrefijoID '@0001
                        .oeAsiento.PrefijoID = oeMovCuentaCte.PrefijoID '@0001
                        If .Referencia <> "VALE" And .Referencia <> "SUSTENTO CONTABLE" Then
                            odMovimientoDoc.GuardarCompra(.oeMovimientoDoc, .oeAsiento)
                            .IdReferencia = .oeMovimientoDoc.Id
                        End If

                    End If
                End If

                stResultado = sqlhelper.ExecuteScalar("TES.Isp_MovCuentaCte_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdCuentaCorriente _
                        , .Fecha _
                        , .Importe _
                        , .IdTipoDocumento _
                        , .Glosa _
                        , .IdReferencia _
                        , .TipoReferencia _
                        , .IngresoEgreso _
                        , .Liquidado _
                        , .UsuarioCreacion _
                        , .Activo _
                        , .FechaLiquida _
                        , .UsuarioLiquida
                    ).ToString.Split("_")

                If Not .oeMovCuentaCte_Asiento Is Nothing Then
                    .oeMovCuentaCte_Asiento.PrefijoID = oeMovCuentaCte.PrefijoID '@0001
                    .oeAsiento.PrefijoID = oeMovCuentaCte.PrefijoID '@0001
                    If .oeMovCuentaCte_Asiento.TipoOperacion = "I" Then
                        .oeMovCuentaCte_Asiento.IdMovCuentaCte = stResultado(0)
                        odMovCtaCte_Asiento.Guardar(.oeMovCuentaCte_Asiento, .oeAsiento)
                    End If
                End If

            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarLista(ByVal leMovCuentaCte As List(Of e_MovCuentaCte)) As Boolean
        Try
            Using TransScope As New TransactionScope()

                Dim ingreso As Double = 0
                Dim egreso As Double = 0

                Dim leMov As New List(Of e_MovCuentaCte)
                Dim leMovCtaCte As New List(Of e_MovCuentaCte)

                leMov = leMovCuentaCte.Where(Function(item) item.TipoOperacion <> "E").ToList
                leMovCtaCte = leMovCuentaCte.Where(Function(item) item.TipoOperacion <> "").ToList

                For Each oeMovCtaCte As e_MovCuentaCte In leMovCtaCte
                    If oeMovCtaCte.TipoOperacion = "E" Then
                        Eliminar(oeMovCtaCte)
                    Else
                        Guardar(oeMovCtaCte, False)
                    End If
                Next

                For Each oeMovCtaCte As e_MovCuentaCte In leMov
                    If oeMovCtaCte.IdMoneda = "1CH01" Then
                        ingreso = ingreso + oeMovCtaCte.Ingreso
                        egreso = egreso + oeMovCtaCte.Egreso
                    Else
                        ingreso = ingreso + (oeMovCtaCte.Ingreso * oeMovCtaCte.TipoCambio)
                        egreso = egreso + (oeMovCtaCte.Egreso * oeMovCtaCte.TipoCambio)
                    End If
                Next
                If leMovCtaCte.Count > 0 Then
                    If leMovCtaCte(0).TipoOperacion <> "L" Then
                        oeCuentaCte = New e_CuentaCorriente
                        oeCuentaCte.TipoOperacion = "S"
                        oeCuentaCte.Saldo = ingreso - egreso
                        oeCuentaCte.Id = leMovCtaCte(0).IdCuentaCorriente
                        odCuentaCte.Guardar(oeCuentaCte)
                        oeSaldoCte = New e_SaldoCtaCorriente
                        oeSaldoCte.TipoOperacion = "S"
                        oeSaldoCte.Monto = ingreso
                        oeSaldoCte.Saldo = ingreso - egreso
                        oeSaldoCte.Liquidado = 0
                        oeSaldoCte.TipoCuenta = 2
                        oeSaldoCte.IdCuentaCorriente = leMovCtaCte(0).IdCuentaCorriente
                        odSaldoCte.Guardar(oeSaldoCte)
                    Else
                        oeSaldoCte = New e_SaldoCtaCorriente
                        oeSaldoCte.TipoOperacion = "L"
                        oeSaldoCte.Liquidado = 0
                        oeSaldoCte.TipoCuenta = 2
                        oeSaldoCte.IdCuentaCorriente = leMov(0).IdCuentaCorriente
                        oeSaldoCte.UsuarioLiquida = leMov(0).UsuarioLiquida
                        odSaldoCte.Guardar(oeSaldoCte)

                        oeSaldoCte = New e_SaldoCtaCorriente
                        oeSaldoCte.TipoOperacion = "I"
                        oeSaldoCte.IdCuentaCorriente = leMov(0).IdCuentaCorriente
                        oeSaldoCte.Liquidado = 0
                        oeSaldoCte.Monto = 0
                        oeSaldoCte.TipoCuenta = 2
                        oeSaldoCte.UsuarioCreacion = leMov(0).UsuarioLiquida

                        odSaldoCte.Guardar(oeSaldoCte)
                    End If
                End If

                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeMovCuentaCte As e_MovCuentaCte) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_MovCuentaCte_IAE", "E", "", oeMovCuentaCte.Id)
            If Not oeMovCuentaCte.oeAsiento Is Nothing Then
                If oeMovCuentaCte.oeAsiento.Id <> "" Then
                    Dim odAsiento As New d_Asiento
                    odAsiento.Eliminar(oeMovCuentaCte.oeAsiento)
                    oeMovCtaCteAsiento = New e_MovCuentaCte_Asiento
                    oeMovCtaCteAsiento.IdMovCuentaCte = oeMovCuentaCte.Id
                    odMovCtaCte_Asiento.Eliminar(oeMovCtaCteAsiento)
                End If
            End If
            If oeMovCuentaCte.TipoReferencia = "0" Then
                oeTransferencia = New e_Transferencia
                oeTransferencia.Id = oeMovCuentaCte.IdReferencia
                odTransferencia.Eliminar(oeTransferencia)
            Else
                oeMovDocumento = New e_MovimientoDocumento
                oeMovDocumento.Id = oeMovCuentaCte.IdReferencia
                odMovDocumento.EliminarDocumentoyPago(oeMovDocumento)
            End If
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function UltimoIdInserta(ByVal PrefijoID As String) As String
        Try
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "TES.MovCuentaCte", PrefijoID
                                  )
            Return IIf(stResultado Is Nothing, PrefijoID & "000000000001", stResultado)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarMasivo(ByVal DtMD As Data.DataTable, ByVal DtCOM As Data.DataTable, ByVal DtMCC As Data.DataTable, _
                                  ByVal DtAC As Data.DataTable, ByVal DtAMD As Data.DataTable, ByVal DtAM As Data.DataTable, _
                                  ByVal DtAMMD As Data.DataTable, ByVal DtMA As Data.DataTable, ByVal DtMCCA As Data.DataTable) As Boolean
        Try
            Dim odAsientoMov As New d_AsientoMovimiento, odAsiMovDoc As New d_AsientoMov_MovDoc
            Using TransScope As New TransactionScope()
                sqlhelper.InsertarMasivo("CON.MovimientoDocumento", DtMD, False)
                sqlhelper.InsertarMasivo("CON.Compra", DtCOM, False)
                sqlhelper.InsertarMasivo("TES.MovCuentaCte", DtMCC, False)
                sqlhelper.InsertarMasivo("CON.Asiento", DtAC, False)
                sqlhelper.InsertarMasivo("CON.Asiento_MovDoc", DtAMD, False)
                sqlhelper.InsertarMasivo("CON.AsientoMovimiento", DtAM, False)
                sqlhelper.InsertarMasivo("CON.AsientoMov_MovDoc", DtAMMD, False)
                sqlhelper.InsertarMasivo("CON.MovimientoAnalisis", DtMA, False)
                sqlhelper.InsertarMasivo("TES.MovCuentaCte_Asiento", DtMCCA, False)
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function EliminarLista(ByVal leMovCuentaCte As List(Of e_MovCuentaCte)) As Boolean
        Try
            Using TransScope As New TransactionScope()
                For Each _oeMovCuentaCte In leMovCuentaCte
                    With _oeMovCuentaCte
                        sqlhelper.ExecuteScalar("TES.Isp_MovCuentaCte_IAE", "X", "", _
                            .Id _
                            , .IdCuentaCorriente _
                            , .Fecha _
                            , .Importe _
                            , .IdTipoDocumento _
                            , .Glosa _
                            , .IdReferencia _
                            , .TipoReferencia _
                            , .IngresoEgreso _
                            , .Liquidado _
                            , .UsuarioCreacion _
                            , .Activo _
                            , .FechaLiquida _
                            , .UsuarioLiquida _
                        )
                    End With
                Next
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDocumentos(ByVal oeMovCuentaCte As e_MovCuentaCte) As List(Of e_MovimientoDocumento)
        Try
            Dim ldMovimientoDocumento As New List(Of e_MovimientoDocumento)
            Dim ds As DataSet
             With oeMovCuentaCte
                ds = sqlhelper.ExecuteDataset("TES.Isp_MovCuentaCte_Listar", .TipoOperacion _
                        , .Id _
                        , .IdCuentaCorriente _
                        , .IdReferencia _
                        , .TipoReferencia _
                        , .IngresoEgreso _
                        , .Liquidado _
                        , .UsuarioCreacion _
                        , .FechaCreacion _
                        , .Activo _
                        , .FechaLiquida _
                        , .UsuarioLiquida _
                        )
            End With
            oeMovDocumento = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMovDocumento = odMovDocumento.Cargar(o_Fila)
                    ldMovimientoDocumento.Add(oeMovDocumento)
                Next
            End If
            Return ldMovimientoDocumento
        Catch ex As Exception
            Throw
        End Try
    End Function


End Class
