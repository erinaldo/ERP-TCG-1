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

Public Class d_TipoNeumatico
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_TipoNeumatico
        Try
            Dim oeTipoNeumatico = New e_TipoNeumatico( _
                             o_fila("Id").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Abreviatura").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                                       )
            Return oeTipoNeumatico
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoNeumatico As e_TipoNeumatico) As e_TipoNeumatico

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[NEU].[Isp_TipoNeumatico_Listar]", "", oeTipoNeumatico.Id)
            If ds.Tables.Count > 0 Then
                oeTipoNeumatico = Cargar(ds.Tables(0).Rows(0))
                Return oeTipoNeumatico
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTipoNeumatico As e_TipoNeumatico) As List(Of e_TipoNeumatico)
        Try
            Dim ldTipoNeumatico As New List(Of e_TipoNeumatico)
            Dim ds As DataSet
            With oeTipoNeumatico
                ds = sqlhelper.ExecuteDataset("[NEU].[Isp_TipoNeumatico_Listar]", "" _
                        , .Id _
                        , .Nombre _
                        , .Abreviatura _
                        , .Activo _
                        , .UsuarioCreacion _
                                    )
            End With
            oeTipoNeumatico = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeTipoNeumatico = Cargar(o_Fila)
                    ldTipoNeumatico.Add(oeTipoNeumatico)
                Next
            End If
            Return ldTipoNeumatico
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoNeumatico As e_TipoNeumatico) As Boolean
        Try
            With oeTipoNeumatico
                sqlhelper.ExecuteNonQuery("[NEU].[Isp_TipoNeumatico_IAE]", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .Nombre _
                        , .Abreviatura _
                        , .Activo _
                        , .UsuarioCreacion
                         )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeTipoNeumatico As e_TipoNeumatico) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[NEU].[Isp_TipoNeumatico_IAE]", "E", "", oeTipoNeumatico.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
