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

Public Class d_Asiento
    Private sqlhelper As New SqlHelper

    Private odMovimientoCajaBanco As New d_MovimientoCajaBanco

    Private Function Cargar(ByVal o_fila As DataRow) As e_Asiento
        Try
            Dim oeAsiento = New e_Asiento(
                             o_fila("Id").ToString _
                             , o_fila("IdPeriodo").ToString _
                             , o_fila("IdTipoAsiento").ToString _
                             , o_fila("NroAsiento").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("GlosaImprime").ToString _
                             , o_fila("IdMoneda").ToString _
                             , o_fila("TipoCambio").ToString _
                             , o_fila("TotalDebe").ToString _
                             , o_fila("TotalHaber").ToString _
                             , o_fila("IdUsuarioBloquea").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("IdEstado").ToString _
                             , o_fila("IdAsientoExtorno").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("IndOrigen").ToString _
                             , o_fila("IdentificaAsiento").ToString)
            Return oeAsiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeAsiento As e_Asiento) As e_Asiento
        Try
            Dim ds As DataSet
            With oeAsiento
                ds = sqlhelper.ExecuteDataset("CON.ISP_Asiento_Listar",
                                                .TipoOperacion,
                                                .Id,
                                                .IdPeriodo,
                                                .IdTipoAsiento,
                                                .NroAsiento,
                                                .Fecha,
                                                .Glosa)
            End With

            If ds.Tables(0).Rows.Count > 0 Then
                oeAsiento = Cargar(ds.Tables(0).Rows(0))
                Dim oeAsientoMov As New e_AsientoMovimiento
                Dim olAsientoMov As New d_AsientoMovimiento
                oeAsientoMov.IdAsiento = oeAsiento.Id
                oeAsientoMov.Activo = True
                oeAsiento.AsientoMovimiento.AddRange(olAsientoMov.Listar(oeAsientoMov))
            Else
                oeAsiento = New e_Asiento
            End If
            Return oeAsiento
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener2(ByVal oeAsiento As e_Asiento) As e_Asiento
        Try
            Dim ds As DataSet
            With oeAsiento
                ds = sqlhelper.ExecuteDataset("CON.ISP_Asiento_Listar",
                                                .TipoOperacion,
                                                .Id,
                                                .IdPeriodo,
                                                .IdTipoAsiento,
                                                .NroAsiento,
                                                .Fecha,
                                                .Glosa)
                If ds.Tables(0).Rows.Count > 0 Then
                    oeAsiento = Cargar(ds.Tables(0).Rows(0))
                End If
            End With
            Return oeAsiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeAsiento As e_Asiento) As List(Of e_Asiento)
        Try
            Dim ldAsiento As New List(Of e_Asiento)
            Dim ds As DataSet
            With oeAsiento
                ds = sqlhelper.ExecuteDataset("CON.ISP_Asiento_Listar", .TipoOperacion _
                        , .Id _
                        , .IdPeriodo _
                        , .IdTipoAsiento _
                        , .NroAsiento _
                        , .Fecha _
                        , .Glosa _
                        , .GlosaImprime _
                        , .IdMoneda _
                        , .TipoCambio _
                        , .TotalDebe _
                        , .TotalHaber _
                        , .IdUsuarioBloquea _
                        , .IdUsuarioCrea _
                        , .IdEstado _
                        , .IdAsientoExtorno _
                        , .FechaCreacion _
                        , .Activo _
                        , .IdentificaAsiento
                        )
            End With
            oeAsiento = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeAsiento = Cargar(o_Fila)
                    ldAsiento.Add(oeAsiento)
                Next
            End If
            Return ldAsiento
        Catch ex As Exception
            Throw
        End Try
    End Function

