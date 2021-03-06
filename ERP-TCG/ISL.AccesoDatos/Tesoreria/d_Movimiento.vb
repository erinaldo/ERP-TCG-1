﻿'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_Movimiento

    Private sqlhelper As New SqlHelper
    Public strIdMovimiento As String = ""
    Dim oeMovimiento_Viaje As New e_Movimiento_Viaje
    Dim odMovimiento_Viaje As New d_Movimiento_Viaje
    Dim odMovimiento_Flete As New d_Movimiento_Flete
    Dim oeMovimientoFlete As New e_Movimiento_Flete
    Dim Correlativo As Boolean

    Dim oeCajaMonto As New e_CajaMonto
    Dim odCajaMonto As New d_CajaMonto
    Dim oeCorrelativo As New e_Correlativo
    Dim odCorrelativo As New d_Correlativo
    Dim oeTipodocumento As New e_TipoDocumento
    Dim odTipoDocumento As New d_TipoDocumento
    Dim oeChequeEmitido As New e_ChequeEmitido
    Dim odChequeEmitido As New d_ChequeEmitido
    Dim odChequexCobrar As New d_ChequexCobrar
    Dim oeCuentaCorriente As New e_CuentaCorriente
    Dim odCuentaCorriente As New d_CuentaCorriente

    Private Function Cargar(ByVal o_fila As DataRow) As e_Movimiento
        Try
            Dim oeMovimiento = New e_Movimiento( _
                             o_fila("Id").ToString _
                             , o_fila("Fecha") _
                             , o_fila("IdCuentaCorrienteOrigen").ToString _
                             , o_fila("IdCuentaCorrienteDestino").ToString _
                             , o_fila("Ingreso").ToString _
                             , o_fila("Egreso").ToString _
                             , o_fila("Saldo").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("Voucher").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Descuento").ToString _
                             , o_fila("TipoMovimiento").ToString _
                             , o_fila("IdEstado").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("TipoTransa").ToString _
                             , o_fila("IndPrestamoHab").ToString _
                             , o_fila("SaldoPorDepositar") _
            )
            Return oeMovimiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CargarMovimiento(ByVal o_fila As DataRow) As e_Movimiento
        Try

            Dim oeMovimiento = New e_Movimiento(o_fila("IdMovimiento").ToString _
                                                , o_fila("IdMovimientoViaje").ToString _
                                                , o_fila("IdViaje").ToString _
                                                , o_fila("NombreCompleto").ToString _
                                                , o_fila("IdCuentaCorrienteOrigen").ToString _
                             , o_fila("IdCuentaCorrienteDestino").ToString _
                             , o_fila("Viaje").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("UsuarioAutoriza").ToString _
                             , o_fila("Importe") _
                             , o_fila("Fecha") _
                             , o_fila("IndAdministrativo").ToString)
            Return oeMovimiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerMovimiento(ByVal oeMovimiento As e_Movimiento) As e_Movimiento
        Try

            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_Movimiento_Listar", oeMovimiento.TipoOperacion, _
             oeMovimiento.Id)
            oeMovimiento = New e_Movimiento
            If ds.Tables(0).Rows.Count > 0 Then
                oeMovimiento = CargarMovimiento(ds.Tables(0).Rows(0))
            End If
            Return oeMovimiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMovimiento As e_Movimiento) As e_Movimiento
        Try

            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_Movimiento_Listar", oeMovimiento.TipoOperacion, _
             oeMovimiento.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeMovimiento = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeMovimiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeMovimiento As e_Movimiento) As List(Of e_Movimiento)
        Try

            Dim ldMovimiento As New List(Of e_Movimiento)
            Dim ds As DataSet
            With oeMovimiento
                ds = sqlhelper.ExecuteDataset("TES.Isp_Movimiento_Listar", "" _
                        , .Id _
                        , .Activo _
                        )
            End With
            oeMovimiento = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMovimiento = Cargar(o_Fila)
                    ldMovimiento.Add(oeMovimiento)
                Next
            End If
            Return ldMovimiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDscto(ByVal oeMovimiento As e_Movimiento) As List(Of e_Movimiento)
        Try

            Dim ldMovimiento As New List(Of e_Movimiento)
            Dim ds As DataSet
            With oeMovimiento
                ds = sqlhelper.ExecuteDataset("TES.Isp_Movimiento_Listar", .TipoOperacion, .Id, .Activo)
            End With
            oeMovimiento = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMovimiento = CargarMovimiento(o_Fila)
                    ldMovimiento.Add(oeMovimiento)
                Next
            End If
            Return ldMovimiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarDsctoExtorno(ByVal oeMovimiento As e_Movimiento) As Boolean
        Try
            Dim strCorrelativo As String = ""
            With oeMovimiento
                If .TipoMovimiento = 2 Then
                    strCorrelativo = CargarCorrelativoLocal("VALE", .PrefijoID)
                    GrabarCorrelativo(strCorrelativo, "VALE", .PrefijoID)
                End If
                Using transScope As New TransactionScope()
                    strIdMovimiento = sqlhelper.ExecuteScalar("TES.Isp_Movimiento_IAE", .TipoOperacion,
                                                              .PrefijoID,
                                                  .Id _
                                                , .Fecha _
                                                , .IdCuentaCorrienteOrigen _
                                                , .IdCuentaCorrienteDestino _
                                                , .Ingreso _
                                                , .Egreso _
                                                , .Saldo _
                                                , .Glosa _
                                                , strCorrelativo _
                                                , .UsuarioCreacion _
                                                , .Descuento _
                                                , .TipoMovimiento _
                                                , .IdEstado _
                                                , .Activo _
                                                , .TipoTransa _
                                                , .AsignadoGrupo _
                                                , .IndPrestamoHab _
                                                , .Depositado _
                                                , .SaldoPorDepositar _
                                                , .IndCerrado _
                                                , .Concepto _
                                                , Date.Parse("01/01/1901") _
                                                , .NroCuotas, .IdCaja)
                    If .oeMovimientoViaje.IdViaje <> "" Then
                        .oeMovimientoViaje.IdMovimiento = strIdMovimiento
                        .oeMovimientoViaje.TipoOperacion = "I"
                        .oeMovimientoViaje.PrefijoID = oeMovimiento.PrefijoID '@0001
                        odMovimiento_Viaje.Guardar(.oeMovimientoViaje)
                    End If
                    .Id = strIdMovimiento
                    transScope.Complete()
                End Using
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarSimple(ByVal oeMovimiento As e_Movimiento) As Boolean
        Try
            With oeMovimiento
                sqlhelper.ExecuteNonQuery("TES.Isp_Movimiento_IAE", .TipoOperacion,
                                                          .PrefijoID,
                                              .Id, .Fecha, .IdCuentaCorrienteOrigen, .IdCuentaCorrienteDestino _
                                            , .Ingreso, .Egreso, .Saldo, .Glosa, .Voucher, .UsuarioCreacion _
                                            , .Descuento, .TipoMovimiento, .IdEstado, .Activo, .TipoTransa _
                                            , .AsignadoGrupo, .IndPrestamoHab, .Depositado, .SaldoPorDepositar _
                                            , .IndCerrado, "", .FechaCierre, .NroCuotas, .IdCaja)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarDobleMovimiento(ByVal loMovimiento As List(Of e_Movimiento), ByVal oeMov As e_Movimiento) As Boolean
        Try
            Using transScope As New TransactionScope
                If oeMov.Id <> "" Then ActualizarMovimiento(oeMov)
                For Each mov As e_Movimiento In loMovimiento
                    mov.PrefijoID = oeMov.PrefijoID '@0001
                    GuardarMovimiento(mov, New e_Movimiento)
                Next
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ActualizarMovimiento(oeMovimiento As e_Movimiento) As Boolean
        Try
            sqlhelper.ExecuteDataset("TES.Isp_Movimiento_IAE", oeMovimiento.TipoOperacion, oeMovimiento.PrefijoID,
                             oeMovimiento.Id, Date.Parse("01/01/1901"), String.Empty, String.Empty, 0, 0, 0 _
                           , String.Empty, String.Empty, String.Empty, 0, 0, oeMovimiento.IdEstado)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function LiquidarHabilitar(ByVal oeMovimiento As e_Movimiento) As Boolean
        Try
            With oeMovimiento
                sqlhelper.ExecuteNonQuery("TES.Isp_Movimiento_IAE", .TipoOperacion, .PrefijoID, .Id)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function LiquidarHabilitarLista(ByVal loMovimiento As List(Of e_Movimiento)) As Boolean
        Try
            Using transScope As New TransactionScope
                For Each mov As e_Movimiento In loMovimiento
                    LiquidarHabilitar(mov)
                Next
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarMovimiento(oeMovimiento As e_Movimiento, oeMov As e_Movimiento) As Boolean
        Try
            Dim IdMovimiento As String = ""
            Dim strCorrelativo As String = ""
            Using transScope As New TransactionScope
                If oeMov.Id <> "" Then ActualizarMovimiento(oeMov)
                With oeMovimiento
                    If .IndicadorCorrelativo Then
                        If .TipoTransa = 4 Then
                            strCorrelativo = CargarCorrelativo("VALE", .PrefijoID, 1)
                            GrabarCorrelativo(strCorrelativo, "VALE", .PrefijoID, 1)
                        Else
                            strCorrelativo = CargarCorrelativo("VALE", .PrefijoID)
                            GrabarCorrelativo(strCorrelativo, "VALE", .PrefijoID)
                        End If
                    End If
                    IdMovimiento = sqlhelper.ExecuteScalar("TES.Isp_Movimiento_IAE", .TipoOperacion, .PrefijoID,
                                                  .Id, .Fecha, .IdCuentaCorrienteOrigen, .IdCuentaCorrienteDestino, .Ingreso, .Egreso _
                                                , .Saldo, .Glosa, strCorrelativo, .UsuarioCreacion, .Descuento, .TipoMovimiento, .IdEstado _
                                                , .Activo, .TipoTransa, .AsignadoGrupo, .IndPrestamoHab, .Depositado, .SaldoPorDepositar _
                                                , 0, .Concepto, Date.Parse("01/01/1901"), .NroCuotas, .IdCaja)
                    .Id = IdMovimiento
                    If .oeMovimientoViaje.IdViaje <> "" Then
                        .oeMovimientoViaje.IdMovimiento = IdMovimiento
                        .oeMovimientoViaje.TipoOperacion = .TipoOperacion
                        .oeMovimientoViaje.PrefijoID = oeMovimiento.PrefijoID '@0001
                        odMovimiento_Viaje.Guardar(.oeMovimientoViaje)
                    End If
                    If .oeMovimientoFlete.IdViaje <> "" Then
                        .oeMovimientoFlete.IdMovimiento = IdMovimiento
                        .oeMovimientoFlete.TipoOperacion = "I"
                        .oeMovimientoFlete.PrefijoID = oeMovimiento.PrefijoID '@0001
                        odMovimiento_Flete.Guardar(.oeMovimientoFlete)
                    End If
                    If .TipoProceso = "HABILITACION_CUENTA" Then
                        oeChequeEmitido.TipoOperacion = "D"
                        oeChequeEmitido.Fecha = Date.Parse("01/01/1901")
                        oeChequeEmitido.FechaCobro = Date.Parse("01/01/1901")
                        oeChequeEmitido.FechaCreacion = Date.Parse("01/01/1901")
                        oeChequeEmitido.IdCuentaCorriente = .IdCuentaCorrienteDestino
                        oeChequeEmitido.Id = .IdCheque
                        oeChequeEmitido.IdEstado = "1CH00032"
                        oeChequeEmitido.PrefijoID = oeMovimiento.PrefijoID '@0001
                        odChequeEmitido.Guardar(oeChequeEmitido)
                    End If
                End With
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CargarCorrelativo(ByVal TipoDocumento As String, ByVal PrefijoID As String, Optional ByVal Tipo As Integer = 0) As String
        Dim Numero As String = ""
        oeTipodocumento.TipoOperacion = "B"
        oeTipodocumento.Nombre = TipoDocumento
        oeTipodocumento = odTipoDocumento.Obtener(oeTipodocumento)
        oeCorrelativo.TipoOperacion = "1"
        oeCorrelativo.Prefijo = PrefijoID
        oeCorrelativo.IdTipoDocumento = oeTipodocumento.Id
        oeCorrelativo.Tipo = Tipo
        oeCorrelativo = odCorrelativo.ObtenerLocal(oeCorrelativo)
        Numero = oeCorrelativo.Numero + 1
        Do While Len(Numero) < 10
            Numero = 0 & Numero
        Loop
        Return Numero
    End Function

    Private Function CargarCorrelativoLocal(ByVal TipoDocumento As String, ByVal PrefijoID As String) As String
        Dim Numero As String = ""
        oeTipodocumento.TipoOperacion = "B"
        oeTipodocumento.Nombre = TipoDocumento
        oeTipodocumento = odTipoDocumento.Obtener(oeTipodocumento)
        oeCorrelativo.TipoOperacion = "1"
        oeCorrelativo.Prefijo = PrefijoID
        oeCorrelativo.IdTipoDocumento = oeTipodocumento.Id
        oeCorrelativo = odCorrelativo.ObtenerLocal(oeCorrelativo)
        Numero = oeCorrelativo.Numero + 1
        Do While Len(Numero) < 10
            Numero = 0 & Numero
        Loop
        Return Numero
    End Function

    Private Function GrabarCorrelativo(ByVal Numero As String, ByVal TipoDocumento As String, ByVal PrefijoID As String, Optional ByVal Tipo As Integer = 0) As Boolean
        Try
            oeTipodocumento.TipoOperacion = "B"
            oeTipodocumento.Nombre = TipoDocumento
            oeTipodocumento = odTipoDocumento.Obtener(oeTipodocumento)
            Select Case PrefijoID
                Case "1CH"
                    oeCorrelativo.Serie = 1
                Case "1PY"
                    oeCorrelativo.Serie = 2
                Case "1LI"
                    oeCorrelativo.Serie = 3
                Case "1SA"
                    oeCorrelativo.Serie = 4
                Case "1LU"
                    oeCorrelativo.Serie = 5
                Case "1SI"
                    oeCorrelativo.Serie = 9
            End Select
            If Numero = "" Then
                Return False
            Else
                oeCorrelativo.TipoOperacion = "I"
                oeCorrelativo.Numero = CInt(Numero)
                oeCorrelativo.Prefijo = PrefijoID
                oeCorrelativo.PrefijoID = PrefijoID
                oeCorrelativo.IdTipoDocumento = oeTipodocumento.Id
                oeCorrelativo.Tipo = Tipo
                If odCorrelativo.GuardarLocal(oeCorrelativo) Then Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function GrabarCorrelativo1(ByVal Numero As String, ByVal TipoDocumento As String, ByVal PrefijoID As String) As Boolean
        Try
            oeTipodocumento.TipoOperacion = "B"
            oeTipodocumento.Nombre = TipoDocumento
            oeTipodocumento = odTipoDocumento.Obtener(oeTipodocumento)
            Select Case PrefijoID
                Case "1CH"
                    oeCorrelativo.Serie = 1
                Case "1PY"
                    oeCorrelativo.Serie = 2
                Case "1LI"
                    oeCorrelativo.Serie = 3
                Case "1SA"
                    oeCorrelativo.Serie = 4
                Case "1LU"
                    oeCorrelativo.Serie = 5
                Case "1SI"
                    oeCorrelativo.Serie = 9
            End Select
            If Numero = "" Then
                Return False
            Else
                oeCorrelativo.TipoOperacion = "I"
                oeCorrelativo.Numero = CInt(Numero)
                oeCorrelativo.Prefijo = PrefijoID
                oeCorrelativo.IdTipoDocumento = oeTipodocumento.Id
                If odCorrelativo.GuardarLocal(oeCorrelativo) Then Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeMovimiento As e_Movimiento) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_Movimiento_IAE", "E", _
             "", oeMovimiento.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class