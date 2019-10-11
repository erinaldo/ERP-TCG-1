'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_OrdenTrabajo_Servicio
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_OrdenTrabajo_Servicio
        Try
            Dim oeOrdenTrabajo_Servicio = New e_OrdenTrabajo_Servicio( _
                             o_fila("Id").ToString _
                             , o_fila("IdOrdenTrabajo").ToString _
                             , o_fila("IdServicio").ToString _
                             , o_fila("IdMantenimientoEquipo").ToString _
                             , o_fila("Cantidad").ToString _
                             , o_fila("Costo").ToString _
                             , o_fila("Descripcion").ToString _
                             , o_fila("IdEmpresaServicio").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                                    )
            Return oeOrdenTrabajo_Servicio
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CargarReporteOTS(ByVal o_fila As DataRow) As e_ReporteOTServicio
        Try
            Dim oeReporteOTS = New e_ReporteOTServicio( _
                             o_fila("IdOrdenTrabajo").ToString _
                             , o_fila("NroOT").ToString _
                             , o_fila("FechaProgramacion") _
                             , o_fila("TipoMantenimiento").ToString _
                             , o_fila("Mantenimiento").ToString _
                             , o_fila("IdServicio").ToString _
                             , o_fila("Servicio").ToString _
                             , o_fila("Placa").ToString _
                             , o_fila("Marca").ToString _
                             , o_fila("Proveedor").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("CostoOTS") _
                              , o_fila("NroRS").ToString _
                             , o_fila("NroOC").ToString _
                             , o_fila("GlosaOCS").ToString _
                             , o_fila("TipoDoc").ToString _
                             , o_fila("FecDoc") _
                             , o_fila("NroDoc").ToString _
                              , o_fila("TipoMoneda").ToString _
                             , o_fila("TipoCambio") _
                             , o_fila("Total") _
                             , o_fila("Cantidad") _
                             , o_fila("PrecioUnitario") _
                                    )
            Return oeReporteOTS
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeOrdenTrabajo_Servicio As e_OrdenTrabajo_Servicio) As e_OrdenTrabajo_Servicio

        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "", oeOrdenTrabajo_Servicio.Id)
            If ds.Tables.Count > 0 Then
                oeOrdenTrabajo_Servicio = Cargar(ds.Tables(0).Rows(0))
                Return oeOrdenTrabajo_Servicio
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeOrdenTrabajo_Servicio As e_OrdenTrabajo_Servicio) As List(Of e_OrdenTrabajo_Servicio)
        Try
            Dim ldOrdenTrabajo_Servicio As New List(Of e_OrdenTrabajo_Servicio)
            Dim ds As DataSet
            With oeOrdenTrabajo_Servicio
                ds = SqlHelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "" _
                        , .Id _
                        , .IdOrdenTrabajo _
                        , .IdServicio _
                        , .IdMantenimientoEquipo _
                        , .Cantidad _
                        , .Costo _
                        , .Descripcion _
                        , .IdEmpresaServicio _
                        , .Activo _
                        , .UsuarioCreacion _
                                )
            End With
            oeOrdenTrabajo_Servicio = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeOrdenTrabajo_Servicio = Cargar(o_Fila)
                    ldOrdenTrabajo_Servicio.Add(oeOrdenTrabajo_Servicio)
                Next
            End If
            Return ldOrdenTrabajo_Servicio
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarReporte(ByVal oeReporteOTS As e_ReporteOTServicio) As List(Of e_ReporteOTServicio)
        Try
            Dim leReporteOTS As New List(Of e_ReporteOTServicio)
            Dim ds As DataSet
            With oeReporteOTS
                ds = sqlhelper.ExecuteDataset("MAN.Isp_ReporteOTServicio_Listar", .TipoOperacion _
                        , .IdOrdenTrabajo _
                        , .IdTipoMantenimiento _
                        , .IdMantenimiento _
                        , .IdServicio _
                        , .IdMarca _
                        , .IdEquipo _
                        , .IdProveedor _
                        , .FechaInicio _
                        , .FechaFin _
                                )
            End With
            oeReporteOTS = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeReporteOTS = CargarReporteOTS(o_Fila)
                    leReporteOTS.Add(oeReporteOTS)
                Next
            End If
            Return leReporteOTS
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal ls_OrdenTrabajo) As Data.DataSet
        Try
            Return sqlhelper.ExecuteDataset("[MAN].[Isp_OrdenTrabajo_Servicio_Listar]", "L" _
                     , "", ls_OrdenTrabajo _
                     )
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeOrdenTrabajo_Servicio As e_OrdenTrabajo_Servicio) As Boolean
        Try
            With oeOrdenTrabajo_Servicio
                sqlhelper.ExecuteNonQuery("[MAN].[Isp_OrdenTrabajo_Servicio_IAE]", .TipoOperacion, .PrefijoID _
                        , .Id _
                        , .IdOrdenTrabajo _
                        , .IdServicio _
                        , .IdMantenimientoEquipo _
                        , .Cantidad _
                        , .Costo _
                        , .CostoDolares _
                        , .Descripcion _
                        , .Activo _
                        , .UsuarioCreacion
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeOrdenTrabajo_Servicio As e_OrdenTrabajo_Servicio) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[MAN].[Isp_OrdenTrabajo_Servicio_IAE]", "E", "", oeOrdenTrabajo_Servicio.Id _
                                      , oeOrdenTrabajo_Servicio.IdOrdenTrabajo)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
