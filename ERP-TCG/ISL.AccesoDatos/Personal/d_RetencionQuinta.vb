Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_RetencionQuinta

    Private sqlhelper As New SqlHelper
    Private odDetalle As New d_DetalleRentaQuinta
    Private oeDetalle As New e_DetalleRentaQuinta

    Private Function Cargar(ByVal o_fila As DataRow) As e_RetencionQuinta
        Try
            Dim oeRetencionQuinta = New e_RetencionQuinta( _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("IdPlanilla").ToString _
                             , o_fila("Planilla").ToString _
                             , o_fila("Importe") _
                             , o_fila("IdEstado").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaModifica") _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("Activo") _
            )
            Return oeRetencionQuinta
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeRetencionQuinta As e_RetencionQuinta) As e_RetencionQuinta

        Try
            Dim ds As DataSet
            With oeRetencionQuinta
                ds = sqlhelper.ExecuteDataset("PER.Isp_RetencionQuinta_Listar", .TipoOperacion, .Id, .Codigo, .IdPlanilla, .Importe _
                        , .IdEstado _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeRetencionQuinta = Cargar(ds.Tables(0).Rows(0))
                oeDetalle = New e_DetalleRentaQuinta
                oeDetalle.TipoOperacion = ""
                oeDetalle.IdRetencionQuinta = oeRetencionQuinta.Id
                oeDetalle.Activo = True
                oeRetencionQuinta.leDetalle = odDetalle.Listar(oeDetalle)
            End If
            Return oeRetencionQuinta
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeRetencionQuinta As e_RetencionQuinta) As List(Of e_RetencionQuinta)
        Try
            Dim ldRetencionQuinta As New List(Of e_RetencionQuinta)
            Dim ds As DataSet
            With oeRetencionQuinta
                ds = sqlhelper.ExecuteDataset("PER.Isp_RetencionQuinta_Listar", .TipoOperacion _
                        , .Id _
                        , .Codigo _
                        , .IdPlanilla _
                        , .Importe _
                        , .IdEstado _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo _
                        )
            End With
            oeRetencionQuinta = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeRetencionQuinta = Cargar(o_Fila)
                ldRetencionQuinta.Add(oeRetencionQuinta)
            Next
            Return ldRetencionQuinta
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeRetencionQuinta As e_RetencionQuinta) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim _idrenta As String = ""
            Using TransScope As New TransactionScope()
                With oeRetencionQuinta
                    _idrenta = sqlhelper.ExecuteScalar("PER.Isp_RetencionQuinta_IAE", .TipoOperacion, .PrefijoID, _
                            .Id _
                            , .Codigo _
                            , .IdPlanilla _
                            , .Importe _
                            , .IdEstado _
                            , .Glosa _
                            , .FechaCreacion _
                            , .UsuarioCreacion _
                            , .FechaModifica _
                            , .UsuarioModifica _
                            , .Activo _
                        )

                    For Each det In .leDetalle
                        det.IdRetencionQuinta = _idrenta
                        If det.TipoOperacion <> "" Then
                            If det.TipoOperacion = "E" Then
                                odDetalle.Eliminar(det)
                            Else
                                odDetalle.Guardar(det)
                            End If
                        End If
                    Next

                End With
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeRetencionQuinta As e_RetencionQuinta) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_RetencionQuinta_IAE", "E", _
             "", oeRetencionQuinta.Id, "", "", 0, "", "", #1/1/1901#, "", #1/1/1901#, oeRetencionQuinta.UsuarioModifica)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function ImportarDatos(ByVal oeRetencionQuinta As e_RetencionQuinta) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim _idrenta As String = ""
            Using TransScope As New TransactionScope()
                With oeRetencionQuinta
                    _idrenta = sqlhelper.ExecuteScalar("PER.Isp_RetencionQuinta_IAE", .TipoOperacion, .PrefijoID, _
                            .Id _
                            , .Codigo _
                            , .IdPlanilla _
                            , .Importe _
                            , .IdEstado _
                            , .Glosa _
                            , .FechaCreacion _
                            , .UsuarioCreacion _
                            , .FechaModifica _
                            , .UsuarioModifica _
                            , .Activo _
                        )

                    If .dtDetalleR5.Rows.Count > 0 Then
                        For Each Fil As DataRow In .dtDetalleR5.Rows
                            Fil("IdRetencionQuinta") = _idrenta
                        Next
                        odDetalle.GuardarMasivo(.dtDetalleR5)
                    End If

                End With
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
