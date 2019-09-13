Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_DetalleEntornoTrabajo

    Dim SqlHelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_DetalleEntornoTrabajo
        Try
            Dim oeDetalleEntornoTrabajo = New e_DetalleEntornoTrabajo( _
                             o_fila("Id").ToString _
                             , o_fila("IdUsuario").ToString _
                             , o_fila("IdEntornoTrabajo").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeDetalleEntornoTrabajo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDetalleEntornoTrabajo As e_DetalleEntornoTrabajo) As e_DetalleEntornoTrabajo

        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("SGD.ISP_DetalleEntornoTrabajo_Listar", "", oeDetalleEntornoTrabajo.Id)
            If ds.Tables.Count > 0 Then
                oeDetalleEntornoTrabajo = Cargar(ds.Tables(0).Rows(0))
                Return oeDetalleEntornoTrabajo
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDetalleEntornoTrabajo As e_DetalleEntornoTrabajo) As List(Of e_DetalleEntornoTrabajo)
        Try
            Dim ldDetalleEntornoTrabajo As New List(Of e_DetalleEntornoTrabajo)
            Dim ds As DataSet
            With oeDetalleEntornoTrabajo
                ds = SqlHelper.ExecuteDataset("SGD.ISP_DetalleEntornoTrabajo_Listar", "" _
                        , .Id _
                        , .IdUsuario _
                        , .IdEntornoTrabajo _
                        )
            End With
            oeDetalleEntornoTrabajo = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeDetalleEntornoTrabajo = Cargar(o_Fila)
                    ldDetalleEntornoTrabajo.Add(oeDetalleEntornoTrabajo)
                Next
                '    Return ldDetalleEntornoTrabajo
                'Else
                '    Return Nothing
            End If
            Return ldDetalleEntornoTrabajo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDetalleEntornoTrabajo As e_DetalleEntornoTrabajo) As Boolean
        Try

            Dim d_DatosConfiguracion As New d_DatosConfiguracion

            With oeDetalleEntornoTrabajo
                SqlHelper.ExecuteNonQuery("SGD.ISP_DetalleEntornoTrabajo_IAE", .TipoOperacion, _
                        .Id _
                        , .IdUsuario _
                        , .IdEntornoTrabajo _
                        , .Activo _
                        , .PrefijoID _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeDetalleEntornoTrabajo As e_DetalleEntornoTrabajo) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("SGD.ISP_DetalleEntornoTrabajo_IAE", "E", oeDetalleEntornoTrabajo.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
