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
Public Class d_OrdenAsignacion

    Private sqlhelper As New SqlHelper
    Dim odUnidadAsignada As New d_OrdenAsignacion_UnidadAsignacion
    Dim odUnidadAsignadaMat As New d_OrdenAsignacion_Material

    Private Function Cargar(ByVal o_fila As DataRow) As e_OrdenAsignacion
        Try
            Dim oeOrdenAsignacion = New e_OrdenAsignacion( _
                             o_fila("Id").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("NroOA").ToString _
                             , o_fila("IdEstadoOA").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("IndUnidadAsignacion").ToString _
                             , o_fila("UnidadAsignada").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("Usuario").ToString _
                             , o_fila("IdUsuario").ToString)
            Return oeOrdenAsignacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CargarReporte(ByVal o_fila As DataRow) As e_ReporteOA
        Try
            Dim oeReporteOA = New e_ReporteOA( _
                             o_fila("Id").ToString _
                             , o_fila("NroOA").ToString _
                             , o_fila("Fecha") _
                             , o_fila("Glosa").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("UnidadAsignada").ToString _
                             , o_fila("Area").ToString _
                             , o_fila("IdMaterial").ToString _
                             , o_fila("CodigoMat").ToString _
                             , o_fila("Material").ToString _
                             , o_fila("UnidadMedida").ToString _
                             , o_fila("CantidadMaterial") _
                             , o_fila("CantidadReal") _
                             , o_fila("CostoUnitario") _
                             , o_fila("Importe"))
            Return oeReporteOA
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeOrdenAsignacion As e_OrdenAsignacion) As e_OrdenAsignacion

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_OrdenAsignacion_Listar", "1", oeOrdenAsignacion.Id, oeOrdenAsignacion.NroOA)
            If ds.Tables(0).Rows.Count > 0 Then
                oeOrdenAsignacion = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeOrdenAsignacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeOrdenAsignacion As e_OrdenAsignacion) As List(Of e_OrdenAsignacion)
        Try
            Dim ldOrdenAsignacion As New List(Of e_OrdenAsignacion)
            Dim ds As DataSet
            With oeOrdenAsignacion
                ds = sqlhelper.ExecuteDataset("STD.Isp_OrdenAsignacion_Listar" _
                                              , .TipoOperacion _
                                              , .Id _
                                              , .NroOA _
                                              , .IdEstadoOA _
                                              , .Glosa _
                                              , .Activo _
                                              , .IdUsuario _
                                              , .FechaDesde _
                                              , .FechaHasta _
                                              , .Idunidadasignada _
                                              , .IndUnidad
                                              )

            End With
            oeOrdenAsignacion = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeOrdenAsignacion = Cargar(o_Fila)
                    ldOrdenAsignacion.Add(oeOrdenAsignacion)
                Next
            End If
            Return ldOrdenAsignacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarReporte(ByVal oeReporteOA As e_ReporteOA) As List(Of e_ReporteOA)
        Try
            Dim ldReporteOA As New List(Of e_ReporteOA)
            Dim ds As DataSet
            With oeReporteOA
                ds = sqlhelper.ExecuteDataset("MAN.Isp_ReporteOrdenAsignacion_Listar" _
                                              , .TipoOperacion _
                                              , .IdUnidad _
                                              , .IdMaterial _
                                              , .FechaDesde _
                                              , .FechaHasta _
                                              , .IdAlmacen
                                              )

            End With
            oeReporteOA = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeReporteOA = CargarReporte(o_Fila)
                    ldReporteOA.Add(oeReporteOA)
                Next
            End If
            Return ldReporteOA
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeOrdenAsignacion As e_OrdenAsignacion) As Boolean
        Try
            Dim odReqMat As New d_RequerimientoMaterial
            Dim odReq As New d_Requerimiento
            Dim stResultado() As String
            Using transScope As New TransactionScope()
                With oeOrdenAsignacion
                    stResultado = sqlhelper.ExecuteScalar("STD.Isp_OrdenAsignacion_IAE",
                                                          .TipoOperacion,
                                                          .PrefijoID,
                                                          .Id _
                                                          , .Fecha _
                                                          , .NroOA _
                                                          , .IdEstadoOA _
                                                          , .Glosa _
                                                          , .Activo _
                                                          , .IdUsuario).ToString.Split("_")

                    Dim oeOA_UA As New e_OrdenAsignacion_UnidadAsignacion
                    oeOA_UA.Id = "" : oeOA_UA.IdOrdenAsignacion = stResultado(0)
                    odUnidadAsignada.Eliminar(oeOA_UA)

                    For Each Detalle As e_OrdenAsignacion_UnidadAsignacion In .lstUnidadAsignada
                        Detalle.IdOrdenAsignacion = stResultado(0) : Detalle.UsuarioCreacion = .IdUsuario
                        Detalle.TipoOperacion = IIf(String.IsNullOrEmpty(Detalle.Id), "I", .TipoOperacion)
                        Detalle.PrefijoID = oeOrdenAsignacion.PrefijoID '@0001
                        odUnidadAsignada.Guardar(Detalle)
                    Next

                    Dim oeOA_MA As New e_OrdenAsignacion_Material
                    oeOA_MA.PrefijoID = oeOrdenAsignacion.PrefijoID '@0001
                    oeOA_MA.Id = "" : oeOA_MA.IdOrdenAsignacion = stResultado(0)
                    odUnidadAsignadaMat.Eliminar(oeOA_MA)
                    For Each item As e_OrdenAsignacion_Material In .lstUnidadAsignadaMat
                        item.IdOrdenAsignacion = stResultado(0) : item.UsuarioCreacion = .IdUsuario
                        item.TipoOperacion = IIf(String.IsNullOrEmpty(item.Id), "I", .TipoOperacion)
                        item.PrefijoID = oeOrdenAsignacion.PrefijoID '@0001
                        odUnidadAsignadaMat.Guardar(item)
                        item.oeReqMaterial.PrefijoID = oeOrdenAsignacion.PrefijoID '@0001
                        If Not item.oeReqMaterial Is Nothing Then
                            If Not String.IsNullOrEmpty(item.oeReqMaterial.Tipooperacion) Then odReqMat.Guardar(item.oeReqMaterial)
                        End If
                    Next

                    For Each oerq In .lstRequerimiento
                        oerq.TipoOperacion = "B"
                        oerq.PrefijoID = oeOrdenAsignacion.PrefijoID '@0001
                        odReq.Guardar(oerq)
                    Next

                End With
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeOrdenAsignacion As e_OrdenAsignacion) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_OrdenAsignacion_IAE", oeOrdenAsignacion.TipoOperacion, _
             "", oeOrdenAsignacion.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class