#Region "Guardar Asiento"

    Public Function Guardar(ByRef oeAsiento As e_Asiento, idAsientoDocCmp As String, Optional ByVal UsaTransaccion As Boolean = True) As Boolean
        Try
            If UsaTransaccion Then
                Using transScope As New TransactionScope
                    GuardarAsiento(oeAsiento, idAsientoDocCmp)
                    transScope.Complete()
                End Using
            Else
                GuardarAsiento(oeAsiento)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function GuardarAsiento(ByRef oeAsiento As e_Asiento, Optional idAsientoDocCmp As String = Nothing) As Boolean
        Try
            Dim stResultado() As String
            With oeAsiento
                stResultado = sqlhelper.ExecuteScalar("CON.Isp_Asiento_IAE", .TipoOperacion, .PrefijoID,
                         .Id _
                        , .IdPeriodo _
                        , .IdTipoAsiento _
                        , .NroAsiento _
                        , .Fecha _
                        , .Glosa _
                        , .GlosaImprime _
                        , .IdMoneda _
                        , .TipoCambio _
                        , .TotalDebe _
                        , .TotalHaber _
                        , .IdUsuarioBloquea _
                        , .IdUsuarioCrea _
                        , .IdEstado _
                        , .IdAsientoExtorno _
                        , .FechaCreacion _
                        , .Activo _
                        , .IdentificaAsiento _
                        , .IndOrigen).ToString.Split("_")

                oeAsiento.Id = stResultado(0)
                Dim ls_IdDocumentoRetencion As String = ""
                Dim odAsientoMov As New d_AsientoMovimiento
                'detalle de asiento
                For Each oeAsientoMovimiento As e_AsientoMovimiento In .AsientoMovimiento
                    oeAsientoMovimiento.PrefijoID = oeAsiento.PrefijoID '@0001
                    With oeAsientoMovimiento
                        .IdAsiento = stResultado(0)
                        If oeAsiento._IdMovimientoCajaBanco <> "" Then
                            If Not oeAsientoMovimiento.MovimientoDocumento Is Nothing Then
                                oeAsientoMovimiento.MovimientoDocumento._idMovimientoCajaBanco = oeAsiento._IdMovimientoCajaBanco
                            End If
                            If Not oeAsientoMovimiento.ObligacionFinanciera Is Nothing Then
                                oeAsientoMovimiento.ObligacionFinanciera._IdMovimientoCajaBanco = oeAsiento._IdMovimientoCajaBanco
                            End If
                        End If
                        If Not .MovimientoDocumento Is Nothing Then
                            If Not .MovimientoDocumento.CuentaxCyP Is Nothing Then
                                If Not .MovimientoDocumento.CuentaxCyP.CuentaxPDocumentoRetencion Is Nothing Then
                                    .MovimientoDocumento.CuentaxCyP.PrefijoID = oeAsiento.PrefijoID '@0001
                                    .MovimientoDocumento.CuentaxCyP.CuentaxPDocumentoRetencion.IdDocumentoRetencion = ls_IdDocumentoRetencion
                                End If
                            End If
                            .MovimientoDocumento.PrefijoID = oeAsiento.PrefijoID '@0001
                        End If
                        If .TipoOperacion = "I" Or .TipoOperacion = "A" Or .TipoOperacion = "S" Then 'inserta, actualiza,modificacion de Saldo
                            If .BandGuardMasivo Then
                                'para caso de que se inserte en masivo en movimiento analisis
                                'aqui debe ingresar solo movmientos relaacionados a movimientos analisis
                                odAsientoMov.GuardarMasivo(oeAsientoMovimiento)
                            Else
                                odAsientoMov.Guardar(oeAsientoMovimiento)
                            End If
                            If oeAsientoMovimiento._IdMovimientoCajaBanco <> "" Then
                                'para caso de pago cobros con cta 10, traigo su id para relacionde de cuentaxCyP
                                oeAsiento._IdMovimientoCajaBanco = oeAsientoMovimiento._IdMovimientoCajaBanco
                            End If
                            If Not oeAsientoMovimiento.DocumentoRetencion Is Nothing Then
                                oeAsientoMovimiento.DocumentoRetencion.PrefijoID = oeAsiento.PrefijoID '@0001
                                If ls_IdDocumentoRetencion = "" Then
                                    ls_IdDocumentoRetencion = oeAsientoMovimiento.DocumentoRetencion.Id
                                    oeAsiento.IdRetencion = ls_IdDocumentoRetencion
                                End If
                            End If
                        ElseIf .TipoOperacion = "E" Then
                            odAsientoMov.Eliminar(oeAsientoMovimiento)
                            If Not .MovimientoDocumento Is Nothing Then 'cuando se inserta asiento y documento
                                If .MovimientoDocumento.TipoOperacion <> "" Then 'movimiento documento, llama proceso de movimiento documento
                                    Dim odMovDoc As New d_MovimientoDocumento
                                    Dim oeMovDoc As New e_MovimientoDocumento
                                    oeMovDoc = .MovimientoDocumento
                                    If .MovimientoDocumento.TipoOperacion = "E" Then
                                        odMovDoc.Eliminar(oeMovDoc)
                                    End If
                                End If
                            End If
                        End If
                    End With
                Next
                'relacion asiento y movimiento documento para compras y ventas
                If .Asiento_MovDoc.IdMovimientoDocumento <> "" Then
                    .Asiento_MovDoc.IdAsiento = stResultado(0)
                    Dim odAsientoMovDoc As New d_Asiento_MovDoc
                    .Asiento_MovDoc.PrefijoID = oeAsiento.PrefijoID '@0001
                    odAsientoMovDoc.Guardar(.Asiento_MovDoc)
                End If
                If Not idAsientoDocCmp Is String.Empty And Not idAsientoDocCmp Is Nothing Then
                    Dim odAsiento_Existencia As New d_Asiento_Existencia
                    Dim oeAsiento_Existencia As New e_Asiento_Existencia
                    With oeAsiento_Existencia
                        .TipoOperacion = "I"
                        .IdAsientoDoc = idAsientoDocCmp
                        .IdAsientoExis = oeAsiento.Id
                        .IdUsuarioCrea = oeAsiento.IdUsuarioCrea
                        .Activo = True
                    End With
                    oeAsiento_Existencia.PrefijoID = oeAsiento.PrefijoID '@0001
                    odAsiento_Existencia.Guardar(oeAsiento_Existencia)
                End If
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarAsientoContable(ByRef oeAsiento As e_Asiento) As Boolean
        Try
            Dim stResultado() As String
            With oeAsiento
                stResultado = sqlhelper.ExecuteScalar("CON.Isp_Asiento_IAE",
                                                      .TipoOperacion,
                                                      .PrefijoID,
                                                         .Id _
                                                        , .IdPeriodo _
                                                        , .IdTipoAsiento _
                                                        , .NroAsiento _
                                                        , .Fecha _
                                                        , .Glosa _
                                                        , .GlosaImprime _
                                                        , .IdMoneda _
                                                        , .TipoCambio _
                                                        , .TotalDebe _
                                                        , .TotalHaber _
                                                        , .IdUsuarioBloquea _
                                                        , .IdUsuarioCrea _
                                                        , .IdEstado _
                                                        , .IdAsientoExtorno _
                                                        , .FechaCreacion _
                                                        , .Activo _
                                                        , .IdentificaAsiento _
                                                        , .IndOrigen).ToString.Split("_")
                oeAsiento.Id = stResultado(0)
            End With

            If Not oeAsiento.Asiento_MovDoc Is Nothing Then
                Dim odAsiento_MovDoc As New d_Asiento_MovDoc
                oeAsiento.Asiento_MovDoc.IdAsiento = oeAsiento.Id
                oeAsiento.Asiento_MovDoc.PrefijoID = oeAsiento.PrefijoID '@0001
                odAsiento_MovDoc.Guardar(oeAsiento.Asiento_MovDoc)
            End If

            For Each obj In oeAsiento.AsientoMovimiento
                obj.IdAsiento = oeAsiento.Id
                Dim odAsientoMovimiento As New d_AsientoMovimiento
                obj.PrefijoID = oeAsiento.PrefijoID '@0001
                odAsientoMovimiento.Guardar(obj)
                If Not obj.MovimientoCajaBanco Is Nothing Then
                    oeAsiento._IdMovimientoCajaBanco = obj.MovimientoCajaBanco.Id
                End If
            Next
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

