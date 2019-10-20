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

Public Class d_AccionSistema

    Private sqlhelper As New SqlHelper
    Dim oeAR As New e_ActividadRestringida
    Dim odAR As New d_ActividadRestringida

    Private Function Cargar(ByVal o_fila As DataRow) As e_AccionSistema
        Try
            Dim oeAccionSistema = New e_AccionSistema( _
                             o_Fila("Id").ToString _
                             , o_Fila("Codigo").ToString _
                             , o_Fila("Nombre").ToString _
                             , o_Fila("Descripcion").ToString _
                             , o_Fila("Activo").ToString _
                             , o_Fila("FechaCreacion").ToString _
                             , o_Fila("UsuarioCreacion").ToString _
            )
            Return oeAccionSistema
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeAccionSistema As e_AccionSistema) As e_AccionSistema

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("SGD.Isp_AccionSistema_Listar", oeAccionSistema.TipoOperacion, oeAccionSistema.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeAccionSistema = Cargar(ds.Tables(0).Rows(0))
                oeAR = New e_ActividadRestringida
                oeAR.IdAccionSistema = oeAccionSistema.Id
                oeAccionSistema.leActividadRestringida = odAR.Listar(oeAR)
            End If
            Return oeAccionSistema
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeAccionSistema As e_AccionSistema) As List(Of e_AccionSistema)
        Try
            Dim ldAccionSistema As New List(Of e_AccionSistema)
            Dim ds As DataSet
            With oeAccionSistema
                ds = sqlhelper.ExecuteDataset("SGD.Isp_AccionSistema_Listar", .TipoOperacion _
                        , .Id _
                        , .Codigo _
                        , .Nombre _
                        , .Descripcion _
                        , .Activo _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        )
            End With
            oeAccionSistema = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeAccionSistema = Cargar(o_Fila)
                ldAccionSistema.Add(oeAccionSistema)
            Next
            Return ldAccionSistema
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeAccionSistema As e_AccionSistema) As Boolean
        Try
            Using TransScope As New TransactionScope()
                Dim _id As String = ""
                With oeAccionSistema
                    _id = sqlhelper.ExecuteScalar("SGD.Isp_AccionSistema_IAE", .TipoOperacion, .PrefijoID,
                            .Id _
                            , .Codigo _
                            , .Nombre _
                            , .Descripcion _
                            , .Activo _
                            , .FechaCreacion _
                            , .UsuarioCreacion
                        )
                    If .leActividadRestringida.Count > 0 Then
                        For Each oe In .leActividadRestringida
                            oe.PrefijoID = oeAccionSistema.PrefijoID '@0001
                            oe.IdAccionSistema = _id
                            If oe.TipoOperacion = "E" Then
                                odAR.Eliminar(oe)
                            Else
                                odAR.Guardar(oe)
                            End If
                        Next
                    End If
                End With
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeAccionSistema As e_AccionSistema) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SGD.Isp_AccionSistema_IAE", "E", _
             "", oeAccionSistema.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function


End Class
