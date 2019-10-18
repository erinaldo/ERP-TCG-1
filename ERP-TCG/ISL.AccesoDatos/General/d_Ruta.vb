'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Transactions

Public Class d_Ruta

#Region "Variables"
    Private sqlhelper As New SqlHelper
    Private odTiempoCiclo As New d_TiempoCiclo
    Private odFlte As New d_Flete
    Private odBolsaViaje As New d_BolsaViaje
    Private odDistanciaZona As New d_DistanciaZona
    Private odMontoRuta As New d_MontoRuta
    Private odZonaCombustible As New d_ZonaCombustible
    Private odRutaPeaje As d_RutaPeaje
#End Region
    
    Private Function Cargar(ByVal o_fila As DataRow) As e_Ruta
        Try
            Dim oeRuta = New e_Ruta(o_fila("Seleccion") _
                            , o_fila("Id").Trim.ToString() _
                             , o_fila("Codigo").ToString() _
                             , o_fila("IdOrigen").ToString() _
                             , o_fila("Origen").ToString() _
                             , o_fila("IdDestino").ToString() _
                             , o_fila("Destino").ToString() _
                             , o_fila("IdCentro").ToString() _
                             , o_fila("IdFlota").ToString() _
                             , o_fila("Kilometros") _
                             , o_fila("HorasSolo") _
                             , o_fila("HorasAcompañado") _
                             , o_fila("IndicadorLocal") _
                             , o_fila("FactorReferencial").ToString() _
                             , o_fila("Activo") _
                             , o_fila("Nombre").ToString() _
                             , o_fila("CantidadTarifas"))
            Return oeRuta
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeRuta As e_Ruta) As e_Ruta
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[STD].[Isp_Ruta_Listar]", _
                                          oeRuta.TipoOperacion, _
                                          oeRuta.Id, _
                                          oeRuta.IdOrigen, _
                                          oeRuta.IdDestino)
            If ds.Tables(0).Rows.Count > 0 Then
                oeRuta = Cargar(ds.Tables(0).Rows(0))
            Else
                oeRuta = New e_Ruta
            End If
            Return oeRuta
        Catch ex As Exception
            Throw ex
        End Try
    End Function
   
    Public Function Listar(ByVal oeRuta As e_Ruta) As List(Of e_Ruta)
        Try
            Dim ldRuta As New List(Of e_Ruta)
            Dim ds As DataSet
            With oeRuta
                ds = sqlhelper.ExecuteDataset("[STD].[Isp_Ruta_Listar]", _
                                              oeRuta.TipoOperacion _
                                             , .Id _
                                             , .IdOrigen _
                                             , .IdDestino _
                                             , .IdCentro _
                                             , .IdFlota _
                                             , .Activo)
            End With
            oeRuta = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeRuta = Cargar(o_Fila)
                    ldRuta.Add(oeRuta)
                Next
            Else
                ldRuta = New List(Of e_Ruta)
            End If
            Return ldRuta
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarGrupos(ByVal oeRuta As e_Ruta) As DataSet
        Try
            Return sqlhelper.ExecuteDataset("[STD].[Isp_Ruta_Listar]", "1" _
                                    , "" _
                                    , "" _
                                    , "" _
                                    , "" _
                                    , "" _
                                    , oeRuta.Activo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeRuta As e_Ruta) As Boolean
        Dim stResultado() As String
        Try
            odRutaPeaje = New d_RutaPeaje
            Using transScope As New TransactionScope()
                With oeRuta
                    stResultado = sqlhelper.ExecuteScalar("[STD].[Isp_Ruta_IAE]", _
                                        .TipoOperacion, _
                                        .PrefijoID, _
                                        "A", _
                                         .Id.Trim _
                                        , .Codigo _
                                        , .IdOrigen _
                                        , .IdDestino _
                                        , .IdCentro _
                                        , .IdFlota _
                                        , .Kilometros _
                                        , .HorasSolo _
                                        , .HorasAcompañado _
                                        , .IndicadorLocal _
                                        , .FactorReferencial _
                                        , .Activo _
                                        , .UsuarioCreacion).ToString.Split("_")
                End With
                If oeRuta.oeTiempoCiclo.Count > 0 Then
                    For Each TiempoCiclo As e_TiempoCiclo In oeRuta.oeTiempoCiclo
                        TiempoCiclo.IdRuta = stResultado(0)
                        TiempoCiclo.PrefijoID = oeRuta.PrefijoID '@0001
                        odTiempoCiclo.Guardar(TiempoCiclo)
                    Next
                End If

                If oeRuta.oeFlete.Count > 0 Then
                    For Each Flete As e_Flete In oeRuta.oeFlete
                        Flete.IdRuta = stResultado(0)
                        Flete.PrefijoID = oeRuta.PrefijoID '@0001
                        odFlte.Guardar(Flete)
                    Next
                End If

                If oeRuta.oeBolsaViaje.Count > 0 Then
                    For Each BolsaViaje As e_BolsaViaje In oeRuta.oeBolsaViaje
                        BolsaViaje.IdRuta = stResultado(0)
                        BolsaViaje.PrefijoID = oeRuta.PrefijoID '@0001
                        odBolsaViaje.Guardar(BolsaViaje)
                    Next
                End If

                If oeRuta.oeDistanciaZona.Count > 0 Then
                    For Each DistanciaZona As e_DistanciaZona In oeRuta.oeDistanciaZona
                        DistanciaZona.TipoOperacion = "I"
                        DistanciaZona.IdRuta = stResultado(0)
                        DistanciaZona.PrefijoID = oeRuta.PrefijoID '@0001
                        odDistanciaZona.Guardar(DistanciaZona)
                    Next
                End If

                If oeRuta.loMontoRuta.Count > 0 Then
                    For Each monrut As e_MontoRuta In oeRuta.loMontoRuta
                        If monrut.TipoOperacion = "" Then monrut.TipoOperacion = "A"
                        monrut.IdRuta = stResultado(0)
                        monrut.PrefijoID = oeRuta.PrefijoID '@0001
                        odMontoRuta.Guardar(monrut)
                    Next
                End If

                If oeRuta.loZonaD2.Count > 0 Then
                    For Each ZonaD2 As e_ZonaCombustible In oeRuta.loZonaD2
                        ZonaD2.IdRuta = stResultado(0)
                        ZonaD2.PrefijoID = oeRuta.PrefijoID '@0001
                        odZonaCombustible.Guardar(ZonaD2)
                    Next
                End If
                For Each RutaPeaje As e_RutaPeaje In oeRuta.ListaRutaPeaje
                    With RutaPeaje
                        .PrefijoID = oeRuta.PrefijoID '@0001
                        If .TipoOperacion = "E" Then
                            odRutaPeaje.Eliminar(RutaPeaje)
                        Else
                            .TipoOperacion = "I"
                            RutaPeaje.IdRuta = stResultado(0)
                            odRutaPeaje.Guardar(RutaPeaje)
                        End If
                    End With
                Next
                transScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeRuta As e_Ruta) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[STD].[Isp_Ruta_IAE]", _
                                      "E", _
                                      "", _
                                      "", _
                                    oeRuta.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function VerificarAntesEliminar(ByVal oeRuta As e_Ruta) As Integer
        Try
            Dim cant = sqlhelper.ExecuteScalar("[STD].[Isp_Ruta_Verificar]", _
                                    oeRuta.Id)
            Return cant
        Catch ex As Exception
            Throw
            Return 0
        End Try
    End Function

End Class