#End Region

    Public Function GuardarAplicacion(ByRef oeAsiento As e_Asiento, ByVal leMovAnalisis As List(Of e_MovimientoAnalisis)) As Boolean
        Try
            Dim odMovAnalis As New d_MovimientoAnalisis
            Using transScope As New TransactionScope
                For Each obj As e_MovimientoAnalisis In leMovAnalisis
                    obj.PrefijoID = oeAsiento.PrefijoID '@0001
                    odMovAnalis.Guardar(obj)
                Next
                Guardar(oeAsiento, False)
                transScope.Complete()
            End Using

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarMasivo(ByVal oeAsiento As e_Asiento) As Boolean
        Try
            Dim stResultado() As String
            Using transScope As New TransactionScope()
                With oeAsiento
                    stResultado = sqlhelper.ExecuteScalar("CON.Isp_Asiento_IAE", .TipoOperacion, .PrefijoID,
                            .Id _
                            , .IdPeriodo _
                            , .IdTipoAsiento _
                            , .NroAsiento _
                            , .Fecha _
                            , .Glosa _
                            , .GlosaImprime _
                            , .IdMoneda _
                            , .TipoCambio _
                            , .TotalDebe _
                            , .TotalHaber _
                            , .IdUsuarioBloquea _
                            , .IdUsuarioCrea _
                            , .IdEstado _
                            , .IdAsientoExtorno _
                            , .FechaCreacion _
                            , .Activo _
                            , .IdentificaAsiento _
                            , .IndOrigen
                        ).ToString.Split("_")
                    oeAsiento.Id = stResultado(0)
                    Dim odAsientoMov As New d_AsientoMovimiento
                    For Each oeAsientomovimiento As e_AsientoMovimiento In .AsientoMovimiento
                        With oeAsientomovimiento
                            .IdAsiento = stResultado(0)
                            .PrefijoID = oeAsiento.PrefijoID '@0001
                            If .TipoOperacion = "I" Then
                                odAsientoMov.GuardarMasivo(oeAsientomovimiento)
                            End If
                        End With
                    Next
                End With
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarComprobante(ByVal oeAsiento As e_Asiento) As Boolean
        Try

            Dim stResultado() As String
            'transaccion viene de documento
            With oeAsiento
                stResultado = sqlhelper.ExecuteScalar("CON.Isp_Asiento_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdPeriodo _
                        , .IdTipoAsiento _
                        , .NroAsiento _
                        , .Fecha _
                        , .Glosa _
                        , .GlosaImprime _
                        , .IdMoneda _
                        , .TipoCambio _
                        , .TotalDebe _
                        , .TotalHaber _
                        , .IdUsuarioBloquea _
                        , .IdUsuarioCrea _
                        , .IdEstado _
                        , .IdAsientoExtorno _
                        , .FechaCreacion _
                        , .Activo _
                        , .IdentificaAsiento _
                        , .IndOrigen
                    ).ToString.Split("_")
                Dim odAsientoMov As New d_AsientoMovimiento
                If .TipoOperacion = "A" Then
                    ''PRIMERO ELIMINAMOS LOS detalles del ASIENTO
                    For Each oeAsientomovimiento As e_AsientoMovimiento In .AsientoMovimiento
                        With oeAsientomovimiento
                            .PrefijoID = oeAsiento.PrefijoID '@0001
                            .IdAsiento = stResultado(0)
                            If .TipoOperacion = "E" Then ''eliminamos todo y despues volvemos a insertar
                                odAsientoMov.Eliminar(oeAsientomovimiento)
                            End If
                        End With
                    Next
                End If

                For Each oeAsientomovimiento As e_AsientoMovimiento In .AsientoMovimiento
                    With oeAsientomovimiento
                        .PrefijoID = oeAsiento.PrefijoID '@0001
                        .IdAsiento = stResultado(0)
                        If .TipoOperacion = "I" Or .TipoOperacion = "A" Then
                            If .BandGuardMasivo Then
                                odAsientoMov.GuardarMasivo(oeAsientomovimiento)
                            Else
                                odAsientoMov.GuardarComprobante(oeAsientomovimiento)
                            End If

                        End If
                    End With
                Next
                If .Asiento_MovDoc.IdMovimientoDocumento <> "" Then
                    .Asiento_MovDoc.PrefijoID = oeAsiento.PrefijoID '@0001
                    .Asiento_MovDoc.IdAsiento = stResultado(0)
                    Dim odAsientoMovDoc As New d_Asiento_MovDoc
                    odAsientoMovDoc.Guardar(.Asiento_MovDoc)
                End If
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function DuplicaAsiento(ByVal oeAsiento As e_Asiento) As Boolean
        Try
            With oeAsiento
                sqlhelper.ExecuteNonQuery("CON.Isp_Asiento_IAE", "D",
                 .PrefijoID, oeAsiento.Id, .IdPeriodo, .IdTipoAsiento, "", .Fecha, "" _
                        , "", "", 0, 0, 0, "", .IdUsuarioCrea)
            End With

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ExtornarAsiento(ByVal oeAsiento As e_Asiento) As Boolean
        Try

            With oeAsiento
                sqlhelper.ExecuteNonQuery("CON.Isp_AsientoExtorno", oeAsiento.TipoOperacion,
                                          .PrefijoID,
                                          oeAsiento.Id,
                                          oeAsiento.IdPeriodo,
                                          oeAsiento.IdTipoAsiento,
                                          oeAsiento.Glosa,
                                          oeAsiento.GlosaImprime,
                                          oeAsiento.IdUsuarioCrea)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CorrelativoAsiento(ByVal IdPeriodo As String) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.ISP_Asiento_Correlativo", IdPeriodo)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeAsiento As e_Asiento) As Boolean
        Try
            With oeAsiento
                sqlhelper.ExecuteNonQuery("CON.Isp_Asiento_IAE", "E",
                                        .PrefijoID,
                                        .Id, "", "", "",
                                        Date.Now, "", "", "", 0,
                                        .TotalDebe, 0,
                                        .IdUsuarioBloquea,
                                        .IdUsuarioCrea)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function EliminarAsientoAjuste(ByVal oeAsiento As e_Asiento) As Boolean
        Try

            With oeAsiento
                sqlhelper.ExecuteNonQuery("CON.Isp_Asiento_IAE", "J",
                 "", oeAsiento.Id, "", "", "", Date.Now, "", "", "", 0, 0, 0, "", oeAsiento.IdUsuarioCrea, "",
                 "", Date.Now, 1, "", 0)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function EliminarCobroPago(ByVal oeAsiento As e_Asiento, ByVal leCuentaxCyP As List(Of e_CuentaxCyP)) As Boolean
        Try
            Using transScope As New TransactionScope

                EliminarAsientoAjuste(oeAsiento)
                Eliminar(oeAsiento)

                Dim odCuentaCyP As New d_CuentaxCyP
                For Each obj As e_CuentaxCyP In leCuentaxCyP
                    odCuentaCyP.Eliminar(obj)
                    Exit For ' en el store se eliminan todos los relacionados
                Next
                transScope.Complete()
            End Using

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Extornar envio y emision del documento
    ''' </summary>
    ''' <param name="oeAsiento"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ExtornarEmitidoEnviado(ByVal oeAsiento As e_Asiento) As Boolean
        Try
            With oeAsiento
                sqlhelper.ExecuteNonQuery("CON.Isp_Asiento_IAE", "R",
                 .PrefijoID,
                 oeAsiento.Id,
                 "",
                 "", "", Date.Now, "", "", "", 0, 0, 0, "", oeAsiento.IdUsuarioCrea, "", "", Date.Now, 1, "", oeAsiento.IndOrigen)
            End With

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function InventariosYBalances(ByVal Mes As String, ByVal TipoConsulta As String) As DataTable
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_InventariosYBalances", Mes, TipoConsulta)
            If ds.Tables(0).Rows.Count = 0 Then Throw New Exception("No se encontro información")
            Return ds.Tables(0)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarMasivo2(ByVal oeAsiento As e_Asiento, ByVal DTAM As DataTable,
                                   ByVal DTAM_MD As DataTable, ByVal DTAM_OFIN As DataTable,
                                   ByVal oeAsiento2 As e_Asiento, ByVal DTAM2 As DataTable,
                                   ByVal DTAM_MD2 As DataTable, ByVal DTAM_OFIN2 As DataTable, ByVal oeMovAnalis As e_MovimientoAnalisis) As Boolean
        Try
            Dim stResultado() As String
            Using transScope As New TransactionScope()
                With oeAsiento
                    stResultado = sqlhelper.ExecuteScalar("CON.Isp_Asiento_IAE",
                                                          .TipoOperacion,
                                                          .PrefijoID,
                                                        .Id _
                                                        , .IdPeriodo _
                                                        , .IdTipoAsiento _
                                                        , .NroAsiento _
                                                        , .Fecha _
                                                        , .Glosa _
                                                        , .GlosaImprime _
                                                        , .IdMoneda _
                                                        , .TipoCambio _
                                                        , .TotalDebe _
                                                        , .TotalHaber _
                                                        , .IdUsuarioBloquea _
                                                        , .IdUsuarioCrea _
                                                        , .IdEstado _
                                                        , .IdAsientoExtorno _
                                                        , .FechaCreacion _
                                                        , .Activo _
                                                        , .IdentificaAsiento _
                                                        , .IndOrigen
                                                    ).ToString.Split("_")
                End With
                oeAsiento.Id = stResultado(0)
                For Each oeAsientomovimiento As DataRow In DTAM.Rows
                    With oeAsientomovimiento
                        .Item("IdAsiento") = stResultado(0)
                    End With
                Next
                Dim odAsientoMov As New d_AsientoMovimiento
                odAsientoMov.GuardarMasivo2(DTAM)
                Dim odAsientoMov_MovDoc As New d_AsientoMov_MovDoc
                If DTAM_MD.Rows.Count > 0 Then
                    odAsientoMov_MovDoc.GuardarMasivo(DTAM_MD)
                End If
                Dim odAsientoMov_Obligacion As New d_AsientoMov_ObligacionFin
                If DTAM_OFIN.Rows.Count > 0 Then
                    odAsientoMov_Obligacion.GuardarMasivo(DTAM_OFIN)
                End If
                If Not String.IsNullOrEmpty(oeAsiento2.TipoOperacion) Then
                    With oeAsiento2
                        stResultado = sqlhelper.ExecuteScalar("CON.Isp_Asiento_IAE",
                                                              .TipoOperacion,
                                                              .PrefijoID,
                                                                .Id _
                                                                , .IdPeriodo _
                                                                , .IdTipoAsiento _
                                                                , .NroAsiento _
                                                                , .Fecha _
                                                                , .Glosa _
                                                                , .GlosaImprime _
                                                                , .IdMoneda _
                                                                , .TipoCambio _
                                                                , .TotalDebe _
                                                                , .TotalHaber _
                                                                , .IdUsuarioBloquea _
                                                                , .IdUsuarioCrea _
                                                                , .IdEstado _
                                                                , .IdAsientoExtorno _
                                                                , .FechaCreacion _
                                                                , .Activo _
                                                                , .IdentificaAsiento _
                                                                , .IndOrigen
                                                            ).ToString.Split("_")
                    End With
                    oeAsiento2.Id = stResultado(0)
                    For Each oeAsientomovimiento As DataRow In DTAM2.Rows
                        With oeAsientomovimiento
                            .Item("IdAsiento") = stResultado(0)
                        End With
                    Next
                    odAsientoMov.GuardarMasivo2(DTAM2)
                    If DTAM_MD2.Rows.Count > 0 Then
                        odAsientoMov_MovDoc.GuardarMasivo(DTAM_MD2)
                    End If
                    If DTAM_OFIN2.Rows.Count > 0 Then
                        odAsientoMov_Obligacion.GuardarMasivo(DTAM_OFIN2)
                    End If

                    If Not oeMovAnalis Is Nothing Then
                        Dim odAnalisis As New d_MovimientoAnalisis
                        oeMovAnalis.PrefijoID = oeAsiento.PrefijoID '@0001
                        odAnalisis.Guardar(oeMovAnalis)
                    End If

                End If
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function UltimoIdInserta(ByVal PrefijoID As String) As String
        Try
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "CON.Asiento", PrefijoID
                                  )
            Return IIf(stResultado Is Nothing, PrefijoID & "000000000001", stResultado)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function UltimoNroAsiento(ByVal IdTipo As String, ByVal IdPeriodo As String, ByVal TipoOperacion As String, ByVal PrefijoID As String) As String
        Try
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_NumeroContable_Listar", TipoOperacion, PrefijoID _
                                   , IdTipo _
                                   , IdPeriodo)
            Return stResultado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarCobranzaPago(ByVal DTAsiento As DataTable, ByVal DTAsientoMovimiento As DataTable _
                                    , ByVal DTMovCajaBanco As DataTable, ByVal DTAM_MovDoc As DataTable _
                                    , ByVal DTCtaxCyP As DataTable, ByVal DTMA As DataTable,
                                    ByVal ListaDoc As List(Of e_MovimientoDocumento),
                                     ByVal oeMovCajaBanco As e_MovimientoCajaBanco) As Boolean
        Try
            Using transScope As New TransactionScope
                sqlhelper.InsertarMasivo("CON.Asiento", DTAsiento, False)
                sqlhelper.InsertarMasivo("CON.AsientoMovimiento", DTAsientoMovimiento, False)
                sqlhelper.InsertarMasivo("CON.AsientoMov_MovDoc", DTAM_MovDoc, False)
                sqlhelper.InsertarMasivo("CON.MovimientoCajaBanco", DTMovCajaBanco, False)
                sqlhelper.InsertarMasivo("TES.CuentaxCyP", DTCtaxCyP, False)
                sqlhelper.InsertarMasivo("CON.MovimientoAnalisis", DTMA, False)

                For Each obj In ListaDoc
                    obj.PrefijoID = oeMovCajaBanco.PrefijoID '@0001
                    With obj
                        sqlhelper.ExecuteNonQuery("CON.Isp_MovimientoDocumento_IAE",
                                "SAL" _
                                , .PrefijoID _
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
                                , .Glosa _
                                , .IdLiquidacion _
                                , 0 _
                                , .IdTipoBien _
                                , .OrdenCompra _
                                , "" _
                                , .CodMotivo
                                )
                    End With
                Next
                If oeMovCajaBanco.TipoOperacion = "S" Then
                    odMovimientoCajaBanco.Guardar(oeMovCajaBanco)
                End If
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#Region "Ajuste TipoCambio"

    Private Function CargarAjusteTC(ByVal o_fila As DataRow) As e_AjusteTC
        Try
            Dim oeAjusteTC = New e_AjusteTC(
                             o_fila("IdMovimientoDocumento").ToString _
                             , o_fila("IdPeriodo").ToString _
                             , o_fila("TipoAsiento").ToString _
                             , o_fila("Periodo").ToString _
                             , o_fila("NroAsiento").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("Cuenta").ToString _
                             , o_fila("TipoDocumento").ToString _
                             , o_fila("Serie").ToString _
                             , o_fila("Numero").ToString _
                             , o_fila("TipoCambio") _
                             , o_fila("Debe") _
                             , o_fila("Haber"))
            Return oeAjusteTC
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarAjusteTC(ByVal oeAjusteTC As e_AjusteTC) As List(Of e_AjusteTC)
        Try
            Dim ldAjusteTC As New List(Of e_AjusteTC)
            Dim ds As DataSet
            With oeAjusteTC
                ds = sqlhelper.ExecuteDataset("CON.Isp_AjusteTipoCambio_Listar", .TipoOperacion _
                        , .IdMovimientoDocumento _
                        , .IdPeriodo _
                        , .Ejercicio
                        )
            End With
            oeAjusteTC = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeAjusteTC = CargarAjusteTC(o_Fila)
                    ldAjusteTC.Add(oeAjusteTC)
                Next
            End If
            Return ldAjusteTC
        Catch ex As Exception
            Throw
        End Try
    End Function

