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

Public Class d_AlertaDetalle

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_AlertaDetalle
        Try
            Dim oeAlertaDetalle = New e_AlertaDetalle( _
                             o_fila("Id").ToString _
                             , o_fila("IdAlerta").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("Email").ToString _
                             , o_fila("Visual").ToString _
                             , o_fila("Sonora").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("NombreCompleto") _
                             , o_fila("Activo").ToString _
            )
            Return oeAlertaDetalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeAlertaDetalle As e_AlertaDetalle) As e_AlertaDetalle
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("SGD.Isp_AlertaDetalle_Listar", "", oeAlertaDetalle.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeAlertaDetalle = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeAlertaDetalle
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeAlertaDetalle As e_AlertaDetalle) As List(Of e_AlertaDetalle)
        Try
            Dim ldAlertaDetalle As New List(Of e_AlertaDetalle)
            Dim ds As DataSet
            With oeAlertaDetalle
                ds = sqlhelper.ExecuteDataset("SGD.Isp_AlertaDetalle_Listar", "" _
                        , .Id _
                        , .IdAlerta _
                        , .Estado _
                        , .Glosa _
                        , .Email _
                        , .Visual _
                        , .Sonora _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oeAlertaDetalle = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeAlertaDetalle = Cargar(o_Fila)
                ldAlertaDetalle.Add(oeAlertaDetalle)
            Next
            Return ldAlertaDetalle
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeAlertaDetalle As e_AlertaDetalle) As Boolean
        Try
            With oeAlertaDetalle
                sqlhelper.ExecuteNonQuery("SGD.Isp_AlertaDetalle_IAE", .TipoOperacion,
                        .Id _
                        , .IdAlerta _
                        , .Estado _
                        , .Glosa _
                        , .Email _
                        , .Visual _
                        , .Sonora _
                        , .UsuarioCreacion _
                        , .Activo _
                        , .PrefijoID
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeAlertaDetalle As e_AlertaDetalle) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SGD.Isp_AlertaDetalle_IAE", "E", oeAlertaDetalle.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function


End Class
