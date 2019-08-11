Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_AccidenteIncidencia
    Private sqlhelper As New SqlHelper
    Dim odAreaResponsableEvento As New d_AreaResponsableEvento
    Dim odOperacion As New d_Operacion

    Private Function Cargar(ByVal o_fila As DataRow) As e_AccidenteIncidencia
        Try
            Dim oeAccidenteIncidencia = New e_AccidenteIncidencia()
            oeAccidenteIncidencia.Id = o_fila("Id").ToString.Trim
            oeAccidenteIncidencia.Codigo = o_fila("Codigo").ToString.Trim
            oeAccidenteIncidencia.IdViaje = o_fila("IdViaje").ToString.Trim
            oeAccidenteIncidencia.IdTipoEvento = o_fila("IdTipoEvento").ToString.Trim
            oeAccidenteIncidencia.TipoEvento = o_fila("TipoEvento").ToString.Trim
            oeAccidenteIncidencia.IdTipo = o_fila("IdTipo").ToString.Trim
            oeAccidenteIncidencia.Tipo = o_fila("Tipo").ToString.Trim
            oeAccidenteIncidencia.IdOperador = o_fila("IdOperador").ToString.Trim
            oeAccidenteIncidencia.Operador = o_fila("Operador").ToString.Trim
            oeAccidenteIncidencia.FechaHora = o_fila("Fecha").ToString.Trim
            oeAccidenteIncidencia.Descripcion = o_fila("Descripcion").ToString.Trim
            oeAccidenteIncidencia.IdUbicacion = o_fila("IdUbicacion").ToString.Trim
            oeAccidenteIncidencia.Ubicacion = o_fila("Ubicacion").ToString.Trim
            oeAccidenteIncidencia.ReferenciaLugar = o_fila("ReferenciaLugar").ToString.Trim
            oeAccidenteIncidencia.Denuncia = o_fila("Denuncia").ToString.Trim
            oeAccidenteIncidencia.FechaHoraDenuncia = o_fila("FechaDenuncia").ToString.Trim
            oeAccidenteIncidencia.Dosaje = o_fila("Dosaje").ToString.Trim
            oeAccidenteIncidencia.FechaHoraDosaje = o_fila("FechaDosaje").ToString.Trim
            oeAccidenteIncidencia.Observacion = o_fila("Observacion").ToString.Trim
            oeAccidenteIncidencia.Estado = o_fila("Estado").ToString.Trim
            oeAccidenteIncidencia.NombreEstado = o_fila("NombreEstado").ToString.Trim
            oeAccidenteIncidencia.FechaCreacion = o_fila("FechaCreacion").ToString.Trim
            oeAccidenteIncidencia.UsuarioCreacion = o_fila("UsuarioCreacion").ToString.Trim
            oeAccidenteIncidencia.Activo = o_fila("Activo").ToString.Trim
            oeAccidenteIncidencia.FechaModifica = o_fila("FechaModifica").ToString.Trim
            oeAccidenteIncidencia.UsuarioModifica = o_fila("UsuarioModifica").ToString.Trim
            oeAccidenteIncidencia.Identificador = o_fila("Id").ToString.Trim

            Dim objViaje As New e_Viaje
            objViaje.Id = oeAccidenteIncidencia.IdViaje.Trim
            objViaje.TipoOperacion = "0"
            objViaje = odOperacion.ObtenerViaje(objViaje)
            oeAccidenteIncidencia.CodigoViaje = objViaje.Codigo
            oeAccidenteIncidencia.CargaMaterial = objViaje.CargaMaterial
            oeAccidenteIncidencia.Origen = objViaje.Origen
            oeAccidenteIncidencia.Destino = objViaje.Destino
            oeAccidenteIncidencia.Escala = objViaje.Escala
            oeAccidenteIncidencia.Piloto = objViaje.Piloto
            oeAccidenteIncidencia.Copiloto = objViaje.Copiloto
            oeAccidenteIncidencia.Tracto = objViaje.Tracto
            oeAccidenteIncidencia.TipoVehiculo = objViaje.TipoVehiculo
            oeAccidenteIncidencia.Carreta = objViaje.Carreta
            oeAccidenteIncidencia.Fecha = objViaje.Fecha
            oeAccidenteIncidencia.Cliente = objViaje.Cliente
            oeAccidenteIncidencia.PesoToneladas = objViaje.PesoToneladas

            Return oeAccidenteIncidencia
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeAccidenteIncidencia As e_AccidenteIncidencia) As e_AccidenteIncidencia
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("SPC.Isp_AccidenteIncidencia_Listar", oeAccidenteIncidencia.TipoOperacion, oeAccidenteIncidencia.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeAccidenteIncidencia = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeAccidenteIncidencia
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeAccidenteIncidencia As e_AccidenteIncidencia) As List(Of e_AccidenteIncidencia)
        Try
            Dim ldAccidenteIncidencia As New List(Of e_AccidenteIncidencia)
            Dim ds As DataSet
            With oeAccidenteIncidencia
                ds = sqlhelper.ExecuteDataset("SPC.Isp_AccidenteIncidencia_Listar", "" _
                        , .Id _
                        , .Codigo _
                        , .IdViaje _
                        , .IdTipo _
                        , .IdOperador _
                        , .Denuncia _
                        , .Dosaje _
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
            oeAccidenteIncidencia = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeAccidenteIncidencia = Cargar(o_Fila)
                ldAccidenteIncidencia.Add(oeAccidenteIncidencia)
            Next
            Return ldAccidenteIncidencia
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeAccidenteIncidencia As e_AccidenteIncidencia) As Boolean
        Try
            Dim stResultado() As String
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeAccidenteIncidencia
                stResultado = sqlhelper.ExecuteScalar("SPC.Isp_AccidenteIncidencia_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .UsuarioCreacion _
                        , .Codigo _
                        , .IdViaje _
                        , .FechaHora _
                        , .IdTipo _
                        , .IdOperador _
                        , .Denuncia _
                        , .FechaHoraDenuncia _
                        , .Dosaje _
                        , .FechaHoraDosaje _
                        , .Descripcion _
                        , .IdUbicacion _
                        , .ReferenciaLugar _
                        , .Observacion _
                        , .Estado _
                        , .Activo _
                    ).ToString.Split("_")

                If .leAreaAccidente.Count > 0 Then
                    For Each AreaResponsableEvento As e_AreaResponsableEvento In .leAreaAccidente
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

    Public Function Eliminar(ByVal oeAccidenteIncidencia As e_AccidenteIncidencia) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SPC.Isp_AccidenteIncidencia_IAE", "E", _
             "", oeAccidenteIncidencia.Id, oeAccidenteIncidencia.UsuarioCreacion)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
