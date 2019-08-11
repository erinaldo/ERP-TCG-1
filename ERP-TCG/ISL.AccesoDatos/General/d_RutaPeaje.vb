Imports ISL.EntidadesWCF

Public Class d_RutaPeaje
    Private sqlhelper As SqlHelper

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
            sqlhelper = New SqlHelper
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_RutaPeaje_Listar", _
                                          "GEN", _
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
            sqlhelper = New SqlHelper
            Dim ldRutaPeaje As New List(Of e_RutaPeaje)
            Dim ds As DataSet
            With oeRutaPeaje
                ds = sqlhelper.ExecuteDataset("STD.Isp_RutaPeaje_Listar", _
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
            sqlhelper = New SqlHelper
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeRutaPeaje
                sqlhelper.ExecuteNonQuery("STD.Isp_RutaPeaje_IAE", _
                                          .TipoOperacion _
                                            , d_DatosConfiguracion.PrefijoID _
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
            sqlhelper = New SqlHelper
            With oeRutaPeaje
                sqlhelper.ExecuteNonQuery("STD.Isp_RutaPeaje_IAE", _
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
