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

Public Class d_TipoZona

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_TipoZona
        Try
            Dim oeTipoZona = New e_TipoZona( _
                             o_Fila("Id").ToString _
                             , o_Fila("Nombre").ToString _
                             , o_Fila("Abreviatura").ToString _
                             , o_Fila("Activo").ToString _
                             , o_Fila("UsuarioCreacion").ToString _
                             , o_Fila("FechaCreacion").ToString _
            )
            Return oeTipoZona
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoZona As e_TipoZona) As e_TipoZona

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_TipoZona_Listar", "", oeTipoZona.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeTipoZona = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeTipoZona
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTipoZona As e_TipoZona) As List(Of e_TipoZona)
        Try
            Dim ldTipoZona As New List(Of e_TipoZona)
            Dim ds As DataSet
            With oeTipoZona
                ds = sqlhelper.ExecuteDataset("STD.Isp_TipoZona_Listar", "" _
                        , .Id _
                        , .Nombre _
                        , .Abreviatura _
                        , .Activo _
                        , .UsuarioCreacion _
                        )
            End With
            oeTipoZona = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeTipoZona = Cargar(o_Fila)
                ldTipoZona.Add(oeTipoZona)
            Next
            Return ldTipoZona
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoZona As e_TipoZona) As Boolean
        Try
            With oeTipoZona
                sqlhelper.ExecuteNonQuery("STD.Isp_TipoZona_IAE", .TipoOperacion,
                        .Id _
                        , .Nombre _
                        , .Abreviatura _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .PrefijoID
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeTipoZona As e_TipoZona) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_TipoZona_IAE", "E", oeTipoZona.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function


End Class
