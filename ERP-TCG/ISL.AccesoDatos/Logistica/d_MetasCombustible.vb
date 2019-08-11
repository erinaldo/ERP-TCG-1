Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_MetasCombustible
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_MetasCombustible
        Try
            Dim oeMetasCombustible = New e_MetasCombustible( _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("IdModeloTracto").ToString _
                             , o_fila("ModeloTracto").ToString _
                             , o_fila("MarcaTracto").ToString _
                             , o_fila("IdMarcaTracto").ToString _
                             , o_fila("IdModeloCarreta").ToString _
                             , o_fila("ModeloCarreta").ToString _
                             , o_fila("MarcaCarreta").ToString _
                             , o_fila("IdMarcaCarreta").ToString _
                             , o_fila("Rutas").ToString _
                             , o_fila("Pesos").ToString _
                             , o_fila("Rendimiento") _
                             , o_fila("Distancia") _
                             , o_fila("Activo") _
                             , o_fila("UsuarioCreacion").ToString _
                                     )
            Return oeMetasCombustible
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMetasCombustible As e_MetasCombustible) As e_MetasCombustible

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[ALM].[Isp_MetasCombustible_Listar]", "", oeMetasCombustible.Id)
            If ds.Tables.Count > 0 Then
                oeMetasCombustible = Cargar(ds.Tables(0).Rows(0))
                Return oeMetasCombustible
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMetasCombustible As e_MetasCombustible) As List(Of e_MetasCombustible)
        Try
            Dim ldMetasCombustible As New List(Of e_MetasCombustible)
            Dim ds As DataSet
            With oeMetasCombustible
                ds = sqlhelper.ExecuteDataset("[ALM].[Isp_MetasCombustible_Listar]", .TipoOperacion _
                        , .Id _
                        , .IdModeloTracto _
                        , .IdModeloCarreta _
                        , .Ruta _
                        , .Pesos _
                        , .Rendimiento _
                        , .Distancia _
                        , .Activo _
                        , .UsuarioCreacion _
                                             )
            End With
            oeMetasCombustible = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMetasCombustible = Cargar(o_Fila)
                    ldMetasCombustible.Add(oeMetasCombustible)
                Next
            End If
            Return ldMetasCombustible
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMetasCombustible As e_MetasCombustible) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeMetasCombustible
                sqlhelper.ExecuteNonQuery("[ALM].[Isp_MetasCombustible_IAE]", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .IdModeloTracto _
                        , .IdModeloCarreta _
                        , .Ruta _
                        , .Pesos _
                        , .Rendimiento _
                        , .Distancia _
                        , .Activo _
                        , .UsuarioCreacion _
                                      )
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeMetasCombustible As e_MetasCombustible) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[ALM].[Isp_MetasCombustible_IAE]", "E", _
             "", oeMetasCombustible.Id)
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
