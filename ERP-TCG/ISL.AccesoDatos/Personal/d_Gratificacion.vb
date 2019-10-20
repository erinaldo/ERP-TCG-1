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

Public Class d_Gratificacion

    Private sqlhelper As New SqlHelper
    Private oeDetalle As New e_DetalleGratificacion, odDetalle As New d_DetalleGratificacion

    Private Function Cargar(ByVal o_fila As DataRow) As e_Gratificacion
        Try
            Dim oeGratificacion = New e_Gratificacion( _
                             o_fila("Id").ToString _
                             , o_fila("IdPeriodo").ToString _
                             , o_fila("Periodo").ToString _
                             , o_fila("IndTipo") _
                             , o_fila("Codigo").ToString _
                             , o_fila("Monto") _
                             , o_fila("Pendiente") _
                             , o_fila("Glosa").ToString _
                             , o_fila("IdEstado").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("PromBono") _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaModifica") _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("Activo") _
            )
            If o_fila("FechaPago").ToString = "" Then
                oeGratificacion.FechaPago = "01/01/1900"
            Else
                oeGratificacion.FechaPago = o_fila("FechaPago")
            End If
            'oeGratificacion.FechaPago = o_fila("FechaPago")
            Return oeGratificacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeGratificacion As e_Gratificacion) As e_Gratificacion
        Try
            Dim ds As DataSet
            With oeGratificacion
                ds = sqlhelper.ExecuteDataset("PER.Isp_BonificacionCompensatorio_Listar", .TipoOperacion, .Id, .IdPeriodo, .IndTipo, .Codigo, .IdEstado, .Activo)
            End With
            If ds.Tables(0).rows.Count > 0 Then
                oeGratificacion = Cargar(ds.Tables(0).Rows(0))
                oeDetalle = New e_DetalleGratificacion
                oeDetalle.TipoOperacion = ""
                oeDetalle.IdGratificacion = oeGratificacion.Id
                oeDetalle.IndPendiente = -1
                oeDetalle.Activo = True
                oeGratificacion.leDetalle = odDetalle.Listar(oeDetalle)
            End If
            Return oeGratificacion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeGratificacion As e_Gratificacion) As List(Of e_Gratificacion)
        Try
            Dim ldGratificacion As New List(Of e_Gratificacion)
            Dim ds As DataSet
            With oeGratificacion
                ds = sqlhelper.ExecuteDataset("PER.Isp_BonificacionCompensatorio_Listar", .TipoOperacion _
                        , .Id _
                        , .IdPeriodo _
                        , .IndTipo _
                        , .Codigo _
                        , .IdEstado _
                        , .Activo _
                        )
            End With
            oeGratificacion = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeGratificacion = Cargar(o_Fila)
                ldGratificacion.Add(oeGratificacion)
            Next
            Return ldGratificacion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeGratificacion As e_Gratificacion) As Boolean
        Try
            Dim _idgrati As String = ""
            Using TransScope As New TransactionScope()
                With oeGratificacion

                    _idgrati = sqlhelper.ExecuteScalar("PER.Isp_BonificacionCompensatorio_IAE", .TipoOperacion, .PrefijoID,
                            .Id _
                            , .IdPeriodo _
                            , .IndTipo _
                            , .Codigo _
                            , .Monto _
                            , .Pendiente _
                            , .Glosa _
                            , .IdEstado _
                            , .PromBono _
                            , .FechaCreacion _
                            , .UsuarioCreacion _
                            , .FechaModifica _
                            , .UsuarioModifica _
                            , .Activo _
                            , .FechaPago
                        )

                    For Each oeDet In .leDetalle
                        oeDet.IdGratificacion = _idgrati
                        oeDet.PrefijoID = oeGratificacion.PrefijoID '@0001
                        If oeDet.TipoOperacion <> "" Then
                            If oeDet.TipoOperacion = "E" Then
                                odDetalle.Eliminar(oeDet)
                            Else
                                odDetalle.Guardar(oeDet)
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

    Public Function Eliminar(ByVal oeGratificacion As e_Gratificacion) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_BonificacionCompensatorio_IAE", "E", _
             "", oeGratificacion.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function ImportarDatos(ByVal oeGratificacion As e_Gratificacion) As Boolean
        Try
            Dim _idgrati As String = ""
            Using TransScope As New TransactionScope()
                With oeGratificacion
                    _idgrati = sqlhelper.ExecuteScalar("PER.Isp_BonificacionCompensatorio_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdPeriodo _
                        , .IndTipo _
                        , .Codigo _
                        , .Monto _
                        , .Pendiente _
                        , .Glosa _
                        , .IdEstado _
                        , .PromBono _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo _
                        , .FechaPago
                    )
                    If .dtDetalle.Rows.Count > 0 Then
                        For Each Fil As DataRow In .dtDetalle.Rows
                            Fil("IdBonoCompensatorio") = _idgrati
                        Next
                        odDetalle.GuardarMasivo(.dtDetalle)
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
