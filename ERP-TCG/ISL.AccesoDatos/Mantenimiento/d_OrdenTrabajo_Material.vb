Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_OrdenTrabajo_Material
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_OrdenTrabajo_Material
        Try
            Dim oeOrdenTrabajoMaterial = New e_OrdenTrabajo_Material(o_fila("Id").ToString _
                             , o_fila("IdMaterial").ToString _
                             , o_fila("IdOrdenTrabajo").ToString _
                              , o_fila("IdMantenimientoEquipo").ToString _
                             , o_fila("Mantenimiento").ToString _
                              , o_fila("Equipo").ToString _
                              , o_fila("IdUnidadMedidad").ToString _
                             , o_fila("CantidadMaterial") _
                             , o_fila("CantidadMaterialEntregada") _
                             , o_fila("CantidadMaterialDevuelto") _
                             , o_fila("IdSubAlmacen") _
                              , o_fila("IdAlmacen") _
                             , o_fila("Activo"))
            Return oeOrdenTrabajoMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CargarReporteOTM(ByVal o_fila As DataRow) As e_ReporteOTMaterial
        Try
            Dim oeReporteOTM = New e_ReporteOTMaterial(o_fila("IdTipoMantenimiento").ToString _
                             , o_fila("TipoMantenimiento").ToString, o_fila("Mantenimiento").ToString _
                             , o_fila("Equipo").ToString, o_fila("TipoVehiculo").ToString, o_fila("Flota").ToString _
                             , o_fila("IdMaterial").ToString, o_fila("CodigoMat").ToString, o_fila("Material").ToString _
                             , o_fila("CantidadMaterial"), o_fila("Cantidad"), o_fila("PrecioUnit"), o_fila("Importe") _
                             , o_fila("NroOT").ToString, o_fila("FechaProgramacion"), o_fila("FechaInicioTrabajo"), o_fila("FechaPedido") _
                             , o_fila("Estado").ToString, o_fila("KmOT"))
            Return oeReporteOTM
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeOrdenTrabajoMaterial As e_OrdenTrabajo_Material) As e_OrdenTrabajo_Material
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[MAN].[Isp_OrdenTrabajo_Material_Listar]", _
                                          "", oeOrdenTrabajoMaterial.Id)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeOrdenTrabajoMaterial = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeOrdenTrabajoMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeOrdenTrabajoMaterial As e_OrdenTrabajo_Material) As List(Of e_OrdenTrabajo_Material)
        Try
            Dim ldOrdenTrabajoMaterial As New List(Of e_OrdenTrabajo_Material)
            Dim ds As DataSet
            With oeOrdenTrabajoMaterial
                ds = sqlhelper.ExecuteDataset("[MAN].[Isp_OrdenTrabajo_Material_Listar]", .TipoOperacion _
                        , .Id, .IdMaterial, .IdOrdenTrabajo, .IdMantenimientoEquipo, .CantidadMaterial _
                        , .CantidadMaterialEntregada, .CantidadMaterialDevuelto, .Activo)
            End With
            oeOrdenTrabajoMaterial = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeOrdenTrabajoMaterial = Cargar(o_Fila)
                    ldOrdenTrabajoMaterial.Add(oeOrdenTrabajoMaterial)
                Next
            End If
            Return ldOrdenTrabajoMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarReporte(ByVal oeReporteOTM As e_ReporteOTMaterial) As List(Of e_ReporteOTMaterial)
        Try
            Dim leReporteOTM As New List(Of e_ReporteOTMaterial)
            Dim ds As DataSet
            With oeReporteOTM
                ds = sqlhelper.ExecuteDataset("MAN.Isp_ReporteOTMaterial_Listar", .TipoOperacion _
                        , .IdTipoMantenimiento, .IdMantenimiento, .IdEquipo, .IdMaterial, .FechaInicio _
                        , .FechaFin, .IdAlmacen, .Tipo)
            End With
            oeReporteOTM = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeReporteOTM = CargarReporteOTM(o_Fila)
                    leReporteOTM.Add(oeReporteOTM)
                Next
            End If
            Return leReporteOTM
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal ls_IdOrdenTrabajo As String) As Data.DataSet
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[MAN].[Isp_OrdenTrabajo_Material_Listar]", "L", _
                                           "", "", ls_IdOrdenTrabajo)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeOrdenTrabajoMaterial As e_OrdenTrabajo_Material) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeOrdenTrabajoMaterial
                sqlhelper.ExecuteNonQuery("[MAN].[Isp_OrdenTrabajo_Material_IAE]", _
                                          .TipoOperacion, .PrefijoID _
                                          , .Id, .IdOrdenTrabajo, .IdMaterial, .IdMantenimientoEquipo _
                                          , .IdUnidadMedida, .CantidadMaterial, .CantidadMaterialEntregada _
                                          , .CantidadMaterialDevuelto, .Costo, .IdSubAlmacen, .UsuarioCreacion _
                                          , .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeOrdenTrabajoMaterial As e_OrdenTrabajo_Material) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[MAN].[Isp_OrdenTrabajo_Material_IAE]", "E", "", oeOrdenTrabajoMaterial.Id, _
                                       oeOrdenTrabajoMaterial.IdOrdenTrabajo)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
