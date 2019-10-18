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

Public Class d_TipoEquipo

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_TipoEquipo
        Try
            Dim oeTipoEquipo = New e_TipoEquipo( _
                             o_Fila("Id").ToString _
                             , o_Fila("Nombre").ToString _
                             , o_Fila("Abreviatura").ToString _
                             , o_Fila("Activo").ToString _
                             , o_Fila("UsuarioCreacion").ToString _
                             , o_Fila("FechaCreacion").ToString _
            )
            Return oeTipoEquipo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoEquipo As e_TipoEquipo) As e_TipoEquipo

        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "", oeTipoEquipo.Id)
            If ds.Tables.Count > 0 Then
                oeTipoEquipo = Cargar(ds.Tables(0).Rows(0))
                Return oeTipoEquipo
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTipoEquipo As e_TipoEquipo) As List(Of e_TipoEquipo)
        Try
            Dim ldTipoEquipo As New List(Of e_TipoEquipo)
            Dim ds As DataSet
            With oeTipoEquipo
                ds = SqlHelper.ExecuteDataset("MAN.Isp_TipoEquipo_Listar", "" _
                        , .Id _
                        , .Nombre _
                        , .Abreviatura _
                        , .Activo _
                        , .UsuarioCreacion _
                        )
            End With
            oeTipoEquipo = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeTipoEquipo = Cargar(o_Fila)
                    ldTipoEquipo.Add(oeTipoEquipo)
                Next
                Return ldTipoEquipo
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoEquipo As e_TipoEquipo) As Boolean
        Try
            With oeTipoEquipo
                sqlhelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .Nombre _
                        , .Abreviatura _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .FechaCreacion
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeTipoEquipo As e_TipoEquipo) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
             "", oeTipoEquipo.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function


End Class

