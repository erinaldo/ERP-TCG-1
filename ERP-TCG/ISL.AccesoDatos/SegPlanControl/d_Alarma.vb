Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_Alarma
    Private sqlhelper As New SqlHelper
    Dim odAreaResponsableEvento As New d_AreaResponsableEvento
    Dim odOperacion As New d_Operacion

    Private Function Cargar(ByVal o_fila As DataRow) As e_Alarma
        Try
            Dim oeAlarma = New e_Alarma()
            oeAlarma.Id = o_fila("Id").ToString.Trim
            oeAlarma.Codigo = o_fila("Codigo").ToString.Trim
            oeAlarma.IdViaje = o_fila("IdViaje").ToString.Trim
            oeAlarma.IdTipoEvento = o_fila("IdTipoEvento").ToString.Trim
            oeAlarma.TipoEvento = o_fila("TipoEvento").ToString.Trim
            oeAlarma.IdTipo = o_fila("IdTipo").ToString.Trim
            oeAlarma.Tipo = o_fila("Tipo").ToString.Trim
            oeAlarma.IdOperador = o_fila("IdOperador").ToString.Trim
            oeAlarma.Operador = o_fila("Operador").ToString.Trim
            oeAlarma.FechaHora = o_fila("Fecha").ToString.Trim
            oeAlarma.Descripcion = o_fila("Descripcion").ToString.Trim
            oeAlarma.IdUbicacion = o_fila("IdUbicacion").ToString.Trim
            oeAlarma.Ubicacion = o_fila("Ubicacion").ToString.Trim
            oeAlarma.ReferenciaLugar = o_fila("ReferenciaLugar").ToString.Trim
            oeAlarma.Observacion = o_fila("Observacion").ToString.Trim
            oeAlarma.Estado = o_fila("Estado").ToString.Trim
            oeAlarma.NombreEstado = o_fila("NombreEstado").ToString.Trim
            oeAlarma.FechaCreacion = o_fila("FechaCreacion").ToString.Trim
            oeAlarma.UsuarioCreacion = o_fila("UsuarioCreacion").ToString.Trim
            oeAlarma.Activo = o_fila("Activo").ToString.Trim
            oeAlarma.FechaModifica = o_fila("FechaModifica").ToString.Trim
            oeAlarma.UsuarioModifica = o_fila("UsuarioModifica").ToString.Trim
            oeAlarma.Identificador = o_fila("Id").ToString.Trim

            Dim objViaje As New e_Viaje
            objViaje.Id = oeAlarma.IdViaje.Trim
            objViaje.TipoOperacion = "0"
            objViaje = odOperacion.ObtenerViaje(objViaje)
            oeAlarma.CodigoViaje = objViaje.Codigo
            oeAlarma.CargaMaterial = objViaje.CargaMaterial
            oeAlarma.Origen = objViaje.Origen
            oeAlarma.Destino = objViaje.Destino
            oeAlarma.Escala = objViaje.Escala
            oeAlarma.Piloto = objViaje.Piloto
            oeAlarma.Copiloto = objViaje.Copiloto
            oeAlarma.Tracto = objViaje.Tracto
            oeAlarma.TipoVehiculo = objViaje.TipoVehiculo
            oeAlarma.Carreta = objViaje.Carreta
            oeAlarma.Fecha = objViaje.Fecha
            oeAlarma.Cliente = objViaje.Cliente
            oeAlarma.PesoToneladas = objViaje.PesoToneladas

            Return oeAlarma
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeAlarma As e_Alarma) As e_Alarma
        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("SPC.Isp_Alarma_Listar", "", oeAlarma.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeAlarma = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeAlarma
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeAlarma As e_Alarma) As List(Of e_Alarma)
        Try
            Dim ldAlarma As New List(Of e_Alarma)
            Dim ds As DataSet
            With oeAlarma
                ds = sqlhelper.ExecuteDataset("SPC.Isp_Alarma_Listar", "" _
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
            oeAlarma = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeAlarma = Cargar(o_Fila)
                ldAlarma.Add(oeAlarma)
            Next
            Return ldAlarma
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeAlarma As e_Alarma) As Boolean
        Try
            Dim stResultado() As String
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeAlarma
                stResultado = sqlhelper.ExecuteScalar("SPC.Isp_Alarma_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
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
                        , .UsuarioCreacion _
                        , .Activo _
                        , .FechaModifica _
                        , .UsuarioModifica _
                    ).ToString.Split("_")

                If .leAreaAlarma.Count > 0 Then
                    For Each AreaResponsableEvento As e_AreaResponsableEvento In .leAreaAlarma
                        AreaResponsableEvento.IdEvento = stResultado(0)
                        AreaResponsableEvento.IdTipoEvento = oeAlarma.IdTipoEvento.Trim
                        AreaResponsableEvento.TipoOperacion = oeAlarma.TipoOperacion.Trim
                        AreaResponsableEvento.UsuarioCreacion = oeAlarma.UsuarioCreacion.Trim
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

    Public Function Eliminar(ByVal oeAlarma As e_Alarma) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SPC.Isp_Alarma_IAE", "E", _
             "", oeAlarma.Id, "", "", "", "", Date.Now, "", "", "", "", "", Date.Now, oeAlarma.UsuarioCreacion)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class
