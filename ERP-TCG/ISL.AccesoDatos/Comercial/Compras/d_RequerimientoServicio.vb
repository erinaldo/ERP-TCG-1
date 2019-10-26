'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_RequerimientoServicio


    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_RequerimientoServicio
        Try
            Dim oeRequerimientoServicio = New e_RequerimientoServicio(o_fila("Seleccion") _
                             , o_fila("Id").ToString _
                              , o_fila("IdServicio").ToString _
                             , o_fila("Asignado").ToString _
                             , o_fila("Cantidad").ToString _
                             , o_fila("Precio").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("IdCentroCosto").ToString _
                             , o_fila("CentroCosto").ToString _
                             , o_fila("IdEmpresaServicio").ToString _
                             , o_fila("IdRequerimiento").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Fechacreacion").ToString _
                             , o_fila("Servicio").ToString _
                             , o_fila("CodigoServicio").ToString _
                             , o_fila("CodigoRequerimiento").ToString _
                             , o_fila("IdArea").ToString _
                             , o_fila("Area").ToString _
                             , o_fila("IdEstadoRequerimientoServicio").ToString _
                             , o_fila("EstadoRequerimientoServicio").ToString _
                             , o_fila("NroOT").ToString _
                             , o_fila("Equipo").ToString _
                             , o_fila("IdMantenimiento").ToString _
                             , o_fila("Mantenimiento").ToString _
                             , o_fila("IdEquipo").ToString)
            Return oeRequerimientoServicio

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeRequerimientoServicio As e_RequerimientoServicio) As e_RequerimientoServicio

        Try
            Dim ds As DataSet
            With oeRequerimientoServicio
                ds = sqlhelper.ExecuteDataset("[CMP].[Isp_Requerimiento_Servicio_Listar]", _
                                                                                     .Tipooperacion, .Id, .IdRequerimiento, .IdEmpresaServicio)

            End With            
            If ds.Tables.Count > 0 Then
                oeRequerimientoServicio = Cargar(ds.Tables(0).Rows(0))
                Return oeRequerimientoServicio
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeRequerimientoServicio As e_RequerimientoServicio) As List(Of e_RequerimientoServicio)
        Try
            Dim ldRequerimientoServicio As New List(Of e_RequerimientoServicio)
            Dim ds As DataSet
            With oeRequerimientoServicio
                ds = sqlhelper.ExecuteDataset("[CMP].[Isp_Requerimiento_Servicio_Listar]", .Tipooperacion, _
                                                                                     .Id, _
                                                                                     .IdRequerimiento, _
                                                                                     .IdEmpresaServicio)

            End With
            oeRequerimientoServicio = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeRequerimientoServicio = Cargar(o_Fila)
                    ldRequerimientoServicio.Add(oeRequerimientoServicio)
                Next
            End If
            Return ldRequerimientoServicio
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeRequerimientoServicio As e_RequerimientoServicio) As Boolean
        Try
            With oeRequerimientoServicio
                sqlhelper.ExecuteNonQuery("[CMP].[Isp_Requerimiento_Servicio_IAE]",
                                                            .Tipooperacion,
                                                             .PrefijoID,
                                                            .Id,
                                                            .Activo,
                                                            .IdRequerimiento,
                                                            .IdServicio,
                                                            .IdCentroCosto,
                                                            .Asignado,
                                                            .Cantidad,
                                                            .Precio,
                                                            .Glosa,
                                                            .IdEmpresaServicio,
                                                            .UsuarioCreacion,
                                                            .IndicadorAprobacion,
                                                            .IdEstadoRequerimientoServicio,
                                                            .IdMantenimiento)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeRequerimientoServicio As e_RequerimientoServicio) As Boolean
        Try

            sqlhelper.ExecuteNonQuery("[CMP].[Isp_Requerimiento_Servicio_IAE]" _
                                      , oeRequerimientoServicio.Tipooperacion _
                                      , "" _
                                      , "" _
                                      , 0 _
                                      , oeRequerimientoServicio.IdRequerimiento)

            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function


End Class
