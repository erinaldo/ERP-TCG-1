Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient
Public Class d_GuiaRemisionRemitente
    Private sqlhelper As New SqlHelper
    Dim odGRRMaterial As New d_GuiaRRemitenteMaterial
    Public Function Cargar(ByVal o_fila As DataRow) As e_GuiaRemisionRemitente
        Try
            Dim oeGuiaRemisionRemitente = New e_GuiaRemisionRemitente( _
                             o_fila("Id").ToString _
                             , o_fila("IdEmpresaProveedor").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("IdTipoGuia").ToString _
                             , o_fila("NroGuia").ToString _
                             , o_fila("Serie").ToString _
                             , o_fila("Numero").ToString _
                             , o_fila("MotTraslado").ToString _
                             , o_fila("IdMotivoTraslado").ToString _
                             , o_fila("IdEmpresaOrigen").ToString _
                             , o_fila("IdEmpresaDestino").ToString _
                             , o_fila("IdDireccionOrigen").ToString _
                             , o_fila("IdDireccionDestino").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("Piloto").ToString _
                             , o_fila("PlacaVehiculo").ToString _
                             , o_fila("PlacaCarreta").ToString _
                             , o_fila("IdEstado").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("nombreUsuario").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaCreacion").ToString _
            )
            Return oeGuiaRemisionRemitente
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeGuiaRemisionRemitente As e_GuiaRemisionRemitente) As e_GuiaRemisionRemitente

        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[CMP].[Isp_GuiaRemision_Listar]", oeGuiaRemisionRemitente.TipoOperacion, oeGuiaRemisionRemitente.Id, _
                                         oeGuiaRemisionRemitente.IdEmpresaProveedor, "", oeGuiaRemisionRemitente.Serie, oeGuiaRemisionRemitente.Numero)
            If ds.Tables(0).rows.Count > 0 Then
                oeGuiaRemisionRemitente = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeGuiaRemisionRemitente
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Function ListarDetallesGRemision(ByVal oeGuiaRemisionRemitente As e_GuiaRemisionRemitente) As List(Of e_Material)
        Try
            Dim lstMateriales As New List(Of e_Material)
            Dim ds As DataSet
            With oeGuiaRemisionRemitente
                ds = sqlhelper.ExecuteDataset("[CMP].[Isp_GuiaRemision_Material_Listar]", .TipoOperacion _
                        , "", .Id)
                If ds.Tables.Count > 0 Then
                    For Each o_Fila As DataRow In ds.Tables(0).Rows
                        Dim oeMaterial As New e_Material
                        Dim odMaterial As New d_Material
                        oeMaterial = odMaterial.Cargar_Detalle(o_Fila)
                        lstMateriales.Add(oeMaterial)
                    Next
                End If

            End With
            Return lstMateriales
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Function Listar(ByVal oeGuiaRemisionRemitente As e_GuiaRemisionRemitente) As List(Of e_GuiaRemisionRemitente)
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ldGuiaRemisionRemitente As New List(Of e_GuiaRemisionRemitente)
            Dim ds As DataSet
            With oeGuiaRemisionRemitente
                ds = sqlhelper.ExecuteDataset("[CMP].[Isp_GuiaRemision_Listar]", .TipoOperacion _
                        , .Id _
                        , .IdEmpresaProveedor _
                        , .IdTipoGuia _
                        , .Serie _
                        , .Numero _
                        , .IdMotivoTraslado _
                        , .IdEmpresaOrigen _
                        , .IdEmpresaDestino _
                        , .IdDireccionOrigen _
                        , .IdDireccionDestino _
                        , .Fecha _
                        , .Glosa _
                        , .Piloto _
                        , .PlacaVehiculo _
                        , .PlacaCarreta _
                        , .IdEstado _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .FechaCreacion _
                        , .fechaInicio _
                        , .fechaFin _
                        )
            End With
            oeGuiaRemisionRemitente = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeGuiaRemisionRemitente = Cargar(o_Fila)
                    ldGuiaRemisionRemitente.Add(oeGuiaRemisionRemitente)
                Next
            End If
            Return ldGuiaRemisionRemitente
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeGuiaRemisionRemitente As e_GuiaRemisionRemitente) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim stResultado() As String
            Using transScope As New TransactionScope()
                With oeGuiaRemisionRemitente
                    stResultado = sqlhelper.ExecuteScalar("[CMP].[Isp_GuiaRemision_IAE]" _
                            , .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                            .Id _
                            , .IdEmpresaProveedor _
                            , .IdTipoGuia _
                            , .Serie _
                            , .Numero _
                            , .IdMotivoTraslado _
                            , .IdEmpresaOrigen _
                            , .IdEmpresaDestino _
                            , .IdDireccionOrigen _
                            , .IdDireccionDestino _
                            , .Fecha _
                            , .Glosa _
                            , .Piloto _
                            , .PlacaVehiculo _
                            , .PlacaCarreta _
                            , .IdEstado _
                            , .Activo _
                            , .UsuarioCreacion _
                            , .FechaCreacion _
                        ).ToString.Split("_")

                    For Each Detalle As e_GuiaRRemitenteMaterial In .lstGRRMaterial
                        Detalle.IdGuiaRemision = stResultado(0) : Detalle.UsuarioCreacion = .UsuarioCreacion
                        Detalle.TipoOperacion = .TipoOperacion
                        odGRRMaterial.Guardar(Detalle)
                    Next
                    '---Asociar a Orden
                    '-----------tabla relacion-------------
                    For Each oeOD As e_Orden In .lstOrden
                        Dim oeOrden_Documento As New e_Orden_Documento
                        Dim odOrden_Documento As New d_Orden_Documento
                        oeOrden_Documento.TipoOperacion = "I"
                        oeOrden_Documento.Id = ""
                        oeOrden_Documento.IdOrden = oeOD.Id
                        oeOrden_Documento.IdTipoOrden = oeOD.IdTipoOrden
                        oeOrden_Documento.IdDocumento = stResultado(0)
                        oeOrden_Documento.Activo = .Activo
                        oeOrden_Documento.UsuarioCreacion = .UsuarioCreacion
                        oeOrden_Documento.IdTipoDocumento = .IdTipoGuia
                        odOrden_Documento.Guardar(oeOrden_Documento)
                    Next
                End With
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeGuiaRemisionRemitente As e_GuiaRemisionRemitente) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[CMP].[Isp_GuiaRemision_IAE]", "E", _
             "", oeGuiaRemisionRemitente.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class
