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

Public Class d_TipoVenta

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_TipoVenta
        Try
            Dim oeTipoVenta = New e_TipoVenta( _
                             o_fila("Id").ToString _
                             , o_fila("IdTablaContableDet").ToString _
                             , o_fila("IdCuentaContable").ToString _
                             , o_fila("Ejercicio").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("Cuenta").ToString _
            )
            Return oeTipoVenta
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoVenta As e_TipoVenta) As e_TipoVenta

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_TipoVenta_Listar", "", oeTipoVenta.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeTipoVenta = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeTipoVenta
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTipoVenta As e_TipoVenta) As List(Of e_TipoVenta)
        Try
            Dim ldTipoVenta As New List(Of e_TipoVenta)
            Dim ds As DataSet
            With oeTipoVenta
                ds = sqlhelper.ExecuteDataset("CON.Isp_TipoVenta_Listar", .TipoOperacion _
                        , .Id _
                        , .IdTablaContableDet _
                        , .IdCuentaContable _
                        , .Ejercicio _
                        , .Activo _
                        )
            End With
            oeTipoVenta = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeTipoVenta = Cargar(o_Fila)
                ldTipoVenta.Add(oeTipoVenta)
            Next
            Return ldTipoVenta
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoVenta As e_TipoVenta) As Boolean
        Try
            With oeTipoVenta
                sqlhelper.ExecuteNonQuery("CON.Isp_TipoVenta_IAE", .TipoOperacion, .PrefijoID,
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
        End Try
    End Function

    Public Function Eliminar(ByVal oeTipoVenta As e_TipoVenta) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.Isp_TipoVenta_IAE", "E", _
             "", oeTipoVenta.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
