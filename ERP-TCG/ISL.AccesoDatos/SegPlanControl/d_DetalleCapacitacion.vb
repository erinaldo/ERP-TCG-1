Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_DetalleCapacitacion

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_DetalleCapacitacion
        Try
            Dim oeDetalleCapacitacion = New e_DetalleCapacitacion( _
                             o_fila("Id").ToString _
                             , o_fila("IdCapacitacion").ToString _
                             , o_fila("IdAsistente").ToString _
                             , o_fila("Asistente").ToString _
                             , o_fila("IndAsistencia") _
                             , o_fila("Observacion").ToString _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaModifica") _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("Activo") _
            )
            Return oeDetalleCapacitacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDetalleCapacitacion As e_DetalleCapacitacion) As e_DetalleCapacitacion

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("SPC.Isp_DetalleCapacitacion_Listar", "", oeDetalleCapacitacion.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeDetalleCapacitacion = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeDetalleCapacitacion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDetalleCapacitacion As e_DetalleCapacitacion) As List(Of e_DetalleCapacitacion)
        Try
            Dim ldDetalleCapacitacion As New List(Of e_DetalleCapacitacion)
            Dim ds As DataSet
            With oeDetalleCapacitacion
                ds = sqlhelper.ExecuteDataset("SPC.Isp_DetalleCapacitacion_Listar", "" _
                        , .Id _
                        , .IdCapacitacion _
                        , .IdAsistente _
                        , .IndAsistencia _
                        , .Observacion _
                        , .Activo _
                        )
            End With
            oeDetalleCapacitacion = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeDetalleCapacitacion = Cargar(o_Fila)
                ldDetalleCapacitacion.Add(oeDetalleCapacitacion)
            Next
            Return ldDetalleCapacitacion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDetalleCapacitacion As e_DetalleCapacitacion) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeDetalleCapacitacion
                sqlhelper.ExecuteNonQuery("SPC.Isp_DetalleCapacitacion_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .IdCapacitacion _
                        , .IdAsistente _
                        , .IndAsistencia _
                        , .Observacion _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeDetalleCapacitacion As e_DetalleCapacitacion) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SPC.Isp_DetalleCapacitacion_IAE", "E", _
             "", oeDetalleCapacitacion.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
