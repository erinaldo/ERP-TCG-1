Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_IncidenciaMaestro
    Private sqlhelper As New SqlHelper
    Private odAlarma As New d_Alarma
    Private odAreaResponsableEvento As New d_AreaResponsableEvento
    Private odAccidenteIncidencia As New d_AccidenteIncidencia
    Private odIncidente As New d_Incidente
    Private odRobo As New d_Robo
    Private oeEncargadoSeguimiento As New d_EncargadoSeguimiento

    Private Function Cargar(ByVal o_fila As DataRow) As e_IncidenciaMaestro
        Try
            Dim oeIncidenciaMaestro = New e_IncidenciaMaestro( _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("IdGradoIncidencia").ToString _
                             , o_fila("IdOperacion").ToString _
                             , o_fila("IdViaje").ToString _
                             , o_fila("IdPrioridad").ToString _
                             , o_fila("IdResponsable").ToString _
                             , o_fila("FechaHora").ToString _
                             , o_fila("Asunto").ToString _
                             , o_fila("Mensaje").ToString _
                             , o_fila("ClienteExterno").ToString _
                             , o_fila("EmpleadoExterno").ToString _
                             , o_fila("EstadoIncidencia").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("FechaModifica").ToString _
                             , o_fila("UsuarioModifica").ToString _
            )
            Return oeIncidenciaMaestro
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeIncidenciaMaestro As e_IncidenciaMaestro) As e_IncidenciaMaestro

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("SPC.Isp_IncidenciaMaestro_Listar", "", oeIncidenciaMaestro.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeIncidenciaMaestro = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeIncidenciaMaestro
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeIncidenciaMaestro As e_IncidenciaMaestro) As List(Of e_IncidenciaMaestro)
        Try
            Dim ldIncidenciaMaestro As New List(Of e_IncidenciaMaestro)
            Dim ds As DataSet
            With oeIncidenciaMaestro
                ds = sqlhelper.ExecuteDataset("SPC.Isp_IncidenciaMaestro_Listar", "" _
                         , .Id _
                        , .Codigo _
                        , .IdGradoIncidencia _
                        , .IdOperacion _
                        , .IdViaje _
                        , .IdPrioridad _
                        , .IdResponsable _
                        , .FechaHora _
                        , .Asunto _
                        , .Mensaje _
                        , .ClienteExterno _
                        , .EmpleadoExterno _
                        , .EstadoIncidencia _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        )
            End With
            oeIncidenciaMaestro = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeIncidenciaMaestro = Cargar(o_Fila)
                ldIncidenciaMaestro.Add(oeIncidenciaMaestro)
            Next
            Return ldIncidenciaMaestro
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeIncidenciaMaestro As e_IncidenciaMaestro) As Boolean
        'Dim stResultado() As String
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Using transScope As New TransactionScope()
                'With oeIncidenciaMaestro
                '    stResultado = sqlhelper.ExecuteScalar("SPC.Isp_IncidenciaMaestro_IAE", .TipoOperacion, .PrefijoID, _
                '            .Id _
                '            , .Codigo _
                '            , .IdGradoIncidencia _
                '            , .IdOperacion _
                '            , .IdViaje _
                '            , .IdPrioridad _
                '            , .IdResponsable _
                '            , .FechaHora _
                '            , .Asunto _
                '            , .Mensaje _
                '            , .ClienteExterno _
                '            , .EmpleadoExterno _
                '            , .EstadoIncidencia _
                '            , .FechaCreacion _
                '            , .UsuarioCreacion _
                '            , .Activo _
                '            , .FechaModifica _
                '            , .UsuarioModifica _
                '        ).ToString.Split("_")
                'End With

                Dim oeAlarma As New e_Alarma
                oeAlarma.TipoOperacion = "U"
                oeAlarma.Id = ""
                oeAlarma.Codigo = ""
                oeAlarma.IdTipo = ""
                oeAlarma.IdOperador = ""
                oeAlarma.Descripcion = ""
                oeAlarma.IdUbicacion = ""
                oeAlarma.ReferenciaLugar = ""
                oeAlarma.Observacion = ""
                oeAlarma.UsuarioModifica = ""
                oeAlarma.IdViaje = oeIncidenciaMaestro.IdViaje
                oeAlarma.FechaCreacion = Date.Now
                oeAlarma.FechaHora = Date.Now
                oeAlarma.FechaModifica = Date.Now
                oeAlarma.leAreaAlarma = New List(Of e_AreaResponsableEvento)
                oeAlarma.UsuarioCreacion = oeIncidenciaMaestro.UsuarioCreacion.Trim
                odAlarma.Guardar(oeAlarma)

                Dim oeAccidente As New e_AccidenteIncidencia
                oeAccidente.TipoOperacion = "U"
                'oeAccidente.Id = ""
                'oeAlarma.Codigo = ""
                'oeAlarma.IdTipo = ""
                'oeAlarma.IdOperador = ""
                'oeAlarma.Descripcion = ""
                'oeAlarma.IdUbicacion = ""
                'oeAlarma.ReferenciaLugar = ""
                'oeAlarma.Observacion = ""
                'oeAlarma.UsuarioModifica = ""
                oeAccidente.IdViaje = oeIncidenciaMaestro.IdViaje
                oeAccidente.FechaHoraDenuncia = Date.Now
                oeAccidente.FechaHoraDosaje = Date.Now
                oeAccidente.FechaCreacion = Date.Now
                oeAccidente.FechaHora = Date.Now
                oeAccidente.FechaModifica = Date.Now
                oeAccidente.leAreaAccidente = New List(Of e_AreaResponsableEvento)
                oeAccidente.UsuarioCreacion = oeIncidenciaMaestro.UsuarioCreacion.Trim
                odAccidenteIncidencia.Guardar(oeAccidente)

                Dim oeIncidente As New e_Incidente
                oeIncidente.TipoOperacion = "U"
                'oeAccidente.Id = ""
                'oeAlarma.Codigo = ""
                'oeAlarma.IdTipo = ""
                'oeAlarma.IdOperador = ""
                'oeAlarma.Descripcion = ""
                'oeAlarma.IdUbicacion = ""
                'oeAlarma.ReferenciaLugar = ""
                'oeAlarma.Observacion = ""
                'oeAlarma.UsuarioModifica = ""
                oeIncidente.IdViaje = oeIncidenciaMaestro.IdViaje
                oeIncidente.FechaCreacion = Date.Now
                oeIncidente.FechaHora = Date.Now
                oeIncidente.FechaModifica = Date.Now
                oeIncidente.leAreaIncidente = New List(Of e_AreaResponsableEvento)
                oeIncidente.UsuarioCreacion = oeIncidenciaMaestro.UsuarioCreacion.Trim
                odIncidente.Guardar(oeIncidente)

                Dim oeRobo As New e_Robo
                oeRobo.TipoOperacion = "U"
                'oeAccidente.Id = ""
                'oeAlarma.Codigo = ""
                'oeAlarma.IdTipo = ""
                'oeAlarma.IdOperador = ""
                'oeAlarma.Descripcion = ""
                'oeAlarma.IdUbicacion = ""
                'oeAlarma.ReferenciaLugar = ""
                'oeAlarma.Observacion = ""
                'oeAlarma.UsuarioModifica = ""
                oeRobo.IdViaje = oeIncidenciaMaestro.IdViaje
                oeRobo.FechaHoraDenuncia = Date.Now
                oeRobo.FechaCreacion = Date.Now
                oeRobo.FechaHora = Date.Now
                oeRobo.FechaModifica = Date.Now
                oeRobo.leAreaRobo = New List(Of e_AreaResponsableEvento)
                oeRobo.UsuarioCreacion = oeIncidenciaMaestro.UsuarioCreacion.Trim
                odRobo.Guardar(oeRobo)

                If oeIncidenciaMaestro.lstAlarma.Count > 0 Then
                    For Each Alarma As e_Alarma In oeIncidenciaMaestro.lstAlarma
                        Alarma.IdViaje = oeIncidenciaMaestro.IdViaje
                        Alarma.UsuarioCreacion = oeIncidenciaMaestro.UsuarioCreacion.Trim
                        Alarma.TipoOperacion = oeIncidenciaMaestro.TipoOperacion
                        odAlarma.Guardar(Alarma)
                    Next
                End If

                If oeIncidenciaMaestro.lstAccidente.Count > 0 Then
                    For Each Accidente As e_AccidenteIncidencia In oeIncidenciaMaestro.lstAccidente
                        Accidente.IdViaje = oeIncidenciaMaestro.IdViaje
                        Accidente.UsuarioCreacion = oeIncidenciaMaestro.UsuarioCreacion.Trim
                        Accidente.TipoOperacion = oeIncidenciaMaestro.TipoOperacion
                        odAccidenteIncidencia.Guardar(Accidente)
                    Next
                End If

                If oeIncidenciaMaestro.lstIncidente.Count > 0 Then
                    For Each Incidente As e_Incidente In oeIncidenciaMaestro.lstIncidente
                        Incidente.IdViaje = oeIncidenciaMaestro.IdViaje
                        Incidente.UsuarioCreacion = oeIncidenciaMaestro.UsuarioCreacion.Trim
                        Incidente.TipoOperacion = oeIncidenciaMaestro.TipoOperacion
                        odIncidente.Guardar(Incidente)
                    Next
                End If

                If oeIncidenciaMaestro.lstRobo.Count > 0 Then
                    For Each Robo As e_Robo In oeIncidenciaMaestro.lstRobo
                        Robo.IdViaje = oeIncidenciaMaestro.IdViaje
                        Robo.UsuarioCreacion = oeIncidenciaMaestro.UsuarioCreacion.Trim
                        Robo.TipoOperacion = oeIncidenciaMaestro.TipoOperacion
                        odRobo.Guardar(Robo)
                    Next
                End If

                

                ''If oeIncidenciaMaestro.oeRobo.Count > 0 Then
                ''    For Each Robo As e_Robo In oeIncidenciaMaestro.oeRobo
                ''        Robo.IdIncidencia = stResultado(0)
                ''        odRobo.Guardar(Robo)
                ''    Next
                ''End If

                ''If oeIncidenciaMaestro.oeEncargadoSeguimiento.Count > 0 Then
                ''    For Each Encargado As e_EncargadoSeguimiento In oeIncidenciaMaestro.oeEncargadoSeguimiento
                ''        Encargado.IdIncidencia = stResultado(0)
                ''        oeEncargadoSeguimiento.Guardar(Encargado)
                ''    Next
                ''End If

                transScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeIncidenciaMaestro As e_IncidenciaMaestro) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SPC.Isp_IncidenciaMaestro_IAE", "E", _
             "", oeIncidenciaMaestro.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class
