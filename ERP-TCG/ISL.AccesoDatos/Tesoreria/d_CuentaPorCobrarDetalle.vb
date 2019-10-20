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

Public Class d_CuentaPorCobrarDetalle
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_CuentaPorCobrarDetalle
        Try
            Dim oeCuentaPorCobrarDetalle = New e_CuentaPorCobrarDetalle( _
                             o_fila("Id").ToString _
                             , o_fila("IdCuentaPorCobrar").ToString _
                             , o_fila("Concepto").ToString _
                             , o_fila("Monto").ToString _
                             , o_fila("Saldo").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("IdMedioPago").ToString _
                             , o_fila("TipoPago").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeCuentaPorCobrarDetalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCuentaPorCobrarDetalle As e_CuentaPorCobrarDetalle) As e_CuentaPorCobrarDetalle

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_CuentaPorCobrarDetalle_Listar", "1", oeCuentaPorCobrarDetalle.Id)
            oeCuentaPorCobrarDetalle = New e_CuentaPorCobrarDetalle
            If ds.Tables.Count > 0 Then
                oeCuentaPorCobrarDetalle = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeCuentaPorCobrarDetalle
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCuentaPorCobrarDetalle As e_CuentaPorCobrarDetalle) As List(Of e_CuentaPorCobrarDetalle)
        Try
            Dim ldCuentaPorCobrarDetalle As New List(Of e_CuentaPorCobrarDetalle)
            Dim ds As DataSet
            With oeCuentaPorCobrarDetalle
                ds = sqlhelper.ExecuteDataset("TES.Isp_CuentaPorCobrarDetalle_Listar", "1" _
                        , .Id _
                        , .IdCuentaPorCobrar _
                        , .Activo _
                        )
            End With
            oeCuentaPorCobrarDetalle = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeCuentaPorCobrarDetalle = Cargar(o_Fila)
                    ldCuentaPorCobrarDetalle.Add(oeCuentaPorCobrarDetalle)
                Next
                Return ldCuentaPorCobrarDetalle
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCuentaPorCobrarDetalle As e_CuentaPorCobrarDetalle) As Boolean
        Try
            With oeCuentaPorCobrarDetalle
                sqlhelper.ExecuteNonQuery("TES.Isp_CuentaPorCobrarDetalle_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdCuentaPorCobrar _
                        , .Concepto _
                        , .Monto _
                        , .Saldo _
                        , .Fecha _
                        , .IdTipoPago _
                        , .UsuarioCreacion _
                        , .Activo
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeCuentaPorCobrarDetalle As e_CuentaPorCobrarDetalle) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_CuentaPorCobrarDetalle_IAE", "E", _
             "", oeCuentaPorCobrarDetalle.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class