Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_TipoFeriado
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_TipoFeriado
        Try
            Dim oeTipoFeriado = New e_TipoFeriado( _
                             o_fila("Id").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeTipoFeriado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoFeriado As e_TipoFeriado) As e_TipoFeriado
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_TipoFeriado_Listar", "", oeTipoFeriado.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeTipoFeriado = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeTipoFeriado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeTipoFeriado As e_TipoFeriado) As List(Of e_TipoFeriado)
        Try
            Dim ldTipoFeriado As New List(Of e_TipoFeriado)
            Dim ds As DataSet
            With oeTipoFeriado
                ds = sqlhelper.ExecuteDataset("STD.Isp_TipoFeriado_Listar", "" _
                        , .Id _
                        , .Nombre _
                        , .Activo _
                        )
            End With
            oeTipoFeriado = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeTipoFeriado = Cargar(o_Fila)
                ldTipoFeriado.Add(oeTipoFeriado)
            Next
            Return ldTipoFeriado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoFeriado As e_TipoFeriado) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeTipoFeriado
                sqlhelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .Nombre _
                        , .Activo _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeTipoFeriado As e_TipoFeriado) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
             "", oeTipoFeriado.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
