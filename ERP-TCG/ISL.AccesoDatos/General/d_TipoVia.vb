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

Public Class d_TipoVia

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_TipoVia
        Try
            Dim oeTipoVia = New e_TipoVia( _
                             o_Fila("Id").ToString _
                             , o_Fila("Nombre").ToString _
                             , o_Fila("Abreviatura").ToString _
                             , o_Fila("Activo").ToString _
                             , o_Fila("UsuarioCreacion").ToString _
                             , o_Fila("FechaCreacion").ToString _
            )
            Return oeTipoVia
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoVia As e_TipoVia) As e_TipoVia

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_TipoVia_Listar", "", oeTipoVia.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeTipoVia = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeTipoVia
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTipoVia As e_TipoVia) As List(Of e_TipoVia)
        Try
            Dim ldTipoVia As New List(Of e_TipoVia)
            Dim ds As DataSet
            With oeTipoVia
                ds = sqlhelper.ExecuteDataset("STD.Isp_TipoVia_Listar", "" _
                        , .Id _
                        , .Nombre _
                        , .Abreviatura _
                        , .Activo _
                        , .UsuarioCreacion _
                        )
            End With
            oeTipoVia = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeTipoVia = Cargar(o_Fila)
                ldTipoVia.Add(oeTipoVia)
            Next
            Return ldTipoVia
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoVia As e_TipoVia) As Boolean
        Try
            With oeTipoVia
                sqlhelper.ExecuteNonQuery("STD.Isp_TipoVia_IAE", .TipoOperacion,
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

    Public Function Eliminar(ByVal oeTipoVia As e_TipoVia) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_TipoVia_IAE", "E", oeTipoVia.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function


End Class
