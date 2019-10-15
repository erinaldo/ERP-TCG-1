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

Public Class d_Deposito
    Private sqlhelper As New SqlHelper
    Dim odDepositoDetalle As New d_DepositoDetalle
    Dim oeDepositoDetalle As New e_DepositoDetalle
    Dim oeMovimiento As New e_Movimiento
    Dim oeMovimientoFlete As New e_Movimiento_Flete
    Dim odMovimiento As New d_Movimiento
    Dim oeGrupo As New e_Grupo
    Dim odGrupo As New d_Grupo

    Public Shared IdMovimientoFleteDD As String

    Private Function Cargar(ByVal o_fila As DataRow) As e_Deposito
        Try
            Dim oeDeposito = New e_Deposito( _
                             o_fila("Id").ToString _
                             , o_fila("Numero").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("IdBanco").ToString _
                             , o_fila("Banco").ToString _
                             , o_fila("IdCuentaBancaria").ToString _
                             , o_fila("NumeroCuenta").ToString _
                             , o_fila("IdMoneda").ToString _
                             , o_fila("Moneda").ToString _
                             , o_fila("Total").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Viaje").ToString)
            Return oeDeposito
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDeposito As e_Deposito) As e_Deposito

        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.ISP_Deposito_Listar", "", _
             oeDeposito.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeDeposito = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeDeposito
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDeposito As e_Deposito) As List(Of e_Deposito)
        Try
            Dim ldDeposito As New List(Of e_Deposito)
            Dim ds As DataSet
            With oeDeposito
                ds = sqlhelper.ExecuteDataset("TES.ISP_Deposito_Listar", "" _
                        , .Id _
                        , .Numero _
                        , .IdCuentaBancaria _
                        , .Activo _
                        , .FechaDesde _
                        , .FechaHasta
                        )
            End With
            oeDeposito = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeDeposito = Cargar(o_Fila)
                    ldDeposito.Add(oeDeposito)
                Next
            End If
            Return ldDeposito
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDeposito As e_Deposito) As Boolean
        Try
            Dim strIdDeposito As String = ""
            Dim IdGrupo As String = ""
            Using TransScope As New TransactionScope()
                With oeDeposito
                    strIdDeposito = sqlhelper.ExecuteScalar("TES.Isp_Deposito_IAE", .TipoOperacion, .PrefijoID,
                            .Id _
                            , .Numero _
                            , .Fecha _
                            , .Glosa _
                            , .IdCuentaBancaria _
                            , .Total _
                            , .Activo _
                            , .FechaCreacion _
                            , .UsuarioCreacion
                        )
                    If .loDepositoDetalle.Count > 0 Then
                        IdGrupo = .loDepositoDetalle(0).IdGrupo
                        For i As Integer = 0 To .loDepositoDetalle.Count - 1
                            oeDepositoDetalle = .loDepositoDetalle(i)
                            oeDepositoDetalle.TipoOperacion = "I"
                            oeDepositoDetalle.IdDeposito = strIdDeposito
                            'oeDepositoDetalle.IdMovimientoFlete = IdMovimientoFleteDD
                            oeDepositoDetalle.PrefijoID = oeDeposito.PrefijoID '@0001
                            odDepositoDetalle.Guardar(oeDepositoDetalle)
                            'actualizar cargado y saldo por depositar en movimiento.... del flete
                            oeMovimiento = New e_Movimiento
                            oeMovimiento.Id = oeDepositoDetalle.IdMovimiento
                            oeMovimiento.TipoOperacion = "F"
                            oeMovimiento.SaldoPorDepositar = oeDepositoDetalle.SaldoPorDepositar - oeDepositoDetalle.Importe
                            oeMovimiento.TipoProceso = "NORMAL"
                            oeMovimiento.PrefijoID = oeDeposito.PrefijoID '@0001
                            odMovimiento.GuardarMovimiento(oeMovimiento, New e_Movimiento)
                        Next
                        'reducir saldo en grupo de flete para nivelar reporte ff
                        If IdGrupo <> "" Then
                            oeGrupo.TipoOperacion = "P"
                            oeGrupo.Id = IdGrupo
                            oeGrupo.Saldo = oeDepositoDetalle.SaldoPorDepositar - oeDepositoDetalle.Importe
                            oeGrupo.PrefijoID = oeDeposito.PrefijoID '@0001
                            odGrupo.Guardar(oeGrupo)
                        End If
                    End If
                End With
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeDeposito As e_Deposito) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_Deposito_IAE", "E", _
             "", oeDeposito.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class