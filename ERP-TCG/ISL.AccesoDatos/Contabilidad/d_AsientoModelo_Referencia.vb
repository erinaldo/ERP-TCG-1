Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_AsientoModelo_Referencia
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_AsientoModelo_Referencia
        Try
            Dim oeAsientoModelo_Referencia = New e_AsientoModelo_Referencia( _
                             o_fila("Id").ToString _
                             , o_fila("IdAsiMod_ActNeg").ToString _
                             , o_fila("TipoReferencia") _
                             , o_fila("Referencia").ToString _
                             , o_fila("IdReferencia").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("FechaModifica") _
                             , o_fila("Activo") _
                             , o_fila("IdActividadNegocio").ToString _
            )
            Return oeAsientoModelo_Referencia
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function Cargar2(ByVal o_fila As DataRow) As e_AsientoModelo_Referencia
        Try
            Dim oeAsientoModelo_Referencia = New e_AsientoModelo_Referencia( _
                             o_fila("Id").ToString _
                             , o_fila("Referencia").ToString _
                             , o_fila("TipoReferencia") _
            )
            Return oeAsientoModelo_Referencia
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar2(ByVal oeAsientoModelo_Referencia As e_AsientoModelo_Referencia) As List(Of e_AsientoModelo_Referencia)
        Try
            Dim ldAsientoModelo_Referencia As New List(Of e_AsientoModelo_Referencia)
            Dim ds As DataSet
            With oeAsientoModelo_Referencia
                ds = sqlhelper.ExecuteDataset("CON.Isp_AsientoModelo_Referencia_Listar", .TipoOperacion)
            End With
            oeAsientoModelo_Referencia = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeAsientoModelo_Referencia = Cargar2(o_Fila)
                ldAsientoModelo_Referencia.Add(oeAsientoModelo_Referencia)
            Next
            Return ldAsientoModelo_Referencia
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeAsientoModelo_Referencia As e_AsientoModelo_Referencia) As e_AsientoModelo_Referencia

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_AsientoModelo_Referencia_Listar", "", oeAsientoModelo_Referencia.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeAsientoModelo_Referencia = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeAsientoModelo_Referencia
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeAsientoModelo_Referencia As e_AsientoModelo_Referencia) As List(Of e_AsientoModelo_Referencia)
        Try
            Dim ldAsientoModelo_Referencia As New List(Of e_AsientoModelo_Referencia)
            Dim ds As DataSet
            With oeAsientoModelo_Referencia
                ds = sqlhelper.ExecuteDataset("CON.Isp_AsientoModelo_Referencia_Listar", .TipoOperacion _
                        , .Id _
                        , .IdAsiMod_ActNeg _
                        , .TipoReferencia _
                        , .IdReferencia _
                        , .UsuarioCreacion _
                        , .FechaCreacion _
                        , .UsuarioModifica _
                        , .FechaModifica _
                        , .Activo _
                        )
            End With
            oeAsientoModelo_Referencia = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeAsientoModelo_Referencia = Cargar(o_Fila)
                ldAsientoModelo_Referencia.Add(oeAsientoModelo_Referencia)
            Next
            Return ldAsientoModelo_Referencia
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeAsientoModelo_Referencia As e_AsientoModelo_Referencia) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeAsientoModelo_Referencia
                sqlhelper.ExecuteNonQuery("CON.Isp_AsientoModelo_Referencia_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .IdAsiMod_ActNeg _
                        , .TipoReferencia _
                        , .IdReferencia _
                        , .UsuarioCreacion _
                        , .FechaCreacion _
                        , .UsuarioModifica _
                        , .FechaModifica _
                        , .Activo _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeAsientoModelo_Referencia As e_AsientoModelo_Referencia) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.Isp_AsientoModelo_Referencia_IAE", "E", _
             "", oeAsientoModelo_Referencia.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
