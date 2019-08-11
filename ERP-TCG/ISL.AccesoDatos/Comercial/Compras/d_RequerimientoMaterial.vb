Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_RequerimientoMaterial
    Private sqlhelper As New SqlHelper
    Dim olDetalleMatAsig As New d_DetalleMaterialAsignacion
    Dim olCtrlEntreMat As New d_ControlEntregaMaterial

    Private Function Cargar(ByVal o_fila As DataRow) As e_RequerimientoMaterial
        Try
            Dim oeRequerimientoMaterial = New e_RequerimientoMaterial(o_fila("Seleccion") _
                             , o_fila("Id").ToString _
                              , o_fila("IdRequerimiento").ToString _
                              , o_fila("IdMaterial").ToString _
                             , o_fila("Cantidad").ToString _
                             , o_fila("Precio").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("IdAlmacen").ToString _
                             , o_fila("CantidadPorAtender").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("Usuariocreacion").ToString _
                             , o_fila("Fechacreacion").ToString _
                             , o_fila("Material").ToString _
                             , o_fila("Almacen").ToString _
                             , o_fila("IdUnidadMedida").ToString _
                             , o_fila("UnidadMedida").ToString _
                             , o_fila("IdTipoUnidadMedida").ToString _
                             , o_fila("IdCentroCosto").ToString _
                             , o_fila("CodigoRequerimiento").ToString _
                             , o_fila("CodigoMaterial").ToString _
                             , o_fila("CentroCosto").ToString _
                             , o_fila("IdArea").ToString _
                             , o_fila("Area").ToString _
                             , o_fila("IdEstadoRequerimientoMaterial").ToString _
                             , o_fila("EstadoRequerimientoMaterial").ToString _
                             , o_fila("StockActual").ToString _
                             , o_fila("Trabajador").ToString _
                             , o_fila("IdSubAlmacen").ToString _
                             , o_fila("IdMantenimiento").ToString _
                             , o_fila("Mantenimiento").ToString _
                             , o_fila("IdMantenimientoEquipo").ToString _
                             , o_fila("IndRegularizado").ToString _
                             , o_fila("CantidadPorRegularizar").ToString _
                             , o_fila("Ubicacion").ToString)
            Return oeRequerimientoMaterial

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeRequerimientoMaterial As e_RequerimientoMaterial) As e_RequerimientoMaterial

        Try

            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[CMP].[Isp_Requerimiento_Material_Listar]", _
                                           oeRequerimientoMaterial.Tipooperacion, _
                                           oeRequerimientoMaterial.Id, _
                                           "", _
                                           oeRequerimientoMaterial.Activo)

            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeRequerimientoMaterial = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeRequerimientoMaterial

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeRequerimientoMaterial As e_RequerimientoMaterial) As List(Of e_RequerimientoMaterial)
        Try
            Dim ldRequerimientoMaterial As New List(Of e_RequerimientoMaterial)
            Dim ds As DataSet
            With oeRequerimientoMaterial
                ds = sqlhelper.ExecuteDataset("[CMP].[Isp_Requerimiento_Material_Listar]", _
                                           .Tipooperacion, .Id, .IdRequerimiento, .Activo, _
                                           .FechaInicio, .FechaFinal, .IdMaterial, "", 0, _
                                           0, "", 0, "", "01/01/1901", .IdMantenimiento)
            End With
            oeRequerimientoMaterial = Nothing
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeRequerimientoMaterial = Cargar(o_Fila)
                    ldRequerimientoMaterial.Add(oeRequerimientoMaterial)
                Next
            End If
            Return ldRequerimientoMaterial

        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Function Guardar(ByVal oeRequerimientoMaterial As e_RequerimientoMaterial) As Boolean
        Try
            Dim stResultado() As String
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim odSancion As New d_Sancion
            With oeRequerimientoMaterial
                stResultado = sqlhelper.ExecuteScalar("[CMP].[Isp_Requerimiento_Material_IAE]" _
                                , .Tipooperacion _
                                , d_DatosConfiguracion.PrefijoID, .Id, .IdRequerimiento _
                                , .IdMaterial, .Cantidad _
                                , .Precio _
                                , .Glosa _
                                , .IdSubAlmacen _
                                , .IdAlmacen _
                                , .CantidadPorAtender _
                                , .Activo _
                                , .UsuarioCreacion _
                                , .IdUnidadMedida _
                                , .IdCentroCosto _
                                , .IdEstadoRequerimientoMaterial _
                                , .IndicadorAprobacion, .IdMantenimiento, .IndRegularizado, .CantidadPorRegularizar _
                                , .FechaAtencion).ToString.Split()
                'Si viene de Orden de Asignacion
                If .lstDetalleMaterialAsignacion.Count > 0 AndAlso .Tipooperacion <> "A" Then
                    For Each fila As e_DetalleMaterialAsignacion In .lstDetalleMaterialAsignacion
                        fila.TipoOperacion = "I" : fila.IdRequerimientoMaterial = stResultado(0) : fila.Activo = True
                        olDetalleMatAsig.Guardar(fila)
                    Next
                End If
                Dim i As Double = .CantidadPorRegularizar
                Dim j As Double = .CantidadAAtender
                If i > 0 And j > 0 Then
                    If .loControlEntregaMaterial.Count > 0 AndAlso .Tipooperacion = "D" Then
                        For Each control As e_ControlEntregaMaterial In .loControlEntregaMaterial
                            control.TipoOperacion = "I"
                            control.IdRequerimientoMaterial = stResultado(0)
                            olCtrlEntreMat.Guardar(control)
                        Next
                    End If
                End If
                If .oeSancion.TipoOperacion = "I" Then
                    .oeSancion.oeReqOASan = New e_ReqOAMSancion
                    .oeSancion.oeReqOASan.TipoOperacion = "I"
                    .oeSancion.oeReqOASan.IdRequerimientoMaterial = stResultado(0)
                    .oeSancion.oeReqOASan.IdOrdenAsignacionMaterial = .IdOrdenAsignacionMaterial
                    odSancion.Guardar(.oeSancion)
                End If
                If .Tipooperacion = "D" And .oeSancion.Id <> "" Then
                    .oeSancion.TipoOperacion = "P"
                    odSancion.Guardar(.oeSancion)
                End If
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeRequerimientoMaterial As e_RequerimientoMaterial) As Boolean
        Try

            sqlhelper.ExecuteNonQuery("[CMP].[Isp_Requerimiento_Material_IAE]" _
                                      , oeRequerimientoMaterial.Tipooperacion _
                                      , "" _
                                      , "" _
                                      , oeRequerimientoMaterial.IdRequerimiento)

            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function


    '--------------------------CONSULTAS ESPECIALES SOBRE MATERIALES--------------------------
    'Private Function CargarMaterial(ByVal fila As DataRow) As e_Material
    '    Try
    '        Dim oeMaterial = New e_Material(fila("Seleccion"), _
    '                                        fila("Id"), _
    '                                        fila("Codigo"), _
    '                                        fila("Nombre"), _
    '                                        fila("IdTipoMaterial"), _
    '                                        fila("TipoMaterial"), _
    '                                        fila("IdFamilia"), _
    '                                        fila("Familia"), _
    '                                        fila("IdSubFamilia"), _
    '                                        fila("SubFamilia"), _
    '                                        fila("IdTipoUnidadMedida"), _
    '                                        fila("TipoUnidadMedida"), _
    '                                        fila("IdUnidadMedida"), _
    '                                        fila("Unidad de Medida"), _
    '                                        fila("Medida"), _
    '                                        fila("Peso"), _
    '                                        fila("Serial"), _
    '                                        fila("AfectoIgv"), _
    '                                        fila("Glosa"), _
    '                                        fila("IdAlmacen"), _
    '                                        fila("Almacen"), _
    '                                        fila("Activo") _
    '                                        )
    '        Return oeMaterial
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

    'Public Function ObtenerMaterial(ByVal oeMaterial As e_Material) As e_Material
    '    Try
    '        Dim ds As DataSet
    '        ds = sqlhelper.ExecuteDataset("ALM.Isp_Material_Almacen_Listar", _
    '                                      "5", _
    '                                      "", _
    '                                      "", _
    '                                      oeMaterial.Id, _
    '                                      oeMaterial.IdAlmacen, _
    '                                      oeMaterial.Activo)
    '        'oeMaterial.I)
    '        If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
    '            oeMaterial = CargarMaterial(ds.Tables(0).Rows(0))
    '        End If
    '        Return oeMaterial
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

    '----------------------------------------------------------------------------------------



End Class