#End Region

#Region "Estados Financieros"

    Public Function ListarEEFF(ByVal li_Ejercicio As Integer, ByVal li_Mes As Integer, Optional ls_Operacion As String = "") As DataTable
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[CON].[ISP_EstadosFinancieros_Reporte]", li_Ejercicio, li_Mes)
            If ds.Tables(0).Rows.Count = 0 Then Throw New Exception("No se encontro información")
            Return ds.Tables(0)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarBalanceGeneral(ByVal ln_Ejercicio As Integer, ByVal ln_Mes As Integer) As DataTable
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[CON].[ISP_EstadosFinancieros_Reporte]", ln_Ejercicio, ln_Mes)
            If ds.Tables(0).Rows.Count = 0 Then Throw New Exception("No se encontro información")
            Return ds.Tables(0)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarEstadoGanaciasPerdidas(ByVal ls_IdPeriodo As String, ByVal ls_TipoOper As String) As DataSet
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[CON].[Isp_InventariosYBalances]", ls_IdPeriodo, ls_TipoOper)
            If ds.Tables.Count = 0 Then Throw New Exception("No se encontro información")
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarBalanceComprobacion(ByVal oeAsiento As e_Asiento) As DataTable
        Try
            Dim ds As DataSet
            Dim ds2 As DataSet
            With oeAsiento
                ds = sqlhelper.ExecuteDataset("CON.ISP_Balance_Comprobacion_Listar", "A", .IdPeriodo, ._Mes, ._Ejercicio)
            End With
            With oeAsiento
                ds2 = sqlhelper.ExecuteDataset("CON.ISP_Balance_Comprobacion_Listar", "M", .IdPeriodo, ._Mes, ._Ejercicio)
            End With
            oeAsiento = Nothing
            '0 as DebeSa, 0 as HaberSa, 0 as DebeSaAc, 0 as HaberSaAc
            If ds2.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds2.Tables(0).Rows
                    Dim expresion As String = "IdCuentaContable = '" & o_Fila("IdCuentaContable").ToString & "'"
                    Dim tabla() As Data.DataRow = ds.Tables(0).Select(expresion)
                    If tabla.Length = 0 Then
                        o_Fila("DebeSa") = o_Fila("DebeMo")
                        o_Fila("HaberSa") = o_Fila("HaberMo")
                        If o_Fila("DebeSa") - o_Fila("HaberSa") > 0 Then
                            o_Fila("DebeSaAc") = o_Fila("DebeSa") - o_Fila("HaberSa")
                            o_Fila("HaberSaAc") = 0
                        Else
                            o_Fila("DebeSaAc") = 0
                            o_Fila("HaberSaAc") = o_Fila("HaberSa") - o_Fila("DebeSa")
                        End If
                        'Dim rowDetalle As Data.DataRow
                        'rowDetalle = ds.Tables(0).NewRow
                        'rowDetalle = o_Fila
                        'ds.Tables(0).Rows.Add(o_Fila)
                        ds.Tables(0).ImportRow(o_Fila)
                    Else
                        tabla(0).Item("DebeMo") = o_Fila("DebeMo")
                        tabla(0).Item("HaberMo") = o_Fila("HaberMo")
                        tabla(0).Item("DebeSa") = o_Fila("DebeMo") + tabla(0).Item("DebeAn")
                        tabla(0).Item("HaberSa") = o_Fila("HaberMo") + tabla(0).Item("HaberAn")
                        If tabla(0).Item("DebeSa") - tabla(0).Item("HaberSa") > 0 Then
                            tabla(0).Item("DebeSaAc") = tabla(0).Item("DebeSa") - tabla(0).Item("HaberSa")
                            tabla(0).Item("HaberSaAc") = 0
                        Else
                            tabla(0).Item("DebeSaAc") = 0
                            tabla(0).Item("HaberSaAc") = tabla(0).Item("HaberSa") - tabla(0).Item("DebeSa")
                        End If
                    End If
                Next
            End If
            Return ds.Tables(0)

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarBalanceComprobacionDestino(ByVal oeAsiento As e_Asiento) As DataTable
        Try
            Dim ds As DataSet
            Dim ds2 As DataSet
            With oeAsiento
                ds = sqlhelper.ExecuteDataset("CON.ISP_Balance_Comprobacion_Distribucion_Listar", "A", .IdPeriodo, ._Mes)
            End With
            With oeAsiento
                ds2 = sqlhelper.ExecuteDataset("CON.ISP_Balance_Comprobacion_Distribucion_Listar", "M", .IdPeriodo, ._Mes)
            End With
            oeAsiento = Nothing
            '0 as DebeSa, 0 as HaberSa, 0 as DebeSaAc, 0 as HaberSaAc
            If ds2.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds2.Tables(0).Rows
                    Dim expresion As String = "IdGastoFuncion = '" & o_Fila("IdGastoFuncion").ToString & "'"
                    Dim tabla() As Data.DataRow = ds.Tables(0).Select(expresion)
                    If tabla.Length = 0 Then
                        o_Fila("DebeSa") = o_Fila("DebeMo")
                        o_Fila("HaberSa") = o_Fila("HaberMo")
                        If o_Fila("DebeSa") - o_Fila("HaberSa") > 0 Then
                            o_Fila("DebeSaAc") = o_Fila("DebeSa") - o_Fila("HaberSa")
                            o_Fila("HaberSaAc") = 0
                        Else
                            o_Fila("DebeSaAc") = 0
                            o_Fila("HaberSaAc") = o_Fila("HaberSa") - o_Fila("DebeSa")
                        End If
                        'Dim rowDetalle As Data.DataRow
                        'rowDetalle = ds.Tables(0).NewRow
                        'rowDetalle = o_Fila
                        'ds.Tables(0).Rows.Add(o_Fila)
                        ds.Tables(0).ImportRow(o_Fila)
                    Else
                        tabla(0).Item("DebeMo") = o_Fila("DebeMo")
                        tabla(0).Item("HaberMo") = o_Fila("HaberMo")
                        tabla(0).Item("DebeSa") = o_Fila("DebeMo") + tabla(0).Item("DebeAn")
                        tabla(0).Item("HaberSa") = o_Fila("HaberMo") + tabla(0).Item("HaberAn")
                        If tabla(0).Item("DebeSa") - tabla(0).Item("HaberSa") > 0 Then
                            tabla(0).Item("DebeSaAc") = tabla(0).Item("DebeSa") - tabla(0).Item("HaberSa")
                            tabla(0).Item("HaberSaAc") = 0
                        Else
                            tabla(0).Item("DebeSaAc") = 0
                            tabla(0).Item("HaberSaAc") = tabla(0).Item("HaberSa") - tabla(0).Item("DebeSa")
                        End If
                    End If
                Next
            End If
            Return ds.Tables(0)

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarAsientosDescuadrados(ByVal oeAsiento As e_Asiento) As DataTable
        Try
            Dim ds As DataSet
            With oeAsiento
                ds = sqlhelper.ExecuteDataset("CON.ISP_AsientosDescuadrados_Listar", .IdPeriodo)
            End With

            Return ds.Tables(0)

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarUtilidadBrutaVehicular(ByVal Ejercicio As Integer, ByVal Mes As Integer, ByVal Acumulado As Integer) As DataTable
        Try
            Dim ds As DataSet

            ds = sqlhelper.ExecuteDataset("CON.Isp_UtilidadBrutaVehicular_Listar", Ejercicio, Mes, Acumulado)

            Return ds.Tables(0)

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDetalles(ByVal TipoOperacion As String, ByVal IdPeriodo As String,
                                   ByVal IdCuentaContable As String, ByVal IdGastoFuncion As String) As DataTable
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_EstadosFinancieros_Detalles", TipoOperacion, IdPeriodo, IdCuentaContable, IdGastoFuncion)
            Return ds.Tables(0)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Impresiones"

    Public Function ImprimirTranferencia(ByVal IdMovimientoCajaBanco As String) As DataTable
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_ImpresionTransferencia", IdMovimientoCajaBanco)
            Return ds.Tables(0)

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ImprimirCobroPagoAnticipo(ByVal IdMovimientoCajaBanco As String, ByVal lsTipoOperacion As String) As DataTable
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_ImpresionCobroPago", IdMovimientoCajaBanco, lsTipoOperacion)
            Return ds.Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

