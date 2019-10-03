Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_Robo
    Private sqlhelper As New SqlHelper
    Dim odAreaResponsableEvento As New d_AreaResponsableEvento
    Dim odOperacion As New d_Operacion

    Private Function Cargar(ByVal o_fila As DataRow) As e_Robo
        Try
            Dim oeRobo = New e_Robo()
            oeRobo.Id = o_fila("Id").ToString.Trim
            oeRobo.Codigo = o_fila("Codigo").ToString.Trim
            oeRobo.IdViaje = o_fila("IdViaje").ToString.Trim
            oeRobo.IdTipoEvento = o_fila("IdTipoEvento").ToString.Trim
            oeRobo.TipoEvento = o_fila("TipoEvento").ToString.Trim
            oeRobo.IdTipo = o_fila("IdTipo").ToString.Trim
            oeRobo.Tipo = o_fila("Tipo").ToString.Trim
            oeRobo.IdOperador = o_fila("IdOperador").ToString.Trim
            oeRobo.Operador = o_fila("Operador").ToString.Trim
            oeRobo.FechaHora = o_fila("Fecha").ToString.Trim
            oeRobo.Descripcion = o_fila("Descripcion").ToString.Trim
            oeRobo.IdUbicacion = o_fila("IdUbicacion").ToString.Trim
            oeRobo.Ubicacion = o_fila("Ubicacion").ToString.Trim
            oeRobo.ReferenciaLugar = o_fila("ReferenciaLugar").ToString.Trim
            oeRobo.Denuncia = o_fila("Denuncia").ToString.Trim
            oeRobo.FechaHoraDenuncia = o_fila("FechaDenuncia").ToString.Trim
            oeRobo.Observacion = o_fila("Observacion").ToString.Trim
            oeRobo.Estado = o_fila("Estado").ToString.Trim
            oeRobo.NombreEstado = o_fila("NombreEstado").ToString.Trim
            oeRobo.FechaCreacion = o_fila("FechaCreacion").ToString.Trim
            oeRobo.UsuarioCreacion = o_fila("UsuarioCreacion").ToString.Trim
            oeRobo.Activo = o_fila("Activo").ToString.Trim
            oeRobo.FechaModifica = o_fila("FechaModifica").ToString.Trim
            oeRobo.UsuarioModifica = o_fila("UsuarioModifica").ToString.Trim
            oeRobo.Identificador = o_fila("Id").ToString.Trim

            Dim objViaje As New e_Viaje
            objViaje.Id = oeRobo.IdViaje.Trim
            objViaje.TipoOperacion = "0"
            objViaje = odOperacion.ObtenerViaje(objViaje)
            oeRobo.CodigoViaje = objViaje.Codigo
            oeRobo.CargaMaterial = objViaje.CargaMaterial
            oeRobo.Origen = objViaje.Origen
            oeRobo.Destino = objViaje.Destino
            oeRobo.Escala = objViaje.Escala
            oeRobo.Piloto = objViaje.Piloto
            oeRobo.Copiloto = objViaje.Copiloto
            oeRobo.Tracto = objViaje.Tracto
            oeRobo.TipoVehiculo = objViaje.TipoVehiculo
            oeRobo.Carreta = objViaje.Carreta
            oeRobo.Fecha = objViaje.Fecha
            oeRobo.Cliente = objViaje.Cliente
            oeRobo.PesoToneladas = objViaje.PesoToneladas

            Return oeRobo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeRobo As e_Robo) As e_Robo
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("SPC.Isp_Robo_Listar", oeRobo.TipoOperacion, oeRobo.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeRobo = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeRobo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeRobo As e_Robo) As List(Of e_Robo)
        Try
            Dim listaRobo As New List(Of e_Robo)
            Dim ds As DataSet
            With oeRobo
                ds = sqlhelper.ExecuteDataset("SPC.Isp_Robo_Listar", "" _
                        , .Id _
                        , .Codigo _
                        , .IdViaje _
                        , .IdTipo _
                        , .IdOperador _
                        , .Denuncia _
                        , .Descripcion _
                        , .IdUbicacion _
                        , .ReferenciaLugar _
                        , .Estado _
                        , .UsuarioCreacion _
                        , .Activo _
                        , .UsuarioModifica _
                        , .FechaDesde _
                        , .FechaHasta _
                        )
            End With
            oeRobo = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeRobo = Cargar(o_Fila)
                listaRobo.Add(oeRobo)
            Next
            Return listaRobo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeRobo As e_Robo) As Boolean
        Try
            Dim stResultado() As String
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeRobo
                stResultado = sqlhelper.ExecuteScalar("SPC.Isp_Robo_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .UsuarioCreacion _
                        , .Codigo _
                        , .IdViaje _
                        , .FechaHora _
                        , .IdTipo _
                        , .IdOperador _
                        , .Denuncia _
                        , .FechaHoraDenuncia _
                        , .Descripcion _
                        , .IdUbicacion _
                        , .ReferenciaLugar _
                        , .Observacion _
                        , .Estado _
                        , .Activo _
                    ).ToString.Split("_")

                If .leAreaRobo.Count > 0 Then
                    For Each AreaResponsableEvento As e_AreaResponsableEvento In .leAreaRobo
                        AreaResponsableEvento.IdEvento = stResultado(0)
                        AreaResponsableEvento.IdTipoEvento = .IdTipoEvento.Trim
                        AreaResponsableEvento.TipoOperacion = .TipoOperacion.Trim
                        AreaResponsableEvento.UsuarioCreacion = .UsuarioCreacion.Trim
                        odAreaResponsableEvento.Guardar(AreaResponsableEvento)
                    Next
                End If
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeRobo As e_Robo) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SPC.Isp_Robo_IAE", "E", _
             "", oeRobo.Id, oeRobo.UsuarioCreacion)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class
