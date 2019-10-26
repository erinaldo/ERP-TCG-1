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

Public Class d_DepositoDetalle
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_DepositoDetalle
        Try
            Dim oeDepositoDetalle = New e_DepositoDetalle( _
                             o_fila("Id").ToString _
                             , o_fila("IdDeposito").ToString _
                             , o_fila("IdMovimientoFlete").ToString _
                             , o_fila("Importe").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Viaje") _
                             , o_fila("Trabajador") _
                             , o_fila("Fecha") _
                             , o_fila("Flete") _
                             , o_fila("Carga") _
                             , o_fila("IdCliente") _
                             , o_fila("Cliente") _
                             , o_fila("SaldoPorDepositar") _
                             , o_fila("IdMovimiento").ToString _
                             , o_fila("IdGrupo").ToString _
                        )
            Return oeDepositoDetalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDepositoDetalle As e_DepositoDetalle) As e_DepositoDetalle

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_DepositoDetalle_Listar", "", oeDepositoDetalle.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeDepositoDetalle = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeDepositoDetalle
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDepositoDetalle As e_DepositoDetalle) As List(Of e_DepositoDetalle)
        Try
            Dim ldDepositoDetalle As New List(Of e_DepositoDetalle)
            Dim ds As DataSet
            With oeDepositoDetalle
                ds = sqlhelper.ExecuteDataset("TES.Isp_DepositoDetalle_Listar", .TipoOperacion _
                        , .Id _
                        , .IdDeposito _
                        , .IdMovimientoFlete
                        )
            End With
            oeDepositoDetalle = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeDepositoDetalle = Cargar(o_Fila)
                    ldDepositoDetalle.Add(oeDepositoDetalle)
                Next
            End If
            Return ldDepositoDetalle
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDepositoDetalle As e_DepositoDetalle) As Boolean
        Try
            With oeDepositoDetalle
                sqlhelper.ExecuteNonQuery("TES.Isp_DepositoDetalle_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdDeposito _
                        , .IdMovimientoFlete _
                        , .Importe _
                        , .Glosa _
                        , .Activo _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .IdOperacionDetalle _
                        , .IdViaje)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeDepositoDetalle As e_DepositoDetalle) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_DepositoDetalle_IAE", "E", _
            oeDepositoDetalle.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
