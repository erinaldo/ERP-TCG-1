Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_HistorialRechazoOC
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_HistorialRechazoOC
        Try
            Dim oeHistorialRechazoOC = New e_HistorialRechazoOC( _
                             o_fila("Id").ToString _
                             , o_fila("IdOrdenCompra").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("NroOrden").ToString _
                             , o_fila("UsuarioCreacion").ToString)
            Return oeHistorialRechazoOC
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeHistorialRechazoOC As e_HistorialRechazoOC) As e_HistorialRechazoOC

        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "", _
            Left(d_DatosConfiguracion.PrefijoID, 1), "", oeHistorialRechazoOC.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeHistorialRechazoOC = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeHistorialRechazoOC
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeHistorialRechazoOC As e_HistorialRechazoOC) As List(Of e_HistorialRechazoOC)
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ldHistorialRechazoOC As New List(Of e_HistorialRechazoOC)
            Dim ds As DataSet
            With oeHistorialRechazoOC
                ds = sqlhelper.ExecuteDataset("STD.Isp_HistorialRechazoOC_Listar", "" _
                                              , .Id _
                        , .IdOrdenCompra _
                        , .Glosa _
                        , .Fecha _
                        )
            End With
            oeHistorialRechazoOC = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeHistorialRechazoOC = Cargar(o_Fila)
                    ldHistorialRechazoOC.Add(oeHistorialRechazoOC)
                Next
            End If
            Return ldHistorialRechazoOC
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeHistorialRechazoOC As e_HistorialRechazoOC) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeHistorialRechazoOC
                sqlhelper.ExecuteNonQuery("STD.Isp_HistorialRechazoOC_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .IdOrdenCompra _
                        , .Glosa _
                        , .Fecha _
                        , .UsuarioCreacion)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeHistorialRechazoOC As e_HistorialRechazoOC) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
             "", oeHistorialRechazoOC.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
