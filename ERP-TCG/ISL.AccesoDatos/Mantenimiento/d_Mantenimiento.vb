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

Public Class d_Mantenimiento

    Private sqlhelper As New SqlHelper
    Dim odMantenimientoEquipo As New d_MantenimientoEquipo
    Dim odMantenimientoMaterial As New d_MantenimientoMaterial
    Dim odMantenimientoServicio As New d_MantenimientoServicio
    Dim odMantenimientoOcupacion As New d_MantenimientoOcupacion
    Dim odMantenimientoActividad As New d_MantenimientoActividad

    Private Function Cargar(ByVal o_fila As DataRow) As e_Mantenimiento
        Try
            Dim oeMantenimiento = New e_Mantenimiento( _
                             o_fila("Id").ToString _
                             , o_fila("IdTipoMantenimiento").ToString _
                             , o_fila("TipoMantenimiento").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Descripcion").ToString _
                             , o_fila("OrdenSecuencia").ToString _
                             , o_fila("Cantidad").ToString _
                             , o_fila("IdUnidadMedida").ToString _
                             , o_fila("UnidadMedida").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Externa") _
                                  )
            Return oeMantenimiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CargarProyMant(ByVal o_fila As DataRow) As e_ProyMantenimiento
        Try
            Dim oeProyMant = New e_ProyMantenimiento( _
                             o_fila("Codigo").ToString _
                             , o_fila("Placa").ToString _
                             , o_fila("Motriz") _
                             , o_fila("Marca").ToString _
                             , o_fila("Modelo").ToString _
                             , o_fila("Fecha") _
                             , o_fila("Kilometraje") _
                             , o_fila("KMProyectado") _
                             , o_fila("UltimoMantenimiento").ToString _
                             , o_fila("KmUltimoServicio") _
                             , o_fila("Horometro") _
                             , o_fila("FechaUltimoMantenimiento") _
                             , o_fila("UltimaOt").ToString _
                             , o_fila("ProximoMantenimiento") _
                             , o_fila("UnidadMedida") _
                             , o_fila("Cantidad"))
            Return oeProyMant
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMantenimiento As e_Mantenimiento) As e_Mantenimiento
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("MAN.Isp_Mantenimiento_Listar", "", oeMantenimiento.Id, oeMantenimiento.Nombre)
            oeMantenimiento = Nothing
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeMantenimiento = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeMantenimiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeMantenimiento As e_Mantenimiento) As List(Of e_Mantenimiento)
        Try
            Dim ldMantenimiento As New List(Of e_Mantenimiento)
            Dim ds As DataSet
            With oeMantenimiento
                ds = sqlhelper.ExecuteDataset("MAN.Isp_Mantenimiento_Listar", "" _
                        , .Id _
                        , .Nombre _
                        , .Codigo _
                        , .Descripcion _
                        , .Cantidad _
                        , .Activo _
                        , .IdTipoMantenimiento _
                        , .IdUnidadMedida _
                        , .UsuarioCreacion _
                        )
            End With
            oeMantenimiento = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMantenimiento = Cargar(o_Fila)
                    ldMantenimiento.Add(oeMantenimiento)
                Next
            End If
            Return ldMantenimiento
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarProyMant(ByVal oeProyMante As e_ProyMantenimiento) As List(Of e_ProyMantenimiento)
        Try
            Dim leProyMant As New List(Of e_ProyMantenimiento)
            Dim ds As DataSet
            With oeProyMante
                ds = sqlhelper.ExecuteDataset("MAN.Isp_ProyMantGenerico_Listar", .TipoOperacion, .IdUnidadMedida, .IdMarca, .IdModelo)
            End With
            oeProyMante = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeProyMante = CargarProyMant(o_Fila)
                    leProyMant.Add(oeProyMante)
                Next
            End If
            Return leProyMant
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarDS(ByVal oeMantenimiento As e_Mantenimiento) As Data.DataSet
        Try
            Dim ds As DataSet
            With oeMantenimiento
                ds = sqlhelper.ExecuteDataset("MAN.Isp_Mantenimiento_Listar", "D" _
                        , .Id _
                        , .Nombre _
                        , .Codigo _
                        , .Descripcion _
                        , .Cantidad _
                        , .Activo _
                        , .IdTipoMantenimiento _
                        , .IdUnidadMedida _
                        , .UsuarioCreacion _
                        )
            End With
            Return ds
            oeMantenimiento = Nothing
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMantenimiento As e_Mantenimiento) As Boolean
        Try
            Dim stResultado() As String

            Using transScope As New TransactionScope()
                With oeMantenimiento
                    stResultado = sqlhelper.ExecuteScalar("MAN.Isp_Mantenimiento_IAE", .TipoOperacion, .PrefijoID,
                            .Id _
                            , .IdTipoMantenimiento _
                            , .Nombre _
                            , .Codigo _
                            , .Descripcion _
                            , .OrdenSecuencia _
                            , .Cantidad _
                            , .IdUnidadMedida _
                            , .Activo _
                            , .UsuarioCreacion _
                            , .Externa
                        ).ToString.Split("_")

                    Dim oeME As New e_MantenimientoEquipo
                    oeME.Id = "" : oeME.IdMantenimiento = stResultado(0)
                    odMantenimientoEquipo.Eliminar(oeME)
                    For Each Detalle As e_MantenimientoEquipo In .lstDetalleEquipo
                        Detalle.IdMantenimiento = stResultado(0) : Detalle.UsuarioCreacion = .UsuarioCreacion
                        Detalle.TipoOperacion = IIf(String.IsNullOrEmpty(Detalle.Id), "I", .TipoOperacion)
                        Detalle.PrefijoID = oeMantenimiento.PrefijoID '@0001
                        odMantenimientoEquipo.Guardar(Detalle)
                    Next

                    Dim oeMM As New e_MantenimientoMaterial
                    oeMM.PrefijoID = oeMantenimiento.PrefijoID '@0001
                    oeMM.Id = "" : oeMM.IdMantenimiento = stResultado(0)
                    odMantenimientoMaterial.Eliminar(oeMM)
                    For Each Detalle As e_MantenimientoMaterial In .lstDetalleMaterial
                        Detalle.IdMantenimiento = stResultado(0) : Detalle.UsuarioCreacion = .UsuarioCreacion
                        Detalle.TipoOperacion = IIf(String.IsNullOrEmpty(Detalle.Id), "I", .TipoOperacion)
                        Detalle.PrefijoID = oeMantenimiento.PrefijoID '@0001
                        odMantenimientoMaterial.Guardar(Detalle)
                    Next

                    Dim oeMS As New e_MantenimientoServicio
                    oeMS.Id = "" : oeMS.IdMantenimiento = stResultado(0)
                    odMantenimientoServicio.Eliminar(oeMS)
                    For Each Detalle As e_MantenimientoServicio In .lstDetalleServicio
                        Detalle.IdMantenimiento = stResultado(0) : Detalle.UsuarioCreacion = .UsuarioCreacion
                        Detalle.TipoOperacion = IIf(String.IsNullOrEmpty(Detalle.Id), "I", .TipoOperacion)
                        Detalle.PrefijoID = oeMantenimiento.PrefijoID '@0001
                        odMantenimientoServicio.Guardar(Detalle)
                    Next

                    Dim oeMO As New e_MantenimientoOcupacion
                    oeMO.Id = "" : oeMO.IdMantenimiento = stResultado(0)
                    odMantenimientoOcupacion.Eliminar(oeMO)
                    For Each Detalle As e_MantenimientoOcupacion In .lstDetalleOcupacion
                        Detalle.IdMantenimiento = stResultado(0) : Detalle.UsuarioCreacion = .UsuarioCreacion
                        Detalle.TipoOperacion = IIf(String.IsNullOrEmpty(Detalle.Id), "I", .TipoOperacion)
                        Detalle.PrefijoID = oeMantenimiento.PrefijoID '@0001
                        odMantenimientoOcupacion.Guardar(Detalle)
                    Next

                    Dim oeMA As New e_MantenimientoActividad
                    oeMA.Id = "" : oeMA.IdMantenimiento = stResultado(0)
                    odMantenimientoActividad.Eliminar(oeMA)
                    For Each Detalle As e_MantenimientoActividad In .lstDetalleActividad
                        Detalle.IdMantenimiento = stResultado(0) : Detalle.UsuarioCreacion = .UsuarioCreacion
                        Detalle.TipoOperacion = IIf(String.IsNullOrEmpty(Detalle.Id), "I", .TipoOperacion)
                        Detalle.PrefijoID = oeMantenimiento.PrefijoID '@0001
                        odMantenimientoActividad.Guardar(Detalle)
                    Next

                End With
                transScope.Complete()
            End Using
            Return True

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeMantenimiento As e_Mantenimiento) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("MAN.Isp_Mantenimiento_IAE", "E", "", oeMantenimiento.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function ListarProyeccionMantenimiento(ByVal ls_IdMarca As String, ByVal ls_IdModelo As String, ByVal ls_TipoProyeccion As String) As Data.DataSet
        Try
            Return sqlhelper.ExecuteDataset("MAN.Isp_ProyeccionMantenimiento_Listar", ls_IdMarca, ls_IdModelo, ls_TipoProyeccion)
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
