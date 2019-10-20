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

Public Class d_ServicioCuentaContable
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_ServicioCuentaContable
        Try
            Dim oeServicioCuentaContable = New e_ServicioCuentaContable( _
                             o_fila("Id").ToString _
                             , o_fila("IdServicio").ToString _
                             , o_fila("IdCuentaContableHaber").ToString _
                             , o_fila("IdCuentaContableDebe").ToString _
                             , o_fila("Ejercicio").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("CuentaHaber").ToString _
                             , o_fila("CuentaDebe").ToString _
            )
            Return oeServicioCuentaContable
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeServicioCuentaContable As e_ServicioCuentaContable) As e_ServicioCuentaContable

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("Isp_ServicioCuentaContable_Listar", "", oeServicioCuentaContable.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeServicioCuentaContable = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeServicioCuentaContable
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeServicioCuentaContable As e_ServicioCuentaContable) As List(Of e_ServicioCuentaContable)
        Try
            Dim ldServicioCuentaContable As New List(Of e_ServicioCuentaContable)
            Dim ds As DataSet
            With oeServicioCuentaContable
                ds = sqlhelper.ExecuteDataset("CON.Isp_ServicioCuentaContable_Listar", .TipoOperacion _
                        , .Id _
                        , .IdServicio _
                        , .IdCuentaContableHaber _
                        , .IdCuentaContableDebe _
                        , .Ejercicio _
                        , .Activo _
                        )
            End With
            oeServicioCuentaContable = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeServicioCuentaContable = Cargar(o_Fila)
                ldServicioCuentaContable.Add(oeServicioCuentaContable)
            Next
            Return ldServicioCuentaContable
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeServicioCuentaContable As e_ServicioCuentaContable) As Boolean
        Try
            With oeServicioCuentaContable
                sqlhelper.ExecuteNonQuery("CON.Isp_ServicioCuentaContable_IAE", "I", .PrefijoID,
                        .Id _
                        , .IdServicio _
                        , .IdCuentaContableHaber _
                        , .IdCuentaContableDebe _
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

    Public Function Eliminar(ByVal oeServicioCuentaContable As e_ServicioCuentaContable) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.Isp_ServicioCuentaContable_IAE", "E", _
             "", oeServicioCuentaContable.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class
