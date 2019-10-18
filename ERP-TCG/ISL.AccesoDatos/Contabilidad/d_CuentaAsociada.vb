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

Public Class d_CuentaAsociada
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_CuentaAsociada
        Try
            Dim oeCuentaAsociada = New e_CuentaAsociada( _
                             o_fila("Id").ToString _
                             , o_fila("IdCuentaContable").ToString _
                             , o_fila("DebeHaber").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("IdCuentaAsociada").ToString _
                             , o_fila("IdGastoFuncion").ToString _
            )
            Return oeCuentaAsociada
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCuentaAsociada As e_CuentaAsociada) As e_CuentaAsociada

        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("CON.ISP_CuentaAsociada_Listar", "", oeCuentaAsociada.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeCuentaAsociada = Cargar(ds.Tables(0).Rows(0))

            End If
            Return oeCuentaAsociada
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCuentaAsociada As e_CuentaAsociada) As List(Of e_CuentaAsociada)
        Try
            Dim ldCuentaAsociada As New List(Of e_CuentaAsociada)
            Dim ds As DataSet
            With oeCuentaAsociada
                ds = SqlHelper.ExecuteDataset("CON.ISP_CuentaAsociada_Listar", "" _
                        , .Id _
                        , .IdCuentaContable _
                        , .DebeHaber _
                        , .IdCuentaAsociada _
                        , .Activo _
                        )
            End With
            oeCuentaAsociada = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeCuentaAsociada = Cargar(o_Fila)
                    ldCuentaAsociada.Add(oeCuentaAsociada)
                Next
            End If
            Return ldCuentaAsociada
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCuentaAsociada As e_CuentaAsociada) As Boolean
        Try
            With oeCuentaAsociada
                sqlhelper.ExecuteNonQuery("CON.ISP_CuentaAsociada_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdCuentaContable _
                        , .DebeHaber _
                        , .IdCuentaAsociada _
                        , .Activo _
                        , .GastoFuncion
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeCuentaAsociada As e_CuentaAsociada) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("CON.ISP_CuentaAsociada_IAE", "E", _
             "", oeCuentaAsociada.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
