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

Public Class d_AlertaDestino

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_AlertaDestino
        Try
            Dim oeAlertaDestino = New e_AlertaDestino( _
                             o_fila("Id").ToString _
                             , o_fila("IdAlerta").ToString _
                             , o_fila("IdPersona").ToString _
                             , o_fila("NombreCompleto") _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeAlertaDestino
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeAlertaDestino As e_AlertaDestino) As e_AlertaDestino

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("SGD.Isp_AlertaDestino_Listar", "", oeAlertaDestino.Id)
            If ds.Tables.Count > 1 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeAlertaDestino = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeAlertaDestino
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeAlertaDestino As e_AlertaDestino) As List(Of e_AlertaDestino)
        Try
            Dim ldAlertaDestino As New List(Of e_AlertaDestino)
            Dim ds As DataSet
            With oeAlertaDestino
                ds = sqlhelper.ExecuteDataset("SGD.Isp_AlertaDestino_Listar", "" _
                        , .Id _
                        , .IdAlerta _
                        , .IdPersona _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oeAlertaDestino = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeAlertaDestino = Cargar(o_Fila)
                ldAlertaDestino.Add(oeAlertaDestino)
            Next
            Return ldAlertaDestino
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeAlertaDestino As e_AlertaDestino) As Boolean
        Try
            With oeAlertaDestino
                sqlhelper.ExecuteNonQuery("SGD.Isp_AlertaDestino_IAE", .TipoOperacion,
                        .Id _
                        , .IdAlerta _
                        , .IdPersona _
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

    Public Function Eliminar(ByVal oeAlertaDestino As e_AlertaDestino) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SGD.Isp_AlertaDestino_IAE", "E", oeAlertaDestino.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
