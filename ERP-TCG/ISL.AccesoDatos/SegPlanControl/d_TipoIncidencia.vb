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

Public Class d_TipoIncidencia
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_TipoIncidencia
        Try
            Dim oeTipoIncidencia = New e_TipoIncidencia( _
                             o_Fila("Id").ToString _
                             , o_Fila("Nombre").ToString _
                             , o_Fila("Activo").ToString _
                             , o_Fila("UsuarioCreacion").ToString _
                             , o_Fila("FechaCreacion").ToString _
                             , o_Fila("FechaModifica").ToString _
                             , o_Fila("UsuarioModifica").ToString _
            )
            Return oeTipoIncidencia
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoIncidencia As e_TipoIncidencia) As e_TipoIncidencia

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("SPC.Isp_TipoIncidencia_Listar", "", oeTipoIncidencia.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeTipoIncidencia = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeTipoIncidencia
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTipoIncidencia As e_TipoIncidencia) As List(Of e_TipoIncidencia)
        Try
            Dim ldTipoIncidencia As New List(Of e_TipoIncidencia)
            Dim ds As DataSet
            With oeTipoIncidencia
                ds = sqlhelper.ExecuteDataset("SPC.Isp_TipoIncidencia_Listar", "" _
                        , .Id _
                        , .Nombre _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .FechaCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        )
            End With
            oeTipoIncidencia = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeTipoIncidencia = Cargar(o_Fila)
                ldTipoIncidencia.Add(oeTipoIncidencia)
            Next
            Return ldTipoIncidencia
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoIncidencia As e_TipoIncidencia) As Boolean
        Try
            With oeTipoIncidencia
                sqlhelper.ExecuteNonQuery("SPC.Isp_TipoIncidencia_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .Nombre _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .FechaCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeTipoIncidencia As e_TipoIncidencia) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SPC.Isp_TipoIncidencia_IAE", "E", _
             "", oeTipoIncidencia.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class
