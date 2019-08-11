Imports ISL.EntidadesWCF
Public Class d_BolsaRuta
    Private sqlhelper As New SqlHelper

    Private oeBolsaRuta As e_BolsaRuta

    ''' <summary>
    ''' Crear el objeto Bolsa Ruta
    ''' </summary>
    ''' <param name="o_fila"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function Cargar(ByVal o_fila As DataRow) As e_BolsaRuta
        Try
            Dim oeBolsaRuta = New e_BolsaRuta(o_fila("Id"), _
                                              o_fila("IdRuta"), _
                                              o_fila("IdTipoVehiculo"), _
                                              o_fila("Nombre"), _
                                              o_fila("Origen") + " - " + o_fila("Destino"), _
                                              o_fila("MontoMinimo"), _
                                              o_fila("MontoNormal"), _
                                              o_fila("MontoMaximo"), _
                                              o_fila("Activo"), _
                                              o_fila("UsuarioCreacion"))
            Return oeBolsaRuta
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Obtiene un objeto de Bolsa Ruta a partir de su Id
    ''' </summary>
    ''' <param name="oeBolsaRuta">Objeto de Bolsa Ruta</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal oeBolsaRuta As e_BolsaRuta) As e_BolsaRuta
        Try
            Dim ds As New DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_BolsaRuta_Listar", "", oeBolsaRuta.Id, oeBolsaRuta.IdRuta, oeBolsaRuta.Activo)
            oeBolsaRuta = New e_BolsaRuta
            If ds.Tables(0).Rows.Count > 0 Then
                oeBolsaRuta = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeBolsaRuta
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Crear una lista de objetos de Bolsa Ruta
    ''' </summary>
    ''' <param name="oeBolsaRuta"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Listar(ByVal oeBolsaRuta As e_BolsaRuta) As List(Of e_BolsaRuta)
        Try
            Dim ldBolsaRuta As New List(Of e_BolsaRuta)
            Dim ds As DataSet
            With oeBolsaRuta
                ds = sqlhelper.ExecuteDataset("TES.Isp_BolsaRuta_Listar", "", .Id, .IdRuta, _
                     .Activo)
            End With
            oeBolsaRuta = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeBolsaRuta = Cargar(o_Fila)
                    ldBolsaRuta.Add(oeBolsaRuta)
                Next
                Return ldBolsaRuta
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeBolsaRuta As e_BolsaRuta) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion

            With oeBolsaRuta
                sqlhelper.ExecuteNonQuery("TES.Isp_BolsaRuta_IAE", .TipoOperacion, _
                .Id, .IdRuta, .IdTipoVehiculo, .MontoMinimo, .MontoNormal, .MontoMaximo, .Activo, .Usuario, d_DatosConfiguracion.PrefijoID)
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeBolsaRuta As e_BolsaRuta) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("TES.Isp_BolsaRuta_IAE", "E", oeBolsaRuta.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
