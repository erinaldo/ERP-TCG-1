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

Public Class d_Grupo

    Private sqlhelper As New SqlHelper
    Dim oeGrupoDetalle As New e_GrupoDetalle
    Dim odGrupoDetalle As New d_GrupoDetalle

    Private Function Cargar(ByVal o_fila As DataRow) As e_Grupo
        Try
            Dim oeGrupo = New e_Grupo(o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Tipo").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("FechaEnvio").ToString _
                             , o_fila("GlosaEnvio").ToString _
                             , o_fila("ImporteTotal") _
                             , o_fila("Saldo") _
                             , o_fila("FechaReembolso").ToString _
                             , o_fila("IdEstado").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("IdCentro").ToString _
                             , o_fila("Centro").ToString _
                             , o_fila("IdCuentaCorriente").ToString _
                             , o_fila("NroCheque").ToString _
                             , o_fila("Seleccion").ToString _
                             , o_fila("IdPeriodo").ToString _
                             , o_fila("Periodo").ToString _
                             , o_fila("IdCaja").ToString)
            Return oeGrupo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeGrupo As e_Grupo) As e_Grupo
        Try
            Dim ds As DataSet
            Dim oeGrupoDetalle As New e_GrupoDetalle
            Dim odGrupoDetalle As New d_GrupoDetalle
            With oeGrupo
                ds = sqlhelper.ExecuteDataset("TES.Isp_Grupo_Listar", .TipoOperacion _
                        , .Id _
                        , .Codigo _
                        , .Tipo _
                        , .FechaDesde _
                        , .FechaHasta _
                        , .Activo _
                        , .Estado _
                        , .IdCentro)
            End With
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeGrupo = Cargar(ds.Tables(0).Rows(0))
                'oeGrupoDetalle.TipoOperacion = "L"
                'oeGrupoDetalle.IdGrupo = oeGrupo.Id
                'oeGrupo.loDetalleGrupo = odGrupoDetalle.Listar(oeGrupoDetalle)
            End If
            Return oeGrupo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeGrupo As e_Grupo) As List(Of e_Grupo)
        Try

            Dim ldGrupo As New List(Of e_Grupo)
            Dim ds As DataSet
            With oeGrupo
                ds = sqlhelper.ExecuteDataset("TES.Isp_Grupo_Listar", .TipoOperacion _
                        , .Id _
                        , .Codigo _
                        , .Tipo _
                        , .FechaDesde _
                        , .FechaHasta _
                        , .Activo _
                        , .Estado _
                        , .IdCentro _
                        , .lsGruposDescuentos _
                        , .IdChequexCobrar _
                        )
            End With
            oeGrupo = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeGrupo = Cargar(o_Fila)
                    ldGrupo.Add(oeGrupo)
                Next
            End If
            Return ldGrupo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeGrupo As e_Grupo) As String
        Try
            Dim odGrupoDetalleDesc As New d_GrupoDetalle
            Dim oeMovimiento As New e_Movimiento
            Dim odMovimiento As New d_Movimiento
            Dim oeGastoOperacion As New e_GastoOperacion
            Dim odGastoOperacion As New d_GastoOperacion
            Dim id As String = ""
            Using TransScope As New TransactionScope()
                With oeGrupo
                    id = sqlhelper.ExecuteScalar("TES.Isp_Grupo_IAE", .TipoOperacion, .PrefijoID, _
                            .Id, .Codigo, .Tipo, .Fecha, .FechaEnvio, .GlosaEnvio, .ImporteTotal, .Saldo _
                            , .FechaReembolso, .IdCentro, .IdEstado, .Activo, .UsuarioCreacion, .IdCuentaCorriente _
                            , .NroCheque, .IdChequexCobrar, .IdPeriodo, .IdCaja)
                    Select Case .Tipo
                        Case "1"
                            For Each oeGrupoDetalle As e_GrupoDetalle In .loDetalleGrupo
                                If oeGrupoDetalle.Id = "" Then
                                    oeGrupoDetalle.TipoOperacion = "I"
                                End If
                                oeGrupoDetalle.PrefijoID = oeGrupo.PrefijoID '@0001
                                odGrupoDetalle.GuardarLiq(oeGrupoDetalle)
                            Next
                        Case "2"
                            For Each oeGrupoDetalle As e_GrupoDetalle In .loDetalleGrupo
                                If oeGrupoDetalle.Id = "" Then
                                    oeGrupoDetalle.TipoOperacion = "I"
                                End If
                                oeGrupoDetalle.IdGrupo = id
                                oeGrupoDetalle.PrefijoID = oeGrupo.PrefijoID '@0001
                                odGrupoDetalle.Guardar(oeGrupoDetalle)
                                oeGastoOperacion = New e_GastoOperacion
                                oeGastoOperacion.oeRegistroCombustible = Nothing
                                oeGastoOperacion.TipoOperacion = "G"
                                oeGastoOperacion.Id = oeGrupoDetalle.IdGastoOperacion
                                oeGastoOperacion.IdGrupo = id
                                oeGastoOperacion.PrefijoID = oeGrupo.PrefijoID '@0001
                                odGastoOperacion.Guardar(oeGastoOperacion)
                            Next
                            If .TipoOperacion = "S" And .IdCentro <> "1CH001" Then
                                If .IdEstado = "ENVIADO" Then
                                    oeMovimiento = New e_Movimiento
                                    oeMovimiento.IdCuentaCorrienteDestino = .IdCuentaCorriente
                                    oeMovimiento.Fecha = .Fecha
                                    oeMovimiento.IdCuentaCorrienteOrigen = ""
                                    oeMovimiento.Ingreso = .ImporteTotal
                                    oeMovimiento.Egreso = 0
                                    oeMovimiento.Saldo = 0
                                    oeMovimiento.Glosa = "GASTOS ENVIADOS CAJA CHICA " & .Codigo & " " & .Centro
                                    oeMovimiento.IndPrestamoHab = 0
                                    oeMovimiento.Voucher = ""
                                    oeMovimiento.UsuarioCreacion = .UsuarioCreacion
                                    oeMovimiento.Descuento = 1
                                    oeMovimiento.TipoMovimiento = 2
                                    oeMovimiento.IdEstado = "HABILITADA"
                                    oeMovimiento.Activo = True
                                    oeMovimiento.TipoTransa = 0
                                    oeMovimiento.AsignadoGrupo = 0
                                    oeMovimiento.SaldoPorDepositar = 0
                                    oeMovimiento.Depositado = 0
                                    oeMovimiento.TipoOperacion = "I"
                                    oeMovimiento.IndCerrado = 1
                                    oeMovimiento.FechaCierre = Date.Parse("01/01/1901")
                                    oeMovimiento.IdCaja = .IdCaja
                                    oeMovimiento.PrefijoID = oeGrupo.PrefijoID '@0001
                                    odMovimiento.GuardarSimple(oeMovimiento)
                                End If
                            End If
                        Case "3"
                            For Each oeGrupoDetalleFlete As e_GrupoDetalle In .loDetalleGrupo
                                If oeGrupoDetalleFlete.Id = "" Then
                                    oeGrupoDetalleFlete.TipoOperacion = "I"
                                End If
                                oeGrupoDetalleFlete.IdGrupo = id
                                oeGrupoDetalleFlete.PrefijoID = oeGrupo.PrefijoID '@0001
                                odGrupoDetalleDesc.GuardarFlete(oeGrupoDetalleFlete)
                                oeGrupo.Id = id
                                Dim oeMov = New e_Movimiento
                                oeMov.Id = oeGrupoDetalleFlete.IdGastoOperacion
                                oeMov.TipoProceso = "NORMAL"
                                oeMov.TipoOperacion = "G"
                                oeMov.AsignadoGrupo = 1
                                oeMov.PrefijoID = oeGrupo.PrefijoID '@0001
                                odMovimiento.GuardarMovimiento(oeMov, New e_Movimiento)
                            Next
                        Case "4"
                            For Each oeGrupoDetalleDesc As e_GrupoDetalle In .loDetalleGrupo
                                If oeGrupoDetalleDesc.Id = "" Then
                                    oeGrupoDetalleDesc.TipoOperacion = "I"
                                End If
                                oeGrupoDetalleDesc.IdGrupo = id
                                oeGrupoDetalleDesc.IndFlete = 0
                                oeGrupoDetalleDesc.PrefijoID = oeGrupo.PrefijoID '@0001
                                odGrupoDetalleDesc.GuardarDesc(oeGrupoDetalleDesc)
                                oeMovimiento = New e_Movimiento
                                oeMovimiento.Id = oeGrupoDetalleDesc.IdGastoOperacion
                                oeMovimiento.TipoOperacion = "G"
                                oeMovimiento.TipoProceso = "NORMAL"
                                oeMovimiento.AsignadoGrupo = 1
                                oeMovimiento.PrefijoID = oeGrupo.PrefijoID '@0001
                                odMovimiento.GuardarMovimiento(oeMovimiento, New e_Movimiento)
                            Next
                    End Select
                End With
                TransScope.Complete()
            End Using
            Return id
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Enviar(ByVal oeGrupo As e_Grupo) As Boolean
        Try
            Dim odGrupoDetalle As New d_GrupoDetalle
            Dim odMovimiento As New d_Movimiento
            Using TransScope As New TransactionScope()
                oeGrupo.TipoOperacion = "S"
                Guardar(oeGrupo)
                TransScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeGrupo As e_Grupo) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_Grupo_IAE", "E", _
             "", oeGrupo.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class