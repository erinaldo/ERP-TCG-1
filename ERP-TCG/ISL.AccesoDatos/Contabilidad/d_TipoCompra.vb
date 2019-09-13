Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_TipoCompra

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_TipoCompra
        Try
            Dim oeTipoCompra = New e_TipoCompra( _
                             o_fila("Id").ToString _
                             , o_fila("IdTablaContableDet").ToString _
                             , o_fila("Cuenta").ToString _
                             , o_fila("IdCuentaContable60").ToString _
                             , o_fila("Nombre60").ToString _
                             , o_fila("IdCuentaContable61").ToString _
                             , o_fila("Nombre61").ToString _
                             , o_fila("Ejercicio").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeTipoCompra
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoCompra As e_TipoCompra) As e_TipoCompra

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_TipoCompra_Listar", oeTipoCompra.TipoOperacion, oeTipoCompra.Id, _
                                          oeTipoCompra.IdTablaContableDet)
            If ds.Tables(0).Rows.Count > 0 Then
                oeTipoCompra = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeTipoCompra
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTipoCompra As e_TipoCompra) As List(Of e_TipoCompra)
        Try
            Dim ldTipoCompra As New List(Of e_TipoCompra)
            Dim ds As DataSet
            With oeTipoCompra
                ds = sqlhelper.ExecuteDataset("CON.Isp_TipoCompra_Listar", .TipoOperacion _
                        , .Id _
                        , .IdTablaContableDet _
                        , .Cuenta _
                        , .IdCuentaContable60 _
                        , .IdCuentaContable61 _
                        , .Ejercicio _
                        , .Activo _
                        )
            End With
            oeTipoCompra = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeTipoCompra = Cargar(o_Fila)
                ldTipoCompra.Add(oeTipoCompra)
            Next
            Return ldTipoCompra
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoCompra As e_TipoCompra) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeTipoCompra
                sqlhelper.ExecuteNonQuery("CON.Isp_TipoCompra_IAE", .TipoOperacion, .PrefijoID, _
                .Id _
                , .IdTablaContableDet _
                , .Cuenta _
                , .IdCuentaContable60 _
                , .IdCuentaContable61 _
                , .Ejercicio _
                , .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeTipoCompra As e_TipoCompra) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.Isp_TipoCompra_IAE", "E", _
             "", oeTipoCompra.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
