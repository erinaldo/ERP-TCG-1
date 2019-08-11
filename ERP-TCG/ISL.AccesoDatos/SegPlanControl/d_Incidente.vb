Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_Incidente
    Private sqlhelper As New SqlHelper
    Dim odAreaResponsableEvento As New d_AreaResponsableEvento
    Dim odOperacion As New d_Operacion

    Private Function Cargar(ByVal o_fila As DataRow) As e_Incidente
        Try
            Dim oeIncidente = New e_Incidente()
            oeIncidente.Id = o_fila("Id").ToString.Trim
            oeIncidente.Codigo = o_fila("Codigo").ToString.Trim
            oeIncidente.IdViaje = o_fila("IdViaje").ToString.Trim
            oeIncidente.IdTipoEvento = o_fila("IdTipoEvento").ToString.Trim
            oeIncidente.TipoEvento = o_fila("TipoEvento").ToString.Trim
            oeIncidente.IdTipo = o_fila("IdTipo").ToString.Trim
            oeIncidente.Tipo = o_fila("Tipo").ToString.Trim
            oeIncidente.IdOperador = o_fila("IdOperador").ToString.Trim
            oeIncidente.Operador = o_fila("Operador").ToString.Trim
            oeIncidente.FechaHora = o_fila("Fecha").ToString.Trim
            oeIncidente.Descripcion = o_fila("Descripcion").ToString.Trim
            oeIncidente.IdUbicacion = o_fila("IdUbicacion").ToString.Trim
            oeIncidente.Ubicacion = o_fila("Ubicacion").ToString.Trim
            oeIncidente.ReferenciaLugar = o_fila("ReferenciaLugar").ToString.Trim
            oeIncidente.Observacion = o_fila("Observacion").ToString.Trim
            oeIncidente.Estado = o_fila("Estado").ToString.Trim
            oeIncidente.NombreEstado = o_fila("NombreEstado").ToString.Trim
            oeIncidente.FechaCreacion = o_fila("FechaCreacion").ToString.Trim
            oeIncidente.UsuarioCreacion = o_fila("UsuarioCreacion").ToString.Trim
            oeIncidente.Activo = o_fila("Activo").ToString.Trim
            oeIncidente.FechaModifica = o_fila("FechaModifica").ToString.Trim
            oeIncidente.UsuarioModifica = o_fila("UsuarioModifica").ToString.Trim
            oeIncidente.Identificador = o_fila("Id").ToString.Trim

            Dim objViaje As New e_Viaje
            objViaje.Id = oeIncidente.IdViaje.Trim
            objViaje.TipoOperacion = "0"
            objViaje = odOperacion.ObtenerViaje(objViaje)
            oeIncidente.CodigoViaje = objViaje.Codigo
            oeIncidente.CargaMaterial = objViaje.CargaMaterial
            oeIncidente.Origen = objViaje.Origen
            oeIncidente.Destino = objViaje.Destino
            oeIncidente.Escala = objViaje.Escala
            oeIncidente.Piloto = objViaje.Piloto
            oeIncidente.Copiloto = objViaje.Copiloto
            oeIncidente.Tracto = objViaje.Tracto
            oeIncidente.TipoVehiculo = objViaje.TipoVehiculo
            oeIncidente.Carreta = objViaje.Carreta
            oeIncidente.Fecha = objViaje.Fecha
            oeIncidente.Cliente = objViaje.Cliente
            oeIncidente.PesoToneladas = objViaje.PesoToneladas

            Return oeIncidente
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeIncidente As e_Incidente) As e_Incidente
        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("SPC.Isp_Incidente_Listar", "", oeIncidente.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeIncidente = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeIncidente
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeIncidente As e_Incidente) As List(Of e_Incidente)
        Try
            Dim ldIncidente As New List(Of e_Incidente)
            Dim ds As DataSet
            With oeIncidente
                ds = SqlHelper.ExecuteDataset("SPC.Isp_Incidente_Listar", "" _
                        , .Id _
                        , .Codigo _
                        , .IdViaje _
                        , .IdTipo _
                        , .IdOperador _
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
            oeIncidente = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeIncidente = Cargar(o_Fila)
                ldIncidente.Add(oeIncidente)
            Next
            Return ldIncidente
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeIncidente As e_Incidente) As Boolean
        Try
            Dim stResultado() As String
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeIncidente
                stResultado = sqlhelper.ExecuteScalar("SPC.Isp_Incidente_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .UsuarioCreacion _
                        , .Codigo _
                        , .IdViaje _
                        , .IdTipo _
                        , .IdOperador _
                        , .FechaHora _
                        , .Descripcion _
                        , .IdUbicacion _
                        , .ReferenciaLugar _
                        , .Observacion _
                        , .Estado _
                        , .FechaCreacion _
                        , .Activo _
                        , .FechaModifica _
                        , .UsuarioModifica _
                    ).ToString.Split("_")

                If .leAreaIncidente.Count > 0 Then
                    For Each AreaResponsableEvento As e_AreaResponsableEvento In .leAreaIncidente
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

    Public Function Eliminar(ByVal oeIncidente As e_Incidente) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SPC.Isp_Incidente_IAE", "E", _
             "", oeIncidente.Id, oeIncidente.UsuarioCreacion)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class
