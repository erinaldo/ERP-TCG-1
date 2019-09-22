Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

''' <summary>
''' Clase que permite el acceso a los datos de detalle en la asignación de materiales a almacén
''' </summary>
''' <remarks></remarks>
Public Class d_DetalleMaterialAsignacion

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_DetalleMaterialAsignacion
        Try
            Dim oeDetalleMaterialAsignacion = New e_DetalleMaterialAsignacion( _
                             o_fila("Id").ToString _
                             , o_fila("IdOA_Material").ToString _
                             , o_fila("IdMarca").ToString _
                             , o_fila("IdModelo").ToString _
                             , o_fila("Serie").ToString _
                             , o_fila("IdEstado").ToString _
                             , o_fila("Especificaciones").ToString _
                             , o_fila("FechaVencimiento").ToString _
                             , o_fila("Activo").ToString)
            Return oeDetalleMaterialAsignacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDetalleMaterialAsignacion As e_DetalleMaterialAsignacion) As e_DetalleMaterialAsignacion

        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_DetalleMaterialAsignacion_Listar", "", _
             oeDetalleMaterialAsignacion.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeDetalleMaterialAsignacion = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeDetalleMaterialAsignacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeDetalleMaterialAsignacion As e_DetalleMaterialAsignacion) As List(Of e_DetalleMaterialAsignacion)
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ldDetalleMaterialAsignacion As New List(Of e_DetalleMaterialAsignacion)
            Dim ds As DataSet
            With oeDetalleMaterialAsignacion
                ds = sqlhelper.ExecuteDataset("STD.Isp_DetalleMaterialAsignacion_Listar", .TipoOperacion _
                        , .Id _
                        , .IdRequerimientoMaterial _
                        , .IdMarca _
                        , .IdModelo _
                        , .Serie _
                        , .IdEstado _
                        , .Especificaciones _
                        , .Activo _
                        )
            End With
            oeDetalleMaterialAsignacion = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeDetalleMaterialAsignacion = Cargar(o_Fila)
                    ldDetalleMaterialAsignacion.Add(oeDetalleMaterialAsignacion)
                Next
            End If
            Return ldDetalleMaterialAsignacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDetalleMaterial(ByVal oeDetalleMaterial As e_DetalleMaterialAsignacion) As DataSet
        Try
            Dim ds As DataSet
            With oeDetalleMaterial
                ds = sqlhelper.ExecuteDataset("STD.Isp_DetalleMaterialAsignacion_Listar", _
                                                .TipoOperacion, _
                                                .Id, _
                                                .IdRequerimientoMaterial, _
                                                .IdMarca, _
                                                .IdModelo, _
                                                .Serie, _
                                                .IdEstado, _
                                                .Especificaciones, _
                                                .Activo, _
                                                .IdRequerimiento)
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeDetalleMaterialAsignacion As e_DetalleMaterialAsignacion) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeDetalleMaterialAsignacion
                sqlhelper.ExecuteNonQuery("STD.Isp_DetalleMaterialAsignacion_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .IdRequerimientoMaterial _
                        , .IdMarca _
                        , .IdModelo _
                        , .Serie _
                        , .IdEstado _
                        , .Especificaciones _
                        , .FechaVencimiento _
                        , .Activo _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex 
        End Try
    End Function

    Public Function Eliminar(ByVal oeDetalleMaterialAsignacion As e_DetalleMaterialAsignacion) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_DetalleMaterialAsignacion_IAE", "E", _
             "", oeDetalleMaterialAsignacion.Id, oeDetalleMaterialAsignacion.IdRequerimientoMaterial)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class

