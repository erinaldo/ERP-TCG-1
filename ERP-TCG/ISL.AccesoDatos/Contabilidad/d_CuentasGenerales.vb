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

Public Class d_CuentasGenerales
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_CuentasGenerales
        Try
            Dim oeCuentasGenerales = New e_CuentasGenerales( _
                             o_fila("Id").ToString _
                             , o_fila("IdTablaContableDet").ToString _
                             , o_fila("IdCuentaContable").ToString _
                             , o_fila("Ejercicio").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("Cuenta").ToString _
                             , o_fila("NomCuenta").ToString _
            )
            Return oeCuentasGenerales
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCuentasGenerales As e_CuentasGenerales) As e_CuentasGenerales

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_CuentasGenerales_Listar", oeCuentasGenerales.TipoOperacion, oeCuentasGenerales.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeCuentasGenerales = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeCuentasGenerales
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCuentasGenerales As e_CuentasGenerales) As List(Of e_CuentasGenerales)
        Try
            Dim ldCuentasGenerales As New List(Of e_CuentasGenerales)
            Dim ds As DataSet
            With oeCuentasGenerales
                ds = sqlhelper.ExecuteDataset("CON.Isp_CuentasGenerales_Listar", .TipoOperacion _
                        , .Id _
                        , .IdTablaContableDet _
                        , .IdCuentaContable _
                        , .Ejercicio _
                        , .Activo _
                        )
            End With
            oeCuentasGenerales = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeCuentasGenerales = Cargar(o_Fila)
                ldCuentasGenerales.Add(oeCuentasGenerales)
            Next
            Return ldCuentasGenerales
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCuentasGenerales As e_CuentasGenerales) As Boolean
        Try
            With oeCuentasGenerales
                sqlhelper.ExecuteNonQuery("CON.Isp_CuentasGenerales_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdTablaContableDet _
                        , .IdCuentaContable _
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

    Public Function Eliminar(ByVal oeCuentasGenerales As e_CuentasGenerales) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.Isp_CuentasGenerales_IAE", "E", _
             "", oeCuentasGenerales.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
