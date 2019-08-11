Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_GrupoSancion

    Private sqlhelper As New SqlHelper
    Dim oeDetalle As New e_Sancion
    Dim odDetalle As New d_Sancion

    Private Function Cargar(ByVal o_fila As DataRow) As e_GrupoSancion
        Try
            Dim oeGrupoSancion = New e_GrupoSancion( _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("IdArea").ToString _
                             , o_fila("Area").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("Monto") _
                             , o_fila("Activo").ToString _
                             , o_fila("IdEstado").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Tipo") _
            )
            Return oeGrupoSancion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeGrupoSancion As e_GrupoSancion) As e_GrupoSancion
        Try
            Dim ds As DataSet
            With oeGrupoSancion
                ds = sqlhelper.ExecuteDataset("TES.Isp_GrupoSancion_Listar", .TipoOperacion, .Id, .Codigo)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeGrupoSancion = Cargar(ds.Tables(0).Rows(0))
                If oeGrupoSancion.Id <> "" Then
                    oeDetalle.TipoOperacion = "1"
                    oeDetalle.Activo = 1
                    oeDetalle.IdGrupo = oeGrupoSancion.Id
                    oeDetalle.IdEstado = oeGrupoSancion.IdEstado
                    oeGrupoSancion.leDetalle = odDetalle.Listar(oeDetalle)
                End If
            End If
            Return oeGrupoSancion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ObtenerGrupoGenerado(ByVal oeGrupoSancion As e_GrupoSancion) As e_GrupoSancion
        Try
            Dim ds As DataSet
            With oeGrupoSancion
                ds = sqlhelper.ExecuteDataset("TES.Isp_GrupoSancion_Listar", _
                                              .TipoOperacion, _
                                              .Id, _
                                              .Codigo _
                                              , .IdArea _
                                              , .Fecha _
                                              , .Glosa _
                                              , .Monto _
                                              , .Activo _
                                              , .IdEstado)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeGrupoSancion = Cargar(ds.Tables(0).Rows(0))
            Else
                oeGrupoSancion = New e_GrupoSancion
            End If
            Return oeGrupoSancion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeGrupoSancion As e_GrupoSancion) As List(Of e_GrupoSancion)
        Try
            Dim ldGrupoSancion As New List(Of e_GrupoSancion)
            Dim ds As DataSet
            With oeGrupoSancion
                ds = sqlhelper.ExecuteDataset("TES.Isp_GrupoSancion_Listar", .TipoOperacion _
                        , .Id _
                        , .Codigo _
                        , .IdArea _
                        , .Fecha _
                        , .Glosa _
                        , .Monto _
                        , .Activo _
                        , .IdEstado _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , ._NombreEstado _
                        , ._fecDesde _
                        , ._fecHasta _
                        )
            End With
            oeGrupoSancion = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeGrupoSancion = Cargar(o_Fila)
                ldGrupoSancion.Add(oeGrupoSancion)
            Next
            Return ldGrupoSancion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarDS(ByVal oeGrupoSancion As e_GrupoSancion) As Data.DataSet
        Try
         
            With oeGrupoSancion
                Return sqlhelper.ExecuteDataset("TES.Isp_GrupoSancion_Listar", .TipoOperacion _
                        , .Id _
                        , .Codigo _
                        , .IdArea _
                        , .Fecha _
                        , .Glosa _
                        , .Monto _
                        , .Activo _
                        , .IdEstado _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , ._NombreEstado _
                        , ._fecDesde _
                        , ._fecHasta _
                        )
            End With
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeGrupoSancion As e_GrupoSancion) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim stResultado() As String
            Dim est As String = oeGrupoSancion.Estado
            Dim idest As String = oeGrupoSancion.IdEstado
            Using transScope As New TransactionScope
                With oeGrupoSancion
                    stResultado = sqlhelper.ExecuteScalar("TES.Isp_GrupoSancion_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                            .Id _
                            , .Codigo _
                            , .IdArea _
                            , .Fecha _
                            , .Glosa _
                            , .Monto _
                            , .Activo _
                            , .IdEstado _
                            , .FechaCreacion _
                            , .UsuarioCreacion _
                            , ._CadenaId _
                            , .Tipo _
                        ).ToString.Split("_")

                    For Each oeDet As e_Sancion In .leDetalle
                        oeDet.IdGrupo = stResultado(0)
                        If oeDet.TipoOperacion = "E" Then
                            odDetalle.Eliminar(oeDet)
                        Else
                            oeDet.TipoOperacion = "A"
                            odDetalle.Guardar(oeDet)
                        End If
                    Next

                End With
                transScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeGrupoSancion As e_GrupoSancion) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_GrupoSancion_IAE", "E", _
             "", oeGrupoSancion.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
