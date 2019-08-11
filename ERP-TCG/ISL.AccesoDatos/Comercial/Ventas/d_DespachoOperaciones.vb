Imports ISL.EntidadesWCF

Public Class d_DespachoOperaciones
    Private bd As New SqlHelper

    Private Function Cargar(Fila As DataRow) As e_DespachoOperaciones
        Try
            Dim oeDespachoOperaciones = New e_DespachoOperaciones With {
                             .Id = Fila("Id").ToString _
                             , .IdDespacho = Fila("IdDespacho").ToString _
                             , .IdViaje = Fila("IdViaje").ToString _
                             , .Piloto = Fila("Piloto").ToString.Trim _
                             , .Copiloto = Fila("Copiloto").ToString.Trim _
                             , .IdTracto = Fila("IdTracto").ToString _
                             , .Tracto = Fila("Tracto").ToString _
                             , .GlosaN = Fila("GlosaN").ToString _
                             , .Carreta = Fila("Carreta").ToString _
                             , .Zona = Fila("Zona").ToString _
                             , .Origen = Fila("Origen").ToString _
                             , .Destino = Fila("Destino").ToString _
                             , .Estado = Fila("Estado").ToString _
                             , .Cliente = Fila("Cliente").ToString _
                             , .MaterialCarga = Fila("MaterialCarga") _
                             , .Tonelada = Fila("Tonelada") _
                             , .MNTO = Fila("MNTO") _
                             , .Monto = Fila("Monto") _
                             , .ClienteGlosa = Fila("ClienteGlosa").ToString _
                             , .Hora = Fila("Hora") _
                             , .EstadoGlosa = Fila("EstadoGlosa").ToString _
                             , .Disponible = Fila("Disponible").ToString _
                             , .Ocurrencia = Fila("Ocurrencia").ToString _
                             , .Observacion = Fila("Observacion").ToString _
                             , .Glosa = Fila("Glosa").ToString _
                             , .UsuarioCrea = Fila("UsuarioCrea").ToString _
                             , .FechaCrea = Fila("FechaCrea") _
                             , .UsuarioModifica = Fila("UsuarioModifica").ToString _
                             , .FechaModifica = Fila("FechaModifica") _
                             , .Activo = Fila("Activo") _
                             , .NroCelular = Fila("NroCelular").ToString _
                             , .IdMarcaVehiculo = Fila("IdMarcaVehiculo").ToString _
                             , .TipoVehiculoCarreta = Fila("TipoVehiculoCarreta").ToString _
                             , .NroMTC = Fila("NroMTC").ToString _
                             , .NroMTCCarreta = Fila("NroMTCCarreta").ToString _
                             , .Brevete = Fila("Brevete").ToString _
                             , .IndMantenimiento = Fila("IndMantenimiento") _
                             , .IdEscala = Fila("IdEscala").ToString _
                             , .CodigoViajeProg = Fila("CodigoViajeProg").ToString _
                             , .IdTractoProg = Fila("IdTractoProg").ToString _
                             , .IdCarretaProg = Fila("IdCarretaProg").ToString _
                             , .IdPilotoProg = Fila("IdPilotoProg").ToString _
                             , .IdCopilotoProg = Fila("IdCopilotoProg").ToString _
                             , .IdOrigenProg = Fila("IdOrigenProg").ToString _
                             , .IdDestinoProg = Fila("IdDestinoProg").ToString _
                             , .ClienteProg = Fila("ClienteProg").ToString _
                             , .TotalFleteProg = Fila("TotalFleteProg").ToString _
            }
            Return oeDespachoOperaciones
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ExecuteLST(oeDespachoOperaciones As e_DespachoOperaciones) As DataSet
        Try
            Dim ds As DataSet
            With oeDespachoOperaciones
                ds = bd.ExecuteDataset("[OPE].[Isp_DespachoOperaciones_Listar]" _
                        , .TipoOperacion _
                        , .Id _
                        , .IdDespacho _
                        , .IdViaje _
                        , .Piloto _
                        , .Copiloto _
                        , .IdTracto _
                        , .Tracto _
                        , .GlosaN _
                        , .Carreta _
                        , .Zona _
                        , .Origen _
                        , .Destino _
                        , .Estado _
                        , .Cliente _
                        , .MaterialCarga _
                        , .Tonelada _
                        , .MNTO _
                        , .Monto _
                        , .ClienteGlosa _
                        , .Hora _
                        , .EstadoGlosa _
                        , .Disponible _
                        , .Ocurrencia _
                        , .Activo _
                        )
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(oeDespachoOperaciones As e_DespachoOperaciones) As e_DespachoOperaciones
        Try
            Dim ds As DataSet = ExecuteLST(oeDespachoOperaciones)
            If ds.Tables(0).Rows.Count > 0 Then
                If ds.Tables(0).Rows.Count > 1 Then
                    Throw New Exception("Verificar funcion obtener retorna mas de un valor")
                Else
                    oeDespachoOperaciones = Cargar(ds.Tables(0).Rows(0))
                End If
            Else
                oeDespachoOperaciones = New e_DespachoOperaciones
            End If
            Return oeDespachoOperaciones
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oeDespachoOperaciones As e_DespachoOperaciones) As List(Of e_DespachoOperaciones)
        Try
            Dim lstDespachoOperaciones As New List(Of e_DespachoOperaciones)
            Dim ds As DataSet = ExecuteLST(oeDespachoOperaciones)
            oeDespachoOperaciones = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeDespachoOperaciones = Cargar(o_Fila)
                    lstDespachoOperaciones.Add(oeDespachoOperaciones)
                Next
            End If
            Return lstDespachoOperaciones
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(oeDespachoOperaciones As e_DespachoOperaciones) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim IdResultado As String
            With oeDespachoOperaciones
                IdResultado = bd.ExecuteScalar("[OPE].[Isp_DespachoOperaciones_IAE]" _
                        , .TipoOperacion _
                        , d_DatosConfiguracion.PrefijoID _
                        , .Id _
                        , .IdDespacho _
                        , .IdViaje _
                        , .Piloto _
                        , .Copiloto _
                        , .IdTracto _
                        , .Tracto _
                        , .GlosaN _
                        , .Carreta _
                        , .Zona _
                        , .Origen _
                        , .Destino _
                        , .Estado _
                        , .Cliente _
                        , .MaterialCarga _
                        , .Tonelada _
                        , .MNTO _
                        , .Monto _
                        , .ClienteGlosa _
                        , .Hora _
                        , .EstadoGlosa _
                        , .Disponible _
                        , .Ocurrencia _
                        , .Observacion _
                        , .Glosa _
                        , .UsuarioCrea _
                        , .Activo _
                        , .NroCelular _
                        , .IdMarcaVehiculo _
                        , .IndMantenimiento _
                        , .IdEscala
                    ).ToString()
                .Id = IdResultado
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(oeDespachoOperaciones As e_DespachoOperaciones) As Boolean
        Try
            With oeDespachoOperaciones
                bd.ExecuteNonQuery("[OPE].[Isp_DespachoOperaciones_IAE]" _
                       , "E" _
                       , "" _
                       , .Id _
                        , .IdDespacho _
                        , .IdViaje _
                        , .Piloto _
                        , .Copiloto _
                        , .IdTracto _
                        , .Tracto _
                        , .GlosaN _
                        , .Carreta _
                        , .Zona _
                        , .Origen _
                        , .Destino _
                        , .Estado _
                        , .Cliente _
                        , .MaterialCarga _
                        , .Tonelada _
                        , .MNTO _
                        , .Monto _
                        , .ClienteGlosa _
                        , .Hora _
                        , .EstadoGlosa _
                        , .Disponible _
                        , .Ocurrencia _
                        , .Observacion _
                        , .Glosa _
                        , .UsuarioCrea _
                        , .Activo _
                        , .NroCelular _
                        , .IdMarcaVehiculo _
                        , .IndMantenimiento _
                        , .IdEscala
                   )
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
