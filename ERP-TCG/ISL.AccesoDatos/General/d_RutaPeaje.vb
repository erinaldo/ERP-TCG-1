'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF

Public Class d_RutaPeaje
    Private sqlhelper As New SqlHelper

    Private Function Cargar(o_fila As DataRow) As e_RutaPeaje
        Try
            Dim oeRutaPeaje = New e_RutaPeaje With {
                         .Id = o_fila("Id").ToString _
                         , .IdRuta = o_fila("IdRuta").ToString _
                         , .IdPeaje = o_fila("IdPeaje").ToString _
                         , .Peaje = o_fila("Peaje").ToString _
                         , .Glosa = o_fila("Glosa").ToString _
                         , .UsuarioCreacion = o_fila("UsuarioCreacion").ToString _
                         , .FechaCreacion = o_fila("FechaCreacion") _
                         , .UsuarioModificacion = o_fila("UsuarioModificacion").ToString _
                         , .FechaModificacion = o_fila("FechaModificacion") _
                         , .Activo = o_fila("Activo") _
            }
            Return oeRutaPeaje
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(oeRutaPeaje As e_RutaPeaje) As e_RutaPeaje
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_RutaPeaje_Listar",
                                          "GEN",
                                          oeRutaPeaje.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeRutaPeaje = Cargar(ds.Tables(0).Rows(0))
            Else
                oeRutaPeaje = New e_RutaPeaje
            End If
            Return oeRutaPeaje
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oeRutaPeaje As e_RutaPeaje) As List(Of e_RutaPeaje)
        Try
            Dim ldRutaPeaje As New List(Of e_RutaPeaje)
            Dim ds As DataSet
            With oeRutaPeaje
                ds = sqlhelper.ExecuteDataset("STD.Isp_RutaPeaje_Listar",
                                              .TipoOperacion _
                                            , .Id _
                                            , .IdRuta _
                                            , .IdPeaje _
                                            , .Glosa _
                                            , .Activo)
            End With
            oeRutaPeaje = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeRutaPeaje = Cargar(o_Fila)
                ldRutaPeaje.Add(oeRutaPeaje)
            Next
            Return ldRutaPeaje
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeRutaPeaje As e_RutaPeaje) As Boolean
        Try
            With oeRutaPeaje
                sqlhelper.ExecuteNonQuery("STD.Isp_RutaPeaje_IAE",
                                          .TipoOperacion _
                                            , .PrefijoID _
                                            , .Id _
                                            , .IdRuta _
                                            , .IdPeaje _
                                            , .Glosa _
                                            , .Activo _
                                            , .UsuarioCreacion)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeRutaPeaje As e_RutaPeaje) As Boolean
        Try
            With oeRutaPeaje
                sqlhelper.ExecuteNonQuery("STD.Isp_RutaPeaje_IAE",
                                          "E" _
                                            , "" _
                                            , .Id _
                                            , .IdRuta _
                                            , .IdPeaje _
                                            , .Glosa _
                                            , .Activo _
                                            , .UsuarioCreacion)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
