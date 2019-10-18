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

Public Class d_Alerta

    Private sqlhelper As New SqlHelper
    Dim odAlertaDestino As New d_AlertaDestino
    Dim odAlertaDetalle As New d_AlertaDetalle

    Private Function Cargar(ByVal o_fila As DataRow) As e_Alerta
        Try
            Dim oeAlerta = New e_Alerta( _
                             o_fila("Id").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("NombreCompleto") _
                             , o_fila("IdActividadNegocio").ToString _
                             , o_fila("ActividadNegocio") _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("Glosa") _
                             , o_fila("Email") _
                             , o_fila("Sonora") _
                             , o_fila("Visual") _
                             , o_fila("Estado").ToString _
                             , o_fila("IdAlertaDetalle") _
                             , o_fila("Activo").ToString _
            )
            Return oeAlerta
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeAlerta As e_Alerta) As e_Alerta
        Try
            Dim ds As DataSet
            Dim oeAlertaDetalle As New e_AlertaDetalle
            Dim oeAlertaDestino As New e_AlertaDestino

            ds = sqlhelper.ExecuteDataset("SGD.Isp_Alerta_Listar", "", oeAlerta.Id)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeAlerta = Cargar(ds.Tables(0).Rows(0))
                oeAlertaDetalle.IdAlerta = oeAlerta.Id
                oeAlerta.leDetalle = odAlertaDetalle.Listar(oeAlertaDetalle)
                oeAlertaDestino.IdAlerta = oeAlerta.Id
                oeAlerta.leDestino = odAlertaDestino.Listar(oeAlertaDestino)
            End If
            Return oeAlerta
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeAlerta As e_Alerta) As List(Of e_Alerta)
        Try
            Dim ldAlerta As New List(Of e_Alerta)
            Dim ds As DataSet
            With oeAlerta
                ds = sqlhelper.ExecuteDataset("SGD.Isp_Alerta_Listar", "" _
                        , .Id _
                        , .UsuarioCreacion _
                        , .IdActividadNegocio _
                        , .Estado _
                        , .Activo _
                        )
            End With
            oeAlerta = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeAlerta = Cargar(o_Fila)
                ldAlerta.Add(oeAlerta)
            Next
            Return ldAlerta
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeAlerta As e_Alerta) As Boolean
        Try
            Using TransScope As New TransactionScope()
                Dim id As String = ""
                With oeAlerta
                    id = sqlhelper.ExecuteScalar("SGD.Isp_Alerta_IAE", .TipoOperacion,
                            .Id _
                            , .UsuarioCreacion _
                            , .IdActividadNegocio _
                            , .Estado _
                            , .Activo _
                            , .PrefijoID
                        )
                End With
                If oeAlerta.oeAlertaDetalle IsNot Nothing Then
                    Dim odAlertaDetalle As New d_AlertaDetalle
                    oeAlerta.oeAlertaDetalle.UsuarioCreacion = oeAlerta.UsuarioCreacion
                    oeAlerta.oeAlertaDetalle.Estado = oeAlerta.Estado
                    oeAlerta.oeAlertaDetalle.IdAlerta = id
                    oeAlerta.oeAlertaDetalle.PrefijoID = oeAlerta.PrefijoID '@0001
                    odAlertaDetalle.Guardar(oeAlerta.oeAlertaDetalle)
                End If
                If oeAlerta.leDestino.Count > 0 Then
                    For Each oeAlertaDestino As e_AlertaDestino In oeAlerta.leDestino
                        oeAlertaDestino.IdAlerta = id
                        'oeAlertaDestino.UsuarioCreacion = oeAlerta.UsuarioCreacion
                        oeAlertaDestino.PrefijoID = oeAlerta.PrefijoID '@0001
                        odAlertaDestino.Guardar(oeAlertaDestino)
                    Next
                End If
                TransScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeAlerta As e_Alerta) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SGD.Isp_Alerta_IAE", "E", oeAlerta.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
