Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_AsistenciaPersonal
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_AsistenciaPersonal
        Try
            Dim oeAsistenciaPersonal = New e_AsistenciaPersonal( _
                             o_fila("Id").ToString _
                             , o_fila("IdTrabajador").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("Retraso").ToString _
                             , o_fila("IndIngresoSalida").ToString _
            )
            Return oeAsistenciaPersonal
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeAsistenciaPersonal As e_AsistenciaPersonal) As e_AsistenciaPersonal

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "", oeAsistenciaPersonal.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeAsistenciaPersonal = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeAsistenciaPersonal
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeAsistenciaPersonal As e_AsistenciaPersonal) As List(Of e_AsistenciaPersonal)
        Try
            Dim ldAsistenciaPersonal As New List(Of e_AsistenciaPersonal)
            Dim ds As DataSet
            With oeAsistenciaPersonal
                ds = sqlhelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "" _
                        , .Id _
                        , .IdTrabajador _
                        , .Fecha _
                        , .Retraso _
                        , .IndIngresoSalida _
                        )
            End With
            oeAsistenciaPersonal = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeAsistenciaPersonal = Cargar(o_Fila)
                ldAsistenciaPersonal.Add(oeAsistenciaPersonal)
            Next
            Return ldAsistenciaPersonal
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeAsistenciaPersonal As e_AsistenciaPersonal) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeAsistenciaPersonal
                sqlhelper.ExecuteNonQuery("PER.Isp_AsistenciaPersonal_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .IdTrabajador _
                        , .Fecha)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeAsistenciaPersonal As e_AsistenciaPersonal) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
             "", oeAsistenciaPersonal.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
