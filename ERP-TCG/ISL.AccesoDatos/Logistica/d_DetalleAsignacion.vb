Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_DetalleAsignacion

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_DetalleAsignacion
        Try

            Dim oeDetalleAsignacion = New e_DetalleAsignacion( _
                               o_fila("Id").ToString _
                             , o_fila("IdRegistroInventario").ToString _
                             , o_fila("IdMarca").ToString _
                             , o_fila("NombreMarca").ToString _
                             , o_fila("IdModelo").ToString _
                             , o_fila("NombreModelo").ToString _
                             , o_fila("IdEstado").ToString _
                             , o_fila("NombreEstado").ToString _
                             , o_fila("Serie").ToString _
                             , o_fila("Especificaciones").ToString _
                             , o_fila("FechaVencimiento"))
            Return oeDetalleAsignacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDetalleAsignacion As e_DetalleAsignacion) As e_DetalleAsignacion

        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("ALM.Isp_DetalleAsignacion_Listar", "", _
            Left(d_DatosConfiguracion.PrefijoID, 1), "", oeDetalleAsignacion.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeDetalleAsignacion = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeDetalleAsignacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeDetalleAsignacion As e_DetalleAsignacion) As List(Of e_DetalleAsignacion)
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ldDetalleAsignacion As New List(Of e_DetalleAsignacion)
            Dim ds As DataSet
            With oeDetalleAsignacion
                ds = sqlhelper.ExecuteDataset("ALM.Isp_DetalleAsignacion_Listar", "" _
                                              , .Id _
                                              , .IdModelo _
                                              , .IdEstado _
                                              , .Serie _
                                              , .Especificaciones _
                                              , .IdRegistroInventario)
            End With
            oeDetalleAsignacion = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeDetalleAsignacion = Cargar(o_Fila)
                    ldDetalleAsignacion.Add(oeDetalleAsignacion)
                Next
            End If
            Return ldDetalleAsignacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeDetalleAsignacion As e_DetalleAsignacion) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeDetalleAsignacion
                sqlhelper.ExecuteNonQuery("ALM.Isp_DetalleAsignacion_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .IdModelo _
                        , .IdEstado _
                        , .Serie _
                        , .Especificaciones _
                        , .IdRegistroInventario _
                        , .Activo _
                        , .FechaVencimiento)
            End With
            Return True
        Catch ex As Exception
            Throw ex 
        End Try
    End Function

    Public Function Eliminar(ByVal oeDetalleAsignacion As e_DetalleAsignacion) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("ALM.Isp_DetalleAsignacion_IAE", "E", _
             "", oeDetalleAsignacion.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class