#End Region

#Region "Consumo"

    Public Function ListarConsumoMaterial(ByVal oePeriodo As e_Periodo, ByVal lsIdSubAlmacen As String) As DataTable
        Try
            Dim ds As DataSet
            With oePeriodo
                ds = sqlhelper.ExecuteDataset("CON.ISP_ConsumoMaterialContabilidad", .TipoOperacion, .Ejercicio, .Mes, lsIdSubAlmacen)
            End With
            oePeriodo = Nothing
            Return ds.Tables(0)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Devengado de seguros"

    Public Function ListarDevengadoSeguros(ByVal FechaVencimiento As Date, ByVal lsTipoOper As String, ByVal lsIddoc As String) As DataTable
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_InterfazSeguroContabilidad", FechaVencimiento, lsTipoOper, lsIddoc)
            Return ds.Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ObtenerOrigenContable(ByVal Tipo As String, ByVal IdMovDoc As String) As Integer
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_OrigenContable_Listar", Tipo, IdMovDoc)

            If ds.Tables(0).Rows.Count() > 0 Then
                Return ds.Tables(0).Rows(0).Item(0)
            Else
                Return 0
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

#End Region

#Region "Descuentos a Personal"

    ''' <summary>
    ''' Guardar Asiento por Reembolso de Descuento de Caja y Otras Areas
    ''' </summary>
    ''' <param name="oeAsiento"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GuardarAsientoDscto(ByVal oeAsiento As e_Asiento, Optional oeAsientoAnticipo As e_Asiento = Nothing) As Boolean
        Try
            Dim odAsientoMov As New d_AsientoMovimiento, odAsientoMovDoc As New d_Asiento_MovDoc, odAsientoReferencia As d_AsientoReferencia, odLiquidacionTrabjador As New d_LiquidacionTrabajador_Asiento
            Using TransScope As New TransactionScope()
                Dim stResultado() As String
                With oeAsiento
                    stResultado = sqlhelper.ExecuteScalar("CON.Isp_Asiento_IAE", .TipoOperacion, .PrefijoID,
                             .Id _
                            , .IdPeriodo _
                            , .IdTipoAsiento _
                            , .NroAsiento _
                            , .Fecha _
                            , .Glosa _
                            , .GlosaImprime _
                            , .IdMoneda _
                            , .TipoCambio _
                            , .TotalDebe _
                            , .TotalHaber _
                            , .IdUsuarioBloquea _
                            , .IdUsuarioCrea _
                            , .IdEstado _
                            , .IdAsientoExtorno _
                            , .FechaCreacion _
                            , .Activo _
                            , .IdentificaAsiento _
                            , .IndOrigen
                                ).ToString.Split("_")
                    oeAsiento.Id = stResultado(0)
                    '==============================================
                    'RELACIONAR LiquidacionTrabajador <-> Asiento
                    If Not .oeLiquidacionTrabajador_Asiento.idliquidaciontrabajador Is String.Empty Then
                        .oeLiquidacionTrabajador_Asiento.idasiento = stResultado(0)
                        .oeLiquidacionTrabajador_Asiento.PrefijoID = oeAsiento.PrefijoID '@0001
                        odLiquidacionTrabjador.Guardar(.oeLiquidacionTrabajador_Asiento)
                    End If
                    '==============================================
                    If Not .Asiento_MovDoc Is Nothing Then
                        .Asiento_MovDoc.IdAsiento = stResultado(0)
                        .Asiento_MovDoc.PrefijoID = oeAsiento.PrefijoID '@0001
                        odAsientoMovDoc.Guardar(.Asiento_MovDoc)
                    End If
                    If .AsientoReferencia.TipoOperacion = "I" Then
                        odAsientoReferencia = New d_AsientoReferencia
                        .AsientoReferencia.IdAsiento = stResultado(0)
                        .AsientoReferencia.PrefijoID = oeAsiento.PrefijoID '@0001
                        odAsientoReferencia.Guardar(.AsientoReferencia)
                    End If
                    For Each oeAsiMov In .AsientoMovimiento
                        oeAsiMov.IdAsiento = stResultado(0)
                        If (oeAsiMov.ObligacionFinanciera.oeObligacionPago IsNot Nothing) AndAlso oeAsiMov.ObligacionFinanciera.oeObligacionPago.TipoOperacion <> "" Then
                            oeAsiMov.ObligacionFinanciera.oeObligacionPago.IdMovimientoCajaBanco = oeAsiento._IdMovimientoCajaBanco
                        End If
                        oeAsiMov.PrefijoID = oeAsiento.PrefijoID '@0001
                        odAsientoMov.GuardarAsiMov(oeAsiMov)
                        If oeAsiMov._IdMovimientoCajaBanco <> "" Then oeAsiento._IdMovimientoCajaBanco = oeAsiMov._IdMovimientoCajaBanco
                    Next

                    If Not oeAsientoAnticipo Is Nothing Then
                        oeAsientoAnticipo.PrefijoID = oeAsiento.PrefijoID '@0001
                        GuardarAsiento_AplicaAnticipo(oeAsientoAnticipo, stResultado(0))
                    End If
                End With
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarAsiento_AplicaAnticipo(ByVal oeAsiento As e_Asiento, idasientodoc As String) As Boolean
        Try
            Dim odAsientoMov As New d_AsientoMovimiento, odAsientoMovDoc As New d_Asiento_MovDoc
            Dim oeAsiento_Anticipo As New e_Asiento_Anticipo, odAsiento_Anticipo As New d_Asiento_Anticipo
            Using TransScope As New TransactionScope()
                Dim stResultado() As String
                With oeAsiento
                    stResultado = sqlhelper.ExecuteScalar("CON.Isp_Asiento_IAE", .TipoOperacion, .PrefijoID,
                             .Id _
                            , .IdPeriodo _
                            , .IdTipoAsiento _
                            , .NroAsiento _
                            , .Fecha _
                            , .Glosa _
                            , .GlosaImprime _
                            , .IdMoneda _
                            , .TipoCambio _
                            , .TotalDebe _
                            , .TotalHaber _
                            , .IdUsuarioBloquea _
                            , .IdUsuarioCrea _
                            , .IdEstado _
                            , .IdAsientoExtorno _
                            , .FechaCreacion _
                            , .Activo _
                            , .IdentificaAsiento _
                            , .IndOrigen
                                ).ToString.Split("_")
                    oeAsiento.Id = stResultado(0)
                    '==============================================
                    'RELACIONAR Asiento <-> Asiento_Anticipo
                    If Not idasientodoc Is String.Empty Then
                        oeAsiento_Anticipo.IdAsientoDoc = idasientodoc
                        oeAsiento_Anticipo.IdAsientoAntic = stResultado(0)
                        oeAsiento_Anticipo.Activo = True
                        oeAsiento_Anticipo.TipoOperacion = oeAsiento.TipoOperacion
                        oeAsiento_Anticipo.PrefijoID = .PrefijoID '@0001
                        odAsiento_Anticipo.Guardar(oeAsiento_Anticipo)
                    End If
                    '==============================================

                    For Each oeAsiMov In .AsientoMovimiento
                        oeAsiMov.IdAsiento = stResultado(0)
                        oeAsiMov.PrefijoID = .PrefijoID '@0001
                        odAsientoMov.GuardarAsiMov(oeAsiMov)
                    Next
                End With
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarAsientoMasivo(ByVal dtAsiento As Data.DataTable, ByVal dtAsiMov As Data.DataTable, ByVal dtAMDoc As Data.DataTable) As Boolean
        Try
            Dim odAsientoMov As New d_AsientoMovimiento, odAsiMovDoc As New d_AsientoMov_MovDoc
            Using TransScope As New TransactionScope()
                sqlhelper.InsertarMasivo("CON.Asiento", dtAsiento, False)
                sqlhelper.InsertarMasivo("CON.AsientoMovimiento", dtAsiMov, False)
                sqlhelper.InsertarMasivo("CON.AsientoMov_MovDoc", dtAMDoc, False)
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarAsientoMasivo2(ByVal dtAsiento As Data.DataTable, ByVal dtAsiMov As Data.DataTable, ByVal dtAMObli As Data.DataTable) As Boolean
        Try
            Dim odAsientoMov As New d_AsientoMovimiento, odAsiMovDoc As New d_AsientoMov_MovDoc
            Using TransScope As New TransactionScope()
                sqlhelper.InsertarMasivo("CON.Asiento", dtAsiento, False)
                sqlhelper.InsertarMasivo("CON.AsientoMovimiento", dtAsiMov, False)
                sqlhelper.InsertarMasivo("FIN.AsientoMov_ObligacionFin", dtAMObli, False)
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarAsientoMasivo3(ByVal dtAsiento As Data.DataTable, ByVal dtAsiMov As Data.DataTable, ByVal dtMCB As Data.DataTable, ByVal dtCPC As Data.DataTable, ByVal dtAMDoc As Data.DataTable) As Boolean
        Try
            'Dim odAsientoMov As New d_AsientoMovimiento, odAsiMovDoc As New d_AsientoMov_MovDoc
            Using TransScope As New TransactionScope()
                sqlhelper.InsertarMasivo("CON.Asiento", dtAsiento, False)
                sqlhelper.InsertarMasivo("CON.AsientoMovimiento", dtAsiMov, False)
                sqlhelper.InsertarMasivo("CON.MovimientoCajaBanco", dtMCB, False)
                sqlhelper.InsertarMasivo("TES.CuentaxCyP", dtCPC, False)
                sqlhelper.InsertarMasivo("CON.AsientoMov_MovDoc", dtAMDoc, False)
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarAsientoMasivo4(dtAsiento As Data.DataTable, dtAsiMov As Data.DataTable, dtMovAna As Data.DataTable, dtAsiRef As Data.DataTable) As Boolean
        Try
            Using TransScope As New TransactionScope()
                sqlhelper.InsertarMasivo("CON.Asiento", dtAsiento, False)
                sqlhelper.InsertarMasivo("CON.AsientoMovimiento", dtAsiMov, False)
                sqlhelper.InsertarMasivo("CON.MovimientoAnalisis", dtMovAna, False)
                sqlhelper.InsertarMasivo("CON.AsientoReferencia", dtAsiRef, False)
                TransScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarAsientoMasivo5(ByVal dtAsiento As Data.DataTable, ByVal dtAsiMov As Data.DataTable, ByVal dtAMDoc As Data.DataTable, ByVal dtAMObli As Data.DataTable) As Boolean
        Try
            Dim odAsientoMov As New d_AsientoMovimiento, odAsiMovDoc As New d_AsientoMov_MovDoc
            Using TransScope As New TransactionScope()
                sqlhelper.InsertarMasivo("CON.Asiento", dtAsiento, False)
                sqlhelper.InsertarMasivo("CON.AsientoMovimiento", dtAsiMov, False)
                sqlhelper.InsertarMasivo("CON.AsientoMov_MovDoc", dtAMDoc, False)
                sqlhelper.InsertarMasivo("FIN.AsientoMov_ObligacionFin", dtAMObli, False)
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarMasivo3(ByVal DTAsiento As DataTable) As Boolean
        Try

            sqlhelper.InsertarMasivo("CON.Asiento", DTAsiento, False)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

End Class