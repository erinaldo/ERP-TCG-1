Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient


Public Class d_RegistroConsumoCombustible
    Private sqlhelper As New SqlHelper
    Dim oeRegistroInventario As New e_RegistroInventario
    Dim odRegistroInventario As New d_RegistroInventario
    Dim ListaInventarioAjuste As New List(Of e_Inventario)
    Dim odInventario As New d_Inventario
    Dim MaterialAntiguo As String
    Dim Asumar As Double
    Dim Arestar As Double
    Dim oeSubAlmacen As New e_SubAlmacen
    Dim odSubAlmacen As New d_SubAlmacen

    Private Function Cargar(ByVal o_fila As DataRow) As e_RegistroConsumoCombustible
        Try
            Dim oeRegistrarConsumoCombustible = New e_RegistroConsumoCombustible( _
                             o_fila("Id").ToString _
                             , o_fila("IdViaje").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("IdVehiculo").ToString _
                             , o_fila("FechaTanqueo") _
                             , o_fila("CantidadGls").ToString _
                             , o_fila("Kilometraje").ToString _
                             , o_fila("NroVale").ToString _
                             , o_fila("IndiceCredito").ToString _
                             , o_fila("IndiceTanqueo").ToString _
                             , o_fila("IdEmpresaGrifo").ToString _
                             , o_fila("Grifo").ToString _
                             , o_fila("IdLugar").ToString _
                             , o_fila("LugTanqueo").ToString _
                             , o_fila("IdDireccion").ToString _
                             , o_fila("Direccion").ToString _
                             , o_fila("IdMaterial").ToString _
                             , o_fila("SaldoGls").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("IndIsl").ToString _
                             , o_fila("PlacaVeh").ToString _
                             , o_fila("IdRegistroInventario").ToString _
                             , o_fila("IdPiloto").ToString _
                             , o_fila("Piloto").ToString _
                             , o_fila("ValorUnitario").ToString _
                             , o_fila("GlosaValeTanqueo").ToString _
                                )
            Return oeRegistrarConsumoCombustible
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeRegistrarConsumoCombustible As e_RegistroConsumoCombustible) As e_RegistroConsumoCombustible

        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[ALM].[Isp_RegistroConsumoCombustible_Listar]", _
                                          oeRegistrarConsumoCombustible.TipoOperacion, _
                                          oeRegistrarConsumoCombustible.Id, _
                                          oeRegistrarConsumoCombustible.IdVehiculo, _
                                          oeRegistrarConsumoCombustible.FechaTanqueo)
            If ds.Tables(0).Rows.Count > 0 Then
                oeRegistrarConsumoCombustible = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeRegistrarConsumoCombustible
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeRegistrarConsumoCombustible As e_RegistroConsumoCombustible) As List(Of e_RegistroConsumoCombustible)
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ldRegistrarConsumoCombustible As New List(Of e_RegistroConsumoCombustible)
            Dim ds As DataSet
            With oeRegistrarConsumoCombustible
                ds = sqlhelper.ExecuteDataset("[ALM].[Isp_RegistroConsumoCombustible_Listar]", .TipoOperacion _
                        , .Id _
                        , .IdVehiculo _
                        , .FechaTanqueo _
                        , .NroVale _
                        , .IndCredito _
                        , .IndTanqueo _
                        , .IdGrifo _
                        , .IdDireccion _
                        , .UsuarioCreacion _
                        , .fechaInicio _
                        , .fechaFin _
                        , .LOrigen _
                        , .LDestino _
                        , .Pilotos)
            End With
            oeRegistrarConsumoCombustible = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeRegistrarConsumoCombustible = Cargar(o_Fila)
                    ldRegistrarConsumoCombustible.Add(oeRegistrarConsumoCombustible)
                Next
            End If
            Return ldRegistrarConsumoCombustible
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarMasivo(ByVal oeRegistrarConsumoCombustible As e_RegistroConsumoCombustible) As e_RegistroConsumoCombustible
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim stResultado() As String
            Using transScope As New TransactionScope()
                For Each obj As e_RegistroConsumoCombustible In oeRegistrarConsumoCombustible.ListaRegistrosConsumoD2
                    With obj
                        stResultado = sqlhelper.ExecuteScalar("[ALM].[Isp_RegistroConsumoCombustible_IAE]", _
                                                              .TipoOperacion, _
                                                              .PrefijoID, _
                                .Id _
                                , .IdViaje _
                                , .IdVehiculo _
                                , .IdPiloto _
                                , .FechaTanqueo _
                                , .CantidadGalon _
                                , .KilometrosTanqueo _
                                , .NroVale _
                                , .IndCredito _
                                , .IndTanqueo _
                                , .IdGrifo _
                                , .IdDireccion _
                                , .IdMaterial _
                                , .SaldoGls _
                                , .Estado _
                                , .Activo _
                                , .UsuarioCreacion _
                                , .Ind_GastoViaje _
                                , .Glosa _
                                , .CodigoSurtidor _
                                , .IndIsl _
                                , .GlosaValeTanqueo _
                                ).ToString.Split("_")

                        obj.Id = stResultado(0)

                        For Each Inventario As e_Inventario In obj.lstInventario
                            Inventario.oeRegistroInventario.IdRegistroCombustible = obj.Id.Trim
                            odInventario.GuardarInventario(Inventario)
                        Next
                    End With
                Next
                transScope.Complete()
            End Using
            Return oeRegistrarConsumoCombustible
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeRegistrarConsumoCombustible As e_RegistroConsumoCombustible) As e_RegistroConsumoCombustible
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim stResultado() As String
            Using transScope As New TransactionScope()
                With oeRegistrarConsumoCombustible
                    stResultado = sqlhelper.ExecuteScalar("[ALM].[Isp_RegistroConsumoCombustible_IAE]", _
                                                          .TipoOperacion, _
                                                          .PrefijoID, _
                            .Id _
                            , .IdViaje _
                            , .IdVehiculo _
                            , .IdPiloto _
                            , .FechaTanqueo _
                            , .CantidadGalon _
                            , .KilometrosTanqueo _
                            , .NroVale _
                            , .IndCredito _
                            , .IndTanqueo _
                            , .IdGrifo _
                            , .IdDireccion _
                            , .IdMaterial _
                            , .SaldoGls _
                            , .Estado _
                            , .Activo _
                            , .UsuarioCreacion _
                            , .Ind_GastoViaje _
                            , .Glosa _
                            , .CodigoSurtidor _
                            , .IndIsl _
                            , .GlosaValeTanqueo).ToString.Split("_")
                End With
                oeRegistrarConsumoCombustible.Id = stResultado(0)
                For Each Inventario As e_Inventario In oeRegistrarConsumoCombustible.lstInventario
                    Inventario.oeRegistroInventario.IdRegistroCombustible = oeRegistrarConsumoCombustible.Id
                    If Inventario.oeRegistroInventario.IdRegistroCombustible.Trim = "" Then
                        Throw New Exception("Error en Despacho de Combustible. Comunicar a Sistemas.")
                    End If
                    odInventario.GuardarInventario(Inventario)
                Next
                transScope.Complete()
            End Using
            Return oeRegistrarConsumoCombustible
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeRegistrarConsumoCombustible As e_RegistroConsumoCombustible) As Boolean
        Try
            Using transScope As New TransactionScope()
                sqlhelper.ExecuteNonQuery("[ALM].[Isp_RegistroConsumoCombustible_IAE]", "E", "", oeRegistrarConsumoCombustible.Id, _
                                          "", "", "", Date.Parse("01/01/1901"), 0, 0, "", 0, 0, "", "", "", 0, "", 0, _
                                          oeRegistrarConsumoCombustible.UsuarioCreacion, 0, "", "", 0, "")
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDts(ByVal oeRegComb As e_RegistroConsumoCombustible) As DataSet
        Try
            Dim ds As DataSet
            With oeRegComb
                ds = sqlhelper.ExecuteDataset("[ALM].[Isp_RegistroConsumoCombustible_Listar]", _
                                              .TipoOperacion, _
                                              .Id, _
                                              .IdVehiculo, _
                                              .FechaTanqueo, _
                                              .NroVale, _
                                              .IndCredito, _
                                              .IndTanqueo, _
                                              .IdGrifo, _
                                              .IdDireccion, _
                                              .UsuarioCreacion, _
                                              .fechaInicio, _
                                              .fechaFin, _
                                              .LOrigen, _
                                              .LDestino, _
                                              .Pilotos, _
                                              .TipoVehiculos, _
                                              .Flotas, _
                                              .IdMarca, _
                                              .IdModelo, _
                                              .IndTanqueoNoAsoc, _
                                              .IdFlota, _
                                              .IdZona)
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
   
End Class