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

Public Class d_DetalleConfiguracionNeumatico
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_DetalleConfiguracionNeumatico
        Try
            Dim oeDetalleConfiguracionNeumatico = New e_DetalleConfiguracionNeumatico( _
                             o_fila("Id").ToString _
                             , o_fila("IdConfiguracionNeumaticos").ToString _
                             , o_fila("NroLineaEje").ToString _
                             , o_fila("CantidadLlantas").ToString _
                             , o_fila("IndTraccion").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                        )
            Return oeDetalleConfiguracionNeumatico
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDetalleConfiguracionNeumatico As e_DetalleConfiguracionNeumatico) As e_DetalleConfiguracionNeumatico

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[NEU].[Isp_DetalleConfiguracionNeumatico_Listar]", "", oeDetalleConfiguracionNeumatico.Id)
            If ds.Tables.Count > 0 Then
                oeDetalleConfiguracionNeumatico = Cargar(ds.Tables(0).Rows(0))
                Return oeDetalleConfiguracionNeumatico
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDetalleConfiguracionNeumatico As e_DetalleConfiguracionNeumatico) As List(Of e_DetalleConfiguracionNeumatico)
        Try
            Dim ldDetalleConfiguracionNeumatico As New List(Of e_DetalleConfiguracionNeumatico)
            Dim ds As DataSet
            With oeDetalleConfiguracionNeumatico
                ds = sqlhelper.ExecuteDataset("[NEU].[Isp_DetalleConfiguracionNeumatico_Listar]", "" _
                        , .Id _
                        , .IdConfiguracionNeumatico _
                        , .NroLineaEje _
                        , .CantidadLlantas _
                        , .IndTraccion _
                        , .Activo _
                        , .UsuarioCreacion _
                                          )
            End With
            oeDetalleConfiguracionNeumatico = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeDetalleConfiguracionNeumatico = Cargar(o_Fila)
                    ldDetalleConfiguracionNeumatico.Add(oeDetalleConfiguracionNeumatico)
                Next
            End If
            Return ldDetalleConfiguracionNeumatico
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDetalleConfiguracionNeumatico As e_DetalleConfiguracionNeumatico) As Boolean
        Try
            With oeDetalleConfiguracionNeumatico
                sqlhelper.ExecuteNonQuery("[NEU].[Isp_DetalleConfiguracionNeumatico_IAE]", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdConfiguracionNeumatico _
                        , .NroLineaEje _
                        , .CantidadLlantas _
                        , .IndTraccion _
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

    Public Function Eliminar(ByVal oeDetalleConfiguracionNeumatico As e_DetalleConfiguracionNeumatico) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[NEU].[Isp_DetalleConfiguracionNeumatico_IAE]", "E", _
             "", oeDetalleConfiguracionNeumatico.Id, oeDetalleConfiguracionNeumatico.IdConfiguracionNeumatico)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
