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

Public Class d_ObligacionFinanciera
    Private sqlhelper As New SqlHelper
    Private oeFecLetra As New e_FecLetras, odFecLetra As New d_FecLetras
    Private odObligacionDoc As New d_ObligacionDocumento

    Private Function Cargar(ByVal o_fila As DataRow) As e_ObligacionFinanciera
        Try
            Dim oeObligacionFinanciera = New e_ObligacionFinanciera( _
                             o_fila("IdObligacion").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("IdEmpresaBanco").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("FechaEmision").ToString _
                             , o_fila("FechaVencimiento").ToString _
                             , o_fila("IdTipoObligacion").ToString _
                             , o_fila("IdMoneda").ToString _
                             , o_fila("TipoCambio").ToString _
                             , o_fila("MontoMN").ToString _
                             , o_fila("MontoME").ToString _
                             , o_fila("Saldo").ToString _
                             , o_fila("TasaInteres").ToString _
                             , o_fila("MontoInteresTes").ToString _
                             , o_fila("MontoInteresCon").ToString _
                             , o_fila("MontoInteresMoratorio").ToString _
                             , o_fila("Comision").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("IdCuentaContable").ToString _
                             , o_fila("IdLeasing").ToString _
                             , o_fila("Cuota").ToString _
                             , o_fila("NroCuotas").ToString _
                            , o_fila("IdFec").ToString _
                             , o_fila("IndClienteProveedor").ToString _
                             , o_fila("IdClienteProveedor").ToString _
                             , o_fila("IdCuentaContableInteres").ToString _
                            , o_fila("IdCuentaBancaria").ToString _
                            , o_fila("Gastos") _
                            , o_fila("CodigoUnico") _
                            , o_fila("NombreBanco") _
                            , o_fila("NombreObligacion") _
                            , o_fila("NroLetra").ToString _
                            , o_fila("FechaInicial") _
                            , o_fila("MontoInteresDscto").ToString _
                            )
            Return oeObligacionFinanciera
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function Cargar2(ByVal o_fila As DataRow) As e_ObligacionFin
        Try
            Dim oeObligacionFinan = New e_ObligacionFin( _
                             o_fila("Id").ToString _
                             , o_fila("IdContratoFinanciero").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("IndPeriodoGracia") _
                             , o_fila("FechaVencimiento") _
                             , o_fila("MontoMN") _
                             , o_fila("MontoME") _
                             , o_fila("MontoInteres") _
                             , o_fila("MontoInteresMoratorio") _
                             , o_fila("MontoInteresDscto") _
                             , o_fila("MontoInteresContable") _
                             , o_fila("DiasFinMes") _
                             , o_fila("DiasProximaCuota") _
                             , o_fila("IndInteresMensual") _
                             , o_fila("Comision") _
                             , o_fila("Gastos") _
                             , o_fila("Portes") _
                             , o_fila("IGV") _
                             , o_fila("ITF") _
                             , o_fila("Saldo") _
                             , o_fila("Glosa") _
                             , o_fila("Cuo") _
                             , o_fila("IdCuentaContable").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioModificacion").ToString _
                             , o_fila("FechaModificacion") _
                             , o_fila("MacPCLocalCreacion").ToString _
                             , o_fila("Activo") _
                             , o_fila("NroContrato") _
                             , o_fila("Banco") _
                             , o_fila("TipoDocumento") _
                             , o_fila("Moneda").ToString _
                             , o_fila("TipoCambio").ToString _
                             , o_fila("RetencionMN") _
                             , o_fila("RetencionME")
                            )
            Return oeObligacionFinan
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeObligacionFinanciera As e_ObligacionFinanciera) As e_ObligacionFinanciera
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("FIN.ISP_ObligacionFinanciera_Listar", "",
            Left(oeObligacionFinanciera.PrefijoID, 1), "", oeObligacionFinanciera.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeObligacionFinanciera = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeObligacionFinanciera
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener2(ByVal oeObligacionFin As e_ObligacionFin) As e_ObligacionFin
        Try
            Dim ds As DataSet
            With oeObligacionFin
                ds = sqlhelper.ExecuteDataset("FIN.Isp_ObligacionFin_Listar",
                                              .TipoOperacion,
                                             Left(.PrefijoID, 1),
                                            "",
                                            .Id,
                                            .IdContrato,
                                            .Banco,
                                            .IdTipoObligacion,
                                            .IdMoneda,
                                            .FechaInicio,
                                            .FechaVencimiento,
                                            .Ejercicio,
                                            .Mes,
                                            .IndPeriodoGracia,
                                            .Activo,
                                            .RetencionMN,
                                            .RetencionME
                                            )
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeObligacionFin = Cargar2(ds.Tables(0).Rows(0))
            End If
            Return oeObligacionFin
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeObligacionFinanciera As e_ObligacionFinanciera) As List(Of e_ObligacionFinanciera)
        Try
            Dim ldObligacionFinanciera As New List(Of e_ObligacionFinanciera)
            Dim ds As DataSet
            With oeObligacionFinanciera
                ds = sqlhelper.ExecuteDataset("FIN.ISP_ObligacionFinanciera_Listar",
                                              .TipoOperacion _
                                            , Left(.PrefijoID, 1),
                                            "" _
                                            , .Id _
                                            , .Codigo _
                                            , .IdEmpresaBanco _
                                            , .Glosa _
                                            , .FechaEmision _
                                            , .FechaVencimiento _
                                            , .IdTipoObligacion _
                                            , .IdMoneda _
                                            , .TipoCambio _
                                            , .MontoMN _
                                            , .MontoME _
                                            , .Saldo _
                                            , .TasaInteres _
                                            , .MontoInteresTes _
                                            , .MontoInteresCon _
                                            , .MontoInteresMoratorio _
                                            , .Comision _
                                            , .Activo _
                                            , .IdCuentaContable _
                                            , .NombreDocumento _
                                            , "" _
                                            , ._Ejercicio)
            End With
            oeObligacionFinanciera = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeObligacionFinanciera = Cargar(o_Fila)
                    ldObligacionFinanciera.Add(oeObligacionFinanciera)
                Next
            End If
            Return ldObligacionFinanciera
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar2(ByVal oeObligacionFin As e_ObligacionFin) As List(Of e_ObligacionFin)
        Try
            Dim ldObligacionFin As New List(Of e_ObligacionFin)
            Dim ds As DataSet
            With oeObligacionFin
                ds = sqlhelper.ExecuteDataset("FIN.Isp_ObligacionFin_Listar",
                                              .TipoOperacion,
                                             Left(.PrefijoID, 1),
                                            "",
                                            .Id,
                                            .IdContrato,
                                            .Banco,
                                            .IdTipoObligacion,
                                            .IdMoneda,
                                            .FechaInicio,
                                            .FechaVencimiento,
                                            .Ejercicio,
                                            .Mes,
                                            .IndPeriodoGracia,
                                            .Activo
                                            )
            End With
            oeObligacionFin = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeObligacionFin = Cargar2(o_Fila)
                    ldObligacionFin.Add(oeObligacionFin)
                Next
            End If
            Return ldObligacionFin
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarDatable(ByVal oeObligacionFinanciera As e_ObligacionFinanciera) As DataTable
        Try
            Dim ldObligacionFinanciera As New List(Of e_ObligacionFinanciera)
            Dim ds As DataSet
            With oeObligacionFinanciera
                ds = sqlhelper.ExecuteDataset("FIN.ISP_ObligacionFinanciera_Listar", .TipoOperacion _
                        , Left(.PrefijoID, 1), "" _
                        , .Id _
                        , .Codigo _
                        , .IdEmpresaBanco _
                        , .Glosa _
                        , .FechaEmision _
                        , .FechaVencimiento _
                        , .IdTipoObligacion _
                        , .IdMoneda
                                                     )
            End With
            oeObligacionFinanciera = Nothing
            Return ds.Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarValidar(ByVal oeObligacionFinanciera As e_ObligacionFinanciera) As Integer
        Try

            Dim ds As DataSet
            With oeObligacionFinanciera
                ds = sqlhelper.ExecuteDataset("FIN.ISP_ObligacionFinanciera_Listar", "V" _
                        , Left(.PrefijoID, 1), "" _
                        , .Id _
                        , .Codigo _
                        , .IdEmpresaBanco _
                        , .Glosa _
                        , .FechaEmision _
                        , .FechaVencimiento _
                        , .IdTipoObligacion _
                        , .IdMoneda _
                        , .TipoCambio _
                        , .MontoMN _
                        , .MontoME _
                        , .Saldo _
                        , .TasaInteres _
                        , .MontoInteresTes _
                        , .MontoInteresCon _
                        , .MontoInteresMoratorio _
                        , .Comision _
                        , .Activo _
                        , .IdCuentaContable _
                        , .NombreDocumento _
                        , .CodigoUnico _
                               )
            End With
            oeObligacionFinanciera = Nothing
            Dim Resul As Integer = 0
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    Resul = o_Fila("Result")
                Next
            End If
            Return Resul
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarObli(ByVal oeObligacionFinanciera As e_ObligacionFinanciera) As Boolean
        Try
            With oeObligacionFinanciera
                sqlhelper.ExecuteNonQuery("FIN.ISP_ObligacionFinanciera_IAE", .TipoOperacion, "", _
                        .Id _
                        , .Codigo _
                        , .IdEmpresaBanco _
                        , .Glosa _
                        , .FechaEmision _
                        , .FechaVencimiento _
                        , .IdTipoObligacion _
                        , .IdMoneda _
                        , .TipoCambio _
                        , .MontoMN _
                        , .MontoME _
                        , .Saldo _
                        , .TasaInteres _
                        , .MontoInteresTes _
                        , .MontoInteresCon _
                        , .MontoInteresMoratorio _
                        , .Comision _
                        , .Activo _
                        , .IdCuentaContable _
                        , "" _
                        , .Cuota _
                        , .NroCuotas _
                        , .ActivoLeasing _
                        , "" _
                        , .IndClienteProveedor _
                        , .IdClienteProveedor _
                        , .ActivoLetras _
                        , .UsuarioCreacion _
                        , .MacPcLocalCreacion _
                        , ._IdCuentaContableInteres _
                        , .IdCuentaBancaria _
                        , .Gastos _
                        , .CodigoUnico _
                        , .NroLetra _
                        , .FechaInicial _
                        , .MontoInteresDscto _
                ).ToString.Split("_")
            End With

        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function CambiarGlosa(ByVal oeObligacionFinanciera As e_ObligacionFinanciera) As Boolean
        Try
            With oeObligacionFinanciera
                sqlhelper.ExecuteNonQuery("FIN.ISP_ObligacionFinanciera_IAE", "G", "", _
                        .Id _
                        , .Codigo _
                        , .IdEmpresaBanco _
                        , .Glosa _
                        , .FechaEmision _
                        , .FechaVencimiento _
                        , .IdTipoObligacion _
                        , .IdMoneda _
                        , .TipoCambio _
                        , .MontoMN _
                        , .MontoME _
                        , .Saldo _
                        , .TasaInteres _
                        , .MontoInteresTes _
                        , .MontoInteresCon _
                        , .MontoInteresMoratorio _
                        , .Comision _
                        , .Activo _
                        , .IdCuentaContable _
                        , "" _
                        , .Cuota _
                        , .NroCuotas _
                        , .ActivoLeasing _
                        , "" _
                        , .IndClienteProveedor _
                        , .IdClienteProveedor _
                        , .ActivoLetras _
                        , .UsuarioCreacion _
                        , .MacPcLocalCreacion _
                        , ._IdCuentaContableInteres _
                        , .IdCuentaBancaria _
                        , .Gastos _
                        , .CodigoUnico _
                        , .NroLetra _
                        , .FechaInicial _
                        , .MontoInteresDscto _
                         ).ToString.Split("_")
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Guardar(ByVal oeObligacionFinanciera As e_ObligacionFinanciera, ByVal oeAsiento As e_Asiento, Optional ByVal UsaTransaccion As Boolean = True) As Boolean
        Try
            If UsaTransaccion Then
                Using transScope As New TransactionScope
                    GuardarObligacion(oeObligacionFinanciera, oeAsiento)
                    transScope.Complete()
                End Using
            Else
                GuardarObligacion(oeObligacionFinanciera, oeAsiento)
            End If
            Return True

        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Guardar(ByVal oeObligacionFin As e_ObligacionFin) As Boolean
        Try
            Dim stResultado() As String
            Using transScope As New TransactionScope
                With oeObligacionFin
                    stResultado = sqlhelper.ExecuteScalar("FIN.Isp_ObligacionFin_IAE2" _
                                                          , .TipoOperacion _
                                                          , .PrefijoID _
                                                          , .Id _
                                                          , .IdContrato _
                                                          , .NroVencimiento _
                                                          , .IndPeriodoGracia _
                                                          , .FechaVencimiento _
                                                          , .MontoMN _
                                                          , .MontoME _
                                                          , .MontoInteres _
                                                          , .MontoInteresMoratorio _
                                                          , .MontoInteresDscto _
                                                          , .MontoInteresContable _
                                                          , .DiasFinMes _
                                                          , .DiasProximaCuota _
                                                          , .IndInteresMensual _
                                                          , .Comision _
                                                          , .Gastos _
                                                          , .Portes _
                                                          , .IGV _
                                                          , .ITF _
                                                          , .Saldo _
                                                          , .Glosa _
                                                          , .Cuo _
                                                          , .IdCuentaContable _
                                                          , .Usuario _
                                                          , .UsuarioModifica _
                                                          , .MacLocal _
                                                          , .Activo _
                                                          , .RetencionMN _
                                                          , .RetencionME
                                                          ).ToString.Split("_")
                    .Id = stResultado(0)
                    If .oeFecLetra.NroLetra.Trim <> "" Then
                        .oeFecLetra.IdObligacionFinanciera = .Id
                        .oeFecLetra.PrefijoID = oeObligacionFin.PrefijoID '@0001
                        odFecLetra.Guardar(oeFecLetra)
                    End If
                    If .leOblFinDoc.Count > 0 Then
                        For Each oeOblDoc In .leOblFinDoc
                            oeOblDoc.IdObligacionFinanciera = .Id
                            oeOblDoc.PrefijoID = oeObligacionFin.PrefijoID '@0001
                            odObligacionDoc.Guardar(oeOblDoc)
                        Next
                    End If
                End With
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarLista(ByVal leObligacionFin As List(Of e_ObligacionFin)) As Boolean
        Try
            For Each oeObliFin In leObligacionFin
                Guardar(oeObliFin)
            Next
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function GuardarObligacion(ByVal oeObligacionFinanciera As e_ObligacionFinanciera, ByVal oeAsiento As e_Asiento) As Boolean
        Try
            Dim stResultado() As String
            With oeObligacionFinanciera
                stResultado = sqlhelper.ExecuteScalar("FIN.ISP_ObligacionFinanciera_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .Codigo _
                        , .IdEmpresaBanco _
                        , .Glosa _
                        , .FechaEmision _
                        , .FechaVencimiento _
                        , .IdTipoObligacion _
                        , .IdMoneda _
                        , .TipoCambio _
                        , .MontoMN _
                        , .MontoME _
                        , .Saldo _
                        , .TasaInteres _
                        , .MontoInteresTes _
                        , .MontoInteresCon _
                        , .MontoInteresMoratorio _
                        , .Comision _
                        , .Activo _
                        , .IdCuentaContable _
                        , "" _
                        , .Cuota _
                        , .NroCuotas _
                        , .ActivoLeasing _
                        , "" _
                        , .IndClienteProveedor _
                        , .IdClienteProveedor _
                        , .ActivoLetras _
                        , .UsuarioCreacion _
                        , .MacPcLocalCreacion _
                        , ._IdCuentaContableInteres _
                        , .IdCuentaBancaria _
                        , .Gastos _
                        , .CodigoUnico _
                        , .NroLetra _
                        , .FechaInicial _
                        , .MontoInteresDscto
                        ).ToString.Split("_")

                oeObligacionFinanciera.Id = stResultado(0)
                If Not oeAsiento Is Nothing Then
                    '-----asiento de provision de obligacion-----------
                    If oeAsiento.TipoOperacion = "I" Then
                        For Each obj As e_AsientoMovimiento In oeAsiento.AsientoMovimiento
                            obj.PrefijoID = oeAsiento.PrefijoID '@0001
                            obj.AsMov_ObligacionFin.PrefijoID = oeAsiento.PrefijoID '@0001
                            If Not obj.AsMov_ObligacionFin Is Nothing Then
                                If obj.AsMov_ObligacionFin.TipoOperacion = "I" Then
                                    obj.AsMov_ObligacionFin.IdObligacionFinanciera = stResultado(0)
                                End If
                            End If
                            obj.MovimientoDocumento.PrefijoID = oeAsiento.PrefijoID '@0001
                            obj.MovimientoDocumento.CuentaxCyP.PrefijoID = oeAsiento.PrefijoID '@0001
                            obj.MovimientoDocumento.CuentaxCyP.ObligacionDocumento.PrefijoID = oeAsiento.PrefijoID '@0001
                            If Not obj.MovimientoDocumento.CuentaxCyP Is Nothing Then
                                If Not obj.MovimientoDocumento.CuentaxCyP.ObligacionDocumento Is Nothing Then
                                    If obj.MovimientoDocumento.CuentaxCyP.ObligacionDocumento.TipoOperacion = "I" Then
                                        obj.MovimientoDocumento.CuentaxCyP.ObligacionDocumento.IdObligacionFinanciera = stResultado(0)
                                    End If
                                End If
                            End If
                        Next
                        Dim odAsiento As New d_Asiento
                        odAsiento.Guardar(oeAsiento, Nothing, False)
                    End If
                    '-------------------------------------------------
                End If
                If oeObligacionFinanciera.leObligacionDocumento.Count > 0 Then
                    Dim odObligacionDoc As New d_ObligacionDocumento
                    '--------------para caso de obligacion no afecta ctas x pagar o cobrar-----
                    For Each obj As e_ObligacionDocumento In oeObligacionFinanciera.leObligacionDocumento
                        obj.PrefijoID = oeAsiento.PrefijoID '@0001
                        obj.IdObligacionFinanciera = stResultado(0)
                        If obj.TipoOperacion = "I" Or obj.TipoOperacion = "A" Then
                            odObligacionDoc.Guardar(obj)
                        Else
                            odObligacionDoc.Eliminar(obj)
                        End If
                    Next
                End If

                If Not .oeObligacionPago Is Nothing Then
                    If .oeObligacionPago.TipoOperacion <> "" Then
                        Dim OdObligacionPago As New d_ObligacionPago
                        .oeObligacionPago.PrefijoID = oeAsiento.PrefijoID '@0001
                        .oeObligacionPago.IdMovimientoCajaBanco = ._IdMovimientoCajaBanco
                        .oeObligacionPago._IdAsientoMovimiento = ._IdAsientoMovimiento
                        OdObligacionPago.Guardar(.oeObligacionPago)
                    End If

                End If

            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function GuardarObligacion2(ByVal oeObligacionFin As e_ObligacionFin) As Boolean
        Try
            Dim stResultado() As String
            With oeObligacionFin
                stResultado = sqlhelper.ExecuteScalar("FIN.Isp_ObligacionFin_IAE2" _
                                                          , .TipoOperacion _
                                                          , .PrefijoID _
                                                          , .Id _
                                                          , .IdContrato _
                                                          , .NroVencimiento _
                                                          , .IndPeriodoGracia _
                                                          , .FechaVencimiento _
                                                          , .MontoMN _
                                                          , .MontoME _
                                                          , .MontoInteres _
                                                          , .MontoInteresMoratorio _
                                                          , .MontoInteresDscto _
                                                          , .MontoInteresContable _
                                                          , .DiasFinMes _
                                                          , .DiasProximaCuota _
                                                          , .IndInteresMensual _
                                                          , .Comision _
                                                          , .Gastos _
                                                          , .Portes _
                                                          , .IGV _
                                                          , .ITF _
                                                          , .Saldo _
                                                          , .Glosa _
                                                          , .Cuo _
                                                          , .IdCuentaContable _
                                                          , .Usuario _
                                                          , .UsuarioModifica _
                                                          , .MacLocal _
                                                          , .Activo
                        ).ToString.Split("_")

                oeObligacionFin.Id = stResultado(0)
                If oeObligacionFin.leOblFinDoc.Count > 0 Then
                    Dim odObligacionDoc As New d_ObligacionDocumento
                    '--------------para caso de obligacion no afecta ctas x pagar o cobrar-----
                    For Each obj As e_ObligacionDocumento In oeObligacionFin.leOblFinDoc
                        obj.IdObligacionFinanciera = stResultado(0)
                        obj.PrefijoID = oeObligacionFin.PrefijoID '@0001
                        If obj.TipoOperacion = "I" Or obj.TipoOperacion = "A" Then
                            odObligacionDoc.Guardar(obj)
                        Else
                            odObligacionDoc.Eliminar(obj)
                        End If
                    Next
                End If

                If Not .oeObligacionPago Is Nothing Then
                    If .oeObligacionPago.TipoOperacion <> "" Then
                        Dim OdObligacionPago As New d_ObligacionPago
                        .oeObligacionPago.PrefijoID = oeObligacionFin.PrefijoID '@0001
                        .oeObligacionPago.IdMovimientoCajaBanco = ._IdMovimientoCajaBanco
                        .oeObligacionPago._IdAsientoMovimiento = ._IdAsientoMovimiento
                        OdObligacionPago.Guardar(.oeObligacionPago)
                    End If

                End If

            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function GuardarVariasObligaciones(ByVal leObligacionFinanciera As List(Of e_ObligacionFinanciera), _
                                              ByVal oeAsiento As e_Asiento, ByVal OeAsientoInt As e_Asiento, _
                                              Optional ByVal ProvisionaInteres As Boolean = False) As Boolean
        Try
            '
            'Dim stResultado() As String
            'Using transScope As New TransactionScope
            '    For Each oeObli As e_ObligacionFinanciera In leObligacionFinanciera
            '        With oeObli
            '            stResultado = sqlhelper.ExecuteScalar("FIN.ISP_ObligacionFinanciera_IAE", .TipoOperacion, .PrefijoID, _
            '            .Id, .Codigo, .IdEmpresaBanco, .Glosa, .FechaEmision, .FechaVencimiento, .IdTipoObligacion _
            '            , .IdMoneda, .TipoCambio, .MontoMN, .MontoME, .Saldo, .TasaInteres, .MontoInteresTes _
            '            , .MontoInteresCon, .MontoInteresMoratorio, .Comision, .Activo, .IdCuentaContable _
            '            , "", .Cuota, .NroCuotas, .ActivoLeasing, "", .IndClienteProveedor, .IdClienteProveedor _
            '            , .ActivoLetras, .UsuarioCreacion, .MacPcLocalCreacion, ._IdCuentaContableInteres, .IdCuentaBancaria, _
            '            .Gastos, .CodigoUnico, .NroLetra, .FechaInicial, .MontoInteresDscto).ToString.Split("_")
            '            oeObli.Id = stResultado(0)
            '        End With
            '        If Not oeAsiento Is Nothing Then
            '            '----------asiento de provision de obligacion---------------------------
            '            If oeAsiento.TipoOperacion = "I" Then
            '                For Each obj As e_AsientoMovimiento In oeAsiento.AsientoMovimiento
            '                    If Not obj.AsMov_ObligacionFin Is Nothing And ProvisionaInteres = False Then
            '                        If obj.AsMov_ObligacionFin.TipoOperacion = "I" _
            '                        And obj.AsMov_ObligacionFin.ObligacionFin.Equals1(oeObli) Then
            '                            obj.AsMov_ObligacionFin.IdObligacionFinanciera = stResultado(0)
            '                        End If
            '                    End If
            '                    If Not obj.MovimientoDocumento.CuentaxCyP Is Nothing Then
            '                        If Not obj.MovimientoDocumento.CuentaxCyP.ObligacionDocumento Is Nothing Then
            '                            If obj.MovimientoDocumento.CuentaxCyP.ObligacionDocumento.TipoOperacion = "I" _
            '                            And obj.AsMov_ObligacionFin.ObligacionFin.Equals1(oeObli) Then
            '                                obj.MovimientoDocumento.CuentaxCyP.ObligacionDocumento.IdObligacionFinanciera = stResultado(0)
            '                            End If
            '                        End If
            '                    End If
            '                Next
            '            End If
            '            '-------------------------------------------------------------------
            '        End If
            '        If Not OeAsientoInt Is Nothing Then
            '            '-----asiento de provision de la obligacion y de los intereses de la obligacion (FACTORY)-----------
            '            If OeAsientoInt.TipoOperacion = "I" Then
            '                For Each obj As e_AsientoMovimiento In OeAsientoInt.AsientoMovimiento
            '                    If Not obj.AsMov_ObligacionFin Is Nothing Then
            '                        If obj.AsMov_ObligacionFin.TipoOperacion = "I" _
            '                        And obj.AsMov_ObligacionFin.ObligacionFin.Equals1(oeObli) Then
            '                            obj.AsMov_ObligacionFin.IdObligacionFinanciera = stResultado(0)
            '                        End If
            '                    End If
            '                Next
            '            End If
            '            '---------------------------------------------------------------------------------
            '        End If
            '        If oeObli.leObligacionDocumento.Count > 0 Then
            '            Dim odObligacionDoc As New d_ObligacionDocumento
            '            '--------------para caso de obligacion no afecta ctas x pagar o cobrar-----
            '            For Each obj As e_ObligacionDocumento In oeObli.leObligacionDocumento
            '                obj.IdObligacionFinanciera = stResultado(0)
            '                If obj.TipoOperacion = "I" Or obj.TipoOperacion = "A" Then
            '                    odObligacionDoc.Guardar(obj)
            '                Else
            '                    odObligacionDoc.Eliminar(obj)
            '                End If
            '            Next
            '            '----------------------------------------------------------------------------
            '        End If
            '    Next
            '    Dim odAsiento As New d_Asiento
            '    odAsiento.Guardar(oeAsiento, False)
            '    If Not OeAsientoInt Is Nothing Then
            '        odAsiento.Guardar(OeAsientoInt, False)
            '    End If
            '    transScope.Complete()
            'End Using
            'Return True
            Return False
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarLetras(ByVal DTOBLIGACION As DataTable, ByVal DTFECLETRAS As DataTable, DTOBLIDOC As DataTable _
                                 , ByVal DTAsiento As DataTable, ByVal DTAsientoMovimiento As DataTable _
                                , ByVal DTAM_MovDoc As DataTable, ByVal DTCtaxCyP As DataTable _
                                , ByVal DTAMOFIN As DataTable, ByVal DTMA As DataTable _
                                , ByVal ListaDoc As List(Of e_MovimientoDocumento)) As Boolean
        Try

            Using transScope As New TransactionScope

                sqlhelper.InsertarMasivo("FIN.ObligacionFinanciera", DTOBLIGACION, False)
                sqlhelper.InsertarMasivo("FIN.FecLetras", DTFECLETRAS, False)
                sqlhelper.InsertarMasivo("FIN.ObligacionDocumento", DTOBLIDOC, False)
                sqlhelper.InsertarMasivo("CON.Asiento", DTAsiento, False)
                sqlhelper.InsertarMasivo("CON.AsientoMovimiento", DTAsientoMovimiento, False)
                sqlhelper.InsertarMasivo("CON.AsientoMov_MovDoc", DTAM_MovDoc, False)
                sqlhelper.InsertarMasivo("FIN.AsientoMov_ObligacionFin", DTAMOFIN, False)
                sqlhelper.InsertarMasivo("TES.CuentaxCyP", DTCtaxCyP, False)
                sqlhelper.InsertarMasivo("CON.MovimientoAnalisis", DTMA, False)

                For Each obj In ListaDoc
                    With obj
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
                                )
                    End With
                Next
                transScope.Complete()

            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarCreditoHipotecario(ByVal DOFIN As DataTable, ByVal DA As DataTable _
                                              , ByVal DAM As DataTable, ByVal DAMOFIN As DataTable _
                                              , ByVal DMCB As DataTable, DMA As DataTable) As Boolean
        Try

            Using transScope As New TransactionScope

                sqlhelper.InsertarMasivo("FIN.ObligacionFinanciera", DOFIN, False)
                sqlhelper.InsertarMasivo("CON.Asiento", DA, False)
                sqlhelper.InsertarMasivo("CON.AsientoMovimiento", DAM, False)
                sqlhelper.InsertarMasivo("FIN.AsientoMov_ObligacionFin", DAMOFIN, False)
                sqlhelper.InsertarMasivo("CON.MovimientoCajaBanco", DMCB, False)
                sqlhelper.InsertarMasivo("CON.MovimientoAnalisis", DMA, False)

                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeObligacionFinanciera As e_ObligacionFinanciera) As Boolean
        Try

            sqlhelper.ExecuteNonQuery("FIN.ISP_ObligacionFinanciera_IAE", "X", _
             "", oeObligacionFinanciera.Id, oeObligacionFinanciera.Codigo)

            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function UltimoIdInserta(ByVal PrefijoID As String) As String
        Try
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "FIN.ObligacionFinanciera ", PrefijoID
                                  )
            Return IIf(stResultado Is Nothing, PrefijoID & "000000000001", stResultado)
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class