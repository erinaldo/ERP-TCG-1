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

Public Class d_CuentaFlujoCaja
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_CuentaFlujoCaja
        Try
            Dim oeCuentaFlujoCaja = New e_CuentaFlujoCaja( _
                             o_fila("Id").ToString _
                             , o_fila("IdCuentaContable").ToString _
                             , o_fila("IdFlujoCaja").ToString _
                             , o_fila("Ejercicio").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("Cuenta").ToString _
            )
            Return oeCuentaFlujoCaja
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCuentaFlujoCaja As e_CuentaFlujoCaja) As e_CuentaFlujoCaja

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.CuentaFlujoCaja_Listar", oeCuentaFlujoCaja.TipoOperacion _
                                          , oeCuentaFlujoCaja.Id _
                                          , oeCuentaFlujoCaja.IdCuentaContable _
                                          , oeCuentaFlujoCaja.IdFlujoCaja)
            If ds.Tables(0).Rows.Count > 0 Then
                oeCuentaFlujoCaja = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeCuentaFlujoCaja
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCuentaFlujoCaja As e_CuentaFlujoCaja) As List(Of e_CuentaFlujoCaja)
        Try
            Dim ldCuentaFlujoCaja As New List(Of e_CuentaFlujoCaja)
            Dim ds As DataSet
            With oeCuentaFlujoCaja
                ds = sqlhelper.ExecuteDataset("TES.CuentaFlujoCaja_Listar", "L" _
                        , .Id _
                        , .IdCuentaContable _
                        , .IdFlujoCaja _
                        , .Ejercicio _
                        , .Activo _
                        )
            End With
            oeCuentaFlujoCaja = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeCuentaFlujoCaja = Cargar(o_Fila)
                ldCuentaFlujoCaja.Add(oeCuentaFlujoCaja)
            Next
            Return ldCuentaFlujoCaja
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCuentaFlujoCaja As e_CuentaFlujoCaja) As Boolean
        Try
            With oeCuentaFlujoCaja
                sqlhelper.ExecuteNonQuery("TES.CuentaFlujoCaja_IAE", "I", .PrefijoID,
                        .Id _
                        , .IdCuentaContable _
                        , .IdFlujoCaja _
                        , .Ejercicio _
                        , .Activo
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeCuentaFlujoCaja As e_CuentaFlujoCaja) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.CuentaFlujoCaja_IAE", "E", _
             "", oeCuentaFlujoCaja.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class
