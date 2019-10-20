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

Public Class d_PagoAdicional

    Private sqlhelper As New SqlHelper
    Private oeDetPA As New e_DetallePagoAdicional, odDetPA As New d_DetallePagoAdicional

    Private Function Cargar(ByVal o_fila As DataRow) As e_PagoAdicional
        Try
            Dim oePagoAdicional = New e_PagoAdicional( _
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
            Return oePagoAdicional
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oePagoAdicional As e_PagoAdicional) As e_PagoAdicional

        Try
            Dim ds As DataSet
            With oePagoAdicional
                ds = sqlhelper.ExecuteDataset("PER.Isp_PagoAdicional_Listar", .TipoOperacion, .Id, .IdPlanilla)
            End With
            If ds.Tables(0).rows.Count > 0 Then
                oePagoAdicional = Cargar(ds.Tables(0).Rows(0))
                oeDetPA = New e_DetallePagoAdicional
                oeDetPA.TipoOperacion = ""
                oeDetPA.IndTipo = -1
                oeDetPA.Activo = True
                oeDetPA.IdPagoAdicional = oePagoAdicional.Id
                oePagoAdicional.leDetalle = odDetPA.Listar(oeDetPA)
            End If
            Return oePagoAdicional
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oePagoAdicional As e_PagoAdicional) As List(Of e_PagoAdicional)
        Try
            Dim ldPagoAdicional As New List(Of e_PagoAdicional)
            Dim ds As DataSet
            With oePagoAdicional
                ds = sqlhelper.ExecuteDataset("PER.Isp_PagoAdicional_Listar", .TipoOperacion _
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
            oePagoAdicional = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oePagoAdicional = Cargar(o_Fila)
                ldPagoAdicional.Add(oePagoAdicional)
            Next
            Return ldPagoAdicional
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oePagoAdicional As e_PagoAdicional) As Boolean
        Try
            Dim _idpa As String = ""
            Using TransScope As New TransactionScope()
                With oePagoAdicional
                    _idpa = sqlhelper.ExecuteScalar("PER.Isp_PagoAdicional_IAE", .TipoOperacion, .PrefijoID,
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
                        oeDetAux.PrefijoID = oePagoAdicional.PrefijoID '@0001
                        If oeDetAux.TipoOperacion = "E" Then
                            odDetPA.Eliminar(oeDetAux)
                        Else
                            oeDetAux.IdPagoAdicional = _idpa
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

    Public Function Eliminar(ByVal oePagoAdicional As e_PagoAdicional) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_PagoAdicional_IAE", "E", _
             "", oePagoAdicional.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function ImportarDatos(ByVal oePagoAdicional As e_PagoAdicional) As Boolean
        Try
            Dim _idpa As String = ""
            Using TransScope As New TransactionScope()
                With oePagoAdicional
                    _idpa = sqlhelper.ExecuteScalar("PER.Isp_PagoAdicional_IAE", .TipoOperacion, .PrefijoID,
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
                            Fil("IdPagoAdicional") = _idpa
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
