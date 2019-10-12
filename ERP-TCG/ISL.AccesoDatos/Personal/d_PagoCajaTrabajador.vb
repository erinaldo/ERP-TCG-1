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

Public Class d_PagoCajaTrabajador

    Private sqlhelper As New SqlHelper
    Private oeDetPA As New e_DetallePagoCajaTrabajador, odDetPA As New d_DetallePagoCajaTrabajador

    Private Function Cargar(ByVal o_fila As DataRow) As e_PagoCajaTrabajador
        Try
            Dim oePagoCajaTrabajador = New e_PagoCajaTrabajador( _
                             o_fila("Id").ToString _
                             , o_fila("IdPlanilla").ToString _
                             , o_fila("Planilla").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Descripcion").ToString _
                             , o_fila("IdEstado").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaModifica") _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("Activo") _
            )
            Return oePagoCajaTrabajador
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oePagoCajaTrabajador As e_PagoCajaTrabajador) As e_PagoCajaTrabajador
        Try
            Dim ds As DataSet
            With oePagoCajaTrabajador
                ds = sqlhelper.ExecuteDataset("PER.Isp_PagoCajaTrabajador_Listar", .TipoOperacion, .Id, .IdPlanilla)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oePagoCajaTrabajador = Cargar(ds.Tables(0).Rows(0))
                oeDetPA = New e_DetallePagoCajaTrabajador
                oeDetPA.TipoOperacion = ""
                oeDetPA.IndTipo = -1
                oeDetPA.Activo = True
                oeDetPA.IdPagoCajaTrabajador = oePagoCajaTrabajador.Id
                oePagoCajaTrabajador.leDetalle = odDetPA.Listar(oeDetPA)
            End If
            Return oePagoCajaTrabajador
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oePagoCajaTrabajador As e_PagoCajaTrabajador) As List(Of e_PagoCajaTrabajador)
        Try
            Dim ldPagoCajaTrabajador As New List(Of e_PagoCajaTrabajador)
            Dim ds As DataSet
            With oePagoCajaTrabajador
                ds = sqlhelper.ExecuteDataset("PER.Isp_PagoCajaTrabajador_Listar", .TipoOperacion _
                        , .Id _
                        , .IdPlanilla _
                        , .Codigo _
                        , .Descripcion _
                        , .IdEstado _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo _
                        )
            End With
            oePagoCajaTrabajador = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oePagoCajaTrabajador = Cargar(o_Fila)
                ldPagoCajaTrabajador.Add(oePagoCajaTrabajador)
            Next
            Return ldPagoCajaTrabajador
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oePagoCajaTrabajador As e_PagoCajaTrabajador) As Boolean
        Try
            Dim _idpa As String = ""
            Using TransScope As New TransactionScope()
                With oePagoCajaTrabajador
                    _idpa = sqlhelper.ExecuteScalar("PER.Isp_PagoCajaTrabajador_IAE", .TipoOperacion, .PrefijoID,
                            .Id _
                            , .IdPlanilla _
                            , .Codigo _
                            , .Descripcion _
                            , .IdEstado _
                            , .FechaCreacion _
                            , .UsuarioCreacion _
                            , .FechaModifica _
                            , .UsuarioModifica _
                            , .Activo
                        )
                    For Each oeDetAux In .leDetalle.Where(Function(it) it.TipoOperacion.Trim <> "").ToList
                        oeDetAux.PrefijoID = oePagoCajaTrabajador.PrefijoID '@0001
                        If oeDetAux.TipoOperacion = "E" Then
                            odDetPA.Eliminar(oeDetAux)
                        Else
                            oeDetAux.IdPagoCajaTrabajador = _idpa
                            odDetPA.Guardar(oeDetAux)
                        End If
                    Next
                End With
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oePagoCajaTrabajador As e_PagoCajaTrabajador) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_PagoCajaTrabajador_IAE", "E", _
             "", oePagoCajaTrabajador.Id, "", "", "", "", Date.Now, oePagoCajaTrabajador.UsuarioModifica)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function ImportarDatos(ByVal oePagoCajaTrabajador As e_PagoCajaTrabajador) As Boolean
        Try
            Dim _idpa As String = ""
            Using TransScope As New TransactionScope()
                With oePagoCajaTrabajador
                    _idpa = sqlhelper.ExecuteScalar("PER.Isp_PagoCajaTrabajador_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdPlanilla _
                        , .Codigo _
                        , .Descripcion _
                        , .IdEstado _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo
                    )

                    If .dtDetallePA.Rows.Count > 0 Then
                        For Each Fil As DataRow In .dtDetallePA.Rows
                            Fil("IdPagoCajaTrabajador") = _idpa
                        Next
                        odDetPA.GuardarMasivo(.dtDetallePA)
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
