Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_GradoIncidencia
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_GradoIncidencia
        Try
            Dim oeGradoIncidencia = New e_GradoIncidencia( _
                             o_Fila("Id").ToString _
                             , o_Fila("Nombre").ToString _
                             , o_Fila("Activo").ToString _
                             , o_Fila("UsuarioCreacion").ToString _
                             , o_Fila("FechaCreacion").ToString _
                             , o_Fila("FechaModifica").ToString _
                             , o_Fila("UsuarioModifica").ToString _
            )
            Return oeGradoIncidencia
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeGradoIncidencia As e_GradoIncidencia) As e_GradoIncidencia

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("SPC.Isp_GradoIncidencia_Listar", "", oeGradoIncidencia.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeGradoIncidencia = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeGradoIncidencia
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeGradoIncidencia As e_GradoIncidencia) As List(Of e_GradoIncidencia)
        Try
            Dim ldGradoIncidencia As New List(Of e_GradoIncidencia)
            Dim ds As DataSet
            With oeGradoIncidencia
                ds = sqlhelper.ExecuteDataset("SPC.Isp_GradoIncidencia_Listar", "" _
                        , .Id _
                        , .Nombre _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .FechaCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        )
            End With
            oeGradoIncidencia = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeGradoIncidencia = Cargar(o_Fila)
                ldGradoIncidencia.Add(oeGradoIncidencia)
            Next
            Return ldGradoIncidencia
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeGradoIncidencia As e_GradoIncidencia) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeGradoIncidencia
                sqlhelper.ExecuteNonQuery("SPC.Isp_GradoIncidencia_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .Nombre _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .FechaCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeGradoIncidencia As e_GradoIncidencia) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SPC.Isp_GradoIncidencia_IAE", "E", _
             "", oeGradoIncidencia.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class